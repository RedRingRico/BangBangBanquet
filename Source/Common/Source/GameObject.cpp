#include <GameObject.hpp>

namespace BBB
{
	GameObject::GameObject( ) :
		m_pModel( ZED_NULL ),
		m_Renderable( ZED_FALSE )
	{
		m_Position.Zero( );
	}

	GameObject::~GameObject( )
	{
	}

	ZED_UINT32 GameObject::LoadModel( const ZED_CHAR8 *p_pModelPath )
	{
		return ZED_FAIL;
	}

	void GameObject::SetPosition( const ZED_FLOAT32 p_X, const ZED_FLOAT32 p_Y,
			const ZED_FLOAT32 p_Z )
	{
		m_Position.Set( p_X, p_Y, p_Z );
	}

	void GameObject::GetPosition(
		ZED::Arithmetic::Vector3 &p_Position ) const
	{
		p_Position = m_Position;
	}

	ZED_BOOL GameObject::ToggleRenderable( )
	{
		m_Renderable = !m_Renderable;

		return m_Renderable;
	}

	void GameObject::SetRenderable( const ZED_BOOL p_Renderable )
	{
		m_Renderable = p_Renderable;
	}
}

