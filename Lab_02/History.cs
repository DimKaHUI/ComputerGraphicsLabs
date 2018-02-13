using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{

    struct Record
    {
        public  string Key;
        public object[] Data;
        public Record(string key, int steps)
        {
            Key = key;
            Data = new object[steps];
        }

        public object this[int i]
        {
            get { return Data[i]; }
            set { Data[i] = value; }
        }
    }
    class History
    {
        private int _steps;
        private int _curStep;
        private int _savedLen = 0;

        private List<Record> _storage = new List<Record>();

        public History(int steps)
        {
            if (steps < 1)
            {
                throw new ArgumentException("Must be not less than 1", "steps");
            }
            _steps = steps;
            _curStep = steps - 1;
        }

        public void StoreData(string key, ICloneable data)
        {
            for (int i = 0; i < _storage.Count; i++)
            {
                if (_storage[i].Key == key)
                {
                    _storage[i].Data[_curStep] = data.Clone();
                    break;
                }
            }
            _storage.Add(new Record(key, _steps));
            _storage[_storage.Count - 1].Data[_curStep] = data.Clone();
        }

        public object LoadData(string key)
        {
            for (int i = 0; i < _storage.Count; i++)
            {
                if (_storage[i].Key == key)
                {
                    return _storage[i].Data[_curStep];
                }
            }
            return null;
        }

        public void NextStep()
        {
            /*if (_curStep > _steps - 1)
                _curStep = _steps - 1;*/

            if (_curStep == _steps - 1)
            {
                for (int i = 0; i < _storage.Count; i++)
                {
                    for (int k = 0; k < _steps - 1; k++)
                    {
                        _storage[i].Data[k] = _storage[i].Data[k + 1];
                    }
                    _storage[i].Data[_steps - 1] = null;
                }
                _savedLen++;
            }
            else
            {
                for (int i = 0; i < _storage.Count; i++)
                {
                    while (_curStep < _steps - 2)
                    {
                        _curStep++;
                        _savedLen--;
                        for (int k = _steps - 1; k > 0; k--)
                        {
                            _storage[i].Data[k - 1] = _storage[i].Data[k];
                        }
                    }
                    _storage[i].Data[_steps - 1] = null;
                }
                _curStep++;
            }
        }

        public bool PrevStep()
        {
            if (_curStep > _steps - _savedLen)
            {
                _curStep--;
                return true;
            }
            return false;
        }

        public bool Revert()
        {
            if (_curStep < _steps - 1)
            {
                _curStep++;
                return true;
            }
            return false;
        }
    }
}
