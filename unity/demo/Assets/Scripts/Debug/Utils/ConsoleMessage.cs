﻿using UnityEngine;
using UtyMap.Unity.Infrastructure.Diagnostic;

namespace Assets.Scripts.Debug.Utils
{
    public class ConsoleMessage
    {
        public string Text { get; private set; }
        public DefaultTrace.RecordType Type { get; private set; }
        public Color Color { get; private set; }

        public ConsoleMessage(string text, DefaultTrace.RecordType type, Color color)
        {
            Text = text;
            Type = type;
            Color = color;
        }

        private static readonly Color DebugColor = Color.white;
        private static readonly Color WarningColor = Color.yellow;
        private static readonly Color ErrorColor = Color.red;
        private static readonly Color InfoColor = Color.cyan;

        public static ConsoleMessage Debug(string message)
        {
            return new ConsoleMessage(message, DefaultTrace.RecordType.Debug, DebugColor);
        }

        public static ConsoleMessage Info(string message)
        {
            return new ConsoleMessage(message, DefaultTrace.RecordType.Info, InfoColor);
        }

        public static ConsoleMessage Warning(string message)
        {
            return new ConsoleMessage(message, DefaultTrace.RecordType.Warn,  WarningColor);
        }

        public static ConsoleMessage Error(string message)
        {
            return new ConsoleMessage(message, DefaultTrace.RecordType.Error,  ErrorColor);
        }
    }
}
