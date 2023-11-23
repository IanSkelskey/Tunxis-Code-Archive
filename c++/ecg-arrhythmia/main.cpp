#include <iostream>

using namespace std;

int pulse, qrsAmp, pAmp, tAmp;

void diagnosis(int pulse, int qrsAmp, int pAmp, int tAmp)
{
    if (pulse == 0)
    {
        if (qrsAmp == 0)
        {
            if (pAmp == 0)
            {
                if (tAmp == 0)
                {
                    cout << "The patient is in cardiac arrest.\n";
                }
                else
                    cout << "Diagnosis unknown.\n";
            }
            else
                cout << "Diagnsosis unknown.\n";
        }
        else
            cout << "Diagnosis unknown.\n";
    }
    else
    {
        if ((pulse < 40) && (pulse > 0))
        {
            if (qrsAmp == 4)
            {
                if (pAmp == 1)
                {
                    if (tAmp == 1)
                    {
                        cout << "The patient is crashing.\n";
                    }
                    else
                        cout << "Diagnosis unknown.\n";
                }
                else
                    cout << "Diagnosis unknown.\n";
            }
            else
                cout << "Diagnosis unknown.\n";
        }
        else
        {
            if ((pulse >= 40) && (pulse <= 200))
            {
                if (qrsAmp == 6)
                {
                    if (pAmp == 1)
                    {
                        if (tAmp == 1)
                        {
                            cout << "The patient's condition is normal.\n";
                        }
                        else
                            cout << "Diagnosis unknown.\n";
                    }
                    else
                        cout << "Diagnosis unknown.\n";
                }
                else
                {
                    if (qrsAmp == 12)
                    {
                        if (pAmp == 1)
                        {
                            if (tAmp == 1)
                            {
                                cout << "The patient is in preventricular contraction.\n";
                            }
                            else
                                cout << "Diagnosis unknown.\n";
                        }
                        else
                            cout << "Diagnosis unknown.\n";
                    }
                    else
                        cout << "Diagnosis unknown.\n";
                }
            }
            else
            {
                if (pulse > 200)
                {
                    if (qrsAmp == 3)
                    {
                        if (pAmp == 0)
                        {
                            if (tAmp == 0)
                            {
                                cout << "The patient is in ventricular fibrillation.\n";
                            }
                            else
                                cout << "Diagnosis unknown.\n";
                        }
                        else
                            cout << "Diagnosis unknown.\n";
                    }
                    else
                    {
                        if (qrsAmp == 12)
                        {
                            if (pAmp == 0)
                            {
                                if (tAmp == 0)
                                {
                                    cout << "The patient is in ventricular tachycardia.\n";
                                }
                                else
                                    cout << "Diagnosis unknown.\n";
                            }
                            else
                                cout << "Diagnosis unknown.\n";
                        }
                        else
                            cout << "Diagnosis unknown.\n";
                    }
                }
                else
                    cout << "Diagnosis unknown.\n";
            }

        }
    }
}

int main()
{
    cout << "Welcome! Tell me about your patient.\n";
    cout << "Enter pulse: ";
    cin >> pulse;
    cout << "Enter QRS Amplitude: ";
    cin >> qrsAmp;
    cout << "Enter P Amplitude: ";
    cin >> pAmp;
    cout << "Enter T Amplitude: ";
    cin >> tAmp;
    cout << endl;

    //cout << "pulse = " << pulse << " qrsAmp = " << qrsAmp << " pAmp = " << pAmp << " tAmp = " << tAmp << endl;

    diagnosis(pulse, qrsAmp, pAmp, tAmp);

    return 0;
}
