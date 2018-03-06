﻿using UnityEngine;

namespace Deform.Deformers
{
	public class NormalScaleDeformer : DeformerComponent
	{
		public float amount = 0f;

		public override Chunk Modify (Chunk chunk, TransformData transformData, Bounds bounds)
		{
			for (int vertexIndex = 0; vertexIndex < chunk.Size; vertexIndex++)
				chunk.vertexData[vertexIndex].position += chunk.vertexData[vertexIndex].normal * amount;

			return chunk;
		}
	}
}