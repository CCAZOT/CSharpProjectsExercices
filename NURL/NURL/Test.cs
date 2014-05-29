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
		    //given
		    var command = null; //votre implémentation
		
		    //when
		    var result = command.Show(url); //exemple d'implémentation
		
		    //then
		
		    Assert.That(result, Is.EqualTo("<h1>hello</h1>"));
		}
	}
}
