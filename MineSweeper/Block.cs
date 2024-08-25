using MineSweeper.Interface;

namespace MineSweeper
{
	public class Block
	{
		public string BlockType { get; set; }
		public bool IsTriggered { get; }
		public bool IsMarked { get; set; }
		public Block[] AdjacentBlocks { get; init; }
		public uint AdjacentMines { get; }
	}
}
