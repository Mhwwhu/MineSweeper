using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
	public class GameContext
	{
		public Block[] Blocks {  get; set; }
		public GameConfigure Configure { get; set; }
		public IServiceProvider ServiceProvider { get; set; }
	}
}
