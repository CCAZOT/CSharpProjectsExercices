/*
 * Created by SharpDevelop.
 * User: Cédric
 * Date: 29/05/2014
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
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
            var commands = new string[] { "get", "-url", @"https://ccazot.github.io" };
            var expectedString = @"<!DOCTYPE html><html><body><h1>Hello World</h1><p>I'm hosted with GitHub Pages.</p></body></html>"+"\n";

   
            app.DispatchArgs(commands);
            var data = app.Datas;


            Assert.AreEqual(expectedString, data);


		}
		[Test]
        public void FileContentShouldBeEqualToStringVariable()
        {

    
            var commands = new string[] { "get", "-url", @"https://ccazot.github.io","-save",@"c:\test\testfile.htm" };
            var expectedFileContent = @"<!DOCTYPE html><html><body><h1>Hello World</h1><p>I'm hosted with GitHub Pages.</p></body></html>"+"\n";

            var app = new CommandURL();
            app.DispatchArgs(commands);
            var fileContent = File.ReadAllText(@"c:\test\testfile.htm");


            Assert.AreEqual(expectedFileContent, fileContent);
        }

        [Test]
        public void GetAverageTime()
        {
            var app = new CommandURL();

            //given
            var commands = new string[] { "test", "-url", @"https://ccazot.github.io", "-time", "3","-avg"  };
    
            //when
            app.DispatchArgs(commands);

            //then
            Assert.IsTrue(app.avg > 0);
        }

        [Test]
        public void TestConnection()
        {
            var app = new CommandURL();
           
            //given
            var commands = new string[] { "test", "-url", @"https://ccazot.github.io", "-time", "3" };

            //when
            app.DispatchArgs(commands);

            //then
            Assert.IsTrue(app.Time > 0);
        }
	}
}
