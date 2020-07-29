using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotDinoGame.Model
{
    public class OperationModel
    {
        private OperationModel(string value) { Value = value; }

        public string Value { get; set; }

        public static OperationModel GreaterThan { get { return new OperationModel("GT"); } }
        public static OperationModel LessThan { get { return new OperationModel("LT"); } }
    }
}
