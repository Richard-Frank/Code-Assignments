#include "Cat.h"

void Cat::Kill()
{
	if (isAlive())
	{
		m_numLives--;
	}
}