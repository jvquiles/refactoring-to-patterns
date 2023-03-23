using System;
using System.Linq;
using System.Web;

namespace RefactoringToPatterns.ComposeMethod
{
    public class List
    {

        private readonly bool _readOnly;
        private int _size;
        private Object[] _elements;

        public List(bool readOnly)
        {
            _readOnly = readOnly;
            _size = 0;
            _elements = new Object[_size];
        }

        public void Add(Object element) {
            if(!_readOnly) {
                int newSize = _size + 1;

                if(newSize > _elements.Length)
                {
                    _elements = IncrementBy(10);
                }

                _elements[_size++] = element;
            }
        }

        private object[] IncrementBy(int increment)
        {
            Object[] newElements = new Object[_elements.Length + increment];

            CloneArray(newElements);
            return newElements;
        }

        private void CloneArray(object[] newElements)
        {
            for (int i = 0; i < _size; i++)
                newElements[i] = _elements[i];
        }

        public object[] Elements()
        {
            return _elements;
        }

    }

}