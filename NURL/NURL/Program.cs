/*
 * Created by SharpDevelop.
 * User: Cédric
 * Date: 29/05/2014
 * Time: 14:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NURL
{
	class Program
	{

        static void Main(string[] args)
        {
            var app = new CommandURL();
            app.DispatchArgs(args);
        }
	
	}
}