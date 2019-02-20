using System;
using System.Collections.Generic;

namespace Parcels.Models
{
    public class Package
    {
        private int _length;
        private int _height;
        private int _width;
        private int _weight;
        private int _counter = 0;
        private static List<Package> list = new List<Package>(){};

        public Package(int length, int height, int width, int weight)
        {
            _length = length;
            _height = height;
            _width = width;
            _weight = weight;
            list.Add(this);
        }

        public int GetLength()
        {
            return _length;
        }

        public void SetLength(int newLength)
        {
            _length = newLength;
        }

        public int GetHeight()
        {
            return _height;
        }

        public void SetHeight(int newHeight)
        {
            _height = newHeight;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetWidth(int newWidth)
        {
            _width = newWidth;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public void SetWeight(int newWeight)
        {
            _weight = newWeight;
        }

        public int GetVolume()
        {
            return _width*_length*_height;
        }

        public int CostToShip()
        {
            return (this.GetVolume()+(2*_weight));
        }
        
        public int GetPackageID()
        {
            _counter++;
            return _counter;
        }

        public static List<Package> GetList()
        {
            return list;
        }


    }

}