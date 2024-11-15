﻿using Markdown.Avalonia.Plugins;

namespace Markdown.Avalonia
{
    public class ChatAISetup : IMdAvPlugin
    {
        public void Setup(SetupInfo info)
        {
            info.EnableNoteBlock = false;
            info.EnableRuleExt = false;
            info.EnableTextAlignment = false;
            info.EnableListMarkerExt = false;
            info.EnableContainerBlockExt = false;
            info.EnableTextileInline = false;

            info.EnablePreRenderingCodeBlock = true;
        }
    }
}