using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        static void Main(string[] args)
        {

        }

        public int GetProfityForAgent(int agentType, float age, float exprience)
        {
            float agent = age * exprience;

            int res = 0;

            float promres = 0;

            if (agent < 0 || res < 0)
            {
                return -1;
            }

            switch (agentType)
            {
                case 1:
                {
                    switch (agentType)
                    {
                        case 1:
                        {
                            if (exprience >= 10)
                            { 
                                promres = (float)(agent * 0.5);           

                                res = (int)Math.Ceiling(promres);

                            }                        

                            return res;
                        }

                            case 2:
                                {
                                    if (exprience >= 20)

                                    {

                                        promres = (float)(agent * 0.7);

                                        res = (int)Math.Ceiling(promres);

                                    }

                                    return res;
                                }

                            case 3:
                                {
                                    if (exprience >= 40)

                                    {
                                        promres = (float)(agent * 0.9);

                                        res = (int)Math.Ceiling(promres);

                                    }

                                    return res;
                                }

                            default:
                                {
                                    return -1;
                                }
                    }
                }

                case 2:
                    {
                        switch (agentType)
                        {
                            case 1:
                                {
                                    promres = (float)(agent * 0.1);

                                    res = (int)Math.Ceiling(promres);

                                    return res;
                                }

                            case 2:
                                {
                                    promres = (float)(agent * 0.17);

                                    res = (int)Math.Ceiling(promres);

                                    return res;
                                }

                            case 3:
                                {
                                    promres = (float)(agent * 0.26);

                                    res = (int)Math.Ceiling(promres);

                                    return res;
                                }

                            default:
                                {
                                    return -1;
                                }
                        }
                    }

                default:
                    {
                        return -1;
                    }

            }
        }
    }
}
