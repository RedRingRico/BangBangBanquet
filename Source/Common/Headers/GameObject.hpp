#ifndef __BANGBANGBANQUET_GAMEOBJECT_HPP__
#define __BANGBANGBANQUET_GAMEOBJECT_HPP__

#include <Arithmetic/Vector3.hpp>
#include <Renderer/Model.hpp>

namespace BBB
{
	class GameObject
	{
	public:
		GameObject( );
		virtual ~GameObject( );

		ZED_UINT32 LoadModel( const ZED_CHAR8 *p_pModelPath );

		void SetPosition( const ZED_FLOAT32 p_X, const ZED_FLOAT32 p_Y,
			const ZED_FLOAT32 p_Z );

		void GetPosition( ZED::Arithmetic::Vector3 &p_Position ) const;

		ZED_BOOL ToggleRenderable( );

		void SetRenderable( const ZED_BOOL p_Renderable );

	protected:
		ZED::Arithmetic::Vector3	m_Position;
		ZED::Renderer::Model		*m_pModel;
		ZED_BOOL					m_Renderable;
	};
}

#endif // __BANGBANGBANQUET_GAMEOBJECT_HPP__

