using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{

    struct Record
    {
        public string Key;
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
        private int _minIndex;

        private List<Record> _storage = new List<Record>();

        public History(int steps)
        {
            if (steps < 1)
            {
                throw new ArgumentException("Must be not less than 1", "steps");
            }
            _steps = steps;
            _curStep = steps - 1;
            _minIndex = _curStep + 1;
        }

        public void StoreData(string key, ICloneable data)
        {
            for (int i = 0; i < _storage.Count; i++)
            {
                if (_storage[i].Key == key)
                {
                    _storage[i].Data[_curStep] = data.Clone();
                    return;
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
            int shift = _steps - 2 - _curStep;

            if (shift >= 0)
            {
                for (int i = 0; i < shift; i++)
                {
                    for (int j = 0; j < _storage.Count; j++)
                    {
                        for (int k = _steps - 1; k > 0; k--)
                            _storage[j].Data[k] = _storage[j][k - 1];
                    }
                }
                if (_minIndex < _steps - 1)
                _minIndex += shift;
            }
            else
            {
                for (int i = 0; i < -shift; i++)
                {
                    for (int j = 0; j < _storage.Count; j++)
                    {
                        for (int k = 0; k < _steps - 1; k++)
                            _storage[j].Data[k] = _storage[j][k + 1];
                    }
                }
                if(_minIndex > 0)
                    _minIndex += shift;
            }
            _curStep = _steps - 1;

            //MessageBox.Show(_curStep.ToString());
        }

        public bool PrevStep()
        {
            //MessageBox.Show(_curStep.ToString());
            if (_curStep > _minIndex)
            {
                _curStep--;
                return true;
            }
            return false;
        }

        public bool Revert()
        {
            //MessageBox.Show(_curStep.ToString());
            if (_curStep < _steps - 1)
            {
                _curStep++;
                return true;
            }
            return false;
        }
    }
}
