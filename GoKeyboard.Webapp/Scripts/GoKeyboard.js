$(function ()
{
	window.Exo = Backbone.Model.extend(
	{
		defaults:
		{
			id: "1",
			Name: "exo 1",
			Sections: ["eieieiei jqjqqj jqqjqjq"]
		},
		initialize: function Exo()
		{
			console.log('Exo construction');
			this.url = "api/exercices/" + this.id;
		}

	});

	window.Exos = Backbone.Collection.extend(
	{
		model: Exo,
		url: "api/exercices",
		//localStorage: new Store("exos"),
		initialize: function ()
		{
			console.log("Exos collection consctructor");
		}
	});

	listExos = new Exos();
	e1 = new Exo();
	e1.fetch({ success: function (result) { console.log(result); } });
	e1.toJSON();
});