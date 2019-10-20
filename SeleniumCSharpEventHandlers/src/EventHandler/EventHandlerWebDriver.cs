using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using static SeleniumCSharpEventHandlers.src.EventHandler.EventHandlers;
namespace SeleniumCSharpEventHandlers.src.EventHandler
{
    public sealed class EventHandlerWebDriver
    {
        private static readonly object _lock = new object();
        private static EventFiringWebDriver _driver = null;
        private static IWebDriver _parentDriver;

        private EventHandlerWebDriver()
        {

        }
        public static IWebDriver ParentDriver
        {
            set => _parentDriver = value;
        }
        public static EventFiringWebDriver EventFiringWebDriver
        {
            get
            {
                lock (_lock)
                {
                    if (_driver == null)
                    {
                        _driver = new EventFiringWebDriver(_parentDriver);
                        EventFiringHandler(_driver);
                    }

                    return _driver;
                }
            }

        }

        private static void EventFiringHandler(EventFiringWebDriver firingWebDriver)
        {
            //Navigation event handler
            firingWebDriver.Navigating += _Navigating;
            firingWebDriver.Navigated += _Navigated;
            firingWebDriver.NavigatingBack += _NavigatingBack;
            firingWebDriver.NavigatingForward += _NavigatingForward;
            firingWebDriver.NavigatedBack += _NavigatedBack;
            firingWebDriver.NavigatedForward += _NavigatedForward;

            //Element Click
            firingWebDriver.ElementClicking += _ElementClicking;
            firingWebDriver.ElementClicked += _ElementClicked;
            firingWebDriver.ElementValueChanging += _ElementValueChanging;
            firingWebDriver.ElementValueChanged += _ElementValueChanged;

            //Finding Element
            firingWebDriver.FindingElement += _FindingElement;
            firingWebDriver.FindElementCompleted += _FindElementCompleted;

            //Script execution
            firingWebDriver.ScriptExecuting += _ScriptExecuting;
            firingWebDriver.ScriptExecuted += _ScriptExecuted;

            //Exception
            firingWebDriver.ExceptionThrown += _ExceptionThrown;

        }
    }
}
