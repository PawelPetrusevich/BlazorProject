using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;

namespace Blazor.BlazorUI.Pages
{
    public class CounterBase : ComponentBase
    {
        public int currentCount = 0;
        public string Name { get; set; }

        public DateTime Color { get; set; }

        public void IncrementCount()
        {
            currentCount++;
        }

        public void LogKeyPressed(KeyboardEventArgs eventArgs)
        {
            Console.WriteLine(eventArgs);
        }
    }
}