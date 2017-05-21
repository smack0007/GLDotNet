using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GLDotNet
{
	public sealed partial class GL
	{
		public const uint ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
		public const uint ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
		public const uint ACTIVE_ATTRIBUTES = 0x8B89;
		public const uint ACTIVE_PROGRAM = 0x8259;
		public const uint ACTIVE_RESOURCES = 0x92F5;
		public const uint ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
		public const uint ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
		public const uint ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
		public const uint ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
		public const uint ACTIVE_SUBROUTINES = 0x8DE5;
		public const uint ACTIVE_TEXTURE = 0x84E0;
		public const uint ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
		public const uint ACTIVE_UNIFORM_BLOCKS = 0x8A36;
		public const uint ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
		public const uint ACTIVE_UNIFORMS = 0x8B86;
		public const uint ACTIVE_VARIABLES = 0x9305;
		public const uint ALIASED_LINE_WIDTH_RANGE = 0x846E;
		public const uint ALL_BARRIER_BITS = 0xFFFFFFFF;
		public const uint ALL_SHADER_BITS = 0xFFFFFFFF;
		public const uint ALPHA = 0x1906;
		public const uint ALREADY_SIGNALED = 0x911A;
		public const uint ALWAYS = 0x0207;
		public const uint AND = 0x1501;
		public const uint AND_INVERTED = 0x1504;
		public const uint AND_REVERSE = 0x1502;
		public const uint ANY_SAMPLES_PASSED = 0x8C2F;
		public const uint ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
		public const uint ARRAY_BUFFER = 0x8892;
		public const uint ARRAY_BUFFER_BINDING = 0x8894;
		public const uint ARRAY_SIZE = 0x92FB;
		public const uint ARRAY_STRIDE = 0x92FE;
		public const uint ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
		public const uint ATOMIC_COUNTER_BUFFER = 0x92C0;
		public const uint ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
		public const uint ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
		public const uint ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
		public const uint ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
		public const uint ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
		public const uint ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
		public const uint ATOMIC_COUNTER_BUFFER_START = 0x92C2;
		public const uint ATTACHED_SHADERS = 0x8B85;
		public const uint AUTO_GENERATE_MIPMAP = 0x8295;
		public const uint BACK = 0x0405;
		public const uint BACK_LEFT = 0x0402;
		public const uint BACK_RIGHT = 0x0403;
		public const uint BGR = 0x80E0;
		public const uint BGR_INTEGER = 0x8D9A;
		public const uint BGRA = 0x80E1;
		public const uint BGRA_INTEGER = 0x8D9B;
		public const uint BLEND = 0x0BE2;
		public const uint BLEND_DST = 0x0BE0;
		public const uint BLEND_DST_ALPHA = 0x80CA;
		public const uint BLEND_DST_RGB = 0x80C8;
		public const uint BLEND_EQUATION_ALPHA = 0x883D;
		public const uint BLEND_EQUATION_RGB = 0x8009;
		public const uint BLEND_SRC = 0x0BE1;
		public const uint BLEND_SRC_ALPHA = 0x80CB;
		public const uint BLEND_SRC_RGB = 0x80C9;
		public const uint BLOCK_INDEX = 0x92FD;
		public const uint BLUE = 0x1905;
		public const uint BLUE_INTEGER = 0x8D96;
		public const uint BOOL = 0x8B56;
		public const uint BOOL_VEC2 = 0x8B57;
		public const uint BOOL_VEC3 = 0x8B58;
		public const uint BOOL_VEC4 = 0x8B59;
		public const uint BUFFER = 0x82E0;
		public const uint BUFFER_ACCESS = 0x88BB;
		public const uint BUFFER_ACCESS_FLAGS = 0x911F;
		public const uint BUFFER_BINDING = 0x9302;
		public const uint BUFFER_DATA_SIZE = 0x9303;
		public const uint BUFFER_IMMUTABLE_STORAGE = 0x821F;
		public const uint BUFFER_MAP_LENGTH = 0x9120;
		public const uint BUFFER_MAP_OFFSET = 0x9121;
		public const uint BUFFER_MAP_POINTER = 0x88BD;
		public const uint BUFFER_MAPPED = 0x88BC;
		public const uint BUFFER_SIZE = 0x8764;
		public const uint BUFFER_STORAGE_FLAGS = 0x8220;
		public const uint BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
		public const uint BUFFER_USAGE = 0x8765;
		public const uint BUFFER_VARIABLE = 0x92E5;
		public const uint BYTE = 0x1400;
		public const uint CAVEAT_SUPPORT = 0x82B8;
		public const uint CCW = 0x0901;
		public const uint CLAMP_READ_COLOR = 0x891C;
		public const uint CLAMP_TO_BORDER = 0x812D;
		public const uint CLAMP_TO_EDGE = 0x812F;
		public const uint CLEAR = 0x1500;
		public const uint CLEAR_BUFFER = 0x82B4;
		public const uint CLEAR_TEXTURE = 0x9365;
		public const uint CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
		public const uint CLIENT_STORAGE_BIT = 0x0200;
		public const uint CLIP_DEPTH_MODE = 0x935D;
		public const uint CLIP_DISTANCE0 = 0x3000;
		public const uint CLIP_DISTANCE1 = 0x3001;
		public const uint CLIP_DISTANCE2 = 0x3002;
		public const uint CLIP_DISTANCE3 = 0x3003;
		public const uint CLIP_DISTANCE4 = 0x3004;
		public const uint CLIP_DISTANCE5 = 0x3005;
		public const uint CLIP_DISTANCE6 = 0x3006;
		public const uint CLIP_DISTANCE7 = 0x3007;
		public const uint CLIP_ORIGIN = 0x935C;
		public const uint COLOR = 0x1800;
		public const uint COLOR_ATTACHMENT0 = 0x8CE0;
		public const uint COLOR_ATTACHMENT1 = 0x8CE1;
		public const uint COLOR_ATTACHMENT10 = 0x8CEA;
		public const uint COLOR_ATTACHMENT11 = 0x8CEB;
		public const uint COLOR_ATTACHMENT12 = 0x8CEC;
		public const uint COLOR_ATTACHMENT13 = 0x8CED;
		public const uint COLOR_ATTACHMENT14 = 0x8CEE;
		public const uint COLOR_ATTACHMENT15 = 0x8CEF;
		public const uint COLOR_ATTACHMENT16 = 0x8CF0;
		public const uint COLOR_ATTACHMENT17 = 0x8CF1;
		public const uint COLOR_ATTACHMENT18 = 0x8CF2;
		public const uint COLOR_ATTACHMENT19 = 0x8CF3;
		public const uint COLOR_ATTACHMENT2 = 0x8CE2;
		public const uint COLOR_ATTACHMENT20 = 0x8CF4;
		public const uint COLOR_ATTACHMENT21 = 0x8CF5;
		public const uint COLOR_ATTACHMENT22 = 0x8CF6;
		public const uint COLOR_ATTACHMENT23 = 0x8CF7;
		public const uint COLOR_ATTACHMENT24 = 0x8CF8;
		public const uint COLOR_ATTACHMENT25 = 0x8CF9;
		public const uint COLOR_ATTACHMENT26 = 0x8CFA;
		public const uint COLOR_ATTACHMENT27 = 0x8CFB;
		public const uint COLOR_ATTACHMENT28 = 0x8CFC;
		public const uint COLOR_ATTACHMENT29 = 0x8CFD;
		public const uint COLOR_ATTACHMENT3 = 0x8CE3;
		public const uint COLOR_ATTACHMENT30 = 0x8CFE;
		public const uint COLOR_ATTACHMENT31 = 0x8CFF;
		public const uint COLOR_ATTACHMENT4 = 0x8CE4;
		public const uint COLOR_ATTACHMENT5 = 0x8CE5;
		public const uint COLOR_ATTACHMENT6 = 0x8CE6;
		public const uint COLOR_ATTACHMENT7 = 0x8CE7;
		public const uint COLOR_ATTACHMENT8 = 0x8CE8;
		public const uint COLOR_ATTACHMENT9 = 0x8CE9;
		public const uint COLOR_BUFFER_BIT = 0x00004000;
		public const uint COLOR_CLEAR_VALUE = 0x0C22;
		public const uint COLOR_COMPONENTS = 0x8283;
		public const uint COLOR_ENCODING = 0x8296;
		public const uint COLOR_LOGIC_OP = 0x0BF2;
		public const uint COLOR_RENDERABLE = 0x8286;
		public const uint COLOR_WRITEMASK = 0x0C23;
		public const uint COMMAND_BARRIER_BIT = 0x00000040;
		public const uint COMPARE_REF_TO_TEXTURE = 0x884E;
		public const uint COMPATIBLE_SUBROUTINES = 0x8E4B;
		public const uint COMPILE_STATUS = 0x8B81;
		public const uint COMPRESSED_R11_EAC = 0x9270;
		public const uint COMPRESSED_RED = 0x8225;
		public const uint COMPRESSED_RED_RGTC1 = 0x8DBB;
		public const uint COMPRESSED_RG = 0x8226;
		public const uint COMPRESSED_RG_RGTC2 = 0x8DBD;
		public const uint COMPRESSED_RG11_EAC = 0x9272;
		public const uint COMPRESSED_RGB = 0x84ED;
		public const uint COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;
		public const uint COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;
		public const uint COMPRESSED_RGB8_ETC2 = 0x9274;
		public const uint COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
		public const uint COMPRESSED_RGBA = 0x84EE;
		public const uint COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;
		public const uint COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
		public const uint COMPRESSED_SIGNED_R11_EAC = 0x9271;
		public const uint COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
		public const uint COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
		public const uint COMPRESSED_SIGNED_RG11_EAC = 0x9273;
		public const uint COMPRESSED_SRGB = 0x8C48;
		public const uint COMPRESSED_SRGB_ALPHA = 0x8C49;
		public const uint COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;
		public const uint COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
		public const uint COMPRESSED_SRGB8_ETC2 = 0x9275;
		public const uint COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
		public const uint COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		public const uint COMPUTE_SHADER = 0x91B9;
		public const uint COMPUTE_SHADER_BIT = 0x00000020;
		public const uint COMPUTE_SUBROUTINE = 0x92ED;
		public const uint COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
		public const uint COMPUTE_TEXTURE = 0x82A0;
		public const uint COMPUTE_WORK_GROUP_SIZE = 0x8267;
		public const uint CONDITION_SATISFIED = 0x911C;
		public const uint CONSTANT_ALPHA = 0x8003;
		public const uint CONSTANT_COLOR = 0x8001;
		public const uint CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
		public const uint CONTEXT_CORE_PROFILE_BIT = 0x00000001;
		public const uint CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
		public const uint CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
		public const uint CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
		public const uint CONTEXT_FLAGS = 0x821E;
		public const uint CONTEXT_LOST = 0x0507;
		public const uint CONTEXT_PROFILE_MASK = 0x9126;
		public const uint CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
		public const uint CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
		public const uint COPY = 0x1503;
		public const uint COPY_INVERTED = 0x150C;
		public const uint COPY_READ_BUFFER = 0x8F36;
		public const uint COPY_READ_BUFFER_BINDING = 0x8F36;
		public const uint COPY_WRITE_BUFFER = 0x8F37;
		public const uint COPY_WRITE_BUFFER_BINDING = 0x8F37;
		public const uint CULL_FACE = 0x0B44;
		public const uint CULL_FACE_MODE = 0x0B45;
		public const uint CURRENT_PROGRAM = 0x8B8D;
		public const uint CURRENT_QUERY = 0x8865;
		public const uint CURRENT_VERTEX_ATTRIB = 0x8626;
		public const uint CW = 0x0900;
		public const uint DEBUG_CALLBACK_FUNCTION = 0x8244;
		public const uint DEBUG_CALLBACK_USER_PARAM = 0x8245;
		public const uint DEBUG_GROUP_STACK_DEPTH = 0x826D;
		public const uint DEBUG_LOGGED_MESSAGES = 0x9145;
		public const uint DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
		public const uint DEBUG_OUTPUT = 0x92E0;
		public const uint DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
		public const uint DEBUG_SEVERITY_HIGH = 0x9146;
		public const uint DEBUG_SEVERITY_LOW = 0x9148;
		public const uint DEBUG_SEVERITY_MEDIUM = 0x9147;
		public const uint DEBUG_SEVERITY_NOTIFICATION = 0x826B;
		public const uint DEBUG_SOURCE_API = 0x8246;
		public const uint DEBUG_SOURCE_APPLICATION = 0x824A;
		public const uint DEBUG_SOURCE_OTHER = 0x824B;
		public const uint DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
		public const uint DEBUG_SOURCE_THIRD_PARTY = 0x8249;
		public const uint DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
		public const uint DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
		public const uint DEBUG_TYPE_ERROR = 0x824C;
		public const uint DEBUG_TYPE_MARKER = 0x8268;
		public const uint DEBUG_TYPE_OTHER = 0x8251;
		public const uint DEBUG_TYPE_PERFORMANCE = 0x8250;
		public const uint DEBUG_TYPE_POP_GROUP = 0x826A;
		public const uint DEBUG_TYPE_PORTABILITY = 0x824F;
		public const uint DEBUG_TYPE_PUSH_GROUP = 0x8269;
		public const uint DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
		public const uint DECR = 0x1E03;
		public const uint DECR_WRAP = 0x8508;
		public const uint DELETE_STATUS = 0x8B80;
		public const uint DEPTH = 0x1801;
		public const uint DEPTH_ATTACHMENT = 0x8D00;
		public const uint DEPTH_BUFFER_BIT = 0x00000100;
		public const uint DEPTH_CLAMP = 0x864F;
		public const uint DEPTH_CLEAR_VALUE = 0x0B73;
		public const uint DEPTH_COMPONENT = 0x1902;
		public const uint DEPTH_COMPONENT16 = 0x81A5;
		public const uint DEPTH_COMPONENT24 = 0x81A6;
		public const uint DEPTH_COMPONENT32 = 0x81A7;
		public const uint DEPTH_COMPONENT32F = 0x8CAC;
		public const uint DEPTH_COMPONENTS = 0x8284;
		public const uint DEPTH_FUNC = 0x0B74;
		public const uint DEPTH_RANGE = 0x0B70;
		public const uint DEPTH_RENDERABLE = 0x8287;
		public const uint DEPTH_STENCIL = 0x84F9;
		public const uint DEPTH_STENCIL_ATTACHMENT = 0x821A;
		public const uint DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
		public const uint DEPTH_TEST = 0x0B71;
		public const uint DEPTH_WRITEMASK = 0x0B72;
		public const uint DEPTH24_STENCIL8 = 0x88F0;
		public const uint DEPTH32F_STENCIL8 = 0x8CAD;
		public const uint DISPATCH_INDIRECT_BUFFER = 0x90EE;
		public const uint DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
		public const uint DITHER = 0x0BD0;
		public const uint DONT_CARE = 0x1100;
		public const uint DOUBLE = 0x140A;
		public const uint DOUBLE_MAT2 = 0x8F46;
		public const uint DOUBLE_MAT2x3 = 0x8F49;
		public const uint DOUBLE_MAT2x4 = 0x8F4A;
		public const uint DOUBLE_MAT3 = 0x8F47;
		public const uint DOUBLE_MAT3x2 = 0x8F4B;
		public const uint DOUBLE_MAT3x4 = 0x8F4C;
		public const uint DOUBLE_MAT4 = 0x8F48;
		public const uint DOUBLE_MAT4x2 = 0x8F4D;
		public const uint DOUBLE_MAT4x3 = 0x8F4E;
		public const uint DOUBLE_VEC2 = 0x8FFC;
		public const uint DOUBLE_VEC3 = 0x8FFD;
		public const uint DOUBLE_VEC4 = 0x8FFE;
		public const uint DOUBLEBUFFER = 0x0C32;
		public const uint DRAW_BUFFER = 0x0C01;
		public const uint DRAW_BUFFER0 = 0x8825;
		public const uint DRAW_BUFFER1 = 0x8826;
		public const uint DRAW_BUFFER10 = 0x882F;
		public const uint DRAW_BUFFER11 = 0x8830;
		public const uint DRAW_BUFFER12 = 0x8831;
		public const uint DRAW_BUFFER13 = 0x8832;
		public const uint DRAW_BUFFER14 = 0x8833;
		public const uint DRAW_BUFFER15 = 0x8834;
		public const uint DRAW_BUFFER2 = 0x8827;
		public const uint DRAW_BUFFER3 = 0x8828;
		public const uint DRAW_BUFFER4 = 0x8829;
		public const uint DRAW_BUFFER5 = 0x882A;
		public const uint DRAW_BUFFER6 = 0x882B;
		public const uint DRAW_BUFFER7 = 0x882C;
		public const uint DRAW_BUFFER8 = 0x882D;
		public const uint DRAW_BUFFER9 = 0x882E;
		public const uint DRAW_FRAMEBUFFER = 0x8CA9;
		public const uint DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint DRAW_INDIRECT_BUFFER = 0x8F3F;
		public const uint DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
		public const uint DST_ALPHA = 0x0304;
		public const uint DST_COLOR = 0x0306;
		public const uint DYNAMIC_COPY = 0x88EA;
		public const uint DYNAMIC_DRAW = 0x88E8;
		public const uint DYNAMIC_READ = 0x88E9;
		public const uint DYNAMIC_STORAGE_BIT = 0x0100;
		public const uint ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
		public const uint ELEMENT_ARRAY_BUFFER = 0x8893;
		public const uint ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
		public const uint EQUAL = 0x0202;
		public const uint EQUIV = 0x1509;
		public const uint EXTENSIONS = 0x1F03;
		public const uint FALSE = 0;
		public const uint FASTEST = 0x1101;
		public const uint FILL = 0x1B02;
		public const uint FILTER = 0x829A;
		public const uint FIRST_VERTEX_CONVENTION = 0x8E4D;
		public const uint FIXED = 0x140C;
		public const uint FIXED_ONLY = 0x891D;
		public const uint FLOAT = 0x1406;
		public const uint FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
		public const uint FLOAT_MAT2 = 0x8B5A;
		public const uint FLOAT_MAT2x3 = 0x8B65;
		public const uint FLOAT_MAT2x4 = 0x8B66;
		public const uint FLOAT_MAT3 = 0x8B5B;
		public const uint FLOAT_MAT3x2 = 0x8B67;
		public const uint FLOAT_MAT3x4 = 0x8B68;
		public const uint FLOAT_MAT4 = 0x8B5C;
		public const uint FLOAT_MAT4x2 = 0x8B69;
		public const uint FLOAT_MAT4x3 = 0x8B6A;
		public const uint FLOAT_VEC2 = 0x8B50;
		public const uint FLOAT_VEC3 = 0x8B51;
		public const uint FLOAT_VEC4 = 0x8B52;
		public const uint FRACTIONAL_EVEN = 0x8E7C;
		public const uint FRACTIONAL_ODD = 0x8E7B;
		public const uint FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
		public const uint FRAGMENT_SHADER = 0x8B30;
		public const uint FRAGMENT_SHADER_BIT = 0x00000002;
		public const uint FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
		public const uint FRAGMENT_SUBROUTINE = 0x92EC;
		public const uint FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
		public const uint FRAGMENT_TEXTURE = 0x829F;
		public const uint FRAMEBUFFER = 0x8D40;
		public const uint FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
		public const uint FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
		public const uint FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
		public const uint FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
		public const uint FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
		public const uint FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
		public const uint FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
		public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		public const uint FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
		public const uint FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		public const uint FRAMEBUFFER_BARRIER_BIT = 0x00000400;
		public const uint FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint FRAMEBUFFER_BLEND = 0x828B;
		public const uint FRAMEBUFFER_COMPLETE = 0x8CD5;
		public const uint FRAMEBUFFER_DEFAULT = 0x8218;
		public const uint FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
		public const uint FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
		public const uint FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
		public const uint FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
		public const uint FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
		public const uint FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		public const uint FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
		public const uint FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
		public const uint FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		public const uint FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
		public const uint FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
		public const uint FRAMEBUFFER_RENDERABLE = 0x8289;
		public const uint FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
		public const uint FRAMEBUFFER_SRGB = 0x8DB9;
		public const uint FRAMEBUFFER_UNDEFINED = 0x8219;
		public const uint FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		public const uint FRONT = 0x0404;
		public const uint FRONT_AND_BACK = 0x0408;
		public const uint FRONT_FACE = 0x0B46;
		public const uint FRONT_LEFT = 0x0400;
		public const uint FRONT_RIGHT = 0x0401;
		public const uint FULL_SUPPORT = 0x82B7;
		public const uint FUNC_ADD = 0x8006;
		public const uint FUNC_REVERSE_SUBTRACT = 0x800B;
		public const uint FUNC_SUBTRACT = 0x800A;
		public const uint GEOMETRY_INPUT_TYPE = 0x8917;
		public const uint GEOMETRY_OUTPUT_TYPE = 0x8918;
		public const uint GEOMETRY_SHADER = 0x8DD9;
		public const uint GEOMETRY_SHADER_BIT = 0x00000004;
		public const uint GEOMETRY_SHADER_INVOCATIONS = 0x887F;
		public const uint GEOMETRY_SUBROUTINE = 0x92EB;
		public const uint GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
		public const uint GEOMETRY_TEXTURE = 0x829E;
		public const uint GEOMETRY_VERTICES_OUT = 0x8916;
		public const uint GEQUAL = 0x0206;
		public const uint GET_TEXTURE_IMAGE_FORMAT = 0x8291;
		public const uint GET_TEXTURE_IMAGE_TYPE = 0x8292;
		public const uint GREATER = 0x0204;
		public const uint GREEN = 0x1904;
		public const uint GREEN_INTEGER = 0x8D95;
		public const uint GUILTY_CONTEXT_RESET = 0x8253;
		public const uint HALF_FLOAT = 0x140B;
		public const uint HIGH_FLOAT = 0x8DF2;
		public const uint HIGH_INT = 0x8DF5;
		public const uint IMAGE_1D = 0x904C;
		public const uint IMAGE_1D_ARRAY = 0x9052;
		public const uint IMAGE_2D = 0x904D;
		public const uint IMAGE_2D_ARRAY = 0x9053;
		public const uint IMAGE_2D_MULTISAMPLE = 0x9055;
		public const uint IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
		public const uint IMAGE_2D_RECT = 0x904F;
		public const uint IMAGE_3D = 0x904E;
		public const uint IMAGE_BINDING_ACCESS = 0x8F3E;
		public const uint IMAGE_BINDING_FORMAT = 0x906E;
		public const uint IMAGE_BINDING_LAYER = 0x8F3D;
		public const uint IMAGE_BINDING_LAYERED = 0x8F3C;
		public const uint IMAGE_BINDING_LEVEL = 0x8F3B;
		public const uint IMAGE_BINDING_NAME = 0x8F3A;
		public const uint IMAGE_BUFFER = 0x9051;
		public const uint IMAGE_CLASS_1_X_16 = 0x82BE;
		public const uint IMAGE_CLASS_1_X_32 = 0x82BB;
		public const uint IMAGE_CLASS_1_X_8 = 0x82C1;
		public const uint IMAGE_CLASS_10_10_10_2 = 0x82C3;
		public const uint IMAGE_CLASS_11_11_10 = 0x82C2;
		public const uint IMAGE_CLASS_2_X_16 = 0x82BD;
		public const uint IMAGE_CLASS_2_X_32 = 0x82BA;
		public const uint IMAGE_CLASS_2_X_8 = 0x82C0;
		public const uint IMAGE_CLASS_4_X_16 = 0x82BC;
		public const uint IMAGE_CLASS_4_X_32 = 0x82B9;
		public const uint IMAGE_CLASS_4_X_8 = 0x82BF;
		public const uint IMAGE_COMPATIBILITY_CLASS = 0x82A8;
		public const uint IMAGE_CUBE = 0x9050;
		public const uint IMAGE_CUBE_MAP_ARRAY = 0x9054;
		public const uint IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
		public const uint IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
		public const uint IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
		public const uint IMAGE_PIXEL_FORMAT = 0x82A9;
		public const uint IMAGE_PIXEL_TYPE = 0x82AA;
		public const uint IMAGE_TEXEL_SIZE = 0x82A7;
		public const uint IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
		public const uint IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
		public const uint INCR = 0x1E02;
		public const uint INCR_WRAP = 0x8507;
		public const uint INFO_LOG_LENGTH = 0x8B84;
		public const uint INNOCENT_CONTEXT_RESET = 0x8254;
		public const uint INT = 0x1404;
		public const uint INT_2_10_10_10_REV = 0x8D9F;
		public const uint INT_IMAGE_1D = 0x9057;
		public const uint INT_IMAGE_1D_ARRAY = 0x905D;
		public const uint INT_IMAGE_2D = 0x9058;
		public const uint INT_IMAGE_2D_ARRAY = 0x905E;
		public const uint INT_IMAGE_2D_MULTISAMPLE = 0x9060;
		public const uint INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
		public const uint INT_IMAGE_2D_RECT = 0x905A;
		public const uint INT_IMAGE_3D = 0x9059;
		public const uint INT_IMAGE_BUFFER = 0x905C;
		public const uint INT_IMAGE_CUBE = 0x905B;
		public const uint INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
		public const uint INT_SAMPLER_1D = 0x8DC9;
		public const uint INT_SAMPLER_1D_ARRAY = 0x8DCE;
		public const uint INT_SAMPLER_2D = 0x8DCA;
		public const uint INT_SAMPLER_2D_ARRAY = 0x8DCF;
		public const uint INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
		public const uint INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
		public const uint INT_SAMPLER_2D_RECT = 0x8DCD;
		public const uint INT_SAMPLER_3D = 0x8DCB;
		public const uint INT_SAMPLER_BUFFER = 0x8DD0;
		public const uint INT_SAMPLER_CUBE = 0x8DCC;
		public const uint INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
		public const uint INT_VEC2 = 0x8B53;
		public const uint INT_VEC3 = 0x8B54;
		public const uint INT_VEC4 = 0x8B55;
		public const uint INTERLEAVED_ATTRIBS = 0x8C8C;
		public const uint INTERNALFORMAT_ALPHA_SIZE = 0x8274;
		public const uint INTERNALFORMAT_ALPHA_TYPE = 0x827B;
		public const uint INTERNALFORMAT_BLUE_SIZE = 0x8273;
		public const uint INTERNALFORMAT_BLUE_TYPE = 0x827A;
		public const uint INTERNALFORMAT_DEPTH_SIZE = 0x8275;
		public const uint INTERNALFORMAT_DEPTH_TYPE = 0x827C;
		public const uint INTERNALFORMAT_GREEN_SIZE = 0x8272;
		public const uint INTERNALFORMAT_GREEN_TYPE = 0x8279;
		public const uint INTERNALFORMAT_PREFERRED = 0x8270;
		public const uint INTERNALFORMAT_RED_SIZE = 0x8271;
		public const uint INTERNALFORMAT_RED_TYPE = 0x8278;
		public const uint INTERNALFORMAT_SHARED_SIZE = 0x8277;
		public const uint INTERNALFORMAT_STENCIL_SIZE = 0x8276;
		public const uint INTERNALFORMAT_STENCIL_TYPE = 0x827D;
		public const uint INTERNALFORMAT_SUPPORTED = 0x826F;
		public const uint INVALID_ENUM = 0x0500;
		public const uint INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		public const uint INVALID_INDEX = 0xFFFFFFFFu;
		public const uint INVALID_OPERATION = 0x0502;
		public const uint INVALID_VALUE = 0x0501;
		public const uint INVERT = 0x150A;
		public const uint IS_PER_PATCH = 0x92E7;
		public const uint IS_ROW_MAJOR = 0x9300;
		public const uint ISOLINES = 0x8E7A;
		public const uint KEEP = 0x1E00;
		public const uint LAST_VERTEX_CONVENTION = 0x8E4E;
		public const uint LAYER_PROVOKING_VERTEX = 0x825E;
		public const uint LEFT = 0x0406;
		public const uint LEQUAL = 0x0203;
		public const uint LESS = 0x0201;
		public const uint LINE = 0x1B01;
		public const uint LINE_LOOP = 0x0002;
		public const uint LINE_SMOOTH = 0x0B20;
		public const uint LINE_SMOOTH_HINT = 0x0C52;
		public const uint LINE_STRIP = 0x0003;
		public const uint LINE_STRIP_ADJACENCY = 0x000B;
		public const uint LINE_WIDTH = 0x0B21;
		public const uint LINE_WIDTH_GRANULARITY = 0x0B23;
		public const uint LINE_WIDTH_RANGE = 0x0B22;
		public const uint LINEAR = 0x2601;
		public const uint LINEAR_MIPMAP_LINEAR = 0x2703;
		public const uint LINEAR_MIPMAP_NEAREST = 0x2701;
		public const uint LINES = 0x0001;
		public const uint LINES_ADJACENCY = 0x000A;
		public const uint LINK_STATUS = 0x8B82;
		public const uint LOCATION = 0x930E;
		public const uint LOCATION_COMPONENT = 0x934A;
		public const uint LOCATION_INDEX = 0x930F;
		public const uint LOGIC_OP_MODE = 0x0BF0;
		public const uint LOSE_CONTEXT_ON_RESET = 0x8252;
		public const uint LOW_FLOAT = 0x8DF0;
		public const uint LOW_INT = 0x8DF3;
		public const uint LOWER_LEFT = 0x8CA1;
		public const uint MAJOR_VERSION = 0x821B;
		public const uint MANUAL_GENERATE_MIPMAP = 0x8294;
		public const uint MAP_COHERENT_BIT = 0x0080;
		public const uint MAP_FLUSH_EXPLICIT_BIT = 0x0010;
		public const uint MAP_INVALIDATE_BUFFER_BIT = 0x0008;
		public const uint MAP_INVALIDATE_RANGE_BIT = 0x0004;
		public const uint MAP_PERSISTENT_BIT = 0x0040;
		public const uint MAP_READ_BIT = 0x0001;
		public const uint MAP_UNSYNCHRONIZED_BIT = 0x0020;
		public const uint MAP_WRITE_BIT = 0x0002;
		public const uint MATRIX_STRIDE = 0x92FF;
		public const uint MAX = 0x8008;
		public const uint MAX_3D_TEXTURE_SIZE = 0x8073;
		public const uint MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
		public const uint MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
		public const uint MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
		public const uint MAX_CLIP_DISTANCES = 0x0D32;
		public const uint MAX_COLOR_ATTACHMENTS = 0x8CDF;
		public const uint MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
		public const uint MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
		public const uint MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
		public const uint MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
		public const uint MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
		public const uint MAX_COMBINED_DIMENSIONS = 0x8282;
		public const uint MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
		public const uint MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
		public const uint MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
		public const uint MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
		public const uint MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
		public const uint MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
		public const uint MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
		public const uint MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
		public const uint MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
		public const uint MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
		public const uint MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
		public const uint MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
		public const uint MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
		public const uint MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
		public const uint MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
		public const uint MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
		public const uint MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
		public const uint MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
		public const uint MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
		public const uint MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
		public const uint MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
		public const uint MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
		public const uint MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		public const uint MAX_CULL_DISTANCES = 0x82F9;
		public const uint MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
		public const uint MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
		public const uint MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
		public const uint MAX_DEPTH = 0x8280;
		public const uint MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
		public const uint MAX_DRAW_BUFFERS = 0x8824;
		public const uint MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
		public const uint MAX_ELEMENT_INDEX = 0x8D6B;
		public const uint MAX_ELEMENTS_INDICES = 0x80E9;
		public const uint MAX_ELEMENTS_VERTICES = 0x80E8;
		public const uint MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
		public const uint MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
		public const uint MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
		public const uint MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
		public const uint MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
		public const uint MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
		public const uint MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
		public const uint MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
		public const uint MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
		public const uint MAX_FRAMEBUFFER_HEIGHT = 0x9316;
		public const uint MAX_FRAMEBUFFER_LAYERS = 0x9317;
		public const uint MAX_FRAMEBUFFER_SAMPLES = 0x9318;
		public const uint MAX_FRAMEBUFFER_WIDTH = 0x9315;
		public const uint MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
		public const uint MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
		public const uint MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
		public const uint MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
		public const uint MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
		public const uint MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
		public const uint MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
		public const uint MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
		public const uint MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
		public const uint MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
		public const uint MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
		public const uint MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
		public const uint MAX_HEIGHT = 0x827F;
		public const uint MAX_IMAGE_SAMPLES = 0x906D;
		public const uint MAX_IMAGE_UNITS = 0x8F38;
		public const uint MAX_INTEGER_SAMPLES = 0x9110;
		public const uint MAX_LABEL_LENGTH = 0x82E8;
		public const uint MAX_LAYERS = 0x8281;
		public const uint MAX_NAME_LENGTH = 0x92F6;
		public const uint MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
		public const uint MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
		public const uint MAX_PATCH_VERTICES = 0x8E7D;
		public const uint MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
		public const uint MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
		public const uint MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
		public const uint MAX_RENDERBUFFER_SIZE = 0x84E8;
		public const uint MAX_SAMPLE_MASK_WORDS = 0x8E59;
		public const uint MAX_SAMPLES = 0x8D57;
		public const uint MAX_SERVER_WAIT_TIMEOUT = 0x9111;
		public const uint MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
		public const uint MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
		public const uint MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
		public const uint MAX_SUBROUTINES = 0x8DE7;
		public const uint MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
		public const uint MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
		public const uint MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
		public const uint MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
		public const uint MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
		public const uint MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
		public const uint MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
		public const uint MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
		public const uint MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
		public const uint MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
		public const uint MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
		public const uint MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
		public const uint MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
		public const uint MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
		public const uint MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
		public const uint MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
		public const uint MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
		public const uint MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
		public const uint MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
		public const uint MAX_TESS_GEN_LEVEL = 0x8E7E;
		public const uint MAX_TESS_PATCH_COMPONENTS = 0x8E84;
		public const uint MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
		public const uint MAX_TEXTURE_IMAGE_UNITS = 0x8872;
		public const uint MAX_TEXTURE_LOD_BIAS = 0x84FD;
		public const uint MAX_TEXTURE_SIZE = 0x0D33;
		public const uint MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
		public const uint MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
		public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
		public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
		public const uint MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
		public const uint MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
		public const uint MAX_UNIFORM_LOCATIONS = 0x826E;
		public const uint MAX_VARYING_COMPONENTS = 0x8B4B;
		public const uint MAX_VARYING_FLOATS = 0x8B4B;
		public const uint MAX_VARYING_VECTORS = 0x8DFC;
		public const uint MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
		public const uint MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
		public const uint MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
		public const uint MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
		public const uint MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
		public const uint MAX_VERTEX_ATTRIBS = 0x8869;
		public const uint MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
		public const uint MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
		public const uint MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
		public const uint MAX_VERTEX_STREAMS = 0x8E71;
		public const uint MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
		public const uint MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
		public const uint MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
		public const uint MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		public const uint MAX_VIEWPORT_DIMS = 0x0D3A;
		public const uint MAX_VIEWPORTS = 0x825B;
		public const uint MAX_WIDTH = 0x827E;
		public const uint MEDIUM_FLOAT = 0x8DF1;
		public const uint MEDIUM_INT = 0x8DF4;
		public const uint MIN = 0x8007;
		public const uint MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
		public const uint MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
		public const uint MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
		public const uint MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
		public const uint MIN_SAMPLE_SHADING_VALUE = 0x8C37;
		public const uint MINOR_VERSION = 0x821C;
		public const uint MIPMAP = 0x8293;
		public const uint MIRROR_CLAMP_TO_EDGE = 0x8743;
		public const uint MIRRORED_REPEAT = 0x8370;
		public const uint MULTISAMPLE = 0x809D;
		public const uint NAME_LENGTH = 0x92F9;
		public const uint NAND = 0x150E;
		public const uint NEAREST = 0x2600;
		public const uint NEAREST_MIPMAP_LINEAR = 0x2702;
		public const uint NEAREST_MIPMAP_NEAREST = 0x2700;
		public const uint NEGATIVE_ONE_TO_ONE = 0x935E;
		public const uint NEVER = 0x0200;
		public const uint NICEST = 0x1102;
		public const uint NO_ERROR = 0;
		public const uint NO_RESET_NOTIFICATION = 0x8261;
		public const uint NONE = 0;
		public const uint NOOP = 0x1505;
		public const uint NOR = 0x1508;
		public const uint NOTEQUAL = 0x0205;
		public const uint NUM_ACTIVE_VARIABLES = 0x9304;
		public const uint NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
		public const uint NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
		public const uint NUM_EXTENSIONS = 0x821D;
		public const uint NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
		public const uint NUM_SAMPLE_COUNTS = 0x9380;
		public const uint NUM_SHADER_BINARY_FORMATS = 0x8DF9;
		public const uint NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
		public const uint OBJECT_TYPE = 0x9112;
		public const uint OFFSET = 0x92FC;
		public const uint ONE = 1;
		public const uint ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		public const uint ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const uint ONE_MINUS_DST_ALPHA = 0x0305;
		public const uint ONE_MINUS_DST_COLOR = 0x0307;
		public const uint ONE_MINUS_SRC_ALPHA = 0x0303;
		public const uint ONE_MINUS_SRC_COLOR = 0x0301;
		public const uint ONE_MINUS_SRC1_ALPHA = 0x88FB;
		public const uint ONE_MINUS_SRC1_COLOR = 0x88FA;
		public const uint OR = 0x1507;
		public const uint OR_INVERTED = 0x150D;
		public const uint OR_REVERSE = 0x150B;
		public const uint OUT_OF_MEMORY = 0x0505;
		public const uint PACK_ALIGNMENT = 0x0D05;
		public const uint PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
		public const uint PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
		public const uint PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
		public const uint PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
		public const uint PACK_IMAGE_HEIGHT = 0x806C;
		public const uint PACK_LSB_FIRST = 0x0D01;
		public const uint PACK_ROW_LENGTH = 0x0D02;
		public const uint PACK_SKIP_IMAGES = 0x806B;
		public const uint PACK_SKIP_PIXELS = 0x0D04;
		public const uint PACK_SKIP_ROWS = 0x0D03;
		public const uint PACK_SWAP_BYTES = 0x0D00;
		public const uint PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
		public const uint PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
		public const uint PATCH_VERTICES = 0x8E72;
		public const uint PATCHES = 0x000E;
		public const uint PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
		public const uint PIXEL_PACK_BUFFER = 0x88EB;
		public const uint PIXEL_PACK_BUFFER_BINDING = 0x88ED;
		public const uint PIXEL_UNPACK_BUFFER = 0x88EC;
		public const uint PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
		public const uint POINT = 0x1B00;
		public const uint POINT_FADE_THRESHOLD_SIZE = 0x8128;
		public const uint POINT_SIZE = 0x0B11;
		public const uint POINT_SIZE_GRANULARITY = 0x0B13;
		public const uint POINT_SIZE_RANGE = 0x0B12;
		public const uint POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
		public const uint POINTS = 0x0000;
		public const uint POLYGON_MODE = 0x0B40;
		public const uint POLYGON_OFFSET_FACTOR = 0x8038;
		public const uint POLYGON_OFFSET_FILL = 0x8037;
		public const uint POLYGON_OFFSET_LINE = 0x2A02;
		public const uint POLYGON_OFFSET_POINT = 0x2A01;
		public const uint POLYGON_OFFSET_UNITS = 0x2A00;
		public const uint POLYGON_SMOOTH = 0x0B41;
		public const uint POLYGON_SMOOTH_HINT = 0x0C53;
		public const uint PRIMITIVE_RESTART = 0x8F9D;
		public const uint PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
		public const uint PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
		public const uint PRIMITIVE_RESTART_INDEX = 0x8F9E;
		public const uint PRIMITIVES_GENERATED = 0x8C87;
		public const uint PROGRAM = 0x82E2;
		public const uint PROGRAM_BINARY_FORMATS = 0x87FF;
		public const uint PROGRAM_BINARY_LENGTH = 0x8741;
		public const uint PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
		public const uint PROGRAM_INPUT = 0x92E3;
		public const uint PROGRAM_OUTPUT = 0x92E4;
		public const uint PROGRAM_PIPELINE = 0x82E4;
		public const uint PROGRAM_PIPELINE_BINDING = 0x825A;
		public const uint PROGRAM_POINT_SIZE = 0x8642;
		public const uint PROGRAM_SEPARABLE = 0x8258;
		public const uint PROVOKING_VERTEX = 0x8E4F;
		public const uint PROXY_TEXTURE_1D = 0x8063;
		public const uint PROXY_TEXTURE_1D_ARRAY = 0x8C19;
		public const uint PROXY_TEXTURE_2D = 0x8064;
		public const uint PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
		public const uint PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
		public const uint PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
		public const uint PROXY_TEXTURE_3D = 0x8070;
		public const uint PROXY_TEXTURE_CUBE_MAP = 0x851B;
		public const uint PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
		public const uint PROXY_TEXTURE_RECTANGLE = 0x84F7;
		public const uint QUADS = 0x0007;
		public const uint QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
		public const uint QUERY = 0x82E3;
		public const uint QUERY_BUFFER = 0x9192;
		public const uint QUERY_BUFFER_BARRIER_BIT = 0x00008000;
		public const uint QUERY_BUFFER_BINDING = 0x9193;
		public const uint QUERY_BY_REGION_NO_WAIT = 0x8E16;
		public const uint QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
		public const uint QUERY_BY_REGION_WAIT = 0x8E15;
		public const uint QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
		public const uint QUERY_COUNTER_BITS = 0x8864;
		public const uint QUERY_NO_WAIT = 0x8E14;
		public const uint QUERY_NO_WAIT_INVERTED = 0x8E18;
		public const uint QUERY_RESULT = 0x8866;
		public const uint QUERY_RESULT_AVAILABLE = 0x8867;
		public const uint QUERY_RESULT_NO_WAIT = 0x9194;
		public const uint QUERY_TARGET = 0x82EA;
		public const uint QUERY_WAIT = 0x8E13;
		public const uint QUERY_WAIT_INVERTED = 0x8E17;
		public const uint R11F_G11F_B10F = 0x8C3A;
		public const uint R16 = 0x822A;
		public const uint R16_SNORM = 0x8F98;
		public const uint R16F = 0x822D;
		public const uint R16I = 0x8233;
		public const uint R16UI = 0x8234;
		public const uint R3_G3_B2 = 0x2A10;
		public const uint R32F = 0x822E;
		public const uint R32I = 0x8235;
		public const uint R32UI = 0x8236;
		public const uint R8 = 0x8229;
		public const uint R8_SNORM = 0x8F94;
		public const uint R8I = 0x8231;
		public const uint R8UI = 0x8232;
		public const uint RASTERIZER_DISCARD = 0x8C89;
		public const uint READ_BUFFER = 0x0C02;
		public const uint READ_FRAMEBUFFER = 0x8CA8;
		public const uint READ_FRAMEBUFFER_BINDING = 0x8CAA;
		public const uint READ_ONLY = 0x88B8;
		public const uint READ_PIXELS = 0x828C;
		public const uint READ_PIXELS_FORMAT = 0x828D;
		public const uint READ_PIXELS_TYPE = 0x828E;
		public const uint READ_WRITE = 0x88BA;
		public const uint RED = 0x1903;
		public const uint RED_INTEGER = 0x8D94;
		public const uint REFERENCED_BY_COMPUTE_SHADER = 0x930B;
		public const uint REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
		public const uint REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
		public const uint REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
		public const uint REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
		public const uint REFERENCED_BY_VERTEX_SHADER = 0x9306;
		public const uint RENDERBUFFER = 0x8D41;
		public const uint RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		public const uint RENDERBUFFER_BINDING = 0x8CA7;
		public const uint RENDERBUFFER_BLUE_SIZE = 0x8D52;
		public const uint RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		public const uint RENDERBUFFER_GREEN_SIZE = 0x8D51;
		public const uint RENDERBUFFER_HEIGHT = 0x8D43;
		public const uint RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		public const uint RENDERBUFFER_RED_SIZE = 0x8D50;
		public const uint RENDERBUFFER_SAMPLES = 0x8CAB;
		public const uint RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		public const uint RENDERBUFFER_WIDTH = 0x8D42;
		public const uint RENDERER = 0x1F01;
		public const uint REPEAT = 0x2901;
		public const uint REPLACE = 0x1E01;
		public const uint RESET_NOTIFICATION_STRATEGY = 0x8256;
		public const uint RG = 0x8227;
		public const uint RG_INTEGER = 0x8228;
		public const uint RG16 = 0x822C;
		public const uint RG16_SNORM = 0x8F99;
		public const uint RG16F = 0x822F;
		public const uint RG16I = 0x8239;
		public const uint RG16UI = 0x823A;
		public const uint RG32F = 0x8230;
		public const uint RG32I = 0x823B;
		public const uint RG32UI = 0x823C;
		public const uint RG8 = 0x822B;
		public const uint RG8_SNORM = 0x8F95;
		public const uint RG8I = 0x8237;
		public const uint RG8UI = 0x8238;
		public const uint RGB = 0x1907;
		public const uint RGB_INTEGER = 0x8D98;
		public const uint RGB10 = 0x8052;
		public const uint RGB10_A2 = 0x8059;
		public const uint RGB10_A2UI = 0x906F;
		public const uint RGB12 = 0x8053;
		public const uint RGB16 = 0x8054;
		public const uint RGB16_SNORM = 0x8F9A;
		public const uint RGB16F = 0x881B;
		public const uint RGB16I = 0x8D89;
		public const uint RGB16UI = 0x8D77;
		public const uint RGB32F = 0x8815;
		public const uint RGB32I = 0x8D83;
		public const uint RGB32UI = 0x8D71;
		public const uint RGB4 = 0x804F;
		public const uint RGB5 = 0x8050;
		public const uint RGB5_A1 = 0x8057;
		public const uint RGB565 = 0x8D62;
		public const uint RGB8 = 0x8051;
		public const uint RGB8_SNORM = 0x8F96;
		public const uint RGB8I = 0x8D8F;
		public const uint RGB8UI = 0x8D7D;
		public const uint RGB9_E5 = 0x8C3D;
		public const uint RGBA = 0x1908;
		public const uint RGBA_INTEGER = 0x8D99;
		public const uint RGBA12 = 0x805A;
		public const uint RGBA16 = 0x805B;
		public const uint RGBA16_SNORM = 0x8F9B;
		public const uint RGBA16F = 0x881A;
		public const uint RGBA16I = 0x8D88;
		public const uint RGBA16UI = 0x8D76;
		public const uint RGBA2 = 0x8055;
		public const uint RGBA32F = 0x8814;
		public const uint RGBA32I = 0x8D82;
		public const uint RGBA32UI = 0x8D70;
		public const uint RGBA4 = 0x8056;
		public const uint RGBA8 = 0x8058;
		public const uint RGBA8_SNORM = 0x8F97;
		public const uint RGBA8I = 0x8D8E;
		public const uint RGBA8UI = 0x8D7C;
		public const uint RIGHT = 0x0407;
		public const uint SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		public const uint SAMPLE_ALPHA_TO_ONE = 0x809F;
		public const uint SAMPLE_BUFFERS = 0x80A8;
		public const uint SAMPLE_COVERAGE = 0x80A0;
		public const uint SAMPLE_COVERAGE_INVERT = 0x80AB;
		public const uint SAMPLE_COVERAGE_VALUE = 0x80AA;
		public const uint SAMPLE_MASK = 0x8E51;
		public const uint SAMPLE_MASK_VALUE = 0x8E52;
		public const uint SAMPLE_POSITION = 0x8E50;
		public const uint SAMPLE_SHADING = 0x8C36;
		public const uint SAMPLER = 0x82E6;
		public const uint SAMPLER_1D = 0x8B5D;
		public const uint SAMPLER_1D_ARRAY = 0x8DC0;
		public const uint SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
		public const uint SAMPLER_1D_SHADOW = 0x8B61;
		public const uint SAMPLER_2D = 0x8B5E;
		public const uint SAMPLER_2D_ARRAY = 0x8DC1;
		public const uint SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
		public const uint SAMPLER_2D_MULTISAMPLE = 0x9108;
		public const uint SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
		public const uint SAMPLER_2D_RECT = 0x8B63;
		public const uint SAMPLER_2D_RECT_SHADOW = 0x8B64;
		public const uint SAMPLER_2D_SHADOW = 0x8B62;
		public const uint SAMPLER_3D = 0x8B5F;
		public const uint SAMPLER_BINDING = 0x8919;
		public const uint SAMPLER_BUFFER = 0x8DC2;
		public const uint SAMPLER_CUBE = 0x8B60;
		public const uint SAMPLER_CUBE_MAP_ARRAY = 0x900C;
		public const uint SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
		public const uint SAMPLER_CUBE_SHADOW = 0x8DC5;
		public const uint SAMPLES = 0x80A9;
		public const uint SAMPLES_PASSED = 0x8914;
		public const uint SCISSOR_BOX = 0x0C10;
		public const uint SCISSOR_TEST = 0x0C11;
		public const uint SEPARATE_ATTRIBS = 0x8C8D;
		public const uint SET = 0x150F;
		public const uint SHADER = 0x82E1;
		public const uint SHADER_BINARY_FORMATS = 0x8DF8;
		public const uint SHADER_COMPILER = 0x8DFA;
		public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
		public const uint SHADER_IMAGE_ATOMIC = 0x82A6;
		public const uint SHADER_IMAGE_LOAD = 0x82A4;
		public const uint SHADER_IMAGE_STORE = 0x82A5;
		public const uint SHADER_SOURCE_LENGTH = 0x8B88;
		public const uint SHADER_STORAGE_BARRIER_BIT = 0x00002000;
		public const uint SHADER_STORAGE_BLOCK = 0x92E6;
		public const uint SHADER_STORAGE_BUFFER = 0x90D2;
		public const uint SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
		public const uint SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
		public const uint SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
		public const uint SHADER_STORAGE_BUFFER_START = 0x90D4;
		public const uint SHADER_TYPE = 0x8B4F;
		public const uint SHADING_LANGUAGE_VERSION = 0x8B8C;
		public const uint SHORT = 0x1402;
		public const uint SIGNALED = 0x9119;
		public const uint SIGNED_NORMALIZED = 0x8F9C;
		public const uint SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
		public const uint SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
		public const uint SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
		public const uint SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
		public const uint SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const uint SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
		public const uint SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
		public const uint SMOOTH_POINT_SIZE_RANGE = 0x0B12;
		public const uint SRC_ALPHA = 0x0302;
		public const uint SRC_ALPHA_SATURATE = 0x0308;
		public const uint SRC_COLOR = 0x0300;
		public const uint SRC1_ALPHA = 0x8589;
		public const uint SRC1_COLOR = 0x88F9;
		public const uint SRGB = 0x8C40;
		public const uint SRGB_ALPHA = 0x8C42;
		public const uint SRGB_READ = 0x8297;
		public const uint SRGB_WRITE = 0x8298;
		public const uint SRGB8 = 0x8C41;
		public const uint SRGB8_ALPHA8 = 0x8C43;
		public const uint STACK_OVERFLOW = 0x0503;
		public const uint STACK_UNDERFLOW = 0x0504;
		public const uint STATIC_COPY = 0x88E6;
		public const uint STATIC_DRAW = 0x88E4;
		public const uint STATIC_READ = 0x88E5;
		public const uint STENCIL = 0x1802;
		public const uint STENCIL_ATTACHMENT = 0x8D20;
		public const uint STENCIL_BACK_FAIL = 0x8801;
		public const uint STENCIL_BACK_FUNC = 0x8800;
		public const uint STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
		public const uint STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
		public const uint STENCIL_BACK_REF = 0x8CA3;
		public const uint STENCIL_BACK_VALUE_MASK = 0x8CA4;
		public const uint STENCIL_BACK_WRITEMASK = 0x8CA5;
		public const uint STENCIL_BUFFER_BIT = 0x00000400;
		public const uint STENCIL_CLEAR_VALUE = 0x0B91;
		public const uint STENCIL_COMPONENTS = 0x8285;
		public const uint STENCIL_FAIL = 0x0B94;
		public const uint STENCIL_FUNC = 0x0B92;
		public const uint STENCIL_INDEX = 0x1901;
		public const uint STENCIL_INDEX1 = 0x8D46;
		public const uint STENCIL_INDEX16 = 0x8D49;
		public const uint STENCIL_INDEX4 = 0x8D47;
		public const uint STENCIL_INDEX8 = 0x8D48;
		public const uint STENCIL_PASS_DEPTH_FAIL = 0x0B95;
		public const uint STENCIL_PASS_DEPTH_PASS = 0x0B96;
		public const uint STENCIL_REF = 0x0B97;
		public const uint STENCIL_RENDERABLE = 0x8288;
		public const uint STENCIL_TEST = 0x0B90;
		public const uint STENCIL_VALUE_MASK = 0x0B93;
		public const uint STENCIL_WRITEMASK = 0x0B98;
		public const uint STEREO = 0x0C33;
		public const uint STREAM_COPY = 0x88E2;
		public const uint STREAM_DRAW = 0x88E0;
		public const uint STREAM_READ = 0x88E1;
		public const uint SUBPIXEL_BITS = 0x0D50;
		public const uint SYNC_CONDITION = 0x9113;
		public const uint SYNC_FENCE = 0x9116;
		public const uint SYNC_FLAGS = 0x9115;
		public const uint SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
		public const uint SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
		public const uint SYNC_STATUS = 0x9114;
		public const uint TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
		public const uint TESS_CONTROL_SHADER = 0x8E88;
		public const uint TESS_CONTROL_SHADER_BIT = 0x00000008;
		public const uint TESS_CONTROL_SUBROUTINE = 0x92E9;
		public const uint TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
		public const uint TESS_CONTROL_TEXTURE = 0x829C;
		public const uint TESS_EVALUATION_SHADER = 0x8E87;
		public const uint TESS_EVALUATION_SHADER_BIT = 0x00000010;
		public const uint TESS_EVALUATION_SUBROUTINE = 0x92EA;
		public const uint TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
		public const uint TESS_EVALUATION_TEXTURE = 0x829D;
		public const uint TESS_GEN_MODE = 0x8E76;
		public const uint TESS_GEN_POINT_MODE = 0x8E79;
		public const uint TESS_GEN_SPACING = 0x8E77;
		public const uint TESS_GEN_VERTEX_ORDER = 0x8E78;
		public const uint TEXTURE = 0x1702;
		public const uint TEXTURE_1D = 0x0DE0;
		public const uint TEXTURE_1D_ARRAY = 0x8C18;
		public const uint TEXTURE_2D = 0x0DE1;
		public const uint TEXTURE_2D_ARRAY = 0x8C1A;
		public const uint TEXTURE_2D_MULTISAMPLE = 0x9100;
		public const uint TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
		public const uint TEXTURE_3D = 0x806F;
		public const uint TEXTURE_ALPHA_SIZE = 0x805F;
		public const uint TEXTURE_ALPHA_TYPE = 0x8C13;
		public const uint TEXTURE_BASE_LEVEL = 0x813C;
		public const uint TEXTURE_BINDING_1D = 0x8068;
		public const uint TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
		public const uint TEXTURE_BINDING_2D = 0x8069;
		public const uint TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
		public const uint TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
		public const uint TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
		public const uint TEXTURE_BINDING_3D = 0x806A;
		public const uint TEXTURE_BINDING_BUFFER = 0x8C2C;
		public const uint TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const uint TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
		public const uint TEXTURE_BINDING_RECTANGLE = 0x84F6;
		public const uint TEXTURE_BLUE_SIZE = 0x805E;
		public const uint TEXTURE_BLUE_TYPE = 0x8C12;
		public const uint TEXTURE_BORDER_COLOR = 0x1004;
		public const uint TEXTURE_BUFFER = 0x8C2A;
		public const uint TEXTURE_BUFFER_BINDING = 0x8C2A;
		public const uint TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
		public const uint TEXTURE_BUFFER_OFFSET = 0x919D;
		public const uint TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
		public const uint TEXTURE_BUFFER_SIZE = 0x919E;
		public const uint TEXTURE_COMPARE_FUNC = 0x884D;
		public const uint TEXTURE_COMPARE_MODE = 0x884C;
		public const uint TEXTURE_COMPRESSED = 0x86A1;
		public const uint TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
		public const uint TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
		public const uint TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
		public const uint TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
		public const uint TEXTURE_COMPRESSION_HINT = 0x84EF;
		public const uint TEXTURE_CUBE_MAP = 0x8513;
		public const uint TEXTURE_CUBE_MAP_ARRAY = 0x9009;
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		public const uint TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		public const uint TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		public const uint TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		public const uint TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
		public const uint TEXTURE_DEPTH = 0x8071;
		public const uint TEXTURE_DEPTH_SIZE = 0x884A;
		public const uint TEXTURE_DEPTH_TYPE = 0x8C16;
		public const uint TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
		public const uint TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
		public const uint TEXTURE_GATHER = 0x82A2;
		public const uint TEXTURE_GATHER_SHADOW = 0x82A3;
		public const uint TEXTURE_GREEN_SIZE = 0x805D;
		public const uint TEXTURE_GREEN_TYPE = 0x8C11;
		public const uint TEXTURE_HEIGHT = 0x1001;
		public const uint TEXTURE_IMAGE_FORMAT = 0x828F;
		public const uint TEXTURE_IMAGE_TYPE = 0x8290;
		public const uint TEXTURE_IMMUTABLE_FORMAT = 0x912F;
		public const uint TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
		public const uint TEXTURE_INTERNAL_FORMAT = 0x1003;
		public const uint TEXTURE_LOD_BIAS = 0x8501;
		public const uint TEXTURE_MAG_FILTER = 0x2800;
		public const uint TEXTURE_MAX_LEVEL = 0x813D;
		public const uint TEXTURE_MAX_LOD = 0x813B;
		public const uint TEXTURE_MIN_FILTER = 0x2801;
		public const uint TEXTURE_MIN_LOD = 0x813A;
		public const uint TEXTURE_RECTANGLE = 0x84F5;
		public const uint TEXTURE_RED_SIZE = 0x805C;
		public const uint TEXTURE_RED_TYPE = 0x8C10;
		public const uint TEXTURE_SAMPLES = 0x9106;
		public const uint TEXTURE_SHADOW = 0x82A1;
		public const uint TEXTURE_SHARED_SIZE = 0x8C3F;
		public const uint TEXTURE_STENCIL_SIZE = 0x88F1;
		public const uint TEXTURE_SWIZZLE_A = 0x8E45;
		public const uint TEXTURE_SWIZZLE_B = 0x8E44;
		public const uint TEXTURE_SWIZZLE_G = 0x8E43;
		public const uint TEXTURE_SWIZZLE_R = 0x8E42;
		public const uint TEXTURE_SWIZZLE_RGBA = 0x8E46;
		public const uint TEXTURE_TARGET = 0x1006;
		public const uint TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
		public const uint TEXTURE_VIEW = 0x82B5;
		public const uint TEXTURE_VIEW_MIN_LAYER = 0x82DD;
		public const uint TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
		public const uint TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
		public const uint TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
		public const uint TEXTURE_WIDTH = 0x1000;
		public const uint TEXTURE_WRAP_R = 0x8072;
		public const uint TEXTURE_WRAP_S = 0x2802;
		public const uint TEXTURE_WRAP_T = 0x2803;
		public const uint TEXTURE0 = 0x84C0;
		public const uint TEXTURE1 = 0x84C1;
		public const uint TEXTURE10 = 0x84CA;
		public const uint TEXTURE11 = 0x84CB;
		public const uint TEXTURE12 = 0x84CC;
		public const uint TEXTURE13 = 0x84CD;
		public const uint TEXTURE14 = 0x84CE;
		public const uint TEXTURE15 = 0x84CF;
		public const uint TEXTURE16 = 0x84D0;
		public const uint TEXTURE17 = 0x84D1;
		public const uint TEXTURE18 = 0x84D2;
		public const uint TEXTURE19 = 0x84D3;
		public const uint TEXTURE2 = 0x84C2;
		public const uint TEXTURE20 = 0x84D4;
		public const uint TEXTURE21 = 0x84D5;
		public const uint TEXTURE22 = 0x84D6;
		public const uint TEXTURE23 = 0x84D7;
		public const uint TEXTURE24 = 0x84D8;
		public const uint TEXTURE25 = 0x84D9;
		public const uint TEXTURE26 = 0x84DA;
		public const uint TEXTURE27 = 0x84DB;
		public const uint TEXTURE28 = 0x84DC;
		public const uint TEXTURE29 = 0x84DD;
		public const uint TEXTURE3 = 0x84C3;
		public const uint TEXTURE30 = 0x84DE;
		public const uint TEXTURE31 = 0x84DF;
		public const uint TEXTURE4 = 0x84C4;
		public const uint TEXTURE5 = 0x84C5;
		public const uint TEXTURE6 = 0x84C6;
		public const uint TEXTURE7 = 0x84C7;
		public const uint TEXTURE8 = 0x84C8;
		public const uint TEXTURE9 = 0x84C9;
		public const uint TIME_ELAPSED = 0x88BF;
		public const uint TIMEOUT_EXPIRED = 0x911B;
		public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
		public const uint TIMESTAMP = 0x8E28;
		public const uint TOP_LEVEL_ARRAY_SIZE = 0x930C;
		public const uint TOP_LEVEL_ARRAY_STRIDE = 0x930D;
		public const uint TRANSFORM_FEEDBACK = 0x8E22;
		public const uint TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
		public const uint TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
		public const uint TRANSFORM_FEEDBACK_BINDING = 0x8E25;
		public const uint TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
		public const uint TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
		public const uint TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
		public const uint TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
		public const uint TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
		public const uint TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
		public const uint TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
		public const uint TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
		public const uint TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
		public const uint TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
		public const uint TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
		public const uint TRANSFORM_FEEDBACK_VARYING = 0x92F4;
		public const uint TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
		public const uint TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
		public const uint TRIANGLE_FAN = 0x0006;
		public const uint TRIANGLE_STRIP = 0x0005;
		public const uint TRIANGLE_STRIP_ADJACENCY = 0x000D;
		public const uint TRIANGLES = 0x0004;
		public const uint TRIANGLES_ADJACENCY = 0x000C;
		public const uint TRUE = 1;
		public const uint TYPE = 0x92FA;
		public const uint UNDEFINED_VERTEX = 0x8260;
		public const uint UNIFORM = 0x92E1;
		public const uint UNIFORM_ARRAY_STRIDE = 0x8A3C;
		public const uint UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
		public const uint UNIFORM_BARRIER_BIT = 0x00000004;
		public const uint UNIFORM_BLOCK = 0x92E2;
		public const uint UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
		public const uint UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
		public const uint UNIFORM_BLOCK_BINDING = 0x8A3F;
		public const uint UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
		public const uint UNIFORM_BLOCK_INDEX = 0x8A3A;
		public const uint UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
		public const uint UNIFORM_BUFFER = 0x8A11;
		public const uint UNIFORM_BUFFER_BINDING = 0x8A28;
		public const uint UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
		public const uint UNIFORM_BUFFER_SIZE = 0x8A2A;
		public const uint UNIFORM_BUFFER_START = 0x8A29;
		public const uint UNIFORM_IS_ROW_MAJOR = 0x8A3E;
		public const uint UNIFORM_MATRIX_STRIDE = 0x8A3D;
		public const uint UNIFORM_NAME_LENGTH = 0x8A39;
		public const uint UNIFORM_OFFSET = 0x8A3B;
		public const uint UNIFORM_SIZE = 0x8A38;
		public const uint UNIFORM_TYPE = 0x8A37;
		public const uint UNKNOWN_CONTEXT_RESET = 0x8255;
		public const uint UNPACK_ALIGNMENT = 0x0CF5;
		public const uint UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
		public const uint UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
		public const uint UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
		public const uint UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
		public const uint UNPACK_IMAGE_HEIGHT = 0x806E;
		public const uint UNPACK_LSB_FIRST = 0x0CF1;
		public const uint UNPACK_ROW_LENGTH = 0x0CF2;
		public const uint UNPACK_SKIP_IMAGES = 0x806D;
		public const uint UNPACK_SKIP_PIXELS = 0x0CF4;
		public const uint UNPACK_SKIP_ROWS = 0x0CF3;
		public const uint UNPACK_SWAP_BYTES = 0x0CF0;
		public const uint UNSIGNALED = 0x9118;
		public const uint UNSIGNED_BYTE = 0x1401;
		public const uint UNSIGNED_BYTE_2_3_3_REV = 0x8362;
		public const uint UNSIGNED_BYTE_3_3_2 = 0x8032;
		public const uint UNSIGNED_INT = 0x1405;
		public const uint UNSIGNED_INT_10_10_10_2 = 0x8036;
		public const uint UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
		public const uint UNSIGNED_INT_2_10_10_10_REV = 0x8368;
		public const uint UNSIGNED_INT_24_8 = 0x84FA;
		public const uint UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
		public const uint UNSIGNED_INT_8_8_8_8 = 0x8035;
		public const uint UNSIGNED_INT_8_8_8_8_REV = 0x8367;
		public const uint UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
		public const uint UNSIGNED_INT_IMAGE_1D = 0x9062;
		public const uint UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
		public const uint UNSIGNED_INT_IMAGE_2D = 0x9063;
		public const uint UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
		public const uint UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
		public const uint UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
		public const uint UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
		public const uint UNSIGNED_INT_IMAGE_3D = 0x9064;
		public const uint UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
		public const uint UNSIGNED_INT_IMAGE_CUBE = 0x9066;
		public const uint UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
		public const uint UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
		public const uint UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
		public const uint UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
		public const uint UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
		public const uint UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
		public const uint UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
		public const uint UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
		public const uint UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
		public const uint UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
		public const uint UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
		public const uint UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
		public const uint UNSIGNED_INT_VEC2 = 0x8DC6;
		public const uint UNSIGNED_INT_VEC3 = 0x8DC7;
		public const uint UNSIGNED_INT_VEC4 = 0x8DC8;
		public const uint UNSIGNED_NORMALIZED = 0x8C17;
		public const uint UNSIGNED_SHORT = 0x1403;
		public const uint UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
		public const uint UNSIGNED_SHORT_4_4_4_4 = 0x8033;
		public const uint UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
		public const uint UNSIGNED_SHORT_5_5_5_1 = 0x8034;
		public const uint UNSIGNED_SHORT_5_6_5 = 0x8363;
		public const uint UNSIGNED_SHORT_5_6_5_REV = 0x8364;
		public const uint UPPER_LEFT = 0x8CA2;
		public const uint VALIDATE_STATUS = 0x8B83;
		public const uint VENDOR = 0x1F00;
		public const uint VERSION = 0x1F02;
		public const uint VERTEX_ARRAY = 0x8074;
		public const uint VERTEX_ARRAY_BINDING = 0x85B5;
		public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
		public const uint VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
		public const uint VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
		public const uint VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
		public const uint VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
		public const uint VERTEX_ATTRIB_ARRAY_LONG = 0x874E;
		public const uint VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
		public const uint VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
		public const uint VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
		public const uint VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
		public const uint VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
		public const uint VERTEX_ATTRIB_BINDING = 0x82D4;
		public const uint VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
		public const uint VERTEX_BINDING_BUFFER = 0x8F4F;
		public const uint VERTEX_BINDING_DIVISOR = 0x82D6;
		public const uint VERTEX_BINDING_OFFSET = 0x82D7;
		public const uint VERTEX_BINDING_STRIDE = 0x82D8;
		public const uint VERTEX_PROGRAM_POINT_SIZE = 0x8642;
		public const uint VERTEX_SHADER = 0x8B31;
		public const uint VERTEX_SHADER_BIT = 0x00000001;
		public const uint VERTEX_SUBROUTINE = 0x92E8;
		public const uint VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
		public const uint VERTEX_TEXTURE = 0x829B;
		public const uint VIEW_CLASS_128_BITS = 0x82C4;
		public const uint VIEW_CLASS_16_BITS = 0x82CA;
		public const uint VIEW_CLASS_24_BITS = 0x82C9;
		public const uint VIEW_CLASS_32_BITS = 0x82C8;
		public const uint VIEW_CLASS_48_BITS = 0x82C7;
		public const uint VIEW_CLASS_64_BITS = 0x82C6;
		public const uint VIEW_CLASS_8_BITS = 0x82CB;
		public const uint VIEW_CLASS_96_BITS = 0x82C5;
		public const uint VIEW_CLASS_BPTC_FLOAT = 0x82D3;
		public const uint VIEW_CLASS_BPTC_UNORM = 0x82D2;
		public const uint VIEW_CLASS_RGTC1_RED = 0x82D0;
		public const uint VIEW_CLASS_RGTC2_RG = 0x82D1;
		public const uint VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
		public const uint VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
		public const uint VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
		public const uint VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
		public const uint VIEW_COMPATIBILITY_CLASS = 0x82B6;
		public const uint VIEWPORT = 0x0BA2;
		public const uint VIEWPORT_BOUNDS_RANGE = 0x825D;
		public const uint VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
		public const uint VIEWPORT_SUBPIXEL_BITS = 0x825C;
		public const uint WAIT_FAILED = 0x911D;
		public const uint WRITE_ONLY = 0x88B9;
		public const uint XOR = 0x1506;
		public const uint ZERO = 0;
		public const uint ZERO_TO_ONE = 0x935F;

		public static class Delegates
		{
			public delegate void ActiveShaderProgram(uint pipeline, uint program);

			public delegate void ActiveTexture(uint texture);

			public delegate void AttachShader(uint program, uint shader);

			public delegate void BeginConditionalRender(uint id, uint mode);

			public delegate void BeginQuery(uint target, uint id);

			public delegate void BeginQueryIndexed(uint target, uint index, uint id);

			public delegate void BeginTransformFeedback(uint primitiveMode);

			public delegate void BindAttribLocation(uint program, uint index, string name);

			public delegate void BindBuffer(uint target, uint buffer);

			public delegate void BindBufferBase(uint target, uint index, uint buffer);

			public delegate void BindBufferRange(uint target, uint index, uint buffer, int offset, int size);

			public delegate void BindBuffersBase(uint target, uint first, int count, uint[] buffers);

			public delegate void BindBuffersRange(uint target, uint first, int count, uint[] buffers, int[] offsets, int[] sizes);

			public delegate void BindFragDataLocation(uint program, uint color, string name);

			public delegate void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name);

			public delegate void BindFramebuffer(uint target, uint framebuffer);

			public delegate void BindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);

			public delegate void BindImageTextures(uint first, int count, uint[] textures);

			public delegate void BindProgramPipeline(uint pipeline);

			public delegate void BindRenderbuffer(uint target, uint renderbuffer);

			public delegate void BindSampler(uint unit, uint sampler);

			public delegate void BindSamplers(uint first, int count, uint[] samplers);

			public delegate void BindTexture(uint target, uint texture);

			public delegate void BindTextures(uint first, int count, uint[] textures);

			public delegate void BindTextureUnit(uint unit, uint texture);

			public delegate void BindTransformFeedback(uint target, uint id);

			public delegate void BindVertexArray(uint array);

			public delegate void BindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride);

			public delegate void BindVertexBuffers(uint first, int count, uint[] buffers, int[] offsets, int[] strides);

			public delegate void BlendColor(float red, float green, float blue, float alpha);

			public delegate void BlendEquation(uint mode);

			public delegate void BlendEquationi(uint buf, uint mode);

			public delegate void BlendEquationSeparate(uint modeRGB, uint modeAlpha);

			public delegate void BlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);

			public delegate void BlendFunc(uint sfactor, uint dfactor);

			public delegate void BlendFunci(uint buf, uint src, uint dst);

			public delegate void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

			public delegate void BlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);

			public delegate void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

			public delegate void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

			public delegate void BufferData(uint target, int size, IntPtr data, uint usage);

			public delegate void BufferStorage(uint target, int size, IntPtr data, uint flags);

			public delegate void BufferSubData(uint target, int offset, int size, IntPtr data);

			public delegate uint CheckFramebufferStatus(uint target);

			public delegate uint CheckNamedFramebufferStatus(uint framebuffer, uint target);

			public delegate void ClampColor(uint target, uint clamp);

			public delegate void Clear(uint mask);

			public delegate void ClearBufferData(uint target, uint internalformat, uint format, uint type, IntPtr data);

			public delegate void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil);

			public delegate void ClearBufferfv(uint buffer, int drawbuffer, float[] value);

			public delegate void ClearBufferiv(uint buffer, int drawbuffer, int[] value);

			public delegate void ClearBufferSubData(uint target, uint internalformat, int offset, int size, uint format, uint type, IntPtr data);

			public delegate void ClearBufferuiv(uint buffer, int drawbuffer, uint[] value);

			public delegate void ClearColor(float red, float green, float blue, float alpha);

			public delegate void ClearDepth(double depth);

			public delegate void ClearDepthf(float d);

			public delegate void ClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, IntPtr data);

			public delegate void ClearNamedBufferSubData(uint buffer, uint internalformat, int offset, int size, uint format, uint type, IntPtr data);

			public delegate void ClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);

			public delegate void ClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float[] value);

			public delegate void ClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int[] value);

			public delegate void ClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint[] value);

			public delegate void ClearStencil(int s);

			public delegate void ClearTexImage(uint texture, int level, uint format, uint type, IntPtr data);

			public delegate void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data);

			public delegate uint ClientWaitSync(IntPtr sync, uint flags, ulong timeout);

			public delegate void ClipControl(uint origin, uint depth);

			public delegate void ColorMask(bool red, bool green, bool blue, bool alpha);

			public delegate void ColorMaski(uint index, bool r, bool g, bool b, bool a);

			public delegate void CompileShader(uint shader);

			public delegate void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);

			public delegate void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);

			public delegate void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);

			public delegate void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);

			public delegate void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);

			public delegate void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

			public delegate void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);

			public delegate void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);

			public delegate void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

			public delegate void CopyBufferSubData(uint readTarget, uint writeTarget, int readOffset, int writeOffset, int size);

			public delegate void CopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);

			public delegate void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size);

			public delegate void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border);

			public delegate void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

			public delegate void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);

			public delegate void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

			public delegate void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

			public delegate void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width);

			public delegate void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);

			public delegate void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

			public delegate void CreateBuffers(int n, uint[] buffers);

			public delegate void CreateFramebuffers(int n, uint[] framebuffers);

			public delegate uint CreateProgram();

			public delegate void CreateProgramPipelines(int n, uint[] pipelines);

			public delegate void CreateQueries(uint target, int n, uint[] ids);

			public delegate void CreateRenderbuffers(int n, uint[] renderbuffers);

			public delegate void CreateSamplers(int n, uint[] samplers);

			public delegate uint CreateShader(uint type);

			public delegate uint CreateShaderProgramv(uint type, int count, string[] strings);

			public delegate void CreateTextures(uint target, int n, uint[] textures);

			public delegate void CreateTransformFeedbacks(int n, uint[] ids);

			public delegate void CreateVertexArrays(int n, uint[] arrays);

			public delegate void CullFace(uint mode);

			public delegate void DebugMessageCallback(DebugProc callback, IntPtr userParam);

			public delegate void DebugMessageControl(uint source, uint type, uint severity, int count, uint[] ids, bool enabled);

			public delegate void DebugMessageInsert(uint source, uint type, uint id, uint severity, int length, string buf);

			public delegate void DeleteBuffers(int n, uint[] buffers);

			public delegate void DeleteFramebuffers(int n, uint[] framebuffers);

			public delegate void DeleteProgram(uint program);

			public delegate void DeleteProgramPipelines(int n, uint[] pipelines);

			public delegate void DeleteQueries(int n, uint[] ids);

			public delegate void DeleteRenderbuffers(int n, uint[] renderbuffers);

			public delegate void DeleteSamplers(int count, uint[] samplers);

			public delegate void DeleteShader(uint shader);

			public delegate void DeleteSync(IntPtr sync);

			public delegate void DeleteTextures(int n, uint[] textures);

			public delegate void DeleteTransformFeedbacks(int n, uint[] ids);

			public delegate void DeleteVertexArrays(int n, uint[] arrays);

			public delegate void DepthFunc(uint func);

			public delegate void DepthMask(bool flag);

			public delegate void DepthRange(double near, double far);

			public delegate void DepthRangeArrayv(uint first, int count, double[] v);

			public delegate void DepthRangef(float n, float f);

			public delegate void DepthRangeIndexed(uint index, double n, double f);

			public delegate void DetachShader(uint program, uint shader);

			public delegate void Disable(uint cap);

			public delegate void Disablei(uint target, uint index);

			public delegate void DisableVertexArrayAttrib(uint vaobj, uint index);

			public delegate void DisableVertexAttribArray(uint index);

			public delegate void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);

			public delegate void DispatchComputeIndirect(int indirect);

			public delegate void DrawArrays(uint mode, int first, int count);

			public delegate void DrawArraysIndirect(uint mode, IntPtr indirect);

			public delegate void DrawArraysInstanced(uint mode, int first, int count, int instancecount);

			public delegate void DrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance);

			public delegate void DrawBuffer(uint buf);

			public delegate void DrawBuffers(int n, uint[] bufs);

			public delegate void DrawElements(uint mode, int count, uint type, IntPtr indices);

			public delegate void DrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int basevertex);

			public delegate void DrawElementsIndirect(uint mode, uint type, IntPtr indirect);

			public delegate void DrawElementsInstanced(uint mode, int count, uint type, IntPtr indices, int instancecount);

			public delegate void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance);

			public delegate void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex);

			public delegate void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance);

			public delegate void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices);

			public delegate void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex);

			public delegate void DrawTransformFeedback(uint mode, uint id);

			public delegate void DrawTransformFeedbackInstanced(uint mode, uint id, int instancecount);

			public delegate void DrawTransformFeedbackStream(uint mode, uint id, uint stream);

			public delegate void DrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount);

			public delegate void Enable(uint cap);

			public delegate void Enablei(uint target, uint index);

			public delegate void EnableVertexArrayAttrib(uint vaobj, uint index);

			public delegate void EnableVertexAttribArray(uint index);

			public delegate void EndConditionalRender();

			public delegate void EndQuery(uint target);

			public delegate void EndQueryIndexed(uint target, uint index);

			public delegate void EndTransformFeedback();

			public delegate IntPtr FenceSync(uint condition, uint flags);

			public delegate void Finish();

			public delegate void Flush();

			public delegate void FlushMappedBufferRange(uint target, int offset, int length);

			public delegate void FlushMappedNamedBufferRange(uint buffer, int offset, int length);

			public delegate void FramebufferParameteri(uint target, uint pname, int param);

			public delegate void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

			public delegate void FramebufferTexture(uint target, uint attachment, uint texture, int level);

			public delegate void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level);

			public delegate void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);

			public delegate void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);

			public delegate void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);

			public delegate void FrontFace(uint mode);

			public delegate void GenBuffers(int n, uint[] buffers);

			public delegate void GenerateMipmap(uint target);

			public delegate void GenerateTextureMipmap(uint texture);

			public delegate void GenFramebuffers(int n, uint[] framebuffers);

			public delegate void GenProgramPipelines(int n, uint[] pipelines);

			public delegate void GenQueries(int n, uint[] ids);

			public delegate void GenRenderbuffers(int n, uint[] renderbuffers);

			public delegate void GenSamplers(int count, uint[] samplers);

			public delegate void GenTextures(int n, uint[] textures);

			public delegate void GenTransformFeedbacks(int n, uint[] ids);

			public delegate void GenVertexArrays(int n, uint[] arrays);

			public delegate void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int[] @params);

			public delegate void GetActiveAttrib(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name);

			public delegate void GetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int[] length, StringBuilder name);

			public delegate void GetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int[] values);

			public delegate void GetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int[] length, StringBuilder name);

			public delegate void GetActiveUniform(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name);

			public delegate void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int[] @params);

			public delegate void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int[] length, StringBuilder uniformBlockName);

			public delegate void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int[] length, StringBuilder uniformName);

			public delegate void GetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] @params);

			public delegate void GetAttachedShaders(uint program, int maxCount, int[] count, uint[] shaders);

			public delegate int GetAttribLocation(uint program, string name);

			public delegate void GetBooleani_v(uint target, uint index, bool[] data);

			public delegate void GetBooleanv(uint pname, bool[] data);

			public delegate void GetBufferParameteri64v(uint target, uint pname, long[] @params);

			public delegate void GetBufferParameteriv(uint target, uint pname, int[] @params);

			public delegate void GetBufferPointerv(uint target, uint pname, IntPtr[] @params);

			public delegate void GetBufferSubData(uint target, int offset, int size, IntPtr data);

			public delegate void GetCompressedTexImage(uint target, int level, IntPtr img);

			public delegate void GetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels);

			public delegate void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels);

			public delegate uint GetDebugMessageLog(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, StringBuilder messageLog);

			public delegate void GetDoublei_v(uint target, uint index, double[] data);

			public delegate void GetDoublev(uint pname, double[] data);

			public delegate uint GetError();

			public delegate void GetFloati_v(uint target, uint index, float[] data);

			public delegate void GetFloatv(uint pname, float[] data);

			public delegate int GetFragDataIndex(uint program, string name);

			public delegate int GetFragDataLocation(uint program, string name);

			public delegate void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int[] @params);

			public delegate void GetFramebufferParameteriv(uint target, uint pname, int[] @params);

			public delegate uint GetGraphicsResetStatus();

			public delegate void GetInteger64i_v(uint target, uint index, long[] data);

			public delegate void GetInteger64v(uint pname, long[] data);

			public delegate void GetIntegeri_v(uint target, uint index, int[] data);

			public delegate void GetIntegerv(uint pname, int[] data);

			public delegate void GetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, long[] @params);

			public delegate void GetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int[] @params);

			public delegate void GetMultisamplefv(uint pname, uint index, float[] val);

			public delegate void GetNamedBufferParameteri64v(uint buffer, uint pname, long[] @params);

			public delegate void GetNamedBufferParameteriv(uint buffer, uint pname, int[] @params);

			public delegate void GetNamedBufferPointerv(uint buffer, uint pname, IntPtr[] @params);

			public delegate void GetNamedBufferSubData(uint buffer, int offset, int size, IntPtr data);

			public delegate void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int[] @params);

			public delegate void GetNamedFramebufferParameteriv(uint framebuffer, uint pname, int[] param);

			public delegate void GetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int[] @params);

			public delegate void GetnCompressedTexImage(uint target, int lod, int bufSize, IntPtr pixels);

			public delegate void GetnTexImage(uint target, int level, uint format, uint type, int bufSize, IntPtr pixels);

			public delegate void GetnUniformdv(uint program, int location, int bufSize, double[] @params);

			public delegate void GetnUniformfv(uint program, int location, int bufSize, float[] @params);

			public delegate void GetnUniformiv(uint program, int location, int bufSize, int[] @params);

			public delegate void GetnUniformuiv(uint program, int location, int bufSize, uint[] @params);

			public delegate void GetObjectLabel(uint identifier, uint name, int bufSize, int[] length, StringBuilder label);

			public delegate void GetObjectPtrLabel(IntPtr ptr, int bufSize, int[] length, StringBuilder label);

			public delegate void GetPointerv(uint pname, IntPtr[] @params);

			public delegate void GetProgramBinary(uint program, int bufSize, int[] length, uint[] binaryFormat, IntPtr binary);

			public delegate void GetProgramInfoLog(uint program, int bufSize, out int length, StringBuilder infoLog);

			public delegate void GetProgramInterfaceiv(uint program, uint programInterface, uint pname, int[] @params);

			public delegate void GetProgramiv(uint program, uint pname, out int @params);

			public delegate void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int[] length, StringBuilder infoLog);

			public delegate void GetProgramPipelineiv(uint pipeline, uint pname, int[] @params);

			public delegate uint GetProgramResourceIndex(uint program, uint programInterface, string name);

			public delegate void GetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, int[] @params);

			public delegate int GetProgramResourceLocation(uint program, uint programInterface, string name);

			public delegate int GetProgramResourceLocationIndex(uint program, uint programInterface, string name);

			public delegate void GetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int[] length, StringBuilder name);

			public delegate void GetProgramStageiv(uint program, uint shadertype, uint pname, int[] values);

			public delegate void GetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int offset);

			public delegate void GetQueryBufferObjectiv(uint id, uint buffer, uint pname, int offset);

			public delegate void GetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int offset);

			public delegate void GetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int offset);

			public delegate void GetQueryIndexediv(uint target, uint index, uint pname, int[] @params);

			public delegate void GetQueryiv(uint target, uint pname, int[] @params);

			public delegate void GetQueryObjecti64v(uint id, uint pname, long[] @params);

			public delegate void GetQueryObjectiv(uint id, uint pname, int[] @params);

			public delegate void GetQueryObjectui64v(uint id, uint pname, ulong[] @params);

			public delegate void GetQueryObjectuiv(uint id, uint pname, uint[] @params);

			public delegate void GetRenderbufferParameteriv(uint target, uint pname, int[] @params);

			public delegate void GetSamplerParameterfv(uint sampler, uint pname, float[] @params);

			public delegate void GetSamplerParameterIiv(uint sampler, uint pname, int[] @params);

			public delegate void GetSamplerParameterIuiv(uint sampler, uint pname, uint[] @params);

			public delegate void GetSamplerParameteriv(uint sampler, uint pname, int[] @params);

			public delegate void GetShaderInfoLog(uint shader, int bufSize, out int length, StringBuilder infoLog);

			public delegate void GetShaderiv(uint shader, uint pname, out int @params);

			public delegate void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int[] range, int[] precision);

			public delegate void GetShaderSource(uint shader, int bufSize, int[] length, StringBuilder source);

			public delegate IntPtr GetString(uint name);

			public delegate IntPtr GetStringi(uint name, uint index);

			public delegate uint GetSubroutineIndex(uint program, uint shadertype, string name);

			public delegate int GetSubroutineUniformLocation(uint program, uint shadertype, string name);

			public delegate void GetSynciv(IntPtr sync, uint pname, int bufSize, int[] length, int[] values);

			public delegate void GetTexImage(uint target, int level, uint format, uint type, IntPtr pixels);

			public delegate void GetTexLevelParameterfv(uint target, int level, uint pname, float[] @params);

			public delegate void GetTexLevelParameteriv(uint target, int level, uint pname, int[] @params);

			public delegate void GetTexParameterfv(uint target, uint pname, float[] @params);

			public delegate void GetTexParameterIiv(uint target, uint pname, int[] @params);

			public delegate void GetTexParameterIuiv(uint target, uint pname, uint[] @params);

			public delegate void GetTexParameteriv(uint target, uint pname, int[] @params);

			public delegate void GetTextureImage(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels);

			public delegate void GetTextureLevelParameterfv(uint texture, int level, uint pname, float[] @params);

			public delegate void GetTextureLevelParameteriv(uint texture, int level, uint pname, int[] @params);

			public delegate void GetTextureParameterfv(uint texture, uint pname, float[] @params);

			public delegate void GetTextureParameterIiv(uint texture, uint pname, int[] @params);

			public delegate void GetTextureParameterIuiv(uint texture, uint pname, uint[] @params);

			public delegate void GetTextureParameteriv(uint texture, uint pname, int[] @params);

			public delegate void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels);

			public delegate void GetTransformFeedbacki_v(uint xfb, uint pname, uint index, int[] param);

			public delegate void GetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long[] param);

			public delegate void GetTransformFeedbackiv(uint xfb, uint pname, int[] param);

			public delegate void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name);

			public delegate uint GetUniformBlockIndex(uint program, string uniformBlockName);

			public delegate void GetUniformdv(uint program, int location, double[] @params);

			public delegate void GetUniformfv(uint program, int location, float[] @params);

			public delegate void GetUniformIndices(uint program, int uniformCount, string[] uniformNames, uint[] uniformIndices);

			public delegate void GetUniformiv(uint program, int location, int[] @params);

			public delegate int GetUniformLocation(uint program, string name);

			public delegate void GetUniformSubroutineuiv(uint shadertype, int location, uint[] @params);

			public delegate void GetUniformuiv(uint program, int location, uint[] @params);

			public delegate void GetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long[] param);

			public delegate void GetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int[] param);

			public delegate void GetVertexArrayiv(uint vaobj, uint pname, int[] param);

			public delegate void GetVertexAttribdv(uint index, uint pname, double[] @params);

			public delegate void GetVertexAttribfv(uint index, uint pname, float[] @params);

			public delegate void GetVertexAttribIiv(uint index, uint pname, int[] @params);

			public delegate void GetVertexAttribIuiv(uint index, uint pname, uint[] @params);

			public delegate void GetVertexAttribiv(uint index, uint pname, int[] @params);

			public delegate void GetVertexAttribLdv(uint index, uint pname, double[] @params);

			public delegate void GetVertexAttribPointerv(uint index, uint pname, IntPtr[] pointer);

			public delegate void Hint(uint target, uint mode);

			public delegate void InvalidateBufferData(uint buffer);

			public delegate void InvalidateBufferSubData(uint buffer, int offset, int length);

			public delegate void InvalidateFramebuffer(uint target, int numAttachments, uint[] attachments);

			public delegate void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint[] attachments);

			public delegate void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint[] attachments, int x, int y, int width, int height);

			public delegate void InvalidateSubFramebuffer(uint target, int numAttachments, uint[] attachments, int x, int y, int width, int height);

			public delegate void InvalidateTexImage(uint texture, int level);

			public delegate void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);

			public delegate bool IsBuffer(uint buffer);

			public delegate bool IsEnabled(uint cap);

			public delegate bool IsEnabledi(uint target, uint index);

			public delegate bool IsFramebuffer(uint framebuffer);

			public delegate bool IsProgram(uint program);

			public delegate bool IsProgramPipeline(uint pipeline);

			public delegate bool IsQuery(uint id);

			public delegate bool IsRenderbuffer(uint renderbuffer);

			public delegate bool IsSampler(uint sampler);

			public delegate bool IsShader(uint shader);

			public delegate bool IsSync(IntPtr sync);

			public delegate bool IsTexture(uint texture);

			public delegate bool IsTransformFeedback(uint id);

			public delegate bool IsVertexArray(uint array);

			public delegate void LineWidth(float width);

			public delegate void LinkProgram(uint program);

			public delegate void LogicOp(uint opcode);

			public delegate IntPtr MapBuffer(uint target, uint access);

			public delegate IntPtr MapBufferRange(uint target, int offset, int length, uint access);

			public delegate IntPtr MapNamedBuffer(uint buffer, uint access);

			public delegate IntPtr MapNamedBufferRange(uint buffer, int offset, int length, uint access);

			public delegate void MemoryBarrier(uint barriers);

			public delegate void MemoryBarrierByRegion(uint barriers);

			public delegate void MinSampleShading(float value);

			public delegate void MultiDrawArrays(uint mode, int[] first, int[] count, int drawcount);

			public delegate void MultiDrawArraysIndirect(uint mode, IntPtr indirect, int drawcount, int stride);

			public delegate void MultiDrawElements(uint mode, int[] count, uint type, IntPtr[] indices, int drawcount);

			public delegate void MultiDrawElementsBaseVertex(uint mode, int[] count, uint type, IntPtr[] indices, int drawcount, int[] basevertex);

			public delegate void MultiDrawElementsIndirect(uint mode, uint type, IntPtr indirect, int drawcount, int stride);

			public delegate void NamedBufferData(uint buffer, int size, IntPtr data, uint usage);

			public delegate void NamedBufferStorage(uint buffer, int size, IntPtr data, uint flags);

			public delegate void NamedBufferSubData(uint buffer, int offset, int size, IntPtr data);

			public delegate void NamedFramebufferDrawBuffer(uint framebuffer, uint buf);

			public delegate void NamedFramebufferDrawBuffers(uint framebuffer, int n, uint[] bufs);

			public delegate void NamedFramebufferParameteri(uint framebuffer, uint pname, int param);

			public delegate void NamedFramebufferReadBuffer(uint framebuffer, uint src);

			public delegate void NamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);

			public delegate void NamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level);

			public delegate void NamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer);

			public delegate void NamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height);

			public delegate void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height);

			public delegate void ObjectLabel(uint identifier, uint name, int length, string label);

			public delegate void ObjectPtrLabel(IntPtr ptr, int length, string label);

			public delegate void PatchParameterfv(uint pname, float[] values);

			public delegate void PatchParameteri(uint pname, int value);

			public delegate void PauseTransformFeedback();

			public delegate void PixelStoref(uint pname, float param);

			public delegate void PixelStorei(uint pname, int param);

			public delegate void PointParameterf(uint pname, float param);

			public delegate void PointParameterfv(uint pname, float[] @params);

			public delegate void PointParameteri(uint pname, int param);

			public delegate void PointParameteriv(uint pname, int[] @params);

			public delegate void PointSize(float size);

			public delegate void PolygonMode(uint face, uint mode);

			public delegate void PolygonOffset(float factor, float units);

			public delegate void PopDebugGroup();

			public delegate void PrimitiveRestartIndex(uint index);

			public delegate void ProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length);

			public delegate void ProgramParameteri(uint program, uint pname, int value);

			public delegate void ProgramUniform1d(uint program, int location, double v0);

			public delegate void ProgramUniform1dv(uint program, int location, int count, double[] value);

			public delegate void ProgramUniform1f(uint program, int location, float v0);

			public delegate void ProgramUniform1fv(uint program, int location, int count, float[] value);

			public delegate void ProgramUniform1i(uint program, int location, int v0);

			public delegate void ProgramUniform1iv(uint program, int location, int count, int[] value);

			public delegate void ProgramUniform1ui(uint program, int location, uint v0);

			public delegate void ProgramUniform1uiv(uint program, int location, int count, uint[] value);

			public delegate void ProgramUniform2d(uint program, int location, double v0, double v1);

			public delegate void ProgramUniform2dv(uint program, int location, int count, double[] value);

			public delegate void ProgramUniform2f(uint program, int location, float v0, float v1);

			public delegate void ProgramUniform2fv(uint program, int location, int count, float[] value);

			public delegate void ProgramUniform2i(uint program, int location, int v0, int v1);

			public delegate void ProgramUniform2iv(uint program, int location, int count, int[] value);

			public delegate void ProgramUniform2ui(uint program, int location, uint v0, uint v1);

			public delegate void ProgramUniform2uiv(uint program, int location, int count, uint[] value);

			public delegate void ProgramUniform3d(uint program, int location, double v0, double v1, double v2);

			public delegate void ProgramUniform3dv(uint program, int location, int count, double[] value);

			public delegate void ProgramUniform3f(uint program, int location, float v0, float v1, float v2);

			public delegate void ProgramUniform3fv(uint program, int location, int count, float[] value);

			public delegate void ProgramUniform3i(uint program, int location, int v0, int v1, int v2);

			public delegate void ProgramUniform3iv(uint program, int location, int count, int[] value);

			public delegate void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);

			public delegate void ProgramUniform3uiv(uint program, int location, int count, uint[] value);

			public delegate void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);

			public delegate void ProgramUniform4dv(uint program, int location, int count, double[] value);

			public delegate void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);

			public delegate void ProgramUniform4fv(uint program, int location, int count, float[] value);

			public delegate void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);

			public delegate void ProgramUniform4iv(uint program, int location, int count, int[] value);

			public delegate void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);

			public delegate void ProgramUniform4uiv(uint program, int location, int count, uint[] value);

			public delegate void ProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void ProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void ProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void ProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void ProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void ProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void ProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void ProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void ProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void ProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void ProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void ProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void ProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void ProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void ProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void ProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void ProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void ProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void ProvokingVertex(uint mode);

			public delegate void PushDebugGroup(uint source, uint id, int length, string message);

			public delegate void QueryCounter(uint id, uint target);

			public delegate void ReadBuffer(uint src);

			public delegate void ReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data);

			public delegate void ReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels);

			public delegate void ReleaseShaderCompiler();

			public delegate void RenderbufferStorage(uint target, uint internalformat, int width, int height);

			public delegate void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);

			public delegate void ResumeTransformFeedback();

			public delegate void SampleCoverage(float value, bool invert);

			public delegate void SampleMaski(uint maskNumber, uint mask);

			public delegate void SamplerParameterf(uint sampler, uint pname, float param);

			public delegate void SamplerParameterfv(uint sampler, uint pname, float[] param);

			public delegate void SamplerParameteri(uint sampler, uint pname, int param);

			public delegate void SamplerParameterIiv(uint sampler, uint pname, int[] param);

			public delegate void SamplerParameterIuiv(uint sampler, uint pname, uint[] param);

			public delegate void SamplerParameteriv(uint sampler, uint pname, int[] param);

			public delegate void Scissor(int x, int y, int width, int height);

			public delegate void ScissorArrayv(uint first, int count, int[] v);

			public delegate void ScissorIndexed(uint index, int left, int bottom, int width, int height);

			public delegate void ScissorIndexedv(uint index, int[] v);

			public delegate void ShaderBinary(int count, uint[] shaders, uint binaryformat, IntPtr binary, int length);

			public delegate void ShaderSource(uint shader, int count, ref string @string, ref int length);

			public delegate void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);

			public delegate void StencilFunc(uint func, int @ref, uint mask);

			public delegate void StencilFuncSeparate(uint face, uint func, int @ref, uint mask);

			public delegate void StencilMask(uint mask);

			public delegate void StencilMaskSeparate(uint face, uint mask);

			public delegate void StencilOp(uint fail, uint zfail, uint zpass);

			public delegate void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);

			public delegate void TexBuffer(uint target, uint internalformat, uint buffer);

			public delegate void TexBufferRange(uint target, uint internalformat, uint buffer, int offset, int size);

			public delegate void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels);

			public delegate void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);

			public delegate void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);

			public delegate void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void TexParameterf(uint target, uint pname, float param);

			public delegate void TexParameterfv(uint target, uint pname, float[] @params);

			public delegate void TexParameteri(uint target, uint pname, int param);

			public delegate void TexParameterIiv(uint target, uint pname, int[] @params);

			public delegate void TexParameterIuiv(uint target, uint pname, uint[] @params);

			public delegate void TexParameteriv(uint target, uint pname, int[] @params);

			public delegate void TexStorage1D(uint target, int levels, uint internalformat, int width);

			public delegate void TexStorage2D(uint target, int levels, uint internalformat, int width, int height);

			public delegate void TexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);

			public delegate void TexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);

			public delegate void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);

			public delegate void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

			public delegate void TextureBarrier();

			public delegate void TextureBuffer(uint texture, uint internalformat, uint buffer);

			public delegate void TextureBufferRange(uint texture, uint internalformat, uint buffer, int offset, int size);

			public delegate void TextureParameterf(uint texture, uint pname, float param);

			public delegate void TextureParameterfv(uint texture, uint pname, float[] param);

			public delegate void TextureParameteri(uint texture, uint pname, int param);

			public delegate void TextureParameterIiv(uint texture, uint pname, int[] @params);

			public delegate void TextureParameterIuiv(uint texture, uint pname, uint[] @params);

			public delegate void TextureParameteriv(uint texture, uint pname, int[] param);

			public delegate void TextureStorage1D(uint texture, int levels, uint internalformat, int width);

			public delegate void TextureStorage2D(uint texture, int levels, uint internalformat, int width, int height);

			public delegate void TextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void TextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth);

			public delegate void TextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void TextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);

			public delegate void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);

			public delegate void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

			public delegate void TextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

			public delegate void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer);

			public delegate void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size);

			public delegate void TransformFeedbackVaryings(uint program, int count, string[] varyings, uint bufferMode);

			public delegate void Uniform1d(int location, double x);

			public delegate void Uniform1dv(int location, int count, double[] value);

			public delegate void Uniform1f(int location, float v0);

			public delegate void Uniform1fv(int location, int count, float[] value);

			public delegate void Uniform1i(int location, int v0);

			public delegate void Uniform1iv(int location, int count, int[] value);

			public delegate void Uniform1ui(int location, uint v0);

			public delegate void Uniform1uiv(int location, int count, uint[] value);

			public delegate void Uniform2d(int location, double x, double y);

			public delegate void Uniform2dv(int location, int count, double[] value);

			public delegate void Uniform2f(int location, float v0, float v1);

			public delegate void Uniform2fv(int location, int count, float[] value);

			public delegate void Uniform2i(int location, int v0, int v1);

			public delegate void Uniform2iv(int location, int count, int[] value);

			public delegate void Uniform2ui(int location, uint v0, uint v1);

			public delegate void Uniform2uiv(int location, int count, uint[] value);

			public delegate void Uniform3d(int location, double x, double y, double z);

			public delegate void Uniform3dv(int location, int count, double[] value);

			public delegate void Uniform3f(int location, float v0, float v1, float v2);

			public delegate void Uniform3fv(int location, int count, float[] value);

			public delegate void Uniform3i(int location, int v0, int v1, int v2);

			public delegate void Uniform3iv(int location, int count, int[] value);

			public delegate void Uniform3ui(int location, uint v0, uint v1, uint v2);

			public delegate void Uniform3uiv(int location, int count, uint[] value);

			public delegate void Uniform4d(int location, double x, double y, double z, double w);

			public delegate void Uniform4dv(int location, int count, double[] value);

			public delegate void Uniform4f(int location, float v0, float v1, float v2, float v3);

			public delegate void Uniform4fv(int location, int count, float[] value);

			public delegate void Uniform4i(int location, int v0, int v1, int v2, int v3);

			public delegate void Uniform4iv(int location, int count, int[] value);

			public delegate void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3);

			public delegate void Uniform4uiv(int location, int count, uint[] value);

			public delegate void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

			public delegate void UniformMatrix2dv(int location, int count, bool transpose, double[] value);

			public delegate void UniformMatrix2fv(int location, int count, bool transpose, float[] value);

			public delegate void UniformMatrix2x3dv(int location, int count, bool transpose, double[] value);

			public delegate void UniformMatrix2x3fv(int location, int count, bool transpose, float[] value);

			public delegate void UniformMatrix2x4dv(int location, int count, bool transpose, double[] value);

			public delegate void UniformMatrix2x4fv(int location, int count, bool transpose, float[] value);

			public delegate void UniformMatrix3dv(int location, int count, bool transpose, double[] value);

			public delegate void UniformMatrix3fv(int location, int count, bool transpose, float[] value);

			public delegate void UniformMatrix3x2dv(int location, int count, bool transpose, double[] value);

			public delegate void UniformMatrix3x2fv(int location, int count, bool transpose, float[] value);

			public delegate void UniformMatrix3x4dv(int location, int count, bool transpose, double[] value);

			public delegate void UniformMatrix3x4fv(int location, int count, bool transpose, float[] value);

			public delegate void UniformMatrix4dv(int location, int count, bool transpose, double[] value);

			public delegate void UniformMatrix4fv(int location, int count, bool transpose, ref float value);

			public delegate void UniformMatrix4x2dv(int location, int count, bool transpose, double[] value);

			public delegate void UniformMatrix4x2fv(int location, int count, bool transpose, float[] value);

			public delegate void UniformMatrix4x3dv(int location, int count, bool transpose, double[] value);

			public delegate void UniformMatrix4x3fv(int location, int count, bool transpose, float[] value);

			public delegate void UniformSubroutinesuiv(uint shadertype, int count, uint[] indices);

			public delegate bool UnmapBuffer(uint target);

			public delegate bool UnmapNamedBuffer(uint buffer);

			public delegate void UseProgram(uint program);

			public delegate void UseProgramStages(uint pipeline, uint stages, uint program);

			public delegate void ValidateProgram(uint program);

			public delegate void ValidateProgramPipeline(uint pipeline);

			public delegate void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex);

			public delegate void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);

			public delegate void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor);

			public delegate void VertexArrayElementBuffer(uint vaobj, uint buffer);

			public delegate void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride);

			public delegate void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint[] buffers, int[] offsets, int[] strides);

			public delegate void VertexAttrib1d(uint index, double x);

			public delegate void VertexAttrib1dv(uint index, double[] v);

			public delegate void VertexAttrib1f(uint index, float x);

			public delegate void VertexAttrib1fv(uint index, float[] v);

			public delegate void VertexAttrib1s(uint index, short x);

			public delegate void VertexAttrib1sv(uint index, short[] v);

			public delegate void VertexAttrib2d(uint index, double x, double y);

			public delegate void VertexAttrib2dv(uint index, double[] v);

			public delegate void VertexAttrib2f(uint index, float x, float y);

			public delegate void VertexAttrib2fv(uint index, float[] v);

			public delegate void VertexAttrib2s(uint index, short x, short y);

			public delegate void VertexAttrib2sv(uint index, short[] v);

			public delegate void VertexAttrib3d(uint index, double x, double y, double z);

			public delegate void VertexAttrib3dv(uint index, double[] v);

			public delegate void VertexAttrib3f(uint index, float x, float y, float z);

			public delegate void VertexAttrib3fv(uint index, float[] v);

			public delegate void VertexAttrib3s(uint index, short x, short y, short z);

			public delegate void VertexAttrib3sv(uint index, short[] v);

			public delegate void VertexAttrib4bv(uint index, sbyte[] v);

			public delegate void VertexAttrib4d(uint index, double x, double y, double z, double w);

			public delegate void VertexAttrib4dv(uint index, double[] v);

			public delegate void VertexAttrib4f(uint index, float x, float y, float z, float w);

			public delegate void VertexAttrib4fv(uint index, float[] v);

			public delegate void VertexAttrib4iv(uint index, int[] v);

			public delegate void VertexAttrib4Nbv(uint index, sbyte[] v);

			public delegate void VertexAttrib4Niv(uint index, int[] v);

			public delegate void VertexAttrib4Nsv(uint index, short[] v);

			public delegate void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);

			public delegate void VertexAttrib4Nubv(uint index, byte[] v);

			public delegate void VertexAttrib4Nuiv(uint index, uint[] v);

			public delegate void VertexAttrib4Nusv(uint index, ushort[] v);

			public delegate void VertexAttrib4s(uint index, short x, short y, short z, short w);

			public delegate void VertexAttrib4sv(uint index, short[] v);

			public delegate void VertexAttrib4ubv(uint index, byte[] v);

			public delegate void VertexAttrib4uiv(uint index, uint[] v);

			public delegate void VertexAttrib4usv(uint index, ushort[] v);

			public delegate void VertexAttribBinding(uint attribindex, uint bindingindex);

			public delegate void VertexAttribDivisor(uint index, uint divisor);

			public delegate void VertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);

			public delegate void VertexAttribI1i(uint index, int x);

			public delegate void VertexAttribI1iv(uint index, int[] v);

			public delegate void VertexAttribI1ui(uint index, uint x);

			public delegate void VertexAttribI1uiv(uint index, uint[] v);

			public delegate void VertexAttribI2i(uint index, int x, int y);

			public delegate void VertexAttribI2iv(uint index, int[] v);

			public delegate void VertexAttribI2ui(uint index, uint x, uint y);

			public delegate void VertexAttribI2uiv(uint index, uint[] v);

			public delegate void VertexAttribI3i(uint index, int x, int y, int z);

			public delegate void VertexAttribI3iv(uint index, int[] v);

			public delegate void VertexAttribI3ui(uint index, uint x, uint y, uint z);

			public delegate void VertexAttribI3uiv(uint index, uint[] v);

			public delegate void VertexAttribI4bv(uint index, sbyte[] v);

			public delegate void VertexAttribI4i(uint index, int x, int y, int z, int w);

			public delegate void VertexAttribI4iv(uint index, int[] v);

			public delegate void VertexAttribI4sv(uint index, short[] v);

			public delegate void VertexAttribI4ubv(uint index, byte[] v);

			public delegate void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);

			public delegate void VertexAttribI4uiv(uint index, uint[] v);

			public delegate void VertexAttribI4usv(uint index, ushort[] v);

			public delegate void VertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void VertexAttribIPointer(uint index, int size, uint type, int stride, IntPtr pointer);

			public delegate void VertexAttribL1d(uint index, double x);

			public delegate void VertexAttribL1dv(uint index, double[] v);

			public delegate void VertexAttribL2d(uint index, double x, double y);

			public delegate void VertexAttribL2dv(uint index, double[] v);

			public delegate void VertexAttribL3d(uint index, double x, double y, double z);

			public delegate void VertexAttribL3dv(uint index, double[] v);

			public delegate void VertexAttribL4d(uint index, double x, double y, double z, double w);

			public delegate void VertexAttribL4dv(uint index, double[] v);

			public delegate void VertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void VertexAttribLPointer(uint index, int size, uint type, int stride, IntPtr pointer);

			public delegate void VertexAttribP1ui(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP1uiv(uint index, uint type, bool normalized, uint[] value);

			public delegate void VertexAttribP2ui(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP2uiv(uint index, uint type, bool normalized, uint[] value);

			public delegate void VertexAttribP3ui(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP3uiv(uint index, uint type, bool normalized, uint[] value);

			public delegate void VertexAttribP4ui(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP4uiv(uint index, uint type, bool normalized, uint[] value);

			public delegate void VertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer);

			public delegate void VertexBindingDivisor(uint bindingindex, uint divisor);

			public delegate void Viewport(int x, int y, int width, int height);

			public delegate void ViewportArrayv(uint first, int count, float[] v);

			public delegate void ViewportIndexedf(uint index, float x, float y, float w, float h);

			public delegate void ViewportIndexedfv(uint index, float[] v);

			public delegate void WaitSync(IntPtr sync, uint flags, ulong timeout);

		}

		private readonly IGLPlatformContext platformContext;

		private Delegates.ActiveShaderProgram _ActiveShaderProgram;

		private Delegates.ActiveTexture _ActiveTexture;

		private Delegates.AttachShader _AttachShader;

		private Delegates.BeginConditionalRender _BeginConditionalRender;

		private Delegates.BeginQuery _BeginQuery;

		private Delegates.BeginQueryIndexed _BeginQueryIndexed;

		private Delegates.BeginTransformFeedback _BeginTransformFeedback;

		private Delegates.BindAttribLocation _BindAttribLocation;

		private Delegates.BindBuffer _BindBuffer;

		private Delegates.BindBufferBase _BindBufferBase;

		private Delegates.BindBufferRange _BindBufferRange;

		private Delegates.BindBuffersBase _BindBuffersBase;

		private Delegates.BindBuffersRange _BindBuffersRange;

		private Delegates.BindFragDataLocation _BindFragDataLocation;

		private Delegates.BindFragDataLocationIndexed _BindFragDataLocationIndexed;

		private Delegates.BindFramebuffer _BindFramebuffer;

		private Delegates.BindImageTexture _BindImageTexture;

		private Delegates.BindImageTextures _BindImageTextures;

		private Delegates.BindProgramPipeline _BindProgramPipeline;

		private Delegates.BindRenderbuffer _BindRenderbuffer;

		private Delegates.BindSampler _BindSampler;

		private Delegates.BindSamplers _BindSamplers;

		private Delegates.BindTexture _BindTexture;

		private Delegates.BindTextures _BindTextures;

		private Delegates.BindTextureUnit _BindTextureUnit;

		private Delegates.BindTransformFeedback _BindTransformFeedback;

		private Delegates.BindVertexArray _BindVertexArray;

		private Delegates.BindVertexBuffer _BindVertexBuffer;

		private Delegates.BindVertexBuffers _BindVertexBuffers;

		private Delegates.BlendColor _BlendColor;

		private Delegates.BlendEquation _BlendEquation;

		private Delegates.BlendEquationi _BlendEquationi;

		private Delegates.BlendEquationSeparate _BlendEquationSeparate;

		private Delegates.BlendEquationSeparatei _BlendEquationSeparatei;

		private Delegates.BlendFunc _BlendFunc;

		private Delegates.BlendFunci _BlendFunci;

		private Delegates.BlendFuncSeparate _BlendFuncSeparate;

		private Delegates.BlendFuncSeparatei _BlendFuncSeparatei;

		private Delegates.BlitFramebuffer _BlitFramebuffer;

		private Delegates.BlitNamedFramebuffer _BlitNamedFramebuffer;

		private Delegates.BufferData _BufferData;

		private Delegates.BufferStorage _BufferStorage;

		private Delegates.BufferSubData _BufferSubData;

		private Delegates.CheckFramebufferStatus _CheckFramebufferStatus;

		private Delegates.CheckNamedFramebufferStatus _CheckNamedFramebufferStatus;

		private Delegates.ClampColor _ClampColor;

		private Delegates.Clear _Clear;

		private Delegates.ClearBufferData _ClearBufferData;

		private Delegates.ClearBufferfi _ClearBufferfi;

		private Delegates.ClearBufferfv _ClearBufferfv;

		private Delegates.ClearBufferiv _ClearBufferiv;

		private Delegates.ClearBufferSubData _ClearBufferSubData;

		private Delegates.ClearBufferuiv _ClearBufferuiv;

		private Delegates.ClearColor _ClearColor;

		private Delegates.ClearDepth _ClearDepth;

		private Delegates.ClearDepthf _ClearDepthf;

		private Delegates.ClearNamedBufferData _ClearNamedBufferData;

		private Delegates.ClearNamedBufferSubData _ClearNamedBufferSubData;

		private Delegates.ClearNamedFramebufferfi _ClearNamedFramebufferfi;

		private Delegates.ClearNamedFramebufferfv _ClearNamedFramebufferfv;

		private Delegates.ClearNamedFramebufferiv _ClearNamedFramebufferiv;

		private Delegates.ClearNamedFramebufferuiv _ClearNamedFramebufferuiv;

		private Delegates.ClearStencil _ClearStencil;

		private Delegates.ClearTexImage _ClearTexImage;

		private Delegates.ClearTexSubImage _ClearTexSubImage;

		private Delegates.ClientWaitSync _ClientWaitSync;

		private Delegates.ClipControl _ClipControl;

		private Delegates.ColorMask _ColorMask;

		private Delegates.ColorMaski _ColorMaski;

		private Delegates.CompileShader _CompileShader;

		private Delegates.CompressedTexImage1D _CompressedTexImage1D;

		private Delegates.CompressedTexImage2D _CompressedTexImage2D;

		private Delegates.CompressedTexImage3D _CompressedTexImage3D;

		private Delegates.CompressedTexSubImage1D _CompressedTexSubImage1D;

		private Delegates.CompressedTexSubImage2D _CompressedTexSubImage2D;

		private Delegates.CompressedTexSubImage3D _CompressedTexSubImage3D;

		private Delegates.CompressedTextureSubImage1D _CompressedTextureSubImage1D;

		private Delegates.CompressedTextureSubImage2D _CompressedTextureSubImage2D;

		private Delegates.CompressedTextureSubImage3D _CompressedTextureSubImage3D;

		private Delegates.CopyBufferSubData _CopyBufferSubData;

		private Delegates.CopyImageSubData _CopyImageSubData;

		private Delegates.CopyNamedBufferSubData _CopyNamedBufferSubData;

		private Delegates.CopyTexImage1D _CopyTexImage1D;

		private Delegates.CopyTexImage2D _CopyTexImage2D;

		private Delegates.CopyTexSubImage1D _CopyTexSubImage1D;

		private Delegates.CopyTexSubImage2D _CopyTexSubImage2D;

		private Delegates.CopyTexSubImage3D _CopyTexSubImage3D;

		private Delegates.CopyTextureSubImage1D _CopyTextureSubImage1D;

		private Delegates.CopyTextureSubImage2D _CopyTextureSubImage2D;

		private Delegates.CopyTextureSubImage3D _CopyTextureSubImage3D;

		private Delegates.CreateBuffers _CreateBuffers;

		private Delegates.CreateFramebuffers _CreateFramebuffers;

		private Delegates.CreateProgram _CreateProgram;

		private Delegates.CreateProgramPipelines _CreateProgramPipelines;

		private Delegates.CreateQueries _CreateQueries;

		private Delegates.CreateRenderbuffers _CreateRenderbuffers;

		private Delegates.CreateSamplers _CreateSamplers;

		private Delegates.CreateShader _CreateShader;

		private Delegates.CreateShaderProgramv _CreateShaderProgramv;

		private Delegates.CreateTextures _CreateTextures;

		private Delegates.CreateTransformFeedbacks _CreateTransformFeedbacks;

		private Delegates.CreateVertexArrays _CreateVertexArrays;

		private Delegates.CullFace _CullFace;

		private Delegates.DebugMessageCallback _DebugMessageCallback;

		private Delegates.DebugMessageControl _DebugMessageControl;

		private Delegates.DebugMessageInsert _DebugMessageInsert;

		private Delegates.DeleteBuffers _DeleteBuffers;

		private Delegates.DeleteFramebuffers _DeleteFramebuffers;

		private Delegates.DeleteProgram _DeleteProgram;

		private Delegates.DeleteProgramPipelines _DeleteProgramPipelines;

		private Delegates.DeleteQueries _DeleteQueries;

		private Delegates.DeleteRenderbuffers _DeleteRenderbuffers;

		private Delegates.DeleteSamplers _DeleteSamplers;

		private Delegates.DeleteShader _DeleteShader;

		private Delegates.DeleteSync _DeleteSync;

		private Delegates.DeleteTextures _DeleteTextures;

		private Delegates.DeleteTransformFeedbacks _DeleteTransformFeedbacks;

		private Delegates.DeleteVertexArrays _DeleteVertexArrays;

		private Delegates.DepthFunc _DepthFunc;

		private Delegates.DepthMask _DepthMask;

		private Delegates.DepthRange _DepthRange;

		private Delegates.DepthRangeArrayv _DepthRangeArrayv;

		private Delegates.DepthRangef _DepthRangef;

		private Delegates.DepthRangeIndexed _DepthRangeIndexed;

		private Delegates.DetachShader _DetachShader;

		private Delegates.Disable _Disable;

		private Delegates.Disablei _Disablei;

		private Delegates.DisableVertexArrayAttrib _DisableVertexArrayAttrib;

		private Delegates.DisableVertexAttribArray _DisableVertexAttribArray;

		private Delegates.DispatchCompute _DispatchCompute;

		private Delegates.DispatchComputeIndirect _DispatchComputeIndirect;

		private Delegates.DrawArrays _DrawArrays;

		private Delegates.DrawArraysIndirect _DrawArraysIndirect;

		private Delegates.DrawArraysInstanced _DrawArraysInstanced;

		private Delegates.DrawArraysInstancedBaseInstance _DrawArraysInstancedBaseInstance;

		private Delegates.DrawBuffer _DrawBuffer;

		private Delegates.DrawBuffers _DrawBuffers;

		private Delegates.DrawElements _DrawElements;

		private Delegates.DrawElementsBaseVertex _DrawElementsBaseVertex;

		private Delegates.DrawElementsIndirect _DrawElementsIndirect;

		private Delegates.DrawElementsInstanced _DrawElementsInstanced;

		private Delegates.DrawElementsInstancedBaseInstance _DrawElementsInstancedBaseInstance;

		private Delegates.DrawElementsInstancedBaseVertex _DrawElementsInstancedBaseVertex;

		private Delegates.DrawElementsInstancedBaseVertexBaseInstance _DrawElementsInstancedBaseVertexBaseInstance;

		private Delegates.DrawRangeElements _DrawRangeElements;

		private Delegates.DrawRangeElementsBaseVertex _DrawRangeElementsBaseVertex;

		private Delegates.DrawTransformFeedback _DrawTransformFeedback;

		private Delegates.DrawTransformFeedbackInstanced _DrawTransformFeedbackInstanced;

		private Delegates.DrawTransformFeedbackStream _DrawTransformFeedbackStream;

		private Delegates.DrawTransformFeedbackStreamInstanced _DrawTransformFeedbackStreamInstanced;

		private Delegates.Enable _Enable;

		private Delegates.Enablei _Enablei;

		private Delegates.EnableVertexArrayAttrib _EnableVertexArrayAttrib;

		private Delegates.EnableVertexAttribArray _EnableVertexAttribArray;

		private Delegates.EndConditionalRender _EndConditionalRender;

		private Delegates.EndQuery _EndQuery;

		private Delegates.EndQueryIndexed _EndQueryIndexed;

		private Delegates.EndTransformFeedback _EndTransformFeedback;

		private Delegates.FenceSync _FenceSync;

		private Delegates.Finish _Finish;

		private Delegates.Flush _Flush;

		private Delegates.FlushMappedBufferRange _FlushMappedBufferRange;

		private Delegates.FlushMappedNamedBufferRange _FlushMappedNamedBufferRange;

		private Delegates.FramebufferParameteri _FramebufferParameteri;

		private Delegates.FramebufferRenderbuffer _FramebufferRenderbuffer;

		private Delegates.FramebufferTexture _FramebufferTexture;

		private Delegates.FramebufferTexture1D _FramebufferTexture1D;

		private Delegates.FramebufferTexture2D _FramebufferTexture2D;

		private Delegates.FramebufferTexture3D _FramebufferTexture3D;

		private Delegates.FramebufferTextureLayer _FramebufferTextureLayer;

		private Delegates.FrontFace _FrontFace;

		private Delegates.GenBuffers _GenBuffers;

		private Delegates.GenerateMipmap _GenerateMipmap;

		private Delegates.GenerateTextureMipmap _GenerateTextureMipmap;

		private Delegates.GenFramebuffers _GenFramebuffers;

		private Delegates.GenProgramPipelines _GenProgramPipelines;

		private Delegates.GenQueries _GenQueries;

		private Delegates.GenRenderbuffers _GenRenderbuffers;

		private Delegates.GenSamplers _GenSamplers;

		private Delegates.GenTextures _GenTextures;

		private Delegates.GenTransformFeedbacks _GenTransformFeedbacks;

		private Delegates.GenVertexArrays _GenVertexArrays;

		private Delegates.GetActiveAtomicCounterBufferiv _GetActiveAtomicCounterBufferiv;

		private Delegates.GetActiveAttrib _GetActiveAttrib;

		private Delegates.GetActiveSubroutineName _GetActiveSubroutineName;

		private Delegates.GetActiveSubroutineUniformiv _GetActiveSubroutineUniformiv;

		private Delegates.GetActiveSubroutineUniformName _GetActiveSubroutineUniformName;

		private Delegates.GetActiveUniform _GetActiveUniform;

		private Delegates.GetActiveUniformBlockiv _GetActiveUniformBlockiv;

		private Delegates.GetActiveUniformBlockName _GetActiveUniformBlockName;

		private Delegates.GetActiveUniformName _GetActiveUniformName;

		private Delegates.GetActiveUniformsiv _GetActiveUniformsiv;

		private Delegates.GetAttachedShaders _GetAttachedShaders;

		private Delegates.GetAttribLocation _GetAttribLocation;

		private Delegates.GetBooleani_v _GetBooleani_v;

		private Delegates.GetBooleanv _GetBooleanv;

		private Delegates.GetBufferParameteri64v _GetBufferParameteri64v;

		private Delegates.GetBufferParameteriv _GetBufferParameteriv;

		private Delegates.GetBufferPointerv _GetBufferPointerv;

		private Delegates.GetBufferSubData _GetBufferSubData;

		private Delegates.GetCompressedTexImage _GetCompressedTexImage;

		private Delegates.GetCompressedTextureImage _GetCompressedTextureImage;

		private Delegates.GetCompressedTextureSubImage _GetCompressedTextureSubImage;

		private Delegates.GetDebugMessageLog _GetDebugMessageLog;

		private Delegates.GetDoublei_v _GetDoublei_v;

		private Delegates.GetDoublev _GetDoublev;

		private Delegates.GetError _GetError;

		private Delegates.GetFloati_v _GetFloati_v;

		private Delegates.GetFloatv _GetFloatv;

		private Delegates.GetFragDataIndex _GetFragDataIndex;

		private Delegates.GetFragDataLocation _GetFragDataLocation;

		private Delegates.GetFramebufferAttachmentParameteriv _GetFramebufferAttachmentParameteriv;

		private Delegates.GetFramebufferParameteriv _GetFramebufferParameteriv;

		private Delegates.GetGraphicsResetStatus _GetGraphicsResetStatus;

		private Delegates.GetInteger64i_v _GetInteger64i_v;

		private Delegates.GetInteger64v _GetInteger64v;

		private Delegates.GetIntegeri_v _GetIntegeri_v;

		private Delegates.GetIntegerv _GetIntegerv;

		private Delegates.GetInternalformati64v _GetInternalformati64v;

		private Delegates.GetInternalformativ _GetInternalformativ;

		private Delegates.GetMultisamplefv _GetMultisamplefv;

		private Delegates.GetNamedBufferParameteri64v _GetNamedBufferParameteri64v;

		private Delegates.GetNamedBufferParameteriv _GetNamedBufferParameteriv;

		private Delegates.GetNamedBufferPointerv _GetNamedBufferPointerv;

		private Delegates.GetNamedBufferSubData _GetNamedBufferSubData;

		private Delegates.GetNamedFramebufferAttachmentParameteriv _GetNamedFramebufferAttachmentParameteriv;

		private Delegates.GetNamedFramebufferParameteriv _GetNamedFramebufferParameteriv;

		private Delegates.GetNamedRenderbufferParameteriv _GetNamedRenderbufferParameteriv;

		private Delegates.GetnCompressedTexImage _GetnCompressedTexImage;

		private Delegates.GetnTexImage _GetnTexImage;

		private Delegates.GetnUniformdv _GetnUniformdv;

		private Delegates.GetnUniformfv _GetnUniformfv;

		private Delegates.GetnUniformiv _GetnUniformiv;

		private Delegates.GetnUniformuiv _GetnUniformuiv;

		private Delegates.GetObjectLabel _GetObjectLabel;

		private Delegates.GetObjectPtrLabel _GetObjectPtrLabel;

		private Delegates.GetPointerv _GetPointerv;

		private Delegates.GetProgramBinary _GetProgramBinary;

		private Delegates.GetProgramInfoLog _GetProgramInfoLog;

		private Delegates.GetProgramInterfaceiv _GetProgramInterfaceiv;

		private Delegates.GetProgramiv _GetProgramiv;

		private Delegates.GetProgramPipelineInfoLog _GetProgramPipelineInfoLog;

		private Delegates.GetProgramPipelineiv _GetProgramPipelineiv;

		private Delegates.GetProgramResourceIndex _GetProgramResourceIndex;

		private Delegates.GetProgramResourceiv _GetProgramResourceiv;

		private Delegates.GetProgramResourceLocation _GetProgramResourceLocation;

		private Delegates.GetProgramResourceLocationIndex _GetProgramResourceLocationIndex;

		private Delegates.GetProgramResourceName _GetProgramResourceName;

		private Delegates.GetProgramStageiv _GetProgramStageiv;

		private Delegates.GetQueryBufferObjecti64v _GetQueryBufferObjecti64v;

		private Delegates.GetQueryBufferObjectiv _GetQueryBufferObjectiv;

		private Delegates.GetQueryBufferObjectui64v _GetQueryBufferObjectui64v;

		private Delegates.GetQueryBufferObjectuiv _GetQueryBufferObjectuiv;

		private Delegates.GetQueryIndexediv _GetQueryIndexediv;

		private Delegates.GetQueryiv _GetQueryiv;

		private Delegates.GetQueryObjecti64v _GetQueryObjecti64v;

		private Delegates.GetQueryObjectiv _GetQueryObjectiv;

		private Delegates.GetQueryObjectui64v _GetQueryObjectui64v;

		private Delegates.GetQueryObjectuiv _GetQueryObjectuiv;

		private Delegates.GetRenderbufferParameteriv _GetRenderbufferParameteriv;

		private Delegates.GetSamplerParameterfv _GetSamplerParameterfv;

		private Delegates.GetSamplerParameterIiv _GetSamplerParameterIiv;

		private Delegates.GetSamplerParameterIuiv _GetSamplerParameterIuiv;

		private Delegates.GetSamplerParameteriv _GetSamplerParameteriv;

		private Delegates.GetShaderInfoLog _GetShaderInfoLog;

		private Delegates.GetShaderiv _GetShaderiv;

		private Delegates.GetShaderPrecisionFormat _GetShaderPrecisionFormat;

		private Delegates.GetShaderSource _GetShaderSource;

		private Delegates.GetString _GetString;

		private Delegates.GetStringi _GetStringi;

		private Delegates.GetSubroutineIndex _GetSubroutineIndex;

		private Delegates.GetSubroutineUniformLocation _GetSubroutineUniformLocation;

		private Delegates.GetSynciv _GetSynciv;

		private Delegates.GetTexImage _GetTexImage;

		private Delegates.GetTexLevelParameterfv _GetTexLevelParameterfv;

		private Delegates.GetTexLevelParameteriv _GetTexLevelParameteriv;

		private Delegates.GetTexParameterfv _GetTexParameterfv;

		private Delegates.GetTexParameterIiv _GetTexParameterIiv;

		private Delegates.GetTexParameterIuiv _GetTexParameterIuiv;

		private Delegates.GetTexParameteriv _GetTexParameteriv;

		private Delegates.GetTextureImage _GetTextureImage;

		private Delegates.GetTextureLevelParameterfv _GetTextureLevelParameterfv;

		private Delegates.GetTextureLevelParameteriv _GetTextureLevelParameteriv;

		private Delegates.GetTextureParameterfv _GetTextureParameterfv;

		private Delegates.GetTextureParameterIiv _GetTextureParameterIiv;

		private Delegates.GetTextureParameterIuiv _GetTextureParameterIuiv;

		private Delegates.GetTextureParameteriv _GetTextureParameteriv;

		private Delegates.GetTextureSubImage _GetTextureSubImage;

		private Delegates.GetTransformFeedbacki_v _GetTransformFeedbacki_v;

		private Delegates.GetTransformFeedbacki64_v _GetTransformFeedbacki64_v;

		private Delegates.GetTransformFeedbackiv _GetTransformFeedbackiv;

		private Delegates.GetTransformFeedbackVarying _GetTransformFeedbackVarying;

		private Delegates.GetUniformBlockIndex _GetUniformBlockIndex;

		private Delegates.GetUniformdv _GetUniformdv;

		private Delegates.GetUniformfv _GetUniformfv;

		private Delegates.GetUniformIndices _GetUniformIndices;

		private Delegates.GetUniformiv _GetUniformiv;

		private Delegates.GetUniformLocation _GetUniformLocation;

		private Delegates.GetUniformSubroutineuiv _GetUniformSubroutineuiv;

		private Delegates.GetUniformuiv _GetUniformuiv;

		private Delegates.GetVertexArrayIndexed64iv _GetVertexArrayIndexed64iv;

		private Delegates.GetVertexArrayIndexediv _GetVertexArrayIndexediv;

		private Delegates.GetVertexArrayiv _GetVertexArrayiv;

		private Delegates.GetVertexAttribdv _GetVertexAttribdv;

		private Delegates.GetVertexAttribfv _GetVertexAttribfv;

		private Delegates.GetVertexAttribIiv _GetVertexAttribIiv;

		private Delegates.GetVertexAttribIuiv _GetVertexAttribIuiv;

		private Delegates.GetVertexAttribiv _GetVertexAttribiv;

		private Delegates.GetVertexAttribLdv _GetVertexAttribLdv;

		private Delegates.GetVertexAttribPointerv _GetVertexAttribPointerv;

		private Delegates.Hint _Hint;

		private Delegates.InvalidateBufferData _InvalidateBufferData;

		private Delegates.InvalidateBufferSubData _InvalidateBufferSubData;

		private Delegates.InvalidateFramebuffer _InvalidateFramebuffer;

		private Delegates.InvalidateNamedFramebufferData _InvalidateNamedFramebufferData;

		private Delegates.InvalidateNamedFramebufferSubData _InvalidateNamedFramebufferSubData;

		private Delegates.InvalidateSubFramebuffer _InvalidateSubFramebuffer;

		private Delegates.InvalidateTexImage _InvalidateTexImage;

		private Delegates.InvalidateTexSubImage _InvalidateTexSubImage;

		private Delegates.IsBuffer _IsBuffer;

		private Delegates.IsEnabled _IsEnabled;

		private Delegates.IsEnabledi _IsEnabledi;

		private Delegates.IsFramebuffer _IsFramebuffer;

		private Delegates.IsProgram _IsProgram;

		private Delegates.IsProgramPipeline _IsProgramPipeline;

		private Delegates.IsQuery _IsQuery;

		private Delegates.IsRenderbuffer _IsRenderbuffer;

		private Delegates.IsSampler _IsSampler;

		private Delegates.IsShader _IsShader;

		private Delegates.IsSync _IsSync;

		private Delegates.IsTexture _IsTexture;

		private Delegates.IsTransformFeedback _IsTransformFeedback;

		private Delegates.IsVertexArray _IsVertexArray;

		private Delegates.LineWidth _LineWidth;

		private Delegates.LinkProgram _LinkProgram;

		private Delegates.LogicOp _LogicOp;

		private Delegates.MapBuffer _MapBuffer;

		private Delegates.MapBufferRange _MapBufferRange;

		private Delegates.MapNamedBuffer _MapNamedBuffer;

		private Delegates.MapNamedBufferRange _MapNamedBufferRange;

		private Delegates.MemoryBarrier _MemoryBarrier;

		private Delegates.MemoryBarrierByRegion _MemoryBarrierByRegion;

		private Delegates.MinSampleShading _MinSampleShading;

		private Delegates.MultiDrawArrays _MultiDrawArrays;

		private Delegates.MultiDrawArraysIndirect _MultiDrawArraysIndirect;

		private Delegates.MultiDrawElements _MultiDrawElements;

		private Delegates.MultiDrawElementsBaseVertex _MultiDrawElementsBaseVertex;

		private Delegates.MultiDrawElementsIndirect _MultiDrawElementsIndirect;

		private Delegates.NamedBufferData _NamedBufferData;

		private Delegates.NamedBufferStorage _NamedBufferStorage;

		private Delegates.NamedBufferSubData _NamedBufferSubData;

		private Delegates.NamedFramebufferDrawBuffer _NamedFramebufferDrawBuffer;

		private Delegates.NamedFramebufferDrawBuffers _NamedFramebufferDrawBuffers;

		private Delegates.NamedFramebufferParameteri _NamedFramebufferParameteri;

		private Delegates.NamedFramebufferReadBuffer _NamedFramebufferReadBuffer;

		private Delegates.NamedFramebufferRenderbuffer _NamedFramebufferRenderbuffer;

		private Delegates.NamedFramebufferTexture _NamedFramebufferTexture;

		private Delegates.NamedFramebufferTextureLayer _NamedFramebufferTextureLayer;

		private Delegates.NamedRenderbufferStorage _NamedRenderbufferStorage;

		private Delegates.NamedRenderbufferStorageMultisample _NamedRenderbufferStorageMultisample;

		private Delegates.ObjectLabel _ObjectLabel;

		private Delegates.ObjectPtrLabel _ObjectPtrLabel;

		private Delegates.PatchParameterfv _PatchParameterfv;

		private Delegates.PatchParameteri _PatchParameteri;

		private Delegates.PauseTransformFeedback _PauseTransformFeedback;

		private Delegates.PixelStoref _PixelStoref;

		private Delegates.PixelStorei _PixelStorei;

		private Delegates.PointParameterf _PointParameterf;

		private Delegates.PointParameterfv _PointParameterfv;

		private Delegates.PointParameteri _PointParameteri;

		private Delegates.PointParameteriv _PointParameteriv;

		private Delegates.PointSize _PointSize;

		private Delegates.PolygonMode _PolygonMode;

		private Delegates.PolygonOffset _PolygonOffset;

		private Delegates.PopDebugGroup _PopDebugGroup;

		private Delegates.PrimitiveRestartIndex _PrimitiveRestartIndex;

		private Delegates.ProgramBinary _ProgramBinary;

		private Delegates.ProgramParameteri _ProgramParameteri;

		private Delegates.ProgramUniform1d _ProgramUniform1d;

		private Delegates.ProgramUniform1dv _ProgramUniform1dv;

		private Delegates.ProgramUniform1f _ProgramUniform1f;

		private Delegates.ProgramUniform1fv _ProgramUniform1fv;

		private Delegates.ProgramUniform1i _ProgramUniform1i;

		private Delegates.ProgramUniform1iv _ProgramUniform1iv;

		private Delegates.ProgramUniform1ui _ProgramUniform1ui;

		private Delegates.ProgramUniform1uiv _ProgramUniform1uiv;

		private Delegates.ProgramUniform2d _ProgramUniform2d;

		private Delegates.ProgramUniform2dv _ProgramUniform2dv;

		private Delegates.ProgramUniform2f _ProgramUniform2f;

		private Delegates.ProgramUniform2fv _ProgramUniform2fv;

		private Delegates.ProgramUniform2i _ProgramUniform2i;

		private Delegates.ProgramUniform2iv _ProgramUniform2iv;

		private Delegates.ProgramUniform2ui _ProgramUniform2ui;

		private Delegates.ProgramUniform2uiv _ProgramUniform2uiv;

		private Delegates.ProgramUniform3d _ProgramUniform3d;

		private Delegates.ProgramUniform3dv _ProgramUniform3dv;

		private Delegates.ProgramUniform3f _ProgramUniform3f;

		private Delegates.ProgramUniform3fv _ProgramUniform3fv;

		private Delegates.ProgramUniform3i _ProgramUniform3i;

		private Delegates.ProgramUniform3iv _ProgramUniform3iv;

		private Delegates.ProgramUniform3ui _ProgramUniform3ui;

		private Delegates.ProgramUniform3uiv _ProgramUniform3uiv;

		private Delegates.ProgramUniform4d _ProgramUniform4d;

		private Delegates.ProgramUniform4dv _ProgramUniform4dv;

		private Delegates.ProgramUniform4f _ProgramUniform4f;

		private Delegates.ProgramUniform4fv _ProgramUniform4fv;

		private Delegates.ProgramUniform4i _ProgramUniform4i;

		private Delegates.ProgramUniform4iv _ProgramUniform4iv;

		private Delegates.ProgramUniform4ui _ProgramUniform4ui;

		private Delegates.ProgramUniform4uiv _ProgramUniform4uiv;

		private Delegates.ProgramUniformMatrix2dv _ProgramUniformMatrix2dv;

		private Delegates.ProgramUniformMatrix2fv _ProgramUniformMatrix2fv;

		private Delegates.ProgramUniformMatrix2x3dv _ProgramUniformMatrix2x3dv;

		private Delegates.ProgramUniformMatrix2x3fv _ProgramUniformMatrix2x3fv;

		private Delegates.ProgramUniformMatrix2x4dv _ProgramUniformMatrix2x4dv;

		private Delegates.ProgramUniformMatrix2x4fv _ProgramUniformMatrix2x4fv;

		private Delegates.ProgramUniformMatrix3dv _ProgramUniformMatrix3dv;

		private Delegates.ProgramUniformMatrix3fv _ProgramUniformMatrix3fv;

		private Delegates.ProgramUniformMatrix3x2dv _ProgramUniformMatrix3x2dv;

		private Delegates.ProgramUniformMatrix3x2fv _ProgramUniformMatrix3x2fv;

		private Delegates.ProgramUniformMatrix3x4dv _ProgramUniformMatrix3x4dv;

		private Delegates.ProgramUniformMatrix3x4fv _ProgramUniformMatrix3x4fv;

		private Delegates.ProgramUniformMatrix4dv _ProgramUniformMatrix4dv;

		private Delegates.ProgramUniformMatrix4fv _ProgramUniformMatrix4fv;

		private Delegates.ProgramUniformMatrix4x2dv _ProgramUniformMatrix4x2dv;

		private Delegates.ProgramUniformMatrix4x2fv _ProgramUniformMatrix4x2fv;

		private Delegates.ProgramUniformMatrix4x3dv _ProgramUniformMatrix4x3dv;

		private Delegates.ProgramUniformMatrix4x3fv _ProgramUniformMatrix4x3fv;

		private Delegates.ProvokingVertex _ProvokingVertex;

		private Delegates.PushDebugGroup _PushDebugGroup;

		private Delegates.QueryCounter _QueryCounter;

		private Delegates.ReadBuffer _ReadBuffer;

		private Delegates.ReadnPixels _ReadnPixels;

		private Delegates.ReadPixels _ReadPixels;

		private Delegates.ReleaseShaderCompiler _ReleaseShaderCompiler;

		private Delegates.RenderbufferStorage _RenderbufferStorage;

		private Delegates.RenderbufferStorageMultisample _RenderbufferStorageMultisample;

		private Delegates.ResumeTransformFeedback _ResumeTransformFeedback;

		private Delegates.SampleCoverage _SampleCoverage;

		private Delegates.SampleMaski _SampleMaski;

		private Delegates.SamplerParameterf _SamplerParameterf;

		private Delegates.SamplerParameterfv _SamplerParameterfv;

		private Delegates.SamplerParameteri _SamplerParameteri;

		private Delegates.SamplerParameterIiv _SamplerParameterIiv;

		private Delegates.SamplerParameterIuiv _SamplerParameterIuiv;

		private Delegates.SamplerParameteriv _SamplerParameteriv;

		private Delegates.Scissor _Scissor;

		private Delegates.ScissorArrayv _ScissorArrayv;

		private Delegates.ScissorIndexed _ScissorIndexed;

		private Delegates.ScissorIndexedv _ScissorIndexedv;

		private Delegates.ShaderBinary _ShaderBinary;

		private Delegates.ShaderSource _ShaderSource;

		private Delegates.ShaderStorageBlockBinding _ShaderStorageBlockBinding;

		private Delegates.StencilFunc _StencilFunc;

		private Delegates.StencilFuncSeparate _StencilFuncSeparate;

		private Delegates.StencilMask _StencilMask;

		private Delegates.StencilMaskSeparate _StencilMaskSeparate;

		private Delegates.StencilOp _StencilOp;

		private Delegates.StencilOpSeparate _StencilOpSeparate;

		private Delegates.TexBuffer _TexBuffer;

		private Delegates.TexBufferRange _TexBufferRange;

		private Delegates.TexImage1D _TexImage1D;

		private Delegates.TexImage2D _TexImage2D;

		private Delegates.TexImage2DMultisample _TexImage2DMultisample;

		private Delegates.TexImage3D _TexImage3D;

		private Delegates.TexImage3DMultisample _TexImage3DMultisample;

		private Delegates.TexParameterf _TexParameterf;

		private Delegates.TexParameterfv _TexParameterfv;

		private Delegates.TexParameteri _TexParameteri;

		private Delegates.TexParameterIiv _TexParameterIiv;

		private Delegates.TexParameterIuiv _TexParameterIuiv;

		private Delegates.TexParameteriv _TexParameteriv;

		private Delegates.TexStorage1D _TexStorage1D;

		private Delegates.TexStorage2D _TexStorage2D;

		private Delegates.TexStorage2DMultisample _TexStorage2DMultisample;

		private Delegates.TexStorage3D _TexStorage3D;

		private Delegates.TexStorage3DMultisample _TexStorage3DMultisample;

		private Delegates.TexSubImage1D _TexSubImage1D;

		private Delegates.TexSubImage2D _TexSubImage2D;

		private Delegates.TexSubImage3D _TexSubImage3D;

		private Delegates.TextureBarrier _TextureBarrier;

		private Delegates.TextureBuffer _TextureBuffer;

		private Delegates.TextureBufferRange _TextureBufferRange;

		private Delegates.TextureParameterf _TextureParameterf;

		private Delegates.TextureParameterfv _TextureParameterfv;

		private Delegates.TextureParameteri _TextureParameteri;

		private Delegates.TextureParameterIiv _TextureParameterIiv;

		private Delegates.TextureParameterIuiv _TextureParameterIuiv;

		private Delegates.TextureParameteriv _TextureParameteriv;

		private Delegates.TextureStorage1D _TextureStorage1D;

		private Delegates.TextureStorage2D _TextureStorage2D;

		private Delegates.TextureStorage2DMultisample _TextureStorage2DMultisample;

		private Delegates.TextureStorage3D _TextureStorage3D;

		private Delegates.TextureStorage3DMultisample _TextureStorage3DMultisample;

		private Delegates.TextureSubImage1D _TextureSubImage1D;

		private Delegates.TextureSubImage2D _TextureSubImage2D;

		private Delegates.TextureSubImage3D _TextureSubImage3D;

		private Delegates.TextureView _TextureView;

		private Delegates.TransformFeedbackBufferBase _TransformFeedbackBufferBase;

		private Delegates.TransformFeedbackBufferRange _TransformFeedbackBufferRange;

		private Delegates.TransformFeedbackVaryings _TransformFeedbackVaryings;

		private Delegates.Uniform1d _Uniform1d;

		private Delegates.Uniform1dv _Uniform1dv;

		private Delegates.Uniform1f _Uniform1f;

		private Delegates.Uniform1fv _Uniform1fv;

		private Delegates.Uniform1i _Uniform1i;

		private Delegates.Uniform1iv _Uniform1iv;

		private Delegates.Uniform1ui _Uniform1ui;

		private Delegates.Uniform1uiv _Uniform1uiv;

		private Delegates.Uniform2d _Uniform2d;

		private Delegates.Uniform2dv _Uniform2dv;

		private Delegates.Uniform2f _Uniform2f;

		private Delegates.Uniform2fv _Uniform2fv;

		private Delegates.Uniform2i _Uniform2i;

		private Delegates.Uniform2iv _Uniform2iv;

		private Delegates.Uniform2ui _Uniform2ui;

		private Delegates.Uniform2uiv _Uniform2uiv;

		private Delegates.Uniform3d _Uniform3d;

		private Delegates.Uniform3dv _Uniform3dv;

		private Delegates.Uniform3f _Uniform3f;

		private Delegates.Uniform3fv _Uniform3fv;

		private Delegates.Uniform3i _Uniform3i;

		private Delegates.Uniform3iv _Uniform3iv;

		private Delegates.Uniform3ui _Uniform3ui;

		private Delegates.Uniform3uiv _Uniform3uiv;

		private Delegates.Uniform4d _Uniform4d;

		private Delegates.Uniform4dv _Uniform4dv;

		private Delegates.Uniform4f _Uniform4f;

		private Delegates.Uniform4fv _Uniform4fv;

		private Delegates.Uniform4i _Uniform4i;

		private Delegates.Uniform4iv _Uniform4iv;

		private Delegates.Uniform4ui _Uniform4ui;

		private Delegates.Uniform4uiv _Uniform4uiv;

		private Delegates.UniformBlockBinding _UniformBlockBinding;

		private Delegates.UniformMatrix2dv _UniformMatrix2dv;

		private Delegates.UniformMatrix2fv _UniformMatrix2fv;

		private Delegates.UniformMatrix2x3dv _UniformMatrix2x3dv;

		private Delegates.UniformMatrix2x3fv _UniformMatrix2x3fv;

		private Delegates.UniformMatrix2x4dv _UniformMatrix2x4dv;

		private Delegates.UniformMatrix2x4fv _UniformMatrix2x4fv;

		private Delegates.UniformMatrix3dv _UniformMatrix3dv;

		private Delegates.UniformMatrix3fv _UniformMatrix3fv;

		private Delegates.UniformMatrix3x2dv _UniformMatrix3x2dv;

		private Delegates.UniformMatrix3x2fv _UniformMatrix3x2fv;

		private Delegates.UniformMatrix3x4dv _UniformMatrix3x4dv;

		private Delegates.UniformMatrix3x4fv _UniformMatrix3x4fv;

		private Delegates.UniformMatrix4dv _UniformMatrix4dv;

		private Delegates.UniformMatrix4fv _UniformMatrix4fv;

		private Delegates.UniformMatrix4x2dv _UniformMatrix4x2dv;

		private Delegates.UniformMatrix4x2fv _UniformMatrix4x2fv;

		private Delegates.UniformMatrix4x3dv _UniformMatrix4x3dv;

		private Delegates.UniformMatrix4x3fv _UniformMatrix4x3fv;

		private Delegates.UniformSubroutinesuiv _UniformSubroutinesuiv;

		private Delegates.UnmapBuffer _UnmapBuffer;

		private Delegates.UnmapNamedBuffer _UnmapNamedBuffer;

		private Delegates.UseProgram _UseProgram;

		private Delegates.UseProgramStages _UseProgramStages;

		private Delegates.ValidateProgram _ValidateProgram;

		private Delegates.ValidateProgramPipeline _ValidateProgramPipeline;

		private Delegates.VertexArrayAttribBinding _VertexArrayAttribBinding;

		private Delegates.VertexArrayAttribFormat _VertexArrayAttribFormat;

		private Delegates.VertexArrayAttribIFormat _VertexArrayAttribIFormat;

		private Delegates.VertexArrayAttribLFormat _VertexArrayAttribLFormat;

		private Delegates.VertexArrayBindingDivisor _VertexArrayBindingDivisor;

		private Delegates.VertexArrayElementBuffer _VertexArrayElementBuffer;

		private Delegates.VertexArrayVertexBuffer _VertexArrayVertexBuffer;

		private Delegates.VertexArrayVertexBuffers _VertexArrayVertexBuffers;

		private Delegates.VertexAttrib1d _VertexAttrib1d;

		private Delegates.VertexAttrib1dv _VertexAttrib1dv;

		private Delegates.VertexAttrib1f _VertexAttrib1f;

		private Delegates.VertexAttrib1fv _VertexAttrib1fv;

		private Delegates.VertexAttrib1s _VertexAttrib1s;

		private Delegates.VertexAttrib1sv _VertexAttrib1sv;

		private Delegates.VertexAttrib2d _VertexAttrib2d;

		private Delegates.VertexAttrib2dv _VertexAttrib2dv;

		private Delegates.VertexAttrib2f _VertexAttrib2f;

		private Delegates.VertexAttrib2fv _VertexAttrib2fv;

		private Delegates.VertexAttrib2s _VertexAttrib2s;

		private Delegates.VertexAttrib2sv _VertexAttrib2sv;

		private Delegates.VertexAttrib3d _VertexAttrib3d;

		private Delegates.VertexAttrib3dv _VertexAttrib3dv;

		private Delegates.VertexAttrib3f _VertexAttrib3f;

		private Delegates.VertexAttrib3fv _VertexAttrib3fv;

		private Delegates.VertexAttrib3s _VertexAttrib3s;

		private Delegates.VertexAttrib3sv _VertexAttrib3sv;

		private Delegates.VertexAttrib4bv _VertexAttrib4bv;

		private Delegates.VertexAttrib4d _VertexAttrib4d;

		private Delegates.VertexAttrib4dv _VertexAttrib4dv;

		private Delegates.VertexAttrib4f _VertexAttrib4f;

		private Delegates.VertexAttrib4fv _VertexAttrib4fv;

		private Delegates.VertexAttrib4iv _VertexAttrib4iv;

		private Delegates.VertexAttrib4Nbv _VertexAttrib4Nbv;

		private Delegates.VertexAttrib4Niv _VertexAttrib4Niv;

		private Delegates.VertexAttrib4Nsv _VertexAttrib4Nsv;

		private Delegates.VertexAttrib4Nub _VertexAttrib4Nub;

		private Delegates.VertexAttrib4Nubv _VertexAttrib4Nubv;

		private Delegates.VertexAttrib4Nuiv _VertexAttrib4Nuiv;

		private Delegates.VertexAttrib4Nusv _VertexAttrib4Nusv;

		private Delegates.VertexAttrib4s _VertexAttrib4s;

		private Delegates.VertexAttrib4sv _VertexAttrib4sv;

		private Delegates.VertexAttrib4ubv _VertexAttrib4ubv;

		private Delegates.VertexAttrib4uiv _VertexAttrib4uiv;

		private Delegates.VertexAttrib4usv _VertexAttrib4usv;

		private Delegates.VertexAttribBinding _VertexAttribBinding;

		private Delegates.VertexAttribDivisor _VertexAttribDivisor;

		private Delegates.VertexAttribFormat _VertexAttribFormat;

		private Delegates.VertexAttribI1i _VertexAttribI1i;

		private Delegates.VertexAttribI1iv _VertexAttribI1iv;

		private Delegates.VertexAttribI1ui _VertexAttribI1ui;

		private Delegates.VertexAttribI1uiv _VertexAttribI1uiv;

		private Delegates.VertexAttribI2i _VertexAttribI2i;

		private Delegates.VertexAttribI2iv _VertexAttribI2iv;

		private Delegates.VertexAttribI2ui _VertexAttribI2ui;

		private Delegates.VertexAttribI2uiv _VertexAttribI2uiv;

		private Delegates.VertexAttribI3i _VertexAttribI3i;

		private Delegates.VertexAttribI3iv _VertexAttribI3iv;

		private Delegates.VertexAttribI3ui _VertexAttribI3ui;

		private Delegates.VertexAttribI3uiv _VertexAttribI3uiv;

		private Delegates.VertexAttribI4bv _VertexAttribI4bv;

		private Delegates.VertexAttribI4i _VertexAttribI4i;

		private Delegates.VertexAttribI4iv _VertexAttribI4iv;

		private Delegates.VertexAttribI4sv _VertexAttribI4sv;

		private Delegates.VertexAttribI4ubv _VertexAttribI4ubv;

		private Delegates.VertexAttribI4ui _VertexAttribI4ui;

		private Delegates.VertexAttribI4uiv _VertexAttribI4uiv;

		private Delegates.VertexAttribI4usv _VertexAttribI4usv;

		private Delegates.VertexAttribIFormat _VertexAttribIFormat;

		private Delegates.VertexAttribIPointer _VertexAttribIPointer;

		private Delegates.VertexAttribL1d _VertexAttribL1d;

		private Delegates.VertexAttribL1dv _VertexAttribL1dv;

		private Delegates.VertexAttribL2d _VertexAttribL2d;

		private Delegates.VertexAttribL2dv _VertexAttribL2dv;

		private Delegates.VertexAttribL3d _VertexAttribL3d;

		private Delegates.VertexAttribL3dv _VertexAttribL3dv;

		private Delegates.VertexAttribL4d _VertexAttribL4d;

		private Delegates.VertexAttribL4dv _VertexAttribL4dv;

		private Delegates.VertexAttribLFormat _VertexAttribLFormat;

		private Delegates.VertexAttribLPointer _VertexAttribLPointer;

		private Delegates.VertexAttribP1ui _VertexAttribP1ui;

		private Delegates.VertexAttribP1uiv _VertexAttribP1uiv;

		private Delegates.VertexAttribP2ui _VertexAttribP2ui;

		private Delegates.VertexAttribP2uiv _VertexAttribP2uiv;

		private Delegates.VertexAttribP3ui _VertexAttribP3ui;

		private Delegates.VertexAttribP3uiv _VertexAttribP3uiv;

		private Delegates.VertexAttribP4ui _VertexAttribP4ui;

		private Delegates.VertexAttribP4uiv _VertexAttribP4uiv;

		private Delegates.VertexAttribPointer _VertexAttribPointer;

		private Delegates.VertexBindingDivisor _VertexBindingDivisor;

		private Delegates.Viewport _Viewport;

		private Delegates.ViewportArrayv _ViewportArrayv;

		private Delegates.ViewportIndexedf _ViewportIndexedf;

		private Delegates.ViewportIndexedfv _ViewportIndexedfv;

		private Delegates.WaitSync _WaitSync;

		public GL(IGLPlatformContext platformContext)
		{
			this.platformContext = platformContext ?? throw new ArgumentNullException(nameof(platformContext));

			if (this.platformContext.VersionMajor > 1 || (this.platformContext.VersionMajor == 1 && this.platformContext.VersionMinor >= 0))
			{
				this._CullFace = (Delegates.CullFace)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCullFace"), typeof(Delegates.CullFace));
				this._FrontFace = (Delegates.FrontFace)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFrontFace"), typeof(Delegates.FrontFace));
				this._Hint = (Delegates.Hint)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glHint"), typeof(Delegates.Hint));
				this._LineWidth = (Delegates.LineWidth)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glLineWidth"), typeof(Delegates.LineWidth));
				this._PointSize = (Delegates.PointSize)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPointSize"), typeof(Delegates.PointSize));
				this._PolygonMode = (Delegates.PolygonMode)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPolygonMode"), typeof(Delegates.PolygonMode));
				this._Scissor = (Delegates.Scissor)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glScissor"), typeof(Delegates.Scissor));
				this._TexParameterf = (Delegates.TexParameterf)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexParameterf"), typeof(Delegates.TexParameterf));
				this._TexParameterfv = (Delegates.TexParameterfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexParameterfv"), typeof(Delegates.TexParameterfv));
				this._TexParameteri = (Delegates.TexParameteri)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexParameteri"), typeof(Delegates.TexParameteri));
				this._TexParameteriv = (Delegates.TexParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexParameteriv"), typeof(Delegates.TexParameteriv));
				this._TexImage1D = (Delegates.TexImage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexImage1D"), typeof(Delegates.TexImage1D));
				this._TexImage2D = (Delegates.TexImage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexImage2D"), typeof(Delegates.TexImage2D));
				this._DrawBuffer = (Delegates.DrawBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawBuffer"), typeof(Delegates.DrawBuffer));
				this._Clear = (Delegates.Clear)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClear"), typeof(Delegates.Clear));
				this._ClearColor = (Delegates.ClearColor)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearColor"), typeof(Delegates.ClearColor));
				this._ClearStencil = (Delegates.ClearStencil)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearStencil"), typeof(Delegates.ClearStencil));
				this._ClearDepth = (Delegates.ClearDepth)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearDepth"), typeof(Delegates.ClearDepth));
				this._StencilMask = (Delegates.StencilMask)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glStencilMask"), typeof(Delegates.StencilMask));
				this._ColorMask = (Delegates.ColorMask)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glColorMask"), typeof(Delegates.ColorMask));
				this._DepthMask = (Delegates.DepthMask)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDepthMask"), typeof(Delegates.DepthMask));
				this._Disable = (Delegates.Disable)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDisable"), typeof(Delegates.Disable));
				this._Enable = (Delegates.Enable)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glEnable"), typeof(Delegates.Enable));
				this._Finish = (Delegates.Finish)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFinish"), typeof(Delegates.Finish));
				this._Flush = (Delegates.Flush)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFlush"), typeof(Delegates.Flush));
				this._BlendFunc = (Delegates.BlendFunc)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlendFunc"), typeof(Delegates.BlendFunc));
				this._LogicOp = (Delegates.LogicOp)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glLogicOp"), typeof(Delegates.LogicOp));
				this._StencilFunc = (Delegates.StencilFunc)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glStencilFunc"), typeof(Delegates.StencilFunc));
				this._StencilOp = (Delegates.StencilOp)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glStencilOp"), typeof(Delegates.StencilOp));
				this._DepthFunc = (Delegates.DepthFunc)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDepthFunc"), typeof(Delegates.DepthFunc));
				this._PixelStoref = (Delegates.PixelStoref)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPixelStoref"), typeof(Delegates.PixelStoref));
				this._PixelStorei = (Delegates.PixelStorei)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPixelStorei"), typeof(Delegates.PixelStorei));
				this._ReadBuffer = (Delegates.ReadBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glReadBuffer"), typeof(Delegates.ReadBuffer));
				this._ReadPixels = (Delegates.ReadPixels)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glReadPixels"), typeof(Delegates.ReadPixels));
				this._GetBooleanv = (Delegates.GetBooleanv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetBooleanv"), typeof(Delegates.GetBooleanv));
				this._GetDoublev = (Delegates.GetDoublev)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetDoublev"), typeof(Delegates.GetDoublev));
				this._GetError = (Delegates.GetError)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetError"), typeof(Delegates.GetError));
				this._GetFloatv = (Delegates.GetFloatv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetFloatv"), typeof(Delegates.GetFloatv));
				this._GetIntegerv = (Delegates.GetIntegerv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetIntegerv"), typeof(Delegates.GetIntegerv));
				this._GetString = (Delegates.GetString)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetString"), typeof(Delegates.GetString));
				this._GetTexImage = (Delegates.GetTexImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTexImage"), typeof(Delegates.GetTexImage));
				this._GetTexParameterfv = (Delegates.GetTexParameterfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTexParameterfv"), typeof(Delegates.GetTexParameterfv));
				this._GetTexParameteriv = (Delegates.GetTexParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTexParameteriv"), typeof(Delegates.GetTexParameteriv));
				this._GetTexLevelParameterfv = (Delegates.GetTexLevelParameterfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTexLevelParameterfv"), typeof(Delegates.GetTexLevelParameterfv));
				this._GetTexLevelParameteriv = (Delegates.GetTexLevelParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTexLevelParameteriv"), typeof(Delegates.GetTexLevelParameteriv));
				this._IsEnabled = (Delegates.IsEnabled)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsEnabled"), typeof(Delegates.IsEnabled));
				this._DepthRange = (Delegates.DepthRange)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDepthRange"), typeof(Delegates.DepthRange));
				this._Viewport = (Delegates.Viewport)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glViewport"), typeof(Delegates.Viewport));
			}

			if (this.platformContext.VersionMajor > 1 || (this.platformContext.VersionMajor == 1 && this.platformContext.VersionMinor >= 1))
			{
				this._DrawArrays = (Delegates.DrawArrays)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawArrays"), typeof(Delegates.DrawArrays));
				this._DrawElements = (Delegates.DrawElements)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawElements"), typeof(Delegates.DrawElements));
				this._GetPointerv = (Delegates.GetPointerv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetPointerv"), typeof(Delegates.GetPointerv));
				this._PolygonOffset = (Delegates.PolygonOffset)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPolygonOffset"), typeof(Delegates.PolygonOffset));
				this._CopyTexImage1D = (Delegates.CopyTexImage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyTexImage1D"), typeof(Delegates.CopyTexImage1D));
				this._CopyTexImage2D = (Delegates.CopyTexImage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyTexImage2D"), typeof(Delegates.CopyTexImage2D));
				this._CopyTexSubImage1D = (Delegates.CopyTexSubImage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyTexSubImage1D"), typeof(Delegates.CopyTexSubImage1D));
				this._CopyTexSubImage2D = (Delegates.CopyTexSubImage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyTexSubImage2D"), typeof(Delegates.CopyTexSubImage2D));
				this._TexSubImage1D = (Delegates.TexSubImage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexSubImage1D"), typeof(Delegates.TexSubImage1D));
				this._TexSubImage2D = (Delegates.TexSubImage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexSubImage2D"), typeof(Delegates.TexSubImage2D));
				this._BindTexture = (Delegates.BindTexture)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindTexture"), typeof(Delegates.BindTexture));
				this._DeleteTextures = (Delegates.DeleteTextures)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteTextures"), typeof(Delegates.DeleteTextures));
				this._GenTextures = (Delegates.GenTextures)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenTextures"), typeof(Delegates.GenTextures));
				this._IsTexture = (Delegates.IsTexture)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsTexture"), typeof(Delegates.IsTexture));
			}

			if (this.platformContext.VersionMajor > 1 || (this.platformContext.VersionMajor == 1 && this.platformContext.VersionMinor >= 2))
			{
				this._DrawRangeElements = (Delegates.DrawRangeElements)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawRangeElements"), typeof(Delegates.DrawRangeElements));
				this._TexImage3D = (Delegates.TexImage3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexImage3D"), typeof(Delegates.TexImage3D));
				this._TexSubImage3D = (Delegates.TexSubImage3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexSubImage3D"), typeof(Delegates.TexSubImage3D));
				this._CopyTexSubImage3D = (Delegates.CopyTexSubImage3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyTexSubImage3D"), typeof(Delegates.CopyTexSubImage3D));
			}

			if (this.platformContext.VersionMajor > 1 || (this.platformContext.VersionMajor == 1 && this.platformContext.VersionMinor >= 3))
			{
				this._ActiveTexture = (Delegates.ActiveTexture)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glActiveTexture"), typeof(Delegates.ActiveTexture));
				this._SampleCoverage = (Delegates.SampleCoverage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glSampleCoverage"), typeof(Delegates.SampleCoverage));
				this._CompressedTexImage3D = (Delegates.CompressedTexImage3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCompressedTexImage3D"), typeof(Delegates.CompressedTexImage3D));
				this._CompressedTexImage2D = (Delegates.CompressedTexImage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCompressedTexImage2D"), typeof(Delegates.CompressedTexImage2D));
				this._CompressedTexImage1D = (Delegates.CompressedTexImage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCompressedTexImage1D"), typeof(Delegates.CompressedTexImage1D));
				this._CompressedTexSubImage3D = (Delegates.CompressedTexSubImage3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCompressedTexSubImage3D"), typeof(Delegates.CompressedTexSubImage3D));
				this._CompressedTexSubImage2D = (Delegates.CompressedTexSubImage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCompressedTexSubImage2D"), typeof(Delegates.CompressedTexSubImage2D));
				this._CompressedTexSubImage1D = (Delegates.CompressedTexSubImage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCompressedTexSubImage1D"), typeof(Delegates.CompressedTexSubImage1D));
				this._GetCompressedTexImage = (Delegates.GetCompressedTexImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetCompressedTexImage"), typeof(Delegates.GetCompressedTexImage));
			}

			if (this.platformContext.VersionMajor > 1 || (this.platformContext.VersionMajor == 1 && this.platformContext.VersionMinor >= 4))
			{
				this._BlendFuncSeparate = (Delegates.BlendFuncSeparate)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlendFuncSeparate"), typeof(Delegates.BlendFuncSeparate));
				this._MultiDrawArrays = (Delegates.MultiDrawArrays)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMultiDrawArrays"), typeof(Delegates.MultiDrawArrays));
				this._MultiDrawElements = (Delegates.MultiDrawElements)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMultiDrawElements"), typeof(Delegates.MultiDrawElements));
				this._PointParameterf = (Delegates.PointParameterf)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPointParameterf"), typeof(Delegates.PointParameterf));
				this._PointParameterfv = (Delegates.PointParameterfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPointParameterfv"), typeof(Delegates.PointParameterfv));
				this._PointParameteri = (Delegates.PointParameteri)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPointParameteri"), typeof(Delegates.PointParameteri));
				this._PointParameteriv = (Delegates.PointParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPointParameteriv"), typeof(Delegates.PointParameteriv));
				this._BlendColor = (Delegates.BlendColor)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlendColor"), typeof(Delegates.BlendColor));
				this._BlendEquation = (Delegates.BlendEquation)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlendEquation"), typeof(Delegates.BlendEquation));
			}

			if (this.platformContext.VersionMajor > 1 || (this.platformContext.VersionMajor == 1 && this.platformContext.VersionMinor >= 5))
			{
				this._GenQueries = (Delegates.GenQueries)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenQueries"), typeof(Delegates.GenQueries));
				this._DeleteQueries = (Delegates.DeleteQueries)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteQueries"), typeof(Delegates.DeleteQueries));
				this._IsQuery = (Delegates.IsQuery)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsQuery"), typeof(Delegates.IsQuery));
				this._BeginQuery = (Delegates.BeginQuery)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBeginQuery"), typeof(Delegates.BeginQuery));
				this._EndQuery = (Delegates.EndQuery)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glEndQuery"), typeof(Delegates.EndQuery));
				this._GetQueryiv = (Delegates.GetQueryiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetQueryiv"), typeof(Delegates.GetQueryiv));
				this._GetQueryObjectiv = (Delegates.GetQueryObjectiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetQueryObjectiv"), typeof(Delegates.GetQueryObjectiv));
				this._GetQueryObjectuiv = (Delegates.GetQueryObjectuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetQueryObjectuiv"), typeof(Delegates.GetQueryObjectuiv));
				this._BindBuffer = (Delegates.BindBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindBuffer"), typeof(Delegates.BindBuffer));
				this._DeleteBuffers = (Delegates.DeleteBuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteBuffers"), typeof(Delegates.DeleteBuffers));
				this._GenBuffers = (Delegates.GenBuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenBuffers"), typeof(Delegates.GenBuffers));
				this._IsBuffer = (Delegates.IsBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsBuffer"), typeof(Delegates.IsBuffer));
				this._BufferData = (Delegates.BufferData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBufferData"), typeof(Delegates.BufferData));
				this._BufferSubData = (Delegates.BufferSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBufferSubData"), typeof(Delegates.BufferSubData));
				this._GetBufferSubData = (Delegates.GetBufferSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetBufferSubData"), typeof(Delegates.GetBufferSubData));
				this._MapBuffer = (Delegates.MapBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMapBuffer"), typeof(Delegates.MapBuffer));
				this._UnmapBuffer = (Delegates.UnmapBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUnmapBuffer"), typeof(Delegates.UnmapBuffer));
				this._GetBufferParameteriv = (Delegates.GetBufferParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetBufferParameteriv"), typeof(Delegates.GetBufferParameteriv));
				this._GetBufferPointerv = (Delegates.GetBufferPointerv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetBufferPointerv"), typeof(Delegates.GetBufferPointerv));
			}

			if (this.platformContext.VersionMajor > 2 || (this.platformContext.VersionMajor == 2 && this.platformContext.VersionMinor >= 0))
			{
				this._BlendEquationSeparate = (Delegates.BlendEquationSeparate)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlendEquationSeparate"), typeof(Delegates.BlendEquationSeparate));
				this._DrawBuffers = (Delegates.DrawBuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawBuffers"), typeof(Delegates.DrawBuffers));
				this._StencilOpSeparate = (Delegates.StencilOpSeparate)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glStencilOpSeparate"), typeof(Delegates.StencilOpSeparate));
				this._StencilFuncSeparate = (Delegates.StencilFuncSeparate)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glStencilFuncSeparate"), typeof(Delegates.StencilFuncSeparate));
				this._StencilMaskSeparate = (Delegates.StencilMaskSeparate)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glStencilMaskSeparate"), typeof(Delegates.StencilMaskSeparate));
				this._AttachShader = (Delegates.AttachShader)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glAttachShader"), typeof(Delegates.AttachShader));
				this._BindAttribLocation = (Delegates.BindAttribLocation)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindAttribLocation"), typeof(Delegates.BindAttribLocation));
				this._CompileShader = (Delegates.CompileShader)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCompileShader"), typeof(Delegates.CompileShader));
				this._CreateProgram = (Delegates.CreateProgram)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateProgram"), typeof(Delegates.CreateProgram));
				this._CreateShader = (Delegates.CreateShader)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateShader"), typeof(Delegates.CreateShader));
				this._DeleteProgram = (Delegates.DeleteProgram)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteProgram"), typeof(Delegates.DeleteProgram));
				this._DeleteShader = (Delegates.DeleteShader)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteShader"), typeof(Delegates.DeleteShader));
				this._DetachShader = (Delegates.DetachShader)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDetachShader"), typeof(Delegates.DetachShader));
				this._DisableVertexAttribArray = (Delegates.DisableVertexAttribArray)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDisableVertexAttribArray"), typeof(Delegates.DisableVertexAttribArray));
				this._EnableVertexAttribArray = (Delegates.EnableVertexAttribArray)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glEnableVertexAttribArray"), typeof(Delegates.EnableVertexAttribArray));
				this._GetActiveAttrib = (Delegates.GetActiveAttrib)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetActiveAttrib"), typeof(Delegates.GetActiveAttrib));
				this._GetActiveUniform = (Delegates.GetActiveUniform)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetActiveUniform"), typeof(Delegates.GetActiveUniform));
				this._GetAttachedShaders = (Delegates.GetAttachedShaders)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetAttachedShaders"), typeof(Delegates.GetAttachedShaders));
				this._GetAttribLocation = (Delegates.GetAttribLocation)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetAttribLocation"), typeof(Delegates.GetAttribLocation));
				this._GetProgramiv = (Delegates.GetProgramiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramiv"), typeof(Delegates.GetProgramiv));
				this._GetProgramInfoLog = (Delegates.GetProgramInfoLog)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramInfoLog"), typeof(Delegates.GetProgramInfoLog));
				this._GetShaderiv = (Delegates.GetShaderiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetShaderiv"), typeof(Delegates.GetShaderiv));
				this._GetShaderInfoLog = (Delegates.GetShaderInfoLog)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetShaderInfoLog"), typeof(Delegates.GetShaderInfoLog));
				this._GetShaderSource = (Delegates.GetShaderSource)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetShaderSource"), typeof(Delegates.GetShaderSource));
				this._GetUniformLocation = (Delegates.GetUniformLocation)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetUniformLocation"), typeof(Delegates.GetUniformLocation));
				this._GetUniformfv = (Delegates.GetUniformfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetUniformfv"), typeof(Delegates.GetUniformfv));
				this._GetUniformiv = (Delegates.GetUniformiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetUniformiv"), typeof(Delegates.GetUniformiv));
				this._GetVertexAttribdv = (Delegates.GetVertexAttribdv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetVertexAttribdv"), typeof(Delegates.GetVertexAttribdv));
				this._GetVertexAttribfv = (Delegates.GetVertexAttribfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetVertexAttribfv"), typeof(Delegates.GetVertexAttribfv));
				this._GetVertexAttribiv = (Delegates.GetVertexAttribiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetVertexAttribiv"), typeof(Delegates.GetVertexAttribiv));
				this._GetVertexAttribPointerv = (Delegates.GetVertexAttribPointerv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetVertexAttribPointerv"), typeof(Delegates.GetVertexAttribPointerv));
				this._IsProgram = (Delegates.IsProgram)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsProgram"), typeof(Delegates.IsProgram));
				this._IsShader = (Delegates.IsShader)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsShader"), typeof(Delegates.IsShader));
				this._LinkProgram = (Delegates.LinkProgram)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glLinkProgram"), typeof(Delegates.LinkProgram));
				this._ShaderSource = (Delegates.ShaderSource)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glShaderSource"), typeof(Delegates.ShaderSource));
				this._UseProgram = (Delegates.UseProgram)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUseProgram"), typeof(Delegates.UseProgram));
				this._Uniform1f = (Delegates.Uniform1f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform1f"), typeof(Delegates.Uniform1f));
				this._Uniform2f = (Delegates.Uniform2f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform2f"), typeof(Delegates.Uniform2f));
				this._Uniform3f = (Delegates.Uniform3f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform3f"), typeof(Delegates.Uniform3f));
				this._Uniform4f = (Delegates.Uniform4f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform4f"), typeof(Delegates.Uniform4f));
				this._Uniform1i = (Delegates.Uniform1i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform1i"), typeof(Delegates.Uniform1i));
				this._Uniform2i = (Delegates.Uniform2i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform2i"), typeof(Delegates.Uniform2i));
				this._Uniform3i = (Delegates.Uniform3i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform3i"), typeof(Delegates.Uniform3i));
				this._Uniform4i = (Delegates.Uniform4i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform4i"), typeof(Delegates.Uniform4i));
				this._Uniform1fv = (Delegates.Uniform1fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform1fv"), typeof(Delegates.Uniform1fv));
				this._Uniform2fv = (Delegates.Uniform2fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform2fv"), typeof(Delegates.Uniform2fv));
				this._Uniform3fv = (Delegates.Uniform3fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform3fv"), typeof(Delegates.Uniform3fv));
				this._Uniform4fv = (Delegates.Uniform4fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform4fv"), typeof(Delegates.Uniform4fv));
				this._Uniform1iv = (Delegates.Uniform1iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform1iv"), typeof(Delegates.Uniform1iv));
				this._Uniform2iv = (Delegates.Uniform2iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform2iv"), typeof(Delegates.Uniform2iv));
				this._Uniform3iv = (Delegates.Uniform3iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform3iv"), typeof(Delegates.Uniform3iv));
				this._Uniform4iv = (Delegates.Uniform4iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform4iv"), typeof(Delegates.Uniform4iv));
				this._UniformMatrix2fv = (Delegates.UniformMatrix2fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix2fv"), typeof(Delegates.UniformMatrix2fv));
				this._UniformMatrix3fv = (Delegates.UniformMatrix3fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix3fv"), typeof(Delegates.UniformMatrix3fv));
				this._UniformMatrix4fv = (Delegates.UniformMatrix4fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix4fv"), typeof(Delegates.UniformMatrix4fv));
				this._ValidateProgram = (Delegates.ValidateProgram)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glValidateProgram"), typeof(Delegates.ValidateProgram));
				this._VertexAttrib1d = (Delegates.VertexAttrib1d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib1d"), typeof(Delegates.VertexAttrib1d));
				this._VertexAttrib1dv = (Delegates.VertexAttrib1dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib1dv"), typeof(Delegates.VertexAttrib1dv));
				this._VertexAttrib1f = (Delegates.VertexAttrib1f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib1f"), typeof(Delegates.VertexAttrib1f));
				this._VertexAttrib1fv = (Delegates.VertexAttrib1fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib1fv"), typeof(Delegates.VertexAttrib1fv));
				this._VertexAttrib1s = (Delegates.VertexAttrib1s)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib1s"), typeof(Delegates.VertexAttrib1s));
				this._VertexAttrib1sv = (Delegates.VertexAttrib1sv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib1sv"), typeof(Delegates.VertexAttrib1sv));
				this._VertexAttrib2d = (Delegates.VertexAttrib2d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib2d"), typeof(Delegates.VertexAttrib2d));
				this._VertexAttrib2dv = (Delegates.VertexAttrib2dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib2dv"), typeof(Delegates.VertexAttrib2dv));
				this._VertexAttrib2f = (Delegates.VertexAttrib2f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib2f"), typeof(Delegates.VertexAttrib2f));
				this._VertexAttrib2fv = (Delegates.VertexAttrib2fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib2fv"), typeof(Delegates.VertexAttrib2fv));
				this._VertexAttrib2s = (Delegates.VertexAttrib2s)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib2s"), typeof(Delegates.VertexAttrib2s));
				this._VertexAttrib2sv = (Delegates.VertexAttrib2sv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib2sv"), typeof(Delegates.VertexAttrib2sv));
				this._VertexAttrib3d = (Delegates.VertexAttrib3d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib3d"), typeof(Delegates.VertexAttrib3d));
				this._VertexAttrib3dv = (Delegates.VertexAttrib3dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib3dv"), typeof(Delegates.VertexAttrib3dv));
				this._VertexAttrib3f = (Delegates.VertexAttrib3f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib3f"), typeof(Delegates.VertexAttrib3f));
				this._VertexAttrib3fv = (Delegates.VertexAttrib3fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib3fv"), typeof(Delegates.VertexAttrib3fv));
				this._VertexAttrib3s = (Delegates.VertexAttrib3s)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib3s"), typeof(Delegates.VertexAttrib3s));
				this._VertexAttrib3sv = (Delegates.VertexAttrib3sv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib3sv"), typeof(Delegates.VertexAttrib3sv));
				this._VertexAttrib4Nbv = (Delegates.VertexAttrib4Nbv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4Nbv"), typeof(Delegates.VertexAttrib4Nbv));
				this._VertexAttrib4Niv = (Delegates.VertexAttrib4Niv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4Niv"), typeof(Delegates.VertexAttrib4Niv));
				this._VertexAttrib4Nsv = (Delegates.VertexAttrib4Nsv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4Nsv"), typeof(Delegates.VertexAttrib4Nsv));
				this._VertexAttrib4Nub = (Delegates.VertexAttrib4Nub)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4Nub"), typeof(Delegates.VertexAttrib4Nub));
				this._VertexAttrib4Nubv = (Delegates.VertexAttrib4Nubv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4Nubv"), typeof(Delegates.VertexAttrib4Nubv));
				this._VertexAttrib4Nuiv = (Delegates.VertexAttrib4Nuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4Nuiv"), typeof(Delegates.VertexAttrib4Nuiv));
				this._VertexAttrib4Nusv = (Delegates.VertexAttrib4Nusv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4Nusv"), typeof(Delegates.VertexAttrib4Nusv));
				this._VertexAttrib4bv = (Delegates.VertexAttrib4bv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4bv"), typeof(Delegates.VertexAttrib4bv));
				this._VertexAttrib4d = (Delegates.VertexAttrib4d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4d"), typeof(Delegates.VertexAttrib4d));
				this._VertexAttrib4dv = (Delegates.VertexAttrib4dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4dv"), typeof(Delegates.VertexAttrib4dv));
				this._VertexAttrib4f = (Delegates.VertexAttrib4f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4f"), typeof(Delegates.VertexAttrib4f));
				this._VertexAttrib4fv = (Delegates.VertexAttrib4fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4fv"), typeof(Delegates.VertexAttrib4fv));
				this._VertexAttrib4iv = (Delegates.VertexAttrib4iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4iv"), typeof(Delegates.VertexAttrib4iv));
				this._VertexAttrib4s = (Delegates.VertexAttrib4s)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4s"), typeof(Delegates.VertexAttrib4s));
				this._VertexAttrib4sv = (Delegates.VertexAttrib4sv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4sv"), typeof(Delegates.VertexAttrib4sv));
				this._VertexAttrib4ubv = (Delegates.VertexAttrib4ubv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4ubv"), typeof(Delegates.VertexAttrib4ubv));
				this._VertexAttrib4uiv = (Delegates.VertexAttrib4uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4uiv"), typeof(Delegates.VertexAttrib4uiv));
				this._VertexAttrib4usv = (Delegates.VertexAttrib4usv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttrib4usv"), typeof(Delegates.VertexAttrib4usv));
				this._VertexAttribPointer = (Delegates.VertexAttribPointer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribPointer"), typeof(Delegates.VertexAttribPointer));
			}

			if (this.platformContext.VersionMajor > 2 || (this.platformContext.VersionMajor == 2 && this.platformContext.VersionMinor >= 1))
			{
				this._UniformMatrix2x3fv = (Delegates.UniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix2x3fv"), typeof(Delegates.UniformMatrix2x3fv));
				this._UniformMatrix3x2fv = (Delegates.UniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix3x2fv"), typeof(Delegates.UniformMatrix3x2fv));
				this._UniformMatrix2x4fv = (Delegates.UniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix2x4fv"), typeof(Delegates.UniformMatrix2x4fv));
				this._UniformMatrix4x2fv = (Delegates.UniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix4x2fv"), typeof(Delegates.UniformMatrix4x2fv));
				this._UniformMatrix3x4fv = (Delegates.UniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix3x4fv"), typeof(Delegates.UniformMatrix3x4fv));
				this._UniformMatrix4x3fv = (Delegates.UniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix4x3fv"), typeof(Delegates.UniformMatrix4x3fv));
			}

			if (this.platformContext.VersionMajor > 3 || (this.platformContext.VersionMajor == 3 && this.platformContext.VersionMinor >= 0))
			{
				this._ColorMaski = (Delegates.ColorMaski)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glColorMaski"), typeof(Delegates.ColorMaski));
				this._GetBooleani_v = (Delegates.GetBooleani_v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetBooleani_v"), typeof(Delegates.GetBooleani_v));
				this._GetIntegeri_v = (Delegates.GetIntegeri_v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetIntegeri_v"), typeof(Delegates.GetIntegeri_v));
				this._Enablei = (Delegates.Enablei)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glEnablei"), typeof(Delegates.Enablei));
				this._Disablei = (Delegates.Disablei)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDisablei"), typeof(Delegates.Disablei));
				this._IsEnabledi = (Delegates.IsEnabledi)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsEnabledi"), typeof(Delegates.IsEnabledi));
				this._BeginTransformFeedback = (Delegates.BeginTransformFeedback)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBeginTransformFeedback"), typeof(Delegates.BeginTransformFeedback));
				this._EndTransformFeedback = (Delegates.EndTransformFeedback)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glEndTransformFeedback"), typeof(Delegates.EndTransformFeedback));
				this._BindBufferRange = (Delegates.BindBufferRange)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindBufferRange"), typeof(Delegates.BindBufferRange));
				this._BindBufferBase = (Delegates.BindBufferBase)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindBufferBase"), typeof(Delegates.BindBufferBase));
				this._TransformFeedbackVaryings = (Delegates.TransformFeedbackVaryings)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTransformFeedbackVaryings"), typeof(Delegates.TransformFeedbackVaryings));
				this._GetTransformFeedbackVarying = (Delegates.GetTransformFeedbackVarying)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTransformFeedbackVarying"), typeof(Delegates.GetTransformFeedbackVarying));
				this._ClampColor = (Delegates.ClampColor)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClampColor"), typeof(Delegates.ClampColor));
				this._BeginConditionalRender = (Delegates.BeginConditionalRender)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBeginConditionalRender"), typeof(Delegates.BeginConditionalRender));
				this._EndConditionalRender = (Delegates.EndConditionalRender)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glEndConditionalRender"), typeof(Delegates.EndConditionalRender));
				this._VertexAttribIPointer = (Delegates.VertexAttribIPointer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribIPointer"), typeof(Delegates.VertexAttribIPointer));
				this._GetVertexAttribIiv = (Delegates.GetVertexAttribIiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetVertexAttribIiv"), typeof(Delegates.GetVertexAttribIiv));
				this._GetVertexAttribIuiv = (Delegates.GetVertexAttribIuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetVertexAttribIuiv"), typeof(Delegates.GetVertexAttribIuiv));
				this._VertexAttribI1i = (Delegates.VertexAttribI1i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI1i"), typeof(Delegates.VertexAttribI1i));
				this._VertexAttribI2i = (Delegates.VertexAttribI2i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI2i"), typeof(Delegates.VertexAttribI2i));
				this._VertexAttribI3i = (Delegates.VertexAttribI3i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI3i"), typeof(Delegates.VertexAttribI3i));
				this._VertexAttribI4i = (Delegates.VertexAttribI4i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI4i"), typeof(Delegates.VertexAttribI4i));
				this._VertexAttribI1ui = (Delegates.VertexAttribI1ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI1ui"), typeof(Delegates.VertexAttribI1ui));
				this._VertexAttribI2ui = (Delegates.VertexAttribI2ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI2ui"), typeof(Delegates.VertexAttribI2ui));
				this._VertexAttribI3ui = (Delegates.VertexAttribI3ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI3ui"), typeof(Delegates.VertexAttribI3ui));
				this._VertexAttribI4ui = (Delegates.VertexAttribI4ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI4ui"), typeof(Delegates.VertexAttribI4ui));
				this._VertexAttribI1iv = (Delegates.VertexAttribI1iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI1iv"), typeof(Delegates.VertexAttribI1iv));
				this._VertexAttribI2iv = (Delegates.VertexAttribI2iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI2iv"), typeof(Delegates.VertexAttribI2iv));
				this._VertexAttribI3iv = (Delegates.VertexAttribI3iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI3iv"), typeof(Delegates.VertexAttribI3iv));
				this._VertexAttribI4iv = (Delegates.VertexAttribI4iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI4iv"), typeof(Delegates.VertexAttribI4iv));
				this._VertexAttribI1uiv = (Delegates.VertexAttribI1uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI1uiv"), typeof(Delegates.VertexAttribI1uiv));
				this._VertexAttribI2uiv = (Delegates.VertexAttribI2uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI2uiv"), typeof(Delegates.VertexAttribI2uiv));
				this._VertexAttribI3uiv = (Delegates.VertexAttribI3uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI3uiv"), typeof(Delegates.VertexAttribI3uiv));
				this._VertexAttribI4uiv = (Delegates.VertexAttribI4uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI4uiv"), typeof(Delegates.VertexAttribI4uiv));
				this._VertexAttribI4bv = (Delegates.VertexAttribI4bv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI4bv"), typeof(Delegates.VertexAttribI4bv));
				this._VertexAttribI4sv = (Delegates.VertexAttribI4sv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI4sv"), typeof(Delegates.VertexAttribI4sv));
				this._VertexAttribI4ubv = (Delegates.VertexAttribI4ubv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI4ubv"), typeof(Delegates.VertexAttribI4ubv));
				this._VertexAttribI4usv = (Delegates.VertexAttribI4usv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribI4usv"), typeof(Delegates.VertexAttribI4usv));
				this._GetUniformuiv = (Delegates.GetUniformuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetUniformuiv"), typeof(Delegates.GetUniformuiv));
				this._BindFragDataLocation = (Delegates.BindFragDataLocation)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindFragDataLocation"), typeof(Delegates.BindFragDataLocation));
				this._GetFragDataLocation = (Delegates.GetFragDataLocation)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetFragDataLocation"), typeof(Delegates.GetFragDataLocation));
				this._Uniform1ui = (Delegates.Uniform1ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform1ui"), typeof(Delegates.Uniform1ui));
				this._Uniform2ui = (Delegates.Uniform2ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform2ui"), typeof(Delegates.Uniform2ui));
				this._Uniform3ui = (Delegates.Uniform3ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform3ui"), typeof(Delegates.Uniform3ui));
				this._Uniform4ui = (Delegates.Uniform4ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform4ui"), typeof(Delegates.Uniform4ui));
				this._Uniform1uiv = (Delegates.Uniform1uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform1uiv"), typeof(Delegates.Uniform1uiv));
				this._Uniform2uiv = (Delegates.Uniform2uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform2uiv"), typeof(Delegates.Uniform2uiv));
				this._Uniform3uiv = (Delegates.Uniform3uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform3uiv"), typeof(Delegates.Uniform3uiv));
				this._Uniform4uiv = (Delegates.Uniform4uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform4uiv"), typeof(Delegates.Uniform4uiv));
				this._TexParameterIiv = (Delegates.TexParameterIiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexParameterIiv"), typeof(Delegates.TexParameterIiv));
				this._TexParameterIuiv = (Delegates.TexParameterIuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexParameterIuiv"), typeof(Delegates.TexParameterIuiv));
				this._GetTexParameterIiv = (Delegates.GetTexParameterIiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTexParameterIiv"), typeof(Delegates.GetTexParameterIiv));
				this._GetTexParameterIuiv = (Delegates.GetTexParameterIuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTexParameterIuiv"), typeof(Delegates.GetTexParameterIuiv));
				this._ClearBufferiv = (Delegates.ClearBufferiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearBufferiv"), typeof(Delegates.ClearBufferiv));
				this._ClearBufferuiv = (Delegates.ClearBufferuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearBufferuiv"), typeof(Delegates.ClearBufferuiv));
				this._ClearBufferfv = (Delegates.ClearBufferfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearBufferfv"), typeof(Delegates.ClearBufferfv));
				this._ClearBufferfi = (Delegates.ClearBufferfi)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearBufferfi"), typeof(Delegates.ClearBufferfi));
				this._GetStringi = (Delegates.GetStringi)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetStringi"), typeof(Delegates.GetStringi));
				this._IsRenderbuffer = (Delegates.IsRenderbuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsRenderbuffer"), typeof(Delegates.IsRenderbuffer));
				this._BindRenderbuffer = (Delegates.BindRenderbuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindRenderbuffer"), typeof(Delegates.BindRenderbuffer));
				this._DeleteRenderbuffers = (Delegates.DeleteRenderbuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteRenderbuffers"), typeof(Delegates.DeleteRenderbuffers));
				this._GenRenderbuffers = (Delegates.GenRenderbuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenRenderbuffers"), typeof(Delegates.GenRenderbuffers));
				this._RenderbufferStorage = (Delegates.RenderbufferStorage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glRenderbufferStorage"), typeof(Delegates.RenderbufferStorage));
				this._GetRenderbufferParameteriv = (Delegates.GetRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetRenderbufferParameteriv"), typeof(Delegates.GetRenderbufferParameteriv));
				this._IsFramebuffer = (Delegates.IsFramebuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsFramebuffer"), typeof(Delegates.IsFramebuffer));
				this._BindFramebuffer = (Delegates.BindFramebuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindFramebuffer"), typeof(Delegates.BindFramebuffer));
				this._DeleteFramebuffers = (Delegates.DeleteFramebuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteFramebuffers"), typeof(Delegates.DeleteFramebuffers));
				this._GenFramebuffers = (Delegates.GenFramebuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenFramebuffers"), typeof(Delegates.GenFramebuffers));
				this._CheckFramebufferStatus = (Delegates.CheckFramebufferStatus)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCheckFramebufferStatus"), typeof(Delegates.CheckFramebufferStatus));
				this._FramebufferTexture1D = (Delegates.FramebufferTexture1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFramebufferTexture1D"), typeof(Delegates.FramebufferTexture1D));
				this._FramebufferTexture2D = (Delegates.FramebufferTexture2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFramebufferTexture2D"), typeof(Delegates.FramebufferTexture2D));
				this._FramebufferTexture3D = (Delegates.FramebufferTexture3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFramebufferTexture3D"), typeof(Delegates.FramebufferTexture3D));
				this._FramebufferRenderbuffer = (Delegates.FramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFramebufferRenderbuffer"), typeof(Delegates.FramebufferRenderbuffer));
				this._GetFramebufferAttachmentParameteriv = (Delegates.GetFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetFramebufferAttachmentParameteriv"), typeof(Delegates.GetFramebufferAttachmentParameteriv));
				this._GenerateMipmap = (Delegates.GenerateMipmap)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenerateMipmap"), typeof(Delegates.GenerateMipmap));
				this._BlitFramebuffer = (Delegates.BlitFramebuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlitFramebuffer"), typeof(Delegates.BlitFramebuffer));
				this._RenderbufferStorageMultisample = (Delegates.RenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glRenderbufferStorageMultisample"), typeof(Delegates.RenderbufferStorageMultisample));
				this._FramebufferTextureLayer = (Delegates.FramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFramebufferTextureLayer"), typeof(Delegates.FramebufferTextureLayer));
				this._MapBufferRange = (Delegates.MapBufferRange)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMapBufferRange"), typeof(Delegates.MapBufferRange));
				this._FlushMappedBufferRange = (Delegates.FlushMappedBufferRange)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFlushMappedBufferRange"), typeof(Delegates.FlushMappedBufferRange));
				this._BindVertexArray = (Delegates.BindVertexArray)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindVertexArray"), typeof(Delegates.BindVertexArray));
				this._DeleteVertexArrays = (Delegates.DeleteVertexArrays)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteVertexArrays"), typeof(Delegates.DeleteVertexArrays));
				this._GenVertexArrays = (Delegates.GenVertexArrays)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenVertexArrays"), typeof(Delegates.GenVertexArrays));
				this._IsVertexArray = (Delegates.IsVertexArray)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsVertexArray"), typeof(Delegates.IsVertexArray));
			}

			if (this.platformContext.VersionMajor > 3 || (this.platformContext.VersionMajor == 3 && this.platformContext.VersionMinor >= 1))
			{
				this._DrawArraysInstanced = (Delegates.DrawArraysInstanced)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawArraysInstanced"), typeof(Delegates.DrawArraysInstanced));
				this._DrawElementsInstanced = (Delegates.DrawElementsInstanced)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawElementsInstanced"), typeof(Delegates.DrawElementsInstanced));
				this._TexBuffer = (Delegates.TexBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexBuffer"), typeof(Delegates.TexBuffer));
				this._PrimitiveRestartIndex = (Delegates.PrimitiveRestartIndex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPrimitiveRestartIndex"), typeof(Delegates.PrimitiveRestartIndex));
				this._CopyBufferSubData = (Delegates.CopyBufferSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyBufferSubData"), typeof(Delegates.CopyBufferSubData));
				this._GetUniformIndices = (Delegates.GetUniformIndices)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetUniformIndices"), typeof(Delegates.GetUniformIndices));
				this._GetActiveUniformsiv = (Delegates.GetActiveUniformsiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetActiveUniformsiv"), typeof(Delegates.GetActiveUniformsiv));
				this._GetActiveUniformName = (Delegates.GetActiveUniformName)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetActiveUniformName"), typeof(Delegates.GetActiveUniformName));
				this._GetUniformBlockIndex = (Delegates.GetUniformBlockIndex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetUniformBlockIndex"), typeof(Delegates.GetUniformBlockIndex));
				this._GetActiveUniformBlockiv = (Delegates.GetActiveUniformBlockiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetActiveUniformBlockiv"), typeof(Delegates.GetActiveUniformBlockiv));
				this._GetActiveUniformBlockName = (Delegates.GetActiveUniformBlockName)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetActiveUniformBlockName"), typeof(Delegates.GetActiveUniformBlockName));
				this._UniformBlockBinding = (Delegates.UniformBlockBinding)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformBlockBinding"), typeof(Delegates.UniformBlockBinding));
			}

			if (this.platformContext.VersionMajor > 3 || (this.platformContext.VersionMajor == 3 && this.platformContext.VersionMinor >= 2))
			{
				this._DrawElementsBaseVertex = (Delegates.DrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawElementsBaseVertex"), typeof(Delegates.DrawElementsBaseVertex));
				this._DrawRangeElementsBaseVertex = (Delegates.DrawRangeElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawRangeElementsBaseVertex"), typeof(Delegates.DrawRangeElementsBaseVertex));
				this._DrawElementsInstancedBaseVertex = (Delegates.DrawElementsInstancedBaseVertex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawElementsInstancedBaseVertex"), typeof(Delegates.DrawElementsInstancedBaseVertex));
				this._MultiDrawElementsBaseVertex = (Delegates.MultiDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMultiDrawElementsBaseVertex"), typeof(Delegates.MultiDrawElementsBaseVertex));
				this._ProvokingVertex = (Delegates.ProvokingVertex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProvokingVertex"), typeof(Delegates.ProvokingVertex));
				this._FenceSync = (Delegates.FenceSync)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFenceSync"), typeof(Delegates.FenceSync));
				this._IsSync = (Delegates.IsSync)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsSync"), typeof(Delegates.IsSync));
				this._DeleteSync = (Delegates.DeleteSync)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteSync"), typeof(Delegates.DeleteSync));
				this._ClientWaitSync = (Delegates.ClientWaitSync)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClientWaitSync"), typeof(Delegates.ClientWaitSync));
				this._WaitSync = (Delegates.WaitSync)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glWaitSync"), typeof(Delegates.WaitSync));
				this._GetInteger64v = (Delegates.GetInteger64v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetInteger64v"), typeof(Delegates.GetInteger64v));
				this._GetSynciv = (Delegates.GetSynciv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetSynciv"), typeof(Delegates.GetSynciv));
				this._GetInteger64i_v = (Delegates.GetInteger64i_v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetInteger64i_v"), typeof(Delegates.GetInteger64i_v));
				this._GetBufferParameteri64v = (Delegates.GetBufferParameteri64v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetBufferParameteri64v"), typeof(Delegates.GetBufferParameteri64v));
				this._FramebufferTexture = (Delegates.FramebufferTexture)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFramebufferTexture"), typeof(Delegates.FramebufferTexture));
				this._TexImage2DMultisample = (Delegates.TexImage2DMultisample)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexImage2DMultisample"), typeof(Delegates.TexImage2DMultisample));
				this._TexImage3DMultisample = (Delegates.TexImage3DMultisample)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexImage3DMultisample"), typeof(Delegates.TexImage3DMultisample));
				this._GetMultisamplefv = (Delegates.GetMultisamplefv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetMultisamplefv"), typeof(Delegates.GetMultisamplefv));
				this._SampleMaski = (Delegates.SampleMaski)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glSampleMaski"), typeof(Delegates.SampleMaski));
			}

			if (this.platformContext.VersionMajor > 3 || (this.platformContext.VersionMajor == 3 && this.platformContext.VersionMinor >= 3))
			{
				this._BindFragDataLocationIndexed = (Delegates.BindFragDataLocationIndexed)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindFragDataLocationIndexed"), typeof(Delegates.BindFragDataLocationIndexed));
				this._GetFragDataIndex = (Delegates.GetFragDataIndex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetFragDataIndex"), typeof(Delegates.GetFragDataIndex));
				this._GenSamplers = (Delegates.GenSamplers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenSamplers"), typeof(Delegates.GenSamplers));
				this._DeleteSamplers = (Delegates.DeleteSamplers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteSamplers"), typeof(Delegates.DeleteSamplers));
				this._IsSampler = (Delegates.IsSampler)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsSampler"), typeof(Delegates.IsSampler));
				this._BindSampler = (Delegates.BindSampler)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindSampler"), typeof(Delegates.BindSampler));
				this._SamplerParameteri = (Delegates.SamplerParameteri)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glSamplerParameteri"), typeof(Delegates.SamplerParameteri));
				this._SamplerParameteriv = (Delegates.SamplerParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glSamplerParameteriv"), typeof(Delegates.SamplerParameteriv));
				this._SamplerParameterf = (Delegates.SamplerParameterf)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glSamplerParameterf"), typeof(Delegates.SamplerParameterf));
				this._SamplerParameterfv = (Delegates.SamplerParameterfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glSamplerParameterfv"), typeof(Delegates.SamplerParameterfv));
				this._SamplerParameterIiv = (Delegates.SamplerParameterIiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glSamplerParameterIiv"), typeof(Delegates.SamplerParameterIiv));
				this._SamplerParameterIuiv = (Delegates.SamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glSamplerParameterIuiv"), typeof(Delegates.SamplerParameterIuiv));
				this._GetSamplerParameteriv = (Delegates.GetSamplerParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetSamplerParameteriv"), typeof(Delegates.GetSamplerParameteriv));
				this._GetSamplerParameterIiv = (Delegates.GetSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetSamplerParameterIiv"), typeof(Delegates.GetSamplerParameterIiv));
				this._GetSamplerParameterfv = (Delegates.GetSamplerParameterfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetSamplerParameterfv"), typeof(Delegates.GetSamplerParameterfv));
				this._GetSamplerParameterIuiv = (Delegates.GetSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetSamplerParameterIuiv"), typeof(Delegates.GetSamplerParameterIuiv));
				this._QueryCounter = (Delegates.QueryCounter)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glQueryCounter"), typeof(Delegates.QueryCounter));
				this._GetQueryObjecti64v = (Delegates.GetQueryObjecti64v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetQueryObjecti64v"), typeof(Delegates.GetQueryObjecti64v));
				this._GetQueryObjectui64v = (Delegates.GetQueryObjectui64v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetQueryObjectui64v"), typeof(Delegates.GetQueryObjectui64v));
				this._VertexAttribDivisor = (Delegates.VertexAttribDivisor)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribDivisor"), typeof(Delegates.VertexAttribDivisor));
				this._VertexAttribP1ui = (Delegates.VertexAttribP1ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribP1ui"), typeof(Delegates.VertexAttribP1ui));
				this._VertexAttribP1uiv = (Delegates.VertexAttribP1uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribP1uiv"), typeof(Delegates.VertexAttribP1uiv));
				this._VertexAttribP2ui = (Delegates.VertexAttribP2ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribP2ui"), typeof(Delegates.VertexAttribP2ui));
				this._VertexAttribP2uiv = (Delegates.VertexAttribP2uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribP2uiv"), typeof(Delegates.VertexAttribP2uiv));
				this._VertexAttribP3ui = (Delegates.VertexAttribP3ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribP3ui"), typeof(Delegates.VertexAttribP3ui));
				this._VertexAttribP3uiv = (Delegates.VertexAttribP3uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribP3uiv"), typeof(Delegates.VertexAttribP3uiv));
				this._VertexAttribP4ui = (Delegates.VertexAttribP4ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribP4ui"), typeof(Delegates.VertexAttribP4ui));
				this._VertexAttribP4uiv = (Delegates.VertexAttribP4uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribP4uiv"), typeof(Delegates.VertexAttribP4uiv));
			}

			if (this.platformContext.VersionMajor > 4 || (this.platformContext.VersionMajor == 4 && this.platformContext.VersionMinor >= 0))
			{
				this._MinSampleShading = (Delegates.MinSampleShading)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMinSampleShading"), typeof(Delegates.MinSampleShading));
				this._BlendEquationi = (Delegates.BlendEquationi)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlendEquationi"), typeof(Delegates.BlendEquationi));
				this._BlendEquationSeparatei = (Delegates.BlendEquationSeparatei)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlendEquationSeparatei"), typeof(Delegates.BlendEquationSeparatei));
				this._BlendFunci = (Delegates.BlendFunci)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlendFunci"), typeof(Delegates.BlendFunci));
				this._BlendFuncSeparatei = (Delegates.BlendFuncSeparatei)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlendFuncSeparatei"), typeof(Delegates.BlendFuncSeparatei));
				this._DrawArraysIndirect = (Delegates.DrawArraysIndirect)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawArraysIndirect"), typeof(Delegates.DrawArraysIndirect));
				this._DrawElementsIndirect = (Delegates.DrawElementsIndirect)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawElementsIndirect"), typeof(Delegates.DrawElementsIndirect));
				this._Uniform1d = (Delegates.Uniform1d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform1d"), typeof(Delegates.Uniform1d));
				this._Uniform2d = (Delegates.Uniform2d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform2d"), typeof(Delegates.Uniform2d));
				this._Uniform3d = (Delegates.Uniform3d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform3d"), typeof(Delegates.Uniform3d));
				this._Uniform4d = (Delegates.Uniform4d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform4d"), typeof(Delegates.Uniform4d));
				this._Uniform1dv = (Delegates.Uniform1dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform1dv"), typeof(Delegates.Uniform1dv));
				this._Uniform2dv = (Delegates.Uniform2dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform2dv"), typeof(Delegates.Uniform2dv));
				this._Uniform3dv = (Delegates.Uniform3dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform3dv"), typeof(Delegates.Uniform3dv));
				this._Uniform4dv = (Delegates.Uniform4dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniform4dv"), typeof(Delegates.Uniform4dv));
				this._UniformMatrix2dv = (Delegates.UniformMatrix2dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix2dv"), typeof(Delegates.UniformMatrix2dv));
				this._UniformMatrix3dv = (Delegates.UniformMatrix3dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix3dv"), typeof(Delegates.UniformMatrix3dv));
				this._UniformMatrix4dv = (Delegates.UniformMatrix4dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix4dv"), typeof(Delegates.UniformMatrix4dv));
				this._UniformMatrix2x3dv = (Delegates.UniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix2x3dv"), typeof(Delegates.UniformMatrix2x3dv));
				this._UniformMatrix2x4dv = (Delegates.UniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix2x4dv"), typeof(Delegates.UniformMatrix2x4dv));
				this._UniformMatrix3x2dv = (Delegates.UniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix3x2dv"), typeof(Delegates.UniformMatrix3x2dv));
				this._UniformMatrix3x4dv = (Delegates.UniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix3x4dv"), typeof(Delegates.UniformMatrix3x4dv));
				this._UniformMatrix4x2dv = (Delegates.UniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix4x2dv"), typeof(Delegates.UniformMatrix4x2dv));
				this._UniformMatrix4x3dv = (Delegates.UniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformMatrix4x3dv"), typeof(Delegates.UniformMatrix4x3dv));
				this._GetUniformdv = (Delegates.GetUniformdv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetUniformdv"), typeof(Delegates.GetUniformdv));
				this._GetSubroutineUniformLocation = (Delegates.GetSubroutineUniformLocation)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetSubroutineUniformLocation"), typeof(Delegates.GetSubroutineUniformLocation));
				this._GetSubroutineIndex = (Delegates.GetSubroutineIndex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetSubroutineIndex"), typeof(Delegates.GetSubroutineIndex));
				this._GetActiveSubroutineUniformiv = (Delegates.GetActiveSubroutineUniformiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetActiveSubroutineUniformiv"), typeof(Delegates.GetActiveSubroutineUniformiv));
				this._GetActiveSubroutineUniformName = (Delegates.GetActiveSubroutineUniformName)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetActiveSubroutineUniformName"), typeof(Delegates.GetActiveSubroutineUniformName));
				this._GetActiveSubroutineName = (Delegates.GetActiveSubroutineName)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetActiveSubroutineName"), typeof(Delegates.GetActiveSubroutineName));
				this._UniformSubroutinesuiv = (Delegates.UniformSubroutinesuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUniformSubroutinesuiv"), typeof(Delegates.UniformSubroutinesuiv));
				this._GetUniformSubroutineuiv = (Delegates.GetUniformSubroutineuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetUniformSubroutineuiv"), typeof(Delegates.GetUniformSubroutineuiv));
				this._GetProgramStageiv = (Delegates.GetProgramStageiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramStageiv"), typeof(Delegates.GetProgramStageiv));
				this._PatchParameteri = (Delegates.PatchParameteri)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPatchParameteri"), typeof(Delegates.PatchParameteri));
				this._PatchParameterfv = (Delegates.PatchParameterfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPatchParameterfv"), typeof(Delegates.PatchParameterfv));
				this._BindTransformFeedback = (Delegates.BindTransformFeedback)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindTransformFeedback"), typeof(Delegates.BindTransformFeedback));
				this._DeleteTransformFeedbacks = (Delegates.DeleteTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteTransformFeedbacks"), typeof(Delegates.DeleteTransformFeedbacks));
				this._GenTransformFeedbacks = (Delegates.GenTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenTransformFeedbacks"), typeof(Delegates.GenTransformFeedbacks));
				this._IsTransformFeedback = (Delegates.IsTransformFeedback)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsTransformFeedback"), typeof(Delegates.IsTransformFeedback));
				this._PauseTransformFeedback = (Delegates.PauseTransformFeedback)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPauseTransformFeedback"), typeof(Delegates.PauseTransformFeedback));
				this._ResumeTransformFeedback = (Delegates.ResumeTransformFeedback)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glResumeTransformFeedback"), typeof(Delegates.ResumeTransformFeedback));
				this._DrawTransformFeedback = (Delegates.DrawTransformFeedback)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawTransformFeedback"), typeof(Delegates.DrawTransformFeedback));
				this._DrawTransformFeedbackStream = (Delegates.DrawTransformFeedbackStream)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawTransformFeedbackStream"), typeof(Delegates.DrawTransformFeedbackStream));
				this._BeginQueryIndexed = (Delegates.BeginQueryIndexed)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBeginQueryIndexed"), typeof(Delegates.BeginQueryIndexed));
				this._EndQueryIndexed = (Delegates.EndQueryIndexed)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glEndQueryIndexed"), typeof(Delegates.EndQueryIndexed));
				this._GetQueryIndexediv = (Delegates.GetQueryIndexediv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetQueryIndexediv"), typeof(Delegates.GetQueryIndexediv));
			}

			if (this.platformContext.VersionMajor > 4 || (this.platformContext.VersionMajor == 4 && this.platformContext.VersionMinor >= 1))
			{
				this._ReleaseShaderCompiler = (Delegates.ReleaseShaderCompiler)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glReleaseShaderCompiler"), typeof(Delegates.ReleaseShaderCompiler));
				this._ShaderBinary = (Delegates.ShaderBinary)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glShaderBinary"), typeof(Delegates.ShaderBinary));
				this._GetShaderPrecisionFormat = (Delegates.GetShaderPrecisionFormat)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetShaderPrecisionFormat"), typeof(Delegates.GetShaderPrecisionFormat));
				this._DepthRangef = (Delegates.DepthRangef)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDepthRangef"), typeof(Delegates.DepthRangef));
				this._ClearDepthf = (Delegates.ClearDepthf)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearDepthf"), typeof(Delegates.ClearDepthf));
				this._GetProgramBinary = (Delegates.GetProgramBinary)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramBinary"), typeof(Delegates.GetProgramBinary));
				this._ProgramBinary = (Delegates.ProgramBinary)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramBinary"), typeof(Delegates.ProgramBinary));
				this._ProgramParameteri = (Delegates.ProgramParameteri)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramParameteri"), typeof(Delegates.ProgramParameteri));
				this._UseProgramStages = (Delegates.UseProgramStages)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUseProgramStages"), typeof(Delegates.UseProgramStages));
				this._ActiveShaderProgram = (Delegates.ActiveShaderProgram)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glActiveShaderProgram"), typeof(Delegates.ActiveShaderProgram));
				this._CreateShaderProgramv = (Delegates.CreateShaderProgramv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateShaderProgramv"), typeof(Delegates.CreateShaderProgramv));
				this._BindProgramPipeline = (Delegates.BindProgramPipeline)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindProgramPipeline"), typeof(Delegates.BindProgramPipeline));
				this._DeleteProgramPipelines = (Delegates.DeleteProgramPipelines)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDeleteProgramPipelines"), typeof(Delegates.DeleteProgramPipelines));
				this._GenProgramPipelines = (Delegates.GenProgramPipelines)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenProgramPipelines"), typeof(Delegates.GenProgramPipelines));
				this._IsProgramPipeline = (Delegates.IsProgramPipeline)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glIsProgramPipeline"), typeof(Delegates.IsProgramPipeline));
				this._GetProgramPipelineiv = (Delegates.GetProgramPipelineiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramPipelineiv"), typeof(Delegates.GetProgramPipelineiv));
				this._ProgramUniform1i = (Delegates.ProgramUniform1i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform1i"), typeof(Delegates.ProgramUniform1i));
				this._ProgramUniform1iv = (Delegates.ProgramUniform1iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform1iv"), typeof(Delegates.ProgramUniform1iv));
				this._ProgramUniform1f = (Delegates.ProgramUniform1f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform1f"), typeof(Delegates.ProgramUniform1f));
				this._ProgramUniform1fv = (Delegates.ProgramUniform1fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform1fv"), typeof(Delegates.ProgramUniform1fv));
				this._ProgramUniform1d = (Delegates.ProgramUniform1d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform1d"), typeof(Delegates.ProgramUniform1d));
				this._ProgramUniform1dv = (Delegates.ProgramUniform1dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform1dv"), typeof(Delegates.ProgramUniform1dv));
				this._ProgramUniform1ui = (Delegates.ProgramUniform1ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform1ui"), typeof(Delegates.ProgramUniform1ui));
				this._ProgramUniform1uiv = (Delegates.ProgramUniform1uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform1uiv"), typeof(Delegates.ProgramUniform1uiv));
				this._ProgramUniform2i = (Delegates.ProgramUniform2i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform2i"), typeof(Delegates.ProgramUniform2i));
				this._ProgramUniform2iv = (Delegates.ProgramUniform2iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform2iv"), typeof(Delegates.ProgramUniform2iv));
				this._ProgramUniform2f = (Delegates.ProgramUniform2f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform2f"), typeof(Delegates.ProgramUniform2f));
				this._ProgramUniform2fv = (Delegates.ProgramUniform2fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform2fv"), typeof(Delegates.ProgramUniform2fv));
				this._ProgramUniform2d = (Delegates.ProgramUniform2d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform2d"), typeof(Delegates.ProgramUniform2d));
				this._ProgramUniform2dv = (Delegates.ProgramUniform2dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform2dv"), typeof(Delegates.ProgramUniform2dv));
				this._ProgramUniform2ui = (Delegates.ProgramUniform2ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform2ui"), typeof(Delegates.ProgramUniform2ui));
				this._ProgramUniform2uiv = (Delegates.ProgramUniform2uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform2uiv"), typeof(Delegates.ProgramUniform2uiv));
				this._ProgramUniform3i = (Delegates.ProgramUniform3i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform3i"), typeof(Delegates.ProgramUniform3i));
				this._ProgramUniform3iv = (Delegates.ProgramUniform3iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform3iv"), typeof(Delegates.ProgramUniform3iv));
				this._ProgramUniform3f = (Delegates.ProgramUniform3f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform3f"), typeof(Delegates.ProgramUniform3f));
				this._ProgramUniform3fv = (Delegates.ProgramUniform3fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform3fv"), typeof(Delegates.ProgramUniform3fv));
				this._ProgramUniform3d = (Delegates.ProgramUniform3d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform3d"), typeof(Delegates.ProgramUniform3d));
				this._ProgramUniform3dv = (Delegates.ProgramUniform3dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform3dv"), typeof(Delegates.ProgramUniform3dv));
				this._ProgramUniform3ui = (Delegates.ProgramUniform3ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform3ui"), typeof(Delegates.ProgramUniform3ui));
				this._ProgramUniform3uiv = (Delegates.ProgramUniform3uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform3uiv"), typeof(Delegates.ProgramUniform3uiv));
				this._ProgramUniform4i = (Delegates.ProgramUniform4i)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform4i"), typeof(Delegates.ProgramUniform4i));
				this._ProgramUniform4iv = (Delegates.ProgramUniform4iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform4iv"), typeof(Delegates.ProgramUniform4iv));
				this._ProgramUniform4f = (Delegates.ProgramUniform4f)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform4f"), typeof(Delegates.ProgramUniform4f));
				this._ProgramUniform4fv = (Delegates.ProgramUniform4fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform4fv"), typeof(Delegates.ProgramUniform4fv));
				this._ProgramUniform4d = (Delegates.ProgramUniform4d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform4d"), typeof(Delegates.ProgramUniform4d));
				this._ProgramUniform4dv = (Delegates.ProgramUniform4dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform4dv"), typeof(Delegates.ProgramUniform4dv));
				this._ProgramUniform4ui = (Delegates.ProgramUniform4ui)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform4ui"), typeof(Delegates.ProgramUniform4ui));
				this._ProgramUniform4uiv = (Delegates.ProgramUniform4uiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniform4uiv"), typeof(Delegates.ProgramUniform4uiv));
				this._ProgramUniformMatrix2fv = (Delegates.ProgramUniformMatrix2fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix2fv"), typeof(Delegates.ProgramUniformMatrix2fv));
				this._ProgramUniformMatrix3fv = (Delegates.ProgramUniformMatrix3fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix3fv"), typeof(Delegates.ProgramUniformMatrix3fv));
				this._ProgramUniformMatrix4fv = (Delegates.ProgramUniformMatrix4fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix4fv"), typeof(Delegates.ProgramUniformMatrix4fv));
				this._ProgramUniformMatrix2dv = (Delegates.ProgramUniformMatrix2dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix2dv"), typeof(Delegates.ProgramUniformMatrix2dv));
				this._ProgramUniformMatrix3dv = (Delegates.ProgramUniformMatrix3dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix3dv"), typeof(Delegates.ProgramUniformMatrix3dv));
				this._ProgramUniformMatrix4dv = (Delegates.ProgramUniformMatrix4dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix4dv"), typeof(Delegates.ProgramUniformMatrix4dv));
				this._ProgramUniformMatrix2x3fv = (Delegates.ProgramUniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix2x3fv"), typeof(Delegates.ProgramUniformMatrix2x3fv));
				this._ProgramUniformMatrix3x2fv = (Delegates.ProgramUniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix3x2fv"), typeof(Delegates.ProgramUniformMatrix3x2fv));
				this._ProgramUniformMatrix2x4fv = (Delegates.ProgramUniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix2x4fv"), typeof(Delegates.ProgramUniformMatrix2x4fv));
				this._ProgramUniformMatrix4x2fv = (Delegates.ProgramUniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix4x2fv"), typeof(Delegates.ProgramUniformMatrix4x2fv));
				this._ProgramUniformMatrix3x4fv = (Delegates.ProgramUniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix3x4fv"), typeof(Delegates.ProgramUniformMatrix3x4fv));
				this._ProgramUniformMatrix4x3fv = (Delegates.ProgramUniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix4x3fv"), typeof(Delegates.ProgramUniformMatrix4x3fv));
				this._ProgramUniformMatrix2x3dv = (Delegates.ProgramUniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix2x3dv"), typeof(Delegates.ProgramUniformMatrix2x3dv));
				this._ProgramUniformMatrix3x2dv = (Delegates.ProgramUniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix3x2dv"), typeof(Delegates.ProgramUniformMatrix3x2dv));
				this._ProgramUniformMatrix2x4dv = (Delegates.ProgramUniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix2x4dv"), typeof(Delegates.ProgramUniformMatrix2x4dv));
				this._ProgramUniformMatrix4x2dv = (Delegates.ProgramUniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix4x2dv"), typeof(Delegates.ProgramUniformMatrix4x2dv));
				this._ProgramUniformMatrix3x4dv = (Delegates.ProgramUniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix3x4dv"), typeof(Delegates.ProgramUniformMatrix3x4dv));
				this._ProgramUniformMatrix4x3dv = (Delegates.ProgramUniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glProgramUniformMatrix4x3dv"), typeof(Delegates.ProgramUniformMatrix4x3dv));
				this._ValidateProgramPipeline = (Delegates.ValidateProgramPipeline)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glValidateProgramPipeline"), typeof(Delegates.ValidateProgramPipeline));
				this._GetProgramPipelineInfoLog = (Delegates.GetProgramPipelineInfoLog)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramPipelineInfoLog"), typeof(Delegates.GetProgramPipelineInfoLog));
				this._VertexAttribL1d = (Delegates.VertexAttribL1d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribL1d"), typeof(Delegates.VertexAttribL1d));
				this._VertexAttribL2d = (Delegates.VertexAttribL2d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribL2d"), typeof(Delegates.VertexAttribL2d));
				this._VertexAttribL3d = (Delegates.VertexAttribL3d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribL3d"), typeof(Delegates.VertexAttribL3d));
				this._VertexAttribL4d = (Delegates.VertexAttribL4d)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribL4d"), typeof(Delegates.VertexAttribL4d));
				this._VertexAttribL1dv = (Delegates.VertexAttribL1dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribL1dv"), typeof(Delegates.VertexAttribL1dv));
				this._VertexAttribL2dv = (Delegates.VertexAttribL2dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribL2dv"), typeof(Delegates.VertexAttribL2dv));
				this._VertexAttribL3dv = (Delegates.VertexAttribL3dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribL3dv"), typeof(Delegates.VertexAttribL3dv));
				this._VertexAttribL4dv = (Delegates.VertexAttribL4dv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribL4dv"), typeof(Delegates.VertexAttribL4dv));
				this._VertexAttribLPointer = (Delegates.VertexAttribLPointer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribLPointer"), typeof(Delegates.VertexAttribLPointer));
				this._GetVertexAttribLdv = (Delegates.GetVertexAttribLdv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetVertexAttribLdv"), typeof(Delegates.GetVertexAttribLdv));
				this._ViewportArrayv = (Delegates.ViewportArrayv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glViewportArrayv"), typeof(Delegates.ViewportArrayv));
				this._ViewportIndexedf = (Delegates.ViewportIndexedf)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glViewportIndexedf"), typeof(Delegates.ViewportIndexedf));
				this._ViewportIndexedfv = (Delegates.ViewportIndexedfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glViewportIndexedfv"), typeof(Delegates.ViewportIndexedfv));
				this._ScissorArrayv = (Delegates.ScissorArrayv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glScissorArrayv"), typeof(Delegates.ScissorArrayv));
				this._ScissorIndexed = (Delegates.ScissorIndexed)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glScissorIndexed"), typeof(Delegates.ScissorIndexed));
				this._ScissorIndexedv = (Delegates.ScissorIndexedv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glScissorIndexedv"), typeof(Delegates.ScissorIndexedv));
				this._DepthRangeArrayv = (Delegates.DepthRangeArrayv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDepthRangeArrayv"), typeof(Delegates.DepthRangeArrayv));
				this._DepthRangeIndexed = (Delegates.DepthRangeIndexed)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDepthRangeIndexed"), typeof(Delegates.DepthRangeIndexed));
				this._GetFloati_v = (Delegates.GetFloati_v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetFloati_v"), typeof(Delegates.GetFloati_v));
				this._GetDoublei_v = (Delegates.GetDoublei_v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetDoublei_v"), typeof(Delegates.GetDoublei_v));
			}

			if (this.platformContext.VersionMajor > 4 || (this.platformContext.VersionMajor == 4 && this.platformContext.VersionMinor >= 2))
			{
				this._DrawArraysInstancedBaseInstance = (Delegates.DrawArraysInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawArraysInstancedBaseInstance"), typeof(Delegates.DrawArraysInstancedBaseInstance));
				this._DrawElementsInstancedBaseInstance = (Delegates.DrawElementsInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawElementsInstancedBaseInstance"), typeof(Delegates.DrawElementsInstancedBaseInstance));
				this._DrawElementsInstancedBaseVertexBaseInstance = (Delegates.DrawElementsInstancedBaseVertexBaseInstance)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawElementsInstancedBaseVertexBaseInstance"), typeof(Delegates.DrawElementsInstancedBaseVertexBaseInstance));
				this._GetInternalformativ = (Delegates.GetInternalformativ)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetInternalformativ"), typeof(Delegates.GetInternalformativ));
				this._GetActiveAtomicCounterBufferiv = (Delegates.GetActiveAtomicCounterBufferiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetActiveAtomicCounterBufferiv"), typeof(Delegates.GetActiveAtomicCounterBufferiv));
				this._BindImageTexture = (Delegates.BindImageTexture)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindImageTexture"), typeof(Delegates.BindImageTexture));
				this._MemoryBarrier = (Delegates.MemoryBarrier)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMemoryBarrier"), typeof(Delegates.MemoryBarrier));
				this._TexStorage1D = (Delegates.TexStorage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexStorage1D"), typeof(Delegates.TexStorage1D));
				this._TexStorage2D = (Delegates.TexStorage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexStorage2D"), typeof(Delegates.TexStorage2D));
				this._TexStorage3D = (Delegates.TexStorage3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexStorage3D"), typeof(Delegates.TexStorage3D));
				this._DrawTransformFeedbackInstanced = (Delegates.DrawTransformFeedbackInstanced)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawTransformFeedbackInstanced"), typeof(Delegates.DrawTransformFeedbackInstanced));
				this._DrawTransformFeedbackStreamInstanced = (Delegates.DrawTransformFeedbackStreamInstanced)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDrawTransformFeedbackStreamInstanced"), typeof(Delegates.DrawTransformFeedbackStreamInstanced));
			}

			if (this.platformContext.VersionMajor > 4 || (this.platformContext.VersionMajor == 4 && this.platformContext.VersionMinor >= 3))
			{
				this._ClearBufferData = (Delegates.ClearBufferData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearBufferData"), typeof(Delegates.ClearBufferData));
				this._ClearBufferSubData = (Delegates.ClearBufferSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearBufferSubData"), typeof(Delegates.ClearBufferSubData));
				this._DispatchCompute = (Delegates.DispatchCompute)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDispatchCompute"), typeof(Delegates.DispatchCompute));
				this._DispatchComputeIndirect = (Delegates.DispatchComputeIndirect)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDispatchComputeIndirect"), typeof(Delegates.DispatchComputeIndirect));
				this._CopyImageSubData = (Delegates.CopyImageSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyImageSubData"), typeof(Delegates.CopyImageSubData));
				this._FramebufferParameteri = (Delegates.FramebufferParameteri)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFramebufferParameteri"), typeof(Delegates.FramebufferParameteri));
				this._GetFramebufferParameteriv = (Delegates.GetFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetFramebufferParameteriv"), typeof(Delegates.GetFramebufferParameteriv));
				this._GetInternalformati64v = (Delegates.GetInternalformati64v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetInternalformati64v"), typeof(Delegates.GetInternalformati64v));
				this._InvalidateTexSubImage = (Delegates.InvalidateTexSubImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glInvalidateTexSubImage"), typeof(Delegates.InvalidateTexSubImage));
				this._InvalidateTexImage = (Delegates.InvalidateTexImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glInvalidateTexImage"), typeof(Delegates.InvalidateTexImage));
				this._InvalidateBufferSubData = (Delegates.InvalidateBufferSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glInvalidateBufferSubData"), typeof(Delegates.InvalidateBufferSubData));
				this._InvalidateBufferData = (Delegates.InvalidateBufferData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glInvalidateBufferData"), typeof(Delegates.InvalidateBufferData));
				this._InvalidateFramebuffer = (Delegates.InvalidateFramebuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glInvalidateFramebuffer"), typeof(Delegates.InvalidateFramebuffer));
				this._InvalidateSubFramebuffer = (Delegates.InvalidateSubFramebuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glInvalidateSubFramebuffer"), typeof(Delegates.InvalidateSubFramebuffer));
				this._MultiDrawArraysIndirect = (Delegates.MultiDrawArraysIndirect)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMultiDrawArraysIndirect"), typeof(Delegates.MultiDrawArraysIndirect));
				this._MultiDrawElementsIndirect = (Delegates.MultiDrawElementsIndirect)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMultiDrawElementsIndirect"), typeof(Delegates.MultiDrawElementsIndirect));
				this._GetProgramInterfaceiv = (Delegates.GetProgramInterfaceiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramInterfaceiv"), typeof(Delegates.GetProgramInterfaceiv));
				this._GetProgramResourceIndex = (Delegates.GetProgramResourceIndex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramResourceIndex"), typeof(Delegates.GetProgramResourceIndex));
				this._GetProgramResourceName = (Delegates.GetProgramResourceName)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramResourceName"), typeof(Delegates.GetProgramResourceName));
				this._GetProgramResourceiv = (Delegates.GetProgramResourceiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramResourceiv"), typeof(Delegates.GetProgramResourceiv));
				this._GetProgramResourceLocation = (Delegates.GetProgramResourceLocation)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramResourceLocation"), typeof(Delegates.GetProgramResourceLocation));
				this._GetProgramResourceLocationIndex = (Delegates.GetProgramResourceLocationIndex)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetProgramResourceLocationIndex"), typeof(Delegates.GetProgramResourceLocationIndex));
				this._ShaderStorageBlockBinding = (Delegates.ShaderStorageBlockBinding)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glShaderStorageBlockBinding"), typeof(Delegates.ShaderStorageBlockBinding));
				this._TexBufferRange = (Delegates.TexBufferRange)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexBufferRange"), typeof(Delegates.TexBufferRange));
				this._TexStorage2DMultisample = (Delegates.TexStorage2DMultisample)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexStorage2DMultisample"), typeof(Delegates.TexStorage2DMultisample));
				this._TexStorage3DMultisample = (Delegates.TexStorage3DMultisample)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTexStorage3DMultisample"), typeof(Delegates.TexStorage3DMultisample));
				this._TextureView = (Delegates.TextureView)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureView"), typeof(Delegates.TextureView));
				this._BindVertexBuffer = (Delegates.BindVertexBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindVertexBuffer"), typeof(Delegates.BindVertexBuffer));
				this._VertexAttribFormat = (Delegates.VertexAttribFormat)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribFormat"), typeof(Delegates.VertexAttribFormat));
				this._VertexAttribIFormat = (Delegates.VertexAttribIFormat)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribIFormat"), typeof(Delegates.VertexAttribIFormat));
				this._VertexAttribLFormat = (Delegates.VertexAttribLFormat)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribLFormat"), typeof(Delegates.VertexAttribLFormat));
				this._VertexAttribBinding = (Delegates.VertexAttribBinding)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexAttribBinding"), typeof(Delegates.VertexAttribBinding));
				this._VertexBindingDivisor = (Delegates.VertexBindingDivisor)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexBindingDivisor"), typeof(Delegates.VertexBindingDivisor));
				this._DebugMessageControl = (Delegates.DebugMessageControl)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDebugMessageControl"), typeof(Delegates.DebugMessageControl));
				this._DebugMessageInsert = (Delegates.DebugMessageInsert)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDebugMessageInsert"), typeof(Delegates.DebugMessageInsert));
				this._DebugMessageCallback = (Delegates.DebugMessageCallback)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDebugMessageCallback"), typeof(Delegates.DebugMessageCallback));
				this._GetDebugMessageLog = (Delegates.GetDebugMessageLog)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetDebugMessageLog"), typeof(Delegates.GetDebugMessageLog));
				this._PushDebugGroup = (Delegates.PushDebugGroup)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPushDebugGroup"), typeof(Delegates.PushDebugGroup));
				this._PopDebugGroup = (Delegates.PopDebugGroup)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glPopDebugGroup"), typeof(Delegates.PopDebugGroup));
				this._ObjectLabel = (Delegates.ObjectLabel)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glObjectLabel"), typeof(Delegates.ObjectLabel));
				this._GetObjectLabel = (Delegates.GetObjectLabel)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetObjectLabel"), typeof(Delegates.GetObjectLabel));
				this._ObjectPtrLabel = (Delegates.ObjectPtrLabel)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glObjectPtrLabel"), typeof(Delegates.ObjectPtrLabel));
				this._GetObjectPtrLabel = (Delegates.GetObjectPtrLabel)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetObjectPtrLabel"), typeof(Delegates.GetObjectPtrLabel));
			}

			if (this.platformContext.VersionMajor > 4 || (this.platformContext.VersionMajor == 4 && this.platformContext.VersionMinor >= 4))
			{
				this._BufferStorage = (Delegates.BufferStorage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBufferStorage"), typeof(Delegates.BufferStorage));
				this._ClearTexImage = (Delegates.ClearTexImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearTexImage"), typeof(Delegates.ClearTexImage));
				this._ClearTexSubImage = (Delegates.ClearTexSubImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearTexSubImage"), typeof(Delegates.ClearTexSubImage));
				this._BindBuffersBase = (Delegates.BindBuffersBase)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindBuffersBase"), typeof(Delegates.BindBuffersBase));
				this._BindBuffersRange = (Delegates.BindBuffersRange)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindBuffersRange"), typeof(Delegates.BindBuffersRange));
				this._BindTextures = (Delegates.BindTextures)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindTextures"), typeof(Delegates.BindTextures));
				this._BindSamplers = (Delegates.BindSamplers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindSamplers"), typeof(Delegates.BindSamplers));
				this._BindImageTextures = (Delegates.BindImageTextures)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindImageTextures"), typeof(Delegates.BindImageTextures));
				this._BindVertexBuffers = (Delegates.BindVertexBuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindVertexBuffers"), typeof(Delegates.BindVertexBuffers));
			}

			if (this.platformContext.VersionMajor > 4 || (this.platformContext.VersionMajor == 4 && this.platformContext.VersionMinor >= 5))
			{
				this._ClipControl = (Delegates.ClipControl)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClipControl"), typeof(Delegates.ClipControl));
				this._CreateTransformFeedbacks = (Delegates.CreateTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateTransformFeedbacks"), typeof(Delegates.CreateTransformFeedbacks));
				this._TransformFeedbackBufferBase = (Delegates.TransformFeedbackBufferBase)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTransformFeedbackBufferBase"), typeof(Delegates.TransformFeedbackBufferBase));
				this._TransformFeedbackBufferRange = (Delegates.TransformFeedbackBufferRange)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTransformFeedbackBufferRange"), typeof(Delegates.TransformFeedbackBufferRange));
				this._GetTransformFeedbackiv = (Delegates.GetTransformFeedbackiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTransformFeedbackiv"), typeof(Delegates.GetTransformFeedbackiv));
				this._GetTransformFeedbacki_v = (Delegates.GetTransformFeedbacki_v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTransformFeedbacki_v"), typeof(Delegates.GetTransformFeedbacki_v));
				this._GetTransformFeedbacki64_v = (Delegates.GetTransformFeedbacki64_v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTransformFeedbacki64_v"), typeof(Delegates.GetTransformFeedbacki64_v));
				this._CreateBuffers = (Delegates.CreateBuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateBuffers"), typeof(Delegates.CreateBuffers));
				this._NamedBufferStorage = (Delegates.NamedBufferStorage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedBufferStorage"), typeof(Delegates.NamedBufferStorage));
				this._NamedBufferData = (Delegates.NamedBufferData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedBufferData"), typeof(Delegates.NamedBufferData));
				this._NamedBufferSubData = (Delegates.NamedBufferSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedBufferSubData"), typeof(Delegates.NamedBufferSubData));
				this._CopyNamedBufferSubData = (Delegates.CopyNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyNamedBufferSubData"), typeof(Delegates.CopyNamedBufferSubData));
				this._ClearNamedBufferData = (Delegates.ClearNamedBufferData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearNamedBufferData"), typeof(Delegates.ClearNamedBufferData));
				this._ClearNamedBufferSubData = (Delegates.ClearNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearNamedBufferSubData"), typeof(Delegates.ClearNamedBufferSubData));
				this._MapNamedBuffer = (Delegates.MapNamedBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMapNamedBuffer"), typeof(Delegates.MapNamedBuffer));
				this._MapNamedBufferRange = (Delegates.MapNamedBufferRange)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMapNamedBufferRange"), typeof(Delegates.MapNamedBufferRange));
				this._UnmapNamedBuffer = (Delegates.UnmapNamedBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glUnmapNamedBuffer"), typeof(Delegates.UnmapNamedBuffer));
				this._FlushMappedNamedBufferRange = (Delegates.FlushMappedNamedBufferRange)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glFlushMappedNamedBufferRange"), typeof(Delegates.FlushMappedNamedBufferRange));
				this._GetNamedBufferParameteriv = (Delegates.GetNamedBufferParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetNamedBufferParameteriv"), typeof(Delegates.GetNamedBufferParameteriv));
				this._GetNamedBufferParameteri64v = (Delegates.GetNamedBufferParameteri64v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetNamedBufferParameteri64v"), typeof(Delegates.GetNamedBufferParameteri64v));
				this._GetNamedBufferPointerv = (Delegates.GetNamedBufferPointerv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetNamedBufferPointerv"), typeof(Delegates.GetNamedBufferPointerv));
				this._GetNamedBufferSubData = (Delegates.GetNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetNamedBufferSubData"), typeof(Delegates.GetNamedBufferSubData));
				this._CreateFramebuffers = (Delegates.CreateFramebuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateFramebuffers"), typeof(Delegates.CreateFramebuffers));
				this._NamedFramebufferRenderbuffer = (Delegates.NamedFramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedFramebufferRenderbuffer"), typeof(Delegates.NamedFramebufferRenderbuffer));
				this._NamedFramebufferParameteri = (Delegates.NamedFramebufferParameteri)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedFramebufferParameteri"), typeof(Delegates.NamedFramebufferParameteri));
				this._NamedFramebufferTexture = (Delegates.NamedFramebufferTexture)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedFramebufferTexture"), typeof(Delegates.NamedFramebufferTexture));
				this._NamedFramebufferTextureLayer = (Delegates.NamedFramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedFramebufferTextureLayer"), typeof(Delegates.NamedFramebufferTextureLayer));
				this._NamedFramebufferDrawBuffer = (Delegates.NamedFramebufferDrawBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedFramebufferDrawBuffer"), typeof(Delegates.NamedFramebufferDrawBuffer));
				this._NamedFramebufferDrawBuffers = (Delegates.NamedFramebufferDrawBuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedFramebufferDrawBuffers"), typeof(Delegates.NamedFramebufferDrawBuffers));
				this._NamedFramebufferReadBuffer = (Delegates.NamedFramebufferReadBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedFramebufferReadBuffer"), typeof(Delegates.NamedFramebufferReadBuffer));
				this._InvalidateNamedFramebufferData = (Delegates.InvalidateNamedFramebufferData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glInvalidateNamedFramebufferData"), typeof(Delegates.InvalidateNamedFramebufferData));
				this._InvalidateNamedFramebufferSubData = (Delegates.InvalidateNamedFramebufferSubData)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glInvalidateNamedFramebufferSubData"), typeof(Delegates.InvalidateNamedFramebufferSubData));
				this._ClearNamedFramebufferiv = (Delegates.ClearNamedFramebufferiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearNamedFramebufferiv"), typeof(Delegates.ClearNamedFramebufferiv));
				this._ClearNamedFramebufferuiv = (Delegates.ClearNamedFramebufferuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearNamedFramebufferuiv"), typeof(Delegates.ClearNamedFramebufferuiv));
				this._ClearNamedFramebufferfv = (Delegates.ClearNamedFramebufferfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearNamedFramebufferfv"), typeof(Delegates.ClearNamedFramebufferfv));
				this._ClearNamedFramebufferfi = (Delegates.ClearNamedFramebufferfi)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glClearNamedFramebufferfi"), typeof(Delegates.ClearNamedFramebufferfi));
				this._BlitNamedFramebuffer = (Delegates.BlitNamedFramebuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBlitNamedFramebuffer"), typeof(Delegates.BlitNamedFramebuffer));
				this._CheckNamedFramebufferStatus = (Delegates.CheckNamedFramebufferStatus)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCheckNamedFramebufferStatus"), typeof(Delegates.CheckNamedFramebufferStatus));
				this._GetNamedFramebufferParameteriv = (Delegates.GetNamedFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetNamedFramebufferParameteriv"), typeof(Delegates.GetNamedFramebufferParameteriv));
				this._GetNamedFramebufferAttachmentParameteriv = (Delegates.GetNamedFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetNamedFramebufferAttachmentParameteriv"), typeof(Delegates.GetNamedFramebufferAttachmentParameteriv));
				this._CreateRenderbuffers = (Delegates.CreateRenderbuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateRenderbuffers"), typeof(Delegates.CreateRenderbuffers));
				this._NamedRenderbufferStorage = (Delegates.NamedRenderbufferStorage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedRenderbufferStorage"), typeof(Delegates.NamedRenderbufferStorage));
				this._NamedRenderbufferStorageMultisample = (Delegates.NamedRenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glNamedRenderbufferStorageMultisample"), typeof(Delegates.NamedRenderbufferStorageMultisample));
				this._GetNamedRenderbufferParameteriv = (Delegates.GetNamedRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetNamedRenderbufferParameteriv"), typeof(Delegates.GetNamedRenderbufferParameteriv));
				this._CreateTextures = (Delegates.CreateTextures)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateTextures"), typeof(Delegates.CreateTextures));
				this._TextureBuffer = (Delegates.TextureBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureBuffer"), typeof(Delegates.TextureBuffer));
				this._TextureBufferRange = (Delegates.TextureBufferRange)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureBufferRange"), typeof(Delegates.TextureBufferRange));
				this._TextureStorage1D = (Delegates.TextureStorage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureStorage1D"), typeof(Delegates.TextureStorage1D));
				this._TextureStorage2D = (Delegates.TextureStorage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureStorage2D"), typeof(Delegates.TextureStorage2D));
				this._TextureStorage3D = (Delegates.TextureStorage3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureStorage3D"), typeof(Delegates.TextureStorage3D));
				this._TextureStorage2DMultisample = (Delegates.TextureStorage2DMultisample)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureStorage2DMultisample"), typeof(Delegates.TextureStorage2DMultisample));
				this._TextureStorage3DMultisample = (Delegates.TextureStorage3DMultisample)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureStorage3DMultisample"), typeof(Delegates.TextureStorage3DMultisample));
				this._TextureSubImage1D = (Delegates.TextureSubImage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureSubImage1D"), typeof(Delegates.TextureSubImage1D));
				this._TextureSubImage2D = (Delegates.TextureSubImage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureSubImage2D"), typeof(Delegates.TextureSubImage2D));
				this._TextureSubImage3D = (Delegates.TextureSubImage3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureSubImage3D"), typeof(Delegates.TextureSubImage3D));
				this._CompressedTextureSubImage1D = (Delegates.CompressedTextureSubImage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCompressedTextureSubImage1D"), typeof(Delegates.CompressedTextureSubImage1D));
				this._CompressedTextureSubImage2D = (Delegates.CompressedTextureSubImage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCompressedTextureSubImage2D"), typeof(Delegates.CompressedTextureSubImage2D));
				this._CompressedTextureSubImage3D = (Delegates.CompressedTextureSubImage3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCompressedTextureSubImage3D"), typeof(Delegates.CompressedTextureSubImage3D));
				this._CopyTextureSubImage1D = (Delegates.CopyTextureSubImage1D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyTextureSubImage1D"), typeof(Delegates.CopyTextureSubImage1D));
				this._CopyTextureSubImage2D = (Delegates.CopyTextureSubImage2D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyTextureSubImage2D"), typeof(Delegates.CopyTextureSubImage2D));
				this._CopyTextureSubImage3D = (Delegates.CopyTextureSubImage3D)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCopyTextureSubImage3D"), typeof(Delegates.CopyTextureSubImage3D));
				this._TextureParameterf = (Delegates.TextureParameterf)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureParameterf"), typeof(Delegates.TextureParameterf));
				this._TextureParameterfv = (Delegates.TextureParameterfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureParameterfv"), typeof(Delegates.TextureParameterfv));
				this._TextureParameteri = (Delegates.TextureParameteri)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureParameteri"), typeof(Delegates.TextureParameteri));
				this._TextureParameterIiv = (Delegates.TextureParameterIiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureParameterIiv"), typeof(Delegates.TextureParameterIiv));
				this._TextureParameterIuiv = (Delegates.TextureParameterIuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureParameterIuiv"), typeof(Delegates.TextureParameterIuiv));
				this._TextureParameteriv = (Delegates.TextureParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureParameteriv"), typeof(Delegates.TextureParameteriv));
				this._GenerateTextureMipmap = (Delegates.GenerateTextureMipmap)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGenerateTextureMipmap"), typeof(Delegates.GenerateTextureMipmap));
				this._BindTextureUnit = (Delegates.BindTextureUnit)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glBindTextureUnit"), typeof(Delegates.BindTextureUnit));
				this._GetTextureImage = (Delegates.GetTextureImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTextureImage"), typeof(Delegates.GetTextureImage));
				this._GetCompressedTextureImage = (Delegates.GetCompressedTextureImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetCompressedTextureImage"), typeof(Delegates.GetCompressedTextureImage));
				this._GetTextureLevelParameterfv = (Delegates.GetTextureLevelParameterfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTextureLevelParameterfv"), typeof(Delegates.GetTextureLevelParameterfv));
				this._GetTextureLevelParameteriv = (Delegates.GetTextureLevelParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTextureLevelParameteriv"), typeof(Delegates.GetTextureLevelParameteriv));
				this._GetTextureParameterfv = (Delegates.GetTextureParameterfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTextureParameterfv"), typeof(Delegates.GetTextureParameterfv));
				this._GetTextureParameterIiv = (Delegates.GetTextureParameterIiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTextureParameterIiv"), typeof(Delegates.GetTextureParameterIiv));
				this._GetTextureParameterIuiv = (Delegates.GetTextureParameterIuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTextureParameterIuiv"), typeof(Delegates.GetTextureParameterIuiv));
				this._GetTextureParameteriv = (Delegates.GetTextureParameteriv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTextureParameteriv"), typeof(Delegates.GetTextureParameteriv));
				this._CreateVertexArrays = (Delegates.CreateVertexArrays)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateVertexArrays"), typeof(Delegates.CreateVertexArrays));
				this._DisableVertexArrayAttrib = (Delegates.DisableVertexArrayAttrib)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glDisableVertexArrayAttrib"), typeof(Delegates.DisableVertexArrayAttrib));
				this._EnableVertexArrayAttrib = (Delegates.EnableVertexArrayAttrib)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glEnableVertexArrayAttrib"), typeof(Delegates.EnableVertexArrayAttrib));
				this._VertexArrayElementBuffer = (Delegates.VertexArrayElementBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexArrayElementBuffer"), typeof(Delegates.VertexArrayElementBuffer));
				this._VertexArrayVertexBuffer = (Delegates.VertexArrayVertexBuffer)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexArrayVertexBuffer"), typeof(Delegates.VertexArrayVertexBuffer));
				this._VertexArrayVertexBuffers = (Delegates.VertexArrayVertexBuffers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexArrayVertexBuffers"), typeof(Delegates.VertexArrayVertexBuffers));
				this._VertexArrayAttribBinding = (Delegates.VertexArrayAttribBinding)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexArrayAttribBinding"), typeof(Delegates.VertexArrayAttribBinding));
				this._VertexArrayAttribFormat = (Delegates.VertexArrayAttribFormat)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexArrayAttribFormat"), typeof(Delegates.VertexArrayAttribFormat));
				this._VertexArrayAttribIFormat = (Delegates.VertexArrayAttribIFormat)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexArrayAttribIFormat"), typeof(Delegates.VertexArrayAttribIFormat));
				this._VertexArrayAttribLFormat = (Delegates.VertexArrayAttribLFormat)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexArrayAttribLFormat"), typeof(Delegates.VertexArrayAttribLFormat));
				this._VertexArrayBindingDivisor = (Delegates.VertexArrayBindingDivisor)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glVertexArrayBindingDivisor"), typeof(Delegates.VertexArrayBindingDivisor));
				this._GetVertexArrayiv = (Delegates.GetVertexArrayiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetVertexArrayiv"), typeof(Delegates.GetVertexArrayiv));
				this._GetVertexArrayIndexediv = (Delegates.GetVertexArrayIndexediv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetVertexArrayIndexediv"), typeof(Delegates.GetVertexArrayIndexediv));
				this._GetVertexArrayIndexed64iv = (Delegates.GetVertexArrayIndexed64iv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetVertexArrayIndexed64iv"), typeof(Delegates.GetVertexArrayIndexed64iv));
				this._CreateSamplers = (Delegates.CreateSamplers)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateSamplers"), typeof(Delegates.CreateSamplers));
				this._CreateProgramPipelines = (Delegates.CreateProgramPipelines)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateProgramPipelines"), typeof(Delegates.CreateProgramPipelines));
				this._CreateQueries = (Delegates.CreateQueries)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glCreateQueries"), typeof(Delegates.CreateQueries));
				this._GetQueryBufferObjecti64v = (Delegates.GetQueryBufferObjecti64v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetQueryBufferObjecti64v"), typeof(Delegates.GetQueryBufferObjecti64v));
				this._GetQueryBufferObjectiv = (Delegates.GetQueryBufferObjectiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetQueryBufferObjectiv"), typeof(Delegates.GetQueryBufferObjectiv));
				this._GetQueryBufferObjectui64v = (Delegates.GetQueryBufferObjectui64v)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetQueryBufferObjectui64v"), typeof(Delegates.GetQueryBufferObjectui64v));
				this._GetQueryBufferObjectuiv = (Delegates.GetQueryBufferObjectuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetQueryBufferObjectuiv"), typeof(Delegates.GetQueryBufferObjectuiv));
				this._MemoryBarrierByRegion = (Delegates.MemoryBarrierByRegion)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glMemoryBarrierByRegion"), typeof(Delegates.MemoryBarrierByRegion));
				this._GetTextureSubImage = (Delegates.GetTextureSubImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetTextureSubImage"), typeof(Delegates.GetTextureSubImage));
				this._GetCompressedTextureSubImage = (Delegates.GetCompressedTextureSubImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetCompressedTextureSubImage"), typeof(Delegates.GetCompressedTextureSubImage));
				this._GetGraphicsResetStatus = (Delegates.GetGraphicsResetStatus)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetGraphicsResetStatus"), typeof(Delegates.GetGraphicsResetStatus));
				this._GetnCompressedTexImage = (Delegates.GetnCompressedTexImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetnCompressedTexImage"), typeof(Delegates.GetnCompressedTexImage));
				this._GetnTexImage = (Delegates.GetnTexImage)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetnTexImage"), typeof(Delegates.GetnTexImage));
				this._GetnUniformdv = (Delegates.GetnUniformdv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetnUniformdv"), typeof(Delegates.GetnUniformdv));
				this._GetnUniformfv = (Delegates.GetnUniformfv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetnUniformfv"), typeof(Delegates.GetnUniformfv));
				this._GetnUniformiv = (Delegates.GetnUniformiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetnUniformiv"), typeof(Delegates.GetnUniformiv));
				this._GetnUniformuiv = (Delegates.GetnUniformuiv)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glGetnUniformuiv"), typeof(Delegates.GetnUniformuiv));
				this._ReadnPixels = (Delegates.ReadnPixels)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glReadnPixels"), typeof(Delegates.ReadnPixels));
				this._TextureBarrier = (Delegates.TextureBarrier)Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress("glTextureBarrier"), typeof(Delegates.TextureBarrier));
			}

			this.Initialize();
		}

		public void ActiveShaderProgram(uint pipeline, uint program)
		{
			this._ActiveShaderProgram(pipeline, program);
#if DEBUG
			this.CheckErrors("ActiveShaderProgram");
#endif
		}

		public void ActiveTexture(uint texture)
		{
			this._ActiveTexture(texture);
#if DEBUG
			this.CheckErrors("ActiveTexture");
#endif
		}

		public void AttachShader(uint program, uint shader)
		{
			this._AttachShader(program, shader);
#if DEBUG
			this.CheckErrors("AttachShader");
#endif
		}

		public void BeginConditionalRender(uint id, uint mode)
		{
			this._BeginConditionalRender(id, mode);
#if DEBUG
			this.CheckErrors("BeginConditionalRender");
#endif
		}

		public void BeginQuery(uint target, uint id)
		{
			this._BeginQuery(target, id);
#if DEBUG
			this.CheckErrors("BeginQuery");
#endif
		}

		public void BeginQueryIndexed(uint target, uint index, uint id)
		{
			this._BeginQueryIndexed(target, index, id);
#if DEBUG
			this.CheckErrors("BeginQueryIndexed");
#endif
		}

		public void BeginTransformFeedback(uint primitiveMode)
		{
			this._BeginTransformFeedback(primitiveMode);
#if DEBUG
			this.CheckErrors("BeginTransformFeedback");
#endif
		}

		public void BindAttribLocation(uint program, uint index, string name)
		{
			this._BindAttribLocation(program, index, name);
#if DEBUG
			this.CheckErrors("BindAttribLocation");
#endif
		}

		public void BindBuffer(BufferTarget target, uint buffer)
		{
			this._BindBuffer((uint)target, buffer);
#if DEBUG
			this.CheckErrors("BindBuffer");
#endif
		}

		public void BindBuffer(uint target, uint buffer)
		{
			this._BindBuffer(target, buffer);
#if DEBUG
			this.CheckErrors("BindBuffer");
#endif
		}

		public void BindBufferBase(uint target, uint index, uint buffer)
		{
			this._BindBufferBase(target, index, buffer);
#if DEBUG
			this.CheckErrors("BindBufferBase");
#endif
		}

		public void BindBufferRange(uint target, uint index, uint buffer, int offset, int size)
		{
			this._BindBufferRange(target, index, buffer, offset, size);
#if DEBUG
			this.CheckErrors("BindBufferRange");
#endif
		}

		public void BindBuffersBase(uint target, uint first, int count, uint[] buffers)
		{
			this._BindBuffersBase(target, first, count, buffers);
#if DEBUG
			this.CheckErrors("BindBuffersBase");
#endif
		}

		public void BindBuffersRange(uint target, uint first, int count, uint[] buffers, int[] offsets, int[] sizes)
		{
			this._BindBuffersRange(target, first, count, buffers, offsets, sizes);
#if DEBUG
			this.CheckErrors("BindBuffersRange");
#endif
		}

		public void BindFragDataLocation(uint program, uint color, string name)
		{
			this._BindFragDataLocation(program, color, name);
#if DEBUG
			this.CheckErrors("BindFragDataLocation");
#endif
		}

		public void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name)
		{
			this._BindFragDataLocationIndexed(program, colorNumber, index, name);
#if DEBUG
			this.CheckErrors("BindFragDataLocationIndexed");
#endif
		}

		public void BindFramebuffer(uint target, uint framebuffer)
		{
			this._BindFramebuffer(target, framebuffer);
#if DEBUG
			this.CheckErrors("BindFramebuffer");
#endif
		}

		public void BindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format)
		{
			this._BindImageTexture(unit, texture, level, layered, layer, access, format);
#if DEBUG
			this.CheckErrors("BindImageTexture");
#endif
		}

		public void BindImageTextures(uint first, int count, uint[] textures)
		{
			this._BindImageTextures(first, count, textures);
#if DEBUG
			this.CheckErrors("BindImageTextures");
#endif
		}

		public void BindProgramPipeline(uint pipeline)
		{
			this._BindProgramPipeline(pipeline);
#if DEBUG
			this.CheckErrors("BindProgramPipeline");
#endif
		}

		public void BindRenderbuffer(uint target, uint renderbuffer)
		{
			this._BindRenderbuffer(target, renderbuffer);
#if DEBUG
			this.CheckErrors("BindRenderbuffer");
#endif
		}

		public void BindSampler(uint unit, uint sampler)
		{
			this._BindSampler(unit, sampler);
#if DEBUG
			this.CheckErrors("BindSampler");
#endif
		}

		public void BindSamplers(uint first, int count, uint[] samplers)
		{
			this._BindSamplers(first, count, samplers);
#if DEBUG
			this.CheckErrors("BindSamplers");
#endif
		}

		public void BindTexture(TextureTarget target, uint texture)
		{
			this._BindTexture((uint)target, texture);
#if DEBUG
			this.CheckErrors("BindTexture");
#endif
		}

		public void BindTexture(uint target, uint texture)
		{
			this._BindTexture(target, texture);
#if DEBUG
			this.CheckErrors("BindTexture");
#endif
		}

		public void BindTextures(uint first, int count, uint[] textures)
		{
			this._BindTextures(first, count, textures);
#if DEBUG
			this.CheckErrors("BindTextures");
#endif
		}

		public void BindTextureUnit(uint unit, uint texture)
		{
			this._BindTextureUnit(unit, texture);
#if DEBUG
			this.CheckErrors("BindTextureUnit");
#endif
		}

		public void BindTransformFeedback(uint target, uint id)
		{
			this._BindTransformFeedback(target, id);
#if DEBUG
			this.CheckErrors("BindTransformFeedback");
#endif
		}

		public void BindVertexArray(uint array)
		{
			this._BindVertexArray(array);
#if DEBUG
			this.CheckErrors("BindVertexArray");
#endif
		}

		public void BindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride)
		{
			this._BindVertexBuffer(bindingindex, buffer, offset, stride);
#if DEBUG
			this.CheckErrors("BindVertexBuffer");
#endif
		}

		public void BindVertexBuffers(uint first, int count, uint[] buffers, int[] offsets, int[] strides)
		{
			this._BindVertexBuffers(first, count, buffers, offsets, strides);
#if DEBUG
			this.CheckErrors("BindVertexBuffers");
#endif
		}

		public void BlendColor(float red, float green, float blue, float alpha)
		{
			this._BlendColor(red, green, blue, alpha);
#if DEBUG
			this.CheckErrors("BlendColor");
#endif
		}

		public void BlendEquation(uint mode)
		{
			this._BlendEquation(mode);
#if DEBUG
			this.CheckErrors("BlendEquation");
#endif
		}

		public void BlendEquationi(uint buf, uint mode)
		{
			this._BlendEquationi(buf, mode);
#if DEBUG
			this.CheckErrors("BlendEquationi");
#endif
		}

		public void BlendEquationSeparate(uint modeRGB, uint modeAlpha)
		{
			this._BlendEquationSeparate(modeRGB, modeAlpha);
#if DEBUG
			this.CheckErrors("BlendEquationSeparate");
#endif
		}

		public void BlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha)
		{
			this._BlendEquationSeparatei(buf, modeRGB, modeAlpha);
#if DEBUG
			this.CheckErrors("BlendEquationSeparatei");
#endif
		}

		public void BlendFunc(BlendingFactorSrc sfactor, BlendingFactorDest dfactor)
		{
			this._BlendFunc((uint)sfactor, (uint)dfactor);
#if DEBUG
			this.CheckErrors("BlendFunc");
#endif
		}

		public void BlendFunc(uint sfactor, uint dfactor)
		{
			this._BlendFunc(sfactor, dfactor);
#if DEBUG
			this.CheckErrors("BlendFunc");
#endif
		}

		public void BlendFunci(uint buf, uint src, uint dst)
		{
			this._BlendFunci(buf, src, dst);
#if DEBUG
			this.CheckErrors("BlendFunci");
#endif
		}

		public void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
			this._BlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
#if DEBUG
			this.CheckErrors("BlendFuncSeparate");
#endif
		}

		public void BlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
		{
			this._BlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
#if DEBUG
			this.CheckErrors("BlendFuncSeparatei");
#endif
		}

		public void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, uint filter)
		{
			this._BlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, filter);
#if DEBUG
			this.CheckErrors("BlitFramebuffer");
#endif
		}

		public void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			this._BlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
#if DEBUG
			this.CheckErrors("BlitFramebuffer");
#endif
		}

		public void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			this._BlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
#if DEBUG
			this.CheckErrors("BlitNamedFramebuffer");
#endif
		}

		public void BufferData(BufferTarget target, int size, IntPtr data, BufferUsage usage)
		{
			this._BufferData((uint)target, size, data, (uint)usage);
#if DEBUG
			this.CheckErrors("BufferData");
#endif
		}

		public void BufferData(uint target, int size, IntPtr data, uint usage)
		{
			this._BufferData(target, size, data, usage);
#if DEBUG
			this.CheckErrors("BufferData");
#endif
		}

		public void BufferStorage(uint target, int size, IntPtr data, uint flags)
		{
			this._BufferStorage(target, size, data, flags);
#if DEBUG
			this.CheckErrors("BufferStorage");
#endif
		}

		public void BufferSubData(BufferTarget target, int offset, int size, IntPtr data)
		{
			this._BufferSubData((uint)target, offset, size, data);
#if DEBUG
			this.CheckErrors("BufferSubData");
#endif
		}

		public void BufferSubData(uint target, int offset, int size, IntPtr data)
		{
			this._BufferSubData(target, offset, size, data);
#if DEBUG
			this.CheckErrors("BufferSubData");
#endif
		}

		public uint CheckFramebufferStatus(uint target)
		{
			var result = this._CheckFramebufferStatus(target);
#if DEBUG
			this.CheckErrors("CheckFramebufferStatus");
#endif
			return result;
		}

		public uint CheckNamedFramebufferStatus(uint framebuffer, uint target)
		{
			var result = this._CheckNamedFramebufferStatus(framebuffer, target);
#if DEBUG
			this.CheckErrors("CheckNamedFramebufferStatus");
#endif
			return result;
		}

		public void ClampColor(uint target, uint clamp)
		{
			this._ClampColor(target, clamp);
#if DEBUG
			this.CheckErrors("ClampColor");
#endif
		}

		public void Clear(ClearBufferMask mask)
		{
			this._Clear((uint)mask);
#if DEBUG
			this.CheckErrors("Clear");
#endif
		}

		public void Clear(uint mask)
		{
			this._Clear(mask);
#if DEBUG
			this.CheckErrors("Clear");
#endif
		}

		public void ClearBufferData(uint target, uint internalformat, uint format, uint type, IntPtr data)
		{
			this._ClearBufferData(target, internalformat, format, type, data);
#if DEBUG
			this.CheckErrors("ClearBufferData");
#endif
		}

		public void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil)
		{
			this._ClearBufferfi(buffer, drawbuffer, depth, stencil);
#if DEBUG
			this.CheckErrors("ClearBufferfi");
#endif
		}

		public void ClearBufferfv(uint buffer, int drawbuffer, float[] value)
		{
			this._ClearBufferfv(buffer, drawbuffer, value);
#if DEBUG
			this.CheckErrors("ClearBufferfv");
#endif
		}

		public void ClearBufferiv(uint buffer, int drawbuffer, int[] value)
		{
			this._ClearBufferiv(buffer, drawbuffer, value);
#if DEBUG
			this.CheckErrors("ClearBufferiv");
#endif
		}

		public void ClearBufferSubData(uint target, uint internalformat, int offset, int size, uint format, uint type, IntPtr data)
		{
			this._ClearBufferSubData(target, internalformat, offset, size, format, type, data);
#if DEBUG
			this.CheckErrors("ClearBufferSubData");
#endif
		}

		public void ClearBufferuiv(uint buffer, int drawbuffer, uint[] value)
		{
			this._ClearBufferuiv(buffer, drawbuffer, value);
#if DEBUG
			this.CheckErrors("ClearBufferuiv");
#endif
		}

		public void ClearColor(float red, float green, float blue, float alpha)
		{
			this._ClearColor(red, green, blue, alpha);
#if DEBUG
			this.CheckErrors("ClearColor");
#endif
		}

		public void ClearDepth(double depth)
		{
			this._ClearDepth(depth);
#if DEBUG
			this.CheckErrors("ClearDepth");
#endif
		}

		public void ClearDepthf(float d)
		{
			this._ClearDepthf(d);
#if DEBUG
			this.CheckErrors("ClearDepthf");
#endif
		}

		public void ClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, IntPtr data)
		{
			this._ClearNamedBufferData(buffer, internalformat, format, type, data);
#if DEBUG
			this.CheckErrors("ClearNamedBufferData");
#endif
		}

		public void ClearNamedBufferSubData(uint buffer, uint internalformat, int offset, int size, uint format, uint type, IntPtr data)
		{
			this._ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
#if DEBUG
			this.CheckErrors("ClearNamedBufferSubData");
#endif
		}

		public void ClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil)
		{
			this._ClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
#if DEBUG
			this.CheckErrors("ClearNamedFramebufferfi");
#endif
		}

		public void ClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float[] value)
		{
			this._ClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);
#if DEBUG
			this.CheckErrors("ClearNamedFramebufferfv");
#endif
		}

		public void ClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int[] value)
		{
			this._ClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);
#if DEBUG
			this.CheckErrors("ClearNamedFramebufferiv");
#endif
		}

		public void ClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint[] value)
		{
			this._ClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);
#if DEBUG
			this.CheckErrors("ClearNamedFramebufferuiv");
#endif
		}

		public void ClearStencil(int s)
		{
			this._ClearStencil(s);
#if DEBUG
			this.CheckErrors("ClearStencil");
#endif
		}

		public void ClearTexImage(uint texture, int level, uint format, uint type, IntPtr data)
		{
			this._ClearTexImage(texture, level, format, type, data);
#if DEBUG
			this.CheckErrors("ClearTexImage");
#endif
		}

		public void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data)
		{
			this._ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
#if DEBUG
			this.CheckErrors("ClearTexSubImage");
#endif
		}

		public uint ClientWaitSync(IntPtr sync, uint flags, ulong timeout)
		{
			var result = this._ClientWaitSync(sync, flags, timeout);
#if DEBUG
			this.CheckErrors("ClientWaitSync");
#endif
			return result;
		}

		public void ClipControl(uint origin, uint depth)
		{
			this._ClipControl(origin, depth);
#if DEBUG
			this.CheckErrors("ClipControl");
#endif
		}

		public void ColorMask(bool red, bool green, bool blue, bool alpha)
		{
			this._ColorMask(red, green, blue, alpha);
#if DEBUG
			this.CheckErrors("ColorMask");
#endif
		}

		public void ColorMaski(uint index, bool r, bool g, bool b, bool a)
		{
			this._ColorMaski(index, r, g, b, a);
#if DEBUG
			this.CheckErrors("ColorMaski");
#endif
		}

		public void CompileShader(uint shader)
		{
			this._CompileShader(shader);
#if DEBUG
			this.CheckErrors("CompileShader");
#endif
		}

		public void CompressedTexImage1D(TextureTarget target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data)
		{
			this._CompressedTexImage1D((uint)target, level, internalformat, width, border, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexImage1D");
#endif
		}

		public void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data)
		{
			this._CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexImage1D");
#endif
		}

		public void CompressedTexImage2D(TextureTarget target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data)
		{
			this._CompressedTexImage2D((uint)target, level, internalformat, width, height, border, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexImage2D");
#endif
		}

		public void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data)
		{
			this._CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexImage2D");
#endif
		}

		public void CompressedTexImage3D(TextureTarget target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
		{
			this._CompressedTexImage3D((uint)target, level, internalformat, width, height, depth, border, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexImage3D");
#endif
		}

		public void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
		{
			this._CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexImage3D");
#endif
		}

		public void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data)
		{
			this._CompressedTexSubImage1D((uint)target, level, xoffset, width, (uint)format, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexSubImage1D");
#endif
		}

		public void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data)
		{
			this._CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexSubImage1D");
#endif
		}

		public void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
		{
			this._CompressedTexSubImage2D((uint)target, level, xoffset, yoffset, width, height, (uint)format, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexSubImage2D");
#endif
		}

		public void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data)
		{
			this._CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexSubImage2D");
#endif
		}

		public void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
		{
			this._CompressedTexSubImage3D((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexSubImage3D");
#endif
		}

		public void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data)
		{
			this._CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTexSubImage3D");
#endif
		}

		public void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data)
		{
			this._CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTextureSubImage1D");
#endif
		}

		public void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data)
		{
			this._CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTextureSubImage2D");
#endif
		}

		public void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data)
		{
			this._CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
#if DEBUG
			this.CheckErrors("CompressedTextureSubImage3D");
#endif
		}

		public void CopyBufferSubData(uint readTarget, uint writeTarget, int readOffset, int writeOffset, int size)
		{
			this._CopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
#if DEBUG
			this.CheckErrors("CopyBufferSubData");
#endif
		}

		public void CopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			this._CopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
#if DEBUG
			this.CheckErrors("CopyImageSubData");
#endif
		}

		public void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size)
		{
			this._CopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
#if DEBUG
			this.CheckErrors("CopyNamedBufferSubData");
#endif
		}

		public void CopyTexImage1D(TextureTarget target, int level, uint internalformat, int x, int y, int width, int border)
		{
			this._CopyTexImage1D((uint)target, level, internalformat, x, y, width, border);
#if DEBUG
			this.CheckErrors("CopyTexImage1D");
#endif
		}

		public void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border)
		{
			this._CopyTexImage1D(target, level, internalformat, x, y, width, border);
#if DEBUG
			this.CheckErrors("CopyTexImage1D");
#endif
		}

		public void CopyTexImage2D(TextureTarget target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
			this._CopyTexImage2D((uint)target, level, internalformat, x, y, width, height, border);
#if DEBUG
			this.CheckErrors("CopyTexImage2D");
#endif
		}

		public void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
			this._CopyTexImage2D(target, level, internalformat, x, y, width, height, border);
#if DEBUG
			this.CheckErrors("CopyTexImage2D");
#endif
		}

		public void CopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, int width)
		{
			this._CopyTexSubImage1D((uint)target, level, xoffset, x, y, width);
#if DEBUG
			this.CheckErrors("CopyTexSubImage1D");
#endif
		}

		public void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width)
		{
			this._CopyTexSubImage1D(target, level, xoffset, x, y, width);
#if DEBUG
			this.CheckErrors("CopyTexSubImage1D");
#endif
		}

		public void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			this._CopyTexSubImage2D((uint)target, level, xoffset, yoffset, x, y, width, height);
#if DEBUG
			this.CheckErrors("CopyTexSubImage2D");
#endif
		}

		public void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			this._CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
#if DEBUG
			this.CheckErrors("CopyTexSubImage2D");
#endif
		}

		public void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			this._CopyTexSubImage3D((uint)target, level, xoffset, yoffset, zoffset, x, y, width, height);
#if DEBUG
			this.CheckErrors("CopyTexSubImage3D");
#endif
		}

		public void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			this._CopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
#if DEBUG
			this.CheckErrors("CopyTexSubImage3D");
#endif
		}

		public void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width)
		{
			this._CopyTextureSubImage1D(texture, level, xoffset, x, y, width);
#if DEBUG
			this.CheckErrors("CopyTextureSubImage1D");
#endif
		}

		public void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			this._CopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
#if DEBUG
			this.CheckErrors("CopyTextureSubImage2D");
#endif
		}

		public void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			this._CopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
#if DEBUG
			this.CheckErrors("CopyTextureSubImage3D");
#endif
		}

		public void CreateBuffers(int n, uint[] buffers)
		{
			this._CreateBuffers(n, buffers);
#if DEBUG
			this.CheckErrors("CreateBuffers");
#endif
		}

		public void CreateFramebuffers(int n, uint[] framebuffers)
		{
			this._CreateFramebuffers(n, framebuffers);
#if DEBUG
			this.CheckErrors("CreateFramebuffers");
#endif
		}

		public uint CreateProgram()
		{
			var result = this._CreateProgram();
#if DEBUG
			this.CheckErrors("CreateProgram");
#endif
			return result;
		}

		public void CreateProgramPipelines(int n, uint[] pipelines)
		{
			this._CreateProgramPipelines(n, pipelines);
#if DEBUG
			this.CheckErrors("CreateProgramPipelines");
#endif
		}

		public void CreateQueries(uint target, int n, uint[] ids)
		{
			this._CreateQueries(target, n, ids);
#if DEBUG
			this.CheckErrors("CreateQueries");
#endif
		}

		public void CreateRenderbuffers(int n, uint[] renderbuffers)
		{
			this._CreateRenderbuffers(n, renderbuffers);
#if DEBUG
			this.CheckErrors("CreateRenderbuffers");
#endif
		}

		public void CreateSamplers(int n, uint[] samplers)
		{
			this._CreateSamplers(n, samplers);
#if DEBUG
			this.CheckErrors("CreateSamplers");
#endif
		}

		public uint CreateShader(uint type)
		{
			var result = this._CreateShader(type);
#if DEBUG
			this.CheckErrors("CreateShader");
#endif
			return result;
		}

		public uint CreateShaderProgramv(uint type, int count, string[] strings)
		{
			var result = this._CreateShaderProgramv(type, count, strings);
#if DEBUG
			this.CheckErrors("CreateShaderProgramv");
#endif
			return result;
		}

		public void CreateTextures(uint target, int n, uint[] textures)
		{
			this._CreateTextures(target, n, textures);
#if DEBUG
			this.CheckErrors("CreateTextures");
#endif
		}

		public void CreateTransformFeedbacks(int n, uint[] ids)
		{
			this._CreateTransformFeedbacks(n, ids);
#if DEBUG
			this.CheckErrors("CreateTransformFeedbacks");
#endif
		}

		public void CreateVertexArrays(int n, uint[] arrays)
		{
			this._CreateVertexArrays(n, arrays);
#if DEBUG
			this.CheckErrors("CreateVertexArrays");
#endif
		}

		public void CullFace(CullFaceMode mode)
		{
			this._CullFace((uint)mode);
#if DEBUG
			this.CheckErrors("CullFace");
#endif
		}

		public void CullFace(uint mode)
		{
			this._CullFace(mode);
#if DEBUG
			this.CheckErrors("CullFace");
#endif
		}

		public void DebugMessageCallback(DebugProc callback, IntPtr userParam)
		{
			this._DebugMessageCallback(callback, userParam);
#if DEBUG
			this.CheckErrors("DebugMessageCallback");
#endif
		}

		public void DebugMessageControl(uint source, uint type, uint severity, int count, uint[] ids, bool enabled)
		{
			this._DebugMessageControl(source, type, severity, count, ids, enabled);
#if DEBUG
			this.CheckErrors("DebugMessageControl");
#endif
		}

		public void DebugMessageInsert(uint source, uint type, uint id, uint severity, int length, string buf)
		{
			this._DebugMessageInsert(source, type, id, severity, length, buf);
#if DEBUG
			this.CheckErrors("DebugMessageInsert");
#endif
		}

		public void DeleteBuffers(int n, uint[] buffers)
		{
			this._DeleteBuffers(n, buffers);
#if DEBUG
			this.CheckErrors("DeleteBuffers");
#endif
		}

		public void DeleteBuffer(uint handle)
		{
			UintBuffer[0] = handle;
			DeleteBuffers(1, UintBuffer);
		}

		public void DeleteFramebuffers(int n, uint[] framebuffers)
		{
			this._DeleteFramebuffers(n, framebuffers);
#if DEBUG
			this.CheckErrors("DeleteFramebuffers");
#endif
		}

		public void DeleteFramebuffer(uint handle)
		{
			UintBuffer[0] = handle;
			DeleteFramebuffers(1, UintBuffer);
		}

		public void DeleteProgram(uint program)
		{
			this._DeleteProgram(program);
#if DEBUG
			this.CheckErrors("DeleteProgram");
#endif
		}

		public void DeleteProgramPipelines(int n, uint[] pipelines)
		{
			this._DeleteProgramPipelines(n, pipelines);
#if DEBUG
			this.CheckErrors("DeleteProgramPipelines");
#endif
		}

		public void DeleteProgramPipeline(uint handle)
		{
			UintBuffer[0] = handle;
			DeleteProgramPipelines(1, UintBuffer);
		}

		public void DeleteQueries(int n, uint[] ids)
		{
			this._DeleteQueries(n, ids);
#if DEBUG
			this.CheckErrors("DeleteQueries");
#endif
		}

		public void DeleteQuerie(uint handle)
		{
			UintBuffer[0] = handle;
			DeleteQueries(1, UintBuffer);
		}

		public void DeleteRenderbuffers(int n, uint[] renderbuffers)
		{
			this._DeleteRenderbuffers(n, renderbuffers);
#if DEBUG
			this.CheckErrors("DeleteRenderbuffers");
#endif
		}

		public void DeleteRenderbuffer(uint handle)
		{
			UintBuffer[0] = handle;
			DeleteRenderbuffers(1, UintBuffer);
		}

		public void DeleteSamplers(int count, uint[] samplers)
		{
			this._DeleteSamplers(count, samplers);
#if DEBUG
			this.CheckErrors("DeleteSamplers");
#endif
		}

		public void DeleteSampler(uint handle)
		{
			UintBuffer[0] = handle;
			DeleteSamplers(1, UintBuffer);
		}

		public void DeleteShader(uint shader)
		{
			this._DeleteShader(shader);
#if DEBUG
			this.CheckErrors("DeleteShader");
#endif
		}

		public void DeleteSync(IntPtr sync)
		{
			this._DeleteSync(sync);
#if DEBUG
			this.CheckErrors("DeleteSync");
#endif
		}

		public void DeleteTextures(int n, uint[] textures)
		{
			this._DeleteTextures(n, textures);
#if DEBUG
			this.CheckErrors("DeleteTextures");
#endif
		}

		public void DeleteTexture(uint handle)
		{
			UintBuffer[0] = handle;
			DeleteTextures(1, UintBuffer);
		}

		public void DeleteTransformFeedbacks(int n, uint[] ids)
		{
			this._DeleteTransformFeedbacks(n, ids);
#if DEBUG
			this.CheckErrors("DeleteTransformFeedbacks");
#endif
		}

		public void DeleteTransformFeedback(uint handle)
		{
			UintBuffer[0] = handle;
			DeleteTransformFeedbacks(1, UintBuffer);
		}

		public void DeleteVertexArrays(int n, uint[] arrays)
		{
			this._DeleteVertexArrays(n, arrays);
#if DEBUG
			this.CheckErrors("DeleteVertexArrays");
#endif
		}

		public void DeleteVertexArray(uint handle)
		{
			UintBuffer[0] = handle;
			DeleteVertexArrays(1, UintBuffer);
		}

		public void DepthFunc(DepthFunction func)
		{
			this._DepthFunc((uint)func);
#if DEBUG
			this.CheckErrors("DepthFunc");
#endif
		}

		public void DepthFunc(uint func)
		{
			this._DepthFunc(func);
#if DEBUG
			this.CheckErrors("DepthFunc");
#endif
		}

		public void DepthMask(bool flag)
		{
			this._DepthMask(flag);
#if DEBUG
			this.CheckErrors("DepthMask");
#endif
		}

		public void DepthRange(double near, double far)
		{
			this._DepthRange(near, far);
#if DEBUG
			this.CheckErrors("DepthRange");
#endif
		}

		public void DepthRangeArrayv(uint first, int count, double[] v)
		{
			this._DepthRangeArrayv(first, count, v);
#if DEBUG
			this.CheckErrors("DepthRangeArrayv");
#endif
		}

		public void DepthRangef(float n, float f)
		{
			this._DepthRangef(n, f);
#if DEBUG
			this.CheckErrors("DepthRangef");
#endif
		}

		public void DepthRangeIndexed(uint index, double n, double f)
		{
			this._DepthRangeIndexed(index, n, f);
#if DEBUG
			this.CheckErrors("DepthRangeIndexed");
#endif
		}

		public void DetachShader(uint program, uint shader)
		{
			this._DetachShader(program, shader);
#if DEBUG
			this.CheckErrors("DetachShader");
#endif
		}

		public void Disable(EnableCap cap)
		{
			this._Disable((uint)cap);
#if DEBUG
			this.CheckErrors("Disable");
#endif
		}

		public void Disable(uint cap)
		{
			this._Disable(cap);
#if DEBUG
			this.CheckErrors("Disable");
#endif
		}

		public void Disablei(uint target, uint index)
		{
			this._Disablei(target, index);
#if DEBUG
			this.CheckErrors("Disablei");
#endif
		}

		public void DisableVertexArrayAttrib(uint vaobj, uint index)
		{
			this._DisableVertexArrayAttrib(vaobj, index);
#if DEBUG
			this.CheckErrors("DisableVertexArrayAttrib");
#endif
		}

		public void DisableVertexAttribArray(uint index)
		{
			this._DisableVertexAttribArray(index);
#if DEBUG
			this.CheckErrors("DisableVertexAttribArray");
#endif
		}

		public void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
		{
			this._DispatchCompute(num_groups_x, num_groups_y, num_groups_z);
#if DEBUG
			this.CheckErrors("DispatchCompute");
#endif
		}

		public void DispatchComputeIndirect(int indirect)
		{
			this._DispatchComputeIndirect(indirect);
#if DEBUG
			this.CheckErrors("DispatchComputeIndirect");
#endif
		}

		public void DrawArrays(PrimitiveType mode, int first, int count)
		{
			this._DrawArrays((uint)mode, first, count);
#if DEBUG
			this.CheckErrors("DrawArrays");
#endif
		}

		public void DrawArrays(uint mode, int first, int count)
		{
			this._DrawArrays(mode, first, count);
#if DEBUG
			this.CheckErrors("DrawArrays");
#endif
		}

		public void DrawArraysIndirect(PrimitiveType mode, IntPtr indirect)
		{
			this._DrawArraysIndirect((uint)mode, indirect);
#if DEBUG
			this.CheckErrors("DrawArraysIndirect");
#endif
		}

		public void DrawArraysIndirect(uint mode, IntPtr indirect)
		{
			this._DrawArraysIndirect(mode, indirect);
#if DEBUG
			this.CheckErrors("DrawArraysIndirect");
#endif
		}

		public void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount)
		{
			this._DrawArraysInstanced((uint)mode, first, count, instancecount);
#if DEBUG
			this.CheckErrors("DrawArraysInstanced");
#endif
		}

		public void DrawArraysInstanced(uint mode, int first, int count, int instancecount)
		{
			this._DrawArraysInstanced(mode, first, count, instancecount);
#if DEBUG
			this.CheckErrors("DrawArraysInstanced");
#endif
		}

		public void DrawArraysInstancedBaseInstance(PrimitiveType mode, int first, int count, int instancecount, uint baseinstance)
		{
			this._DrawArraysInstancedBaseInstance((uint)mode, first, count, instancecount, baseinstance);
#if DEBUG
			this.CheckErrors("DrawArraysInstancedBaseInstance");
#endif
		}

		public void DrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance)
		{
			this._DrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
#if DEBUG
			this.CheckErrors("DrawArraysInstancedBaseInstance");
#endif
		}

		public void DrawBuffer(DrawBufferMode buf)
		{
			this._DrawBuffer((uint)buf);
#if DEBUG
			this.CheckErrors("DrawBuffer");
#endif
		}

		public void DrawBuffer(uint buf)
		{
			this._DrawBuffer(buf);
#if DEBUG
			this.CheckErrors("DrawBuffer");
#endif
		}

		public void DrawBuffers(int n, uint[] bufs)
		{
			this._DrawBuffers(n, bufs);
#if DEBUG
			this.CheckErrors("DrawBuffers");
#endif
		}

		public void DrawElements(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices)
		{
			this._DrawElements((uint)mode, count, (uint)type, indices);
#if DEBUG
			this.CheckErrors("DrawElements");
#endif
		}

		public void DrawElements(uint mode, int count, uint type, IntPtr indices)
		{
			this._DrawElements(mode, count, type, indices);
#if DEBUG
			this.CheckErrors("DrawElements");
#endif
		}

		public void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int basevertex)
		{
			this._DrawElementsBaseVertex((uint)mode, count, (uint)type, indices, basevertex);
#if DEBUG
			this.CheckErrors("DrawElementsBaseVertex");
#endif
		}

		public void DrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int basevertex)
		{
			this._DrawElementsBaseVertex(mode, count, type, indices, basevertex);
#if DEBUG
			this.CheckErrors("DrawElementsBaseVertex");
#endif
		}

		public void DrawElementsIndirect(PrimitiveType mode, uint type, IntPtr indirect)
		{
			this._DrawElementsIndirect((uint)mode, type, indirect);
#if DEBUG
			this.CheckErrors("DrawElementsIndirect");
#endif
		}

		public void DrawElementsIndirect(uint mode, uint type, IntPtr indirect)
		{
			this._DrawElementsIndirect(mode, type, indirect);
#if DEBUG
			this.CheckErrors("DrawElementsIndirect");
#endif
		}

		public void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount)
		{
			this._DrawElementsInstanced((uint)mode, count, (uint)type, indices, instancecount);
#if DEBUG
			this.CheckErrors("DrawElementsInstanced");
#endif
		}

		public void DrawElementsInstanced(uint mode, int count, uint type, IntPtr indices, int instancecount)
		{
			this._DrawElementsInstanced(mode, count, type, indices, instancecount);
#if DEBUG
			this.CheckErrors("DrawElementsInstanced");
#endif
		}

		public void DrawElementsInstancedBaseInstance(PrimitiveType mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance)
		{
			this._DrawElementsInstancedBaseInstance((uint)mode, count, type, indices, instancecount, baseinstance);
#if DEBUG
			this.CheckErrors("DrawElementsInstancedBaseInstance");
#endif
		}

		public void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance)
		{
			this._DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
#if DEBUG
			this.CheckErrors("DrawElementsInstancedBaseInstance");
#endif
		}

		public void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int basevertex)
		{
			this._DrawElementsInstancedBaseVertex((uint)mode, count, (uint)type, indices, instancecount, basevertex);
#if DEBUG
			this.CheckErrors("DrawElementsInstancedBaseVertex");
#endif
		}

		public void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex)
		{
			this._DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
#if DEBUG
			this.CheckErrors("DrawElementsInstancedBaseVertex");
#endif
		}

		public void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance)
		{
			this._DrawElementsInstancedBaseVertexBaseInstance((uint)mode, count, type, indices, instancecount, basevertex, baseinstance);
#if DEBUG
			this.CheckErrors("DrawElementsInstancedBaseVertexBaseInstance");
#endif
		}

		public void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance)
		{
			this._DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
#if DEBUG
			this.CheckErrors("DrawElementsInstancedBaseVertexBaseInstance");
#endif
		}

		public void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices)
		{
			this._DrawRangeElements((uint)mode, start, end, count, (uint)type, indices);
#if DEBUG
			this.CheckErrors("DrawRangeElements");
#endif
		}

		public void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices)
		{
			this._DrawRangeElements(mode, start, end, count, type, indices);
#if DEBUG
			this.CheckErrors("DrawRangeElements");
#endif
		}

		public void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices, int basevertex)
		{
			this._DrawRangeElementsBaseVertex((uint)mode, start, end, count, (uint)type, indices, basevertex);
#if DEBUG
			this.CheckErrors("DrawRangeElementsBaseVertex");
#endif
		}

		public void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex)
		{
			this._DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
#if DEBUG
			this.CheckErrors("DrawRangeElementsBaseVertex");
#endif
		}

		public void DrawTransformFeedback(PrimitiveType mode, uint id)
		{
			this._DrawTransformFeedback((uint)mode, id);
#if DEBUG
			this.CheckErrors("DrawTransformFeedback");
#endif
		}

		public void DrawTransformFeedback(uint mode, uint id)
		{
			this._DrawTransformFeedback(mode, id);
#if DEBUG
			this.CheckErrors("DrawTransformFeedback");
#endif
		}

		public void DrawTransformFeedbackInstanced(PrimitiveType mode, uint id, int instancecount)
		{
			this._DrawTransformFeedbackInstanced((uint)mode, id, instancecount);
#if DEBUG
			this.CheckErrors("DrawTransformFeedbackInstanced");
#endif
		}

		public void DrawTransformFeedbackInstanced(uint mode, uint id, int instancecount)
		{
			this._DrawTransformFeedbackInstanced(mode, id, instancecount);
#if DEBUG
			this.CheckErrors("DrawTransformFeedbackInstanced");
#endif
		}

		public void DrawTransformFeedbackStream(PrimitiveType mode, uint id, uint stream)
		{
			this._DrawTransformFeedbackStream((uint)mode, id, stream);
#if DEBUG
			this.CheckErrors("DrawTransformFeedbackStream");
#endif
		}

		public void DrawTransformFeedbackStream(uint mode, uint id, uint stream)
		{
			this._DrawTransformFeedbackStream(mode, id, stream);
#if DEBUG
			this.CheckErrors("DrawTransformFeedbackStream");
#endif
		}

		public void DrawTransformFeedbackStreamInstanced(PrimitiveType mode, uint id, uint stream, int instancecount)
		{
			this._DrawTransformFeedbackStreamInstanced((uint)mode, id, stream, instancecount);
#if DEBUG
			this.CheckErrors("DrawTransformFeedbackStreamInstanced");
#endif
		}

		public void DrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount)
		{
			this._DrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
#if DEBUG
			this.CheckErrors("DrawTransformFeedbackStreamInstanced");
#endif
		}

		public void Enable(EnableCap cap)
		{
			this._Enable((uint)cap);
#if DEBUG
			this.CheckErrors("Enable");
#endif
		}

		public void Enable(uint cap)
		{
			this._Enable(cap);
#if DEBUG
			this.CheckErrors("Enable");
#endif
		}

		public void Enablei(uint target, uint index)
		{
			this._Enablei(target, index);
#if DEBUG
			this.CheckErrors("Enablei");
#endif
		}

		public void EnableVertexArrayAttrib(uint vaobj, uint index)
		{
			this._EnableVertexArrayAttrib(vaobj, index);
#if DEBUG
			this.CheckErrors("EnableVertexArrayAttrib");
#endif
		}

		public void EnableVertexAttribArray(uint index)
		{
			this._EnableVertexAttribArray(index);
#if DEBUG
			this.CheckErrors("EnableVertexAttribArray");
#endif
		}

		public void EndConditionalRender()
		{
			this._EndConditionalRender();
#if DEBUG
			this.CheckErrors("EndConditionalRender");
#endif
		}

		public void EndQuery(uint target)
		{
			this._EndQuery(target);
#if DEBUG
			this.CheckErrors("EndQuery");
#endif
		}

		public void EndQueryIndexed(uint target, uint index)
		{
			this._EndQueryIndexed(target, index);
#if DEBUG
			this.CheckErrors("EndQueryIndexed");
#endif
		}

		public void EndTransformFeedback()
		{
			this._EndTransformFeedback();
#if DEBUG
			this.CheckErrors("EndTransformFeedback");
#endif
		}

		public IntPtr FenceSync(uint condition, uint flags)
		{
			var result = this._FenceSync(condition, flags);
#if DEBUG
			this.CheckErrors("FenceSync");
#endif
			return result;
		}

		public void Finish()
		{
			this._Finish();
#if DEBUG
			this.CheckErrors("Finish");
#endif
		}

		public void Flush()
		{
			this._Flush();
#if DEBUG
			this.CheckErrors("Flush");
#endif
		}

		public void FlushMappedBufferRange(BufferTarget target, int offset, int length)
		{
			this._FlushMappedBufferRange((uint)target, offset, length);
#if DEBUG
			this.CheckErrors("FlushMappedBufferRange");
#endif
		}

		public void FlushMappedBufferRange(uint target, int offset, int length)
		{
			this._FlushMappedBufferRange(target, offset, length);
#if DEBUG
			this.CheckErrors("FlushMappedBufferRange");
#endif
		}

		public void FlushMappedNamedBufferRange(uint buffer, int offset, int length)
		{
			this._FlushMappedNamedBufferRange(buffer, offset, length);
#if DEBUG
			this.CheckErrors("FlushMappedNamedBufferRange");
#endif
		}

		public void FramebufferParameteri(uint target, uint pname, int param)
		{
			this._FramebufferParameteri(target, pname, param);
#if DEBUG
			this.CheckErrors("FramebufferParameteri");
#endif
		}

		public void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			this._FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
#if DEBUG
			this.CheckErrors("FramebufferRenderbuffer");
#endif
		}

		public void FramebufferTexture(uint target, uint attachment, uint texture, int level)
		{
			this._FramebufferTexture(target, attachment, texture, level);
#if DEBUG
			this.CheckErrors("FramebufferTexture");
#endif
		}

		public void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			this._FramebufferTexture1D(target, attachment, textarget, texture, level);
#if DEBUG
			this.CheckErrors("FramebufferTexture1D");
#endif
		}

		public void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			this._FramebufferTexture2D(target, attachment, textarget, texture, level);
#if DEBUG
			this.CheckErrors("FramebufferTexture2D");
#endif
		}

		public void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
			this._FramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
#if DEBUG
			this.CheckErrors("FramebufferTexture3D");
#endif
		}

		public void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer)
		{
			this._FramebufferTextureLayer(target, attachment, texture, level, layer);
#if DEBUG
			this.CheckErrors("FramebufferTextureLayer");
#endif
		}

		public void FrontFace(FrontFaceDirection mode)
		{
			this._FrontFace((uint)mode);
#if DEBUG
			this.CheckErrors("FrontFace");
#endif
		}

		public void FrontFace(uint mode)
		{
			this._FrontFace(mode);
#if DEBUG
			this.CheckErrors("FrontFace");
#endif
		}

		public void GenBuffers(int n, uint[] buffers)
		{
			this._GenBuffers(n, buffers);
#if DEBUG
			this.CheckErrors("GenBuffers");
#endif
		}

		public uint GenBuffer()
		{
			GenBuffers(1, UintBuffer);
			return UintBuffer[0];
		}

		public void GenerateMipmap(uint target)
		{
			this._GenerateMipmap(target);
#if DEBUG
			this.CheckErrors("GenerateMipmap");
#endif
		}

		public void GenerateTextureMipmap(uint texture)
		{
			this._GenerateTextureMipmap(texture);
#if DEBUG
			this.CheckErrors("GenerateTextureMipmap");
#endif
		}

		public void GenFramebuffers(int n, uint[] framebuffers)
		{
			this._GenFramebuffers(n, framebuffers);
#if DEBUG
			this.CheckErrors("GenFramebuffers");
#endif
		}

		public uint GenFramebuffer()
		{
			GenFramebuffers(1, UintBuffer);
			return UintBuffer[0];
		}

		public void GenProgramPipelines(int n, uint[] pipelines)
		{
			this._GenProgramPipelines(n, pipelines);
#if DEBUG
			this.CheckErrors("GenProgramPipelines");
#endif
		}

		public uint GenProgramPipeline()
		{
			GenProgramPipelines(1, UintBuffer);
			return UintBuffer[0];
		}

		public void GenQueries(int n, uint[] ids)
		{
			this._GenQueries(n, ids);
#if DEBUG
			this.CheckErrors("GenQueries");
#endif
		}

		public uint GenQuerie()
		{
			GenQueries(1, UintBuffer);
			return UintBuffer[0];
		}

		public void GenRenderbuffers(int n, uint[] renderbuffers)
		{
			this._GenRenderbuffers(n, renderbuffers);
#if DEBUG
			this.CheckErrors("GenRenderbuffers");
#endif
		}

		public uint GenRenderbuffer()
		{
			GenRenderbuffers(1, UintBuffer);
			return UintBuffer[0];
		}

		public void GenSamplers(int count, uint[] samplers)
		{
			this._GenSamplers(count, samplers);
#if DEBUG
			this.CheckErrors("GenSamplers");
#endif
		}

		public uint GenSampler()
		{
			GenSamplers(1, UintBuffer);
			return UintBuffer[0];
		}

		public void GenTextures(int n, uint[] textures)
		{
			this._GenTextures(n, textures);
#if DEBUG
			this.CheckErrors("GenTextures");
#endif
		}

		public uint GenTexture()
		{
			GenTextures(1, UintBuffer);
			return UintBuffer[0];
		}

		public void GenTransformFeedbacks(int n, uint[] ids)
		{
			this._GenTransformFeedbacks(n, ids);
#if DEBUG
			this.CheckErrors("GenTransformFeedbacks");
#endif
		}

		public uint GenTransformFeedback()
		{
			GenTransformFeedbacks(1, UintBuffer);
			return UintBuffer[0];
		}

		public void GenVertexArrays(int n, uint[] arrays)
		{
			this._GenVertexArrays(n, arrays);
#if DEBUG
			this.CheckErrors("GenVertexArrays");
#endif
		}

		public uint GenVertexArray()
		{
			GenVertexArrays(1, UintBuffer);
			return UintBuffer[0];
		}

		public void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int[] @params)
		{
			this._GetActiveAtomicCounterBufferiv(program, bufferIndex, pname, @params);
#if DEBUG
			this.CheckErrors("GetActiveAtomicCounterBufferiv");
#endif
		}

		public void GetActiveAttrib(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name)
		{
			this._GetActiveAttrib(program, index, bufSize, length, size, type, name);
#if DEBUG
			this.CheckErrors("GetActiveAttrib");
#endif
		}

		public void GetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int[] length, StringBuilder name)
		{
			this._GetActiveSubroutineName(program, shadertype, index, bufsize, length, name);
#if DEBUG
			this.CheckErrors("GetActiveSubroutineName");
#endif
		}

		public void GetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int[] values)
		{
			this._GetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
#if DEBUG
			this.CheckErrors("GetActiveSubroutineUniformiv");
#endif
		}

		public void GetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int[] length, StringBuilder name)
		{
			this._GetActiveSubroutineUniformName(program, shadertype, index, bufsize, length, name);
#if DEBUG
			this.CheckErrors("GetActiveSubroutineUniformName");
#endif
		}

		public void GetActiveUniform(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name)
		{
			this._GetActiveUniform(program, index, bufSize, length, size, type, name);
#if DEBUG
			this.CheckErrors("GetActiveUniform");
#endif
		}

		public void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int[] @params)
		{
			this._GetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params);
#if DEBUG
			this.CheckErrors("GetActiveUniformBlockiv");
#endif
		}

		public void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int[] length, StringBuilder uniformBlockName)
		{
			this._GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
#if DEBUG
			this.CheckErrors("GetActiveUniformBlockName");
#endif
		}

		public void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int[] length, StringBuilder uniformName)
		{
			this._GetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);
#if DEBUG
			this.CheckErrors("GetActiveUniformName");
#endif
		}

		public void GetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] @params)
		{
			this._GetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params);
#if DEBUG
			this.CheckErrors("GetActiveUniformsiv");
#endif
		}

		public void GetAttachedShaders(uint program, int maxCount, int[] count, uint[] shaders)
		{
			this._GetAttachedShaders(program, maxCount, count, shaders);
#if DEBUG
			this.CheckErrors("GetAttachedShaders");
#endif
		}

		public int GetAttribLocation(uint program, string name)
		{
			var result = this._GetAttribLocation(program, name);
#if DEBUG
			this.CheckErrors("GetAttribLocation");
#endif
			return result;
		}

		public void GetBooleani_v(uint target, uint index, bool[] data)
		{
			this._GetBooleani_v(target, index, data);
#if DEBUG
			this.CheckErrors("GetBooleani_v");
#endif
		}

		public void GetBooleanv(GetPName pname, bool[] data)
		{
			this._GetBooleanv((uint)pname, data);
#if DEBUG
			this.CheckErrors("GetBooleanv");
#endif
		}

		public void GetBooleanv(uint pname, bool[] data)
		{
			this._GetBooleanv(pname, data);
#if DEBUG
			this.CheckErrors("GetBooleanv");
#endif
		}

		public void GetBufferParameteri64v(BufferTarget target, uint pname, long[] @params)
		{
			this._GetBufferParameteri64v((uint)target, pname, @params);
#if DEBUG
			this.CheckErrors("GetBufferParameteri64v");
#endif
		}

		public void GetBufferParameteri64v(uint target, uint pname, long[] @params)
		{
			this._GetBufferParameteri64v(target, pname, @params);
#if DEBUG
			this.CheckErrors("GetBufferParameteri64v");
#endif
		}

		public void GetBufferParameteriv(BufferTarget target, uint pname, int[] @params)
		{
			this._GetBufferParameteriv((uint)target, pname, @params);
#if DEBUG
			this.CheckErrors("GetBufferParameteriv");
#endif
		}

		public void GetBufferParameteriv(uint target, uint pname, int[] @params)
		{
			this._GetBufferParameteriv(target, pname, @params);
#if DEBUG
			this.CheckErrors("GetBufferParameteriv");
#endif
		}

		public void GetBufferPointerv(BufferTarget target, uint pname, IntPtr[] @params)
		{
			this._GetBufferPointerv((uint)target, pname, @params);
#if DEBUG
			this.CheckErrors("GetBufferPointerv");
#endif
		}

		public void GetBufferPointerv(uint target, uint pname, IntPtr[] @params)
		{
			this._GetBufferPointerv(target, pname, @params);
#if DEBUG
			this.CheckErrors("GetBufferPointerv");
#endif
		}

		public void GetBufferSubData(BufferTarget target, int offset, int size, IntPtr data)
		{
			this._GetBufferSubData((uint)target, offset, size, data);
#if DEBUG
			this.CheckErrors("GetBufferSubData");
#endif
		}

		public void GetBufferSubData(uint target, int offset, int size, IntPtr data)
		{
			this._GetBufferSubData(target, offset, size, data);
#if DEBUG
			this.CheckErrors("GetBufferSubData");
#endif
		}

		public void GetCompressedTexImage(TextureTarget target, int level, IntPtr img)
		{
			this._GetCompressedTexImage((uint)target, level, img);
#if DEBUG
			this.CheckErrors("GetCompressedTexImage");
#endif
		}

		public void GetCompressedTexImage(uint target, int level, IntPtr img)
		{
			this._GetCompressedTexImage(target, level, img);
#if DEBUG
			this.CheckErrors("GetCompressedTexImage");
#endif
		}

		public void GetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels)
		{
			this._GetCompressedTextureImage(texture, level, bufSize, pixels);
#if DEBUG
			this.CheckErrors("GetCompressedTextureImage");
#endif
		}

		public void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels)
		{
			this._GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
#if DEBUG
			this.CheckErrors("GetCompressedTextureSubImage");
#endif
		}

		public uint GetDebugMessageLog(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, StringBuilder messageLog)
		{
			var result = this._GetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
#if DEBUG
			this.CheckErrors("GetDebugMessageLog");
#endif
			return result;
		}

		public void GetDoublei_v(uint target, uint index, double[] data)
		{
			this._GetDoublei_v(target, index, data);
#if DEBUG
			this.CheckErrors("GetDoublei_v");
#endif
		}

		public void GetDoublev(GetPName pname, double[] data)
		{
			this._GetDoublev((uint)pname, data);
#if DEBUG
			this.CheckErrors("GetDoublev");
#endif
		}

		public void GetDoublev(uint pname, double[] data)
		{
			this._GetDoublev(pname, data);
#if DEBUG
			this.CheckErrors("GetDoublev");
#endif
		}

		public void GetFloati_v(uint target, uint index, float[] data)
		{
			this._GetFloati_v(target, index, data);
#if DEBUG
			this.CheckErrors("GetFloati_v");
#endif
		}

		public void GetFloatv(GetPName pname, float[] data)
		{
			this._GetFloatv((uint)pname, data);
#if DEBUG
			this.CheckErrors("GetFloatv");
#endif
		}

		public void GetFloatv(uint pname, float[] data)
		{
			this._GetFloatv(pname, data);
#if DEBUG
			this.CheckErrors("GetFloatv");
#endif
		}

		public int GetFragDataIndex(uint program, string name)
		{
			var result = this._GetFragDataIndex(program, name);
#if DEBUG
			this.CheckErrors("GetFragDataIndex");
#endif
			return result;
		}

		public int GetFragDataLocation(uint program, string name)
		{
			var result = this._GetFragDataLocation(program, name);
#if DEBUG
			this.CheckErrors("GetFragDataLocation");
#endif
			return result;
		}

		public void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int[] @params)
		{
			this._GetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
#if DEBUG
			this.CheckErrors("GetFramebufferAttachmentParameteriv");
#endif
		}

		public void GetFramebufferParameteriv(uint target, uint pname, int[] @params)
		{
			this._GetFramebufferParameteriv(target, pname, @params);
#if DEBUG
			this.CheckErrors("GetFramebufferParameteriv");
#endif
		}

		public uint GetGraphicsResetStatus()
		{
			var result = this._GetGraphicsResetStatus();
#if DEBUG
			this.CheckErrors("GetGraphicsResetStatus");
#endif
			return result;
		}

		public void GetInteger64i_v(uint target, uint index, long[] data)
		{
			this._GetInteger64i_v(target, index, data);
#if DEBUG
			this.CheckErrors("GetInteger64i_v");
#endif
		}

		public void GetInteger64v(uint pname, long[] data)
		{
			this._GetInteger64v(pname, data);
#if DEBUG
			this.CheckErrors("GetInteger64v");
#endif
		}

		public void GetIntegeri_v(uint target, uint index, int[] data)
		{
			this._GetIntegeri_v(target, index, data);
#if DEBUG
			this.CheckErrors("GetIntegeri_v");
#endif
		}

		public void GetIntegerv(GetPName pname, int[] data)
		{
			this._GetIntegerv((uint)pname, data);
#if DEBUG
			this.CheckErrors("GetIntegerv");
#endif
		}

		public void GetIntegerv(uint pname, int[] data)
		{
			this._GetIntegerv(pname, data);
#if DEBUG
			this.CheckErrors("GetIntegerv");
#endif
		}

		public void GetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, long[] @params)
		{
			this._GetInternalformati64v(target, internalformat, pname, bufSize, @params);
#if DEBUG
			this.CheckErrors("GetInternalformati64v");
#endif
		}

		public void GetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int[] @params)
		{
			this._GetInternalformativ(target, internalformat, pname, bufSize, @params);
#if DEBUG
			this.CheckErrors("GetInternalformativ");
#endif
		}

		public void GetMultisamplefv(uint pname, uint index, float[] val)
		{
			this._GetMultisamplefv(pname, index, val);
#if DEBUG
			this.CheckErrors("GetMultisamplefv");
#endif
		}

		public void GetNamedBufferParameteri64v(uint buffer, uint pname, long[] @params)
		{
			this._GetNamedBufferParameteri64v(buffer, pname, @params);
#if DEBUG
			this.CheckErrors("GetNamedBufferParameteri64v");
#endif
		}

		public void GetNamedBufferParameteriv(uint buffer, uint pname, int[] @params)
		{
			this._GetNamedBufferParameteriv(buffer, pname, @params);
#if DEBUG
			this.CheckErrors("GetNamedBufferParameteriv");
#endif
		}

		public void GetNamedBufferPointerv(uint buffer, uint pname, IntPtr[] @params)
		{
			this._GetNamedBufferPointerv(buffer, pname, @params);
#if DEBUG
			this.CheckErrors("GetNamedBufferPointerv");
#endif
		}

		public void GetNamedBufferSubData(uint buffer, int offset, int size, IntPtr data)
		{
			this._GetNamedBufferSubData(buffer, offset, size, data);
#if DEBUG
			this.CheckErrors("GetNamedBufferSubData");
#endif
		}

		public void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int[] @params)
		{
			this._GetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, @params);
#if DEBUG
			this.CheckErrors("GetNamedFramebufferAttachmentParameteriv");
#endif
		}

		public void GetNamedFramebufferParameteriv(uint framebuffer, uint pname, int[] param)
		{
			this._GetNamedFramebufferParameteriv(framebuffer, pname, param);
#if DEBUG
			this.CheckErrors("GetNamedFramebufferParameteriv");
#endif
		}

		public void GetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int[] @params)
		{
			this._GetNamedRenderbufferParameteriv(renderbuffer, pname, @params);
#if DEBUG
			this.CheckErrors("GetNamedRenderbufferParameteriv");
#endif
		}

		public void GetnCompressedTexImage(uint target, int lod, int bufSize, IntPtr pixels)
		{
			this._GetnCompressedTexImage(target, lod, bufSize, pixels);
#if DEBUG
			this.CheckErrors("GetnCompressedTexImage");
#endif
		}

		public void GetnTexImage(uint target, int level, uint format, uint type, int bufSize, IntPtr pixels)
		{
			this._GetnTexImage(target, level, format, type, bufSize, pixels);
#if DEBUG
			this.CheckErrors("GetnTexImage");
#endif
		}

		public void GetnUniformdv(uint program, int location, int bufSize, double[] @params)
		{
			this._GetnUniformdv(program, location, bufSize, @params);
#if DEBUG
			this.CheckErrors("GetnUniformdv");
#endif
		}

		public void GetnUniformfv(uint program, int location, int bufSize, float[] @params)
		{
			this._GetnUniformfv(program, location, bufSize, @params);
#if DEBUG
			this.CheckErrors("GetnUniformfv");
#endif
		}

		public void GetnUniformiv(uint program, int location, int bufSize, int[] @params)
		{
			this._GetnUniformiv(program, location, bufSize, @params);
#if DEBUG
			this.CheckErrors("GetnUniformiv");
#endif
		}

		public void GetnUniformuiv(uint program, int location, int bufSize, uint[] @params)
		{
			this._GetnUniformuiv(program, location, bufSize, @params);
#if DEBUG
			this.CheckErrors("GetnUniformuiv");
#endif
		}

		public void GetObjectLabel(uint identifier, uint name, int bufSize, int[] length, StringBuilder label)
		{
			this._GetObjectLabel(identifier, name, bufSize, length, label);
#if DEBUG
			this.CheckErrors("GetObjectLabel");
#endif
		}

		public void GetObjectPtrLabel(IntPtr ptr, int bufSize, int[] length, StringBuilder label)
		{
			this._GetObjectPtrLabel(ptr, bufSize, length, label);
#if DEBUG
			this.CheckErrors("GetObjectPtrLabel");
#endif
		}

		public void GetPointerv(uint pname, IntPtr[] @params)
		{
			this._GetPointerv(pname, @params);
#if DEBUG
			this.CheckErrors("GetPointerv");
#endif
		}

		public void GetProgramBinary(uint program, int bufSize, int[] length, uint[] binaryFormat, IntPtr binary)
		{
			this._GetProgramBinary(program, bufSize, length, binaryFormat, binary);
#if DEBUG
			this.CheckErrors("GetProgramBinary");
#endif
		}

		public void GetProgramInterfaceiv(uint program, uint programInterface, uint pname, int[] @params)
		{
			this._GetProgramInterfaceiv(program, programInterface, pname, @params);
#if DEBUG
			this.CheckErrors("GetProgramInterfaceiv");
#endif
		}

		public void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int[] length, StringBuilder infoLog)
		{
			this._GetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
#if DEBUG
			this.CheckErrors("GetProgramPipelineInfoLog");
#endif
		}

		public void GetProgramPipelineiv(uint pipeline, uint pname, int[] @params)
		{
			this._GetProgramPipelineiv(pipeline, pname, @params);
#if DEBUG
			this.CheckErrors("GetProgramPipelineiv");
#endif
		}

		public uint GetProgramResourceIndex(uint program, uint programInterface, string name)
		{
			var result = this._GetProgramResourceIndex(program, programInterface, name);
#if DEBUG
			this.CheckErrors("GetProgramResourceIndex");
#endif
			return result;
		}

		public void GetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, int[] @params)
		{
			this._GetProgramResourceiv(program, programInterface, index, propCount, props, bufSize, length, @params);
#if DEBUG
			this.CheckErrors("GetProgramResourceiv");
#endif
		}

		public int GetProgramResourceLocation(uint program, uint programInterface, string name)
		{
			var result = this._GetProgramResourceLocation(program, programInterface, name);
#if DEBUG
			this.CheckErrors("GetProgramResourceLocation");
#endif
			return result;
		}

		public int GetProgramResourceLocationIndex(uint program, uint programInterface, string name)
		{
			var result = this._GetProgramResourceLocationIndex(program, programInterface, name);
#if DEBUG
			this.CheckErrors("GetProgramResourceLocationIndex");
#endif
			return result;
		}

		public void GetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int[] length, StringBuilder name)
		{
			this._GetProgramResourceName(program, programInterface, index, bufSize, length, name);
#if DEBUG
			this.CheckErrors("GetProgramResourceName");
#endif
		}

		public void GetProgramStageiv(uint program, uint shadertype, uint pname, int[] values)
		{
			this._GetProgramStageiv(program, shadertype, pname, values);
#if DEBUG
			this.CheckErrors("GetProgramStageiv");
#endif
		}

		public void GetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int offset)
		{
			this._GetQueryBufferObjecti64v(id, buffer, pname, offset);
#if DEBUG
			this.CheckErrors("GetQueryBufferObjecti64v");
#endif
		}

		public void GetQueryBufferObjectiv(uint id, uint buffer, uint pname, int offset)
		{
			this._GetQueryBufferObjectiv(id, buffer, pname, offset);
#if DEBUG
			this.CheckErrors("GetQueryBufferObjectiv");
#endif
		}

		public void GetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int offset)
		{
			this._GetQueryBufferObjectui64v(id, buffer, pname, offset);
#if DEBUG
			this.CheckErrors("GetQueryBufferObjectui64v");
#endif
		}

		public void GetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int offset)
		{
			this._GetQueryBufferObjectuiv(id, buffer, pname, offset);
#if DEBUG
			this.CheckErrors("GetQueryBufferObjectuiv");
#endif
		}

		public void GetQueryIndexediv(uint target, uint index, uint pname, int[] @params)
		{
			this._GetQueryIndexediv(target, index, pname, @params);
#if DEBUG
			this.CheckErrors("GetQueryIndexediv");
#endif
		}

		public void GetQueryiv(uint target, uint pname, int[] @params)
		{
			this._GetQueryiv(target, pname, @params);
#if DEBUG
			this.CheckErrors("GetQueryiv");
#endif
		}

		public void GetQueryObjecti64v(uint id, uint pname, long[] @params)
		{
			this._GetQueryObjecti64v(id, pname, @params);
#if DEBUG
			this.CheckErrors("GetQueryObjecti64v");
#endif
		}

		public void GetQueryObjectiv(uint id, uint pname, int[] @params)
		{
			this._GetQueryObjectiv(id, pname, @params);
#if DEBUG
			this.CheckErrors("GetQueryObjectiv");
#endif
		}

		public void GetQueryObjectui64v(uint id, uint pname, ulong[] @params)
		{
			this._GetQueryObjectui64v(id, pname, @params);
#if DEBUG
			this.CheckErrors("GetQueryObjectui64v");
#endif
		}

		public void GetQueryObjectuiv(uint id, uint pname, uint[] @params)
		{
			this._GetQueryObjectuiv(id, pname, @params);
#if DEBUG
			this.CheckErrors("GetQueryObjectuiv");
#endif
		}

		public void GetRenderbufferParameteriv(uint target, uint pname, int[] @params)
		{
			this._GetRenderbufferParameteriv(target, pname, @params);
#if DEBUG
			this.CheckErrors("GetRenderbufferParameteriv");
#endif
		}

		public void GetSamplerParameterfv(uint sampler, uint pname, float[] @params)
		{
			this._GetSamplerParameterfv(sampler, pname, @params);
#if DEBUG
			this.CheckErrors("GetSamplerParameterfv");
#endif
		}

		public void GetSamplerParameterIiv(uint sampler, uint pname, int[] @params)
		{
			this._GetSamplerParameterIiv(sampler, pname, @params);
#if DEBUG
			this.CheckErrors("GetSamplerParameterIiv");
#endif
		}

		public void GetSamplerParameterIuiv(uint sampler, uint pname, uint[] @params)
		{
			this._GetSamplerParameterIuiv(sampler, pname, @params);
#if DEBUG
			this.CheckErrors("GetSamplerParameterIuiv");
#endif
		}

		public void GetSamplerParameteriv(uint sampler, uint pname, int[] @params)
		{
			this._GetSamplerParameteriv(sampler, pname, @params);
#if DEBUG
			this.CheckErrors("GetSamplerParameteriv");
#endif
		}

		public void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int[] range, int[] precision)
		{
			this._GetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
#if DEBUG
			this.CheckErrors("GetShaderPrecisionFormat");
#endif
		}

		public void GetShaderSource(uint shader, int bufSize, int[] length, StringBuilder source)
		{
			this._GetShaderSource(shader, bufSize, length, source);
#if DEBUG
			this.CheckErrors("GetShaderSource");
#endif
		}

		public IntPtr GetStringi(uint name, uint index)
		{
			var result = this._GetStringi(name, index);
#if DEBUG
			this.CheckErrors("GetStringi");
#endif
			return result;
		}

		public uint GetSubroutineIndex(uint program, uint shadertype, string name)
		{
			var result = this._GetSubroutineIndex(program, shadertype, name);
#if DEBUG
			this.CheckErrors("GetSubroutineIndex");
#endif
			return result;
		}

		public int GetSubroutineUniformLocation(uint program, uint shadertype, string name)
		{
			var result = this._GetSubroutineUniformLocation(program, shadertype, name);
#if DEBUG
			this.CheckErrors("GetSubroutineUniformLocation");
#endif
			return result;
		}

		public void GetSynciv(IntPtr sync, uint pname, int bufSize, int[] length, int[] values)
		{
			this._GetSynciv(sync, pname, bufSize, length, values);
#if DEBUG
			this.CheckErrors("GetSynciv");
#endif
		}

		public void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			this._GetTexImage((uint)target, level, (uint)format, (uint)type, pixels);
#if DEBUG
			this.CheckErrors("GetTexImage");
#endif
		}

		public void GetTexImage(uint target, int level, uint format, uint type, IntPtr pixels)
		{
			this._GetTexImage(target, level, format, type, pixels);
#if DEBUG
			this.CheckErrors("GetTexImage");
#endif
		}

		public void GetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float[] @params)
		{
			this._GetTexLevelParameterfv((uint)target, level, (uint)pname, @params);
#if DEBUG
			this.CheckErrors("GetTexLevelParameterfv");
#endif
		}

		public void GetTexLevelParameterfv(uint target, int level, uint pname, float[] @params)
		{
			this._GetTexLevelParameterfv(target, level, pname, @params);
#if DEBUG
			this.CheckErrors("GetTexLevelParameterfv");
#endif
		}

		public void GetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int[] @params)
		{
			this._GetTexLevelParameteriv((uint)target, level, (uint)pname, @params);
#if DEBUG
			this.CheckErrors("GetTexLevelParameteriv");
#endif
		}

		public void GetTexLevelParameteriv(uint target, int level, uint pname, int[] @params)
		{
			this._GetTexLevelParameteriv(target, level, pname, @params);
#if DEBUG
			this.CheckErrors("GetTexLevelParameteriv");
#endif
		}

		public void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float[] @params)
		{
			this._GetTexParameterfv((uint)target, (uint)pname, @params);
#if DEBUG
			this.CheckErrors("GetTexParameterfv");
#endif
		}

		public void GetTexParameterfv(uint target, uint pname, float[] @params)
		{
			this._GetTexParameterfv(target, pname, @params);
#if DEBUG
			this.CheckErrors("GetTexParameterfv");
#endif
		}

		public void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int[] @params)
		{
			this._GetTexParameterIiv((uint)target, (uint)pname, @params);
#if DEBUG
			this.CheckErrors("GetTexParameterIiv");
#endif
		}

		public void GetTexParameterIiv(uint target, uint pname, int[] @params)
		{
			this._GetTexParameterIiv(target, pname, @params);
#if DEBUG
			this.CheckErrors("GetTexParameterIiv");
#endif
		}

		public void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint[] @params)
		{
			this._GetTexParameterIuiv((uint)target, (uint)pname, @params);
#if DEBUG
			this.CheckErrors("GetTexParameterIuiv");
#endif
		}

		public void GetTexParameterIuiv(uint target, uint pname, uint[] @params)
		{
			this._GetTexParameterIuiv(target, pname, @params);
#if DEBUG
			this.CheckErrors("GetTexParameterIuiv");
#endif
		}

		public void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int[] @params)
		{
			this._GetTexParameteriv((uint)target, (uint)pname, @params);
#if DEBUG
			this.CheckErrors("GetTexParameteriv");
#endif
		}

		public void GetTexParameteriv(uint target, uint pname, int[] @params)
		{
			this._GetTexParameteriv(target, pname, @params);
#if DEBUG
			this.CheckErrors("GetTexParameteriv");
#endif
		}

		public void GetTextureImage(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels)
		{
			this._GetTextureImage(texture, level, format, type, bufSize, pixels);
#if DEBUG
			this.CheckErrors("GetTextureImage");
#endif
		}

		public void GetTextureLevelParameterfv(uint texture, int level, uint pname, float[] @params)
		{
			this._GetTextureLevelParameterfv(texture, level, pname, @params);
#if DEBUG
			this.CheckErrors("GetTextureLevelParameterfv");
#endif
		}

		public void GetTextureLevelParameteriv(uint texture, int level, uint pname, int[] @params)
		{
			this._GetTextureLevelParameteriv(texture, level, pname, @params);
#if DEBUG
			this.CheckErrors("GetTextureLevelParameteriv");
#endif
		}

		public void GetTextureParameterfv(uint texture, uint pname, float[] @params)
		{
			this._GetTextureParameterfv(texture, pname, @params);
#if DEBUG
			this.CheckErrors("GetTextureParameterfv");
#endif
		}

		public void GetTextureParameterIiv(uint texture, uint pname, int[] @params)
		{
			this._GetTextureParameterIiv(texture, pname, @params);
#if DEBUG
			this.CheckErrors("GetTextureParameterIiv");
#endif
		}

		public void GetTextureParameterIuiv(uint texture, uint pname, uint[] @params)
		{
			this._GetTextureParameterIuiv(texture, pname, @params);
#if DEBUG
			this.CheckErrors("GetTextureParameterIuiv");
#endif
		}

		public void GetTextureParameteriv(uint texture, uint pname, int[] @params)
		{
			this._GetTextureParameteriv(texture, pname, @params);
#if DEBUG
			this.CheckErrors("GetTextureParameteriv");
#endif
		}

		public void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels)
		{
			this._GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
#if DEBUG
			this.CheckErrors("GetTextureSubImage");
#endif
		}

		public void GetTransformFeedbacki_v(uint xfb, uint pname, uint index, int[] param)
		{
			this._GetTransformFeedbacki_v(xfb, pname, index, param);
#if DEBUG
			this.CheckErrors("GetTransformFeedbacki_v");
#endif
		}

		public void GetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long[] param)
		{
			this._GetTransformFeedbacki64_v(xfb, pname, index, param);
#if DEBUG
			this.CheckErrors("GetTransformFeedbacki64_v");
#endif
		}

		public void GetTransformFeedbackiv(uint xfb, uint pname, int[] param)
		{
			this._GetTransformFeedbackiv(xfb, pname, param);
#if DEBUG
			this.CheckErrors("GetTransformFeedbackiv");
#endif
		}

		public void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name)
		{
			this._GetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
#if DEBUG
			this.CheckErrors("GetTransformFeedbackVarying");
#endif
		}

		public uint GetUniformBlockIndex(uint program, string uniformBlockName)
		{
			var result = this._GetUniformBlockIndex(program, uniformBlockName);
#if DEBUG
			this.CheckErrors("GetUniformBlockIndex");
#endif
			return result;
		}

		public void GetUniformdv(uint program, int location, double[] @params)
		{
			this._GetUniformdv(program, location, @params);
#if DEBUG
			this.CheckErrors("GetUniformdv");
#endif
		}

		public void GetUniformfv(uint program, int location, float[] @params)
		{
			this._GetUniformfv(program, location, @params);
#if DEBUG
			this.CheckErrors("GetUniformfv");
#endif
		}

		public void GetUniformIndices(uint program, int uniformCount, string[] uniformNames, uint[] uniformIndices)
		{
			this._GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
#if DEBUG
			this.CheckErrors("GetUniformIndices");
#endif
		}

		public void GetUniformiv(uint program, int location, int[] @params)
		{
			this._GetUniformiv(program, location, @params);
#if DEBUG
			this.CheckErrors("GetUniformiv");
#endif
		}

		public int GetUniformLocation(uint program, string name)
		{
			var result = this._GetUniformLocation(program, name);
#if DEBUG
			this.CheckErrors("GetUniformLocation");
#endif
			return result;
		}

		public void GetUniformSubroutineuiv(uint shadertype, int location, uint[] @params)
		{
			this._GetUniformSubroutineuiv(shadertype, location, @params);
#if DEBUG
			this.CheckErrors("GetUniformSubroutineuiv");
#endif
		}

		public void GetUniformuiv(uint program, int location, uint[] @params)
		{
			this._GetUniformuiv(program, location, @params);
#if DEBUG
			this.CheckErrors("GetUniformuiv");
#endif
		}

		public void GetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long[] param)
		{
			this._GetVertexArrayIndexed64iv(vaobj, index, pname, param);
#if DEBUG
			this.CheckErrors("GetVertexArrayIndexed64iv");
#endif
		}

		public void GetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int[] param)
		{
			this._GetVertexArrayIndexediv(vaobj, index, pname, param);
#if DEBUG
			this.CheckErrors("GetVertexArrayIndexediv");
#endif
		}

		public void GetVertexArrayiv(uint vaobj, uint pname, int[] param)
		{
			this._GetVertexArrayiv(vaobj, pname, param);
#if DEBUG
			this.CheckErrors("GetVertexArrayiv");
#endif
		}

		public void GetVertexAttribdv(uint index, uint pname, double[] @params)
		{
			this._GetVertexAttribdv(index, pname, @params);
#if DEBUG
			this.CheckErrors("GetVertexAttribdv");
#endif
		}

		public void GetVertexAttribfv(uint index, uint pname, float[] @params)
		{
			this._GetVertexAttribfv(index, pname, @params);
#if DEBUG
			this.CheckErrors("GetVertexAttribfv");
#endif
		}

		public void GetVertexAttribIiv(uint index, uint pname, int[] @params)
		{
			this._GetVertexAttribIiv(index, pname, @params);
#if DEBUG
			this.CheckErrors("GetVertexAttribIiv");
#endif
		}

		public void GetVertexAttribIuiv(uint index, uint pname, uint[] @params)
		{
			this._GetVertexAttribIuiv(index, pname, @params);
#if DEBUG
			this.CheckErrors("GetVertexAttribIuiv");
#endif
		}

		public void GetVertexAttribiv(uint index, uint pname, int[] @params)
		{
			this._GetVertexAttribiv(index, pname, @params);
#if DEBUG
			this.CheckErrors("GetVertexAttribiv");
#endif
		}

		public void GetVertexAttribLdv(uint index, uint pname, double[] @params)
		{
			this._GetVertexAttribLdv(index, pname, @params);
#if DEBUG
			this.CheckErrors("GetVertexAttribLdv");
#endif
		}

		public void GetVertexAttribPointerv(uint index, uint pname, IntPtr[] pointer)
		{
			this._GetVertexAttribPointerv(index, pname, pointer);
#if DEBUG
			this.CheckErrors("GetVertexAttribPointerv");
#endif
		}

		public void Hint(HintTarget target, HintMode mode)
		{
			this._Hint((uint)target, (uint)mode);
#if DEBUG
			this.CheckErrors("Hint");
#endif
		}

		public void Hint(uint target, uint mode)
		{
			this._Hint(target, mode);
#if DEBUG
			this.CheckErrors("Hint");
#endif
		}

		public void InvalidateBufferData(uint buffer)
		{
			this._InvalidateBufferData(buffer);
#if DEBUG
			this.CheckErrors("InvalidateBufferData");
#endif
		}

		public void InvalidateBufferSubData(uint buffer, int offset, int length)
		{
			this._InvalidateBufferSubData(buffer, offset, length);
#if DEBUG
			this.CheckErrors("InvalidateBufferSubData");
#endif
		}

		public void InvalidateFramebuffer(uint target, int numAttachments, uint[] attachments)
		{
			this._InvalidateFramebuffer(target, numAttachments, attachments);
#if DEBUG
			this.CheckErrors("InvalidateFramebuffer");
#endif
		}

		public void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint[] attachments)
		{
			this._InvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
#if DEBUG
			this.CheckErrors("InvalidateNamedFramebufferData");
#endif
		}

		public void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint[] attachments, int x, int y, int width, int height)
		{
			this._InvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
#if DEBUG
			this.CheckErrors("InvalidateNamedFramebufferSubData");
#endif
		}

		public void InvalidateSubFramebuffer(uint target, int numAttachments, uint[] attachments, int x, int y, int width, int height)
		{
			this._InvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
#if DEBUG
			this.CheckErrors("InvalidateSubFramebuffer");
#endif
		}

		public void InvalidateTexImage(uint texture, int level)
		{
			this._InvalidateTexImage(texture, level);
#if DEBUG
			this.CheckErrors("InvalidateTexImage");
#endif
		}

		public void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
		{
			this._InvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
#if DEBUG
			this.CheckErrors("InvalidateTexSubImage");
#endif
		}

		public bool IsBuffer(uint buffer)
		{
			var result = this._IsBuffer(buffer);
#if DEBUG
			this.CheckErrors("IsBuffer");
#endif
			return result;
		}

		public bool IsEnabled(EnableCap cap)
		{
			var result = this._IsEnabled((uint)cap);
#if DEBUG
			this.CheckErrors("IsEnabled");
#endif
			return result;
		}

		public bool IsEnabled(uint cap)
		{
			var result = this._IsEnabled(cap);
#if DEBUG
			this.CheckErrors("IsEnabled");
#endif
			return result;
		}

		public bool IsEnabledi(uint target, uint index)
		{
			var result = this._IsEnabledi(target, index);
#if DEBUG
			this.CheckErrors("IsEnabledi");
#endif
			return result;
		}

		public bool IsFramebuffer(uint framebuffer)
		{
			var result = this._IsFramebuffer(framebuffer);
#if DEBUG
			this.CheckErrors("IsFramebuffer");
#endif
			return result;
		}

		public bool IsProgram(uint program)
		{
			var result = this._IsProgram(program);
#if DEBUG
			this.CheckErrors("IsProgram");
#endif
			return result;
		}

		public bool IsProgramPipeline(uint pipeline)
		{
			var result = this._IsProgramPipeline(pipeline);
#if DEBUG
			this.CheckErrors("IsProgramPipeline");
#endif
			return result;
		}

		public bool IsQuery(uint id)
		{
			var result = this._IsQuery(id);
#if DEBUG
			this.CheckErrors("IsQuery");
#endif
			return result;
		}

		public bool IsRenderbuffer(uint renderbuffer)
		{
			var result = this._IsRenderbuffer(renderbuffer);
#if DEBUG
			this.CheckErrors("IsRenderbuffer");
#endif
			return result;
		}

		public bool IsSampler(uint sampler)
		{
			var result = this._IsSampler(sampler);
#if DEBUG
			this.CheckErrors("IsSampler");
#endif
			return result;
		}

		public bool IsShader(uint shader)
		{
			var result = this._IsShader(shader);
#if DEBUG
			this.CheckErrors("IsShader");
#endif
			return result;
		}

		public bool IsSync(IntPtr sync)
		{
			var result = this._IsSync(sync);
#if DEBUG
			this.CheckErrors("IsSync");
#endif
			return result;
		}

		public bool IsTexture(uint texture)
		{
			var result = this._IsTexture(texture);
#if DEBUG
			this.CheckErrors("IsTexture");
#endif
			return result;
		}

		public bool IsTransformFeedback(uint id)
		{
			var result = this._IsTransformFeedback(id);
#if DEBUG
			this.CheckErrors("IsTransformFeedback");
#endif
			return result;
		}

		public bool IsVertexArray(uint array)
		{
			var result = this._IsVertexArray(array);
#if DEBUG
			this.CheckErrors("IsVertexArray");
#endif
			return result;
		}

		public void LineWidth(float width)
		{
			this._LineWidth(width);
#if DEBUG
			this.CheckErrors("LineWidth");
#endif
		}

		public void LogicOp(LogicOp opcode)
		{
			this._LogicOp((uint)opcode);
#if DEBUG
			this.CheckErrors("LogicOp");
#endif
		}

		public void LogicOp(uint opcode)
		{
			this._LogicOp(opcode);
#if DEBUG
			this.CheckErrors("LogicOp");
#endif
		}

		public IntPtr MapBuffer(BufferTarget target, BufferAccess access)
		{
			var result = this._MapBuffer((uint)target, (uint)access);
#if DEBUG
			this.CheckErrors("MapBuffer");
#endif
			return result;
		}

		public IntPtr MapBuffer(uint target, uint access)
		{
			var result = this._MapBuffer(target, access);
#if DEBUG
			this.CheckErrors("MapBuffer");
#endif
			return result;
		}

		public IntPtr MapBufferRange(BufferTarget target, int offset, int length, uint access)
		{
			var result = this._MapBufferRange((uint)target, offset, length, access);
#if DEBUG
			this.CheckErrors("MapBufferRange");
#endif
			return result;
		}

		public IntPtr MapBufferRange(uint target, int offset, int length, uint access)
		{
			var result = this._MapBufferRange(target, offset, length, access);
#if DEBUG
			this.CheckErrors("MapBufferRange");
#endif
			return result;
		}

		public IntPtr MapNamedBuffer(uint buffer, uint access)
		{
			var result = this._MapNamedBuffer(buffer, access);
#if DEBUG
			this.CheckErrors("MapNamedBuffer");
#endif
			return result;
		}

		public IntPtr MapNamedBufferRange(uint buffer, int offset, int length, uint access)
		{
			var result = this._MapNamedBufferRange(buffer, offset, length, access);
#if DEBUG
			this.CheckErrors("MapNamedBufferRange");
#endif
			return result;
		}

		public void MemoryBarrier(uint barriers)
		{
			this._MemoryBarrier(barriers);
#if DEBUG
			this.CheckErrors("MemoryBarrier");
#endif
		}

		public void MemoryBarrierByRegion(uint barriers)
		{
			this._MemoryBarrierByRegion(barriers);
#if DEBUG
			this.CheckErrors("MemoryBarrierByRegion");
#endif
		}

		public void MinSampleShading(float value)
		{
			this._MinSampleShading(value);
#if DEBUG
			this.CheckErrors("MinSampleShading");
#endif
		}

		public void MultiDrawArrays(PrimitiveType mode, int[] first, int[] count, int drawcount)
		{
			this._MultiDrawArrays((uint)mode, first, count, drawcount);
#if DEBUG
			this.CheckErrors("MultiDrawArrays");
#endif
		}

		public void MultiDrawArrays(uint mode, int[] first, int[] count, int drawcount)
		{
			this._MultiDrawArrays(mode, first, count, drawcount);
#if DEBUG
			this.CheckErrors("MultiDrawArrays");
#endif
		}

		public void MultiDrawArraysIndirect(PrimitiveType mode, IntPtr indirect, int drawcount, int stride)
		{
			this._MultiDrawArraysIndirect((uint)mode, indirect, drawcount, stride);
#if DEBUG
			this.CheckErrors("MultiDrawArraysIndirect");
#endif
		}

		public void MultiDrawArraysIndirect(uint mode, IntPtr indirect, int drawcount, int stride)
		{
			this._MultiDrawArraysIndirect(mode, indirect, drawcount, stride);
#if DEBUG
			this.CheckErrors("MultiDrawArraysIndirect");
#endif
		}

		public void MultiDrawElements(PrimitiveType mode, int[] count, DrawElementsType type, IntPtr[] indices, int drawcount)
		{
			this._MultiDrawElements((uint)mode, count, (uint)type, indices, drawcount);
#if DEBUG
			this.CheckErrors("MultiDrawElements");
#endif
		}

		public void MultiDrawElements(uint mode, int[] count, uint type, IntPtr[] indices, int drawcount)
		{
			this._MultiDrawElements(mode, count, type, indices, drawcount);
#if DEBUG
			this.CheckErrors("MultiDrawElements");
#endif
		}

		public void MultiDrawElementsBaseVertex(PrimitiveType mode, int[] count, DrawElementsType type, IntPtr[] indices, int drawcount, int[] basevertex)
		{
			this._MultiDrawElementsBaseVertex((uint)mode, count, (uint)type, indices, drawcount, basevertex);
#if DEBUG
			this.CheckErrors("MultiDrawElementsBaseVertex");
#endif
		}

		public void MultiDrawElementsBaseVertex(uint mode, int[] count, uint type, IntPtr[] indices, int drawcount, int[] basevertex)
		{
			this._MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
#if DEBUG
			this.CheckErrors("MultiDrawElementsBaseVertex");
#endif
		}

		public void MultiDrawElementsIndirect(PrimitiveType mode, uint type, IntPtr indirect, int drawcount, int stride)
		{
			this._MultiDrawElementsIndirect((uint)mode, type, indirect, drawcount, stride);
#if DEBUG
			this.CheckErrors("MultiDrawElementsIndirect");
#endif
		}

		public void MultiDrawElementsIndirect(uint mode, uint type, IntPtr indirect, int drawcount, int stride)
		{
			this._MultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
#if DEBUG
			this.CheckErrors("MultiDrawElementsIndirect");
#endif
		}

		public void NamedBufferData(uint buffer, int size, IntPtr data, uint usage)
		{
			this._NamedBufferData(buffer, size, data, usage);
#if DEBUG
			this.CheckErrors("NamedBufferData");
#endif
		}

		public void NamedBufferStorage(uint buffer, int size, IntPtr data, uint flags)
		{
			this._NamedBufferStorage(buffer, size, data, flags);
#if DEBUG
			this.CheckErrors("NamedBufferStorage");
#endif
		}

		public void NamedBufferSubData(uint buffer, int offset, int size, IntPtr data)
		{
			this._NamedBufferSubData(buffer, offset, size, data);
#if DEBUG
			this.CheckErrors("NamedBufferSubData");
#endif
		}

		public void NamedFramebufferDrawBuffer(uint framebuffer, uint buf)
		{
			this._NamedFramebufferDrawBuffer(framebuffer, buf);
#if DEBUG
			this.CheckErrors("NamedFramebufferDrawBuffer");
#endif
		}

		public void NamedFramebufferDrawBuffers(uint framebuffer, int n, uint[] bufs)
		{
			this._NamedFramebufferDrawBuffers(framebuffer, n, bufs);
#if DEBUG
			this.CheckErrors("NamedFramebufferDrawBuffers");
#endif
		}

		public void NamedFramebufferParameteri(uint framebuffer, uint pname, int param)
		{
			this._NamedFramebufferParameteri(framebuffer, pname, param);
#if DEBUG
			this.CheckErrors("NamedFramebufferParameteri");
#endif
		}

		public void NamedFramebufferReadBuffer(uint framebuffer, uint src)
		{
			this._NamedFramebufferReadBuffer(framebuffer, src);
#if DEBUG
			this.CheckErrors("NamedFramebufferReadBuffer");
#endif
		}

		public void NamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			this._NamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
#if DEBUG
			this.CheckErrors("NamedFramebufferRenderbuffer");
#endif
		}

		public void NamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level)
		{
			this._NamedFramebufferTexture(framebuffer, attachment, texture, level);
#if DEBUG
			this.CheckErrors("NamedFramebufferTexture");
#endif
		}

		public void NamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer)
		{
			this._NamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
#if DEBUG
			this.CheckErrors("NamedFramebufferTextureLayer");
#endif
		}

		public void NamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height)
		{
			this._NamedRenderbufferStorage(renderbuffer, internalformat, width, height);
#if DEBUG
			this.CheckErrors("NamedRenderbufferStorage");
#endif
		}

		public void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height)
		{
			this._NamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
#if DEBUG
			this.CheckErrors("NamedRenderbufferStorageMultisample");
#endif
		}

		public void ObjectLabel(uint identifier, uint name, int length, string label)
		{
			this._ObjectLabel(identifier, name, length, label);
#if DEBUG
			this.CheckErrors("ObjectLabel");
#endif
		}

		public void ObjectPtrLabel(IntPtr ptr, int length, string label)
		{
			this._ObjectPtrLabel(ptr, length, label);
#if DEBUG
			this.CheckErrors("ObjectPtrLabel");
#endif
		}

		public void PatchParameterfv(uint pname, float[] values)
		{
			this._PatchParameterfv(pname, values);
#if DEBUG
			this.CheckErrors("PatchParameterfv");
#endif
		}

		public void PatchParameteri(uint pname, int value)
		{
			this._PatchParameteri(pname, value);
#if DEBUG
			this.CheckErrors("PatchParameteri");
#endif
		}

		public void PauseTransformFeedback()
		{
			this._PauseTransformFeedback();
#if DEBUG
			this.CheckErrors("PauseTransformFeedback");
#endif
		}

		public void PixelStoref(PixelStoreParameter pname, float param)
		{
			this._PixelStoref((uint)pname, param);
#if DEBUG
			this.CheckErrors("PixelStoref");
#endif
		}

		public void PixelStoref(uint pname, float param)
		{
			this._PixelStoref(pname, param);
#if DEBUG
			this.CheckErrors("PixelStoref");
#endif
		}

		public void PixelStorei(PixelStoreParameter pname, int param)
		{
			this._PixelStorei((uint)pname, param);
#if DEBUG
			this.CheckErrors("PixelStorei");
#endif
		}

		public void PixelStorei(uint pname, int param)
		{
			this._PixelStorei(pname, param);
#if DEBUG
			this.CheckErrors("PixelStorei");
#endif
		}

		public void PointParameterf(uint pname, float param)
		{
			this._PointParameterf(pname, param);
#if DEBUG
			this.CheckErrors("PointParameterf");
#endif
		}

		public void PointParameterfv(uint pname, float[] @params)
		{
			this._PointParameterfv(pname, @params);
#if DEBUG
			this.CheckErrors("PointParameterfv");
#endif
		}

		public void PointParameteri(uint pname, int param)
		{
			this._PointParameteri(pname, param);
#if DEBUG
			this.CheckErrors("PointParameteri");
#endif
		}

		public void PointParameteriv(uint pname, int[] @params)
		{
			this._PointParameteriv(pname, @params);
#if DEBUG
			this.CheckErrors("PointParameteriv");
#endif
		}

		public void PointSize(float size)
		{
			this._PointSize(size);
#if DEBUG
			this.CheckErrors("PointSize");
#endif
		}

		public void PolygonMode(MaterialFace face, PolygonMode mode)
		{
			this._PolygonMode((uint)face, (uint)mode);
#if DEBUG
			this.CheckErrors("PolygonMode");
#endif
		}

		public void PolygonMode(uint face, uint mode)
		{
			this._PolygonMode(face, mode);
#if DEBUG
			this.CheckErrors("PolygonMode");
#endif
		}

		public void PolygonOffset(float factor, float units)
		{
			this._PolygonOffset(factor, units);
#if DEBUG
			this.CheckErrors("PolygonOffset");
#endif
		}

		public void PopDebugGroup()
		{
			this._PopDebugGroup();
#if DEBUG
			this.CheckErrors("PopDebugGroup");
#endif
		}

		public void PrimitiveRestartIndex(uint index)
		{
			this._PrimitiveRestartIndex(index);
#if DEBUG
			this.CheckErrors("PrimitiveRestartIndex");
#endif
		}

		public void ProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length)
		{
			this._ProgramBinary(program, binaryFormat, binary, length);
#if DEBUG
			this.CheckErrors("ProgramBinary");
#endif
		}

		public void ProgramParameteri(uint program, uint pname, int value)
		{
			this._ProgramParameteri(program, pname, value);
#if DEBUG
			this.CheckErrors("ProgramParameteri");
#endif
		}

		public void ProgramUniform1d(uint program, int location, double v0)
		{
			this._ProgramUniform1d(program, location, v0);
#if DEBUG
			this.CheckErrors("ProgramUniform1d");
#endif
		}

		public void ProgramUniform1dv(uint program, int location, int count, double[] value)
		{
			this._ProgramUniform1dv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform1dv");
#endif
		}

		public void ProgramUniform1f(uint program, int location, float v0)
		{
			this._ProgramUniform1f(program, location, v0);
#if DEBUG
			this.CheckErrors("ProgramUniform1f");
#endif
		}

		public void ProgramUniform1fv(uint program, int location, int count, float[] value)
		{
			this._ProgramUniform1fv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform1fv");
#endif
		}

		public void ProgramUniform1i(uint program, int location, int v0)
		{
			this._ProgramUniform1i(program, location, v0);
#if DEBUG
			this.CheckErrors("ProgramUniform1i");
#endif
		}

		public void ProgramUniform1iv(uint program, int location, int count, int[] value)
		{
			this._ProgramUniform1iv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform1iv");
#endif
		}

		public void ProgramUniform1ui(uint program, int location, uint v0)
		{
			this._ProgramUniform1ui(program, location, v0);
#if DEBUG
			this.CheckErrors("ProgramUniform1ui");
#endif
		}

		public void ProgramUniform1uiv(uint program, int location, int count, uint[] value)
		{
			this._ProgramUniform1uiv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform1uiv");
#endif
		}

		public void ProgramUniform2d(uint program, int location, double v0, double v1)
		{
			this._ProgramUniform2d(program, location, v0, v1);
#if DEBUG
			this.CheckErrors("ProgramUniform2d");
#endif
		}

		public void ProgramUniform2dv(uint program, int location, int count, double[] value)
		{
			this._ProgramUniform2dv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform2dv");
#endif
		}

		public void ProgramUniform2f(uint program, int location, float v0, float v1)
		{
			this._ProgramUniform2f(program, location, v0, v1);
#if DEBUG
			this.CheckErrors("ProgramUniform2f");
#endif
		}

		public void ProgramUniform2fv(uint program, int location, int count, float[] value)
		{
			this._ProgramUniform2fv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform2fv");
#endif
		}

		public void ProgramUniform2i(uint program, int location, int v0, int v1)
		{
			this._ProgramUniform2i(program, location, v0, v1);
#if DEBUG
			this.CheckErrors("ProgramUniform2i");
#endif
		}

		public void ProgramUniform2iv(uint program, int location, int count, int[] value)
		{
			this._ProgramUniform2iv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform2iv");
#endif
		}

		public void ProgramUniform2ui(uint program, int location, uint v0, uint v1)
		{
			this._ProgramUniform2ui(program, location, v0, v1);
#if DEBUG
			this.CheckErrors("ProgramUniform2ui");
#endif
		}

		public void ProgramUniform2uiv(uint program, int location, int count, uint[] value)
		{
			this._ProgramUniform2uiv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform2uiv");
#endif
		}

		public void ProgramUniform3d(uint program, int location, double v0, double v1, double v2)
		{
			this._ProgramUniform3d(program, location, v0, v1, v2);
#if DEBUG
			this.CheckErrors("ProgramUniform3d");
#endif
		}

		public void ProgramUniform3dv(uint program, int location, int count, double[] value)
		{
			this._ProgramUniform3dv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform3dv");
#endif
		}

		public void ProgramUniform3f(uint program, int location, float v0, float v1, float v2)
		{
			this._ProgramUniform3f(program, location, v0, v1, v2);
#if DEBUG
			this.CheckErrors("ProgramUniform3f");
#endif
		}

		public void ProgramUniform3fv(uint program, int location, int count, float[] value)
		{
			this._ProgramUniform3fv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform3fv");
#endif
		}

		public void ProgramUniform3i(uint program, int location, int v0, int v1, int v2)
		{
			this._ProgramUniform3i(program, location, v0, v1, v2);
#if DEBUG
			this.CheckErrors("ProgramUniform3i");
#endif
		}

		public void ProgramUniform3iv(uint program, int location, int count, int[] value)
		{
			this._ProgramUniform3iv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform3iv");
#endif
		}

		public void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2)
		{
			this._ProgramUniform3ui(program, location, v0, v1, v2);
#if DEBUG
			this.CheckErrors("ProgramUniform3ui");
#endif
		}

		public void ProgramUniform3uiv(uint program, int location, int count, uint[] value)
		{
			this._ProgramUniform3uiv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform3uiv");
#endif
		}

		public void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3)
		{
			this._ProgramUniform4d(program, location, v0, v1, v2, v3);
#if DEBUG
			this.CheckErrors("ProgramUniform4d");
#endif
		}

		public void ProgramUniform4dv(uint program, int location, int count, double[] value)
		{
			this._ProgramUniform4dv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform4dv");
#endif
		}

		public void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3)
		{
			this._ProgramUniform4f(program, location, v0, v1, v2, v3);
#if DEBUG
			this.CheckErrors("ProgramUniform4f");
#endif
		}

		public void ProgramUniform4fv(uint program, int location, int count, float[] value)
		{
			this._ProgramUniform4fv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform4fv");
#endif
		}

		public void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3)
		{
			this._ProgramUniform4i(program, location, v0, v1, v2, v3);
#if DEBUG
			this.CheckErrors("ProgramUniform4i");
#endif
		}

		public void ProgramUniform4iv(uint program, int location, int count, int[] value)
		{
			this._ProgramUniform4iv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform4iv");
#endif
		}

		public void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			this._ProgramUniform4ui(program, location, v0, v1, v2, v3);
#if DEBUG
			this.CheckErrors("ProgramUniform4ui");
#endif
		}

		public void ProgramUniform4uiv(uint program, int location, int count, uint[] value)
		{
			this._ProgramUniform4uiv(program, location, count, value);
#if DEBUG
			this.CheckErrors("ProgramUniform4uiv");
#endif
		}

		public void ProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			this._ProgramUniformMatrix2dv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix2dv");
#endif
		}

		public void ProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			this._ProgramUniformMatrix2fv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix2fv");
#endif
		}

		public void ProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			this._ProgramUniformMatrix2x3dv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix2x3dv");
#endif
		}

		public void ProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			this._ProgramUniformMatrix2x3fv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix2x3fv");
#endif
		}

		public void ProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			this._ProgramUniformMatrix2x4dv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix2x4dv");
#endif
		}

		public void ProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			this._ProgramUniformMatrix2x4fv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix2x4fv");
#endif
		}

		public void ProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			this._ProgramUniformMatrix3dv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix3dv");
#endif
		}

		public void ProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			this._ProgramUniformMatrix3fv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix3fv");
#endif
		}

		public void ProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			this._ProgramUniformMatrix3x2dv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix3x2dv");
#endif
		}

		public void ProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			this._ProgramUniformMatrix3x2fv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix3x2fv");
#endif
		}

		public void ProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			this._ProgramUniformMatrix3x4dv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix3x4dv");
#endif
		}

		public void ProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			this._ProgramUniformMatrix3x4fv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix3x4fv");
#endif
		}

		public void ProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			this._ProgramUniformMatrix4dv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix4dv");
#endif
		}

		public void ProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			this._ProgramUniformMatrix4fv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix4fv");
#endif
		}

		public void ProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			this._ProgramUniformMatrix4x2dv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix4x2dv");
#endif
		}

		public void ProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			this._ProgramUniformMatrix4x2fv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix4x2fv");
#endif
		}

		public void ProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			this._ProgramUniformMatrix4x3dv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix4x3dv");
#endif
		}

		public void ProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			this._ProgramUniformMatrix4x3fv(program, location, count, transpose, value);
#if DEBUG
			this.CheckErrors("ProgramUniformMatrix4x3fv");
#endif
		}

		public void ProvokingVertex(uint mode)
		{
			this._ProvokingVertex(mode);
#if DEBUG
			this.CheckErrors("ProvokingVertex");
#endif
		}

		public void PushDebugGroup(uint source, uint id, int length, string message)
		{
			this._PushDebugGroup(source, id, length, message);
#if DEBUG
			this.CheckErrors("PushDebugGroup");
#endif
		}

		public void QueryCounter(uint id, uint target)
		{
			this._QueryCounter(id, target);
#if DEBUG
			this.CheckErrors("QueryCounter");
#endif
		}

		public void ReadBuffer(ReadBufferMode src)
		{
			this._ReadBuffer((uint)src);
#if DEBUG
			this.CheckErrors("ReadBuffer");
#endif
		}

		public void ReadBuffer(uint src)
		{
			this._ReadBuffer(src);
#if DEBUG
			this.CheckErrors("ReadBuffer");
#endif
		}

		public void ReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data)
		{
			this._ReadnPixels(x, y, width, height, format, type, bufSize, data);
#if DEBUG
			this.CheckErrors("ReadnPixels");
#endif
		}

		public void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			this._ReadPixels(x, y, width, height, (uint)format, (uint)type, pixels);
#if DEBUG
			this.CheckErrors("ReadPixels");
#endif
		}

		public void ReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels)
		{
			this._ReadPixels(x, y, width, height, format, type, pixels);
#if DEBUG
			this.CheckErrors("ReadPixels");
#endif
		}

		public void ReleaseShaderCompiler()
		{
			this._ReleaseShaderCompiler();
#if DEBUG
			this.CheckErrors("ReleaseShaderCompiler");
#endif
		}

		public void RenderbufferStorage(uint target, uint internalformat, int width, int height)
		{
			this._RenderbufferStorage(target, internalformat, width, height);
#if DEBUG
			this.CheckErrors("RenderbufferStorage");
#endif
		}

		public void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height)
		{
			this._RenderbufferStorageMultisample(target, samples, internalformat, width, height);
#if DEBUG
			this.CheckErrors("RenderbufferStorageMultisample");
#endif
		}

		public void ResumeTransformFeedback()
		{
			this._ResumeTransformFeedback();
#if DEBUG
			this.CheckErrors("ResumeTransformFeedback");
#endif
		}

		public void SampleCoverage(float value, bool invert)
		{
			this._SampleCoverage(value, invert);
#if DEBUG
			this.CheckErrors("SampleCoverage");
#endif
		}

		public void SampleMaski(uint maskNumber, uint mask)
		{
			this._SampleMaski(maskNumber, mask);
#if DEBUG
			this.CheckErrors("SampleMaski");
#endif
		}

		public void SamplerParameterf(uint sampler, uint pname, float param)
		{
			this._SamplerParameterf(sampler, pname, param);
#if DEBUG
			this.CheckErrors("SamplerParameterf");
#endif
		}

		public void SamplerParameterfv(uint sampler, uint pname, float[] param)
		{
			this._SamplerParameterfv(sampler, pname, param);
#if DEBUG
			this.CheckErrors("SamplerParameterfv");
#endif
		}

		public void SamplerParameteri(uint sampler, uint pname, int param)
		{
			this._SamplerParameteri(sampler, pname, param);
#if DEBUG
			this.CheckErrors("SamplerParameteri");
#endif
		}

		public void SamplerParameterIiv(uint sampler, uint pname, int[] param)
		{
			this._SamplerParameterIiv(sampler, pname, param);
#if DEBUG
			this.CheckErrors("SamplerParameterIiv");
#endif
		}

		public void SamplerParameterIuiv(uint sampler, uint pname, uint[] param)
		{
			this._SamplerParameterIuiv(sampler, pname, param);
#if DEBUG
			this.CheckErrors("SamplerParameterIuiv");
#endif
		}

		public void SamplerParameteriv(uint sampler, uint pname, int[] param)
		{
			this._SamplerParameteriv(sampler, pname, param);
#if DEBUG
			this.CheckErrors("SamplerParameteriv");
#endif
		}

		public void Scissor(int x, int y, int width, int height)
		{
			this._Scissor(x, y, width, height);
#if DEBUG
			this.CheckErrors("Scissor");
#endif
		}

		public void ScissorArrayv(uint first, int count, int[] v)
		{
			this._ScissorArrayv(first, count, v);
#if DEBUG
			this.CheckErrors("ScissorArrayv");
#endif
		}

		public void ScissorIndexed(uint index, int left, int bottom, int width, int height)
		{
			this._ScissorIndexed(index, left, bottom, width, height);
#if DEBUG
			this.CheckErrors("ScissorIndexed");
#endif
		}

		public void ScissorIndexedv(uint index, int[] v)
		{
			this._ScissorIndexedv(index, v);
#if DEBUG
			this.CheckErrors("ScissorIndexedv");
#endif
		}

		public void ShaderBinary(int count, uint[] shaders, uint binaryformat, IntPtr binary, int length)
		{
			this._ShaderBinary(count, shaders, binaryformat, binary, length);
#if DEBUG
			this.CheckErrors("ShaderBinary");
#endif
		}

		public void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
		{
			this._ShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
#if DEBUG
			this.CheckErrors("ShaderStorageBlockBinding");
#endif
		}

		public void StencilFunc(StencilFunction func, int @ref, uint mask)
		{
			this._StencilFunc((uint)func, @ref, mask);
#if DEBUG
			this.CheckErrors("StencilFunc");
#endif
		}

		public void StencilFunc(uint func, int @ref, uint mask)
		{
			this._StencilFunc(func, @ref, mask);
#if DEBUG
			this.CheckErrors("StencilFunc");
#endif
		}

		public void StencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int @ref, uint mask)
		{
			this._StencilFuncSeparate((uint)face, (uint)func, @ref, mask);
#if DEBUG
			this.CheckErrors("StencilFuncSeparate");
#endif
		}

		public void StencilFuncSeparate(uint face, uint func, int @ref, uint mask)
		{
			this._StencilFuncSeparate(face, func, @ref, mask);
#if DEBUG
			this.CheckErrors("StencilFuncSeparate");
#endif
		}

		public void StencilMask(uint mask)
		{
			this._StencilMask(mask);
#if DEBUG
			this.CheckErrors("StencilMask");
#endif
		}

		public void StencilMaskSeparate(StencilFaceDirection face, uint mask)
		{
			this._StencilMaskSeparate((uint)face, mask);
#if DEBUG
			this.CheckErrors("StencilMaskSeparate");
#endif
		}

		public void StencilMaskSeparate(uint face, uint mask)
		{
			this._StencilMaskSeparate(face, mask);
#if DEBUG
			this.CheckErrors("StencilMaskSeparate");
#endif
		}

		public void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			this._StencilOp((uint)fail, (uint)zfail, (uint)zpass);
#if DEBUG
			this.CheckErrors("StencilOp");
#endif
		}

		public void StencilOp(uint fail, uint zfail, uint zpass)
		{
			this._StencilOp(fail, zfail, zpass);
#if DEBUG
			this.CheckErrors("StencilOp");
#endif
		}

		public void StencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			this._StencilOpSeparate((uint)face, (uint)sfail, (uint)dpfail, (uint)dppass);
#if DEBUG
			this.CheckErrors("StencilOpSeparate");
#endif
		}

		public void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass)
		{
			this._StencilOpSeparate(face, sfail, dpfail, dppass);
#if DEBUG
			this.CheckErrors("StencilOpSeparate");
#endif
		}

		public void TexBuffer(TextureTarget target, uint internalformat, uint buffer)
		{
			this._TexBuffer((uint)target, internalformat, buffer);
#if DEBUG
			this.CheckErrors("TexBuffer");
#endif
		}

		public void TexBuffer(uint target, uint internalformat, uint buffer)
		{
			this._TexBuffer(target, internalformat, buffer);
#if DEBUG
			this.CheckErrors("TexBuffer");
#endif
		}

		public void TexBufferRange(uint target, uint internalformat, uint buffer, int offset, int size)
		{
			this._TexBufferRange(target, internalformat, buffer, offset, size);
#if DEBUG
			this.CheckErrors("TexBufferRange");
#endif
		}

		public void TexImage1D(TextureTarget target, int level, int internalformat, int width, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			this._TexImage1D((uint)target, level, internalformat, width, border, (uint)format, (uint)type, pixels);
#if DEBUG
			this.CheckErrors("TexImage1D");
#endif
		}

		public void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels)
		{
			this._TexImage1D(target, level, internalformat, width, border, format, type, pixels);
#if DEBUG
			this.CheckErrors("TexImage1D");
#endif
		}

		public void TexImage2D(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			this._TexImage2D((uint)target, level, internalformat, width, height, border, (uint)format, (uint)type, pixels);
#if DEBUG
			this.CheckErrors("TexImage2D");
#endif
		}

		public void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels)
		{
			this._TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
#if DEBUG
			this.CheckErrors("TexImage2D");
#endif
		}

		public void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			this._TexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
#if DEBUG
			this.CheckErrors("TexImage2DMultisample");
#endif
		}

		public void TexImage3D(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			this._TexImage3D((uint)target, level, internalformat, width, height, depth, border, (uint)format, (uint)type, pixels);
#if DEBUG
			this.CheckErrors("TexImage3D");
#endif
		}

		public void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels)
		{
			this._TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
#if DEBUG
			this.CheckErrors("TexImage3D");
#endif
		}

		public void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			this._TexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
#if DEBUG
			this.CheckErrors("TexImage3DMultisample");
#endif
		}

		public void TexParameterf(TextureTarget target, TextureParameterName pname, float param)
		{
			this._TexParameterf((uint)target, (uint)pname, param);
#if DEBUG
			this.CheckErrors("TexParameterf");
#endif
		}

		public void TexParameterf(uint target, uint pname, float param)
		{
			this._TexParameterf(target, pname, param);
#if DEBUG
			this.CheckErrors("TexParameterf");
#endif
		}

		public void TexParameterfv(TextureTarget target, TextureParameterName pname, float[] @params)
		{
			this._TexParameterfv((uint)target, (uint)pname, @params);
#if DEBUG
			this.CheckErrors("TexParameterfv");
#endif
		}

		public void TexParameterfv(uint target, uint pname, float[] @params)
		{
			this._TexParameterfv(target, pname, @params);
#if DEBUG
			this.CheckErrors("TexParameterfv");
#endif
		}

		public void TexParameteri(TextureTarget target, TextureParameterName pname, int param)
		{
			this._TexParameteri((uint)target, (uint)pname, param);
#if DEBUG
			this.CheckErrors("TexParameteri");
#endif
		}

		public void TexParameteri(uint target, uint pname, int param)
		{
			this._TexParameteri(target, pname, param);
#if DEBUG
			this.CheckErrors("TexParameteri");
#endif
		}

		public void TexParameterIiv(TextureTarget target, TextureParameterName pname, int[] @params)
		{
			this._TexParameterIiv((uint)target, (uint)pname, @params);
#if DEBUG
			this.CheckErrors("TexParameterIiv");
#endif
		}

		public void TexParameterIiv(uint target, uint pname, int[] @params)
		{
			this._TexParameterIiv(target, pname, @params);
#if DEBUG
			this.CheckErrors("TexParameterIiv");
#endif
		}

		public void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint[] @params)
		{
			this._TexParameterIuiv((uint)target, (uint)pname, @params);
#if DEBUG
			this.CheckErrors("TexParameterIuiv");
#endif
		}

		public void TexParameterIuiv(uint target, uint pname, uint[] @params)
		{
			this._TexParameterIuiv(target, pname, @params);
#if DEBUG
			this.CheckErrors("TexParameterIuiv");
#endif
		}

		public void TexParameteriv(TextureTarget target, TextureParameterName pname, int[] @params)
		{
			this._TexParameteriv((uint)target, (uint)pname, @params);
#if DEBUG
			this.CheckErrors("TexParameteriv");
#endif
		}

		public void TexParameteriv(uint target, uint pname, int[] @params)
		{
			this._TexParameteriv(target, pname, @params);
#if DEBUG
			this.CheckErrors("TexParameteriv");
#endif
		}

		public void TexStorage1D(uint target, int levels, uint internalformat, int width)
		{
			this._TexStorage1D(target, levels, internalformat, width);
#if DEBUG
			this.CheckErrors("TexStorage1D");
#endif
		}

		public void TexStorage2D(uint target, int levels, uint internalformat, int width, int height)
		{
			this._TexStorage2D(target, levels, internalformat, width, height);
#if DEBUG
			this.CheckErrors("TexStorage2D");
#endif
		}

		public void TexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			this._TexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
#if DEBUG
			this.CheckErrors("TexStorage2DMultisample");
#endif
		}

		public void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth)
		{
			this._TexStorage3D(target, levels, internalformat, width, height, depth);
#if DEBUG
			this.CheckErrors("TexStorage3D");
#endif
		}

		public void TexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			this._TexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
#if DEBUG
			this.CheckErrors("TexStorage3DMultisample");
#endif
		}

		public void TexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			this._TexSubImage1D((uint)target, level, xoffset, width, (uint)format, (uint)type, pixels);
#if DEBUG
			this.CheckErrors("TexSubImage1D");
#endif
		}

		public void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels)
		{
			this._TexSubImage1D(target, level, xoffset, width, format, type, pixels);
#if DEBUG
			this.CheckErrors("TexSubImage1D");
#endif
		}

		public void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			this._TexSubImage2D((uint)target, level, xoffset, yoffset, width, height, (uint)format, (uint)type, pixels);
#if DEBUG
			this.CheckErrors("TexSubImage2D");
#endif
		}

		public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels)
		{
			this._TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
#if DEBUG
			this.CheckErrors("TexSubImage2D");
#endif
		}

		public void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			this._TexSubImage3D((uint)target, level, xoffset, yoffset, zoffset, width, height, depth, (uint)format, (uint)type, pixels);
#if DEBUG
			this.CheckErrors("TexSubImage3D");
#endif
		}

		public void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels)
		{
			this._TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
#if DEBUG
			this.CheckErrors("TexSubImage3D");
#endif
		}

		public void TextureBarrier()
		{
			this._TextureBarrier();
#if DEBUG
			this.CheckErrors("TextureBarrier");
#endif
		}

		public void TextureBuffer(uint texture, uint internalformat, uint buffer)
		{
			this._TextureBuffer(texture, internalformat, buffer);
#if DEBUG
			this.CheckErrors("TextureBuffer");
#endif
		}

		public void TextureBufferRange(uint texture, uint internalformat, uint buffer, int offset, int size)
		{
			this._TextureBufferRange(texture, internalformat, buffer, offset, size);
#if DEBUG
			this.CheckErrors("TextureBufferRange");
#endif
		}

		public void TextureParameterf(uint texture, uint pname, float param)
		{
			this._TextureParameterf(texture, pname, param);
#if DEBUG
			this.CheckErrors("TextureParameterf");
#endif
		}

		public void TextureParameterfv(uint texture, uint pname, float[] param)
		{
			this._TextureParameterfv(texture, pname, param);
#if DEBUG
			this.CheckErrors("TextureParameterfv");
#endif
		}

		public void TextureParameteri(uint texture, uint pname, int param)
		{
			this._TextureParameteri(texture, pname, param);
#if DEBUG
			this.CheckErrors("TextureParameteri");
#endif
		}

		public void TextureParameterIiv(uint texture, uint pname, int[] @params)
		{
			this._TextureParameterIiv(texture, pname, @params);
#if DEBUG
			this.CheckErrors("TextureParameterIiv");
#endif
		}

		public void TextureParameterIuiv(uint texture, uint pname, uint[] @params)
		{
			this._TextureParameterIuiv(texture, pname, @params);
#if DEBUG
			this.CheckErrors("TextureParameterIuiv");
#endif
		}

		public void TextureParameteriv(uint texture, uint pname, int[] param)
		{
			this._TextureParameteriv(texture, pname, param);
#if DEBUG
			this.CheckErrors("TextureParameteriv");
#endif
		}

		public void TextureStorage1D(uint texture, int levels, uint internalformat, int width)
		{
			this._TextureStorage1D(texture, levels, internalformat, width);
#if DEBUG
			this.CheckErrors("TextureStorage1D");
#endif
		}

		public void TextureStorage2D(uint texture, int levels, uint internalformat, int width, int height)
		{
			this._TextureStorage2D(texture, levels, internalformat, width, height);
#if DEBUG
			this.CheckErrors("TextureStorage2D");
#endif
		}

		public void TextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			this._TextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
#if DEBUG
			this.CheckErrors("TextureStorage2DMultisample");
#endif
		}

		public void TextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth)
		{
			this._TextureStorage3D(texture, levels, internalformat, width, height, depth);
#if DEBUG
			this.CheckErrors("TextureStorage3D");
#endif
		}

		public void TextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			this._TextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
#if DEBUG
			this.CheckErrors("TextureStorage3DMultisample");
#endif
		}

		public void TextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels)
		{
			this._TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
#if DEBUG
			this.CheckErrors("TextureSubImage1D");
#endif
		}

		public void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels)
		{
			this._TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
#if DEBUG
			this.CheckErrors("TextureSubImage2D");
#endif
		}

		public void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels)
		{
			this._TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
#if DEBUG
			this.CheckErrors("TextureSubImage3D");
#endif
		}

		public void TextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			this._TextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
#if DEBUG
			this.CheckErrors("TextureView");
#endif
		}

		public void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer)
		{
			this._TransformFeedbackBufferBase(xfb, index, buffer);
#if DEBUG
			this.CheckErrors("TransformFeedbackBufferBase");
#endif
		}

		public void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size)
		{
			this._TransformFeedbackBufferRange(xfb, index, buffer, offset, size);
#if DEBUG
			this.CheckErrors("TransformFeedbackBufferRange");
#endif
		}

		public void TransformFeedbackVaryings(uint program, int count, string[] varyings, uint bufferMode)
		{
			this._TransformFeedbackVaryings(program, count, varyings, bufferMode);
#if DEBUG
			this.CheckErrors("TransformFeedbackVaryings");
#endif
		}

		public void Uniform1d(int location, double x)
		{
			this._Uniform1d(location, x);
#if DEBUG
			this.CheckErrors("Uniform1d");
#endif
		}

		public void Uniform1dv(int location, int count, double[] value)
		{
			this._Uniform1dv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform1dv");
#endif
		}

		public void Uniform1f(int location, float v0)
		{
			this._Uniform1f(location, v0);
#if DEBUG
			this.CheckErrors("Uniform1f");
#endif
		}

		public void Uniform1fv(int location, int count, float[] value)
		{
			this._Uniform1fv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform1fv");
#endif
		}

		public void Uniform1i(int location, int v0)
		{
			this._Uniform1i(location, v0);
#if DEBUG
			this.CheckErrors("Uniform1i");
#endif
		}

		public void Uniform1iv(int location, int count, int[] value)
		{
			this._Uniform1iv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform1iv");
#endif
		}

		public void Uniform1ui(int location, uint v0)
		{
			this._Uniform1ui(location, v0);
#if DEBUG
			this.CheckErrors("Uniform1ui");
#endif
		}

		public void Uniform1uiv(int location, int count, uint[] value)
		{
			this._Uniform1uiv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform1uiv");
#endif
		}

		public void Uniform2d(int location, double x, double y)
		{
			this._Uniform2d(location, x, y);
#if DEBUG
			this.CheckErrors("Uniform2d");
#endif
		}

		public void Uniform2dv(int location, int count, double[] value)
		{
			this._Uniform2dv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform2dv");
#endif
		}

		public void Uniform2f(int location, float v0, float v1)
		{
			this._Uniform2f(location, v0, v1);
#if DEBUG
			this.CheckErrors("Uniform2f");
#endif
		}

		public void Uniform2fv(int location, int count, float[] value)
		{
			this._Uniform2fv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform2fv");
#endif
		}

		public void Uniform2i(int location, int v0, int v1)
		{
			this._Uniform2i(location, v0, v1);
#if DEBUG
			this.CheckErrors("Uniform2i");
#endif
		}

		public void Uniform2iv(int location, int count, int[] value)
		{
			this._Uniform2iv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform2iv");
#endif
		}

		public void Uniform2ui(int location, uint v0, uint v1)
		{
			this._Uniform2ui(location, v0, v1);
#if DEBUG
			this.CheckErrors("Uniform2ui");
#endif
		}

		public void Uniform2uiv(int location, int count, uint[] value)
		{
			this._Uniform2uiv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform2uiv");
#endif
		}

		public void Uniform3d(int location, double x, double y, double z)
		{
			this._Uniform3d(location, x, y, z);
#if DEBUG
			this.CheckErrors("Uniform3d");
#endif
		}

		public void Uniform3dv(int location, int count, double[] value)
		{
			this._Uniform3dv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform3dv");
#endif
		}

		public void Uniform3f(int location, float v0, float v1, float v2)
		{
			this._Uniform3f(location, v0, v1, v2);
#if DEBUG
			this.CheckErrors("Uniform3f");
#endif
		}

		public void Uniform3fv(int location, int count, float[] value)
		{
			this._Uniform3fv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform3fv");
#endif
		}

		public void Uniform3i(int location, int v0, int v1, int v2)
		{
			this._Uniform3i(location, v0, v1, v2);
#if DEBUG
			this.CheckErrors("Uniform3i");
#endif
		}

		public void Uniform3iv(int location, int count, int[] value)
		{
			this._Uniform3iv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform3iv");
#endif
		}

		public void Uniform3ui(int location, uint v0, uint v1, uint v2)
		{
			this._Uniform3ui(location, v0, v1, v2);
#if DEBUG
			this.CheckErrors("Uniform3ui");
#endif
		}

		public void Uniform3uiv(int location, int count, uint[] value)
		{
			this._Uniform3uiv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform3uiv");
#endif
		}

		public void Uniform4d(int location, double x, double y, double z, double w)
		{
			this._Uniform4d(location, x, y, z, w);
#if DEBUG
			this.CheckErrors("Uniform4d");
#endif
		}

		public void Uniform4dv(int location, int count, double[] value)
		{
			this._Uniform4dv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform4dv");
#endif
		}

		public void Uniform4f(int location, float v0, float v1, float v2, float v3)
		{
			this._Uniform4f(location, v0, v1, v2, v3);
#if DEBUG
			this.CheckErrors("Uniform4f");
#endif
		}

		public void Uniform4fv(int location, int count, float[] value)
		{
			this._Uniform4fv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform4fv");
#endif
		}

		public void Uniform4i(int location, int v0, int v1, int v2, int v3)
		{
			this._Uniform4i(location, v0, v1, v2, v3);
#if DEBUG
			this.CheckErrors("Uniform4i");
#endif
		}

		public void Uniform4iv(int location, int count, int[] value)
		{
			this._Uniform4iv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform4iv");
#endif
		}

		public void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3)
		{
			this._Uniform4ui(location, v0, v1, v2, v3);
#if DEBUG
			this.CheckErrors("Uniform4ui");
#endif
		}

		public void Uniform4uiv(int location, int count, uint[] value)
		{
			this._Uniform4uiv(location, count, value);
#if DEBUG
			this.CheckErrors("Uniform4uiv");
#endif
		}

		public void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
			this._UniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
#if DEBUG
			this.CheckErrors("UniformBlockBinding");
#endif
		}

		public void UniformMatrix2dv(int location, int count, bool transpose, double[] value)
		{
			this._UniformMatrix2dv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix2dv");
#endif
		}

		public void UniformMatrix2fv(int location, int count, bool transpose, float[] value)
		{
			this._UniformMatrix2fv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix2fv");
#endif
		}

		public void UniformMatrix2x3dv(int location, int count, bool transpose, double[] value)
		{
			this._UniformMatrix2x3dv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix2x3dv");
#endif
		}

		public void UniformMatrix2x3fv(int location, int count, bool transpose, float[] value)
		{
			this._UniformMatrix2x3fv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix2x3fv");
#endif
		}

		public void UniformMatrix2x4dv(int location, int count, bool transpose, double[] value)
		{
			this._UniformMatrix2x4dv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix2x4dv");
#endif
		}

		public void UniformMatrix2x4fv(int location, int count, bool transpose, float[] value)
		{
			this._UniformMatrix2x4fv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix2x4fv");
#endif
		}

		public void UniformMatrix3dv(int location, int count, bool transpose, double[] value)
		{
			this._UniformMatrix3dv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix3dv");
#endif
		}

		public void UniformMatrix3fv(int location, int count, bool transpose, float[] value)
		{
			this._UniformMatrix3fv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix3fv");
#endif
		}

		public void UniformMatrix3x2dv(int location, int count, bool transpose, double[] value)
		{
			this._UniformMatrix3x2dv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix3x2dv");
#endif
		}

		public void UniformMatrix3x2fv(int location, int count, bool transpose, float[] value)
		{
			this._UniformMatrix3x2fv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix3x2fv");
#endif
		}

		public void UniformMatrix3x4dv(int location, int count, bool transpose, double[] value)
		{
			this._UniformMatrix3x4dv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix3x4dv");
#endif
		}

		public void UniformMatrix3x4fv(int location, int count, bool transpose, float[] value)
		{
			this._UniformMatrix3x4fv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix3x4fv");
#endif
		}

		public void UniformMatrix4dv(int location, int count, bool transpose, double[] value)
		{
			this._UniformMatrix4dv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix4dv");
#endif
		}

		public void UniformMatrix4fv(int location, int count, bool transpose, ref float value)
		{
			this._UniformMatrix4fv(location, count, transpose, ref value);
#if DEBUG
			this.CheckErrors("UniformMatrix4fv");
#endif
		}

		public void UniformMatrix4x2dv(int location, int count, bool transpose, double[] value)
		{
			this._UniformMatrix4x2dv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix4x2dv");
#endif
		}

		public void UniformMatrix4x2fv(int location, int count, bool transpose, float[] value)
		{
			this._UniformMatrix4x2fv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix4x2fv");
#endif
		}

		public void UniformMatrix4x3dv(int location, int count, bool transpose, double[] value)
		{
			this._UniformMatrix4x3dv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix4x3dv");
#endif
		}

		public void UniformMatrix4x3fv(int location, int count, bool transpose, float[] value)
		{
			this._UniformMatrix4x3fv(location, count, transpose, value);
#if DEBUG
			this.CheckErrors("UniformMatrix4x3fv");
#endif
		}

		public void UniformSubroutinesuiv(uint shadertype, int count, uint[] indices)
		{
			this._UniformSubroutinesuiv(shadertype, count, indices);
#if DEBUG
			this.CheckErrors("UniformSubroutinesuiv");
#endif
		}

		public bool UnmapBuffer(BufferTarget target)
		{
			var result = this._UnmapBuffer((uint)target);
#if DEBUG
			this.CheckErrors("UnmapBuffer");
#endif
			return result;
		}

		public bool UnmapBuffer(uint target)
		{
			var result = this._UnmapBuffer(target);
#if DEBUG
			this.CheckErrors("UnmapBuffer");
#endif
			return result;
		}

		public bool UnmapNamedBuffer(uint buffer)
		{
			var result = this._UnmapNamedBuffer(buffer);
#if DEBUG
			this.CheckErrors("UnmapNamedBuffer");
#endif
			return result;
		}

		public void UseProgram(uint program)
		{
			this._UseProgram(program);
#if DEBUG
			this.CheckErrors("UseProgram");
#endif
		}

		public void UseProgramStages(uint pipeline, uint stages, uint program)
		{
			this._UseProgramStages(pipeline, stages, program);
#if DEBUG
			this.CheckErrors("UseProgramStages");
#endif
		}

		public void ValidateProgram(uint program)
		{
			this._ValidateProgram(program);
#if DEBUG
			this.CheckErrors("ValidateProgram");
#endif
		}

		public void ValidateProgramPipeline(uint pipeline)
		{
			this._ValidateProgramPipeline(pipeline);
#if DEBUG
			this.CheckErrors("ValidateProgramPipeline");
#endif
		}

		public void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex)
		{
			this._VertexArrayAttribBinding(vaobj, attribindex, bindingindex);
#if DEBUG
			this.CheckErrors("VertexArrayAttribBinding");
#endif
		}

		public void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			this._VertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
#if DEBUG
			this.CheckErrors("VertexArrayAttribFormat");
#endif
		}

		public void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			this._VertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
#if DEBUG
			this.CheckErrors("VertexArrayAttribIFormat");
#endif
		}

		public void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			this._VertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
#if DEBUG
			this.CheckErrors("VertexArrayAttribLFormat");
#endif
		}

		public void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor)
		{
			this._VertexArrayBindingDivisor(vaobj, bindingindex, divisor);
#if DEBUG
			this.CheckErrors("VertexArrayBindingDivisor");
#endif
		}

		public void VertexArrayElementBuffer(uint vaobj, uint buffer)
		{
			this._VertexArrayElementBuffer(vaobj, buffer);
#if DEBUG
			this.CheckErrors("VertexArrayElementBuffer");
#endif
		}

		public void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride)
		{
			this._VertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
#if DEBUG
			this.CheckErrors("VertexArrayVertexBuffer");
#endif
		}

		public void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint[] buffers, int[] offsets, int[] strides)
		{
			this._VertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
#if DEBUG
			this.CheckErrors("VertexArrayVertexBuffers");
#endif
		}

		public void VertexAttrib1d(uint index, double x)
		{
			this._VertexAttrib1d(index, x);
#if DEBUG
			this.CheckErrors("VertexAttrib1d");
#endif
		}

		public void VertexAttrib1dv(uint index, double[] v)
		{
			this._VertexAttrib1dv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib1dv");
#endif
		}

		public void VertexAttrib1f(uint index, float x)
		{
			this._VertexAttrib1f(index, x);
#if DEBUG
			this.CheckErrors("VertexAttrib1f");
#endif
		}

		public void VertexAttrib1fv(uint index, float[] v)
		{
			this._VertexAttrib1fv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib1fv");
#endif
		}

		public void VertexAttrib1s(uint index, short x)
		{
			this._VertexAttrib1s(index, x);
#if DEBUG
			this.CheckErrors("VertexAttrib1s");
#endif
		}

		public void VertexAttrib1sv(uint index, short[] v)
		{
			this._VertexAttrib1sv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib1sv");
#endif
		}

		public void VertexAttrib2d(uint index, double x, double y)
		{
			this._VertexAttrib2d(index, x, y);
#if DEBUG
			this.CheckErrors("VertexAttrib2d");
#endif
		}

		public void VertexAttrib2dv(uint index, double[] v)
		{
			this._VertexAttrib2dv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib2dv");
#endif
		}

		public void VertexAttrib2f(uint index, float x, float y)
		{
			this._VertexAttrib2f(index, x, y);
#if DEBUG
			this.CheckErrors("VertexAttrib2f");
#endif
		}

		public void VertexAttrib2fv(uint index, float[] v)
		{
			this._VertexAttrib2fv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib2fv");
#endif
		}

		public void VertexAttrib2s(uint index, short x, short y)
		{
			this._VertexAttrib2s(index, x, y);
#if DEBUG
			this.CheckErrors("VertexAttrib2s");
#endif
		}

		public void VertexAttrib2sv(uint index, short[] v)
		{
			this._VertexAttrib2sv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib2sv");
#endif
		}

		public void VertexAttrib3d(uint index, double x, double y, double z)
		{
			this._VertexAttrib3d(index, x, y, z);
#if DEBUG
			this.CheckErrors("VertexAttrib3d");
#endif
		}

		public void VertexAttrib3dv(uint index, double[] v)
		{
			this._VertexAttrib3dv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib3dv");
#endif
		}

		public void VertexAttrib3f(uint index, float x, float y, float z)
		{
			this._VertexAttrib3f(index, x, y, z);
#if DEBUG
			this.CheckErrors("VertexAttrib3f");
#endif
		}

		public void VertexAttrib3fv(uint index, float[] v)
		{
			this._VertexAttrib3fv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib3fv");
#endif
		}

		public void VertexAttrib3s(uint index, short x, short y, short z)
		{
			this._VertexAttrib3s(index, x, y, z);
#if DEBUG
			this.CheckErrors("VertexAttrib3s");
#endif
		}

		public void VertexAttrib3sv(uint index, short[] v)
		{
			this._VertexAttrib3sv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib3sv");
#endif
		}

		public void VertexAttrib4bv(uint index, sbyte[] v)
		{
			this._VertexAttrib4bv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4bv");
#endif
		}

		public void VertexAttrib4d(uint index, double x, double y, double z, double w)
		{
			this._VertexAttrib4d(index, x, y, z, w);
#if DEBUG
			this.CheckErrors("VertexAttrib4d");
#endif
		}

		public void VertexAttrib4dv(uint index, double[] v)
		{
			this._VertexAttrib4dv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4dv");
#endif
		}

		public void VertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			this._VertexAttrib4f(index, x, y, z, w);
#if DEBUG
			this.CheckErrors("VertexAttrib4f");
#endif
		}

		public void VertexAttrib4fv(uint index, float[] v)
		{
			this._VertexAttrib4fv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4fv");
#endif
		}

		public void VertexAttrib4iv(uint index, int[] v)
		{
			this._VertexAttrib4iv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4iv");
#endif
		}

		public void VertexAttrib4Nbv(uint index, sbyte[] v)
		{
			this._VertexAttrib4Nbv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4Nbv");
#endif
		}

		public void VertexAttrib4Niv(uint index, int[] v)
		{
			this._VertexAttrib4Niv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4Niv");
#endif
		}

		public void VertexAttrib4Nsv(uint index, short[] v)
		{
			this._VertexAttrib4Nsv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4Nsv");
#endif
		}

		public void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w)
		{
			this._VertexAttrib4Nub(index, x, y, z, w);
#if DEBUG
			this.CheckErrors("VertexAttrib4Nub");
#endif
		}

		public void VertexAttrib4Nubv(uint index, byte[] v)
		{
			this._VertexAttrib4Nubv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4Nubv");
#endif
		}

		public void VertexAttrib4Nuiv(uint index, uint[] v)
		{
			this._VertexAttrib4Nuiv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4Nuiv");
#endif
		}

		public void VertexAttrib4Nusv(uint index, ushort[] v)
		{
			this._VertexAttrib4Nusv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4Nusv");
#endif
		}

		public void VertexAttrib4s(uint index, short x, short y, short z, short w)
		{
			this._VertexAttrib4s(index, x, y, z, w);
#if DEBUG
			this.CheckErrors("VertexAttrib4s");
#endif
		}

		public void VertexAttrib4sv(uint index, short[] v)
		{
			this._VertexAttrib4sv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4sv");
#endif
		}

		public void VertexAttrib4ubv(uint index, byte[] v)
		{
			this._VertexAttrib4ubv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4ubv");
#endif
		}

		public void VertexAttrib4uiv(uint index, uint[] v)
		{
			this._VertexAttrib4uiv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4uiv");
#endif
		}

		public void VertexAttrib4usv(uint index, ushort[] v)
		{
			this._VertexAttrib4usv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttrib4usv");
#endif
		}

		public void VertexAttribBinding(uint attribindex, uint bindingindex)
		{
			this._VertexAttribBinding(attribindex, bindingindex);
#if DEBUG
			this.CheckErrors("VertexAttribBinding");
#endif
		}

		public void VertexAttribDivisor(uint index, uint divisor)
		{
			this._VertexAttribDivisor(index, divisor);
#if DEBUG
			this.CheckErrors("VertexAttribDivisor");
#endif
		}

		public void VertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			this._VertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
#if DEBUG
			this.CheckErrors("VertexAttribFormat");
#endif
		}

		public void VertexAttribI1i(uint index, int x)
		{
			this._VertexAttribI1i(index, x);
#if DEBUG
			this.CheckErrors("VertexAttribI1i");
#endif
		}

		public void VertexAttribI1iv(uint index, int[] v)
		{
			this._VertexAttribI1iv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI1iv");
#endif
		}

		public void VertexAttribI1ui(uint index, uint x)
		{
			this._VertexAttribI1ui(index, x);
#if DEBUG
			this.CheckErrors("VertexAttribI1ui");
#endif
		}

		public void VertexAttribI1uiv(uint index, uint[] v)
		{
			this._VertexAttribI1uiv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI1uiv");
#endif
		}

		public void VertexAttribI2i(uint index, int x, int y)
		{
			this._VertexAttribI2i(index, x, y);
#if DEBUG
			this.CheckErrors("VertexAttribI2i");
#endif
		}

		public void VertexAttribI2iv(uint index, int[] v)
		{
			this._VertexAttribI2iv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI2iv");
#endif
		}

		public void VertexAttribI2ui(uint index, uint x, uint y)
		{
			this._VertexAttribI2ui(index, x, y);
#if DEBUG
			this.CheckErrors("VertexAttribI2ui");
#endif
		}

		public void VertexAttribI2uiv(uint index, uint[] v)
		{
			this._VertexAttribI2uiv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI2uiv");
#endif
		}

		public void VertexAttribI3i(uint index, int x, int y, int z)
		{
			this._VertexAttribI3i(index, x, y, z);
#if DEBUG
			this.CheckErrors("VertexAttribI3i");
#endif
		}

		public void VertexAttribI3iv(uint index, int[] v)
		{
			this._VertexAttribI3iv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI3iv");
#endif
		}

		public void VertexAttribI3ui(uint index, uint x, uint y, uint z)
		{
			this._VertexAttribI3ui(index, x, y, z);
#if DEBUG
			this.CheckErrors("VertexAttribI3ui");
#endif
		}

		public void VertexAttribI3uiv(uint index, uint[] v)
		{
			this._VertexAttribI3uiv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI3uiv");
#endif
		}

		public void VertexAttribI4bv(uint index, sbyte[] v)
		{
			this._VertexAttribI4bv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI4bv");
#endif
		}

		public void VertexAttribI4i(uint index, int x, int y, int z, int w)
		{
			this._VertexAttribI4i(index, x, y, z, w);
#if DEBUG
			this.CheckErrors("VertexAttribI4i");
#endif
		}

		public void VertexAttribI4iv(uint index, int[] v)
		{
			this._VertexAttribI4iv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI4iv");
#endif
		}

		public void VertexAttribI4sv(uint index, short[] v)
		{
			this._VertexAttribI4sv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI4sv");
#endif
		}

		public void VertexAttribI4ubv(uint index, byte[] v)
		{
			this._VertexAttribI4ubv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI4ubv");
#endif
		}

		public void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
			this._VertexAttribI4ui(index, x, y, z, w);
#if DEBUG
			this.CheckErrors("VertexAttribI4ui");
#endif
		}

		public void VertexAttribI4uiv(uint index, uint[] v)
		{
			this._VertexAttribI4uiv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI4uiv");
#endif
		}

		public void VertexAttribI4usv(uint index, ushort[] v)
		{
			this._VertexAttribI4usv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribI4usv");
#endif
		}

		public void VertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			this._VertexAttribIFormat(attribindex, size, type, relativeoffset);
#if DEBUG
			this.CheckErrors("VertexAttribIFormat");
#endif
		}

		public void VertexAttribIPointer(uint index, int size, uint type, int stride, IntPtr pointer)
		{
			this._VertexAttribIPointer(index, size, type, stride, pointer);
#if DEBUG
			this.CheckErrors("VertexAttribIPointer");
#endif
		}

		public void VertexAttribL1d(uint index, double x)
		{
			this._VertexAttribL1d(index, x);
#if DEBUG
			this.CheckErrors("VertexAttribL1d");
#endif
		}

		public void VertexAttribL1dv(uint index, double[] v)
		{
			this._VertexAttribL1dv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribL1dv");
#endif
		}

		public void VertexAttribL2d(uint index, double x, double y)
		{
			this._VertexAttribL2d(index, x, y);
#if DEBUG
			this.CheckErrors("VertexAttribL2d");
#endif
		}

		public void VertexAttribL2dv(uint index, double[] v)
		{
			this._VertexAttribL2dv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribL2dv");
#endif
		}

		public void VertexAttribL3d(uint index, double x, double y, double z)
		{
			this._VertexAttribL3d(index, x, y, z);
#if DEBUG
			this.CheckErrors("VertexAttribL3d");
#endif
		}

		public void VertexAttribL3dv(uint index, double[] v)
		{
			this._VertexAttribL3dv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribL3dv");
#endif
		}

		public void VertexAttribL4d(uint index, double x, double y, double z, double w)
		{
			this._VertexAttribL4d(index, x, y, z, w);
#if DEBUG
			this.CheckErrors("VertexAttribL4d");
#endif
		}

		public void VertexAttribL4dv(uint index, double[] v)
		{
			this._VertexAttribL4dv(index, v);
#if DEBUG
			this.CheckErrors("VertexAttribL4dv");
#endif
		}

		public void VertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			this._VertexAttribLFormat(attribindex, size, type, relativeoffset);
#if DEBUG
			this.CheckErrors("VertexAttribLFormat");
#endif
		}

		public void VertexAttribLPointer(uint index, int size, uint type, int stride, IntPtr pointer)
		{
			this._VertexAttribLPointer(index, size, type, stride, pointer);
#if DEBUG
			this.CheckErrors("VertexAttribLPointer");
#endif
		}

		public void VertexAttribP1ui(uint index, uint type, bool normalized, uint value)
		{
			this._VertexAttribP1ui(index, type, normalized, value);
#if DEBUG
			this.CheckErrors("VertexAttribP1ui");
#endif
		}

		public void VertexAttribP1uiv(uint index, uint type, bool normalized, uint[] value)
		{
			this._VertexAttribP1uiv(index, type, normalized, value);
#if DEBUG
			this.CheckErrors("VertexAttribP1uiv");
#endif
		}

		public void VertexAttribP2ui(uint index, uint type, bool normalized, uint value)
		{
			this._VertexAttribP2ui(index, type, normalized, value);
#if DEBUG
			this.CheckErrors("VertexAttribP2ui");
#endif
		}

		public void VertexAttribP2uiv(uint index, uint type, bool normalized, uint[] value)
		{
			this._VertexAttribP2uiv(index, type, normalized, value);
#if DEBUG
			this.CheckErrors("VertexAttribP2uiv");
#endif
		}

		public void VertexAttribP3ui(uint index, uint type, bool normalized, uint value)
		{
			this._VertexAttribP3ui(index, type, normalized, value);
#if DEBUG
			this.CheckErrors("VertexAttribP3ui");
#endif
		}

		public void VertexAttribP3uiv(uint index, uint type, bool normalized, uint[] value)
		{
			this._VertexAttribP3uiv(index, type, normalized, value);
#if DEBUG
			this.CheckErrors("VertexAttribP3uiv");
#endif
		}

		public void VertexAttribP4ui(uint index, uint type, bool normalized, uint value)
		{
			this._VertexAttribP4ui(index, type, normalized, value);
#if DEBUG
			this.CheckErrors("VertexAttribP4ui");
#endif
		}

		public void VertexAttribP4uiv(uint index, uint type, bool normalized, uint[] value)
		{
			this._VertexAttribP4uiv(index, type, normalized, value);
#if DEBUG
			this.CheckErrors("VertexAttribP4uiv");
#endif
		}

		public void VertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer)
		{
			this._VertexAttribPointer(index, size, type, normalized, stride, pointer);
#if DEBUG
			this.CheckErrors("VertexAttribPointer");
#endif
		}

		public void VertexBindingDivisor(uint bindingindex, uint divisor)
		{
			this._VertexBindingDivisor(bindingindex, divisor);
#if DEBUG
			this.CheckErrors("VertexBindingDivisor");
#endif
		}

		public void Viewport(int x, int y, int width, int height)
		{
			this._Viewport(x, y, width, height);
#if DEBUG
			this.CheckErrors("Viewport");
#endif
		}

		public void ViewportArrayv(uint first, int count, float[] v)
		{
			this._ViewportArrayv(first, count, v);
#if DEBUG
			this.CheckErrors("ViewportArrayv");
#endif
		}

		public void ViewportIndexedf(uint index, float x, float y, float w, float h)
		{
			this._ViewportIndexedf(index, x, y, w, h);
#if DEBUG
			this.CheckErrors("ViewportIndexedf");
#endif
		}

		public void ViewportIndexedfv(uint index, float[] v)
		{
			this._ViewportIndexedfv(index, v);
#if DEBUG
			this.CheckErrors("ViewportIndexedfv");
#endif
		}

		public void WaitSync(IntPtr sync, uint flags, ulong timeout)
		{
			this._WaitSync(sync, flags, timeout);
#if DEBUG
			this.CheckErrors("WaitSync");
#endif
		}

	}
}
