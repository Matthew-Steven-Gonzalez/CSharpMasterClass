using System;
namespace interfacesLesson
{

	public interface IDestroyable
	{
        //prop for audio file for destuction noise
        string DestructionSound { get; set; }
        //method to destory
        void Destroy();

    }
}

