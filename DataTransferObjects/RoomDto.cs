using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects
{
    public class RoomDto
    {
        public int Id { get; set; }
        public int MapId { get; set; }
        public required string Name { get; set; }
        public required List<Rectangle> Segments { get; set; }
        public RectangleF? ViewBox { get; set; }
        public bool IsActive { get; set; }
    }
}