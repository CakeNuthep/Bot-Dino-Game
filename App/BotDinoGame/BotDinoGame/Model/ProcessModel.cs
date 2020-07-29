using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotDinoGame.Model
{
    public class ProcessModel
    {
        public double threshold { get; set; }
        public Rectangle rect { get; set; }
        public ActionModel action { get; set; }
        public OperationModel operaion { get; set; }

    }
}
