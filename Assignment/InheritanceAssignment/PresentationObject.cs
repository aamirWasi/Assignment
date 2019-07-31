using System;

namespace InheritanceAssignment
{
    public class PresentationObject
    {
        private readonly int _height;

        public int Width { get; set; }
        public int Height {
            get
            {
                return _height;
            }
        }

        public PresentationObject(int height)
        {
            _height = height;
        }

        public void Copy()
        {
            Console.WriteLine("Object was copying from clipboard...");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated...");
        }
    }
}
