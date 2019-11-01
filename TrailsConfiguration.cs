using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Trails
{
	public class TrailsConfiguration : IRocketPluginConfiguration
	{
		[XmlElement ("DatabaseAddress")]
		public string address;
		[XmlElement ("DatabaseName")]
		public string name;
		[XmlElement ("DatabaseUsername")]
		public string username;
		[XmlElement ("DatabasePassword")]
		public string password;
		[XmlElement ("DatabaseTableName")]
		public string tablename;
		[XmlElement ("DatabasePort")]
		public int port;

		[XmlElement ("useSQL")]
		public bool useSQL = true;

		[XmlArray ("Trails")]
		[XmlArrayItem ("Trail")]
		public List<CustomTrail> customTrails = new List<CustomTrail> ();

		public void LoadDefaults ()
		{
			customTrails = new List<CustomTrail> ()
			{
				new CustomTrail ()
				{
					name = "electric",
					id = 61,
					permission = "trail.electric",
					type = "ALWAYS"
				},
				new CustomTrail ()
				{
					name = "fire",
					id = 139,
					permission = "trail.fire",
					type = "GROUNDED"
				},
				new CustomTrail ()
				{
					name = "water",
					id = 129,
					permission = "trail.water",
					type = "NOTGROUNDED"
				},
				new CustomTrail ()
				{
					name = "red",
					id = 124,
					permission = "trail.red",
					type = "INWATER,VEHICLE.140.106"
				},
				new CustomTrail ()
				{
					name = "orange",
					id = 130,
					permission= "trail.orange",
					type = "INWATER"
				},
				new CustomTrail ()
				{
					name = "purple",
					id = 132,
					permission = "trail.purple",
					type = "INVEHICLE.106.104"
				},
				new CustomTrail ()
				{
					name = "green",
					id = 134,
					permission = "trail.green",
					type = "INVEHICLE.54.52"
				}
			};
		}
	}

	public class CustomTrail
	{
		[XmlElement ("Name")]
		public string name;
		[XmlElement ("ID")]
		public ushort id;
		[XmlElement ("Permission")]
		public string permission;
		[XmlElement ("Type")]
		public string type;

		public CustomTrail () { }
	}
}
