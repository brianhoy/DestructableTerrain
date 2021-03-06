using System.Collections.Generic;
using UnityEngine;

namespace DT {
// stores vertices, uvs of chunk
// Result of a chunk job
public class ChunkProcessOutput {
	public DensityChunk densities;
	public SE.Mesh mesh;
	public string key;
	public float processingTime;
	public int threadId;
	public string errorInfo;
}
}