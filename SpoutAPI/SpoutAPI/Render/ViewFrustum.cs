using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Render
{
    public class ViewFrustum
    {
        Vector3 position;
        float[,] frustum = new float[6, 4];

        public void update(Matrix4 projection, Matrix4 view)
        {
            double t;
            Matrix4 result = view * projection;
            float[] clip =;

            frustum[0, 0] = clip[3] - clip[0];
            frustum[0, 1] = clip[7] - clip[4];
            frustum[0, 2] = clip[11] - clip[8];
            frustum[0, 3] = clip[15] - clip[12];

		    /* Normalize the result */
		    t = Math.Sqrt(frustum[0, 0] * frustum[0, 0] + frustum[0, 1] * frustum[0, 1] + frustum[0, 2] * frustum[0, 2]);
		    frustum[0, 0] /= (float) t;
		    frustum[0, 1] /= (float) t;
		    frustum[0, 2] /= (float) t;
		    frustum[0, 3] /= (float) t;

		    /* Extract the numbers for the LEFT plane */
		    frustum[1, 0] = clip[3] + clip[0];
		    frustum[1, 1] = clip[7] + clip[4];
		    frustum[1, 2] = clip[11] + clip[8];
		    frustum[1, 3] = clip[15] + clip[12];

		    /* Normalize the result */
		    t = Math.Sqrt(frustum[1, 0] * frustum[1, 0] + frustum[1, 1] * frustum[1, 1] + frustum[1, 2] * frustum[1, 2]);
		    frustum[1, 0] /= (float) t;
		    frustum[1, 1] /= (float) t;
		    frustum[1, 2] /= (float) t;
		    frustum[1, 3] /= (float) t;

		    /* Extract the BOTTOM plane */
		    frustum[2, 0] = clip[3] + clip[1];
		    frustum[2, 1] = clip[7] + clip[5];
		    frustum[2, 2] = clip[11] + clip[9];
		    frustum[2, 3] = clip[15] + clip[13];

		    /* Normalize the result */
		    t = Math.Sqrt(frustum[2, 0] * frustum[2, 0] + frustum[2, 1] * frustum[2, 1] + frustum[2, 2] * frustum[2, 2]);
		    frustum[2, 0] /= (float) t;
		    frustum[2, 1] /= (float) t;
		    frustum[2, 2] /= (float) t;
		    frustum[2, 3] /= (float) t;

		    /* Extract the TOP plane */
		    frustum[3, 0] = clip[3] - clip[1];
		    frustum[3, 1] = clip[7] - clip[5];
		    frustum[3, 2] = clip[11] - clip[9];
		    frustum[3, 3] = clip[15] - clip[13];

		    /* Normalize the result */
		    t = Math.Sqrt(frustum[3, 0] * frustum[3, 0] + frustum[3, 1] * frustum[3, 1] + frustum[3, 2] * frustum[3, 2]);
		    frustum[3, 0] /= (float) t;
		    frustum[3, 1] /= (float) t;
		    frustum[3, 2] /= (float) t;
		    frustum[3, 3] /= (float) t;

		    /* Extract the FAR plane */
		    frustum[4, 0] = clip[3] - clip[2];
		    frustum[4, 1] = clip[7] - clip[6];
		    frustum[4, 2] = clip[11] - clip[10];
		    frustum[4, 3] = clip[15] - clip[14];

		    /* Normalize the result */
		    t = Math.Sqrt(frustum[4, 0] * frustum[4, 0] + frustum[4, 1] * frustum[4, 1] + frustum[4, 2] * frustum[4, 2]);
		    frustum[4, 0] /= (float) t;
		    frustum[4, 1] /= (float) t;
		    frustum[4, 2] /= (float) t;
		    frustum[4, 3] /= (float) t;

		    /* Extract the NEAR plane */
		    frustum[5, 0] = clip[3] + clip[2];
		    frustum[5, 1] = clip[7] + clip[6];
		    frustum[5, 2] = clip[11] + clip[10];
		    frustum[5, 3] = clip[15] + clip[14];

		    position = new Vector3(view.M13, view.M23, view.M33);
	    }

            /**
             * Checks if the frustum of this camera intersects the given Cuboid.
             * 
             * @param c The cuboid to check the frustum against.
             * @return True if the frustum intersects the cuboid.
             */
            public bool intersects(Cuboid c)
            {
                Vector3[] vertices = c.getVertices();
                for (int i = 0; i < 6; i++)
                {
                    if (frustum[i, 0] * (vertices[0].X - position.X) + frustum[i, 1] * (vertices[0].Y - position.Y) + frustum[i, 2] * (vertices[0].Z - position.Z) + frustum[i, 3] > 0)
                    {
                        continue;
                    }

                    if (frustum[i, 0] * (vertices[1].X - position.X) + frustum[i, 1] * (vertices[1].Y - position.Y) + frustum[i, 2] * (vertices[1].Z - position.Z) + frustum[i, 3] > 0)
                    {
                        continue;
                    }

                    if (frustum[i, 0] * (vertices[2].X - position.X) + frustum[i, 1] * (vertices[2].Y - position.Y) + frustum[i, 2] * (vertices[2].Z - position.Z) + frustum[i, 3] > 0)
                    {
                        continue;
                    }

                    if (frustum[i, 0] * (vertices[3].X - position.X) + frustum[i, 1] * (vertices[3].Y - position.Y) + frustum[i, 2] * (vertices[3].Z - position.Z) + frustum[i, 3] > 0)
                    {
                        continue;
                    }

                    if (frustum[i, 0] * (vertices[4].X - position.X) + frustum[i, 1] * (vertices[4].Y - position.Y) + frustum[i, 2] * (vertices[4].Z - position.Z) + frustum[i, 3] > 0)
                    {
                        continue;
                    }

                    if (frustum[i, 0] * (vertices[5].X - position.X) + frustum[i, 1] * (vertices[5].Y - position.Y) + frustum[i, 2] * (vertices[5].Z - position.Z) + frustum[i, 3] > 0)
                    {
                        continue;
                    }

                    if (frustum[i, 0] * (vertices[6].X - position.X) + frustum[i, 1] * (vertices[6].Y - position.Y) + frustum[i, 2] * (vertices[6].Z - position.Z) + frustum[i, 3] > 0)
                    {
                        continue;
                    }

                    if (frustum[i, 0] * (vertices[7].X - position.X) + frustum[i, 1] * (vertices[7].Y - position.Y) + frustum[i, 2] * (vertices[7].Z - position.Z) + frustum[i, 3] > 0)
                    {
                        continue;
                    }
                    return false;
                }

                return true;
            }

            /**
             * Checks if the frustum contains the given Vector3.
             * 
             * @param vec The Vector3 to check the frustum against.
             * @return True if the frustum contains the Vector3.
             */
            public bool contains(Vector3 vec)
            {
                for (int p = 0; p < 6; p++)
                {
                    if (frustum[p, 0] * vec.X + frustum[p, 1] * vec.Y + frustum[p, 2] * vec.Z + frustum[p, 3] <= 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
}
