namespace GLDotNet
{
		public enum BlendingFactorDest : uint
		{
			DstAlpha = 0x0304,
			One = 1,
			OneMinusDstAlpha = 0x0305,
			OneMinusSrcAlpha = 0x0303,
			OneMinusSrcColor = 0x0301,
			SrcAlpha = 0x0302,
			SrcColor = 0x0300,
			Zero = 0,
		}

		public enum BlendingFactorSrc : uint
		{
			DstAlpha = 0x0304,
			DstColor = 0x0306,
			One = 1,
			OneMinusDstAlpha = 0x0305,
			OneMinusDstColor = 0x0307,
			OneMinusSrcAlpha = 0x0303,
			SrcAlpha = 0x0302,
			SrcAlphaSaturate = 0x0308,
			Zero = 0,
		}

		public enum BufferAccess : uint
		{
			ReadOnly = 0x88B8,
			WriteOnly = 0x88B9,
			ReadWrite = 0x88BA,
		}

		public enum BufferTarget : uint
		{
			ArrayBuffer = 0x8892,
			AtomicCounterBuffer = 0x92C0,
			CopyReadBuffer = 0x8F36,
			CopyWriteBuffer = 0x8F37,
			DispatchIndirectBuffer = 0x90EE,
			DrawIndirectBuffer = 0x8F3F,
			ElementArrayBuffer = 0x8893,
			PixelPackBuffer = 0x88EB,
			PixelUnpackBuffer = 0x88EC,
			QueryBuffer = 0x9192,
			ShaderStorageBuffer = 0x90D2,
			TextureBuffer = 0x8C2A,
			TransformFeedbackBuffer = 0x8C8E,
			UniformBuffer = 0x8A11,
		}

		public enum BufferUsage : uint
		{
			StreamDraw = 0x88E0,
			StreamRead = 0x88E1,
			StreamCopy = 0x88E2,
			StaticDraw = 0x88E4,
			StaticRead = 0x88E5,
			StaticCopy = 0x88E6,
			DynamicDraw = 0x88E8,
			DynamicRead = 0x88E9,
			DynamicCopy = 0x88EA,
		}

		public enum ClearBufferMask : uint
		{
			ColorBufferBit = 0x00004000,
			DepthBufferBit = 0x00000100,
			StencilBufferBit = 0x00000400,
		}

		public enum CullFaceMode : uint
		{
			Back = 0x0405,
			Front = 0x0404,
			FrontAndBack = 0x0408,
		}

		public enum DepthFunction : uint
		{
			Always = 0x0207,
			Equal = 0x0202,
			Gequal = 0x0206,
			Greater = 0x0204,
			Lequal = 0x0203,
			Less = 0x0201,
			Never = 0x0200,
			Notequal = 0x0205,
		}

		public enum DrawBufferMode : uint
		{
			Back = 0x0405,
			BackLeft = 0x0402,
			BackRight = 0x0403,
			Front = 0x0404,
			FrontAndBack = 0x0408,
			FrontLeft = 0x0400,
			FrontRight = 0x0401,
			Left = 0x0406,
			None = 0,
			Right = 0x0407,
		}

		public enum DrawElementsType : uint
		{
			UnsignedByte = 0x1401,
			UnsignedShort = 0x1403,
			UnsignedInt = 0x1405,
		}

		public enum EnableCap : uint
		{
			Blend = 0x0BE2,
			ColorLogicOp = 0x0BF2,
			CullFace = 0x0B44,
			DepthTest = 0x0B71,
			Dither = 0x0BD0,
			LineSmooth = 0x0B20,
			PolygonOffsetFill = 0x8037,
			PolygonOffsetLine = 0x2A02,
			PolygonOffsetPoint = 0x2A01,
			PolygonSmooth = 0x0B41,
			ScissorTest = 0x0C11,
			StencilTest = 0x0B90,
			Texture1D = 0x0DE0,
			Texture2D = 0x0DE1,
			VertexArray = 0x8074,
		}

		public enum FrontFaceDirection : uint
		{
			Ccw = 0x0901,
			Cw = 0x0900,
		}

		public enum GetPName : uint
		{
			AliasedLineWidthRange = 0x846E,
			Blend = 0x0BE2,
			BlendDst = 0x0BE0,
			BlendSrc = 0x0BE1,
			ColorClearValue = 0x0C22,
			ColorLogicOp = 0x0BF2,
			ColorWritemask = 0x0C23,
			CullFace = 0x0B44,
			CullFaceMode = 0x0B45,
			DepthClearValue = 0x0B73,
			DepthFunc = 0x0B74,
			DepthRange = 0x0B70,
			DepthTest = 0x0B71,
			DepthWritemask = 0x0B72,
			Dither = 0x0BD0,
			Doublebuffer = 0x0C32,
			DrawBuffer = 0x0C01,
			FrontFace = 0x0B46,
			LineSmooth = 0x0B20,
			LineSmoothHint = 0x0C52,
			LineWidth = 0x0B21,
			LineWidthGranularity = 0x0B23,
			LineWidthRange = 0x0B22,
			LogicOpMode = 0x0BF0,
			MaxClipDistances = 0x0D32,
			MaxTextureSize = 0x0D33,
			MaxViewportDims = 0x0D3A,
			PackAlignment = 0x0D05,
			PackLsbFirst = 0x0D01,
			PackRowLength = 0x0D02,
			PackSkipPixels = 0x0D04,
			PackSkipRows = 0x0D03,
			PackSwapBytes = 0x0D00,
			PointSize = 0x0B11,
			PointSizeGranularity = 0x0B13,
			PointSizeRange = 0x0B12,
			PolygonMode = 0x0B40,
			PolygonOffsetFactor = 0x8038,
			PolygonOffsetFill = 0x8037,
			PolygonOffsetLine = 0x2A02,
			PolygonOffsetPoint = 0x2A01,
			PolygonOffsetUnits = 0x2A00,
			PolygonSmooth = 0x0B41,
			PolygonSmoothHint = 0x0C53,
			ReadBuffer = 0x0C02,
			ScissorBox = 0x0C10,
			ScissorTest = 0x0C11,
			SmoothLineWidthGranularity = 0x0B23,
			SmoothLineWidthRange = 0x0B22,
			SmoothPointSizeGranularity = 0x0B13,
			SmoothPointSizeRange = 0x0B12,
			StencilClearValue = 0x0B91,
			StencilFail = 0x0B94,
			StencilFunc = 0x0B92,
			StencilPassDepthFail = 0x0B95,
			StencilPassDepthPass = 0x0B96,
			StencilRef = 0x0B97,
			StencilTest = 0x0B90,
			StencilValueMask = 0x0B93,
			StencilWritemask = 0x0B98,
			Stereo = 0x0C33,
			SubpixelBits = 0x0D50,
			Texture1D = 0x0DE0,
			Texture2D = 0x0DE1,
			TextureBinding1D = 0x8068,
			TextureBinding2D = 0x8069,
			TextureBinding3D = 0x806A,
			UnpackAlignment = 0x0CF5,
			UnpackLsbFirst = 0x0CF1,
			UnpackRowLength = 0x0CF2,
			UnpackSkipPixels = 0x0CF4,
			UnpackSkipRows = 0x0CF3,
			UnpackSwapBytes = 0x0CF0,
			VertexArray = 0x8074,
			Viewport = 0x0BA2,
		}

		public enum GetTextureParameter : uint
		{
			TextureAlphaSize = 0x805F,
			TextureBlueSize = 0x805E,
			TextureBorderColor = 0x1004,
			TextureGreenSize = 0x805D,
			TextureHeight = 0x1001,
			TextureInternalFormat = 0x1003,
			TextureMagFilter = 0x2800,
			TextureMinFilter = 0x2801,
			TextureRedSize = 0x805C,
			TextureWidth = 0x1000,
			TextureWrapS = 0x2802,
			TextureWrapT = 0x2803,
		}

		public enum HintMode : uint
		{
			DontCare = 0x1100,
			Fastest = 0x1101,
			Nicest = 0x1102,
		}

		public enum HintTarget : uint
		{
			FragmentShaderDerivativeHint = 0x8B8B,
			LineSmoothHint = 0x0C52,
			PolygonSmoothHint = 0x0C53,
			ProgramBinaryRetrievableHint = 0x8257,
			TextureCompressionHint = 0x84EF,
		}

		public enum LogicOp : uint
		{
			And = 0x1501,
			AndInverted = 0x1504,
			AndReverse = 0x1502,
			Clear = 0x1500,
			Copy = 0x1503,
			CopyInverted = 0x150C,
			Equiv = 0x1509,
			Invert = 0x150A,
			Nand = 0x150E,
			Noop = 0x1505,
			Nor = 0x1508,
			Or = 0x1507,
			OrInverted = 0x150D,
			OrReverse = 0x150B,
			Set = 0x150F,
			Xor = 0x1506,
		}

		public enum MaterialFace : uint
		{
			Back = 0x0405,
			Front = 0x0404,
			FrontAndBack = 0x0408,
		}

		public enum PixelFormat : uint
		{
			Alpha = 0x1906,
			Blue = 0x1905,
			DepthComponent = 0x1902,
			Green = 0x1904,
			Red = 0x1903,
			Rgb = 0x1907,
			Rgba = 0x1908,
			StencilIndex = 0x1901,
			UnsignedInt = 0x1405,
			UnsignedShort = 0x1403,
		}

		public enum PixelStoreParameter : uint
		{
			PackAlignment = 0x0D05,
			PackImageHeight = 0x806C,
			PackLsbFirst = 0x0D01,
			PackRowLength = 0x0D02,
			PackSkipImages = 0x806B,
			PackSkipPixels = 0x0D04,
			PackSkipRows = 0x0D03,
			PackSwapBytes = 0x0D00,
			UnpackAlignment = 0x0CF5,
			UnpackImageHeight = 0x806E,
			UnpackLsbFirst = 0x0CF1,
			UnpackRowLength = 0x0CF2,
			UnpackSkipImages = 0x806D,
			UnpackSkipPixels = 0x0CF4,
			UnpackSkipRows = 0x0CF3,
			UnpackSwapBytes = 0x0CF0,
		}

		public enum PixelType : uint
		{
			Byte = 0x1400,
			Float = 0x1406,
			Int = 0x1404,
			Short = 0x1402,
			UnsignedByte = 0x1401,
			UnsignedByte332 = 0x8032,
			UnsignedInt = 0x1405,
			UnsignedInt1010102 = 0x8036,
			UnsignedInt8888 = 0x8035,
			UnsignedShort = 0x1403,
			UnsignedShort4444 = 0x8033,
			UnsignedShort5551 = 0x8034,
		}

		public enum PolygonMode : uint
		{
			Fill = 0x1B02,
			Line = 0x1B01,
			Point = 0x1B00,
		}

		public enum PrimitiveType : uint
		{
			Lines = 0x0001,
			LinesAdjacency = 0x000A,
			LineLoop = 0x0002,
			LineStrip = 0x0003,
			LineStripAdjacency = 0x000B,
			Patches = 0x000E,
			Points = 0x0000,
			Quads = 0x0007,
			Triangles = 0x0004,
			TrianglesAdjacency = 0x000C,
			TriangleFan = 0x0006,
			TriangleStrip = 0x0005,
			TriangleStripAdjacency = 0x000D,
		}

		public enum ReadBufferMode : uint
		{
			Back = 0x0405,
			BackLeft = 0x0402,
			BackRight = 0x0403,
			Front = 0x0404,
			FrontLeft = 0x0400,
			FrontRight = 0x0401,
			Left = 0x0406,
			Right = 0x0407,
		}

		public enum StencilFaceDirection : uint
		{
			Front = 0x0404,
			Back = 0x0405,
			FrontAndBack = 0x0408,
		}

		public enum StencilFunction : uint
		{
			Always = 0x0207,
			Equal = 0x0202,
			Gequal = 0x0206,
			Greater = 0x0204,
			Lequal = 0x0203,
			Less = 0x0201,
			Never = 0x0200,
			Notequal = 0x0205,
		}

		public enum StencilOp : uint
		{
			Decr = 0x1E03,
			Incr = 0x1E02,
			Invert = 0x150A,
			Keep = 0x1E00,
			Replace = 0x1E01,
			Zero = 0,
		}

		public enum StringName : uint
		{
			Extensions = 0x1F03,
			Renderer = 0x1F01,
			Vendor = 0x1F00,
			Version = 0x1F02,
			ShadingLanguageVersion = 0x8B8C,
		}

		public enum TextureParameterName : uint
		{
			TextureBorderColor = 0x1004,
			TextureMagFilter = 0x2800,
			TextureMinFilter = 0x2801,
			TextureWrapR = 0x8072,
			TextureWrapS = 0x2802,
			TextureWrapT = 0x2803,
			TextureBaseLevel = 0x813C,
			TextureCompareMode = 0x884C,
			TextureCompareFunc = 0x884D,
			TextureLodBias = 0x8501,
			TextureMinLod = 0x813A,
			TextureMaxLod = 0x813B,
			TextureMaxLevel = 0x813D,
			TextureSwizzleR = 0x8E42,
			TextureSwizzleG = 0x8E43,
			TextureSwizzleB = 0x8E44,
			TextureSwizzleA = 0x8E45,
			TextureSwizzleRgba = 0x8E46,
			DepthStencilTextureMode = 0x90EA,
		}

		public enum TextureTarget : uint
		{
			ProxyTexture1D = 0x8063,
			ProxyTexture1DArray = 0x8C19,
			ProxyTexture2D = 0x8064,
			ProxyTexture2DArray = 0x8C1B,
			ProxyTexture2DMultisample = 0x9101,
			ProxyTexture2DMultisampleArray = 0x9103,
			ProxyTexture3D = 0x8070,
			ProxyTextureCubeMap = 0x851B,
			ProxyTextureCubeMapArray = 0x900B,
			ProxyTextureRectangle = 0x84F7,
			Texture1D = 0x0DE0,
			Texture2D = 0x0DE1,
			Texture3D = 0x806F,
			TextureRectangle = 0x84F5,
			TextureCubeMap = 0x8513,
			TextureCubeMapPositiveX = 0x8515,
			TextureCubeMapNegativeX = 0x8516,
			TextureCubeMapPositiveY = 0x8517,
			TextureCubeMapNegativeY = 0x8518,
			TextureCubeMapPositiveZ = 0x8519,
			TextureCubeMapNegativeZ = 0x851A,
			TextureCubeMapArray = 0x9009,
			Texture1DArray = 0x8C18,
			Texture2DArray = 0x8C1A,
			Texture2DMultisample = 0x9100,
			Texture2DMultisampleArray = 0x9102,
		}

}
