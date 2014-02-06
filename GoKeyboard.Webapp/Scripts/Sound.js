var Sound = function ()
{
	var self = this;

	this.context = null;
	this.notesBuffer = null;
	this.notes = new Array();

	this.Init = function (notesArray)
	{
		window.AudioContext = window.AudioContext || window.webkitAudioContext;
		context = new AudioContext();
		self.notes = notesArray;
	};
	this.Play = function (arrayKey)
	{
		var notePath = self.notes[arrayKey];
		self.notesBuffer = self.LoadSound(notePath);
	};
	this.PlayRandomSoundStartingWith = function (prefix)
	{
		var noteIndex = Math.floor(Math.random() * (Object.size(self.notes) - 2)) + 1;
		var notePath = self.notes[prefix + noteIndex];
		self.notesBuffer = self.LoadSound(notePath);
	};

	this.LoadSound = function (url)
	{
		var request = new XMLHttpRequest();
		request.open('GET', url, true);
		request.responseType = 'arraybuffer';
		// Decode asynchronously
		request.onload = function ()
		{
			context.decodeAudioData(request.response, function (buffer)
			{
				self.notesBuffer = buffer;
				self.PlaySound(self.notesBuffer);
			}, function (data) { alert(data); });
		}
		request.send();
	};


	this.PlaySound = function (buffer)
	{
		var source = context.createBufferSource(); // creates a sound source
		source.buffer = buffer;                    // tell the source which sound to play
		source.connect(context.destination);       // connect the source to the context's destination (the speakers)
		source.start(0);                           // play the source now
		// note: on older systems, may have to use deprecated noteOn(time);
	};
};
Object.size = function (obj)
{
	var size = 0, key;
	for (key in obj)
	{
		if (obj.hasOwnProperty(key)) size++;
	}
	return size;
};