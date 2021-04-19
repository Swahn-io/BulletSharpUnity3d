using BulletUnity;

namespace BulletSharpUnity3d
{
    /**
    This script is last in the script execution order. Its purpose is to ensure that StepSimulation is called after other scripts LateUpdate calls
    Do not add this script manually. The BPhysicsWorld will add it.
    */
    public class BPhysicsWorldEcsHelper : BasePhysicsWorldHelper
    {
        public void StepWorld(float timeStep)
        {
            if (m_ddWorld != null)
            {
                m_ddWorld.StepSimulation(timeStep, 0);
            }

            //collisions
            if (m_collisionEventHandler != null)
            {
                m_collisionEventHandler.OnPhysicsStep(m_world);
            }
        }
    }
}
