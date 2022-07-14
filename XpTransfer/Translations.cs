using Rocket.API.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTransfer
{
    public partial class XPTransferPlugin
    {
        public override TranslationList DefaultTranslations => new TranslationList
        {
            {
                "ProperUsage", "[color=#FF0000]{{XPTransfer}} [/color] [color=#F3F3F3]Proper Usage |[/color] [color=#3E65FF]{0}[/color]"
            },
            {
                "TargetNotFound", "[color=#FF0000]{{XPTransfer}} [/color][color=#F3F3F3]Target not found![/color]"
            },
            {
                "InvalidAmount", "[color=#FF0000]{{XPTransfer}} [/color][color=#F3F3F3]Invalid Amount[/color]"
            },
            {
                "MissingFunds", "[color=#FF0000]{{XPTransfer}} [/color][color=#F3F3F3]Missing Funds![/color]"
            },
            {
                "Target_Paid", "[color=#FF0000]{{XPTransfer}} [/color][color=#3E65FF]{0}[/color] [color=#F3F3F3]has Paid you[/color] [color=#3E65FF]{1}[/color][color=#F3F3F3] Experience[/color]"
            },
            {
                "Player_Paid", "[color=#F3F3F3]You have successfully Paid[/color] [color=#3E65FF]{0}[/color][color=#F3F3F3] |[/color] [color=#3E65FF]{1}[/color][color=#F3F3F3] Experience[/color]"
            },
        };
    }
}