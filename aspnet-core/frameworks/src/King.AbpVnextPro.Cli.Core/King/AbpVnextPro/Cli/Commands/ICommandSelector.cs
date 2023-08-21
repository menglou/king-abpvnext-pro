using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.Cli.Commands;

public interface ICommandSelector
{
    Type Select(CommandLineArgs commandLineArgs);
}
