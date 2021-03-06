﻿///////////////////////////////////////////////////////////////////////////////
//
// (C) 2017 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
//
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////

using OpenQA.Selenium;
using QX = Qooxdoo.WebDriver;

namespace Wisej.Web.Ext.Selenium.UI
{
    /// <summary>
    /// Represents a <see cref="T:Wisej.Web.CheckBox"/> widget.
    /// </summary>
    public class CheckBox : QX.UI.Core.WidgetWithValueBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBox"/> class.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="webDriver">The web driver.</param>
        public CheckBox(IWebElement element, QX.QxWebDriver webDriver) : base(element, webDriver)
        {
        }

        /*/// <summary>
        /// Gets or sets the value of a CheckBox value.</summary>
        /// <returns>The CheckBox value.</returns>
        public override string Value
        {
            get { return base.Value; }
            set
            {
                string script = "return qx.ui.core.Widget.getWidgetByElement(arguments[0]).setValue(arguments[1])";
                object result = JsExecutor.ExecuteScript(script, ContentElement, value);
            }
        }*/

        /// <summary>
        /// Gets the value of a CheckBox's text </summary>
        /// <returns>The CheckBox value.</returns>
        public override string Text
        {
            get { return this.Value; }
        }
    }
}