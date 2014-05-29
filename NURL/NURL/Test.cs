/*
 * Created by SharpDevelop.
 * User: Cédric
 * Date: 29/05/2014
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;


namespace NURL
{
	/// <summary>
	/// Description of Test.
	/// </summary>
	/// 
	[TestFixture]
	public class Test
	{
		[Test]
		public void Should_show_the_content_of_a_page()
		{
		    
		    var app = new CommandURL();
            var commands = new string[] { "get", "-url", @"http://api.openweathermap.org/data/2.5/weather?q=paris&units=metric" };
            var expectedString = @"{""coord"":{""lon"":-95.56,""lat"":33.66},""sys"":{""message"":0.0079,""country"":""US"",""sunrise"":1401362009,""sunset"":1401413157},""weather"":[{""id"":800,""main"":""Clear"",""description"":""sky is clear"",""icon"":""01d""}],""base"":""cmc stations"",""main"":{""temp"":19.75,""pressure"":1013,""humidity"":88,""temp_min"":19,""temp_max"":20},""wind"":{""speed"":2.6,""deg"":340},""clouds"":{""all"":1},""dt"":1401368393,""id"":4717560,""name"":""Paris"",""cod"":200}";

   
            app.DispatchArgs(commands);
            var data = app.Datas;


            Assert.AreEqual(expectedString, data);


		}
	}
}
