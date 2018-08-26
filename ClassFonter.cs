using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExtendedTextEditor
{
    class ClassFonter
    {
        private ToolStripMenuItem previousFontToolItem;
        private ToolStripMenuItem previousFontStyleItem = null;

        public ClassFonter(ToolStripMenuItem item)
        {
            previousFontToolItem = item;
        }

        public System.Drawing.Font GetFont(System.Drawing.FontFamily fontFamily, System.Drawing.FontStyle fontStyle = System.Drawing.FontStyle.Regular, float size = 10)
        {
            return new System.Drawing.Font(fontFamily, size, fontStyle);
        }

        public void SwitchFont(ToolStripMenuItem currentToolItem)
        {
            if (currentToolItem == previousFontToolItem) return;
            currentToolItem.Checked = true;
            if (previousFontToolItem != null) previousFontToolItem.Checked = false;
            previousFontToolItem = currentToolItem;
        }

        public bool SwitchCharStyle(ToolStripMenuItem currentToolItem)
        {
            if (currentToolItem == previousFontStyleItem)
            {
                currentToolItem.Checked = false;
                previousFontStyleItem = null;
                return false;
            }
            else
            {
                currentToolItem.Checked = true;
                if (previousFontStyleItem != null) previousFontStyleItem.Checked = false;
                previousFontStyleItem = currentToolItem;
                return true;
            }
        }

    }
}
