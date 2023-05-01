using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.ComponentHelper
{
    public class ActionHelper
    {
        static Actions actions { get; set; }
        public static void DragAndDrop(IWebElement sourceElement, IWebElement targetElement)
        {
            actions = new Actions(ObjectRepository.driver);
            actions.DragAndDrop(sourceElement, targetElement);
            actions.Build().Perform();
        }

        public static void DragAndDropToOffset(IWebElement sourceElement,int xAxis, int yAxis)
        {
            actions = new Actions(ObjectRepository.driver);
            actions.DragAndDropToOffset(sourceElement, xAxis, yAxis);
            actions.Build().Perform();
        }

        public static void MoveToElement(IWebElement moveToElement)
        {
            actions = new Actions(ObjectRepository.driver);
            actions.ClickAndHold();
            actions.MoveToElement(moveToElement);
            actions.Release();
            actions.Build().Perform();
        }

        public static void DoubleClick()
        {
            actions = new Actions(ObjectRepository.driver);
            actions.DoubleClick();
            actions.Build().Perform();
        }

        public static void DoubleClickOnElement(IWebElement elementToClick)
        {
            actions = new Actions(ObjectRepository.driver);
            actions.DoubleClick(elementToClick);
            actions.Build().Perform();
        }

        public static void RightClick()
        {
            actions = new Actions(ObjectRepository.driver);
            actions.ContextClick();
            actions.Build().Perform();
        }

        public static void RightClickOnElement(IWebElement rightClickOnElement)
        {
            actions = new Actions(ObjectRepository.driver);
            actions.ContextClick(rightClickOnElement);
            actions.Build().Perform();
        }

        public static void MoveByOffSet(int xAxis, int yAxis)
        {
            actions = new Actions(ObjectRepository.driver);
            actions.MoveByOffset(xAxis, yAxis);
            actions.Build().Perform();
        }
    }
}
