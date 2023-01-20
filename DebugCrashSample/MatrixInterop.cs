using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace DebugCrashSample
{
	internal class MatrixInterop
	{
		public static Matrix MultiplyByInterop(ref Matrix left, ref Matrix right)
		{
			Matrix res = new Matrix();
			MatrixMulti(ref left, ref right, ref res);
			return res;
		}

		[DllImport("libMatrix.so", EntryPoint = "MatrixMulti", CallingConvention = CallingConvention.Cdecl)]
		public extern static void MatrixMulti(ref Matrix left, ref Matrix right, ref Matrix res);
	}

	public struct Matrix
	{
		public static Matrix Identity = new Matrix();
		public static Matrix Zero = new Matrix();

		public float M11;
		public float M12;
		public float M13;
		public float M14;

		public float M21;
		public float M22;
		public float M23;
		public float M24;

		public float M31;
		public float M32;
		public float M33;
		public float M34;

		public float M41;
		public float M42;
		public float M43;
		public float M44;


		public Matrix(float[] values) : this()
		{
			throw new NotImplementedException();
		}

		internal void Invert()
		{
			throw new NotImplementedException();
		}

		internal static Matrix Invert(Matrix matrix)
		{
			throw new NotImplementedException();
		}

		internal static Matrix TransposeMatrix(Matrix matrix)
		{
			throw new NotImplementedException();
		}

		internal static Matrix RotationX(float angle)
		{
			throw new NotImplementedException();
		}

		internal static Matrix RotationY(float angle)
		{
			throw new NotImplementedException();
		}

		internal static Matrix Scaling(float scaleX, float scaleY, float scaleZ)
		{
			throw new NotImplementedException();
		}

		internal static Matrix Translation(float x, float y, float z)
		{
			throw new NotImplementedException();
		}

		internal static Matrix RotationZ(float angle)
		{
			throw new NotImplementedException();
		}

		internal static Matrix LookAtLH(Vector3 vector1, Vector3 vector2, Vector3 vector3)
		{
			throw new NotImplementedException();
		}

		internal static Matrix OrthoLH(float width, float height, float znearPlane, float zfarPlane)
		{
			throw new NotImplementedException();
		}

		internal static Matrix PerspectiveFovLH(float fieldOfViewY, float aspectRatio, float zNearPlane, float zFarPlane)
		{
			throw new NotImplementedException();
		}

		internal static Matrix RotationYawPitchRoll(float yaw, float pitch, float roll)
		{
			throw new NotImplementedException();
		}

		internal static Matrix Multiply(Matrix matrix1, Matrix matrix2)
		{
			throw new NotImplementedException();
		}

		public static Matrix operator *(Matrix left, Matrix right)
		{
			throw new NotImplementedException();
		}

		internal static Matrix Scaling(Vector3 vector3)
		{
			throw new NotImplementedException();
		}

		internal static Matrix Translation(Vector3 position)
		{
			throw new NotImplementedException();
		}
	}
}