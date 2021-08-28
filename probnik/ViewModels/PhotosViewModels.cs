using probnik.Data;

namespace probnik.ViewModels
{
    public class PhotosViewModels
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Photo { get; set; }
        public int albumId { get; set; }
        public Albums albums { get; set; }
    }
}