using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Clinic
{
    private Pet[] clinic;

    public string Name { get; private set; }

    private int rooms;

    public int Rooms
    {
        get { return this.rooms; }
        private set 
        { 
            if (value % 2 == 0)
            {
                throw new ArgumentException("Clinic's rooms must be odd number"); 
            }
            this.rooms = value; 
        }
    }

    public Clinic(string name, int rooms)
    {
        this.Name = name;
        this.Rooms = rooms;
        clinic = new Pet[rooms];
    }

    public bool Add(Pet petsName, string clinicsName)
    {
        int middleIndex = (int)Math.Round((double)clinic.Length / 2);

        for (int i = middleIndex; i < clinic.Length; i++)
        {
            if (clinic[i] == null)
            {
                clinic[i] = petsName;
                return true;
            }

            if (clinic[middleIndex - i] == null)
            {
                clinic[middleIndex - i] = petsName;
                return true;
            }

            if (clinic[middleIndex + i] == null)
            {
                clinic[middleIndex + i] = petsName;
                return true;
            }
        }
        return false;
    }

    public bool Release(string clinicName)
    {
        int middleIndex = (int)Math.Round((double)clinic.Length / 2);

        for (int i = middleIndex; i < clinic.Length; i++)
        {
            if (clinic[i] != null)
            {
                clinic[i] = null;
                return true;
            }

            if (clinic[middleIndex + i] != null)
            {
                clinic[middleIndex + i] = null;
                return true;
            }
        }

        for (int i = 0; i < middleIndex; i++)
        {
            if (clinic[i] != null)
            {
                clinic[i] = null;
                return true;
            }
        }

        return false;
    }

    public bool HasEmptyRooms(string clinicName)
    {
        clinic.Where(c => c.);
    }

    public void Print(string clinicName)
    {
        
    }

    public void Print(string clinicName, int room)
    {
        
    }


    //public IEnumerator<Pet> GetEnumerator()
    //{
    //    throw new NotImplementedException();
    //}

    //IEnumerator IEnumerable.GetEnumerator()
    //{
    //    return this.GetEnumerator();
    //}
}

