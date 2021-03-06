﻿using System;
using System.Reflection;
using Glimpse.Core.Extensibility;

namespace Glimpse.Mvc.Message
{
    public class BoundedFilterMessage : ActionFilterMessage, IBoundedFilterMessage
    { 
        public BoundedFilterMessage(TimerResult timerResult, string controllerName, string actionName, FilterBounds bounds, FilterCategory filterCategory, Type resultType, bool isChildAction, Type executedType, MethodInfo method, string eventName = null, string eventCategory = null)
            : base(timerResult, controllerName, actionName, filterCategory, resultType, isChildAction, executedType, method, eventName, eventCategory)
        {
            Bounds = bounds;

            if (string.IsNullOrEmpty(eventName))
            {
                EventName = string.Format("{0}:{1} - {2}:{3}", Category.ToString(), Bounds.ToString(), ControllerName, ActionName); 
            }
        } 

        public FilterBounds Bounds { get; protected set; }
    }
}
