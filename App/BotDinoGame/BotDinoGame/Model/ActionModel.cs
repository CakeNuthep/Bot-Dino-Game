using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotDinoGame.Model
{
    public class ActionModel
    {
        private ActionModel(string value) { Value = value; }

        public string Value { get; set; }

        public static ActionModel UP { get { return new ActionModel("{UP}"); } }
        public static ActionModel DOWN { get { return new ActionModel("{DOWN}"); } }
    }
}
