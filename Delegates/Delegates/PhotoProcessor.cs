using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }

    // with below Process() method, without using Action Delegate, for any modification in PhotoFilters (Adding new methods, deleting existing methods) class we have to modify the Process method
    //public class PhotoProcessor
    //{
    //    //public PhotoFilters filters =new PhotoFilters();
    //    public void Process(string path, PhotoFilters filters)
    //    {
    //        var photo = Photo.Load(path);

    //        filters.ApplyBrightness(photo);
    //        filters.ApplyContrast(photo);
    //        filters.Resize(photo);

    //        photo.Save();
    //    }
    //}
}