using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSumProblem
{
    public class FinderSet
    {
        private IEnumerable<int> _array { get; set; }
        public FinderSet(IEnumerable<int> array)
        {
            _array = array;
        }
        public IEnumerable<SetThree> GetListOfSetThree()
        {
            IEnumerable<SetThree> set = FindElements();
            if (set == null)
            {
                set = new List<SetThree>();   
            }
            return set;
        }
        private IEnumerable<SetThree> FindElements()
        {
            List<SetThree> result = new List<SetThree>();
            int cntArray = _array.Count();
            int[] mas = _array.ToArray();

            for (int i = 0; i < cntArray - 2; i++)
            {
                for (int j = i + 1; j < cntArray - 1; j++)
                {
                    for (int z = j + 1; z < cntArray; z++)
                    {
                        if (mas[i] + mas[j] + mas[z] == 0)
                        {
                            SetThree set = (new SetThree(new List<int>() { mas[i], mas[j], mas[z] }));
                            //[TO DO]  IEqualityComparer for SetThree
                            SetThree fSet = result.Where(x => x._array[0] == mas[i] && x._array[1] == mas[j] && x._array[2] == mas[z]).FirstOrDefault();
                            if (fSet == null)
                            {
                                result.Add(set);
                            }
                        }
                    }
                }

            }
            return result;
        }
    }
}
