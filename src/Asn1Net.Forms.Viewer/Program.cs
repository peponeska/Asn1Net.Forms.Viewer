﻿/*
 *  Asn1Net.Forms.Viewer - GUI application for visualization of ASN.1 objects. 
 *	Implemented using Windows.Forms. Uses Asn1TreeView to do the visualization. 
 *	Part of Asn1Net utilities.
 *  Copyright (c) 2014-2015 Peter Polacko
 *  Author: Peter Polacko <peter.polacko+asn1net@gmail.com>
 *
 *  Licensing for open source projects:
 *  Asn1Net.Forms.Viewer is available under the terms of the GNU Affero General 
 *  Public License version 3 as published by the Free Software Foundation.
 *  Please see <http://www.gnu.org/licenses/agpl-3.0.html> for more details.
 *
 */

using System;
using System.Windows.Forms;

namespace Net.Asn1.Forms.Viewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
