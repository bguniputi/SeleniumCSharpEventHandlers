using NextGenTestLibrary.Loggers;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpEventHandlers.src.EventHandler
{
    public class EventHandlers
    {
        #region Navigation
        public static void _Navigating(object sender, WebDriverNavigationEventArgs eventArgs)
        {
            Logger.log.Debug("Navigating " + eventArgs.Url);
        }

        public static void _Navigated(object sender, WebDriverNavigationEventArgs eventArgs)
        {
            Logger.log.Debug("Navigated " + eventArgs.Url);
        }

        public static void _NavigatingBack(object sender, WebDriverNavigationEventArgs eventArgs)
        {
            Logger.log.Debug("Navigating back");
        }

        public static void _NavigatedBack(object sender, WebDriverNavigationEventArgs eventArgs)
        {
            Logger.log.Debug("Navigated back " + eventArgs.Url);
        }

        public static void _NavigatingForward(object sender, WebDriverNavigationEventArgs eventArgs)
        {
            Logger.log.Debug("Navigating Forward");
        }

        public static void _NavigatedForward(object sender, WebDriverNavigationEventArgs eventArgs)
        {
            Logger.log.Debug("Navigated Forward " + eventArgs.Url);
        }
        #endregion

        #region Click Element

        public static void _ElementClicking(object sender, WebElementEventArgs eventArgs)
        {
            Logger.log.Debug("Clicking " + eventArgs.Element.ToString() + "element");
        }

        public static void _ElementClicked(object sender, WebElementEventArgs eventArgs)
        {
            Logger.log.Debug("Clicked on " + eventArgs.Element.ToString() + "element");
        }

        public static void _ElementValueChanging(object sender, WebElementValueEventArgs eventArgs)
        {
            Logger.log.Debug("Changing element " + eventArgs.Element.ToString() + "value");
        }

        public static void _ElementValueChanged(object sender, WebElementValueEventArgs eventArgs)
        {
            Logger.log.Debug("Element value " + eventArgs.Element.ToString() + "changed");
        }

        #endregion

        #region FindElement
        public static void _FindingElement(object sender, FindElementEventArgs eventArgs)
        {
            Logger.log.Debug("FindingElement from " + eventArgs.Element == null ? "IWebDriver" : "IWebElement" + eventArgs.FindMethod.ToString());
        }

        public static void _FindElementCompleted(object sender, FindElementEventArgs eventArgs)
        {
            Logger.log.Debug("FindingElementCompleted from " + eventArgs.Element == null ? "IWebDriver" : "IWebElement" + eventArgs.FindMethod.ToString());
        }
        #endregion

        #region Javascript execution
        public static void _ScriptExecuting(object sender, WebDriverScriptEventArgs eventArgs)
        {
            Logger.log.Debug("Executing script of " + eventArgs.Script.ToString());
        }

        public static void _ScriptExecuted(object sender, WebDriverScriptEventArgs eventArgs)
        {
            Logger.log.Debug("Script " + eventArgs.Script.ToString() + "is executed");
        }
        #endregion

        #region Exception
        public static void _ExceptionThrown(object sender, WebDriverExceptionEventArgs eventArgs)
        {
            Logger.log.Error("Exception Thrown " + eventArgs.ThrownException.Message);
        }
        #endregion
    }
}
