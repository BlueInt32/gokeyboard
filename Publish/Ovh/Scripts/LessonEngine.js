var LessonEngine = function ()
{
    var self = this;

    self.activePage = null;
    self.activeItem = null;
    self.activeKeyboardHelperKey = null;
    self.timer = new Timer();
    self.seconds = 0;
    self.lastKeypressTiming = 0;
    self.soundManager = new Sound();
    self.sounds = null;
    self.score = 0;
    self.level = 0;
    self.levelStep = 35; // every time score gets beyond (or under) a multiple of this value, the level increases
    self.levelColors = ["#ffc600", "#f0ff00", "#d2ff00", "#a8ff00", "#60ff00", "00da1f", "0096ff"];
    self.globalCharIndex = 0; // this is the index of the current character to type in the entire lesson.
    self.lastErrorIndex = -1; // this is the index of the last character where a mistake was made. Lets us not take into account multiple mistakes on a single character.
    self.errors = new Array();
    self.errorCount = 0;
    self.totalCharsAmount = 0;
    

    self.mistakeMalus = 30; // value decremented from score when a mistake is made
    self.idleMalus = 5; // value decremented from score every second when user is idle

    this.Init = function ()
    {
        self.activePage = $(".page").hide().first().show().addClass("activePage");
        self.activeItem = $(".activePage span").first().addClass("activeItem");
        self.globalCharIndex = self.activeItem.attr("data-index");
        self.activeKeyboardHelperKey = $(".key_" + self.activeItem.html()).addClass("current");
        self.soundManager.Init(self.sounds);

        $(window).keypress(self.KeypressHandler);
    };

    this.KeypressHandler = function (e)
    {
        e.preventDefault();
        self.lastKeypressTiming = self.seconds;
        if (!self.timer.on)
        {
            self.timer.Start(1000, self.OneSecondElapsedHandler);
        }
        if (e.which == self.activeItem.attr("rel"))
        {
            self.RightKeyTyped();
        }
        else
        {
            self.WrongKeyTyped();
        }
        self.UpdateBonusState();
        self.prepareChart();
    };

    this.OneSecondElapsedHandler = function ()
    {
        $("#timer").html(self.timer.Output());
        $('.infinite').val(self.seconds).trigger('change');
        self.seconds++;
        if (self.seconds - self.lastKeypressTiming > 3 || self.lastErrorIndex == self.globalCharIndex)
        {
            self.score = (self.score - self.idleMalus < 0) ? 0 : self.score - self.idleMalus;
            $('.bonus').val(self.score).trigger('change');
        }
    };

    this.RightKeyTyped = function()
    {
        self.score++;
        self.activeItem.removeClass("activeItem").removeClass("error");
        self.activeItem = self.activeItem.nextAll("span").first();
        self.globalCharIndex = self.activeItem.attr("data-index");

        //soundManager.PlayRandomSoundStartingWith("n");
        if (self.activeItem.length == 0)
        {
            // change page !

            self.activePage = $(".activePage").removeClass("activePage").hide().next(".page").addClass("activePage").show();
            if (self.activePage.length == 0)
            {
                // End lesson !
                self.soundManager.Play("win");
                var time = self.timer.Stop();
                $(".endpage").show();
                $("#totalErrorCount").text(self.errorCount);
                $("#timeSpent").text(self.seconds);
                $("#keyboardhelper").hide();

                var charsTyped = self.totalCharsAmount;
                var charsTypedPerMinute = Number((self.totalCharsAmount / self.seconds * 60).toFixed(1));
                $("#charsTyped").text(charsTyped);
                $("#charsTypedPerMinute").text(charsTypedPerMinute);
            }
            self.activeItem = $(".activePage span").first().addClass("activeItem");
            return;
        }
        self.activeKeyboardHelperKey.removeClass("current");
        self.activeKeyboardHelperKey = $(".key_" + self.activeItem.html().replace("&nbsp;", "spacebar"));
        self.activeKeyboardHelperKey.addClass("current");

        self.activeItem.addClass("activeItem");
    }

    this.WrongKeyTyped = function()
    {
        if (self.globalCharIndex != self.lastErrorIndex)
        {
            self.score = (self.score - self.mistakeMalus < 0) ? 0 : self.score - self.mistakeMalus;
            self.activeItem.addClass("error");
            self.soundManager.Play("miss");
            self.errorCount++;
            $("#errorCount").text(self.errorCount);
            
            self.errors.push(self.activeItem.html());

        }
        self.lastErrorIndex = self.globalCharIndex;
    }

    this.UpdateBonusState = function()
    {
        var bonusWheel = $('.bonus');
        bonusWheel.val(self.score).trigger('change');

        var recomputedBonusLevel = Math.floor(self.score / self.levelStep);
        if (self.level != recomputedBonusLevel)
        {
            if (recomputedBonusLevel > self.levelColors.length - 1) recomputedBonusLevel = self.levelColors.length - 1;
            bonusWheel.trigger('configure', { "fgColor": self.levelColors[recomputedBonusLevel] });
            self.level = recomputedBonusLevel;
        }
    }

    this.prepareChart = function()
    {
        var graphData = new Array();
        var finalGraphData = new Array();
        for (var i = 0; i < self.errors.length; i++)
        {
            if(graphData[self.errors[i]] == null)
            {
                graphData[self.errors[i]] = 1;
            }
            else
            {
                graphData[self.errors[i]] = graphData[self.errors[i]] + 1;
            }
        }
        for (var key in graphData)
        {
            finalGraphData.push([key, graphData[key]]);
        }
        console.log(finalGraphData);
        //var finalGraphData = [["January", 10], ["February", 8], ["March", 4], ["April", 13], ["May", 17], ["June", 9]];

        $.plot("#chartplaceholder", [{ data: finalGraphData, color: "#F00" }], {
            series: {
                bars: {
                    show: true,
                    barWidth: 0.6,
                    align: "center",
                    color: "red",
                    fill: 0.5
                }
            },
            xaxis: {
                mode: "categories",
                tickLength: 0
            },
            yaxis: { tickSize: 1, tickDecimals: 0 }
        });
    }
}