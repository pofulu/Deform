﻿using UnityEngine;

namespace Deform
{
	/// <summary>
	/// Holds all information about a vertex.
	/// </summary>
	[System.Serializable]
	public struct VertexData
	{
		public Vector3 position;
		[SerializeField, HideInInspector]
		public readonly Vector3 basePosition;
		[SerializeField]
		public readonly Vector3 normal;
		[SerializeField]
		public readonly Vector4 tangent;
		[SerializeField]
		public readonly Vector2 uv;
		[SerializeField]
		public readonly Color color;

		public VertexData (Vector3 basePosition, Vector3 position, Vector3 normal, Vector4 tangent, Vector2 uv, Color color)
		{
			this.basePosition = basePosition;
			this.position = position;
			this.normal = normal;
			this.tangent = tangent;
			this.uv = uv;
			this.color = color;
		}

		public VertexData (Vector3 position, Vector3 normal, Vector4 tangent, Vector2 uv, Color color)
		{
			this.basePosition = position;
			this.position = position;
			this.normal = normal;
			this.tangent = tangent;
			this.uv = uv;
			this.color = color;
		}

		/// <summary>
		/// Sets the position back to the basePosition.
		/// </summary>
		public void ResetPosition ()
		{
			position = basePosition;
		}
	}
}