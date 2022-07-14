using Rocket.API;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePlugin.Helpers;

namespace TemplatePlugin.Commands
{
    internal class PayCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "Pay";

        public string Help => "Pay";

        public string Syntax => "Pay <Target> <Amount>";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "XPTransfer.Pay" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;
            if(command.Length < 2)
            {
                TranslationHelper.SendMessageTranslation(player.CSteamID, "ProperUsage", "/Pay <Target> <Amount>");
                return;
            }
            var target = UnturnedPlayer.FromName(command[0]);
            if(target == null)
            {
                TranslationHelper.SendMessageTranslation(player.CSteamID, "TargetNotFound");
                return;
            }
            if(!uint.TryParse(command[1], out var amount))
            {
                // Invalid Amount
                TranslationHelper.SendMessageTranslation(player.CSteamID, "InvalidAmount");
                return;
            }
            if(player.Experience < amount)
            {
                // Missing Funds
                TranslationHelper.SendMessageTranslation(player.CSteamID, "MissingFunds");
                return;
            }
            player.Experience -= amount;
            target.Experience += amount;
            TranslationHelper.SendMessageTranslation(target.CSteamID, "Target_Paid", player.CharacterName, amount);
            TranslationHelper.SendMessageTranslation(player.CSteamID, "Player_Paid", target.CharacterName, amount);
        }
    }
}
