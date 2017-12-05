namespace GLDotNet
{
		public enum AtomicCounterBufferPName : uint
		{
			AtomicCounterBufferBinding = 0x92C1,
			AtomicCounterBufferDataSize = 0x92C4,
			AtomicCounterBufferActiveAtomicCounters = 0x92C5,
			AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
			AtomicCounterBufferReferencedByVertexShader = 0x92C7,
			AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
			AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
			AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
			AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
			AtomicCounterBufferReferencedByComputeShader = 0x90ED,
		}

		public enum AttributeType : uint
		{
			FloatVec2 = 0x8B50,
			FloatVec3 = 0x8B51,
			FloatVec4 = 0x8B52,
			IntVec2 = 0x8B53,
			IntVec3 = 0x8B54,
			IntVec4 = 0x8B55,
			Bool = 0x8B56,
			BoolVec2 = 0x8B57,
			BoolVec3 = 0x8B58,
			BoolVec4 = 0x8B59,
			FloatMat2 = 0x8B5A,
			FloatMat3 = 0x8B5B,
			FloatMat4 = 0x8B5C,
			Sampler1D = 0x8B5D,
			Sampler2D = 0x8B5E,
			Sampler3D = 0x8B5F,
			SamplerCube = 0x8B60,
			Sampler1DShadow = 0x8B61,
			Sampler2DShadow = 0x8B62,
			Sampler2DRect = 0x8B63,
			Sampler2DRectShadow = 0x8B64,
			FloatMat2x3 = 0x8B65,
			FloatMat2x4 = 0x8B66,
			FloatMat3x2 = 0x8B67,
			FloatMat3x4 = 0x8B68,
			FloatMat4x2 = 0x8B69,
			FloatMat4x3 = 0x8B6A,
		}

		public enum BindTransformFeedbackTarget : uint
		{
			TransformFeedback = 0x8E22,
		}

		public enum BlendEquationModeEXT : uint
		{
			FuncAdd = 0x8006,
			FuncReverseSubtract = 0x800B,
			FuncSubtract = 0x800A,
		}

		public enum BlendingFactor : uint
		{
			Zero = 0,
			One = 1,
			SrcColor = 0x0300,
			OneMinusSrcColor = 0x0301,
			DstColor = 0x0306,
			OneMinusDstColor = 0x0307,
			SrcAlpha = 0x0302,
			OneMinusSrcAlpha = 0x0303,
			DstAlpha = 0x0304,
			OneMinusDstAlpha = 0x0305,
			ConstantColor = 0x8001,
			OneMinusConstantColor = 0x8002,
			ConstantAlpha = 0x8003,
			OneMinusConstantAlpha = 0x8004,
			SrcAlphaSaturate = 0x0308,
			Src1Color = 0x88F9,
			Src1Alpha = 0x8589,
		}

		public enum BlitFramebufferFilter : uint
		{
			Nearest = 0x2600,
			Linear = 0x2601,
		}

		public enum Buffer : uint
		{
			Color = 0x1800,
			Depth = 0x1801,
			Stencil = 0x1802,
		}

		public enum BufferAccess : uint
		{
			ReadOnly = 0x88B8,
			WriteOnly = 0x88B9,
			ReadWrite = 0x88BA,
		}

		public enum BufferAccessMask : uint
		{
			MapCoherentBit = 0x0080,
			MapFlushExplicitBit = 0x0010,
			MapInvalidateBufferBit = 0x0008,
			MapInvalidateRangeBit = 0x0004,
			MapPersistentBit = 0x0040,
			MapReadBit = 0x0001,
			MapUnsynchronizedBit = 0x0020,
			MapWriteBit = 0x0002,
		}

		public enum BufferStorageTarget : uint
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

		public enum ClipControlDepth : uint
		{
			NegativeOneToOne = 0x935E,
			ZeroToOne = 0x935F,
		}

		public enum ClipControlOrigin : uint
		{
			LowerLeft = 0x8CA1,
			UpperLeft = 0x8CA2,
		}

		public enum ColorBuffer : uint
		{
			None = 0,
			FrontLeft = 0x0400,
			FrontRight = 0x0401,
			BackLeft = 0x0402,
			BackRight = 0x0403,
			Front = 0x0404,
			Back = 0x0405,
			Left = 0x0406,
			Right = 0x0407,
			FrontAndBack = 0x0408,
			ColorAttachment0 = 0x8CE0,
			ColorAttachment1 = 0x8CE1,
			ColorAttachment2 = 0x8CE2,
			ColorAttachment3 = 0x8CE3,
			ColorAttachment4 = 0x8CE4,
			ColorAttachment5 = 0x8CE5,
			ColorAttachment6 = 0x8CE6,
			ColorAttachment7 = 0x8CE7,
			ColorAttachment8 = 0x8CE8,
			ColorAttachment9 = 0x8CE9,
			ColorAttachment10 = 0x8CEA,
			ColorAttachment11 = 0x8CEB,
			ColorAttachment12 = 0x8CEC,
			ColorAttachment13 = 0x8CED,
			ColorAttachment14 = 0x8CEE,
			ColorAttachment15 = 0x8CEF,
			ColorAttachment16 = 0x8CF0,
			ColorAttachment17 = 0x8CF1,
			ColorAttachment18 = 0x8CF2,
			ColorAttachment19 = 0x8CF3,
			ColorAttachment20 = 0x8CF4,
			ColorAttachment21 = 0x8CF5,
			ColorAttachment22 = 0x8CF6,
			ColorAttachment23 = 0x8CF7,
			ColorAttachment24 = 0x8CF8,
			ColorAttachment25 = 0x8CF9,
			ColorAttachment26 = 0x8CFA,
			ColorAttachment27 = 0x8CFB,
			ColorAttachment28 = 0x8CFC,
			ColorAttachment29 = 0x8CFD,
			ColorAttachment30 = 0x8CFE,
			ColorAttachment31 = 0x8CFF,
		}

		public enum CopyBufferSubDataTarget : uint
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

		public enum CullFaceMode : uint
		{
			Back = 0x0405,
			Front = 0x0404,
			FrontAndBack = 0x0408,
		}

		public enum DebugSeverity : uint
		{
			DebugSeverityLow = 0x9148,
			DebugSeverityMedium = 0x9147,
			DebugSeverityHigh = 0x9146,
			DontCare = 0x1100,
		}

		public enum DebugSource : uint
		{
			DebugSourceApi = 0x8246,
			DebugSourceWindowSystem = 0x8247,
			DebugSourceShaderCompiler = 0x8248,
			DebugSourceThirdParty = 0x8249,
			DebugSourceApplication = 0x824A,
			DebugSourceOther = 0x824B,
			DontCare = 0x1100,
		}

		public enum DebugType : uint
		{
			DebugTypeError = 0x824C,
			DebugTypeDeprecatedBehavior = 0x824D,
			DebugTypeUndefinedBehavior = 0x824E,
			DebugTypePortability = 0x824F,
			DebugTypePerformance = 0x8250,
			DebugTypeMarker = 0x8268,
			DebugTypePushGroup = 0x8269,
			DebugTypePopGroup = 0x826A,
			DebugTypeOther = 0x8251,
			DontCare = 0x1100,
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

		public enum FramebufferAttachment : uint
		{
			MaxColorAttachments = 0x8CDF,
			ColorAttachment0 = 0x8CE0,
			ColorAttachment1 = 0x8CE1,
			ColorAttachment2 = 0x8CE2,
			ColorAttachment3 = 0x8CE3,
			ColorAttachment4 = 0x8CE4,
			ColorAttachment5 = 0x8CE5,
			ColorAttachment6 = 0x8CE6,
			ColorAttachment7 = 0x8CE7,
			ColorAttachment8 = 0x8CE8,
			ColorAttachment9 = 0x8CE9,
			ColorAttachment10 = 0x8CEA,
			ColorAttachment11 = 0x8CEB,
			ColorAttachment12 = 0x8CEC,
			ColorAttachment13 = 0x8CED,
			ColorAttachment14 = 0x8CEE,
			ColorAttachment15 = 0x8CEF,
			ColorAttachment16 = 0x8CF0,
			ColorAttachment17 = 0x8CF1,
			ColorAttachment18 = 0x8CF2,
			ColorAttachment19 = 0x8CF3,
			ColorAttachment20 = 0x8CF4,
			ColorAttachment21 = 0x8CF5,
			ColorAttachment22 = 0x8CF6,
			ColorAttachment23 = 0x8CF7,
			ColorAttachment24 = 0x8CF8,
			ColorAttachment25 = 0x8CF9,
			ColorAttachment26 = 0x8CFA,
			ColorAttachment27 = 0x8CFB,
			ColorAttachment28 = 0x8CFC,
			ColorAttachment29 = 0x8CFD,
			ColorAttachment30 = 0x8CFE,
			ColorAttachment31 = 0x8CFF,
			DepthAttachment = 0x8D00,
		}

		public enum FramebufferAttachmentParameterName : uint
		{
			FramebufferAttachmentRedSize = 0x8212,
			FramebufferAttachmentGreenSize = 0x8213,
			FramebufferAttachmentBlueSize = 0x8214,
			FramebufferAttachmentAlphaSize = 0x8215,
			FramebufferAttachmentDepthSize = 0x8216,
			FramebufferAttachmentStencilSize = 0x8217,
			FramebufferAttachmentComponentType = 0x8211,
			FramebufferAttachmentColorEncoding = 0x8210,
			FramebufferAttachmentObjectName = 0x8CD1,
			FramebufferAttachmentTextureLevel = 0x8CD2,
			FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
			FramebufferAttachmentLayered = 0x8DA7,
			FramebufferAttachmentTextureLayer = 0x8CD4,
		}

		public enum FramebufferParameterName : uint
		{
			FramebufferDefaultWidth = 0x9310,
			FramebufferDefaultHeight = 0x9311,
			FramebufferDefaultLayers = 0x9312,
			FramebufferDefaultSamples = 0x9313,
			FramebufferDefaultFixedSampleLocations = 0x9314,
		}

		public enum FramebufferTarget : uint
		{
			Framebuffer = 0x8D40,
			DrawFramebuffer = 0x8CA9,
			ReadFramebuffer = 0x8CA8,
		}

		public enum FrontFaceDirection : uint
		{
			Ccw = 0x0901,
			Cw = 0x0900,
		}

		public enum GetFramebufferParameter : uint
		{
			FramebufferDefaultWidth = 0x9310,
			FramebufferDefaultHeight = 0x9311,
			FramebufferDefaultLayers = 0x9312,
			FramebufferDefaultSamples = 0x9313,
			FramebufferDefaultFixedSampleLocations = 0x9314,
			Doublebuffer = 0x0C32,
			ImplementationColorReadFormat = 0x8B9B,
			ImplementationColorReadType = 0x8B9A,
			Samples = 0x80A9,
			SampleBuffers = 0x80A8,
			Stereo = 0x0C33,
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

		public enum GetPointervPName : uint
		{
			DebugCallbackFunction = 0x8244,
			DebugCallbackUserParam = 0x8245,
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

		public enum InternalFormat : int
		{
			Red = 0x1903,
			R8 = 0x8229,
			R8Snorm = 0x8F94,
			R16 = 0x822A,
			R16Snorm = 0x8F98,
			R16f = 0x822D,
			R32f = 0x822E,
			R8i = 0x8231,
			R16i = 0x8233,
			R32i = 0x8235,
			R8ui = 0x8232,
			R16ui = 0x8234,
			R32ui = 0x8236,
			Rg = 0x8227,
			Rg8 = 0x822B,
			Rg8Snorm = 0x8F95,
			Rg16 = 0x822C,
			Rg16Snorm = 0x8F99,
			Rg16f = 0x822F,
			Rg32f = 0x8230,
			Rg8i = 0x8237,
			Rg16i = 0x8239,
			Rg32i = 0x823B,
			Rg8ui = 0x8238,
			Rg16ui = 0x823A,
			Rg32ui = 0x823C,
			Rgb = 0x1907,
			Rgb4 = 0x804F,
			Rgb5 = 0x8050,
			Rgb8 = 0x8051,
			Rgb8Snorm = 0x8F96,
			Rgb10 = 0x8052,
			Rgb12 = 0x8053,
			Rgb16 = 0x8054,
			Rgb16f = 0x881B,
			Rgb16Snorm = 0x8F9A,
			Rgb8i = 0x8D8F,
			Rgb16i = 0x8D89,
			Rgb32i = 0x8D83,
			Rgb8ui = 0x8D7D,
			Rgb16ui = 0x8D77,
			Rgb32ui = 0x8D71,
			Srgb = 0x8C40,
			SrgbAlpha = 0x8C42,
			Srgb8 = 0x8C41,
			Srgb8Alpha8 = 0x8C43,
			R3G3B2 = 0x2A10,
			R11fG11fB10f = 0x8C3A,
			Rgb9E5 = 0x8C3D,
			Rgba = 0x1908,
			Rgba4 = 0x8056,
			Rgb5A1 = 0x8057,
			Rgba8 = 0x8058,
			Rgba8Snorm = 0x8F97,
			Rgb10A2 = 0x8059,
			Rgba12 = 0x805A,
			Rgba16 = 0x805B,
			Rgba16f = 0x881A,
			Rgba32f = 0x8814,
			Rgba8i = 0x8D8E,
			Rgba16i = 0x8D88,
			Rgba32i = 0x8D82,
			Rgba8ui = 0x8D7C,
			Rgba16ui = 0x8D76,
			Rgba32ui = 0x8D70,
			Rgb10A2ui = 0x906F,
			DepthComponent = 0x1902,
			DepthComponent16 = 0x81A5,
			DepthComponent32f = 0x8CAC,
			DepthStencil = 0x84F9,
			Depth24Stencil8 = 0x88F0,
			Depth32fStencil8 = 0x8CAD,
			CompressedRed = 0x8225,
			CompressedRg = 0x8226,
			CompressedRgb = 0x84ED,
			CompressedRgba = 0x84EE,
			CompressedSrgb = 0x8C48,
			CompressedSrgbAlpha = 0x8C49,
			CompressedRedRgtc1 = 0x8DBB,
			CompressedSignedRedRgtc1 = 0x8DBC,
			CompressedR11Eac = 0x9270,
			CompressedSignedR11Eac = 0x9271,
			CompressedRgRgtc2 = 0x8DBD,
			CompressedSignedRgRgtc2 = 0x8DBE,
			CompressedRgbaBptcUnorm = 0x8E8C,
			CompressedSrgbAlphaBptcUnorm = 0x8E8D,
			CompressedRgbBptcSignedFloat = 0x8E8E,
			CompressedRgbBptcUnsignedFloat = 0x8E8F,
			CompressedRgb8Etc2 = 0x9274,
			CompressedSrgb8Etc2 = 0x9275,
			CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,
			CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,
			CompressedRgba8Etc2Eac = 0x9278,
			CompressedSrgb8Alpha8Etc2Eac = 0x9279,
			CompressedRg11Eac = 0x9272,
			CompressedSignedRg11Eac = 0x9273,
		}

		public enum InternalFormatPName : uint
		{
			NumSampleCounts = 0x9380,
			Samples = 0x80A9,
			InternalformatSupported = 0x826F,
			InternalformatPreferred = 0x8270,
			InternalformatRedSize = 0x8271,
			InternalformatGreenSize = 0x8272,
			InternalformatBlueSize = 0x8273,
			InternalformatAlphaSize = 0x8274,
			InternalformatDepthSize = 0x8275,
			InternalformatStencilSize = 0x8276,
			InternalformatSharedSize = 0x8277,
			InternalformatRedType = 0x8278,
			InternalformatGreenType = 0x8279,
			InternalformatBlueType = 0x827A,
			InternalformatAlphaType = 0x827B,
			InternalformatDepthType = 0x827C,
			InternalformatStencilType = 0x827D,
			MaxWidth = 0x827E,
			MaxHeight = 0x827F,
			MaxDepth = 0x8280,
			MaxLayers = 0x8281,
			ColorComponents = 0x8283,
			ColorRenderable = 0x8286,
			DepthRenderable = 0x8287,
			StencilRenderable = 0x8288,
			FramebufferRenderable = 0x8289,
			FramebufferRenderableLayered = 0x828A,
			FramebufferBlend = 0x828B,
			ReadPixels = 0x828C,
			ReadPixelsFormat = 0x828D,
			ReadPixelsType = 0x828E,
			TextureImageFormat = 0x828F,
			TextureImageType = 0x8290,
			GetTextureImageFormat = 0x8291,
			GetTextureImageType = 0x8292,
			Mipmap = 0x8293,
			AutoGenerateMipmap = 0x8295,
			ColorEncoding = 0x8296,
			SrgbRead = 0x8297,
			SrgbWrite = 0x8298,
			Filter = 0x829A,
			VertexTexture = 0x829B,
			TessControlTexture = 0x829C,
			TessEvaluationTexture = 0x829D,
			GeometryTexture = 0x829E,
			FragmentTexture = 0x829F,
			ComputeTexture = 0x82A0,
			TextureShadow = 0x82A1,
			TextureGather = 0x82A2,
			TextureGatherShadow = 0x82A3,
			ShaderImageLoad = 0x82A4,
			ShaderImageStore = 0x82A5,
			ShaderImageAtomic = 0x82A6,
			ImageTexelSize = 0x82A7,
			ImageCompatibilityClass = 0x82A8,
			ImagePixelFormat = 0x82A9,
			ImagePixelType = 0x82AA,
			ImageFormatCompatibilityType = 0x90C7,
			SimultaneousTextureAndDepthTest = 0x82AC,
			SimultaneousTextureAndStencilTest = 0x82AD,
			SimultaneousTextureAndDepthWrite = 0x82AE,
			SimultaneousTextureAndStencilWrite = 0x82AF,
			TextureCompressed = 0x86A1,
			TextureCompressedBlockWidth = 0x82B1,
			TextureCompressedBlockHeight = 0x82B2,
			TextureCompressedBlockSize = 0x82B3,
			ClearBuffer = 0x82B4,
			TextureView = 0x82B5,
			ViewCompatibilityClass = 0x82B6,
			ClearTexture = 0x9365,
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

		public enum MapBufferUsageMask : uint
		{
			ClientStorageBit = 0x0200,
			DynamicStorageBit = 0x0100,
			MapCoherentBit = 0x0080,
			MapFlushExplicitBit = 0x0010,
			MapInvalidateBufferBit = 0x0008,
			MapInvalidateRangeBit = 0x0004,
			MapPersistentBit = 0x0040,
			MapReadBit = 0x0001,
			MapUnsynchronizedBit = 0x0020,
			MapWriteBit = 0x0002,
		}

		public enum MaterialFace : uint
		{
			Back = 0x0405,
			Front = 0x0404,
			FrontAndBack = 0x0408,
		}

		public enum MemoryBarrierMask : uint
		{
			AllBarrierBits = 0xFFFFFFFF,
			AtomicCounterBarrierBit = 0x00001000,
			BufferUpdateBarrierBit = 0x00000200,
			ClientMappedBufferBarrierBit = 0x00004000,
			CommandBarrierBit = 0x00000040,
			ElementArrayBarrierBit = 0x00000002,
			FramebufferBarrierBit = 0x00000400,
			PixelBufferBarrierBit = 0x00000080,
			QueryBufferBarrierBit = 0x00008000,
			ShaderImageAccessBarrierBit = 0x00000020,
			ShaderStorageBarrierBit = 0x00002000,
			TextureFetchBarrierBit = 0x00000008,
			TextureUpdateBarrierBit = 0x00000100,
			TransformFeedbackBarrierBit = 0x00000800,
			UniformBarrierBit = 0x00000004,
			VertexAttribArrayBarrierBit = 0x00000001,
		}

		public enum ObjectIdentifier : uint
		{
			Buffer = 0x82E0,
			Shader = 0x82E1,
			Program = 0x82E2,
			VertexArray = 0x8074,
			Query = 0x82E3,
			ProgramPipeline = 0x82E4,
			TransformFeedback = 0x8E22,
			Sampler = 0x82E6,
			Texture = 0x1702,
			Renderbuffer = 0x8D41,
			Framebuffer = 0x8D40,
		}

		public enum PatchParameterName : uint
		{
			PatchVertices = 0x8E72,
			PatchDefaultOuterLevel = 0x8E74,
			PatchDefaultInnerLevel = 0x8E73,
		}

		public enum PipelineParameterName : uint
		{
			ActiveProgram = 0x8259,
			VertexShader = 0x8B31,
			TessControlShader = 0x8E88,
			TessEvaluationShader = 0x8E87,
			GeometryShader = 0x8DD9,
			FragmentShader = 0x8B30,
			InfoLogLength = 0x8B84,
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

		public enum PrecisionType : uint
		{
			LowFloat = 0x8DF0,
			MediumFloat = 0x8DF1,
			HighFloat = 0x8DF2,
			LowInt = 0x8DF3,
			MediumInt = 0x8DF4,
			HighInt = 0x8DF5,
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

		public enum ProgramInterface : uint
		{
			Uniform = 0x92E1,
			UniformBlock = 0x92E2,
			ProgramInput = 0x92E3,
			ProgramOutput = 0x92E4,
			VertexSubroutine = 0x92E8,
			TessControlSubroutine = 0x92E9,
			TessEvaluationSubroutine = 0x92EA,
			GeometrySubroutine = 0x92EB,
			FragmentSubroutine = 0x92EC,
			ComputeSubroutine = 0x92ED,
			VertexSubroutineUniform = 0x92EE,
			TessControlSubroutineUniform = 0x92EF,
			TessEvaluationSubroutineUniform = 0x92F0,
			GeometrySubroutineUniform = 0x92F1,
			FragmentSubroutineUniform = 0x92F2,
			ComputeSubroutineUniform = 0x92F3,
			TransformFeedbackVarying = 0x92F4,
			TransformFeedbackBuffer = 0x8C8E,
			BufferVariable = 0x92E5,
			ShaderStorageBlock = 0x92E6,
		}

		public enum ProgramInterfacePName : uint
		{
			ActiveResources = 0x92F5,
			MaxNameLength = 0x92F6,
			MaxNumActiveVariables = 0x92F7,
			MaxNumCompatibleSubroutines = 0x92F8,
		}

		public enum ProgramParameterPName : uint
		{
			ProgramBinaryRetrievableHint = 0x8257,
			ProgramSeparable = 0x8258,
		}

		public enum ProgramProperty : uint
		{
			DeleteStatus = 0x8B80,
			LinkStatus = 0x8B82,
			ValidateStatus = 0x8B83,
			InfoLogLength = 0x8B84,
			AttachedShaders = 0x8B85,
			ActiveAtomicCounterBuffers = 0x92D9,
			ActiveAttributes = 0x8B89,
			ActiveAttributeMaxLength = 0x8B8A,
			ActiveUniforms = 0x8B86,
			ActiveUniformBlocks = 0x8A36,
			ActiveUniformBlockMaxNameLength = 0x8A35,
			ActiveUniformMaxLength = 0x8B87,
			ComputeWorkGroupSize = 0x8267,
			ProgramBinaryLength = 0x8741,
			TransformFeedbackBufferMode = 0x8C7F,
			TransformFeedbackVaryings = 0x8C83,
			TransformFeedbackVaryingMaxLength = 0x8C76,
			GeometryVerticesOut = 0x8916,
			GeometryInputType = 0x8917,
			GeometryOutputType = 0x8918,
		}

		public enum ProgramStagePName : uint
		{
			ActiveSubroutineUniforms = 0x8DE6,
			ActiveSubroutineUniformLocations = 0x8E47,
			ActiveSubroutines = 0x8DE5,
			ActiveSubroutineUniformMaxLength = 0x8E49,
			ActiveSubroutineMaxLength = 0x8E48,
		}

		public enum QueryObjectParameterName : uint
		{
			QueryResultAvailable = 0x8867,
			QueryResult = 0x8866,
			QueryResultNoWait = 0x9194,
			QueryTarget = 0x82EA,
		}

		public enum QueryParameterName : uint
		{
			CurrentQuery = 0x8865,
			QueryCounterBits = 0x8864,
		}

		public enum QueryTarget : uint
		{
			SamplesPassed = 0x8914,
			AnySamplesPassed = 0x8C2F,
			AnySamplesPassedConservative = 0x8D6A,
			PrimitivesGenerated = 0x8C87,
			TransformFeedbackPrimitivesWritten = 0x8C88,
			TimeElapsed = 0x88BF,
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

		public enum RenderbufferParameterName : uint
		{
			RenderbufferWidth = 0x8D42,
			RenderbufferHeight = 0x8D43,
			RenderbufferInternalFormat = 0x8D44,
			RenderbufferSamples = 0x8CAB,
			RenderbufferRedSize = 0x8D50,
			RenderbufferGreenSize = 0x8D51,
			RenderbufferBlueSize = 0x8D52,
			RenderbufferAlphaSize = 0x8D53,
			RenderbufferDepthSize = 0x8D54,
			RenderbufferStencilSize = 0x8D55,
		}

		public enum RenderbufferTarget : uint
		{
			Renderbuffer = 0x8D41,
		}

		public enum SamplerParameterName : uint
		{
			TextureWrapS = 0x2802,
			TextureWrapT = 0x2803,
			TextureWrapR = 0x8072,
			TextureMinFilter = 0x2801,
			TextureMagFilter = 0x2800,
			TextureBorderColor = 0x1004,
			TextureMinLod = 0x813A,
			TextureMaxLod = 0x813B,
			TextureCompareMode = 0x884C,
			TextureCompareFunc = 0x884D,
		}

		public enum ShaderParameterName : uint
		{
			ShaderType = 0x8B4F,
			DeleteStatus = 0x8B80,
			CompileStatus = 0x8B81,
			InfoLogLength = 0x8B84,
			ShaderSourceLength = 0x8B88,
		}

		public enum ShaderType : uint
		{
			ComputeShader = 0x91B9,
			VertexShader = 0x8B31,
			TessControlShader = 0x8E88,
			TessEvaluationShader = 0x8E87,
			GeometryShader = 0x8DD9,
			FragmentShader = 0x8B30,
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

		public enum SubroutineParameterName : uint
		{
			NumCompatibleSubroutines = 0x8E4A,
			CompatibleSubroutines = 0x8E4B,
			UniformSize = 0x8A38,
			UniformNameLength = 0x8A39,
		}

		public enum SyncCondition : uint
		{
			SyncGpuCommandsComplete = 0x9117,
		}

		public enum SyncObjectMask : uint
		{
			SyncFlushCommandsBit = 0x00000001,
		}

		public enum SyncParameterName : uint
		{
			ObjectType = 0x9112,
			SyncStatus = 0x9114,
			SyncCondition = 0x9113,
			SyncFlags = 0x9115,
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
			TextureAlphaSize = 0x805F,
			TextureBlueSize = 0x805E,
			TextureGreenSize = 0x805D,
			TextureHeight = 0x1001,
			TextureInternalFormat = 0x1003,
			TextureRedSize = 0x805C,
			TextureWidth = 0x1000,
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

		public enum TextureUnit : uint
		{
			Texture0 = 0x84C0,
			Texture1 = 0x84C1,
			Texture2 = 0x84C2,
			Texture3 = 0x84C3,
			Texture4 = 0x84C4,
			Texture5 = 0x84C5,
			Texture6 = 0x84C6,
			Texture7 = 0x84C7,
			Texture8 = 0x84C8,
			Texture9 = 0x84C9,
			Texture10 = 0x84CA,
			Texture11 = 0x84CB,
			Texture12 = 0x84CC,
			Texture13 = 0x84CD,
			Texture14 = 0x84CE,
			Texture15 = 0x84CF,
			Texture16 = 0x84D0,
			Texture17 = 0x84D1,
			Texture18 = 0x84D2,
			Texture19 = 0x84D3,
			Texture20 = 0x84D4,
			Texture21 = 0x84D5,
			Texture22 = 0x84D6,
			Texture23 = 0x84D7,
			Texture24 = 0x84D8,
			Texture25 = 0x84D9,
			Texture26 = 0x84DA,
			Texture27 = 0x84DB,
			Texture28 = 0x84DC,
			Texture29 = 0x84DD,
			Texture30 = 0x84DE,
			Texture31 = 0x84DF,
		}

		public enum TransformFeedbackPName : uint
		{
			TransformFeedbackBufferBinding = 0x8C8F,
			TransformFeedbackBufferStart = 0x8C84,
			TransformFeedbackBufferSize = 0x8C85,
			TransformFeedbackPaused = 0x8E23,
			TransformFeedbackActive = 0x8E24,
		}

		public enum TypeEnum : uint
		{
			QueryWait = 0x8E13,
			QueryNoWait = 0x8E14,
			QueryByRegionWait = 0x8E15,
			QueryByRegionNoWait = 0x8E16,
		}

		public enum UniformBlockPName : uint
		{
			UniformBlockBinding = 0x8A3F,
			UniformBlockDataSize = 0x8A40,
			UniformBlockNameLength = 0x8A41,
			UniformBlockActiveUniforms = 0x8A42,
			UniformBlockActiveUniformIndices = 0x8A43,
			UniformBlockReferencedByVertexShader = 0x8A44,
			UniformBlockReferencedByTessControlShader = 0x84F0,
			UniformBlockReferencedByTessEvaluationShader = 0x84F1,
			UniformBlockReferencedByGeometryShader = 0x8A45,
			UniformBlockReferencedByFragmentShader = 0x8A46,
			UniformBlockReferencedByComputeShader = 0x90EC,
		}

		public enum UniformPName : uint
		{
			UniformType = 0x8A37,
			UniformSize = 0x8A38,
			UniformNameLength = 0x8A39,
			UniformBlockIndex = 0x8A3A,
			UniformOffset = 0x8A3B,
			UniformArrayStride = 0x8A3C,
			UniformMatrixStride = 0x8A3D,
			UniformIsRowMajor = 0x8A3E,
			UniformAtomicCounterBufferIndex = 0x92DA,
		}

		public enum UseProgramStageMask : uint
		{
			VertexShaderBit = 0x00000001,
			FragmentShaderBit = 0x00000002,
			GeometryShaderBit = 0x00000004,
			TessControlShaderBit = 0x00000008,
			TessEvaluationShaderBit = 0x00000010,
			ComputeShaderBit = 0x00000020,
			AllShaderBits = 0xFFFFFFFF,
		}

		public enum VertexArrayPName : uint
		{
			VertexAttribArrayEnabled = 0x8622,
			VertexAttribArraySize = 0x8623,
			VertexAttribArrayStride = 0x8624,
			VertexAttribArrayType = 0x8625,
			VertexAttribArrayNormalized = 0x886A,
			VertexAttribArrayInteger = 0x88FD,
			VertexAttribArrayLong = 0x874E,
			VertexAttribArrayDivisor = 0x88FE,
			VertexAttribRelativeOffset = 0x82D5,
		}

		public enum VertexAttribEnum : uint
		{
			VertexAttribArrayBufferBinding = 0x889F,
			VertexAttribArrayEnabled = 0x8622,
			VertexAttribArraySize = 0x8623,
			VertexAttribArrayStride = 0x8624,
			VertexAttribArrayType = 0x8625,
			VertexAttribArrayNormalized = 0x886A,
			VertexAttribArrayInteger = 0x88FD,
			VertexAttribArrayDivisor = 0x88FE,
			CurrentVertexAttrib = 0x8626,
		}

		public enum VertexAttribPointerType : uint
		{
			Byte = 0x1400,
			UnsignedByte = 0x1401,
			Short = 0x1402,
			UnsignedShort = 0x1403,
			Int = 0x1404,
			UnsignedInt = 0x1405,
			Float = 0x1406,
			Double = 0x140A,
			HalfFloat = 0x140B,
			Fixed = 0x140C,
			Int2101010Rev = 0x8D9F,
			UnsignedInt2101010Rev = 0x8368,
			UnsignedInt10f11f11fRev = 0x8C3B,
		}

		public enum VertexAttribType : uint
		{
			Byte = 0x1400,
			Short = 0x1402,
			Int = 0x1404,
			Fixed = 0x140C,
			Float = 0x1406,
			HalfFloat = 0x140B,
			Double = 0x140A,
			UnsignedByte = 0x1401,
			UnsignedShort = 0x1403,
			UnsignedInt = 0x1405,
			Int2101010Rev = 0x8D9F,
			UnsignedInt2101010Rev = 0x8368,
			UnsignedInt10f11f11fRev = 0x8C3B,
		}

		public enum VertexBufferObjectParameter : uint
		{
			BufferAccess = 0x88BB,
			BufferAccessFlags = 0x911F,
			BufferImmutableStorage = 0x821F,
			BufferMapped = 0x88BC,
			BufferMapLength = 0x9120,
			BufferMapOffset = 0x9121,
			BufferSize = 0x8764,
			BufferStorageFlags = 0x8220,
			BufferUsage = 0x8765,
		}

		public enum VertexBufferObjectUsage : uint
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

		public enum VertexProvokingMode : uint
		{
			FirstVertexConvention = 0x8E4D,
			LastVertexConvention = 0x8E4E,
		}

}
