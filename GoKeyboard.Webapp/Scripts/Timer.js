var Timer = function ()
{
	var self = this;

	this.output = null;
	this.startDate = null;
	this.on = false;
	this.refreshIntervalId = null;
	this.tickAction = null;

	this.Elapsed = function ()
	{
		var now = Date.now();
		return now - self.startDate;
	}

	this.Start = function (tickInMs, callback)
	{
		self.startDate = Date.now();
		self.on = true;

		if ('undefined' == typeof callback)
			self.tickAction = function () { };
		self.tickAction = callback;
		self.tickAction.call(null);

		self.refreshIntervalId = window.setInterval(function ()
		{
			self.tickAction.call(null);
		}, 1000);
	}

	this.Stop = function ()
	{
		clearInterval(self.refreshIntervalId);
		self.on = false;
		return this.Output();
	}

	this.Output = function ()
	{
		var h = self.Elapsed();
		var elapsedStr = new Date(h - 3600000);
		var test = elapsedStr.customFormat("#hhh#:#mm#:#ss#")
		return test;
	};
};
Date.prototype.customFormat = function (formatString)
{
	var YYYY, YY, MMMM, MMM, MM, M, DDDD, DDD, DD, D, hhh, hh, h, mm, m, ss, s, ampm, AMPM, dMod, th;
	var dateObject = this;
	YY = ((YYYY = dateObject.getFullYear()) + "").slice(-2);
	MM = (M = dateObject.getMonth() + 1) < 10 ? ('0' + M) : M;
	MMM = (MMMM = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"][M - 1]).substring(0, 3);
	DD = (D = dateObject.getDate()) < 10 ? ('0' + D) : D;
	DDD = (DDDD = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"][dateObject.getDay()]).substring(0, 3);
	th = (D >= 10 && D <= 20) ? 'th' : ((dMod = D % 10) == 1) ? 'st' : (dMod == 2) ? 'nd' : (dMod == 3) ? 'rd' : 'th';
	formatString = formatString.replace("#YYYY#", YYYY).replace("#YY#", YY).replace("#MMMM#", MMMM).replace("#MMM#", MMM).replace("#MM#", MM).replace("#M#", M).replace("#DDDD#", DDDD).replace("#DDD#", DDD).replace("#DD#", DD).replace("#D#", D).replace("#th#", th);

	h = (hhh = dateObject.getHours());
	if (h == 0) h = 24;
	if (h > 12) h -= 12;
	hh = h < 10 ? ('0' + h) : h;
	AMPM = (ampm = hhh < 12 ? 'am' : 'pm').toUpperCase();
	mm = (m = dateObject.getMinutes()) < 10 ? ('0' + m) : m;
	ss = (s = dateObject.getSeconds()) < 10 ? ('0' + s) : s;
	return formatString.replace("#hhh#", hhh).replace("#hh#", hh).replace("#h#", h).replace("#mm#", mm).replace("#m#", m).replace("#ss#", ss).replace("#s#", s).replace("#ampm#", ampm).replace("#AMPM#", AMPM);
}