using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GLDotNet
{
	public static class GL
	{
		public const uint GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
		public const uint GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
		public const uint GL_ACTIVE_ATTRIBUTES = 0x8B89;
		public const uint GL_ACTIVE_PROGRAM = 0x8259;
		public const uint GL_ACTIVE_RESOURCES = 0x92F5;
		public const uint GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
		public const uint GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
		public const uint GL_ACTIVE_SUBROUTINES = 0x8DE5;
		public const uint GL_ACTIVE_TEXTURE = 0x84E0;
		public const uint GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
		public const uint GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
		public const uint GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
		public const uint GL_ACTIVE_UNIFORMS = 0x8B86;
		public const uint GL_ACTIVE_VARIABLES = 0x9305;
		public const uint GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
		public const uint GL_ALL_BARRIER_BITS = 0xFFFFFFFF;
		public const uint GL_ALL_SHADER_BITS = 0xFFFFFFFF;
		public const uint GL_ALPHA = 0x1906;
		public const uint GL_ALREADY_SIGNALED = 0x911A;
		public const uint GL_ALWAYS = 0x0207;
		public const uint GL_AND = 0x1501;
		public const uint GL_AND_INVERTED = 0x1504;
		public const uint GL_AND_REVERSE = 0x1502;
		public const uint GL_ANY_SAMPLES_PASSED = 0x8C2F;
		public const uint GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
		public const uint GL_ARRAY_BUFFER = 0x8892;
		public const uint GL_ARRAY_BUFFER_BINDING = 0x8894;
		public const uint GL_ARRAY_SIZE = 0x92FB;
		public const uint GL_ARRAY_STRIDE = 0x92FE;
		public const uint GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
		public const uint GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
		public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
		public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
		public const uint GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
		public const uint GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
		public const uint GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
		public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
		public const uint GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
		public const uint GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;
		public const uint GL_ATTACHED_SHADERS = 0x8B85;
		public const uint GL_AUTO_GENERATE_MIPMAP = 0x8295;
		public const uint GL_BACK = 0x0405;
		public const uint GL_BACK_LEFT = 0x0402;
		public const uint GL_BACK_RIGHT = 0x0403;
		public const uint GL_BGR = 0x80E0;
		public const uint GL_BGR_INTEGER = 0x8D9A;
		public const uint GL_BGRA = 0x80E1;
		public const uint GL_BGRA_INTEGER = 0x8D9B;
		public const uint GL_BLEND = 0x0BE2;
		public const uint GL_BLEND_DST = 0x0BE0;
		public const uint GL_BLEND_DST_ALPHA = 0x80CA;
		public const uint GL_BLEND_DST_RGB = 0x80C8;
		public const uint GL_BLEND_EQUATION_ALPHA = 0x883D;
		public const uint GL_BLEND_EQUATION_RGB = 0x8009;
		public const uint GL_BLEND_SRC = 0x0BE1;
		public const uint GL_BLEND_SRC_ALPHA = 0x80CB;
		public const uint GL_BLEND_SRC_RGB = 0x80C9;
		public const uint GL_BLOCK_INDEX = 0x92FD;
		public const uint GL_BLUE = 0x1905;
		public const uint GL_BLUE_INTEGER = 0x8D96;
		public const uint GL_BOOL = 0x8B56;
		public const uint GL_BOOL_VEC2 = 0x8B57;
		public const uint GL_BOOL_VEC3 = 0x8B58;
		public const uint GL_BOOL_VEC4 = 0x8B59;
		public const uint GL_BUFFER = 0x82E0;
		public const uint GL_BUFFER_ACCESS = 0x88BB;
		public const uint GL_BUFFER_ACCESS_FLAGS = 0x911F;
		public const uint GL_BUFFER_BINDING = 0x9302;
		public const uint GL_BUFFER_DATA_SIZE = 0x9303;
		public const uint GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
		public const uint GL_BUFFER_MAP_LENGTH = 0x9120;
		public const uint GL_BUFFER_MAP_OFFSET = 0x9121;
		public const uint GL_BUFFER_MAP_POINTER = 0x88BD;
		public const uint GL_BUFFER_MAPPED = 0x88BC;
		public const uint GL_BUFFER_SIZE = 0x8764;
		public const uint GL_BUFFER_STORAGE_FLAGS = 0x8220;
		public const uint GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
		public const uint GL_BUFFER_USAGE = 0x8765;
		public const uint GL_BUFFER_VARIABLE = 0x92E5;
		public const uint GL_BYTE = 0x1400;
		public const uint GL_CAVEAT_SUPPORT = 0x82B8;
		public const uint GL_CCW = 0x0901;
		public const uint GL_CLAMP_READ_COLOR = 0x891C;
		public const uint GL_CLAMP_TO_BORDER = 0x812D;
		public const uint GL_CLAMP_TO_EDGE = 0x812F;
		public const uint GL_CLEAR = 0x1500;
		public const uint GL_CLEAR_BUFFER = 0x82B4;
		public const uint GL_CLEAR_TEXTURE = 0x9365;
		public const uint GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
		public const uint GL_CLIENT_STORAGE_BIT = 0x0200;
		public const uint GL_CLIP_DEPTH_MODE = 0x935D;
		public const uint GL_CLIP_DISTANCE0 = 0x3000;
		public const uint GL_CLIP_DISTANCE1 = 0x3001;
		public const uint GL_CLIP_DISTANCE2 = 0x3002;
		public const uint GL_CLIP_DISTANCE3 = 0x3003;
		public const uint GL_CLIP_DISTANCE4 = 0x3004;
		public const uint GL_CLIP_DISTANCE5 = 0x3005;
		public const uint GL_CLIP_DISTANCE6 = 0x3006;
		public const uint GL_CLIP_DISTANCE7 = 0x3007;
		public const uint GL_CLIP_ORIGIN = 0x935C;
		public const uint GL_COLOR = 0x1800;
		public const uint GL_COLOR_ATTACHMENT0 = 0x8CE0;
		public const uint GL_COLOR_ATTACHMENT1 = 0x8CE1;
		public const uint GL_COLOR_ATTACHMENT10 = 0x8CEA;
		public const uint GL_COLOR_ATTACHMENT11 = 0x8CEB;
		public const uint GL_COLOR_ATTACHMENT12 = 0x8CEC;
		public const uint GL_COLOR_ATTACHMENT13 = 0x8CED;
		public const uint GL_COLOR_ATTACHMENT14 = 0x8CEE;
		public const uint GL_COLOR_ATTACHMENT15 = 0x8CEF;
		public const uint GL_COLOR_ATTACHMENT16 = 0x8CF0;
		public const uint GL_COLOR_ATTACHMENT17 = 0x8CF1;
		public const uint GL_COLOR_ATTACHMENT18 = 0x8CF2;
		public const uint GL_COLOR_ATTACHMENT19 = 0x8CF3;
		public const uint GL_COLOR_ATTACHMENT2 = 0x8CE2;
		public const uint GL_COLOR_ATTACHMENT20 = 0x8CF4;
		public const uint GL_COLOR_ATTACHMENT21 = 0x8CF5;
		public const uint GL_COLOR_ATTACHMENT22 = 0x8CF6;
		public const uint GL_COLOR_ATTACHMENT23 = 0x8CF7;
		public const uint GL_COLOR_ATTACHMENT24 = 0x8CF8;
		public const uint GL_COLOR_ATTACHMENT25 = 0x8CF9;
		public const uint GL_COLOR_ATTACHMENT26 = 0x8CFA;
		public const uint GL_COLOR_ATTACHMENT27 = 0x8CFB;
		public const uint GL_COLOR_ATTACHMENT28 = 0x8CFC;
		public const uint GL_COLOR_ATTACHMENT29 = 0x8CFD;
		public const uint GL_COLOR_ATTACHMENT3 = 0x8CE3;
		public const uint GL_COLOR_ATTACHMENT30 = 0x8CFE;
		public const uint GL_COLOR_ATTACHMENT31 = 0x8CFF;
		public const uint GL_COLOR_ATTACHMENT4 = 0x8CE4;
		public const uint GL_COLOR_ATTACHMENT5 = 0x8CE5;
		public const uint GL_COLOR_ATTACHMENT6 = 0x8CE6;
		public const uint GL_COLOR_ATTACHMENT7 = 0x8CE7;
		public const uint GL_COLOR_ATTACHMENT8 = 0x8CE8;
		public const uint GL_COLOR_ATTACHMENT9 = 0x8CE9;
		public const uint GL_COLOR_BUFFER_BIT = 0x00004000;
		public const uint GL_COLOR_CLEAR_VALUE = 0x0C22;
		public const uint GL_COLOR_COMPONENTS = 0x8283;
		public const uint GL_COLOR_ENCODING = 0x8296;
		public const uint GL_COLOR_LOGIC_OP = 0x0BF2;
		public const uint GL_COLOR_RENDERABLE = 0x8286;
		public const uint GL_COLOR_WRITEMASK = 0x0C23;
		public const uint GL_COMMAND_BARRIER_BIT = 0x00000040;
		public const uint GL_COMPARE_REF_TO_TEXTURE = 0x884E;
		public const uint GL_COMPATIBLE_SUBROUTINES = 0x8E4B;
		public const uint GL_COMPILE_STATUS = 0x8B81;
		public const uint GL_COMPRESSED_R11_EAC = 0x9270;
		public const uint GL_COMPRESSED_RED = 0x8225;
		public const uint GL_COMPRESSED_RED_RGTC1 = 0x8DBB;
		public const uint GL_COMPRESSED_RG = 0x8226;
		public const uint GL_COMPRESSED_RG_RGTC2 = 0x8DBD;
		public const uint GL_COMPRESSED_RG11_EAC = 0x9272;
		public const uint GL_COMPRESSED_RGB = 0x84ED;
		public const uint GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;
		public const uint GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;
		public const uint GL_COMPRESSED_RGB8_ETC2 = 0x9274;
		public const uint GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
		public const uint GL_COMPRESSED_RGBA = 0x84EE;
		public const uint GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;
		public const uint GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
		public const uint GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
		public const uint GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
		public const uint GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
		public const uint GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
		public const uint GL_COMPRESSED_SRGB = 0x8C48;
		public const uint GL_COMPRESSED_SRGB_ALPHA = 0x8C49;
		public const uint GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;
		public const uint GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
		public const uint GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
		public const uint GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
		public const uint GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		public const uint GL_COMPUTE_SHADER = 0x91B9;
		public const uint GL_COMPUTE_SHADER_BIT = 0x00000020;
		public const uint GL_COMPUTE_SUBROUTINE = 0x92ED;
		public const uint GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
		public const uint GL_COMPUTE_TEXTURE = 0x82A0;
		public const uint GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
		public const uint GL_CONDITION_SATISFIED = 0x911C;
		public const uint GL_CONSTANT_ALPHA = 0x8003;
		public const uint GL_CONSTANT_COLOR = 0x8001;
		public const uint GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
		public const uint GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001;
		public const uint GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
		public const uint GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
		public const uint GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
		public const uint GL_CONTEXT_FLAGS = 0x821E;
		public const uint GL_CONTEXT_LOST = 0x0507;
		public const uint GL_CONTEXT_PROFILE_MASK = 0x9126;
		public const uint GL_CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
		public const uint GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
		public const uint GL_COPY = 0x1503;
		public const uint GL_COPY_INVERTED = 0x150C;
		public const uint GL_COPY_READ_BUFFER = 0x8F36;
		public const uint GL_COPY_READ_BUFFER_BINDING = 0x8F36;
		public const uint GL_COPY_WRITE_BUFFER = 0x8F37;
		public const uint GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;
		public const uint GL_CULL_FACE = 0x0B44;
		public const uint GL_CULL_FACE_MODE = 0x0B45;
		public const uint GL_CURRENT_PROGRAM = 0x8B8D;
		public const uint GL_CURRENT_QUERY = 0x8865;
		public const uint GL_CURRENT_VERTEX_ATTRIB = 0x8626;
		public const uint GL_CW = 0x0900;
		public const uint GL_DEBUG_CALLBACK_FUNCTION = 0x8244;
		public const uint GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;
		public const uint GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;
		public const uint GL_DEBUG_LOGGED_MESSAGES = 0x9145;
		public const uint GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
		public const uint GL_DEBUG_OUTPUT = 0x92E0;
		public const uint GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
		public const uint GL_DEBUG_SEVERITY_HIGH = 0x9146;
		public const uint GL_DEBUG_SEVERITY_LOW = 0x9148;
		public const uint GL_DEBUG_SEVERITY_MEDIUM = 0x9147;
		public const uint GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;
		public const uint GL_DEBUG_SOURCE_API = 0x8246;
		public const uint GL_DEBUG_SOURCE_APPLICATION = 0x824A;
		public const uint GL_DEBUG_SOURCE_OTHER = 0x824B;
		public const uint GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
		public const uint GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;
		public const uint GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
		public const uint GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
		public const uint GL_DEBUG_TYPE_ERROR = 0x824C;
		public const uint GL_DEBUG_TYPE_MARKER = 0x8268;
		public const uint GL_DEBUG_TYPE_OTHER = 0x8251;
		public const uint GL_DEBUG_TYPE_PERFORMANCE = 0x8250;
		public const uint GL_DEBUG_TYPE_POP_GROUP = 0x826A;
		public const uint GL_DEBUG_TYPE_PORTABILITY = 0x824F;
		public const uint GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;
		public const uint GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
		public const uint GL_DECR = 0x1E03;
		public const uint GL_DECR_WRAP = 0x8508;
		public const uint GL_DELETE_STATUS = 0x8B80;
		public const uint GL_DEPTH = 0x1801;
		public const uint GL_DEPTH_ATTACHMENT = 0x8D00;
		public const uint GL_DEPTH_BUFFER_BIT = 0x00000100;
		public const uint GL_DEPTH_CLAMP = 0x864F;
		public const uint GL_DEPTH_CLEAR_VALUE = 0x0B73;
		public const uint GL_DEPTH_COMPONENT = 0x1902;
		public const uint GL_DEPTH_COMPONENT16 = 0x81A5;
		public const uint GL_DEPTH_COMPONENT24 = 0x81A6;
		public const uint GL_DEPTH_COMPONENT32 = 0x81A7;
		public const uint GL_DEPTH_COMPONENT32F = 0x8CAC;
		public const uint GL_DEPTH_COMPONENTS = 0x8284;
		public const uint GL_DEPTH_FUNC = 0x0B74;
		public const uint GL_DEPTH_RANGE = 0x0B70;
		public const uint GL_DEPTH_RENDERABLE = 0x8287;
		public const uint GL_DEPTH_STENCIL = 0x84F9;
		public const uint GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
		public const uint GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
		public const uint GL_DEPTH_TEST = 0x0B71;
		public const uint GL_DEPTH_WRITEMASK = 0x0B72;
		public const uint GL_DEPTH24_STENCIL8 = 0x88F0;
		public const uint GL_DEPTH32F_STENCIL8 = 0x8CAD;
		public const uint GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
		public const uint GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
		public const uint GL_DITHER = 0x0BD0;
		public const uint GL_DONT_CARE = 0x1100;
		public const uint GL_DOUBLE = 0x140A;
		public const uint GL_DOUBLE_MAT2 = 0x8F46;
		public const uint GL_DOUBLE_MAT2x3 = 0x8F49;
		public const uint GL_DOUBLE_MAT2x4 = 0x8F4A;
		public const uint GL_DOUBLE_MAT3 = 0x8F47;
		public const uint GL_DOUBLE_MAT3x2 = 0x8F4B;
		public const uint GL_DOUBLE_MAT3x4 = 0x8F4C;
		public const uint GL_DOUBLE_MAT4 = 0x8F48;
		public const uint GL_DOUBLE_MAT4x2 = 0x8F4D;
		public const uint GL_DOUBLE_MAT4x3 = 0x8F4E;
		public const uint GL_DOUBLE_VEC2 = 0x8FFC;
		public const uint GL_DOUBLE_VEC3 = 0x8FFD;
		public const uint GL_DOUBLE_VEC4 = 0x8FFE;
		public const uint GL_DOUBLEBUFFER = 0x0C32;
		public const uint GL_DRAW_BUFFER = 0x0C01;
		public const uint GL_DRAW_BUFFER0 = 0x8825;
		public const uint GL_DRAW_BUFFER1 = 0x8826;
		public const uint GL_DRAW_BUFFER10 = 0x882F;
		public const uint GL_DRAW_BUFFER11 = 0x8830;
		public const uint GL_DRAW_BUFFER12 = 0x8831;
		public const uint GL_DRAW_BUFFER13 = 0x8832;
		public const uint GL_DRAW_BUFFER14 = 0x8833;
		public const uint GL_DRAW_BUFFER15 = 0x8834;
		public const uint GL_DRAW_BUFFER2 = 0x8827;
		public const uint GL_DRAW_BUFFER3 = 0x8828;
		public const uint GL_DRAW_BUFFER4 = 0x8829;
		public const uint GL_DRAW_BUFFER5 = 0x882A;
		public const uint GL_DRAW_BUFFER6 = 0x882B;
		public const uint GL_DRAW_BUFFER7 = 0x882C;
		public const uint GL_DRAW_BUFFER8 = 0x882D;
		public const uint GL_DRAW_BUFFER9 = 0x882E;
		public const uint GL_DRAW_FRAMEBUFFER = 0x8CA9;
		public const uint GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
		public const uint GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
		public const uint GL_DST_ALPHA = 0x0304;
		public const uint GL_DST_COLOR = 0x0306;
		public const uint GL_DYNAMIC_COPY = 0x88EA;
		public const uint GL_DYNAMIC_DRAW = 0x88E8;
		public const uint GL_DYNAMIC_READ = 0x88E9;
		public const uint GL_DYNAMIC_STORAGE_BIT = 0x0100;
		public const uint GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
		public const uint GL_ELEMENT_ARRAY_BUFFER = 0x8893;
		public const uint GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
		public const uint GL_EQUAL = 0x0202;
		public const uint GL_EQUIV = 0x1509;
		public const uint GL_EXTENSIONS = 0x1F03;
		public const uint GL_FALSE = 0;
		public const uint GL_FASTEST = 0x1101;
		public const uint GL_FILL = 0x1B02;
		public const uint GL_FILTER = 0x829A;
		public const uint GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
		public const uint GL_FIXED = 0x140C;
		public const uint GL_FIXED_ONLY = 0x891D;
		public const uint GL_FLOAT = 0x1406;
		public const uint GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
		public const uint GL_FLOAT_MAT2 = 0x8B5A;
		public const uint GL_FLOAT_MAT2x3 = 0x8B65;
		public const uint GL_FLOAT_MAT2x4 = 0x8B66;
		public const uint GL_FLOAT_MAT3 = 0x8B5B;
		public const uint GL_FLOAT_MAT3x2 = 0x8B67;
		public const uint GL_FLOAT_MAT3x4 = 0x8B68;
		public const uint GL_FLOAT_MAT4 = 0x8B5C;
		public const uint GL_FLOAT_MAT4x2 = 0x8B69;
		public const uint GL_FLOAT_MAT4x3 = 0x8B6A;
		public const uint GL_FLOAT_VEC2 = 0x8B50;
		public const uint GL_FLOAT_VEC3 = 0x8B51;
		public const uint GL_FLOAT_VEC4 = 0x8B52;
		public const uint GL_FRACTIONAL_EVEN = 0x8E7C;
		public const uint GL_FRACTIONAL_ODD = 0x8E7B;
		public const uint GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
		public const uint GL_FRAGMENT_SHADER = 0x8B30;
		public const uint GL_FRAGMENT_SHADER_BIT = 0x00000002;
		public const uint GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
		public const uint GL_FRAGMENT_SUBROUTINE = 0x92EC;
		public const uint GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
		public const uint GL_FRAGMENT_TEXTURE = 0x829F;
		public const uint GL_FRAMEBUFFER = 0x8D40;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
		public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		public const uint GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400;
		public const uint GL_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint GL_FRAMEBUFFER_BLEND = 0x828B;
		public const uint GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
		public const uint GL_FRAMEBUFFER_DEFAULT = 0x8218;
		public const uint GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
		public const uint GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
		public const uint GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
		public const uint GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
		public const uint GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
		public const uint GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
		public const uint GL_FRAMEBUFFER_RENDERABLE = 0x8289;
		public const uint GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
		public const uint GL_FRAMEBUFFER_SRGB = 0x8DB9;
		public const uint GL_FRAMEBUFFER_UNDEFINED = 0x8219;
		public const uint GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		public const uint GL_FRONT = 0x0404;
		public const uint GL_FRONT_AND_BACK = 0x0408;
		public const uint GL_FRONT_FACE = 0x0B46;
		public const uint GL_FRONT_LEFT = 0x0400;
		public const uint GL_FRONT_RIGHT = 0x0401;
		public const uint GL_FULL_SUPPORT = 0x82B7;
		public const uint GL_FUNC_ADD = 0x8006;
		public const uint GL_FUNC_REVERSE_SUBTRACT = 0x800B;
		public const uint GL_FUNC_SUBTRACT = 0x800A;
		public const uint GL_GEOMETRY_INPUT_TYPE = 0x8917;
		public const uint GL_GEOMETRY_OUTPUT_TYPE = 0x8918;
		public const uint GL_GEOMETRY_SHADER = 0x8DD9;
		public const uint GL_GEOMETRY_SHADER_BIT = 0x00000004;
		public const uint GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
		public const uint GL_GEOMETRY_SUBROUTINE = 0x92EB;
		public const uint GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
		public const uint GL_GEOMETRY_TEXTURE = 0x829E;
		public const uint GL_GEOMETRY_VERTICES_OUT = 0x8916;
		public const uint GL_GEQUAL = 0x0206;
		public const uint GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291;
		public const uint GL_GET_TEXTURE_IMAGE_TYPE = 0x8292;
		public const uint GL_GREATER = 0x0204;
		public const uint GL_GREEN = 0x1904;
		public const uint GL_GREEN_INTEGER = 0x8D95;
		public const uint GL_GUILTY_CONTEXT_RESET = 0x8253;
		public const uint GL_HALF_FLOAT = 0x140B;
		public const uint GL_HIGH_FLOAT = 0x8DF2;
		public const uint GL_HIGH_INT = 0x8DF5;
		public const uint GL_IMAGE_1D = 0x904C;
		public const uint GL_IMAGE_1D_ARRAY = 0x9052;
		public const uint GL_IMAGE_2D = 0x904D;
		public const uint GL_IMAGE_2D_ARRAY = 0x9053;
		public const uint GL_IMAGE_2D_MULTISAMPLE = 0x9055;
		public const uint GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
		public const uint GL_IMAGE_2D_RECT = 0x904F;
		public const uint GL_IMAGE_3D = 0x904E;
		public const uint GL_IMAGE_BINDING_ACCESS = 0x8F3E;
		public const uint GL_IMAGE_BINDING_FORMAT = 0x906E;
		public const uint GL_IMAGE_BINDING_LAYER = 0x8F3D;
		public const uint GL_IMAGE_BINDING_LAYERED = 0x8F3C;
		public const uint GL_IMAGE_BINDING_LEVEL = 0x8F3B;
		public const uint GL_IMAGE_BINDING_NAME = 0x8F3A;
		public const uint GL_IMAGE_BUFFER = 0x9051;
		public const uint GL_IMAGE_CLASS_1_X_16 = 0x82BE;
		public const uint GL_IMAGE_CLASS_1_X_32 = 0x82BB;
		public const uint GL_IMAGE_CLASS_1_X_8 = 0x82C1;
		public const uint GL_IMAGE_CLASS_10_10_10_2 = 0x82C3;
		public const uint GL_IMAGE_CLASS_11_11_10 = 0x82C2;
		public const uint GL_IMAGE_CLASS_2_X_16 = 0x82BD;
		public const uint GL_IMAGE_CLASS_2_X_32 = 0x82BA;
		public const uint GL_IMAGE_CLASS_2_X_8 = 0x82C0;
		public const uint GL_IMAGE_CLASS_4_X_16 = 0x82BC;
		public const uint GL_IMAGE_CLASS_4_X_32 = 0x82B9;
		public const uint GL_IMAGE_CLASS_4_X_8 = 0x82BF;
		public const uint GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8;
		public const uint GL_IMAGE_CUBE = 0x9050;
		public const uint GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
		public const uint GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
		public const uint GL_IMAGE_PIXEL_FORMAT = 0x82A9;
		public const uint GL_IMAGE_PIXEL_TYPE = 0x82AA;
		public const uint GL_IMAGE_TEXEL_SIZE = 0x82A7;
		public const uint GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
		public const uint GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
		public const uint GL_INCR = 0x1E02;
		public const uint GL_INCR_WRAP = 0x8507;
		public const uint GL_INFO_LOG_LENGTH = 0x8B84;
		public const uint GL_INNOCENT_CONTEXT_RESET = 0x8254;
		public const uint GL_INT = 0x1404;
		public const uint GL_INT_2_10_10_10_REV = 0x8D9F;
		public const uint GL_INT_IMAGE_1D = 0x9057;
		public const uint GL_INT_IMAGE_1D_ARRAY = 0x905D;
		public const uint GL_INT_IMAGE_2D = 0x9058;
		public const uint GL_INT_IMAGE_2D_ARRAY = 0x905E;
		public const uint GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060;
		public const uint GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
		public const uint GL_INT_IMAGE_2D_RECT = 0x905A;
		public const uint GL_INT_IMAGE_3D = 0x9059;
		public const uint GL_INT_IMAGE_BUFFER = 0x905C;
		public const uint GL_INT_IMAGE_CUBE = 0x905B;
		public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
		public const uint GL_INT_SAMPLER_1D = 0x8DC9;
		public const uint GL_INT_SAMPLER_1D_ARRAY = 0x8DCE;
		public const uint GL_INT_SAMPLER_2D = 0x8DCA;
		public const uint GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
		public const uint GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
		public const uint GL_INT_SAMPLER_2D_RECT = 0x8DCD;
		public const uint GL_INT_SAMPLER_3D = 0x8DCB;
		public const uint GL_INT_SAMPLER_BUFFER = 0x8DD0;
		public const uint GL_INT_SAMPLER_CUBE = 0x8DCC;
		public const uint GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
		public const uint GL_INT_VEC2 = 0x8B53;
		public const uint GL_INT_VEC3 = 0x8B54;
		public const uint GL_INT_VEC4 = 0x8B55;
		public const uint GL_INTERLEAVED_ATTRIBS = 0x8C8C;
		public const uint GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274;
		public const uint GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B;
		public const uint GL_INTERNALFORMAT_BLUE_SIZE = 0x8273;
		public const uint GL_INTERNALFORMAT_BLUE_TYPE = 0x827A;
		public const uint GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275;
		public const uint GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C;
		public const uint GL_INTERNALFORMAT_GREEN_SIZE = 0x8272;
		public const uint GL_INTERNALFORMAT_GREEN_TYPE = 0x8279;
		public const uint GL_INTERNALFORMAT_PREFERRED = 0x8270;
		public const uint GL_INTERNALFORMAT_RED_SIZE = 0x8271;
		public const uint GL_INTERNALFORMAT_RED_TYPE = 0x8278;
		public const uint GL_INTERNALFORMAT_SHARED_SIZE = 0x8277;
		public const uint GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276;
		public const uint GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D;
		public const uint GL_INTERNALFORMAT_SUPPORTED = 0x826F;
		public const uint GL_INVALID_ENUM = 0x0500;
		public const uint GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		public const uint GL_INVALID_INDEX = 0xFFFFFFFFu;
		public const uint GL_INVALID_OPERATION = 0x0502;
		public const uint GL_INVALID_VALUE = 0x0501;
		public const uint GL_INVERT = 0x150A;
		public const uint GL_IS_PER_PATCH = 0x92E7;
		public const uint GL_IS_ROW_MAJOR = 0x9300;
		public const uint GL_ISOLINES = 0x8E7A;
		public const uint GL_KEEP = 0x1E00;
		public const uint GL_LAST_VERTEX_CONVENTION = 0x8E4E;
		public const uint GL_LAYER_PROVOKING_VERTEX = 0x825E;
		public const uint GL_LEFT = 0x0406;
		public const uint GL_LEQUAL = 0x0203;
		public const uint GL_LESS = 0x0201;
		public const uint GL_LINE = 0x1B01;
		public const uint GL_LINE_LOOP = 0x0002;
		public const uint GL_LINE_SMOOTH = 0x0B20;
		public const uint GL_LINE_SMOOTH_HINT = 0x0C52;
		public const uint GL_LINE_STRIP = 0x0003;
		public const uint GL_LINE_STRIP_ADJACENCY = 0x000B;
		public const uint GL_LINE_WIDTH = 0x0B21;
		public const uint GL_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const uint GL_LINE_WIDTH_RANGE = 0x0B22;
		public const uint GL_LINEAR = 0x2601;
		public const uint GL_LINEAR_MIPMAP_LINEAR = 0x2703;
		public const uint GL_LINEAR_MIPMAP_NEAREST = 0x2701;
		public const uint GL_LINES = 0x0001;
		public const uint GL_LINES_ADJACENCY = 0x000A;
		public const uint GL_LINK_STATUS = 0x8B82;
		public const uint GL_LOCATION = 0x930E;
		public const uint GL_LOCATION_COMPONENT = 0x934A;
		public const uint GL_LOCATION_INDEX = 0x930F;
		public const uint GL_LOGIC_OP_MODE = 0x0BF0;
		public const uint GL_LOSE_CONTEXT_ON_RESET = 0x8252;
		public const uint GL_LOW_FLOAT = 0x8DF0;
		public const uint GL_LOW_INT = 0x8DF3;
		public const uint GL_LOWER_LEFT = 0x8CA1;
		public const uint GL_MAJOR_VERSION = 0x821B;
		public const uint GL_MANUAL_GENERATE_MIPMAP = 0x8294;
		public const uint GL_MAP_COHERENT_BIT = 0x0080;
		public const uint GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
		public const uint GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
		public const uint GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
		public const uint GL_MAP_PERSISTENT_BIT = 0x0040;
		public const uint GL_MAP_READ_BIT = 0x0001;
		public const uint GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
		public const uint GL_MAP_WRITE_BIT = 0x0002;
		public const uint GL_MATRIX_STRIDE = 0x92FF;
		public const uint GL_MAX = 0x8008;
		public const uint GL_MAX_3D_TEXTURE_SIZE = 0x8073;
		public const uint GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
		public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
		public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
		public const uint GL_MAX_CLIP_DISTANCES = 0x0D32;
		public const uint GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
		public const uint GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
		public const uint GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
		public const uint GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
		public const uint GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
		public const uint GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
		public const uint GL_MAX_COMBINED_DIMENSIONS = 0x8282;
		public const uint GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
		public const uint GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
		public const uint GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
		public const uint GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
		public const uint GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
		public const uint GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
		public const uint GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
		public const uint GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
		public const uint GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
		public const uint GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
		public const uint GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
		public const uint GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
		public const uint GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
		public const uint GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
		public const uint GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
		public const uint GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
		public const uint GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
		public const uint GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
		public const uint GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
		public const uint GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
		public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		public const uint GL_MAX_CULL_DISTANCES = 0x82F9;
		public const uint GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
		public const uint GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
		public const uint GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
		public const uint GL_MAX_DEPTH = 0x8280;
		public const uint GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
		public const uint GL_MAX_DRAW_BUFFERS = 0x8824;
		public const uint GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
		public const uint GL_MAX_ELEMENT_INDEX = 0x8D6B;
		public const uint GL_MAX_ELEMENTS_INDICES = 0x80E9;
		public const uint GL_MAX_ELEMENTS_VERTICES = 0x80E8;
		public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
		public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
		public const uint GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
		public const uint GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
		public const uint GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
		public const uint GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
		public const uint GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
		public const uint GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
		public const uint GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
		public const uint GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
		public const uint GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
		public const uint GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
		public const uint GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
		public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
		public const uint GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
		public const uint GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
		public const uint GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
		public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
		public const uint GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
		public const uint GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
		public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
		public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
		public const uint GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
		public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
		public const uint GL_MAX_HEIGHT = 0x827F;
		public const uint GL_MAX_IMAGE_SAMPLES = 0x906D;
		public const uint GL_MAX_IMAGE_UNITS = 0x8F38;
		public const uint GL_MAX_INTEGER_SAMPLES = 0x9110;
		public const uint GL_MAX_LABEL_LENGTH = 0x82E8;
		public const uint GL_MAX_LAYERS = 0x8281;
		public const uint GL_MAX_NAME_LENGTH = 0x92F6;
		public const uint GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
		public const uint GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
		public const uint GL_MAX_PATCH_VERTICES = 0x8E7D;
		public const uint GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
		public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
		public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
		public const uint GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
		public const uint GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
		public const uint GL_MAX_SAMPLES = 0x8D57;
		public const uint GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
		public const uint GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
		public const uint GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
		public const uint GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
		public const uint GL_MAX_SUBROUTINES = 0x8DE7;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
		public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
		public const uint GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
		public const uint GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
		public const uint GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
		public const uint GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
		public const uint GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
		public const uint GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
		public const uint GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
		public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
		public const uint GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
		public const uint GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
		public const uint GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
		public const uint GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
		public const uint GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
		public const uint GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
		public const uint GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
		public const uint GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
		public const uint GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
		public const uint GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
		public const uint GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;
		public const uint GL_MAX_TEXTURE_SIZE = 0x0D33;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
		public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
		public const uint GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
		public const uint GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
		public const uint GL_MAX_UNIFORM_LOCATIONS = 0x826E;
		public const uint GL_MAX_VARYING_COMPONENTS = 0x8B4B;
		public const uint GL_MAX_VARYING_FLOATS = 0x8B4B;
		public const uint GL_MAX_VARYING_VECTORS = 0x8DFC;
		public const uint GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
		public const uint GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
		public const uint GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
		public const uint GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
		public const uint GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
		public const uint GL_MAX_VERTEX_ATTRIBS = 0x8869;
		public const uint GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
		public const uint GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
		public const uint GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
		public const uint GL_MAX_VERTEX_STREAMS = 0x8E71;
		public const uint GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
		public const uint GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
		public const uint GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
		public const uint GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		public const uint GL_MAX_VIEWPORT_DIMS = 0x0D3A;
		public const uint GL_MAX_VIEWPORTS = 0x825B;
		public const uint GL_MAX_WIDTH = 0x827E;
		public const uint GL_MEDIUM_FLOAT = 0x8DF1;
		public const uint GL_MEDIUM_INT = 0x8DF4;
		public const uint GL_MIN = 0x8007;
		public const uint GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
		public const uint GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
		public const uint GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
		public const uint GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
		public const uint GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;
		public const uint GL_MINOR_VERSION = 0x821C;
		public const uint GL_MIPMAP = 0x8293;
		public const uint GL_MIRROR_CLAMP_TO_EDGE = 0x8743;
		public const uint GL_MIRRORED_REPEAT = 0x8370;
		public const uint GL_MULTISAMPLE = 0x809D;
		public const uint GL_NAME_LENGTH = 0x92F9;
		public const uint GL_NAND = 0x150E;
		public const uint GL_NEAREST = 0x2600;
		public const uint GL_NEAREST_MIPMAP_LINEAR = 0x2702;
		public const uint GL_NEAREST_MIPMAP_NEAREST = 0x2700;
		public const uint GL_NEGATIVE_ONE_TO_ONE = 0x935E;
		public const uint GL_NEVER = 0x0200;
		public const uint GL_NICEST = 0x1102;
		public const uint GL_NO_ERROR = 0;
		public const uint GL_NO_RESET_NOTIFICATION = 0x8261;
		public const uint GL_NONE = 0;
		public const uint GL_NOOP = 0x1505;
		public const uint GL_NOR = 0x1508;
		public const uint GL_NOTEQUAL = 0x0205;
		public const uint GL_NUM_ACTIVE_VARIABLES = 0x9304;
		public const uint GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
		public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
		public const uint GL_NUM_EXTENSIONS = 0x821D;
		public const uint GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
		public const uint GL_NUM_SAMPLE_COUNTS = 0x9380;
		public const uint GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
		public const uint GL_NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
		public const uint GL_OBJECT_TYPE = 0x9112;
		public const uint GL_OFFSET = 0x92FC;
		public const uint GL_ONE = 1;
		public const uint GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		public const uint GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const uint GL_ONE_MINUS_DST_ALPHA = 0x0305;
		public const uint GL_ONE_MINUS_DST_COLOR = 0x0307;
		public const uint GL_ONE_MINUS_SRC_ALPHA = 0x0303;
		public const uint GL_ONE_MINUS_SRC_COLOR = 0x0301;
		public const uint GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
		public const uint GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
		public const uint GL_OR = 0x1507;
		public const uint GL_OR_INVERTED = 0x150D;
		public const uint GL_OR_REVERSE = 0x150B;
		public const uint GL_OUT_OF_MEMORY = 0x0505;
		public const uint GL_PACK_ALIGNMENT = 0x0D05;
		public const uint GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
		public const uint GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
		public const uint GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
		public const uint GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
		public const uint GL_PACK_IMAGE_HEIGHT = 0x806C;
		public const uint GL_PACK_LSB_FIRST = 0x0D01;
		public const uint GL_PACK_ROW_LENGTH = 0x0D02;
		public const uint GL_PACK_SKIP_IMAGES = 0x806B;
		public const uint GL_PACK_SKIP_PIXELS = 0x0D04;
		public const uint GL_PACK_SKIP_ROWS = 0x0D03;
		public const uint GL_PACK_SWAP_BYTES = 0x0D00;
		public const uint GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
		public const uint GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
		public const uint GL_PATCH_VERTICES = 0x8E72;
		public const uint GL_PATCHES = 0x000E;
		public const uint GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
		public const uint GL_PIXEL_PACK_BUFFER = 0x88EB;
		public const uint GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
		public const uint GL_PIXEL_UNPACK_BUFFER = 0x88EC;
		public const uint GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
		public const uint GL_POINT = 0x1B00;
		public const uint GL_POINT_FADE_THRESHOLD_SIZE = 0x8128;
		public const uint GL_POINT_SIZE = 0x0B11;
		public const uint GL_POINT_SIZE_GRANULARITY = 0x0B13;
		public const uint GL_POINT_SIZE_RANGE = 0x0B12;
		public const uint GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
		public const uint GL_POINTS = 0x0000;
		public const uint GL_POLYGON_MODE = 0x0B40;
		public const uint GL_POLYGON_OFFSET_FACTOR = 0x8038;
		public const uint GL_POLYGON_OFFSET_FILL = 0x8037;
		public const uint GL_POLYGON_OFFSET_LINE = 0x2A02;
		public const uint GL_POLYGON_OFFSET_POINT = 0x2A01;
		public const uint GL_POLYGON_OFFSET_UNITS = 0x2A00;
		public const uint GL_POLYGON_SMOOTH = 0x0B41;
		public const uint GL_POLYGON_SMOOTH_HINT = 0x0C53;
		public const uint GL_PRIMITIVE_RESTART = 0x8F9D;
		public const uint GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
		public const uint GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
		public const uint GL_PRIMITIVE_RESTART_INDEX = 0x8F9E;
		public const uint GL_PRIMITIVES_GENERATED = 0x8C87;
		public const uint GL_PROGRAM = 0x82E2;
		public const uint GL_PROGRAM_BINARY_FORMATS = 0x87FF;
		public const uint GL_PROGRAM_BINARY_LENGTH = 0x8741;
		public const uint GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
		public const uint GL_PROGRAM_INPUT = 0x92E3;
		public const uint GL_PROGRAM_OUTPUT = 0x92E4;
		public const uint GL_PROGRAM_PIPELINE = 0x82E4;
		public const uint GL_PROGRAM_PIPELINE_BINDING = 0x825A;
		public const uint GL_PROGRAM_POINT_SIZE = 0x8642;
		public const uint GL_PROGRAM_SEPARABLE = 0x8258;
		public const uint GL_PROVOKING_VERTEX = 0x8E4F;
		public const uint GL_PROXY_TEXTURE_1D = 0x8063;
		public const uint GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19;
		public const uint GL_PROXY_TEXTURE_2D = 0x8064;
		public const uint GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
		public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
		public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
		public const uint GL_PROXY_TEXTURE_3D = 0x8070;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
		public const uint GL_PROXY_TEXTURE_RECTANGLE = 0x84F7;
		public const uint GL_QUADS = 0x0007;
		public const uint GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
		public const uint GL_QUERY = 0x82E3;
		public const uint GL_QUERY_BUFFER = 0x9192;
		public const uint GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;
		public const uint GL_QUERY_BUFFER_BINDING = 0x9193;
		public const uint GL_QUERY_BY_REGION_NO_WAIT = 0x8E16;
		public const uint GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
		public const uint GL_QUERY_BY_REGION_WAIT = 0x8E15;
		public const uint GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
		public const uint GL_QUERY_COUNTER_BITS = 0x8864;
		public const uint GL_QUERY_NO_WAIT = 0x8E14;
		public const uint GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
		public const uint GL_QUERY_RESULT = 0x8866;
		public const uint GL_QUERY_RESULT_AVAILABLE = 0x8867;
		public const uint GL_QUERY_RESULT_NO_WAIT = 0x9194;
		public const uint GL_QUERY_TARGET = 0x82EA;
		public const uint GL_QUERY_WAIT = 0x8E13;
		public const uint GL_QUERY_WAIT_INVERTED = 0x8E17;
		public const uint GL_R11F_G11F_B10F = 0x8C3A;
		public const uint GL_R16 = 0x822A;
		public const uint GL_R16_SNORM = 0x8F98;
		public const uint GL_R16F = 0x822D;
		public const uint GL_R16I = 0x8233;
		public const uint GL_R16UI = 0x8234;
		public const uint GL_R3_G3_B2 = 0x2A10;
		public const uint GL_R32F = 0x822E;
		public const uint GL_R32I = 0x8235;
		public const uint GL_R32UI = 0x8236;
		public const uint GL_R8 = 0x8229;
		public const uint GL_R8_SNORM = 0x8F94;
		public const uint GL_R8I = 0x8231;
		public const uint GL_R8UI = 0x8232;
		public const uint GL_RASTERIZER_DISCARD = 0x8C89;
		public const uint GL_READ_BUFFER = 0x0C02;
		public const uint GL_READ_FRAMEBUFFER = 0x8CA8;
		public const uint GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
		public const uint GL_READ_ONLY = 0x88B8;
		public const uint GL_READ_PIXELS = 0x828C;
		public const uint GL_READ_PIXELS_FORMAT = 0x828D;
		public const uint GL_READ_PIXELS_TYPE = 0x828E;
		public const uint GL_READ_WRITE = 0x88BA;
		public const uint GL_RED = 0x1903;
		public const uint GL_RED_INTEGER = 0x8D94;
		public const uint GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
		public const uint GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
		public const uint GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
		public const uint GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
		public const uint GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
		public const uint GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;
		public const uint GL_RENDERBUFFER = 0x8D41;
		public const uint GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		public const uint GL_RENDERBUFFER_BINDING = 0x8CA7;
		public const uint GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
		public const uint GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		public const uint GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
		public const uint GL_RENDERBUFFER_HEIGHT = 0x8D43;
		public const uint GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		public const uint GL_RENDERBUFFER_RED_SIZE = 0x8D50;
		public const uint GL_RENDERBUFFER_SAMPLES = 0x8CAB;
		public const uint GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		public const uint GL_RENDERBUFFER_WIDTH = 0x8D42;
		public const uint GL_RENDERER = 0x1F01;
		public const uint GL_REPEAT = 0x2901;
		public const uint GL_REPLACE = 0x1E01;
		public const uint GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
		public const uint GL_RG = 0x8227;
		public const uint GL_RG_INTEGER = 0x8228;
		public const uint GL_RG16 = 0x822C;
		public const uint GL_RG16_SNORM = 0x8F99;
		public const uint GL_RG16F = 0x822F;
		public const uint GL_RG16I = 0x8239;
		public const uint GL_RG16UI = 0x823A;
		public const uint GL_RG32F = 0x8230;
		public const uint GL_RG32I = 0x823B;
		public const uint GL_RG32UI = 0x823C;
		public const uint GL_RG8 = 0x822B;
		public const uint GL_RG8_SNORM = 0x8F95;
		public const uint GL_RG8I = 0x8237;
		public const uint GL_RG8UI = 0x8238;
		public const uint GL_RGB = 0x1907;
		public const uint GL_RGB_INTEGER = 0x8D98;
		public const uint GL_RGB10 = 0x8052;
		public const uint GL_RGB10_A2 = 0x8059;
		public const uint GL_RGB10_A2UI = 0x906F;
		public const uint GL_RGB12 = 0x8053;
		public const uint GL_RGB16 = 0x8054;
		public const uint GL_RGB16_SNORM = 0x8F9A;
		public const uint GL_RGB16F = 0x881B;
		public const uint GL_RGB16I = 0x8D89;
		public const uint GL_RGB16UI = 0x8D77;
		public const uint GL_RGB32F = 0x8815;
		public const uint GL_RGB32I = 0x8D83;
		public const uint GL_RGB32UI = 0x8D71;
		public const uint GL_RGB4 = 0x804F;
		public const uint GL_RGB5 = 0x8050;
		public const uint GL_RGB5_A1 = 0x8057;
		public const uint GL_RGB565 = 0x8D62;
		public const uint GL_RGB8 = 0x8051;
		public const uint GL_RGB8_SNORM = 0x8F96;
		public const uint GL_RGB8I = 0x8D8F;
		public const uint GL_RGB8UI = 0x8D7D;
		public const uint GL_RGB9_E5 = 0x8C3D;
		public const uint GL_RGBA = 0x1908;
		public const uint GL_RGBA_INTEGER = 0x8D99;
		public const uint GL_RGBA12 = 0x805A;
		public const uint GL_RGBA16 = 0x805B;
		public const uint GL_RGBA16_SNORM = 0x8F9B;
		public const uint GL_RGBA16F = 0x881A;
		public const uint GL_RGBA16I = 0x8D88;
		public const uint GL_RGBA16UI = 0x8D76;
		public const uint GL_RGBA2 = 0x8055;
		public const uint GL_RGBA32F = 0x8814;
		public const uint GL_RGBA32I = 0x8D82;
		public const uint GL_RGBA32UI = 0x8D70;
		public const uint GL_RGBA4 = 0x8056;
		public const uint GL_RGBA8 = 0x8058;
		public const uint GL_RGBA8_SNORM = 0x8F97;
		public const uint GL_RGBA8I = 0x8D8E;
		public const uint GL_RGBA8UI = 0x8D7C;
		public const uint GL_RIGHT = 0x0407;
		public const uint GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		public const uint GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
		public const uint GL_SAMPLE_BUFFERS = 0x80A8;
		public const uint GL_SAMPLE_COVERAGE = 0x80A0;
		public const uint GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
		public const uint GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
		public const uint GL_SAMPLE_MASK = 0x8E51;
		public const uint GL_SAMPLE_MASK_VALUE = 0x8E52;
		public const uint GL_SAMPLE_POSITION = 0x8E50;
		public const uint GL_SAMPLE_SHADING = 0x8C36;
		public const uint GL_SAMPLER = 0x82E6;
		public const uint GL_SAMPLER_1D = 0x8B5D;
		public const uint GL_SAMPLER_1D_ARRAY = 0x8DC0;
		public const uint GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
		public const uint GL_SAMPLER_1D_SHADOW = 0x8B61;
		public const uint GL_SAMPLER_2D = 0x8B5E;
		public const uint GL_SAMPLER_2D_ARRAY = 0x8DC1;
		public const uint GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
		public const uint GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
		public const uint GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
		public const uint GL_SAMPLER_2D_RECT = 0x8B63;
		public const uint GL_SAMPLER_2D_RECT_SHADOW = 0x8B64;
		public const uint GL_SAMPLER_2D_SHADOW = 0x8B62;
		public const uint GL_SAMPLER_3D = 0x8B5F;
		public const uint GL_SAMPLER_BINDING = 0x8919;
		public const uint GL_SAMPLER_BUFFER = 0x8DC2;
		public const uint GL_SAMPLER_CUBE = 0x8B60;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;
		public const uint GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
		public const uint GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
		public const uint GL_SAMPLES = 0x80A9;
		public const uint GL_SAMPLES_PASSED = 0x8914;
		public const uint GL_SCISSOR_BOX = 0x0C10;
		public const uint GL_SCISSOR_TEST = 0x0C11;
		public const uint GL_SEPARATE_ATTRIBS = 0x8C8D;
		public const uint GL_SET = 0x150F;
		public const uint GL_SHADER = 0x82E1;
		public const uint GL_SHADER_BINARY_FORMATS = 0x8DF8;
		public const uint GL_SHADER_COMPILER = 0x8DFA;
		public const uint GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
		public const uint GL_SHADER_IMAGE_ATOMIC = 0x82A6;
		public const uint GL_SHADER_IMAGE_LOAD = 0x82A4;
		public const uint GL_SHADER_IMAGE_STORE = 0x82A5;
		public const uint GL_SHADER_SOURCE_LENGTH = 0x8B88;
		public const uint GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000;
		public const uint GL_SHADER_STORAGE_BLOCK = 0x92E6;
		public const uint GL_SHADER_STORAGE_BUFFER = 0x90D2;
		public const uint GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
		public const uint GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
		public const uint GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
		public const uint GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
		public const uint GL_SHADER_TYPE = 0x8B4F;
		public const uint GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
		public const uint GL_SHORT = 0x1402;
		public const uint GL_SIGNALED = 0x9119;
		public const uint GL_SIGNED_NORMALIZED = 0x8F9C;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
		public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
		public const uint GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const uint GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
		public const uint GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
		public const uint GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;
		public const uint GL_SRC_ALPHA = 0x0302;
		public const uint GL_SRC_ALPHA_SATURATE = 0x0308;
		public const uint GL_SRC_COLOR = 0x0300;
		public const uint GL_SRC1_ALPHA = 0x8589;
		public const uint GL_SRC1_COLOR = 0x88F9;
		public const uint GL_SRGB = 0x8C40;
		public const uint GL_SRGB_ALPHA = 0x8C42;
		public const uint GL_SRGB_READ = 0x8297;
		public const uint GL_SRGB_WRITE = 0x8298;
		public const uint GL_SRGB8 = 0x8C41;
		public const uint GL_SRGB8_ALPHA8 = 0x8C43;
		public const uint GL_STACK_OVERFLOW = 0x0503;
		public const uint GL_STACK_UNDERFLOW = 0x0504;
		public const uint GL_STATIC_COPY = 0x88E6;
		public const uint GL_STATIC_DRAW = 0x88E4;
		public const uint GL_STATIC_READ = 0x88E5;
		public const uint GL_STENCIL = 0x1802;
		public const uint GL_STENCIL_ATTACHMENT = 0x8D20;
		public const uint GL_STENCIL_BACK_FAIL = 0x8801;
		public const uint GL_STENCIL_BACK_FUNC = 0x8800;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
		public const uint GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
		public const uint GL_STENCIL_BACK_REF = 0x8CA3;
		public const uint GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
		public const uint GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
		public const uint GL_STENCIL_BUFFER_BIT = 0x00000400;
		public const uint GL_STENCIL_CLEAR_VALUE = 0x0B91;
		public const uint GL_STENCIL_COMPONENTS = 0x8285;
		public const uint GL_STENCIL_FAIL = 0x0B94;
		public const uint GL_STENCIL_FUNC = 0x0B92;
		public const uint GL_STENCIL_INDEX = 0x1901;
		public const uint GL_STENCIL_INDEX1 = 0x8D46;
		public const uint GL_STENCIL_INDEX16 = 0x8D49;
		public const uint GL_STENCIL_INDEX4 = 0x8D47;
		public const uint GL_STENCIL_INDEX8 = 0x8D48;
		public const uint GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
		public const uint GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
		public const uint GL_STENCIL_REF = 0x0B97;
		public const uint GL_STENCIL_RENDERABLE = 0x8288;
		public const uint GL_STENCIL_TEST = 0x0B90;
		public const uint GL_STENCIL_VALUE_MASK = 0x0B93;
		public const uint GL_STENCIL_WRITEMASK = 0x0B98;
		public const uint GL_STEREO = 0x0C33;
		public const uint GL_STREAM_COPY = 0x88E2;
		public const uint GL_STREAM_DRAW = 0x88E0;
		public const uint GL_STREAM_READ = 0x88E1;
		public const uint GL_SUBPIXEL_BITS = 0x0D50;
		public const uint GL_SYNC_CONDITION = 0x9113;
		public const uint GL_SYNC_FENCE = 0x9116;
		public const uint GL_SYNC_FLAGS = 0x9115;
		public const uint GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
		public const uint GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
		public const uint GL_SYNC_STATUS = 0x9114;
		public const uint GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
		public const uint GL_TESS_CONTROL_SHADER = 0x8E88;
		public const uint GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
		public const uint GL_TESS_CONTROL_SUBROUTINE = 0x92E9;
		public const uint GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
		public const uint GL_TESS_CONTROL_TEXTURE = 0x829C;
		public const uint GL_TESS_EVALUATION_SHADER = 0x8E87;
		public const uint GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
		public const uint GL_TESS_EVALUATION_SUBROUTINE = 0x92EA;
		public const uint GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
		public const uint GL_TESS_EVALUATION_TEXTURE = 0x829D;
		public const uint GL_TESS_GEN_MODE = 0x8E76;
		public const uint GL_TESS_GEN_POINT_MODE = 0x8E79;
		public const uint GL_TESS_GEN_SPACING = 0x8E77;
		public const uint GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
		public const uint GL_TEXTURE = 0x1702;
		public const uint GL_TEXTURE_1D = 0x0DE0;
		public const uint GL_TEXTURE_1D_ARRAY = 0x8C18;
		public const uint GL_TEXTURE_2D = 0x0DE1;
		public const uint GL_TEXTURE_2D_ARRAY = 0x8C1A;
		public const uint GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
		public const uint GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
		public const uint GL_TEXTURE_3D = 0x806F;
		public const uint GL_TEXTURE_ALPHA_SIZE = 0x805F;
		public const uint GL_TEXTURE_ALPHA_TYPE = 0x8C13;
		public const uint GL_TEXTURE_BASE_LEVEL = 0x813C;
		public const uint GL_TEXTURE_BINDING_1D = 0x8068;
		public const uint GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
		public const uint GL_TEXTURE_BINDING_2D = 0x8069;
		public const uint GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
		public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
		public const uint GL_TEXTURE_BINDING_3D = 0x806A;
		public const uint GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
		public const uint GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
		public const uint GL_TEXTURE_BLUE_SIZE = 0x805E;
		public const uint GL_TEXTURE_BLUE_TYPE = 0x8C12;
		public const uint GL_TEXTURE_BORDER_COLOR = 0x1004;
		public const uint GL_TEXTURE_BUFFER = 0x8C2A;
		public const uint GL_TEXTURE_BUFFER_BINDING = 0x8C2A;
		public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
		public const uint GL_TEXTURE_BUFFER_OFFSET = 0x919D;
		public const uint GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
		public const uint GL_TEXTURE_BUFFER_SIZE = 0x919E;
		public const uint GL_TEXTURE_COMPARE_FUNC = 0x884D;
		public const uint GL_TEXTURE_COMPARE_MODE = 0x884C;
		public const uint GL_TEXTURE_COMPRESSED = 0x86A1;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
		public const uint GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
		public const uint GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
		public const uint GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
		public const uint GL_TEXTURE_CUBE_MAP = 0x8513;
		public const uint GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		public const uint GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
		public const uint GL_TEXTURE_DEPTH = 0x8071;
		public const uint GL_TEXTURE_DEPTH_SIZE = 0x884A;
		public const uint GL_TEXTURE_DEPTH_TYPE = 0x8C16;
		public const uint GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
		public const uint GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
		public const uint GL_TEXTURE_GATHER = 0x82A2;
		public const uint GL_TEXTURE_GATHER_SHADOW = 0x82A3;
		public const uint GL_TEXTURE_GREEN_SIZE = 0x805D;
		public const uint GL_TEXTURE_GREEN_TYPE = 0x8C11;
		public const uint GL_TEXTURE_HEIGHT = 0x1001;
		public const uint GL_TEXTURE_IMAGE_FORMAT = 0x828F;
		public const uint GL_TEXTURE_IMAGE_TYPE = 0x8290;
		public const uint GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
		public const uint GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
		public const uint GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
		public const uint GL_TEXTURE_LOD_BIAS = 0x8501;
		public const uint GL_TEXTURE_MAG_FILTER = 0x2800;
		public const uint GL_TEXTURE_MAX_LEVEL = 0x813D;
		public const uint GL_TEXTURE_MAX_LOD = 0x813B;
		public const uint GL_TEXTURE_MIN_FILTER = 0x2801;
		public const uint GL_TEXTURE_MIN_LOD = 0x813A;
		public const uint GL_TEXTURE_RECTANGLE = 0x84F5;
		public const uint GL_TEXTURE_RED_SIZE = 0x805C;
		public const uint GL_TEXTURE_RED_TYPE = 0x8C10;
		public const uint GL_TEXTURE_SAMPLES = 0x9106;
		public const uint GL_TEXTURE_SHADOW = 0x82A1;
		public const uint GL_TEXTURE_SHARED_SIZE = 0x8C3F;
		public const uint GL_TEXTURE_STENCIL_SIZE = 0x88F1;
		public const uint GL_TEXTURE_SWIZZLE_A = 0x8E45;
		public const uint GL_TEXTURE_SWIZZLE_B = 0x8E44;
		public const uint GL_TEXTURE_SWIZZLE_G = 0x8E43;
		public const uint GL_TEXTURE_SWIZZLE_R = 0x8E42;
		public const uint GL_TEXTURE_SWIZZLE_RGBA = 0x8E46;
		public const uint GL_TEXTURE_TARGET = 0x1006;
		public const uint GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
		public const uint GL_TEXTURE_VIEW = 0x82B5;
		public const uint GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD;
		public const uint GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
		public const uint GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
		public const uint GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
		public const uint GL_TEXTURE_WIDTH = 0x1000;
		public const uint GL_TEXTURE_WRAP_R = 0x8072;
		public const uint GL_TEXTURE_WRAP_S = 0x2802;
		public const uint GL_TEXTURE_WRAP_T = 0x2803;
		public const uint GL_TEXTURE0 = 0x84C0;
		public const uint GL_TEXTURE1 = 0x84C1;
		public const uint GL_TEXTURE10 = 0x84CA;
		public const uint GL_TEXTURE11 = 0x84CB;
		public const uint GL_TEXTURE12 = 0x84CC;
		public const uint GL_TEXTURE13 = 0x84CD;
		public const uint GL_TEXTURE14 = 0x84CE;
		public const uint GL_TEXTURE15 = 0x84CF;
		public const uint GL_TEXTURE16 = 0x84D0;
		public const uint GL_TEXTURE17 = 0x84D1;
		public const uint GL_TEXTURE18 = 0x84D2;
		public const uint GL_TEXTURE19 = 0x84D3;
		public const uint GL_TEXTURE2 = 0x84C2;
		public const uint GL_TEXTURE20 = 0x84D4;
		public const uint GL_TEXTURE21 = 0x84D5;
		public const uint GL_TEXTURE22 = 0x84D6;
		public const uint GL_TEXTURE23 = 0x84D7;
		public const uint GL_TEXTURE24 = 0x84D8;
		public const uint GL_TEXTURE25 = 0x84D9;
		public const uint GL_TEXTURE26 = 0x84DA;
		public const uint GL_TEXTURE27 = 0x84DB;
		public const uint GL_TEXTURE28 = 0x84DC;
		public const uint GL_TEXTURE29 = 0x84DD;
		public const uint GL_TEXTURE3 = 0x84C3;
		public const uint GL_TEXTURE30 = 0x84DE;
		public const uint GL_TEXTURE31 = 0x84DF;
		public const uint GL_TEXTURE4 = 0x84C4;
		public const uint GL_TEXTURE5 = 0x84C5;
		public const uint GL_TEXTURE6 = 0x84C6;
		public const uint GL_TEXTURE7 = 0x84C7;
		public const uint GL_TEXTURE8 = 0x84C8;
		public const uint GL_TEXTURE9 = 0x84C9;
		public const uint GL_TIME_ELAPSED = 0x88BF;
		public const uint GL_TIMEOUT_EXPIRED = 0x911B;
		public const ulong GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
		public const uint GL_TIMESTAMP = 0x8E28;
		public const uint GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
		public const uint GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
		public const uint GL_TRANSFORM_FEEDBACK = 0x8E22;
		public const uint GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
		public const uint GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
		public const uint GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
		public const uint GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
		public const uint GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
		public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
		public const uint GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
		public const uint GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
		public const uint GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
		public const uint GL_TRIANGLE_FAN = 0x0006;
		public const uint GL_TRIANGLE_STRIP = 0x0005;
		public const uint GL_TRIANGLE_STRIP_ADJACENCY = 0x000D;
		public const uint GL_TRIANGLES = 0x0004;
		public const uint GL_TRIANGLES_ADJACENCY = 0x000C;
		public const uint GL_TRUE = 1;
		public const uint GL_TYPE = 0x92FA;
		public const uint GL_UNDEFINED_VERTEX = 0x8260;
		public const uint GL_UNIFORM = 0x92E1;
		public const uint GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
		public const uint GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
		public const uint GL_UNIFORM_BARRIER_BIT = 0x00000004;
		public const uint GL_UNIFORM_BLOCK = 0x92E2;
		public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
		public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
		public const uint GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
		public const uint GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
		public const uint GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
		public const uint GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
		public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
		public const uint GL_UNIFORM_BUFFER = 0x8A11;
		public const uint GL_UNIFORM_BUFFER_BINDING = 0x8A28;
		public const uint GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
		public const uint GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
		public const uint GL_UNIFORM_BUFFER_START = 0x8A29;
		public const uint GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
		public const uint GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
		public const uint GL_UNIFORM_NAME_LENGTH = 0x8A39;
		public const uint GL_UNIFORM_OFFSET = 0x8A3B;
		public const uint GL_UNIFORM_SIZE = 0x8A38;
		public const uint GL_UNIFORM_TYPE = 0x8A37;
		public const uint GL_UNKNOWN_CONTEXT_RESET = 0x8255;
		public const uint GL_UNPACK_ALIGNMENT = 0x0CF5;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
		public const uint GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
		public const uint GL_UNPACK_IMAGE_HEIGHT = 0x806E;
		public const uint GL_UNPACK_LSB_FIRST = 0x0CF1;
		public const uint GL_UNPACK_ROW_LENGTH = 0x0CF2;
		public const uint GL_UNPACK_SKIP_IMAGES = 0x806D;
		public const uint GL_UNPACK_SKIP_PIXELS = 0x0CF4;
		public const uint GL_UNPACK_SKIP_ROWS = 0x0CF3;
		public const uint GL_UNPACK_SWAP_BYTES = 0x0CF0;
		public const uint GL_UNSIGNALED = 0x9118;
		public const uint GL_UNSIGNED_BYTE = 0x1401;
		public const uint GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;
		public const uint GL_UNSIGNED_BYTE_3_3_2 = 0x8032;
		public const uint GL_UNSIGNED_INT = 0x1405;
		public const uint GL_UNSIGNED_INT_10_10_10_2 = 0x8036;
		public const uint GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
		public const uint GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
		public const uint GL_UNSIGNED_INT_24_8 = 0x84FA;
		public const uint GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
		public const uint GL_UNSIGNED_INT_8_8_8_8 = 0x8035;
		public const uint GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;
		public const uint GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
		public const uint GL_UNSIGNED_INT_IMAGE_1D = 0x9062;
		public const uint GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
		public const uint GL_UNSIGNED_INT_IMAGE_2D = 0x9063;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
		public const uint GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
		public const uint GL_UNSIGNED_INT_IMAGE_3D = 0x9064;
		public const uint GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;
		public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
		public const uint GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
		public const uint GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
		public const uint GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
		public const uint GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
		public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
		public const uint GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
		public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
		public const uint GL_UNSIGNED_INT_VEC2 = 0x8DC6;
		public const uint GL_UNSIGNED_INT_VEC3 = 0x8DC7;
		public const uint GL_UNSIGNED_INT_VEC4 = 0x8DC8;
		public const uint GL_UNSIGNED_NORMALIZED = 0x8C17;
		public const uint GL_UNSIGNED_SHORT = 0x1403;
		public const uint GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
		public const uint GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
		public const uint GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
		public const uint GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;
		public const uint GL_UPPER_LEFT = 0x8CA2;
		public const uint GL_VALIDATE_STATUS = 0x8B83;
		public const uint GL_VENDOR = 0x1F00;
		public const uint GL_VERSION = 0x1F02;
		public const uint GL_VERTEX_ARRAY = 0x8074;
		public const uint GL_VERTEX_ARRAY_BINDING = 0x85B5;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
		public const uint GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
		public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
		public const uint GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
		public const uint GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
		public const uint GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E;
		public const uint GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
		public const uint GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
		public const uint GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
		public const uint GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
		public const uint GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
		public const uint GL_VERTEX_ATTRIB_BINDING = 0x82D4;
		public const uint GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
		public const uint GL_VERTEX_BINDING_BUFFER = 0x8F4F;
		public const uint GL_VERTEX_BINDING_DIVISOR = 0x82D6;
		public const uint GL_VERTEX_BINDING_OFFSET = 0x82D7;
		public const uint GL_VERTEX_BINDING_STRIDE = 0x82D8;
		public const uint GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642;
		public const uint GL_VERTEX_SHADER = 0x8B31;
		public const uint GL_VERTEX_SHADER_BIT = 0x00000001;
		public const uint GL_VERTEX_SUBROUTINE = 0x92E8;
		public const uint GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
		public const uint GL_VERTEX_TEXTURE = 0x829B;
		public const uint GL_VIEW_CLASS_128_BITS = 0x82C4;
		public const uint GL_VIEW_CLASS_16_BITS = 0x82CA;
		public const uint GL_VIEW_CLASS_24_BITS = 0x82C9;
		public const uint GL_VIEW_CLASS_32_BITS = 0x82C8;
		public const uint GL_VIEW_CLASS_48_BITS = 0x82C7;
		public const uint GL_VIEW_CLASS_64_BITS = 0x82C6;
		public const uint GL_VIEW_CLASS_8_BITS = 0x82CB;
		public const uint GL_VIEW_CLASS_96_BITS = 0x82C5;
		public const uint GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3;
		public const uint GL_VIEW_CLASS_BPTC_UNORM = 0x82D2;
		public const uint GL_VIEW_CLASS_RGTC1_RED = 0x82D0;
		public const uint GL_VIEW_CLASS_RGTC2_RG = 0x82D1;
		public const uint GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
		public const uint GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
		public const uint GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
		public const uint GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
		public const uint GL_VIEW_COMPATIBILITY_CLASS = 0x82B6;
		public const uint GL_VIEWPORT = 0x0BA2;
		public const uint GL_VIEWPORT_BOUNDS_RANGE = 0x825D;
		public const uint GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
		public const uint GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;
		public const uint GL_WAIT_FAILED = 0x911D;
		public const uint GL_WRITE_ONLY = 0x88B9;
		public const uint GL_XOR = 0x1506;
		public const uint GL_ZERO = 0;
		public const uint GL_ZERO_TO_ONE = 0x935F;

		public delegate void DebugProc(uint source, uint type, uint id, uint severity, int length, string message, IntPtr userParam);

		public static class Delegates
		{
			public delegate void glActiveShaderProgram(uint pipeline, uint program);

			public delegate void glActiveTexture(uint texture);

			public delegate void glAttachShader(uint program, uint shader);

			public delegate void glBeginConditionalRender(uint id, uint mode);

			public delegate void glBeginQuery(uint target, uint id);

			public delegate void glBeginQueryIndexed(uint target, uint index, uint id);

			public delegate void glBeginTransformFeedback(uint primitiveMode);

			public delegate void glBindAttribLocation(uint program, uint index, string name);

			public delegate void glBindBuffer(uint target, uint buffer);

			public delegate void glBindBufferBase(uint target, uint index, uint buffer);

			public delegate void glBindBufferRange(uint target, uint index, uint buffer, int offset, int size);

			public delegate void glBindBuffersBase(uint target, uint first, int count, uint[] buffers);

			public delegate void glBindBuffersRange(uint target, uint first, int count, uint[] buffers, int[] offsets, int[] sizes);

			public delegate void glBindFragDataLocation(uint program, uint color, string name);

			public delegate void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name);

			public delegate void glBindFramebuffer(uint target, uint framebuffer);

			public delegate void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);

			public delegate void glBindImageTextures(uint first, int count, uint[] textures);

			public delegate void glBindProgramPipeline(uint pipeline);

			public delegate void glBindRenderbuffer(uint target, uint renderbuffer);

			public delegate void glBindSampler(uint unit, uint sampler);

			public delegate void glBindSamplers(uint first, int count, uint[] samplers);

			public delegate void glBindTexture(uint target, uint texture);

			public delegate void glBindTextures(uint first, int count, uint[] textures);

			public delegate void glBindTextureUnit(uint unit, uint texture);

			public delegate void glBindTransformFeedback(uint target, uint id);

			public delegate void glBindVertexArray(uint array);

			public delegate void glBindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride);

			public delegate void glBindVertexBuffers(uint first, int count, uint[] buffers, int[] offsets, int[] strides);

			public delegate void glBlendColor(float red, float green, float blue, float alpha);

			public delegate void glBlendEquation(uint mode);

			public delegate void glBlendEquationi(uint buf, uint mode);

			public delegate void glBlendEquationSeparate(uint modeRGB, uint modeAlpha);

			public delegate void glBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);

			public delegate void glBlendFunc(uint sfactor, uint dfactor);

			public delegate void glBlendFunci(uint buf, uint src, uint dst);

			public delegate void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

			public delegate void glBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);

			public delegate void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

			public delegate void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

			public delegate void glBufferData(uint target, int size, IntPtr data, uint usage);

			public delegate void glBufferStorage(uint target, int size, IntPtr data, uint flags);

			public delegate void glBufferSubData(uint target, int offset, int size, IntPtr data);

			public delegate uint glCheckFramebufferStatus(uint target);

			public delegate uint glCheckNamedFramebufferStatus(uint framebuffer, uint target);

			public delegate void glClampColor(uint target, uint clamp);

			public delegate void glClear(uint mask);

			public delegate void glClearBufferData(uint target, uint internalformat, uint format, uint type, IntPtr data);

			public delegate void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil);

			public delegate void glClearBufferfv(uint buffer, int drawbuffer, float[] value);

			public delegate void glClearBufferiv(uint buffer, int drawbuffer, int[] value);

			public delegate void glClearBufferSubData(uint target, uint internalformat, int offset, int size, uint format, uint type, IntPtr data);

			public delegate void glClearBufferuiv(uint buffer, int drawbuffer, uint[] value);

			public delegate void glClearColor(float red, float green, float blue, float alpha);

			public delegate void glClearDepth(double depth);

			public delegate void glClearDepthf(float d);

			public delegate void glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, IntPtr data);

			public delegate void glClearNamedBufferSubData(uint buffer, uint internalformat, int offset, int size, uint format, uint type, IntPtr data);

			public delegate void glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);

			public delegate void glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float[] value);

			public delegate void glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int[] value);

			public delegate void glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint[] value);

			public delegate void glClearStencil(int s);

			public delegate void glClearTexImage(uint texture, int level, uint format, uint type, IntPtr data);

			public delegate void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data);

			public delegate uint glClientWaitSync(IntPtr sync, uint flags, ulong timeout);

			public delegate void glClipControl(uint origin, uint depth);

			public delegate void glColorMask(bool red, bool green, bool blue, bool alpha);

			public delegate void glColorMaski(uint index, bool r, bool g, bool b, bool a);

			public delegate void glCompileShader(uint shader);

			public delegate void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);

			public delegate void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);

			public delegate void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);

			public delegate void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);

			public delegate void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);

			public delegate void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

			public delegate void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);

			public delegate void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);

			public delegate void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

			public delegate void glCopyBufferSubData(uint readTarget, uint writeTarget, int readOffset, int writeOffset, int size);

			public delegate void glCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);

			public delegate void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size);

			public delegate void glCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border);

			public delegate void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

			public delegate void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);

			public delegate void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

			public delegate void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

			public delegate void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width);

			public delegate void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);

			public delegate void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

			public delegate void glCreateBuffers(int n, uint[] buffers);

			public delegate void glCreateFramebuffers(int n, uint[] framebuffers);

			public delegate uint glCreateProgram();

			public delegate void glCreateProgramPipelines(int n, uint[] pipelines);

			public delegate void glCreateQueries(uint target, int n, uint[] ids);

			public delegate void glCreateRenderbuffers(int n, uint[] renderbuffers);

			public delegate void glCreateSamplers(int n, uint[] samplers);

			public delegate uint glCreateShader(uint type);

			public delegate uint glCreateShaderProgramv(uint type, int count, string[] strings);

			public delegate void glCreateTextures(uint target, int n, uint[] textures);

			public delegate void glCreateTransformFeedbacks(int n, uint[] ids);

			public delegate void glCreateVertexArrays(int n, uint[] arrays);

			public delegate void glCullFace(uint mode);

			public delegate void glDebugMessageCallback(DebugProc callback, IntPtr userParam);

			public delegate void glDebugMessageControl(uint source, uint type, uint severity, int count, uint[] ids, bool enabled);

			public delegate void glDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, string buf);

			public delegate void glDeleteBuffers(int n, uint[] buffers);

			public delegate void glDeleteFramebuffers(int n, uint[] framebuffers);

			public delegate void glDeleteProgram(uint program);

			public delegate void glDeleteProgramPipelines(int n, uint[] pipelines);

			public delegate void glDeleteQueries(int n, uint[] ids);

			public delegate void glDeleteRenderbuffers(int n, uint[] renderbuffers);

			public delegate void glDeleteSamplers(int count, uint[] samplers);

			public delegate void glDeleteShader(uint shader);

			public delegate void glDeleteSync(IntPtr sync);

			public delegate void glDeleteTextures(int n, uint[] textures);

			public delegate void glDeleteTransformFeedbacks(int n, uint[] ids);

			public delegate void glDeleteVertexArrays(int n, uint[] arrays);

			public delegate void glDepthFunc(uint func);

			public delegate void glDepthMask(bool flag);

			public delegate void glDepthRange(double near, double far);

			public delegate void glDepthRangeArrayv(uint first, int count, double[] v);

			public delegate void glDepthRangef(float n, float f);

			public delegate void glDepthRangeIndexed(uint index, double n, double f);

			public delegate void glDetachShader(uint program, uint shader);

			public delegate void glDisable(uint cap);

			public delegate void glDisablei(uint target, uint index);

			public delegate void glDisableVertexArrayAttrib(uint vaobj, uint index);

			public delegate void glDisableVertexAttribArray(uint index);

			public delegate void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);

			public delegate void glDispatchComputeIndirect(int indirect);

			public delegate void glDrawArrays(uint mode, int first, int count);

			public delegate void glDrawArraysIndirect(uint mode, IntPtr indirect);

			public delegate void glDrawArraysInstanced(uint mode, int first, int count, int instancecount);

			public delegate void glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance);

			public delegate void glDrawBuffer(uint buf);

			public delegate void glDrawBuffers(int n, uint[] bufs);

			public delegate void glDrawElements(uint mode, int count, uint type, IntPtr indices);

			public delegate void glDrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int basevertex);

			public delegate void glDrawElementsIndirect(uint mode, uint type, IntPtr indirect);

			public delegate void glDrawElementsInstanced(uint mode, int count, uint type, IntPtr indices, int instancecount);

			public delegate void glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance);

			public delegate void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex);

			public delegate void glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance);

			public delegate void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices);

			public delegate void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex);

			public delegate void glDrawTransformFeedback(uint mode, uint id);

			public delegate void glDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount);

			public delegate void glDrawTransformFeedbackStream(uint mode, uint id, uint stream);

			public delegate void glDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount);

			public delegate void glEnable(uint cap);

			public delegate void glEnablei(uint target, uint index);

			public delegate void glEnableVertexArrayAttrib(uint vaobj, uint index);

			public delegate void glEnableVertexAttribArray(uint index);

			public delegate void glEndConditionalRender();

			public delegate void glEndQuery(uint target);

			public delegate void glEndQueryIndexed(uint target, uint index);

			public delegate void glEndTransformFeedback();

			public delegate IntPtr glFenceSync(uint condition, uint flags);

			public delegate void glFinish();

			public delegate void glFlush();

			public delegate void glFlushMappedBufferRange(uint target, int offset, int length);

			public delegate void glFlushMappedNamedBufferRange(uint buffer, int offset, int length);

			public delegate void glFramebufferParameteri(uint target, uint pname, int param);

			public delegate void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

			public delegate void glFramebufferTexture(uint target, uint attachment, uint texture, int level);

			public delegate void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level);

			public delegate void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);

			public delegate void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);

			public delegate void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);

			public delegate void glFrontFace(uint mode);

			public delegate void glGenBuffers(int n, uint[] buffers);

			public delegate void glGenerateMipmap(uint target);

			public delegate void glGenerateTextureMipmap(uint texture);

			public delegate void glGenFramebuffers(int n, uint[] framebuffers);

			public delegate void glGenProgramPipelines(int n, uint[] pipelines);

			public delegate void glGenQueries(int n, uint[] ids);

			public delegate void glGenRenderbuffers(int n, uint[] renderbuffers);

			public delegate void glGenSamplers(int count, uint[] samplers);

			public delegate void glGenTextures(int n, uint[] textures);

			public delegate void glGenTransformFeedbacks(int n, uint[] ids);

			public delegate void glGenVertexArrays(int n, uint[] arrays);

			public delegate void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int[] @params);

			public delegate void glGetActiveAttrib(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name);

			public delegate void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int[] length, StringBuilder name);

			public delegate void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int[] values);

			public delegate void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int[] length, StringBuilder name);

			public delegate void glGetActiveUniform(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name);

			public delegate void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int[] @params);

			public delegate void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int[] length, StringBuilder uniformBlockName);

			public delegate void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int[] length, StringBuilder uniformName);

			public delegate void glGetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] @params);

			public delegate void glGetAttachedShaders(uint program, int maxCount, int[] count, uint[] shaders);

			public delegate int glGetAttribLocation(uint program, string name);

			public delegate void glGetBooleani_v(uint target, uint index, bool[] data);

			public delegate void glGetBooleanv(uint pname, bool[] data);

			public delegate void glGetBufferParameteri64v(uint target, uint pname, long[] @params);

			public delegate void glGetBufferParameteriv(uint target, uint pname, int[] @params);

			public delegate void glGetBufferPointerv(uint target, uint pname, IntPtr[] @params);

			public delegate void glGetBufferSubData(uint target, int offset, int size, IntPtr data);

			public delegate void glGetCompressedTexImage(uint target, int level, IntPtr img);

			public delegate void glGetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels);

			public delegate void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels);

			public delegate uint glGetDebugMessageLog(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, StringBuilder messageLog);

			public delegate void glGetDoublei_v(uint target, uint index, double[] data);

			public delegate void glGetDoublev(uint pname, double[] data);

			public delegate uint glGetError();

			public delegate void glGetFloati_v(uint target, uint index, float[] data);

			public delegate void glGetFloatv(uint pname, float[] data);

			public delegate int glGetFragDataIndex(uint program, string name);

			public delegate int glGetFragDataLocation(uint program, string name);

			public delegate void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int[] @params);

			public delegate void glGetFramebufferParameteriv(uint target, uint pname, int[] @params);

			public delegate uint glGetGraphicsResetStatus();

			public delegate void glGetInteger64i_v(uint target, uint index, long[] data);

			public delegate void glGetInteger64v(uint pname, long[] data);

			public delegate void glGetIntegeri_v(uint target, uint index, int[] data);

			public delegate void glGetIntegerv(uint pname, int[] data);

			public delegate void glGetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, long[] @params);

			public delegate void glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int[] @params);

			public delegate void glGetMultisamplefv(uint pname, uint index, float[] val);

			public delegate void glGetNamedBufferParameteri64v(uint buffer, uint pname, long[] @params);

			public delegate void glGetNamedBufferParameteriv(uint buffer, uint pname, int[] @params);

			public delegate void glGetNamedBufferPointerv(uint buffer, uint pname, IntPtr[] @params);

			public delegate void glGetNamedBufferSubData(uint buffer, int offset, int size, IntPtr data);

			public delegate void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int[] @params);

			public delegate void glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int[] param);

			public delegate void glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int[] @params);

			public delegate void glGetnCompressedTexImage(uint target, int lod, int bufSize, IntPtr pixels);

			public delegate void glGetnTexImage(uint target, int level, uint format, uint type, int bufSize, IntPtr pixels);

			public delegate void glGetnUniformdv(uint program, int location, int bufSize, double[] @params);

			public delegate void glGetnUniformfv(uint program, int location, int bufSize, float[] @params);

			public delegate void glGetnUniformiv(uint program, int location, int bufSize, int[] @params);

			public delegate void glGetnUniformuiv(uint program, int location, int bufSize, uint[] @params);

			public delegate void glGetObjectLabel(uint identifier, uint name, int bufSize, int[] length, StringBuilder label);

			public delegate void glGetObjectPtrLabel(IntPtr ptr, int bufSize, int[] length, StringBuilder label);

			public delegate void glGetPointerv(uint pname, IntPtr[] @params);

			public delegate void glGetProgramBinary(uint program, int bufSize, int[] length, uint[] binaryFormat, IntPtr binary);

			public delegate void glGetProgramInfoLog(uint program, int bufSize, out int length, StringBuilder infoLog);

			public delegate void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int[] @params);

			public delegate void glGetProgramiv(uint program, uint pname, out int @params);

			public delegate void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int[] length, StringBuilder infoLog);

			public delegate void glGetProgramPipelineiv(uint pipeline, uint pname, int[] @params);

			public delegate uint glGetProgramResourceIndex(uint program, uint programInterface, string name);

			public delegate void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, int[] @params);

			public delegate int glGetProgramResourceLocation(uint program, uint programInterface, string name);

			public delegate int glGetProgramResourceLocationIndex(uint program, uint programInterface, string name);

			public delegate void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int[] length, StringBuilder name);

			public delegate void glGetProgramStageiv(uint program, uint shadertype, uint pname, int[] values);

			public delegate void glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int offset);

			public delegate void glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, int offset);

			public delegate void glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int offset);

			public delegate void glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int offset);

			public delegate void glGetQueryIndexediv(uint target, uint index, uint pname, int[] @params);

			public delegate void glGetQueryiv(uint target, uint pname, int[] @params);

			public delegate void glGetQueryObjecti64v(uint id, uint pname, long[] @params);

			public delegate void glGetQueryObjectiv(uint id, uint pname, int[] @params);

			public delegate void glGetQueryObjectui64v(uint id, uint pname, ulong[] @params);

			public delegate void glGetQueryObjectuiv(uint id, uint pname, uint[] @params);

			public delegate void glGetRenderbufferParameteriv(uint target, uint pname, int[] @params);

			public delegate void glGetSamplerParameterfv(uint sampler, uint pname, float[] @params);

			public delegate void glGetSamplerParameterIiv(uint sampler, uint pname, int[] @params);

			public delegate void glGetSamplerParameterIuiv(uint sampler, uint pname, uint[] @params);

			public delegate void glGetSamplerParameteriv(uint sampler, uint pname, int[] @params);

			public delegate void glGetShaderInfoLog(uint shader, int bufSize, out int length, StringBuilder infoLog);

			public delegate void glGetShaderiv(uint shader, uint pname, out int @params);

			public delegate void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int[] range, int[] precision);

			public delegate void glGetShaderSource(uint shader, int bufSize, int[] length, StringBuilder source);

			public delegate IntPtr glGetString(uint name);

			public delegate IntPtr glGetStringi(uint name, uint index);

			public delegate uint glGetSubroutineIndex(uint program, uint shadertype, string name);

			public delegate int glGetSubroutineUniformLocation(uint program, uint shadertype, string name);

			public delegate void glGetSynciv(IntPtr sync, uint pname, int bufSize, int[] length, int[] values);

			public delegate void glGetTexImage(uint target, int level, uint format, uint type, IntPtr pixels);

			public delegate void glGetTexLevelParameterfv(uint target, int level, uint pname, float[] @params);

			public delegate void glGetTexLevelParameteriv(uint target, int level, uint pname, int[] @params);

			public delegate void glGetTexParameterfv(uint target, uint pname, float[] @params);

			public delegate void glGetTexParameterIiv(uint target, uint pname, int[] @params);

			public delegate void glGetTexParameterIuiv(uint target, uint pname, uint[] @params);

			public delegate void glGetTexParameteriv(uint target, uint pname, int[] @params);

			public delegate void glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels);

			public delegate void glGetTextureLevelParameterfv(uint texture, int level, uint pname, float[] @params);

			public delegate void glGetTextureLevelParameteriv(uint texture, int level, uint pname, int[] @params);

			public delegate void glGetTextureParameterfv(uint texture, uint pname, float[] @params);

			public delegate void glGetTextureParameterIiv(uint texture, uint pname, int[] @params);

			public delegate void glGetTextureParameterIuiv(uint texture, uint pname, uint[] @params);

			public delegate void glGetTextureParameteriv(uint texture, uint pname, int[] @params);

			public delegate void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels);

			public delegate void glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int[] param);

			public delegate void glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long[] param);

			public delegate void glGetTransformFeedbackiv(uint xfb, uint pname, int[] param);

			public delegate void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name);

			public delegate uint glGetUniformBlockIndex(uint program, string uniformBlockName);

			public delegate void glGetUniformdv(uint program, int location, double[] @params);

			public delegate void glGetUniformfv(uint program, int location, float[] @params);

			public delegate void glGetUniformIndices(uint program, int uniformCount, string[] uniformNames, uint[] uniformIndices);

			public delegate void glGetUniformiv(uint program, int location, int[] @params);

			public delegate int glGetUniformLocation(uint program, string name);

			public delegate void glGetUniformSubroutineuiv(uint shadertype, int location, uint[] @params);

			public delegate void glGetUniformuiv(uint program, int location, uint[] @params);

			public delegate void glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long[] param);

			public delegate void glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int[] param);

			public delegate void glGetVertexArrayiv(uint vaobj, uint pname, int[] param);

			public delegate void glGetVertexAttribdv(uint index, uint pname, double[] @params);

			public delegate void glGetVertexAttribfv(uint index, uint pname, float[] @params);

			public delegate void glGetVertexAttribIiv(uint index, uint pname, int[] @params);

			public delegate void glGetVertexAttribIuiv(uint index, uint pname, uint[] @params);

			public delegate void glGetVertexAttribiv(uint index, uint pname, int[] @params);

			public delegate void glGetVertexAttribLdv(uint index, uint pname, double[] @params);

			public delegate void glGetVertexAttribPointerv(uint index, uint pname, IntPtr[] pointer);

			public delegate void glHint(uint target, uint mode);

			public delegate void glInvalidateBufferData(uint buffer);

			public delegate void glInvalidateBufferSubData(uint buffer, int offset, int length);

			public delegate void glInvalidateFramebuffer(uint target, int numAttachments, uint[] attachments);

			public delegate void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint[] attachments);

			public delegate void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint[] attachments, int x, int y, int width, int height);

			public delegate void glInvalidateSubFramebuffer(uint target, int numAttachments, uint[] attachments, int x, int y, int width, int height);

			public delegate void glInvalidateTexImage(uint texture, int level);

			public delegate void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);

			public delegate bool glIsBuffer(uint buffer);

			public delegate bool glIsEnabled(uint cap);

			public delegate bool glIsEnabledi(uint target, uint index);

			public delegate bool glIsFramebuffer(uint framebuffer);

			public delegate bool glIsProgram(uint program);

			public delegate bool glIsProgramPipeline(uint pipeline);

			public delegate bool glIsQuery(uint id);

			public delegate bool glIsRenderbuffer(uint renderbuffer);

			public delegate bool glIsSampler(uint sampler);

			public delegate bool glIsShader(uint shader);

			public delegate bool glIsSync(IntPtr sync);

			public delegate bool glIsTexture(uint texture);

			public delegate bool glIsTransformFeedback(uint id);

			public delegate bool glIsVertexArray(uint array);

			public delegate void glLineWidth(float width);

			public delegate void glLinkProgram(uint program);

			public delegate void glLogicOp(uint opcode);

			public delegate IntPtr glMapBuffer(uint target, uint access);

			public delegate IntPtr glMapBufferRange(uint target, int offset, int length, uint access);

			public delegate IntPtr glMapNamedBuffer(uint buffer, uint access);

			public delegate IntPtr glMapNamedBufferRange(uint buffer, int offset, int length, uint access);

			public delegate void glMemoryBarrier(uint barriers);

			public delegate void glMemoryBarrierByRegion(uint barriers);

			public delegate void glMinSampleShading(float value);

			public delegate void glMultiDrawArrays(uint mode, int[] first, int[] count, int drawcount);

			public delegate void glMultiDrawArraysIndirect(uint mode, IntPtr indirect, int drawcount, int stride);

			public delegate void glMultiDrawElements(uint mode, int[] count, uint type, IntPtr[] indices, int drawcount);

			public delegate void glMultiDrawElementsBaseVertex(uint mode, int[] count, uint type, IntPtr[] indices, int drawcount, int[] basevertex);

			public delegate void glMultiDrawElementsIndirect(uint mode, uint type, IntPtr indirect, int drawcount, int stride);

			public delegate void glNamedBufferData(uint buffer, int size, IntPtr data, uint usage);

			public delegate void glNamedBufferStorage(uint buffer, int size, IntPtr data, uint flags);

			public delegate void glNamedBufferSubData(uint buffer, int offset, int size, IntPtr data);

			public delegate void glNamedFramebufferDrawBuffer(uint framebuffer, uint buf);

			public delegate void glNamedFramebufferDrawBuffers(uint framebuffer, int n, uint[] bufs);

			public delegate void glNamedFramebufferParameteri(uint framebuffer, uint pname, int param);

			public delegate void glNamedFramebufferReadBuffer(uint framebuffer, uint src);

			public delegate void glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);

			public delegate void glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level);

			public delegate void glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer);

			public delegate void glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height);

			public delegate void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height);

			public delegate void glObjectLabel(uint identifier, uint name, int length, string label);

			public delegate void glObjectPtrLabel(IntPtr ptr, int length, string label);

			public delegate void glPatchParameterfv(uint pname, float[] values);

			public delegate void glPatchParameteri(uint pname, int value);

			public delegate void glPauseTransformFeedback();

			public delegate void glPixelStoref(uint pname, float param);

			public delegate void glPixelStorei(uint pname, int param);

			public delegate void glPointParameterf(uint pname, float param);

			public delegate void glPointParameterfv(uint pname, float[] @params);

			public delegate void glPointParameteri(uint pname, int param);

			public delegate void glPointParameteriv(uint pname, int[] @params);

			public delegate void glPointSize(float size);

			public delegate void glPolygonMode(uint face, uint mode);

			public delegate void glPolygonOffset(float factor, float units);

			public delegate void glPopDebugGroup();

			public delegate void glPrimitiveRestartIndex(uint index);

			public delegate void glProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length);

			public delegate void glProgramParameteri(uint program, uint pname, int value);

			public delegate void glProgramUniform1d(uint program, int location, double v0);

			public delegate void glProgramUniform1dv(uint program, int location, int count, double[] value);

			public delegate void glProgramUniform1f(uint program, int location, float v0);

			public delegate void glProgramUniform1fv(uint program, int location, int count, float[] value);

			public delegate void glProgramUniform1i(uint program, int location, int v0);

			public delegate void glProgramUniform1iv(uint program, int location, int count, int[] value);

			public delegate void glProgramUniform1ui(uint program, int location, uint v0);

			public delegate void glProgramUniform1uiv(uint program, int location, int count, uint[] value);

			public delegate void glProgramUniform2d(uint program, int location, double v0, double v1);

			public delegate void glProgramUniform2dv(uint program, int location, int count, double[] value);

			public delegate void glProgramUniform2f(uint program, int location, float v0, float v1);

			public delegate void glProgramUniform2fv(uint program, int location, int count, float[] value);

			public delegate void glProgramUniform2i(uint program, int location, int v0, int v1);

			public delegate void glProgramUniform2iv(uint program, int location, int count, int[] value);

			public delegate void glProgramUniform2ui(uint program, int location, uint v0, uint v1);

			public delegate void glProgramUniform2uiv(uint program, int location, int count, uint[] value);

			public delegate void glProgramUniform3d(uint program, int location, double v0, double v1, double v2);

			public delegate void glProgramUniform3dv(uint program, int location, int count, double[] value);

			public delegate void glProgramUniform3f(uint program, int location, float v0, float v1, float v2);

			public delegate void glProgramUniform3fv(uint program, int location, int count, float[] value);

			public delegate void glProgramUniform3i(uint program, int location, int v0, int v1, int v2);

			public delegate void glProgramUniform3iv(uint program, int location, int count, int[] value);

			public delegate void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);

			public delegate void glProgramUniform3uiv(uint program, int location, int count, uint[] value);

			public delegate void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);

			public delegate void glProgramUniform4dv(uint program, int location, int count, double[] value);

			public delegate void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);

			public delegate void glProgramUniform4fv(uint program, int location, int count, float[] value);

			public delegate void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);

			public delegate void glProgramUniform4iv(uint program, int location, int count, int[] value);

			public delegate void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);

			public delegate void glProgramUniform4uiv(uint program, int location, int count, uint[] value);

			public delegate void glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double[] value);

			public delegate void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float[] value);

			public delegate void glProvokingVertex(uint mode);

			public delegate void glPushDebugGroup(uint source, uint id, int length, string message);

			public delegate void glQueryCounter(uint id, uint target);

			public delegate void glReadBuffer(uint src);

			public delegate void glReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data);

			public delegate void glReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels);

			public delegate void glReleaseShaderCompiler();

			public delegate void glRenderbufferStorage(uint target, uint internalformat, int width, int height);

			public delegate void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);

			public delegate void glResumeTransformFeedback();

			public delegate void glSampleCoverage(float value, bool invert);

			public delegate void glSampleMaski(uint maskNumber, uint mask);

			public delegate void glSamplerParameterf(uint sampler, uint pname, float param);

			public delegate void glSamplerParameterfv(uint sampler, uint pname, float[] param);

			public delegate void glSamplerParameteri(uint sampler, uint pname, int param);

			public delegate void glSamplerParameterIiv(uint sampler, uint pname, int[] param);

			public delegate void glSamplerParameterIuiv(uint sampler, uint pname, uint[] param);

			public delegate void glSamplerParameteriv(uint sampler, uint pname, int[] param);

			public delegate void glScissor(int x, int y, int width, int height);

			public delegate void glScissorArrayv(uint first, int count, int[] v);

			public delegate void glScissorIndexed(uint index, int left, int bottom, int width, int height);

			public delegate void glScissorIndexedv(uint index, int[] v);

			public delegate void glShaderBinary(int count, uint[] shaders, uint binaryformat, IntPtr binary, int length);

			public delegate void glShaderSource(uint shader, int count, ref string @string, ref int length);

			public delegate void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);

			public delegate void glStencilFunc(uint func, int @ref, uint mask);

			public delegate void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask);

			public delegate void glStencilMask(uint mask);

			public delegate void glStencilMaskSeparate(uint face, uint mask);

			public delegate void glStencilOp(uint fail, uint zfail, uint zpass);

			public delegate void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);

			public delegate void glTexBuffer(uint target, uint internalformat, uint buffer);

			public delegate void glTexBufferRange(uint target, uint internalformat, uint buffer, int offset, int size);

			public delegate void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels);

			public delegate void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);

			public delegate void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void glTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);

			public delegate void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void glTexParameterf(uint target, uint pname, float param);

			public delegate void glTexParameterfv(uint target, uint pname, float[] @params);

			public delegate void glTexParameteri(uint target, uint pname, int param);

			public delegate void glTexParameterIiv(uint target, uint pname, int[] @params);

			public delegate void glTexParameterIuiv(uint target, uint pname, uint[] @params);

			public delegate void glTexParameteriv(uint target, uint pname, int[] @params);

			public delegate void glTexStorage1D(uint target, int levels, uint internalformat, int width);

			public delegate void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height);

			public delegate void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);

			public delegate void glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);

			public delegate void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);

			public delegate void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

			public delegate void glTextureBarrier();

			public delegate void glTextureBuffer(uint texture, uint internalformat, uint buffer);

			public delegate void glTextureBufferRange(uint texture, uint internalformat, uint buffer, int offset, int size);

			public delegate void glTextureParameterf(uint texture, uint pname, float param);

			public delegate void glTextureParameterfv(uint texture, uint pname, float[] param);

			public delegate void glTextureParameteri(uint texture, uint pname, int param);

			public delegate void glTextureParameterIiv(uint texture, uint pname, int[] @params);

			public delegate void glTextureParameterIuiv(uint texture, uint pname, uint[] @params);

			public delegate void glTextureParameteriv(uint texture, uint pname, int[] param);

			public delegate void glTextureStorage1D(uint texture, int levels, uint internalformat, int width);

			public delegate void glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height);

			public delegate void glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth);

			public delegate void glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);

			public delegate void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);

			public delegate void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

			public delegate void glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

			public delegate void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer);

			public delegate void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size);

			public delegate void glTransformFeedbackVaryings(uint program, int count, string[] varyings, uint bufferMode);

			public delegate void glUniform1d(int location, double x);

			public delegate void glUniform1dv(int location, int count, double[] value);

			public delegate void glUniform1f(int location, float v0);

			public delegate void glUniform1fv(int location, int count, float[] value);

			public delegate void glUniform1i(int location, int v0);

			public delegate void glUniform1iv(int location, int count, int[] value);

			public delegate void glUniform1ui(int location, uint v0);

			public delegate void glUniform1uiv(int location, int count, uint[] value);

			public delegate void glUniform2d(int location, double x, double y);

			public delegate void glUniform2dv(int location, int count, double[] value);

			public delegate void glUniform2f(int location, float v0, float v1);

			public delegate void glUniform2fv(int location, int count, float[] value);

			public delegate void glUniform2i(int location, int v0, int v1);

			public delegate void glUniform2iv(int location, int count, int[] value);

			public delegate void glUniform2ui(int location, uint v0, uint v1);

			public delegate void glUniform2uiv(int location, int count, uint[] value);

			public delegate void glUniform3d(int location, double x, double y, double z);

			public delegate void glUniform3dv(int location, int count, double[] value);

			public delegate void glUniform3f(int location, float v0, float v1, float v2);

			public delegate void glUniform3fv(int location, int count, float[] value);

			public delegate void glUniform3i(int location, int v0, int v1, int v2);

			public delegate void glUniform3iv(int location, int count, int[] value);

			public delegate void glUniform3ui(int location, uint v0, uint v1, uint v2);

			public delegate void glUniform3uiv(int location, int count, uint[] value);

			public delegate void glUniform4d(int location, double x, double y, double z, double w);

			public delegate void glUniform4dv(int location, int count, double[] value);

			public delegate void glUniform4f(int location, float v0, float v1, float v2, float v3);

			public delegate void glUniform4fv(int location, int count, float[] value);

			public delegate void glUniform4i(int location, int v0, int v1, int v2, int v3);

			public delegate void glUniform4iv(int location, int count, int[] value);

			public delegate void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);

			public delegate void glUniform4uiv(int location, int count, uint[] value);

			public delegate void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

			public delegate void glUniformMatrix2dv(int location, int count, bool transpose, double[] value);

			public delegate void glUniformMatrix2fv(int location, int count, bool transpose, float[] value);

			public delegate void glUniformMatrix2x3dv(int location, int count, bool transpose, double[] value);

			public delegate void glUniformMatrix2x3fv(int location, int count, bool transpose, float[] value);

			public delegate void glUniformMatrix2x4dv(int location, int count, bool transpose, double[] value);

			public delegate void glUniformMatrix2x4fv(int location, int count, bool transpose, float[] value);

			public delegate void glUniformMatrix3dv(int location, int count, bool transpose, double[] value);

			public delegate void glUniformMatrix3fv(int location, int count, bool transpose, float[] value);

			public delegate void glUniformMatrix3x2dv(int location, int count, bool transpose, double[] value);

			public delegate void glUniformMatrix3x2fv(int location, int count, bool transpose, float[] value);

			public delegate void glUniformMatrix3x4dv(int location, int count, bool transpose, double[] value);

			public delegate void glUniformMatrix3x4fv(int location, int count, bool transpose, float[] value);

			public delegate void glUniformMatrix4dv(int location, int count, bool transpose, double[] value);

			public delegate void glUniformMatrix4fv(int location, int count, bool transpose, float[] value);

			public delegate void glUniformMatrix4fvByRef(int location, int count, bool transpose, ref float value);

			public delegate void glUniformMatrix4x2dv(int location, int count, bool transpose, double[] value);

			public delegate void glUniformMatrix4x2fv(int location, int count, bool transpose, float[] value);

			public delegate void glUniformMatrix4x3dv(int location, int count, bool transpose, double[] value);

			public delegate void glUniformMatrix4x3fv(int location, int count, bool transpose, float[] value);

			public delegate void glUniformSubroutinesuiv(uint shadertype, int count, uint[] indices);

			public delegate bool glUnmapBuffer(uint target);

			public delegate bool glUnmapNamedBuffer(uint buffer);

			public delegate void glUseProgram(uint program);

			public delegate void glUseProgramStages(uint pipeline, uint stages, uint program);

			public delegate void glValidateProgram(uint program);

			public delegate void glValidateProgramPipeline(uint pipeline);

			public delegate void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex);

			public delegate void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);

			public delegate void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor);

			public delegate void glVertexArrayElementBuffer(uint vaobj, uint buffer);

			public delegate void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride);

			public delegate void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint[] buffers, int[] offsets, int[] strides);

			public delegate void glVertexAttrib1d(uint index, double x);

			public delegate void glVertexAttrib1dv(uint index, double[] v);

			public delegate void glVertexAttrib1f(uint index, float x);

			public delegate void glVertexAttrib1fv(uint index, float[] v);

			public delegate void glVertexAttrib1s(uint index, short x);

			public delegate void glVertexAttrib1sv(uint index, short[] v);

			public delegate void glVertexAttrib2d(uint index, double x, double y);

			public delegate void glVertexAttrib2dv(uint index, double[] v);

			public delegate void glVertexAttrib2f(uint index, float x, float y);

			public delegate void glVertexAttrib2fv(uint index, float[] v);

			public delegate void glVertexAttrib2s(uint index, short x, short y);

			public delegate void glVertexAttrib2sv(uint index, short[] v);

			public delegate void glVertexAttrib3d(uint index, double x, double y, double z);

			public delegate void glVertexAttrib3dv(uint index, double[] v);

			public delegate void glVertexAttrib3f(uint index, float x, float y, float z);

			public delegate void glVertexAttrib3fv(uint index, float[] v);

			public delegate void glVertexAttrib3s(uint index, short x, short y, short z);

			public delegate void glVertexAttrib3sv(uint index, short[] v);

			public delegate void glVertexAttrib4bv(uint index, sbyte[] v);

			public delegate void glVertexAttrib4d(uint index, double x, double y, double z, double w);

			public delegate void glVertexAttrib4dv(uint index, double[] v);

			public delegate void glVertexAttrib4f(uint index, float x, float y, float z, float w);

			public delegate void glVertexAttrib4fv(uint index, float[] v);

			public delegate void glVertexAttrib4iv(uint index, int[] v);

			public delegate void glVertexAttrib4Nbv(uint index, sbyte[] v);

			public delegate void glVertexAttrib4Niv(uint index, int[] v);

			public delegate void glVertexAttrib4Nsv(uint index, short[] v);

			public delegate void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);

			public delegate void glVertexAttrib4Nubv(uint index, byte[] v);

			public delegate void glVertexAttrib4Nuiv(uint index, uint[] v);

			public delegate void glVertexAttrib4Nusv(uint index, ushort[] v);

			public delegate void glVertexAttrib4s(uint index, short x, short y, short z, short w);

			public delegate void glVertexAttrib4sv(uint index, short[] v);

			public delegate void glVertexAttrib4ubv(uint index, byte[] v);

			public delegate void glVertexAttrib4uiv(uint index, uint[] v);

			public delegate void glVertexAttrib4usv(uint index, ushort[] v);

			public delegate void glVertexAttribBinding(uint attribindex, uint bindingindex);

			public delegate void glVertexAttribDivisor(uint index, uint divisor);

			public delegate void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);

			public delegate void glVertexAttribI1i(uint index, int x);

			public delegate void glVertexAttribI1iv(uint index, int[] v);

			public delegate void glVertexAttribI1ui(uint index, uint x);

			public delegate void glVertexAttribI1uiv(uint index, uint[] v);

			public delegate void glVertexAttribI2i(uint index, int x, int y);

			public delegate void glVertexAttribI2iv(uint index, int[] v);

			public delegate void glVertexAttribI2ui(uint index, uint x, uint y);

			public delegate void glVertexAttribI2uiv(uint index, uint[] v);

			public delegate void glVertexAttribI3i(uint index, int x, int y, int z);

			public delegate void glVertexAttribI3iv(uint index, int[] v);

			public delegate void glVertexAttribI3ui(uint index, uint x, uint y, uint z);

			public delegate void glVertexAttribI3uiv(uint index, uint[] v);

			public delegate void glVertexAttribI4bv(uint index, sbyte[] v);

			public delegate void glVertexAttribI4i(uint index, int x, int y, int z, int w);

			public delegate void glVertexAttribI4iv(uint index, int[] v);

			public delegate void glVertexAttribI4sv(uint index, short[] v);

			public delegate void glVertexAttribI4ubv(uint index, byte[] v);

			public delegate void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);

			public delegate void glVertexAttribI4uiv(uint index, uint[] v);

			public delegate void glVertexAttribI4usv(uint index, ushort[] v);

			public delegate void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void glVertexAttribIPointer(uint index, int size, uint type, int stride, IntPtr pointer);

			public delegate void glVertexAttribL1d(uint index, double x);

			public delegate void glVertexAttribL1dv(uint index, double[] v);

			public delegate void glVertexAttribL2d(uint index, double x, double y);

			public delegate void glVertexAttribL2dv(uint index, double[] v);

			public delegate void glVertexAttribL3d(uint index, double x, double y, double z);

			public delegate void glVertexAttribL3dv(uint index, double[] v);

			public delegate void glVertexAttribL4d(uint index, double x, double y, double z, double w);

			public delegate void glVertexAttribL4dv(uint index, double[] v);

			public delegate void glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void glVertexAttribLPointer(uint index, int size, uint type, int stride, IntPtr pointer);

			public delegate void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value);

			public delegate void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint[] value);

			public delegate void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value);

			public delegate void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint[] value);

			public delegate void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value);

			public delegate void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint[] value);

			public delegate void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value);

			public delegate void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint[] value);

			public delegate void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer);

			public delegate void glVertexBindingDivisor(uint bindingindex, uint divisor);

			public delegate void glViewport(int x, int y, int width, int height);

			public delegate void glViewportArrayv(uint first, int count, float[] v);

			public delegate void glViewportIndexedf(uint index, float x, float y, float w, float h);

			public delegate void glViewportIndexedfv(uint index, float[] v);

			public delegate void glWaitSync(IntPtr sync, uint flags, ulong timeout);

		}

		public static Delegates.glActiveShaderProgram glActiveShaderProgram { get; private set; }

		public static Delegates.glActiveTexture glActiveTexture { get; private set; }

		public static Delegates.glAttachShader glAttachShader { get; private set; }

		public static Delegates.glBeginConditionalRender glBeginConditionalRender { get; private set; }

		public static Delegates.glBeginQuery glBeginQuery { get; private set; }

		public static Delegates.glBeginQueryIndexed glBeginQueryIndexed { get; private set; }

		public static Delegates.glBeginTransformFeedback glBeginTransformFeedback { get; private set; }

		public static Delegates.glBindAttribLocation glBindAttribLocation { get; private set; }

		public static Delegates.glBindBuffer glBindBuffer { get; private set; }

		public static Delegates.glBindBufferBase glBindBufferBase { get; private set; }

		public static Delegates.glBindBufferRange glBindBufferRange { get; private set; }

		public static Delegates.glBindBuffersBase glBindBuffersBase { get; private set; }

		public static Delegates.glBindBuffersRange glBindBuffersRange { get; private set; }

		public static Delegates.glBindFragDataLocation glBindFragDataLocation { get; private set; }

		public static Delegates.glBindFragDataLocationIndexed glBindFragDataLocationIndexed { get; private set; }

		public static Delegates.glBindFramebuffer glBindFramebuffer { get; private set; }

		public static Delegates.glBindImageTexture glBindImageTexture { get; private set; }

		public static Delegates.glBindImageTextures glBindImageTextures { get; private set; }

		public static Delegates.glBindProgramPipeline glBindProgramPipeline { get; private set; }

		public static Delegates.glBindRenderbuffer glBindRenderbuffer { get; private set; }

		public static Delegates.glBindSampler glBindSampler { get; private set; }

		public static Delegates.glBindSamplers glBindSamplers { get; private set; }

		public static Delegates.glBindTexture glBindTexture { get; private set; }

		public static Delegates.glBindTextures glBindTextures { get; private set; }

		public static Delegates.glBindTextureUnit glBindTextureUnit { get; private set; }

		public static Delegates.glBindTransformFeedback glBindTransformFeedback { get; private set; }

		public static Delegates.glBindVertexArray glBindVertexArray { get; private set; }

		public static Delegates.glBindVertexBuffer glBindVertexBuffer { get; private set; }

		public static Delegates.glBindVertexBuffers glBindVertexBuffers { get; private set; }

		public static Delegates.glBlendColor glBlendColor { get; private set; }

		public static Delegates.glBlendEquation glBlendEquation { get; private set; }

		public static Delegates.glBlendEquationi glBlendEquationi { get; private set; }

		public static Delegates.glBlendEquationSeparate glBlendEquationSeparate { get; private set; }

		public static Delegates.glBlendEquationSeparatei glBlendEquationSeparatei { get; private set; }

		public static Delegates.glBlendFunc glBlendFunc { get; private set; }

		public static Delegates.glBlendFunci glBlendFunci { get; private set; }

		public static Delegates.glBlendFuncSeparate glBlendFuncSeparate { get; private set; }

		public static Delegates.glBlendFuncSeparatei glBlendFuncSeparatei { get; private set; }

		public static Delegates.glBlitFramebuffer glBlitFramebuffer { get; private set; }

		public static Delegates.glBlitNamedFramebuffer glBlitNamedFramebuffer { get; private set; }

		public static Delegates.glBufferData glBufferData { get; private set; }

		public static Delegates.glBufferStorage glBufferStorage { get; private set; }

		public static Delegates.glBufferSubData glBufferSubData { get; private set; }

		public static Delegates.glCheckFramebufferStatus glCheckFramebufferStatus { get; private set; }

		public static Delegates.glCheckNamedFramebufferStatus glCheckNamedFramebufferStatus { get; private set; }

		public static Delegates.glClampColor glClampColor { get; private set; }

		public static Delegates.glClear glClear { get; private set; }

		public static Delegates.glClearBufferData glClearBufferData { get; private set; }

		public static Delegates.glClearBufferfi glClearBufferfi { get; private set; }

		public static Delegates.glClearBufferfv glClearBufferfv { get; private set; }

		public static Delegates.glClearBufferiv glClearBufferiv { get; private set; }

		public static Delegates.glClearBufferSubData glClearBufferSubData { get; private set; }

		public static Delegates.glClearBufferuiv glClearBufferuiv { get; private set; }

		public static Delegates.glClearColor glClearColor { get; private set; }

		public static Delegates.glClearDepth glClearDepth { get; private set; }

		public static Delegates.glClearDepthf glClearDepthf { get; private set; }

		public static Delegates.glClearNamedBufferData glClearNamedBufferData { get; private set; }

		public static Delegates.glClearNamedBufferSubData glClearNamedBufferSubData { get; private set; }

		public static Delegates.glClearNamedFramebufferfi glClearNamedFramebufferfi { get; private set; }

		public static Delegates.glClearNamedFramebufferfv glClearNamedFramebufferfv { get; private set; }

		public static Delegates.glClearNamedFramebufferiv glClearNamedFramebufferiv { get; private set; }

		public static Delegates.glClearNamedFramebufferuiv glClearNamedFramebufferuiv { get; private set; }

		public static Delegates.glClearStencil glClearStencil { get; private set; }

		public static Delegates.glClearTexImage glClearTexImage { get; private set; }

		public static Delegates.glClearTexSubImage glClearTexSubImage { get; private set; }

		public static Delegates.glClientWaitSync glClientWaitSync { get; private set; }

		public static Delegates.glClipControl glClipControl { get; private set; }

		public static Delegates.glColorMask glColorMask { get; private set; }

		public static Delegates.glColorMaski glColorMaski { get; private set; }

		public static Delegates.glCompileShader glCompileShader { get; private set; }

		public static Delegates.glCompressedTexImage1D glCompressedTexImage1D { get; private set; }

		public static Delegates.glCompressedTexImage2D glCompressedTexImage2D { get; private set; }

		public static Delegates.glCompressedTexImage3D glCompressedTexImage3D { get; private set; }

		public static Delegates.glCompressedTexSubImage1D glCompressedTexSubImage1D { get; private set; }

		public static Delegates.glCompressedTexSubImage2D glCompressedTexSubImage2D { get; private set; }

		public static Delegates.glCompressedTexSubImage3D glCompressedTexSubImage3D { get; private set; }

		public static Delegates.glCompressedTextureSubImage1D glCompressedTextureSubImage1D { get; private set; }

		public static Delegates.glCompressedTextureSubImage2D glCompressedTextureSubImage2D { get; private set; }

		public static Delegates.glCompressedTextureSubImage3D glCompressedTextureSubImage3D { get; private set; }

		public static Delegates.glCopyBufferSubData glCopyBufferSubData { get; private set; }

		public static Delegates.glCopyImageSubData glCopyImageSubData { get; private set; }

		public static Delegates.glCopyNamedBufferSubData glCopyNamedBufferSubData { get; private set; }

		public static Delegates.glCopyTexImage1D glCopyTexImage1D { get; private set; }

		public static Delegates.glCopyTexImage2D glCopyTexImage2D { get; private set; }

		public static Delegates.glCopyTexSubImage1D glCopyTexSubImage1D { get; private set; }

		public static Delegates.glCopyTexSubImage2D glCopyTexSubImage2D { get; private set; }

		public static Delegates.glCopyTexSubImage3D glCopyTexSubImage3D { get; private set; }

		public static Delegates.glCopyTextureSubImage1D glCopyTextureSubImage1D { get; private set; }

		public static Delegates.glCopyTextureSubImage2D glCopyTextureSubImage2D { get; private set; }

		public static Delegates.glCopyTextureSubImage3D glCopyTextureSubImage3D { get; private set; }

		public static Delegates.glCreateBuffers glCreateBuffers { get; private set; }

		public static Delegates.glCreateFramebuffers glCreateFramebuffers { get; private set; }

		public static Delegates.glCreateProgram glCreateProgram { get; private set; }

		public static Delegates.glCreateProgramPipelines glCreateProgramPipelines { get; private set; }

		public static Delegates.glCreateQueries glCreateQueries { get; private set; }

		public static Delegates.glCreateRenderbuffers glCreateRenderbuffers { get; private set; }

		public static Delegates.glCreateSamplers glCreateSamplers { get; private set; }

		public static Delegates.glCreateShader glCreateShader { get; private set; }

		public static Delegates.glCreateShaderProgramv glCreateShaderProgramv { get; private set; }

		public static Delegates.glCreateTextures glCreateTextures { get; private set; }

		public static Delegates.glCreateTransformFeedbacks glCreateTransformFeedbacks { get; private set; }

		public static Delegates.glCreateVertexArrays glCreateVertexArrays { get; private set; }

		public static Delegates.glCullFace glCullFace { get; private set; }

		public static Delegates.glDebugMessageCallback glDebugMessageCallback { get; private set; }

		public static Delegates.glDebugMessageControl glDebugMessageControl { get; private set; }

		public static Delegates.glDebugMessageInsert glDebugMessageInsert { get; private set; }

		public static Delegates.glDeleteBuffers glDeleteBuffers { get; private set; }

		public static Delegates.glDeleteFramebuffers glDeleteFramebuffers { get; private set; }

		public static Delegates.glDeleteProgram glDeleteProgram { get; private set; }

		public static Delegates.glDeleteProgramPipelines glDeleteProgramPipelines { get; private set; }

		public static Delegates.glDeleteQueries glDeleteQueries { get; private set; }

		public static Delegates.glDeleteRenderbuffers glDeleteRenderbuffers { get; private set; }

		public static Delegates.glDeleteSamplers glDeleteSamplers { get; private set; }

		public static Delegates.glDeleteShader glDeleteShader { get; private set; }

		public static Delegates.glDeleteSync glDeleteSync { get; private set; }

		public static Delegates.glDeleteTextures glDeleteTextures { get; private set; }

		public static Delegates.glDeleteTransformFeedbacks glDeleteTransformFeedbacks { get; private set; }

		public static Delegates.glDeleteVertexArrays glDeleteVertexArrays { get; private set; }

		public static Delegates.glDepthFunc glDepthFunc { get; private set; }

		public static Delegates.glDepthMask glDepthMask { get; private set; }

		public static Delegates.glDepthRange glDepthRange { get; private set; }

		public static Delegates.glDepthRangeArrayv glDepthRangeArrayv { get; private set; }

		public static Delegates.glDepthRangef glDepthRangef { get; private set; }

		public static Delegates.glDepthRangeIndexed glDepthRangeIndexed { get; private set; }

		public static Delegates.glDetachShader glDetachShader { get; private set; }

		public static Delegates.glDisable glDisable { get; private set; }

		public static Delegates.glDisablei glDisablei { get; private set; }

		public static Delegates.glDisableVertexArrayAttrib glDisableVertexArrayAttrib { get; private set; }

		public static Delegates.glDisableVertexAttribArray glDisableVertexAttribArray { get; private set; }

		public static Delegates.glDispatchCompute glDispatchCompute { get; private set; }

		public static Delegates.glDispatchComputeIndirect glDispatchComputeIndirect { get; private set; }

		public static Delegates.glDrawArrays glDrawArrays { get; private set; }

		public static Delegates.glDrawArraysIndirect glDrawArraysIndirect { get; private set; }

		public static Delegates.glDrawArraysInstanced glDrawArraysInstanced { get; private set; }

		public static Delegates.glDrawArraysInstancedBaseInstance glDrawArraysInstancedBaseInstance { get; private set; }

		public static Delegates.glDrawBuffer glDrawBuffer { get; private set; }

		public static Delegates.glDrawBuffers glDrawBuffers { get; private set; }

		public static Delegates.glDrawElements glDrawElements { get; private set; }

		public static Delegates.glDrawElementsBaseVertex glDrawElementsBaseVertex { get; private set; }

		public static Delegates.glDrawElementsIndirect glDrawElementsIndirect { get; private set; }

		public static Delegates.glDrawElementsInstanced glDrawElementsInstanced { get; private set; }

		public static Delegates.glDrawElementsInstancedBaseInstance glDrawElementsInstancedBaseInstance { get; private set; }

		public static Delegates.glDrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex { get; private set; }

		public static Delegates.glDrawElementsInstancedBaseVertexBaseInstance glDrawElementsInstancedBaseVertexBaseInstance { get; private set; }

		public static Delegates.glDrawRangeElements glDrawRangeElements { get; private set; }

		public static Delegates.glDrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex { get; private set; }

		public static Delegates.glDrawTransformFeedback glDrawTransformFeedback { get; private set; }

		public static Delegates.glDrawTransformFeedbackInstanced glDrawTransformFeedbackInstanced { get; private set; }

		public static Delegates.glDrawTransformFeedbackStream glDrawTransformFeedbackStream { get; private set; }

		public static Delegates.glDrawTransformFeedbackStreamInstanced glDrawTransformFeedbackStreamInstanced { get; private set; }

		public static Delegates.glEnable glEnable { get; private set; }

		public static Delegates.glEnablei glEnablei { get; private set; }

		public static Delegates.glEnableVertexArrayAttrib glEnableVertexArrayAttrib { get; private set; }

		public static Delegates.glEnableVertexAttribArray glEnableVertexAttribArray { get; private set; }

		public static Delegates.glEndConditionalRender glEndConditionalRender { get; private set; }

		public static Delegates.glEndQuery glEndQuery { get; private set; }

		public static Delegates.glEndQueryIndexed glEndQueryIndexed { get; private set; }

		public static Delegates.glEndTransformFeedback glEndTransformFeedback { get; private set; }

		public static Delegates.glFenceSync glFenceSync { get; private set; }

		public static Delegates.glFinish glFinish { get; private set; }

		public static Delegates.glFlush glFlush { get; private set; }

		public static Delegates.glFlushMappedBufferRange glFlushMappedBufferRange { get; private set; }

		public static Delegates.glFlushMappedNamedBufferRange glFlushMappedNamedBufferRange { get; private set; }

		public static Delegates.glFramebufferParameteri glFramebufferParameteri { get; private set; }

		public static Delegates.glFramebufferRenderbuffer glFramebufferRenderbuffer { get; private set; }

		public static Delegates.glFramebufferTexture glFramebufferTexture { get; private set; }

		public static Delegates.glFramebufferTexture1D glFramebufferTexture1D { get; private set; }

		public static Delegates.glFramebufferTexture2D glFramebufferTexture2D { get; private set; }

		public static Delegates.glFramebufferTexture3D glFramebufferTexture3D { get; private set; }

		public static Delegates.glFramebufferTextureLayer glFramebufferTextureLayer { get; private set; }

		public static Delegates.glFrontFace glFrontFace { get; private set; }

		public static Delegates.glGenBuffers glGenBuffers { get; private set; }

		public static Delegates.glGenerateMipmap glGenerateMipmap { get; private set; }

		public static Delegates.glGenerateTextureMipmap glGenerateTextureMipmap { get; private set; }

		public static Delegates.glGenFramebuffers glGenFramebuffers { get; private set; }

		public static Delegates.glGenProgramPipelines glGenProgramPipelines { get; private set; }

		public static Delegates.glGenQueries glGenQueries { get; private set; }

		public static Delegates.glGenRenderbuffers glGenRenderbuffers { get; private set; }

		public static Delegates.glGenSamplers glGenSamplers { get; private set; }

		public static Delegates.glGenTextures glGenTextures { get; private set; }

		public static Delegates.glGenTransformFeedbacks glGenTransformFeedbacks { get; private set; }

		public static Delegates.glGenVertexArrays glGenVertexArrays { get; private set; }

		public static Delegates.glGetActiveAtomicCounterBufferiv glGetActiveAtomicCounterBufferiv { get; private set; }

		public static Delegates.glGetActiveAttrib glGetActiveAttrib { get; private set; }

		public static Delegates.glGetActiveSubroutineName glGetActiveSubroutineName { get; private set; }

		public static Delegates.glGetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv { get; private set; }

		public static Delegates.glGetActiveSubroutineUniformName glGetActiveSubroutineUniformName { get; private set; }

		public static Delegates.glGetActiveUniform glGetActiveUniform { get; private set; }

		public static Delegates.glGetActiveUniformBlockiv glGetActiveUniformBlockiv { get; private set; }

		public static Delegates.glGetActiveUniformBlockName glGetActiveUniformBlockName { get; private set; }

		public static Delegates.glGetActiveUniformName glGetActiveUniformName { get; private set; }

		public static Delegates.glGetActiveUniformsiv glGetActiveUniformsiv { get; private set; }

		public static Delegates.glGetAttachedShaders glGetAttachedShaders { get; private set; }

		public static Delegates.glGetAttribLocation glGetAttribLocation { get; private set; }

		public static Delegates.glGetBooleani_v glGetBooleani_v { get; private set; }

		public static Delegates.glGetBooleanv glGetBooleanv { get; private set; }

		public static Delegates.glGetBufferParameteri64v glGetBufferParameteri64v { get; private set; }

		public static Delegates.glGetBufferParameteriv glGetBufferParameteriv { get; private set; }

		public static Delegates.glGetBufferPointerv glGetBufferPointerv { get; private set; }

		public static Delegates.glGetBufferSubData glGetBufferSubData { get; private set; }

		public static Delegates.glGetCompressedTexImage glGetCompressedTexImage { get; private set; }

		public static Delegates.glGetCompressedTextureImage glGetCompressedTextureImage { get; private set; }

		public static Delegates.glGetCompressedTextureSubImage glGetCompressedTextureSubImage { get; private set; }

		public static Delegates.glGetDebugMessageLog glGetDebugMessageLog { get; private set; }

		public static Delegates.glGetDoublei_v glGetDoublei_v { get; private set; }

		public static Delegates.glGetDoublev glGetDoublev { get; private set; }

		public static Delegates.glGetError glGetError { get; private set; }

		public static Delegates.glGetFloati_v glGetFloati_v { get; private set; }

		public static Delegates.glGetFloatv glGetFloatv { get; private set; }

		public static Delegates.glGetFragDataIndex glGetFragDataIndex { get; private set; }

		public static Delegates.glGetFragDataLocation glGetFragDataLocation { get; private set; }

		public static Delegates.glGetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv { get; private set; }

		public static Delegates.glGetFramebufferParameteriv glGetFramebufferParameteriv { get; private set; }

		public static Delegates.glGetGraphicsResetStatus glGetGraphicsResetStatus { get; private set; }

		public static Delegates.glGetInteger64i_v glGetInteger64i_v { get; private set; }

		public static Delegates.glGetInteger64v glGetInteger64v { get; private set; }

		public static Delegates.glGetIntegeri_v glGetIntegeri_v { get; private set; }

		public static Delegates.glGetIntegerv glGetIntegerv { get; private set; }

		public static Delegates.glGetInternalformati64v glGetInternalformati64v { get; private set; }

		public static Delegates.glGetInternalformativ glGetInternalformativ { get; private set; }

		public static Delegates.glGetMultisamplefv glGetMultisamplefv { get; private set; }

		public static Delegates.glGetNamedBufferParameteri64v glGetNamedBufferParameteri64v { get; private set; }

		public static Delegates.glGetNamedBufferParameteriv glGetNamedBufferParameteriv { get; private set; }

		public static Delegates.glGetNamedBufferPointerv glGetNamedBufferPointerv { get; private set; }

		public static Delegates.glGetNamedBufferSubData glGetNamedBufferSubData { get; private set; }

		public static Delegates.glGetNamedFramebufferAttachmentParameteriv glGetNamedFramebufferAttachmentParameteriv { get; private set; }

		public static Delegates.glGetNamedFramebufferParameteriv glGetNamedFramebufferParameteriv { get; private set; }

		public static Delegates.glGetNamedRenderbufferParameteriv glGetNamedRenderbufferParameteriv { get; private set; }

		public static Delegates.glGetnCompressedTexImage glGetnCompressedTexImage { get; private set; }

		public static Delegates.glGetnTexImage glGetnTexImage { get; private set; }

		public static Delegates.glGetnUniformdv glGetnUniformdv { get; private set; }

		public static Delegates.glGetnUniformfv glGetnUniformfv { get; private set; }

		public static Delegates.glGetnUniformiv glGetnUniformiv { get; private set; }

		public static Delegates.glGetnUniformuiv glGetnUniformuiv { get; private set; }

		public static Delegates.glGetObjectLabel glGetObjectLabel { get; private set; }

		public static Delegates.glGetObjectPtrLabel glGetObjectPtrLabel { get; private set; }

		public static Delegates.glGetPointerv glGetPointerv { get; private set; }

		public static Delegates.glGetProgramBinary glGetProgramBinary { get; private set; }

		public static Delegates.glGetProgramInfoLog glGetProgramInfoLog { get; private set; }

		public static Delegates.glGetProgramInterfaceiv glGetProgramInterfaceiv { get; private set; }

		public static Delegates.glGetProgramiv glGetProgramiv { get; private set; }

		public static Delegates.glGetProgramPipelineInfoLog glGetProgramPipelineInfoLog { get; private set; }

		public static Delegates.glGetProgramPipelineiv glGetProgramPipelineiv { get; private set; }

		public static Delegates.glGetProgramResourceIndex glGetProgramResourceIndex { get; private set; }

		public static Delegates.glGetProgramResourceiv glGetProgramResourceiv { get; private set; }

		public static Delegates.glGetProgramResourceLocation glGetProgramResourceLocation { get; private set; }

		public static Delegates.glGetProgramResourceLocationIndex glGetProgramResourceLocationIndex { get; private set; }

		public static Delegates.glGetProgramResourceName glGetProgramResourceName { get; private set; }

		public static Delegates.glGetProgramStageiv glGetProgramStageiv { get; private set; }

		public static Delegates.glGetQueryBufferObjecti64v glGetQueryBufferObjecti64v { get; private set; }

		public static Delegates.glGetQueryBufferObjectiv glGetQueryBufferObjectiv { get; private set; }

		public static Delegates.glGetQueryBufferObjectui64v glGetQueryBufferObjectui64v { get; private set; }

		public static Delegates.glGetQueryBufferObjectuiv glGetQueryBufferObjectuiv { get; private set; }

		public static Delegates.glGetQueryIndexediv glGetQueryIndexediv { get; private set; }

		public static Delegates.glGetQueryiv glGetQueryiv { get; private set; }

		public static Delegates.glGetQueryObjecti64v glGetQueryObjecti64v { get; private set; }

		public static Delegates.glGetQueryObjectiv glGetQueryObjectiv { get; private set; }

		public static Delegates.glGetQueryObjectui64v glGetQueryObjectui64v { get; private set; }

		public static Delegates.glGetQueryObjectuiv glGetQueryObjectuiv { get; private set; }

		public static Delegates.glGetRenderbufferParameteriv glGetRenderbufferParameteriv { get; private set; }

		public static Delegates.glGetSamplerParameterfv glGetSamplerParameterfv { get; private set; }

		public static Delegates.glGetSamplerParameterIiv glGetSamplerParameterIiv { get; private set; }

		public static Delegates.glGetSamplerParameterIuiv glGetSamplerParameterIuiv { get; private set; }

		public static Delegates.glGetSamplerParameteriv glGetSamplerParameteriv { get; private set; }

		public static Delegates.glGetShaderInfoLog glGetShaderInfoLog { get; private set; }

		public static Delegates.glGetShaderiv glGetShaderiv { get; private set; }

		public static Delegates.glGetShaderPrecisionFormat glGetShaderPrecisionFormat { get; private set; }

		public static Delegates.glGetShaderSource glGetShaderSource { get; private set; }

		public static Delegates.glGetString glGetString { get; private set; }

		public static Delegates.glGetStringi glGetStringi { get; private set; }

		public static Delegates.glGetSubroutineIndex glGetSubroutineIndex { get; private set; }

		public static Delegates.glGetSubroutineUniformLocation glGetSubroutineUniformLocation { get; private set; }

		public static Delegates.glGetSynciv glGetSynciv { get; private set; }

		public static Delegates.glGetTexImage glGetTexImage { get; private set; }

		public static Delegates.glGetTexLevelParameterfv glGetTexLevelParameterfv { get; private set; }

		public static Delegates.glGetTexLevelParameteriv glGetTexLevelParameteriv { get; private set; }

		public static Delegates.glGetTexParameterfv glGetTexParameterfv { get; private set; }

		public static Delegates.glGetTexParameterIiv glGetTexParameterIiv { get; private set; }

		public static Delegates.glGetTexParameterIuiv glGetTexParameterIuiv { get; private set; }

		public static Delegates.glGetTexParameteriv glGetTexParameteriv { get; private set; }

		public static Delegates.glGetTextureImage glGetTextureImage { get; private set; }

		public static Delegates.glGetTextureLevelParameterfv glGetTextureLevelParameterfv { get; private set; }

		public static Delegates.glGetTextureLevelParameteriv glGetTextureLevelParameteriv { get; private set; }

		public static Delegates.glGetTextureParameterfv glGetTextureParameterfv { get; private set; }

		public static Delegates.glGetTextureParameterIiv glGetTextureParameterIiv { get; private set; }

		public static Delegates.glGetTextureParameterIuiv glGetTextureParameterIuiv { get; private set; }

		public static Delegates.glGetTextureParameteriv glGetTextureParameteriv { get; private set; }

		public static Delegates.glGetTextureSubImage glGetTextureSubImage { get; private set; }

		public static Delegates.glGetTransformFeedbacki_v glGetTransformFeedbacki_v { get; private set; }

		public static Delegates.glGetTransformFeedbacki64_v glGetTransformFeedbacki64_v { get; private set; }

		public static Delegates.glGetTransformFeedbackiv glGetTransformFeedbackiv { get; private set; }

		public static Delegates.glGetTransformFeedbackVarying glGetTransformFeedbackVarying { get; private set; }

		public static Delegates.glGetUniformBlockIndex glGetUniformBlockIndex { get; private set; }

		public static Delegates.glGetUniformdv glGetUniformdv { get; private set; }

		public static Delegates.glGetUniformfv glGetUniformfv { get; private set; }

		public static Delegates.glGetUniformIndices glGetUniformIndices { get; private set; }

		public static Delegates.glGetUniformiv glGetUniformiv { get; private set; }

		public static Delegates.glGetUniformLocation glGetUniformLocation { get; private set; }

		public static Delegates.glGetUniformSubroutineuiv glGetUniformSubroutineuiv { get; private set; }

		public static Delegates.glGetUniformuiv glGetUniformuiv { get; private set; }

		public static Delegates.glGetVertexArrayIndexed64iv glGetVertexArrayIndexed64iv { get; private set; }

		public static Delegates.glGetVertexArrayIndexediv glGetVertexArrayIndexediv { get; private set; }

		public static Delegates.glGetVertexArrayiv glGetVertexArrayiv { get; private set; }

		public static Delegates.glGetVertexAttribdv glGetVertexAttribdv { get; private set; }

		public static Delegates.glGetVertexAttribfv glGetVertexAttribfv { get; private set; }

		public static Delegates.glGetVertexAttribIiv glGetVertexAttribIiv { get; private set; }

		public static Delegates.glGetVertexAttribIuiv glGetVertexAttribIuiv { get; private set; }

		public static Delegates.glGetVertexAttribiv glGetVertexAttribiv { get; private set; }

		public static Delegates.glGetVertexAttribLdv glGetVertexAttribLdv { get; private set; }

		public static Delegates.glGetVertexAttribPointerv glGetVertexAttribPointerv { get; private set; }

		public static Delegates.glHint glHint { get; private set; }

		public static Delegates.glInvalidateBufferData glInvalidateBufferData { get; private set; }

		public static Delegates.glInvalidateBufferSubData glInvalidateBufferSubData { get; private set; }

		public static Delegates.glInvalidateFramebuffer glInvalidateFramebuffer { get; private set; }

		public static Delegates.glInvalidateNamedFramebufferData glInvalidateNamedFramebufferData { get; private set; }

		public static Delegates.glInvalidateNamedFramebufferSubData glInvalidateNamedFramebufferSubData { get; private set; }

		public static Delegates.glInvalidateSubFramebuffer glInvalidateSubFramebuffer { get; private set; }

		public static Delegates.glInvalidateTexImage glInvalidateTexImage { get; private set; }

		public static Delegates.glInvalidateTexSubImage glInvalidateTexSubImage { get; private set; }

		public static Delegates.glIsBuffer glIsBuffer { get; private set; }

		public static Delegates.glIsEnabled glIsEnabled { get; private set; }

		public static Delegates.glIsEnabledi glIsEnabledi { get; private set; }

		public static Delegates.glIsFramebuffer glIsFramebuffer { get; private set; }

		public static Delegates.glIsProgram glIsProgram { get; private set; }

		public static Delegates.glIsProgramPipeline glIsProgramPipeline { get; private set; }

		public static Delegates.glIsQuery glIsQuery { get; private set; }

		public static Delegates.glIsRenderbuffer glIsRenderbuffer { get; private set; }

		public static Delegates.glIsSampler glIsSampler { get; private set; }

		public static Delegates.glIsShader glIsShader { get; private set; }

		public static Delegates.glIsSync glIsSync { get; private set; }

		public static Delegates.glIsTexture glIsTexture { get; private set; }

		public static Delegates.glIsTransformFeedback glIsTransformFeedback { get; private set; }

		public static Delegates.glIsVertexArray glIsVertexArray { get; private set; }

		public static Delegates.glLineWidth glLineWidth { get; private set; }

		public static Delegates.glLinkProgram glLinkProgram { get; private set; }

		public static Delegates.glLogicOp glLogicOp { get; private set; }

		public static Delegates.glMapBuffer glMapBuffer { get; private set; }

		public static Delegates.glMapBufferRange glMapBufferRange { get; private set; }

		public static Delegates.glMapNamedBuffer glMapNamedBuffer { get; private set; }

		public static Delegates.glMapNamedBufferRange glMapNamedBufferRange { get; private set; }

		public static Delegates.glMemoryBarrier glMemoryBarrier { get; private set; }

		public static Delegates.glMemoryBarrierByRegion glMemoryBarrierByRegion { get; private set; }

		public static Delegates.glMinSampleShading glMinSampleShading { get; private set; }

		public static Delegates.glMultiDrawArrays glMultiDrawArrays { get; private set; }

		public static Delegates.glMultiDrawArraysIndirect glMultiDrawArraysIndirect { get; private set; }

		public static Delegates.glMultiDrawElements glMultiDrawElements { get; private set; }

		public static Delegates.glMultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex { get; private set; }

		public static Delegates.glMultiDrawElementsIndirect glMultiDrawElementsIndirect { get; private set; }

		public static Delegates.glNamedBufferData glNamedBufferData { get; private set; }

		public static Delegates.glNamedBufferStorage glNamedBufferStorage { get; private set; }

		public static Delegates.glNamedBufferSubData glNamedBufferSubData { get; private set; }

		public static Delegates.glNamedFramebufferDrawBuffer glNamedFramebufferDrawBuffer { get; private set; }

		public static Delegates.glNamedFramebufferDrawBuffers glNamedFramebufferDrawBuffers { get; private set; }

		public static Delegates.glNamedFramebufferParameteri glNamedFramebufferParameteri { get; private set; }

		public static Delegates.glNamedFramebufferReadBuffer glNamedFramebufferReadBuffer { get; private set; }

		public static Delegates.glNamedFramebufferRenderbuffer glNamedFramebufferRenderbuffer { get; private set; }

		public static Delegates.glNamedFramebufferTexture glNamedFramebufferTexture { get; private set; }

		public static Delegates.glNamedFramebufferTextureLayer glNamedFramebufferTextureLayer { get; private set; }

		public static Delegates.glNamedRenderbufferStorage glNamedRenderbufferStorage { get; private set; }

		public static Delegates.glNamedRenderbufferStorageMultisample glNamedRenderbufferStorageMultisample { get; private set; }

		public static Delegates.glObjectLabel glObjectLabel { get; private set; }

		public static Delegates.glObjectPtrLabel glObjectPtrLabel { get; private set; }

		public static Delegates.glPatchParameterfv glPatchParameterfv { get; private set; }

		public static Delegates.glPatchParameteri glPatchParameteri { get; private set; }

		public static Delegates.glPauseTransformFeedback glPauseTransformFeedback { get; private set; }

		public static Delegates.glPixelStoref glPixelStoref { get; private set; }

		public static Delegates.glPixelStorei glPixelStorei { get; private set; }

		public static Delegates.glPointParameterf glPointParameterf { get; private set; }

		public static Delegates.glPointParameterfv glPointParameterfv { get; private set; }

		public static Delegates.glPointParameteri glPointParameteri { get; private set; }

		public static Delegates.glPointParameteriv glPointParameteriv { get; private set; }

		public static Delegates.glPointSize glPointSize { get; private set; }

		public static Delegates.glPolygonMode glPolygonMode { get; private set; }

		public static Delegates.glPolygonOffset glPolygonOffset { get; private set; }

		public static Delegates.glPopDebugGroup glPopDebugGroup { get; private set; }

		public static Delegates.glPrimitiveRestartIndex glPrimitiveRestartIndex { get; private set; }

		public static Delegates.glProgramBinary glProgramBinary { get; private set; }

		public static Delegates.glProgramParameteri glProgramParameteri { get; private set; }

		public static Delegates.glProgramUniform1d glProgramUniform1d { get; private set; }

		public static Delegates.glProgramUniform1dv glProgramUniform1dv { get; private set; }

		public static Delegates.glProgramUniform1f glProgramUniform1f { get; private set; }

		public static Delegates.glProgramUniform1fv glProgramUniform1fv { get; private set; }

		public static Delegates.glProgramUniform1i glProgramUniform1i { get; private set; }

		public static Delegates.glProgramUniform1iv glProgramUniform1iv { get; private set; }

		public static Delegates.glProgramUniform1ui glProgramUniform1ui { get; private set; }

		public static Delegates.glProgramUniform1uiv glProgramUniform1uiv { get; private set; }

		public static Delegates.glProgramUniform2d glProgramUniform2d { get; private set; }

		public static Delegates.glProgramUniform2dv glProgramUniform2dv { get; private set; }

		public static Delegates.glProgramUniform2f glProgramUniform2f { get; private set; }

		public static Delegates.glProgramUniform2fv glProgramUniform2fv { get; private set; }

		public static Delegates.glProgramUniform2i glProgramUniform2i { get; private set; }

		public static Delegates.glProgramUniform2iv glProgramUniform2iv { get; private set; }

		public static Delegates.glProgramUniform2ui glProgramUniform2ui { get; private set; }

		public static Delegates.glProgramUniform2uiv glProgramUniform2uiv { get; private set; }

		public static Delegates.glProgramUniform3d glProgramUniform3d { get; private set; }

		public static Delegates.glProgramUniform3dv glProgramUniform3dv { get; private set; }

		public static Delegates.glProgramUniform3f glProgramUniform3f { get; private set; }

		public static Delegates.glProgramUniform3fv glProgramUniform3fv { get; private set; }

		public static Delegates.glProgramUniform3i glProgramUniform3i { get; private set; }

		public static Delegates.glProgramUniform3iv glProgramUniform3iv { get; private set; }

		public static Delegates.glProgramUniform3ui glProgramUniform3ui { get; private set; }

		public static Delegates.glProgramUniform3uiv glProgramUniform3uiv { get; private set; }

		public static Delegates.glProgramUniform4d glProgramUniform4d { get; private set; }

		public static Delegates.glProgramUniform4dv glProgramUniform4dv { get; private set; }

		public static Delegates.glProgramUniform4f glProgramUniform4f { get; private set; }

		public static Delegates.glProgramUniform4fv glProgramUniform4fv { get; private set; }

		public static Delegates.glProgramUniform4i glProgramUniform4i { get; private set; }

		public static Delegates.glProgramUniform4iv glProgramUniform4iv { get; private set; }

		public static Delegates.glProgramUniform4ui glProgramUniform4ui { get; private set; }

		public static Delegates.glProgramUniform4uiv glProgramUniform4uiv { get; private set; }

		public static Delegates.glProgramUniformMatrix2dv glProgramUniformMatrix2dv { get; private set; }

		public static Delegates.glProgramUniformMatrix2fv glProgramUniformMatrix2fv { get; private set; }

		public static Delegates.glProgramUniformMatrix2x3dv glProgramUniformMatrix2x3dv { get; private set; }

		public static Delegates.glProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv { get; private set; }

		public static Delegates.glProgramUniformMatrix2x4dv glProgramUniformMatrix2x4dv { get; private set; }

		public static Delegates.glProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv { get; private set; }

		public static Delegates.glProgramUniformMatrix3dv glProgramUniformMatrix3dv { get; private set; }

		public static Delegates.glProgramUniformMatrix3fv glProgramUniformMatrix3fv { get; private set; }

		public static Delegates.glProgramUniformMatrix3x2dv glProgramUniformMatrix3x2dv { get; private set; }

		public static Delegates.glProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv { get; private set; }

		public static Delegates.glProgramUniformMatrix3x4dv glProgramUniformMatrix3x4dv { get; private set; }

		public static Delegates.glProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv { get; private set; }

		public static Delegates.glProgramUniformMatrix4dv glProgramUniformMatrix4dv { get; private set; }

		public static Delegates.glProgramUniformMatrix4fv glProgramUniformMatrix4fv { get; private set; }

		public static Delegates.glProgramUniformMatrix4x2dv glProgramUniformMatrix4x2dv { get; private set; }

		public static Delegates.glProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv { get; private set; }

		public static Delegates.glProgramUniformMatrix4x3dv glProgramUniformMatrix4x3dv { get; private set; }

		public static Delegates.glProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv { get; private set; }

		public static Delegates.glProvokingVertex glProvokingVertex { get; private set; }

		public static Delegates.glPushDebugGroup glPushDebugGroup { get; private set; }

		public static Delegates.glQueryCounter glQueryCounter { get; private set; }

		public static Delegates.glReadBuffer glReadBuffer { get; private set; }

		public static Delegates.glReadnPixels glReadnPixels { get; private set; }

		public static Delegates.glReadPixels glReadPixels { get; private set; }

		public static Delegates.glReleaseShaderCompiler glReleaseShaderCompiler { get; private set; }

		public static Delegates.glRenderbufferStorage glRenderbufferStorage { get; private set; }

		public static Delegates.glRenderbufferStorageMultisample glRenderbufferStorageMultisample { get; private set; }

		public static Delegates.glResumeTransformFeedback glResumeTransformFeedback { get; private set; }

		public static Delegates.glSampleCoverage glSampleCoverage { get; private set; }

		public static Delegates.glSampleMaski glSampleMaski { get; private set; }

		public static Delegates.glSamplerParameterf glSamplerParameterf { get; private set; }

		public static Delegates.glSamplerParameterfv glSamplerParameterfv { get; private set; }

		public static Delegates.glSamplerParameteri glSamplerParameteri { get; private set; }

		public static Delegates.glSamplerParameterIiv glSamplerParameterIiv { get; private set; }

		public static Delegates.glSamplerParameterIuiv glSamplerParameterIuiv { get; private set; }

		public static Delegates.glSamplerParameteriv glSamplerParameteriv { get; private set; }

		public static Delegates.glScissor glScissor { get; private set; }

		public static Delegates.glScissorArrayv glScissorArrayv { get; private set; }

		public static Delegates.glScissorIndexed glScissorIndexed { get; private set; }

		public static Delegates.glScissorIndexedv glScissorIndexedv { get; private set; }

		public static Delegates.glShaderBinary glShaderBinary { get; private set; }

		public static Delegates.glShaderSource glShaderSource { get; private set; }

		public static Delegates.glShaderStorageBlockBinding glShaderStorageBlockBinding { get; private set; }

		public static Delegates.glStencilFunc glStencilFunc { get; private set; }

		public static Delegates.glStencilFuncSeparate glStencilFuncSeparate { get; private set; }

		public static Delegates.glStencilMask glStencilMask { get; private set; }

		public static Delegates.glStencilMaskSeparate glStencilMaskSeparate { get; private set; }

		public static Delegates.glStencilOp glStencilOp { get; private set; }

		public static Delegates.glStencilOpSeparate glStencilOpSeparate { get; private set; }

		public static Delegates.glTexBuffer glTexBuffer { get; private set; }

		public static Delegates.glTexBufferRange glTexBufferRange { get; private set; }

		public static Delegates.glTexImage1D glTexImage1D { get; private set; }

		public static Delegates.glTexImage2D glTexImage2D { get; private set; }

		public static Delegates.glTexImage2DMultisample glTexImage2DMultisample { get; private set; }

		public static Delegates.glTexImage3D glTexImage3D { get; private set; }

		public static Delegates.glTexImage3DMultisample glTexImage3DMultisample { get; private set; }

		public static Delegates.glTexParameterf glTexParameterf { get; private set; }

		public static Delegates.glTexParameterfv glTexParameterfv { get; private set; }

		public static Delegates.glTexParameteri glTexParameteri { get; private set; }

		public static Delegates.glTexParameterIiv glTexParameterIiv { get; private set; }

		public static Delegates.glTexParameterIuiv glTexParameterIuiv { get; private set; }

		public static Delegates.glTexParameteriv glTexParameteriv { get; private set; }

		public static Delegates.glTexStorage1D glTexStorage1D { get; private set; }

		public static Delegates.glTexStorage2D glTexStorage2D { get; private set; }

		public static Delegates.glTexStorage2DMultisample glTexStorage2DMultisample { get; private set; }

		public static Delegates.glTexStorage3D glTexStorage3D { get; private set; }

		public static Delegates.glTexStorage3DMultisample glTexStorage3DMultisample { get; private set; }

		public static Delegates.glTexSubImage1D glTexSubImage1D { get; private set; }

		public static Delegates.glTexSubImage2D glTexSubImage2D { get; private set; }

		public static Delegates.glTexSubImage3D glTexSubImage3D { get; private set; }

		public static Delegates.glTextureBarrier glTextureBarrier { get; private set; }

		public static Delegates.glTextureBuffer glTextureBuffer { get; private set; }

		public static Delegates.glTextureBufferRange glTextureBufferRange { get; private set; }

		public static Delegates.glTextureParameterf glTextureParameterf { get; private set; }

		public static Delegates.glTextureParameterfv glTextureParameterfv { get; private set; }

		public static Delegates.glTextureParameteri glTextureParameteri { get; private set; }

		public static Delegates.glTextureParameterIiv glTextureParameterIiv { get; private set; }

		public static Delegates.glTextureParameterIuiv glTextureParameterIuiv { get; private set; }

		public static Delegates.glTextureParameteriv glTextureParameteriv { get; private set; }

		public static Delegates.glTextureStorage1D glTextureStorage1D { get; private set; }

		public static Delegates.glTextureStorage2D glTextureStorage2D { get; private set; }

		public static Delegates.glTextureStorage2DMultisample glTextureStorage2DMultisample { get; private set; }

		public static Delegates.glTextureStorage3D glTextureStorage3D { get; private set; }

		public static Delegates.glTextureStorage3DMultisample glTextureStorage3DMultisample { get; private set; }

		public static Delegates.glTextureSubImage1D glTextureSubImage1D { get; private set; }

		public static Delegates.glTextureSubImage2D glTextureSubImage2D { get; private set; }

		public static Delegates.glTextureSubImage3D glTextureSubImage3D { get; private set; }

		public static Delegates.glTextureView glTextureView { get; private set; }

		public static Delegates.glTransformFeedbackBufferBase glTransformFeedbackBufferBase { get; private set; }

		public static Delegates.glTransformFeedbackBufferRange glTransformFeedbackBufferRange { get; private set; }

		public static Delegates.glTransformFeedbackVaryings glTransformFeedbackVaryings { get; private set; }

		public static Delegates.glUniform1d glUniform1d { get; private set; }

		public static Delegates.glUniform1dv glUniform1dv { get; private set; }

		public static Delegates.glUniform1f glUniform1f { get; private set; }

		public static Delegates.glUniform1fv glUniform1fv { get; private set; }

		public static Delegates.glUniform1i glUniform1i { get; private set; }

		public static Delegates.glUniform1iv glUniform1iv { get; private set; }

		public static Delegates.glUniform1ui glUniform1ui { get; private set; }

		public static Delegates.glUniform1uiv glUniform1uiv { get; private set; }

		public static Delegates.glUniform2d glUniform2d { get; private set; }

		public static Delegates.glUniform2dv glUniform2dv { get; private set; }

		public static Delegates.glUniform2f glUniform2f { get; private set; }

		public static Delegates.glUniform2fv glUniform2fv { get; private set; }

		public static Delegates.glUniform2i glUniform2i { get; private set; }

		public static Delegates.glUniform2iv glUniform2iv { get; private set; }

		public static Delegates.glUniform2ui glUniform2ui { get; private set; }

		public static Delegates.glUniform2uiv glUniform2uiv { get; private set; }

		public static Delegates.glUniform3d glUniform3d { get; private set; }

		public static Delegates.glUniform3dv glUniform3dv { get; private set; }

		public static Delegates.glUniform3f glUniform3f { get; private set; }

		public static Delegates.glUniform3fv glUniform3fv { get; private set; }

		public static Delegates.glUniform3i glUniform3i { get; private set; }

		public static Delegates.glUniform3iv glUniform3iv { get; private set; }

		public static Delegates.glUniform3ui glUniform3ui { get; private set; }

		public static Delegates.glUniform3uiv glUniform3uiv { get; private set; }

		public static Delegates.glUniform4d glUniform4d { get; private set; }

		public static Delegates.glUniform4dv glUniform4dv { get; private set; }

		public static Delegates.glUniform4f glUniform4f { get; private set; }

		public static Delegates.glUniform4fv glUniform4fv { get; private set; }

		public static Delegates.glUniform4i glUniform4i { get; private set; }

		public static Delegates.glUniform4iv glUniform4iv { get; private set; }

		public static Delegates.glUniform4ui glUniform4ui { get; private set; }

		public static Delegates.glUniform4uiv glUniform4uiv { get; private set; }

		public static Delegates.glUniformBlockBinding glUniformBlockBinding { get; private set; }

		public static Delegates.glUniformMatrix2dv glUniformMatrix2dv { get; private set; }

		public static Delegates.glUniformMatrix2fv glUniformMatrix2fv { get; private set; }

		public static Delegates.glUniformMatrix2x3dv glUniformMatrix2x3dv { get; private set; }

		public static Delegates.glUniformMatrix2x3fv glUniformMatrix2x3fv { get; private set; }

		public static Delegates.glUniformMatrix2x4dv glUniformMatrix2x4dv { get; private set; }

		public static Delegates.glUniformMatrix2x4fv glUniformMatrix2x4fv { get; private set; }

		public static Delegates.glUniformMatrix3dv glUniformMatrix3dv { get; private set; }

		public static Delegates.glUniformMatrix3fv glUniformMatrix3fv { get; private set; }

		public static Delegates.glUniformMatrix3x2dv glUniformMatrix3x2dv { get; private set; }

		public static Delegates.glUniformMatrix3x2fv glUniformMatrix3x2fv { get; private set; }

		public static Delegates.glUniformMatrix3x4dv glUniformMatrix3x4dv { get; private set; }

		public static Delegates.glUniformMatrix3x4fv glUniformMatrix3x4fv { get; private set; }

		public static Delegates.glUniformMatrix4dv glUniformMatrix4dv { get; private set; }

		public static Delegates.glUniformMatrix4fv glUniformMatrix4fv { get; private set; }

		public static Delegates.glUniformMatrix4fvByRef glUniformMatrix4fvByRef { get; private set; }

		public static Delegates.glUniformMatrix4x2dv glUniformMatrix4x2dv { get; private set; }

		public static Delegates.glUniformMatrix4x2fv glUniformMatrix4x2fv { get; private set; }

		public static Delegates.glUniformMatrix4x3dv glUniformMatrix4x3dv { get; private set; }

		public static Delegates.glUniformMatrix4x3fv glUniformMatrix4x3fv { get; private set; }

		public static Delegates.glUniformSubroutinesuiv glUniformSubroutinesuiv { get; private set; }

		public static Delegates.glUnmapBuffer glUnmapBuffer { get; private set; }

		public static Delegates.glUnmapNamedBuffer glUnmapNamedBuffer { get; private set; }

		public static Delegates.glUseProgram glUseProgram { get; private set; }

		public static Delegates.glUseProgramStages glUseProgramStages { get; private set; }

		public static Delegates.glValidateProgram glValidateProgram { get; private set; }

		public static Delegates.glValidateProgramPipeline glValidateProgramPipeline { get; private set; }

		public static Delegates.glVertexArrayAttribBinding glVertexArrayAttribBinding { get; private set; }

		public static Delegates.glVertexArrayAttribFormat glVertexArrayAttribFormat { get; private set; }

		public static Delegates.glVertexArrayAttribIFormat glVertexArrayAttribIFormat { get; private set; }

		public static Delegates.glVertexArrayAttribLFormat glVertexArrayAttribLFormat { get; private set; }

		public static Delegates.glVertexArrayBindingDivisor glVertexArrayBindingDivisor { get; private set; }

		public static Delegates.glVertexArrayElementBuffer glVertexArrayElementBuffer { get; private set; }

		public static Delegates.glVertexArrayVertexBuffer glVertexArrayVertexBuffer { get; private set; }

		public static Delegates.glVertexArrayVertexBuffers glVertexArrayVertexBuffers { get; private set; }

		public static Delegates.glVertexAttrib1d glVertexAttrib1d { get; private set; }

		public static Delegates.glVertexAttrib1dv glVertexAttrib1dv { get; private set; }

		public static Delegates.glVertexAttrib1f glVertexAttrib1f { get; private set; }

		public static Delegates.glVertexAttrib1fv glVertexAttrib1fv { get; private set; }

		public static Delegates.glVertexAttrib1s glVertexAttrib1s { get; private set; }

		public static Delegates.glVertexAttrib1sv glVertexAttrib1sv { get; private set; }

		public static Delegates.glVertexAttrib2d glVertexAttrib2d { get; private set; }

		public static Delegates.glVertexAttrib2dv glVertexAttrib2dv { get; private set; }

		public static Delegates.glVertexAttrib2f glVertexAttrib2f { get; private set; }

		public static Delegates.glVertexAttrib2fv glVertexAttrib2fv { get; private set; }

		public static Delegates.glVertexAttrib2s glVertexAttrib2s { get; private set; }

		public static Delegates.glVertexAttrib2sv glVertexAttrib2sv { get; private set; }

		public static Delegates.glVertexAttrib3d glVertexAttrib3d { get; private set; }

		public static Delegates.glVertexAttrib3dv glVertexAttrib3dv { get; private set; }

		public static Delegates.glVertexAttrib3f glVertexAttrib3f { get; private set; }

		public static Delegates.glVertexAttrib3fv glVertexAttrib3fv { get; private set; }

		public static Delegates.glVertexAttrib3s glVertexAttrib3s { get; private set; }

		public static Delegates.glVertexAttrib3sv glVertexAttrib3sv { get; private set; }

		public static Delegates.glVertexAttrib4bv glVertexAttrib4bv { get; private set; }

		public static Delegates.glVertexAttrib4d glVertexAttrib4d { get; private set; }

		public static Delegates.glVertexAttrib4dv glVertexAttrib4dv { get; private set; }

		public static Delegates.glVertexAttrib4f glVertexAttrib4f { get; private set; }

		public static Delegates.glVertexAttrib4fv glVertexAttrib4fv { get; private set; }

		public static Delegates.glVertexAttrib4iv glVertexAttrib4iv { get; private set; }

		public static Delegates.glVertexAttrib4Nbv glVertexAttrib4Nbv { get; private set; }

		public static Delegates.glVertexAttrib4Niv glVertexAttrib4Niv { get; private set; }

		public static Delegates.glVertexAttrib4Nsv glVertexAttrib4Nsv { get; private set; }

		public static Delegates.glVertexAttrib4Nub glVertexAttrib4Nub { get; private set; }

		public static Delegates.glVertexAttrib4Nubv glVertexAttrib4Nubv { get; private set; }

		public static Delegates.glVertexAttrib4Nuiv glVertexAttrib4Nuiv { get; private set; }

		public static Delegates.glVertexAttrib4Nusv glVertexAttrib4Nusv { get; private set; }

		public static Delegates.glVertexAttrib4s glVertexAttrib4s { get; private set; }

		public static Delegates.glVertexAttrib4sv glVertexAttrib4sv { get; private set; }

		public static Delegates.glVertexAttrib4ubv glVertexAttrib4ubv { get; private set; }

		public static Delegates.glVertexAttrib4uiv glVertexAttrib4uiv { get; private set; }

		public static Delegates.glVertexAttrib4usv glVertexAttrib4usv { get; private set; }

		public static Delegates.glVertexAttribBinding glVertexAttribBinding { get; private set; }

		public static Delegates.glVertexAttribDivisor glVertexAttribDivisor { get; private set; }

		public static Delegates.glVertexAttribFormat glVertexAttribFormat { get; private set; }

		public static Delegates.glVertexAttribI1i glVertexAttribI1i { get; private set; }

		public static Delegates.glVertexAttribI1iv glVertexAttribI1iv { get; private set; }

		public static Delegates.glVertexAttribI1ui glVertexAttribI1ui { get; private set; }

		public static Delegates.glVertexAttribI1uiv glVertexAttribI1uiv { get; private set; }

		public static Delegates.glVertexAttribI2i glVertexAttribI2i { get; private set; }

		public static Delegates.glVertexAttribI2iv glVertexAttribI2iv { get; private set; }

		public static Delegates.glVertexAttribI2ui glVertexAttribI2ui { get; private set; }

		public static Delegates.glVertexAttribI2uiv glVertexAttribI2uiv { get; private set; }

		public static Delegates.glVertexAttribI3i glVertexAttribI3i { get; private set; }

		public static Delegates.glVertexAttribI3iv glVertexAttribI3iv { get; private set; }

		public static Delegates.glVertexAttribI3ui glVertexAttribI3ui { get; private set; }

		public static Delegates.glVertexAttribI3uiv glVertexAttribI3uiv { get; private set; }

		public static Delegates.glVertexAttribI4bv glVertexAttribI4bv { get; private set; }

		public static Delegates.glVertexAttribI4i glVertexAttribI4i { get; private set; }

		public static Delegates.glVertexAttribI4iv glVertexAttribI4iv { get; private set; }

		public static Delegates.glVertexAttribI4sv glVertexAttribI4sv { get; private set; }

		public static Delegates.glVertexAttribI4ubv glVertexAttribI4ubv { get; private set; }

		public static Delegates.glVertexAttribI4ui glVertexAttribI4ui { get; private set; }

		public static Delegates.glVertexAttribI4uiv glVertexAttribI4uiv { get; private set; }

		public static Delegates.glVertexAttribI4usv glVertexAttribI4usv { get; private set; }

		public static Delegates.glVertexAttribIFormat glVertexAttribIFormat { get; private set; }

		public static Delegates.glVertexAttribIPointer glVertexAttribIPointer { get; private set; }

		public static Delegates.glVertexAttribL1d glVertexAttribL1d { get; private set; }

		public static Delegates.glVertexAttribL1dv glVertexAttribL1dv { get; private set; }

		public static Delegates.glVertexAttribL2d glVertexAttribL2d { get; private set; }

		public static Delegates.glVertexAttribL2dv glVertexAttribL2dv { get; private set; }

		public static Delegates.glVertexAttribL3d glVertexAttribL3d { get; private set; }

		public static Delegates.glVertexAttribL3dv glVertexAttribL3dv { get; private set; }

		public static Delegates.glVertexAttribL4d glVertexAttribL4d { get; private set; }

		public static Delegates.glVertexAttribL4dv glVertexAttribL4dv { get; private set; }

		public static Delegates.glVertexAttribLFormat glVertexAttribLFormat { get; private set; }

		public static Delegates.glVertexAttribLPointer glVertexAttribLPointer { get; private set; }

		public static Delegates.glVertexAttribP1ui glVertexAttribP1ui { get; private set; }

		public static Delegates.glVertexAttribP1uiv glVertexAttribP1uiv { get; private set; }

		public static Delegates.glVertexAttribP2ui glVertexAttribP2ui { get; private set; }

		public static Delegates.glVertexAttribP2uiv glVertexAttribP2uiv { get; private set; }

		public static Delegates.glVertexAttribP3ui glVertexAttribP3ui { get; private set; }

		public static Delegates.glVertexAttribP3uiv glVertexAttribP3uiv { get; private set; }

		public static Delegates.glVertexAttribP4ui glVertexAttribP4ui { get; private set; }

		public static Delegates.glVertexAttribP4uiv glVertexAttribP4uiv { get; private set; }

		public static Delegates.glVertexAttribPointer glVertexAttribPointer { get; private set; }

		public static Delegates.glVertexBindingDivisor glVertexBindingDivisor { get; private set; }

		public static Delegates.glViewport glViewport { get; private set; }

		public static Delegates.glViewportArrayv glViewportArrayv { get; private set; }

		public static Delegates.glViewportIndexedf glViewportIndexedf { get; private set; }

		public static Delegates.glViewportIndexedfv glViewportIndexedfv { get; private set; }

		public static Delegates.glWaitSync glWaitSync { get; private set; }

		public static void glInit(Func<string, IntPtr> getProcAddress, int versionMajor, int versionMinor)
		{
			if (getProcAddress == null) throw new ArgumentNullException(nameof(getProcAddress));

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 0))
			{
				glCullFace = (Delegates.glCullFace)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCullFace"), typeof(Delegates.glCullFace));
				glFrontFace = (Delegates.glFrontFace)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFrontFace"), typeof(Delegates.glFrontFace));
				glHint = (Delegates.glHint)Marshal.GetDelegateForFunctionPointer(getProcAddress("glHint"), typeof(Delegates.glHint));
				glLineWidth = (Delegates.glLineWidth)Marshal.GetDelegateForFunctionPointer(getProcAddress("glLineWidth"), typeof(Delegates.glLineWidth));
				glPointSize = (Delegates.glPointSize)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointSize"), typeof(Delegates.glPointSize));
				glPolygonMode = (Delegates.glPolygonMode)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPolygonMode"), typeof(Delegates.glPolygonMode));
				glScissor = (Delegates.glScissor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissor"), typeof(Delegates.glScissor));
				glTexParameterf = (Delegates.glTexParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterf"), typeof(Delegates.glTexParameterf));
				glTexParameterfv = (Delegates.glTexParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterfv"), typeof(Delegates.glTexParameterfv));
				glTexParameteri = (Delegates.glTexParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameteri"), typeof(Delegates.glTexParameteri));
				glTexParameteriv = (Delegates.glTexParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameteriv"), typeof(Delegates.glTexParameteriv));
				glTexImage1D = (Delegates.glTexImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage1D"), typeof(Delegates.glTexImage1D));
				glTexImage2D = (Delegates.glTexImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage2D"), typeof(Delegates.glTexImage2D));
				glDrawBuffer = (Delegates.glDrawBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawBuffer"), typeof(Delegates.glDrawBuffer));
				glClear = (Delegates.glClear)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClear"), typeof(Delegates.glClear));
				glClearColor = (Delegates.glClearColor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearColor"), typeof(Delegates.glClearColor));
				glClearStencil = (Delegates.glClearStencil)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearStencil"), typeof(Delegates.glClearStencil));
				glClearDepth = (Delegates.glClearDepth)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearDepth"), typeof(Delegates.glClearDepth));
				glStencilMask = (Delegates.glStencilMask)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilMask"), typeof(Delegates.glStencilMask));
				glColorMask = (Delegates.glColorMask)Marshal.GetDelegateForFunctionPointer(getProcAddress("glColorMask"), typeof(Delegates.glColorMask));
				glDepthMask = (Delegates.glDepthMask)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthMask"), typeof(Delegates.glDepthMask));
				glDisable = (Delegates.glDisable)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisable"), typeof(Delegates.glDisable));
				glEnable = (Delegates.glEnable)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnable"), typeof(Delegates.glEnable));
				glFinish = (Delegates.glFinish)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFinish"), typeof(Delegates.glFinish));
				glFlush = (Delegates.glFlush)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFlush"), typeof(Delegates.glFlush));
				glBlendFunc = (Delegates.glBlendFunc)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFunc"), typeof(Delegates.glBlendFunc));
				glLogicOp = (Delegates.glLogicOp)Marshal.GetDelegateForFunctionPointer(getProcAddress("glLogicOp"), typeof(Delegates.glLogicOp));
				glStencilFunc = (Delegates.glStencilFunc)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilFunc"), typeof(Delegates.glStencilFunc));
				glStencilOp = (Delegates.glStencilOp)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilOp"), typeof(Delegates.glStencilOp));
				glDepthFunc = (Delegates.glDepthFunc)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthFunc"), typeof(Delegates.glDepthFunc));
				glPixelStoref = (Delegates.glPixelStoref)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPixelStoref"), typeof(Delegates.glPixelStoref));
				glPixelStorei = (Delegates.glPixelStorei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPixelStorei"), typeof(Delegates.glPixelStorei));
				glReadBuffer = (Delegates.glReadBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReadBuffer"), typeof(Delegates.glReadBuffer));
				glReadPixels = (Delegates.glReadPixels)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReadPixels"), typeof(Delegates.glReadPixels));
				glGetBooleanv = (Delegates.glGetBooleanv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBooleanv"), typeof(Delegates.glGetBooleanv));
				glGetDoublev = (Delegates.glGetDoublev)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetDoublev"), typeof(Delegates.glGetDoublev));
				glGetError = (Delegates.glGetError)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetError"), typeof(Delegates.glGetError));
				glGetFloatv = (Delegates.glGetFloatv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFloatv"), typeof(Delegates.glGetFloatv));
				glGetIntegerv = (Delegates.glGetIntegerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetIntegerv"), typeof(Delegates.glGetIntegerv));
				glGetString = (Delegates.glGetString)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetString"), typeof(Delegates.glGetString));
				glGetTexImage = (Delegates.glGetTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexImage"), typeof(Delegates.glGetTexImage));
				glGetTexParameterfv = (Delegates.glGetTexParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameterfv"), typeof(Delegates.glGetTexParameterfv));
				glGetTexParameteriv = (Delegates.glGetTexParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameteriv"), typeof(Delegates.glGetTexParameteriv));
				glGetTexLevelParameterfv = (Delegates.glGetTexLevelParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexLevelParameterfv"), typeof(Delegates.glGetTexLevelParameterfv));
				glGetTexLevelParameteriv = (Delegates.glGetTexLevelParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexLevelParameteriv"), typeof(Delegates.glGetTexLevelParameteriv));
				glIsEnabled = (Delegates.glIsEnabled)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsEnabled"), typeof(Delegates.glIsEnabled));
				glDepthRange = (Delegates.glDepthRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRange"), typeof(Delegates.glDepthRange));
				glViewport = (Delegates.glViewport)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewport"), typeof(Delegates.glViewport));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 1))
			{
				glDrawArrays = (Delegates.glDrawArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArrays"), typeof(Delegates.glDrawArrays));
				glDrawElements = (Delegates.glDrawElements)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElements"), typeof(Delegates.glDrawElements));
				glGetPointerv = (Delegates.glGetPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetPointerv"), typeof(Delegates.glGetPointerv));
				glPolygonOffset = (Delegates.glPolygonOffset)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPolygonOffset"), typeof(Delegates.glPolygonOffset));
				glCopyTexImage1D = (Delegates.glCopyTexImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexImage1D"), typeof(Delegates.glCopyTexImage1D));
				glCopyTexImage2D = (Delegates.glCopyTexImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexImage2D"), typeof(Delegates.glCopyTexImage2D));
				glCopyTexSubImage1D = (Delegates.glCopyTexSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexSubImage1D"), typeof(Delegates.glCopyTexSubImage1D));
				glCopyTexSubImage2D = (Delegates.glCopyTexSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexSubImage2D"), typeof(Delegates.glCopyTexSubImage2D));
				glTexSubImage1D = (Delegates.glTexSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexSubImage1D"), typeof(Delegates.glTexSubImage1D));
				glTexSubImage2D = (Delegates.glTexSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexSubImage2D"), typeof(Delegates.glTexSubImage2D));
				glBindTexture = (Delegates.glBindTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTexture"), typeof(Delegates.glBindTexture));
				glDeleteTextures = (Delegates.glDeleteTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteTextures"), typeof(Delegates.glDeleteTextures));
				glGenTextures = (Delegates.glGenTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenTextures"), typeof(Delegates.glGenTextures));
				glIsTexture = (Delegates.glIsTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsTexture"), typeof(Delegates.glIsTexture));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 2))
			{
				glDrawRangeElements = (Delegates.glDrawRangeElements)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawRangeElements"), typeof(Delegates.glDrawRangeElements));
				glTexImage3D = (Delegates.glTexImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage3D"), typeof(Delegates.glTexImage3D));
				glTexSubImage3D = (Delegates.glTexSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexSubImage3D"), typeof(Delegates.glTexSubImage3D));
				glCopyTexSubImage3D = (Delegates.glCopyTexSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexSubImage3D"), typeof(Delegates.glCopyTexSubImage3D));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 3))
			{
				glActiveTexture = (Delegates.glActiveTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glActiveTexture"), typeof(Delegates.glActiveTexture));
				glSampleCoverage = (Delegates.glSampleCoverage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSampleCoverage"), typeof(Delegates.glSampleCoverage));
				glCompressedTexImage3D = (Delegates.glCompressedTexImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexImage3D"), typeof(Delegates.glCompressedTexImage3D));
				glCompressedTexImage2D = (Delegates.glCompressedTexImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexImage2D"), typeof(Delegates.glCompressedTexImage2D));
				glCompressedTexImage1D = (Delegates.glCompressedTexImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexImage1D"), typeof(Delegates.glCompressedTexImage1D));
				glCompressedTexSubImage3D = (Delegates.glCompressedTexSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexSubImage3D"), typeof(Delegates.glCompressedTexSubImage3D));
				glCompressedTexSubImage2D = (Delegates.glCompressedTexSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexSubImage2D"), typeof(Delegates.glCompressedTexSubImage2D));
				glCompressedTexSubImage1D = (Delegates.glCompressedTexSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexSubImage1D"), typeof(Delegates.glCompressedTexSubImage1D));
				glGetCompressedTexImage = (Delegates.glGetCompressedTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetCompressedTexImage"), typeof(Delegates.glGetCompressedTexImage));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 4))
			{
				glBlendFuncSeparate = (Delegates.glBlendFuncSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFuncSeparate"), typeof(Delegates.glBlendFuncSeparate));
				glMultiDrawArrays = (Delegates.glMultiDrawArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawArrays"), typeof(Delegates.glMultiDrawArrays));
				glMultiDrawElements = (Delegates.glMultiDrawElements)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawElements"), typeof(Delegates.glMultiDrawElements));
				glPointParameterf = (Delegates.glPointParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameterf"), typeof(Delegates.glPointParameterf));
				glPointParameterfv = (Delegates.glPointParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameterfv"), typeof(Delegates.glPointParameterfv));
				glPointParameteri = (Delegates.glPointParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameteri"), typeof(Delegates.glPointParameteri));
				glPointParameteriv = (Delegates.glPointParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameteriv"), typeof(Delegates.glPointParameteriv));
				glBlendColor = (Delegates.glBlendColor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendColor"), typeof(Delegates.glBlendColor));
				glBlendEquation = (Delegates.glBlendEquation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquation"), typeof(Delegates.glBlendEquation));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 5))
			{
				glGenQueries = (Delegates.glGenQueries)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenQueries"), typeof(Delegates.glGenQueries));
				glDeleteQueries = (Delegates.glDeleteQueries)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteQueries"), typeof(Delegates.glDeleteQueries));
				glIsQuery = (Delegates.glIsQuery)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsQuery"), typeof(Delegates.glIsQuery));
				glBeginQuery = (Delegates.glBeginQuery)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginQuery"), typeof(Delegates.glBeginQuery));
				glEndQuery = (Delegates.glEndQuery)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndQuery"), typeof(Delegates.glEndQuery));
				glGetQueryiv = (Delegates.glGetQueryiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryiv"), typeof(Delegates.glGetQueryiv));
				glGetQueryObjectiv = (Delegates.glGetQueryObjectiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjectiv"), typeof(Delegates.glGetQueryObjectiv));
				glGetQueryObjectuiv = (Delegates.glGetQueryObjectuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjectuiv"), typeof(Delegates.glGetQueryObjectuiv));
				glBindBuffer = (Delegates.glBindBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBuffer"), typeof(Delegates.glBindBuffer));
				glDeleteBuffers = (Delegates.glDeleteBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteBuffers"), typeof(Delegates.glDeleteBuffers));
				glGenBuffers = (Delegates.glGenBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenBuffers"), typeof(Delegates.glGenBuffers));
				glIsBuffer = (Delegates.glIsBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsBuffer"), typeof(Delegates.glIsBuffer));
				glBufferData = (Delegates.glBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBufferData"), typeof(Delegates.glBufferData));
				glBufferSubData = (Delegates.glBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBufferSubData"), typeof(Delegates.glBufferSubData));
				glGetBufferSubData = (Delegates.glGetBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferSubData"), typeof(Delegates.glGetBufferSubData));
				glMapBuffer = (Delegates.glMapBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapBuffer"), typeof(Delegates.glMapBuffer));
				glUnmapBuffer = (Delegates.glUnmapBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUnmapBuffer"), typeof(Delegates.glUnmapBuffer));
				glGetBufferParameteriv = (Delegates.glGetBufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferParameteriv"), typeof(Delegates.glGetBufferParameteriv));
				glGetBufferPointerv = (Delegates.glGetBufferPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferPointerv"), typeof(Delegates.glGetBufferPointerv));
			}

			if (versionMajor > 2 || (versionMajor == 2 && versionMinor >= 0))
			{
				glBlendEquationSeparate = (Delegates.glBlendEquationSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquationSeparate"), typeof(Delegates.glBlendEquationSeparate));
				glDrawBuffers = (Delegates.glDrawBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawBuffers"), typeof(Delegates.glDrawBuffers));
				glStencilOpSeparate = (Delegates.glStencilOpSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilOpSeparate"), typeof(Delegates.glStencilOpSeparate));
				glStencilFuncSeparate = (Delegates.glStencilFuncSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilFuncSeparate"), typeof(Delegates.glStencilFuncSeparate));
				glStencilMaskSeparate = (Delegates.glStencilMaskSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilMaskSeparate"), typeof(Delegates.glStencilMaskSeparate));
				glAttachShader = (Delegates.glAttachShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glAttachShader"), typeof(Delegates.glAttachShader));
				glBindAttribLocation = (Delegates.glBindAttribLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindAttribLocation"), typeof(Delegates.glBindAttribLocation));
				glCompileShader = (Delegates.glCompileShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompileShader"), typeof(Delegates.glCompileShader));
				glCreateProgram = (Delegates.glCreateProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateProgram"), typeof(Delegates.glCreateProgram));
				glCreateShader = (Delegates.glCreateShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateShader"), typeof(Delegates.glCreateShader));
				glDeleteProgram = (Delegates.glDeleteProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteProgram"), typeof(Delegates.glDeleteProgram));
				glDeleteShader = (Delegates.glDeleteShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteShader"), typeof(Delegates.glDeleteShader));
				glDetachShader = (Delegates.glDetachShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDetachShader"), typeof(Delegates.glDetachShader));
				glDisableVertexAttribArray = (Delegates.glDisableVertexAttribArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisableVertexAttribArray"), typeof(Delegates.glDisableVertexAttribArray));
				glEnableVertexAttribArray = (Delegates.glEnableVertexAttribArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnableVertexAttribArray"), typeof(Delegates.glEnableVertexAttribArray));
				glGetActiveAttrib = (Delegates.glGetActiveAttrib)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveAttrib"), typeof(Delegates.glGetActiveAttrib));
				glGetActiveUniform = (Delegates.glGetActiveUniform)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniform"), typeof(Delegates.glGetActiveUniform));
				glGetAttachedShaders = (Delegates.glGetAttachedShaders)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetAttachedShaders"), typeof(Delegates.glGetAttachedShaders));
				glGetAttribLocation = (Delegates.glGetAttribLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetAttribLocation"), typeof(Delegates.glGetAttribLocation));
				glGetProgramiv = (Delegates.glGetProgramiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramiv"), typeof(Delegates.glGetProgramiv));
				glGetProgramInfoLog = (Delegates.glGetProgramInfoLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramInfoLog"), typeof(Delegates.glGetProgramInfoLog));
				glGetShaderiv = (Delegates.glGetShaderiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderiv"), typeof(Delegates.glGetShaderiv));
				glGetShaderInfoLog = (Delegates.glGetShaderInfoLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderInfoLog"), typeof(Delegates.glGetShaderInfoLog));
				glGetShaderSource = (Delegates.glGetShaderSource)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderSource"), typeof(Delegates.glGetShaderSource));
				glGetUniformLocation = (Delegates.glGetUniformLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformLocation"), typeof(Delegates.glGetUniformLocation));
				glGetUniformfv = (Delegates.glGetUniformfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformfv"), typeof(Delegates.glGetUniformfv));
				glGetUniformiv = (Delegates.glGetUniformiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformiv"), typeof(Delegates.glGetUniformiv));
				glGetVertexAttribdv = (Delegates.glGetVertexAttribdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribdv"), typeof(Delegates.glGetVertexAttribdv));
				glGetVertexAttribfv = (Delegates.glGetVertexAttribfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribfv"), typeof(Delegates.glGetVertexAttribfv));
				glGetVertexAttribiv = (Delegates.glGetVertexAttribiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribiv"), typeof(Delegates.glGetVertexAttribiv));
				glGetVertexAttribPointerv = (Delegates.glGetVertexAttribPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribPointerv"), typeof(Delegates.glGetVertexAttribPointerv));
				glIsProgram = (Delegates.glIsProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsProgram"), typeof(Delegates.glIsProgram));
				glIsShader = (Delegates.glIsShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsShader"), typeof(Delegates.glIsShader));
				glLinkProgram = (Delegates.glLinkProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glLinkProgram"), typeof(Delegates.glLinkProgram));
				glShaderSource = (Delegates.glShaderSource)Marshal.GetDelegateForFunctionPointer(getProcAddress("glShaderSource"), typeof(Delegates.glShaderSource));
				glUseProgram = (Delegates.glUseProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUseProgram"), typeof(Delegates.glUseProgram));
				glUniform1f = (Delegates.glUniform1f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1f"), typeof(Delegates.glUniform1f));
				glUniform2f = (Delegates.glUniform2f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2f"), typeof(Delegates.glUniform2f));
				glUniform3f = (Delegates.glUniform3f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3f"), typeof(Delegates.glUniform3f));
				glUniform4f = (Delegates.glUniform4f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4f"), typeof(Delegates.glUniform4f));
				glUniform1i = (Delegates.glUniform1i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1i"), typeof(Delegates.glUniform1i));
				glUniform2i = (Delegates.glUniform2i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2i"), typeof(Delegates.glUniform2i));
				glUniform3i = (Delegates.glUniform3i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3i"), typeof(Delegates.glUniform3i));
				glUniform4i = (Delegates.glUniform4i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4i"), typeof(Delegates.glUniform4i));
				glUniform1fv = (Delegates.glUniform1fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1fv"), typeof(Delegates.glUniform1fv));
				glUniform2fv = (Delegates.glUniform2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2fv"), typeof(Delegates.glUniform2fv));
				glUniform3fv = (Delegates.glUniform3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3fv"), typeof(Delegates.glUniform3fv));
				glUniform4fv = (Delegates.glUniform4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4fv"), typeof(Delegates.glUniform4fv));
				glUniform1iv = (Delegates.glUniform1iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1iv"), typeof(Delegates.glUniform1iv));
				glUniform2iv = (Delegates.glUniform2iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2iv"), typeof(Delegates.glUniform2iv));
				glUniform3iv = (Delegates.glUniform3iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3iv"), typeof(Delegates.glUniform3iv));
				glUniform4iv = (Delegates.glUniform4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4iv"), typeof(Delegates.glUniform4iv));
				glUniformMatrix2fv = (Delegates.glUniformMatrix2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2fv"), typeof(Delegates.glUniformMatrix2fv));
				glUniformMatrix3fv = (Delegates.glUniformMatrix3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3fv"), typeof(Delegates.glUniformMatrix3fv));
				glUniformMatrix4fv = (Delegates.glUniformMatrix4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4fv"), typeof(Delegates.glUniformMatrix4fv));
				glValidateProgram = (Delegates.glValidateProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glValidateProgram"), typeof(Delegates.glValidateProgram));
				glVertexAttrib1d = (Delegates.glVertexAttrib1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1d"), typeof(Delegates.glVertexAttrib1d));
				glVertexAttrib1dv = (Delegates.glVertexAttrib1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1dv"), typeof(Delegates.glVertexAttrib1dv));
				glVertexAttrib1f = (Delegates.glVertexAttrib1f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1f"), typeof(Delegates.glVertexAttrib1f));
				glVertexAttrib1fv = (Delegates.glVertexAttrib1fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1fv"), typeof(Delegates.glVertexAttrib1fv));
				glVertexAttrib1s = (Delegates.glVertexAttrib1s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1s"), typeof(Delegates.glVertexAttrib1s));
				glVertexAttrib1sv = (Delegates.glVertexAttrib1sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1sv"), typeof(Delegates.glVertexAttrib1sv));
				glVertexAttrib2d = (Delegates.glVertexAttrib2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2d"), typeof(Delegates.glVertexAttrib2d));
				glVertexAttrib2dv = (Delegates.glVertexAttrib2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2dv"), typeof(Delegates.glVertexAttrib2dv));
				glVertexAttrib2f = (Delegates.glVertexAttrib2f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2f"), typeof(Delegates.glVertexAttrib2f));
				glVertexAttrib2fv = (Delegates.glVertexAttrib2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2fv"), typeof(Delegates.glVertexAttrib2fv));
				glVertexAttrib2s = (Delegates.glVertexAttrib2s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2s"), typeof(Delegates.glVertexAttrib2s));
				glVertexAttrib2sv = (Delegates.glVertexAttrib2sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2sv"), typeof(Delegates.glVertexAttrib2sv));
				glVertexAttrib3d = (Delegates.glVertexAttrib3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3d"), typeof(Delegates.glVertexAttrib3d));
				glVertexAttrib3dv = (Delegates.glVertexAttrib3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3dv"), typeof(Delegates.glVertexAttrib3dv));
				glVertexAttrib3f = (Delegates.glVertexAttrib3f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3f"), typeof(Delegates.glVertexAttrib3f));
				glVertexAttrib3fv = (Delegates.glVertexAttrib3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3fv"), typeof(Delegates.glVertexAttrib3fv));
				glVertexAttrib3s = (Delegates.glVertexAttrib3s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3s"), typeof(Delegates.glVertexAttrib3s));
				glVertexAttrib3sv = (Delegates.glVertexAttrib3sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3sv"), typeof(Delegates.glVertexAttrib3sv));
				glVertexAttrib4Nbv = (Delegates.glVertexAttrib4Nbv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nbv"), typeof(Delegates.glVertexAttrib4Nbv));
				glVertexAttrib4Niv = (Delegates.glVertexAttrib4Niv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Niv"), typeof(Delegates.glVertexAttrib4Niv));
				glVertexAttrib4Nsv = (Delegates.glVertexAttrib4Nsv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nsv"), typeof(Delegates.glVertexAttrib4Nsv));
				glVertexAttrib4Nub = (Delegates.glVertexAttrib4Nub)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nub"), typeof(Delegates.glVertexAttrib4Nub));
				glVertexAttrib4Nubv = (Delegates.glVertexAttrib4Nubv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nubv"), typeof(Delegates.glVertexAttrib4Nubv));
				glVertexAttrib4Nuiv = (Delegates.glVertexAttrib4Nuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nuiv"), typeof(Delegates.glVertexAttrib4Nuiv));
				glVertexAttrib4Nusv = (Delegates.glVertexAttrib4Nusv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nusv"), typeof(Delegates.glVertexAttrib4Nusv));
				glVertexAttrib4bv = (Delegates.glVertexAttrib4bv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4bv"), typeof(Delegates.glVertexAttrib4bv));
				glVertexAttrib4d = (Delegates.glVertexAttrib4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4d"), typeof(Delegates.glVertexAttrib4d));
				glVertexAttrib4dv = (Delegates.glVertexAttrib4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4dv"), typeof(Delegates.glVertexAttrib4dv));
				glVertexAttrib4f = (Delegates.glVertexAttrib4f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4f"), typeof(Delegates.glVertexAttrib4f));
				glVertexAttrib4fv = (Delegates.glVertexAttrib4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4fv"), typeof(Delegates.glVertexAttrib4fv));
				glVertexAttrib4iv = (Delegates.glVertexAttrib4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4iv"), typeof(Delegates.glVertexAttrib4iv));
				glVertexAttrib4s = (Delegates.glVertexAttrib4s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4s"), typeof(Delegates.glVertexAttrib4s));
				glVertexAttrib4sv = (Delegates.glVertexAttrib4sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4sv"), typeof(Delegates.glVertexAttrib4sv));
				glVertexAttrib4ubv = (Delegates.glVertexAttrib4ubv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4ubv"), typeof(Delegates.glVertexAttrib4ubv));
				glVertexAttrib4uiv = (Delegates.glVertexAttrib4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4uiv"), typeof(Delegates.glVertexAttrib4uiv));
				glVertexAttrib4usv = (Delegates.glVertexAttrib4usv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4usv"), typeof(Delegates.glVertexAttrib4usv));
				glVertexAttribPointer = (Delegates.glVertexAttribPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribPointer"), typeof(Delegates.glVertexAttribPointer));
			}

			if (versionMajor > 2 || (versionMajor == 2 && versionMinor >= 1))
			{
				glUniformMatrix2x3fv = (Delegates.glUniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x3fv"), typeof(Delegates.glUniformMatrix2x3fv));
				glUniformMatrix3x2fv = (Delegates.glUniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x2fv"), typeof(Delegates.glUniformMatrix3x2fv));
				glUniformMatrix2x4fv = (Delegates.glUniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x4fv"), typeof(Delegates.glUniformMatrix2x4fv));
				glUniformMatrix4x2fv = (Delegates.glUniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x2fv"), typeof(Delegates.glUniformMatrix4x2fv));
				glUniformMatrix3x4fv = (Delegates.glUniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x4fv"), typeof(Delegates.glUniformMatrix3x4fv));
				glUniformMatrix4x3fv = (Delegates.glUniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x3fv"), typeof(Delegates.glUniformMatrix4x3fv));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 0))
			{
				glColorMaski = (Delegates.glColorMaski)Marshal.GetDelegateForFunctionPointer(getProcAddress("glColorMaski"), typeof(Delegates.glColorMaski));
				glGetBooleani_v = (Delegates.glGetBooleani_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBooleani_v"), typeof(Delegates.glGetBooleani_v));
				glGetIntegeri_v = (Delegates.glGetIntegeri_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetIntegeri_v"), typeof(Delegates.glGetIntegeri_v));
				glEnablei = (Delegates.glEnablei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnablei"), typeof(Delegates.glEnablei));
				glDisablei = (Delegates.glDisablei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisablei"), typeof(Delegates.glDisablei));
				glIsEnabledi = (Delegates.glIsEnabledi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsEnabledi"), typeof(Delegates.glIsEnabledi));
				glBeginTransformFeedback = (Delegates.glBeginTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginTransformFeedback"), typeof(Delegates.glBeginTransformFeedback));
				glEndTransformFeedback = (Delegates.glEndTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndTransformFeedback"), typeof(Delegates.glEndTransformFeedback));
				glBindBufferRange = (Delegates.glBindBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBufferRange"), typeof(Delegates.glBindBufferRange));
				glBindBufferBase = (Delegates.glBindBufferBase)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBufferBase"), typeof(Delegates.glBindBufferBase));
				glTransformFeedbackVaryings = (Delegates.glTransformFeedbackVaryings)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTransformFeedbackVaryings"), typeof(Delegates.glTransformFeedbackVaryings));
				glGetTransformFeedbackVarying = (Delegates.glGetTransformFeedbackVarying)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbackVarying"), typeof(Delegates.glGetTransformFeedbackVarying));
				glClampColor = (Delegates.glClampColor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClampColor"), typeof(Delegates.glClampColor));
				glBeginConditionalRender = (Delegates.glBeginConditionalRender)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginConditionalRender"), typeof(Delegates.glBeginConditionalRender));
				glEndConditionalRender = (Delegates.glEndConditionalRender)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndConditionalRender"), typeof(Delegates.glEndConditionalRender));
				glVertexAttribIPointer = (Delegates.glVertexAttribIPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribIPointer"), typeof(Delegates.glVertexAttribIPointer));
				glGetVertexAttribIiv = (Delegates.glGetVertexAttribIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribIiv"), typeof(Delegates.glGetVertexAttribIiv));
				glGetVertexAttribIuiv = (Delegates.glGetVertexAttribIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribIuiv"), typeof(Delegates.glGetVertexAttribIuiv));
				glVertexAttribI1i = (Delegates.glVertexAttribI1i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1i"), typeof(Delegates.glVertexAttribI1i));
				glVertexAttribI2i = (Delegates.glVertexAttribI2i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2i"), typeof(Delegates.glVertexAttribI2i));
				glVertexAttribI3i = (Delegates.glVertexAttribI3i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3i"), typeof(Delegates.glVertexAttribI3i));
				glVertexAttribI4i = (Delegates.glVertexAttribI4i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4i"), typeof(Delegates.glVertexAttribI4i));
				glVertexAttribI1ui = (Delegates.glVertexAttribI1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1ui"), typeof(Delegates.glVertexAttribI1ui));
				glVertexAttribI2ui = (Delegates.glVertexAttribI2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2ui"), typeof(Delegates.glVertexAttribI2ui));
				glVertexAttribI3ui = (Delegates.glVertexAttribI3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3ui"), typeof(Delegates.glVertexAttribI3ui));
				glVertexAttribI4ui = (Delegates.glVertexAttribI4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4ui"), typeof(Delegates.glVertexAttribI4ui));
				glVertexAttribI1iv = (Delegates.glVertexAttribI1iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1iv"), typeof(Delegates.glVertexAttribI1iv));
				glVertexAttribI2iv = (Delegates.glVertexAttribI2iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2iv"), typeof(Delegates.glVertexAttribI2iv));
				glVertexAttribI3iv = (Delegates.glVertexAttribI3iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3iv"), typeof(Delegates.glVertexAttribI3iv));
				glVertexAttribI4iv = (Delegates.glVertexAttribI4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4iv"), typeof(Delegates.glVertexAttribI4iv));
				glVertexAttribI1uiv = (Delegates.glVertexAttribI1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1uiv"), typeof(Delegates.glVertexAttribI1uiv));
				glVertexAttribI2uiv = (Delegates.glVertexAttribI2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2uiv"), typeof(Delegates.glVertexAttribI2uiv));
				glVertexAttribI3uiv = (Delegates.glVertexAttribI3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3uiv"), typeof(Delegates.glVertexAttribI3uiv));
				glVertexAttribI4uiv = (Delegates.glVertexAttribI4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4uiv"), typeof(Delegates.glVertexAttribI4uiv));
				glVertexAttribI4bv = (Delegates.glVertexAttribI4bv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4bv"), typeof(Delegates.glVertexAttribI4bv));
				glVertexAttribI4sv = (Delegates.glVertexAttribI4sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4sv"), typeof(Delegates.glVertexAttribI4sv));
				glVertexAttribI4ubv = (Delegates.glVertexAttribI4ubv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4ubv"), typeof(Delegates.glVertexAttribI4ubv));
				glVertexAttribI4usv = (Delegates.glVertexAttribI4usv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4usv"), typeof(Delegates.glVertexAttribI4usv));
				glGetUniformuiv = (Delegates.glGetUniformuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformuiv"), typeof(Delegates.glGetUniformuiv));
				glBindFragDataLocation = (Delegates.glBindFragDataLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindFragDataLocation"), typeof(Delegates.glBindFragDataLocation));
				glGetFragDataLocation = (Delegates.glGetFragDataLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFragDataLocation"), typeof(Delegates.glGetFragDataLocation));
				glUniform1ui = (Delegates.glUniform1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1ui"), typeof(Delegates.glUniform1ui));
				glUniform2ui = (Delegates.glUniform2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2ui"), typeof(Delegates.glUniform2ui));
				glUniform3ui = (Delegates.glUniform3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3ui"), typeof(Delegates.glUniform3ui));
				glUniform4ui = (Delegates.glUniform4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4ui"), typeof(Delegates.glUniform4ui));
				glUniform1uiv = (Delegates.glUniform1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1uiv"), typeof(Delegates.glUniform1uiv));
				glUniform2uiv = (Delegates.glUniform2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2uiv"), typeof(Delegates.glUniform2uiv));
				glUniform3uiv = (Delegates.glUniform3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3uiv"), typeof(Delegates.glUniform3uiv));
				glUniform4uiv = (Delegates.glUniform4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4uiv"), typeof(Delegates.glUniform4uiv));
				glTexParameterIiv = (Delegates.glTexParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterIiv"), typeof(Delegates.glTexParameterIiv));
				glTexParameterIuiv = (Delegates.glTexParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterIuiv"), typeof(Delegates.glTexParameterIuiv));
				glGetTexParameterIiv = (Delegates.glGetTexParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameterIiv"), typeof(Delegates.glGetTexParameterIiv));
				glGetTexParameterIuiv = (Delegates.glGetTexParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameterIuiv"), typeof(Delegates.glGetTexParameterIuiv));
				glClearBufferiv = (Delegates.glClearBufferiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferiv"), typeof(Delegates.glClearBufferiv));
				glClearBufferuiv = (Delegates.glClearBufferuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferuiv"), typeof(Delegates.glClearBufferuiv));
				glClearBufferfv = (Delegates.glClearBufferfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferfv"), typeof(Delegates.glClearBufferfv));
				glClearBufferfi = (Delegates.glClearBufferfi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferfi"), typeof(Delegates.glClearBufferfi));
				glGetStringi = (Delegates.glGetStringi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetStringi"), typeof(Delegates.glGetStringi));
				glIsRenderbuffer = (Delegates.glIsRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsRenderbuffer"), typeof(Delegates.glIsRenderbuffer));
				glBindRenderbuffer = (Delegates.glBindRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindRenderbuffer"), typeof(Delegates.glBindRenderbuffer));
				glDeleteRenderbuffers = (Delegates.glDeleteRenderbuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteRenderbuffers"), typeof(Delegates.glDeleteRenderbuffers));
				glGenRenderbuffers = (Delegates.glGenRenderbuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenRenderbuffers"), typeof(Delegates.glGenRenderbuffers));
				glRenderbufferStorage = (Delegates.glRenderbufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glRenderbufferStorage"), typeof(Delegates.glRenderbufferStorage));
				glGetRenderbufferParameteriv = (Delegates.glGetRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetRenderbufferParameteriv"), typeof(Delegates.glGetRenderbufferParameteriv));
				glIsFramebuffer = (Delegates.glIsFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsFramebuffer"), typeof(Delegates.glIsFramebuffer));
				glBindFramebuffer = (Delegates.glBindFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindFramebuffer"), typeof(Delegates.glBindFramebuffer));
				glDeleteFramebuffers = (Delegates.glDeleteFramebuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteFramebuffers"), typeof(Delegates.glDeleteFramebuffers));
				glGenFramebuffers = (Delegates.glGenFramebuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenFramebuffers"), typeof(Delegates.glGenFramebuffers));
				glCheckFramebufferStatus = (Delegates.glCheckFramebufferStatus)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCheckFramebufferStatus"), typeof(Delegates.glCheckFramebufferStatus));
				glFramebufferTexture1D = (Delegates.glFramebufferTexture1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture1D"), typeof(Delegates.glFramebufferTexture1D));
				glFramebufferTexture2D = (Delegates.glFramebufferTexture2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture2D"), typeof(Delegates.glFramebufferTexture2D));
				glFramebufferTexture3D = (Delegates.glFramebufferTexture3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture3D"), typeof(Delegates.glFramebufferTexture3D));
				glFramebufferRenderbuffer = (Delegates.glFramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferRenderbuffer"), typeof(Delegates.glFramebufferRenderbuffer));
				glGetFramebufferAttachmentParameteriv = (Delegates.glGetFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFramebufferAttachmentParameteriv"), typeof(Delegates.glGetFramebufferAttachmentParameteriv));
				glGenerateMipmap = (Delegates.glGenerateMipmap)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenerateMipmap"), typeof(Delegates.glGenerateMipmap));
				glBlitFramebuffer = (Delegates.glBlitFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlitFramebuffer"), typeof(Delegates.glBlitFramebuffer));
				glRenderbufferStorageMultisample = (Delegates.glRenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glRenderbufferStorageMultisample"), typeof(Delegates.glRenderbufferStorageMultisample));
				glFramebufferTextureLayer = (Delegates.glFramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTextureLayer"), typeof(Delegates.glFramebufferTextureLayer));
				glMapBufferRange = (Delegates.glMapBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapBufferRange"), typeof(Delegates.glMapBufferRange));
				glFlushMappedBufferRange = (Delegates.glFlushMappedBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFlushMappedBufferRange"), typeof(Delegates.glFlushMappedBufferRange));
				glBindVertexArray = (Delegates.glBindVertexArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindVertexArray"), typeof(Delegates.glBindVertexArray));
				glDeleteVertexArrays = (Delegates.glDeleteVertexArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteVertexArrays"), typeof(Delegates.glDeleteVertexArrays));
				glGenVertexArrays = (Delegates.glGenVertexArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenVertexArrays"), typeof(Delegates.glGenVertexArrays));
				glIsVertexArray = (Delegates.glIsVertexArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsVertexArray"), typeof(Delegates.glIsVertexArray));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 1))
			{
				glDrawArraysInstanced = (Delegates.glDrawArraysInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArraysInstanced"), typeof(Delegates.glDrawArraysInstanced));
				glDrawElementsInstanced = (Delegates.glDrawElementsInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstanced"), typeof(Delegates.glDrawElementsInstanced));
				glTexBuffer = (Delegates.glTexBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexBuffer"), typeof(Delegates.glTexBuffer));
				glPrimitiveRestartIndex = (Delegates.glPrimitiveRestartIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPrimitiveRestartIndex"), typeof(Delegates.glPrimitiveRestartIndex));
				glCopyBufferSubData = (Delegates.glCopyBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyBufferSubData"), typeof(Delegates.glCopyBufferSubData));
				glGetUniformIndices = (Delegates.glGetUniformIndices)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformIndices"), typeof(Delegates.glGetUniformIndices));
				glGetActiveUniformsiv = (Delegates.glGetActiveUniformsiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformsiv"), typeof(Delegates.glGetActiveUniformsiv));
				glGetActiveUniformName = (Delegates.glGetActiveUniformName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformName"), typeof(Delegates.glGetActiveUniformName));
				glGetUniformBlockIndex = (Delegates.glGetUniformBlockIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformBlockIndex"), typeof(Delegates.glGetUniformBlockIndex));
				glGetActiveUniformBlockiv = (Delegates.glGetActiveUniformBlockiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformBlockiv"), typeof(Delegates.glGetActiveUniformBlockiv));
				glGetActiveUniformBlockName = (Delegates.glGetActiveUniformBlockName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformBlockName"), typeof(Delegates.glGetActiveUniformBlockName));
				glUniformBlockBinding = (Delegates.glUniformBlockBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformBlockBinding"), typeof(Delegates.glUniformBlockBinding));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 2))
			{
				glDrawElementsBaseVertex = (Delegates.glDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsBaseVertex"), typeof(Delegates.glDrawElementsBaseVertex));
				glDrawRangeElementsBaseVertex = (Delegates.glDrawRangeElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawRangeElementsBaseVertex"), typeof(Delegates.glDrawRangeElementsBaseVertex));
				glDrawElementsInstancedBaseVertex = (Delegates.glDrawElementsInstancedBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstancedBaseVertex"), typeof(Delegates.glDrawElementsInstancedBaseVertex));
				glMultiDrawElementsBaseVertex = (Delegates.glMultiDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawElementsBaseVertex"), typeof(Delegates.glMultiDrawElementsBaseVertex));
				glProvokingVertex = (Delegates.glProvokingVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProvokingVertex"), typeof(Delegates.glProvokingVertex));
				glFenceSync = (Delegates.glFenceSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFenceSync"), typeof(Delegates.glFenceSync));
				glIsSync = (Delegates.glIsSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsSync"), typeof(Delegates.glIsSync));
				glDeleteSync = (Delegates.glDeleteSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteSync"), typeof(Delegates.glDeleteSync));
				glClientWaitSync = (Delegates.glClientWaitSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClientWaitSync"), typeof(Delegates.glClientWaitSync));
				glWaitSync = (Delegates.glWaitSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glWaitSync"), typeof(Delegates.glWaitSync));
				glGetInteger64v = (Delegates.glGetInteger64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInteger64v"), typeof(Delegates.glGetInteger64v));
				glGetSynciv = (Delegates.glGetSynciv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSynciv"), typeof(Delegates.glGetSynciv));
				glGetInteger64i_v = (Delegates.glGetInteger64i_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInteger64i_v"), typeof(Delegates.glGetInteger64i_v));
				glGetBufferParameteri64v = (Delegates.glGetBufferParameteri64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferParameteri64v"), typeof(Delegates.glGetBufferParameteri64v));
				glFramebufferTexture = (Delegates.glFramebufferTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture"), typeof(Delegates.glFramebufferTexture));
				glTexImage2DMultisample = (Delegates.glTexImage2DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage2DMultisample"), typeof(Delegates.glTexImage2DMultisample));
				glTexImage3DMultisample = (Delegates.glTexImage3DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage3DMultisample"), typeof(Delegates.glTexImage3DMultisample));
				glGetMultisamplefv = (Delegates.glGetMultisamplefv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetMultisamplefv"), typeof(Delegates.glGetMultisamplefv));
				glSampleMaski = (Delegates.glSampleMaski)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSampleMaski"), typeof(Delegates.glSampleMaski));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 3))
			{
				glBindFragDataLocationIndexed = (Delegates.glBindFragDataLocationIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindFragDataLocationIndexed"), typeof(Delegates.glBindFragDataLocationIndexed));
				glGetFragDataIndex = (Delegates.glGetFragDataIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFragDataIndex"), typeof(Delegates.glGetFragDataIndex));
				glGenSamplers = (Delegates.glGenSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenSamplers"), typeof(Delegates.glGenSamplers));
				glDeleteSamplers = (Delegates.glDeleteSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteSamplers"), typeof(Delegates.glDeleteSamplers));
				glIsSampler = (Delegates.glIsSampler)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsSampler"), typeof(Delegates.glIsSampler));
				glBindSampler = (Delegates.glBindSampler)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindSampler"), typeof(Delegates.glBindSampler));
				glSamplerParameteri = (Delegates.glSamplerParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameteri"), typeof(Delegates.glSamplerParameteri));
				glSamplerParameteriv = (Delegates.glSamplerParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameteriv"), typeof(Delegates.glSamplerParameteriv));
				glSamplerParameterf = (Delegates.glSamplerParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterf"), typeof(Delegates.glSamplerParameterf));
				glSamplerParameterfv = (Delegates.glSamplerParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterfv"), typeof(Delegates.glSamplerParameterfv));
				glSamplerParameterIiv = (Delegates.glSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterIiv"), typeof(Delegates.glSamplerParameterIiv));
				glSamplerParameterIuiv = (Delegates.glSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterIuiv"), typeof(Delegates.glSamplerParameterIuiv));
				glGetSamplerParameteriv = (Delegates.glGetSamplerParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameteriv"), typeof(Delegates.glGetSamplerParameteriv));
				glGetSamplerParameterIiv = (Delegates.glGetSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameterIiv"), typeof(Delegates.glGetSamplerParameterIiv));
				glGetSamplerParameterfv = (Delegates.glGetSamplerParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameterfv"), typeof(Delegates.glGetSamplerParameterfv));
				glGetSamplerParameterIuiv = (Delegates.glGetSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameterIuiv"), typeof(Delegates.glGetSamplerParameterIuiv));
				glQueryCounter = (Delegates.glQueryCounter)Marshal.GetDelegateForFunctionPointer(getProcAddress("glQueryCounter"), typeof(Delegates.glQueryCounter));
				glGetQueryObjecti64v = (Delegates.glGetQueryObjecti64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjecti64v"), typeof(Delegates.glGetQueryObjecti64v));
				glGetQueryObjectui64v = (Delegates.glGetQueryObjectui64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjectui64v"), typeof(Delegates.glGetQueryObjectui64v));
				glVertexAttribDivisor = (Delegates.glVertexAttribDivisor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribDivisor"), typeof(Delegates.glVertexAttribDivisor));
				glVertexAttribP1ui = (Delegates.glVertexAttribP1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP1ui"), typeof(Delegates.glVertexAttribP1ui));
				glVertexAttribP1uiv = (Delegates.glVertexAttribP1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP1uiv"), typeof(Delegates.glVertexAttribP1uiv));
				glVertexAttribP2ui = (Delegates.glVertexAttribP2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP2ui"), typeof(Delegates.glVertexAttribP2ui));
				glVertexAttribP2uiv = (Delegates.glVertexAttribP2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP2uiv"), typeof(Delegates.glVertexAttribP2uiv));
				glVertexAttribP3ui = (Delegates.glVertexAttribP3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP3ui"), typeof(Delegates.glVertexAttribP3ui));
				glVertexAttribP3uiv = (Delegates.glVertexAttribP3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP3uiv"), typeof(Delegates.glVertexAttribP3uiv));
				glVertexAttribP4ui = (Delegates.glVertexAttribP4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP4ui"), typeof(Delegates.glVertexAttribP4ui));
				glVertexAttribP4uiv = (Delegates.glVertexAttribP4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP4uiv"), typeof(Delegates.glVertexAttribP4uiv));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 0))
			{
				glMinSampleShading = (Delegates.glMinSampleShading)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMinSampleShading"), typeof(Delegates.glMinSampleShading));
				glBlendEquationi = (Delegates.glBlendEquationi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquationi"), typeof(Delegates.glBlendEquationi));
				glBlendEquationSeparatei = (Delegates.glBlendEquationSeparatei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquationSeparatei"), typeof(Delegates.glBlendEquationSeparatei));
				glBlendFunci = (Delegates.glBlendFunci)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFunci"), typeof(Delegates.glBlendFunci));
				glBlendFuncSeparatei = (Delegates.glBlendFuncSeparatei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFuncSeparatei"), typeof(Delegates.glBlendFuncSeparatei));
				glDrawArraysIndirect = (Delegates.glDrawArraysIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArraysIndirect"), typeof(Delegates.glDrawArraysIndirect));
				glDrawElementsIndirect = (Delegates.glDrawElementsIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsIndirect"), typeof(Delegates.glDrawElementsIndirect));
				glUniform1d = (Delegates.glUniform1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1d"), typeof(Delegates.glUniform1d));
				glUniform2d = (Delegates.glUniform2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2d"), typeof(Delegates.glUniform2d));
				glUniform3d = (Delegates.glUniform3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3d"), typeof(Delegates.glUniform3d));
				glUniform4d = (Delegates.glUniform4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4d"), typeof(Delegates.glUniform4d));
				glUniform1dv = (Delegates.glUniform1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1dv"), typeof(Delegates.glUniform1dv));
				glUniform2dv = (Delegates.glUniform2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2dv"), typeof(Delegates.glUniform2dv));
				glUniform3dv = (Delegates.glUniform3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3dv"), typeof(Delegates.glUniform3dv));
				glUniform4dv = (Delegates.glUniform4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4dv"), typeof(Delegates.glUniform4dv));
				glUniformMatrix2dv = (Delegates.glUniformMatrix2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2dv"), typeof(Delegates.glUniformMatrix2dv));
				glUniformMatrix3dv = (Delegates.glUniformMatrix3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3dv"), typeof(Delegates.glUniformMatrix3dv));
				glUniformMatrix4dv = (Delegates.glUniformMatrix4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4dv"), typeof(Delegates.glUniformMatrix4dv));
				glUniformMatrix2x3dv = (Delegates.glUniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x3dv"), typeof(Delegates.glUniformMatrix2x3dv));
				glUniformMatrix2x4dv = (Delegates.glUniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x4dv"), typeof(Delegates.glUniformMatrix2x4dv));
				glUniformMatrix3x2dv = (Delegates.glUniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x2dv"), typeof(Delegates.glUniformMatrix3x2dv));
				glUniformMatrix3x4dv = (Delegates.glUniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x4dv"), typeof(Delegates.glUniformMatrix3x4dv));
				glUniformMatrix4x2dv = (Delegates.glUniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x2dv"), typeof(Delegates.glUniformMatrix4x2dv));
				glUniformMatrix4x3dv = (Delegates.glUniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x3dv"), typeof(Delegates.glUniformMatrix4x3dv));
				glGetUniformdv = (Delegates.glGetUniformdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformdv"), typeof(Delegates.glGetUniformdv));
				glGetSubroutineUniformLocation = (Delegates.glGetSubroutineUniformLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSubroutineUniformLocation"), typeof(Delegates.glGetSubroutineUniformLocation));
				glGetSubroutineIndex = (Delegates.glGetSubroutineIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSubroutineIndex"), typeof(Delegates.glGetSubroutineIndex));
				glGetActiveSubroutineUniformiv = (Delegates.glGetActiveSubroutineUniformiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveSubroutineUniformiv"), typeof(Delegates.glGetActiveSubroutineUniformiv));
				glGetActiveSubroutineUniformName = (Delegates.glGetActiveSubroutineUniformName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveSubroutineUniformName"), typeof(Delegates.glGetActiveSubroutineUniformName));
				glGetActiveSubroutineName = (Delegates.glGetActiveSubroutineName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveSubroutineName"), typeof(Delegates.glGetActiveSubroutineName));
				glUniformSubroutinesuiv = (Delegates.glUniformSubroutinesuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformSubroutinesuiv"), typeof(Delegates.glUniformSubroutinesuiv));
				glGetUniformSubroutineuiv = (Delegates.glGetUniformSubroutineuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformSubroutineuiv"), typeof(Delegates.glGetUniformSubroutineuiv));
				glGetProgramStageiv = (Delegates.glGetProgramStageiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramStageiv"), typeof(Delegates.glGetProgramStageiv));
				glPatchParameteri = (Delegates.glPatchParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPatchParameteri"), typeof(Delegates.glPatchParameteri));
				glPatchParameterfv = (Delegates.glPatchParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPatchParameterfv"), typeof(Delegates.glPatchParameterfv));
				glBindTransformFeedback = (Delegates.glBindTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTransformFeedback"), typeof(Delegates.glBindTransformFeedback));
				glDeleteTransformFeedbacks = (Delegates.glDeleteTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteTransformFeedbacks"), typeof(Delegates.glDeleteTransformFeedbacks));
				glGenTransformFeedbacks = (Delegates.glGenTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenTransformFeedbacks"), typeof(Delegates.glGenTransformFeedbacks));
				glIsTransformFeedback = (Delegates.glIsTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsTransformFeedback"), typeof(Delegates.glIsTransformFeedback));
				glPauseTransformFeedback = (Delegates.glPauseTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPauseTransformFeedback"), typeof(Delegates.glPauseTransformFeedback));
				glResumeTransformFeedback = (Delegates.glResumeTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glResumeTransformFeedback"), typeof(Delegates.glResumeTransformFeedback));
				glDrawTransformFeedback = (Delegates.glDrawTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedback"), typeof(Delegates.glDrawTransformFeedback));
				glDrawTransformFeedbackStream = (Delegates.glDrawTransformFeedbackStream)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedbackStream"), typeof(Delegates.glDrawTransformFeedbackStream));
				glBeginQueryIndexed = (Delegates.glBeginQueryIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginQueryIndexed"), typeof(Delegates.glBeginQueryIndexed));
				glEndQueryIndexed = (Delegates.glEndQueryIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndQueryIndexed"), typeof(Delegates.glEndQueryIndexed));
				glGetQueryIndexediv = (Delegates.glGetQueryIndexediv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryIndexediv"), typeof(Delegates.glGetQueryIndexediv));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 1))
			{
				glReleaseShaderCompiler = (Delegates.glReleaseShaderCompiler)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReleaseShaderCompiler"), typeof(Delegates.glReleaseShaderCompiler));
				glShaderBinary = (Delegates.glShaderBinary)Marshal.GetDelegateForFunctionPointer(getProcAddress("glShaderBinary"), typeof(Delegates.glShaderBinary));
				glGetShaderPrecisionFormat = (Delegates.glGetShaderPrecisionFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderPrecisionFormat"), typeof(Delegates.glGetShaderPrecisionFormat));
				glDepthRangef = (Delegates.glDepthRangef)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRangef"), typeof(Delegates.glDepthRangef));
				glClearDepthf = (Delegates.glClearDepthf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearDepthf"), typeof(Delegates.glClearDepthf));
				glGetProgramBinary = (Delegates.glGetProgramBinary)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramBinary"), typeof(Delegates.glGetProgramBinary));
				glProgramBinary = (Delegates.glProgramBinary)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramBinary"), typeof(Delegates.glProgramBinary));
				glProgramParameteri = (Delegates.glProgramParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramParameteri"), typeof(Delegates.glProgramParameteri));
				glUseProgramStages = (Delegates.glUseProgramStages)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUseProgramStages"), typeof(Delegates.glUseProgramStages));
				glActiveShaderProgram = (Delegates.glActiveShaderProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glActiveShaderProgram"), typeof(Delegates.glActiveShaderProgram));
				glCreateShaderProgramv = (Delegates.glCreateShaderProgramv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateShaderProgramv"), typeof(Delegates.glCreateShaderProgramv));
				glBindProgramPipeline = (Delegates.glBindProgramPipeline)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindProgramPipeline"), typeof(Delegates.glBindProgramPipeline));
				glDeleteProgramPipelines = (Delegates.glDeleteProgramPipelines)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteProgramPipelines"), typeof(Delegates.glDeleteProgramPipelines));
				glGenProgramPipelines = (Delegates.glGenProgramPipelines)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenProgramPipelines"), typeof(Delegates.glGenProgramPipelines));
				glIsProgramPipeline = (Delegates.glIsProgramPipeline)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsProgramPipeline"), typeof(Delegates.glIsProgramPipeline));
				glGetProgramPipelineiv = (Delegates.glGetProgramPipelineiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramPipelineiv"), typeof(Delegates.glGetProgramPipelineiv));
				glProgramUniform1i = (Delegates.glProgramUniform1i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1i"), typeof(Delegates.glProgramUniform1i));
				glProgramUniform1iv = (Delegates.glProgramUniform1iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1iv"), typeof(Delegates.glProgramUniform1iv));
				glProgramUniform1f = (Delegates.glProgramUniform1f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1f"), typeof(Delegates.glProgramUniform1f));
				glProgramUniform1fv = (Delegates.glProgramUniform1fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1fv"), typeof(Delegates.glProgramUniform1fv));
				glProgramUniform1d = (Delegates.glProgramUniform1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1d"), typeof(Delegates.glProgramUniform1d));
				glProgramUniform1dv = (Delegates.glProgramUniform1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1dv"), typeof(Delegates.glProgramUniform1dv));
				glProgramUniform1ui = (Delegates.glProgramUniform1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1ui"), typeof(Delegates.glProgramUniform1ui));
				glProgramUniform1uiv = (Delegates.glProgramUniform1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1uiv"), typeof(Delegates.glProgramUniform1uiv));
				glProgramUniform2i = (Delegates.glProgramUniform2i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2i"), typeof(Delegates.glProgramUniform2i));
				glProgramUniform2iv = (Delegates.glProgramUniform2iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2iv"), typeof(Delegates.glProgramUniform2iv));
				glProgramUniform2f = (Delegates.glProgramUniform2f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2f"), typeof(Delegates.glProgramUniform2f));
				glProgramUniform2fv = (Delegates.glProgramUniform2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2fv"), typeof(Delegates.glProgramUniform2fv));
				glProgramUniform2d = (Delegates.glProgramUniform2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2d"), typeof(Delegates.glProgramUniform2d));
				glProgramUniform2dv = (Delegates.glProgramUniform2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2dv"), typeof(Delegates.glProgramUniform2dv));
				glProgramUniform2ui = (Delegates.glProgramUniform2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2ui"), typeof(Delegates.glProgramUniform2ui));
				glProgramUniform2uiv = (Delegates.glProgramUniform2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2uiv"), typeof(Delegates.glProgramUniform2uiv));
				glProgramUniform3i = (Delegates.glProgramUniform3i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3i"), typeof(Delegates.glProgramUniform3i));
				glProgramUniform3iv = (Delegates.glProgramUniform3iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3iv"), typeof(Delegates.glProgramUniform3iv));
				glProgramUniform3f = (Delegates.glProgramUniform3f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3f"), typeof(Delegates.glProgramUniform3f));
				glProgramUniform3fv = (Delegates.glProgramUniform3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3fv"), typeof(Delegates.glProgramUniform3fv));
				glProgramUniform3d = (Delegates.glProgramUniform3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3d"), typeof(Delegates.glProgramUniform3d));
				glProgramUniform3dv = (Delegates.glProgramUniform3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3dv"), typeof(Delegates.glProgramUniform3dv));
				glProgramUniform3ui = (Delegates.glProgramUniform3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3ui"), typeof(Delegates.glProgramUniform3ui));
				glProgramUniform3uiv = (Delegates.glProgramUniform3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3uiv"), typeof(Delegates.glProgramUniform3uiv));
				glProgramUniform4i = (Delegates.glProgramUniform4i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4i"), typeof(Delegates.glProgramUniform4i));
				glProgramUniform4iv = (Delegates.glProgramUniform4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4iv"), typeof(Delegates.glProgramUniform4iv));
				glProgramUniform4f = (Delegates.glProgramUniform4f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4f"), typeof(Delegates.glProgramUniform4f));
				glProgramUniform4fv = (Delegates.glProgramUniform4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4fv"), typeof(Delegates.glProgramUniform4fv));
				glProgramUniform4d = (Delegates.glProgramUniform4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4d"), typeof(Delegates.glProgramUniform4d));
				glProgramUniform4dv = (Delegates.glProgramUniform4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4dv"), typeof(Delegates.glProgramUniform4dv));
				glProgramUniform4ui = (Delegates.glProgramUniform4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4ui"), typeof(Delegates.glProgramUniform4ui));
				glProgramUniform4uiv = (Delegates.glProgramUniform4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4uiv"), typeof(Delegates.glProgramUniform4uiv));
				glProgramUniformMatrix2fv = (Delegates.glProgramUniformMatrix2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2fv"), typeof(Delegates.glProgramUniformMatrix2fv));
				glProgramUniformMatrix3fv = (Delegates.glProgramUniformMatrix3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3fv"), typeof(Delegates.glProgramUniformMatrix3fv));
				glProgramUniformMatrix4fv = (Delegates.glProgramUniformMatrix4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4fv"), typeof(Delegates.glProgramUniformMatrix4fv));
				glProgramUniformMatrix2dv = (Delegates.glProgramUniformMatrix2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2dv"), typeof(Delegates.glProgramUniformMatrix2dv));
				glProgramUniformMatrix3dv = (Delegates.glProgramUniformMatrix3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3dv"), typeof(Delegates.glProgramUniformMatrix3dv));
				glProgramUniformMatrix4dv = (Delegates.glProgramUniformMatrix4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4dv"), typeof(Delegates.glProgramUniformMatrix4dv));
				glProgramUniformMatrix2x3fv = (Delegates.glProgramUniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x3fv"), typeof(Delegates.glProgramUniformMatrix2x3fv));
				glProgramUniformMatrix3x2fv = (Delegates.glProgramUniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x2fv"), typeof(Delegates.glProgramUniformMatrix3x2fv));
				glProgramUniformMatrix2x4fv = (Delegates.glProgramUniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x4fv"), typeof(Delegates.glProgramUniformMatrix2x4fv));
				glProgramUniformMatrix4x2fv = (Delegates.glProgramUniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x2fv"), typeof(Delegates.glProgramUniformMatrix4x2fv));
				glProgramUniformMatrix3x4fv = (Delegates.glProgramUniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x4fv"), typeof(Delegates.glProgramUniformMatrix3x4fv));
				glProgramUniformMatrix4x3fv = (Delegates.glProgramUniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x3fv"), typeof(Delegates.glProgramUniformMatrix4x3fv));
				glProgramUniformMatrix2x3dv = (Delegates.glProgramUniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x3dv"), typeof(Delegates.glProgramUniformMatrix2x3dv));
				glProgramUniformMatrix3x2dv = (Delegates.glProgramUniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x2dv"), typeof(Delegates.glProgramUniformMatrix3x2dv));
				glProgramUniformMatrix2x4dv = (Delegates.glProgramUniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x4dv"), typeof(Delegates.glProgramUniformMatrix2x4dv));
				glProgramUniformMatrix4x2dv = (Delegates.glProgramUniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x2dv"), typeof(Delegates.glProgramUniformMatrix4x2dv));
				glProgramUniformMatrix3x4dv = (Delegates.glProgramUniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x4dv"), typeof(Delegates.glProgramUniformMatrix3x4dv));
				glProgramUniformMatrix4x3dv = (Delegates.glProgramUniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x3dv"), typeof(Delegates.glProgramUniformMatrix4x3dv));
				glValidateProgramPipeline = (Delegates.glValidateProgramPipeline)Marshal.GetDelegateForFunctionPointer(getProcAddress("glValidateProgramPipeline"), typeof(Delegates.glValidateProgramPipeline));
				glGetProgramPipelineInfoLog = (Delegates.glGetProgramPipelineInfoLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramPipelineInfoLog"), typeof(Delegates.glGetProgramPipelineInfoLog));
				glVertexAttribL1d = (Delegates.glVertexAttribL1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL1d"), typeof(Delegates.glVertexAttribL1d));
				glVertexAttribL2d = (Delegates.glVertexAttribL2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL2d"), typeof(Delegates.glVertexAttribL2d));
				glVertexAttribL3d = (Delegates.glVertexAttribL3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL3d"), typeof(Delegates.glVertexAttribL3d));
				glVertexAttribL4d = (Delegates.glVertexAttribL4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL4d"), typeof(Delegates.glVertexAttribL4d));
				glVertexAttribL1dv = (Delegates.glVertexAttribL1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL1dv"), typeof(Delegates.glVertexAttribL1dv));
				glVertexAttribL2dv = (Delegates.glVertexAttribL2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL2dv"), typeof(Delegates.glVertexAttribL2dv));
				glVertexAttribL3dv = (Delegates.glVertexAttribL3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL3dv"), typeof(Delegates.glVertexAttribL3dv));
				glVertexAttribL4dv = (Delegates.glVertexAttribL4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL4dv"), typeof(Delegates.glVertexAttribL4dv));
				glVertexAttribLPointer = (Delegates.glVertexAttribLPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribLPointer"), typeof(Delegates.glVertexAttribLPointer));
				glGetVertexAttribLdv = (Delegates.glGetVertexAttribLdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribLdv"), typeof(Delegates.glGetVertexAttribLdv));
				glViewportArrayv = (Delegates.glViewportArrayv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewportArrayv"), typeof(Delegates.glViewportArrayv));
				glViewportIndexedf = (Delegates.glViewportIndexedf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewportIndexedf"), typeof(Delegates.glViewportIndexedf));
				glViewportIndexedfv = (Delegates.glViewportIndexedfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewportIndexedfv"), typeof(Delegates.glViewportIndexedfv));
				glScissorArrayv = (Delegates.glScissorArrayv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissorArrayv"), typeof(Delegates.glScissorArrayv));
				glScissorIndexed = (Delegates.glScissorIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissorIndexed"), typeof(Delegates.glScissorIndexed));
				glScissorIndexedv = (Delegates.glScissorIndexedv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissorIndexedv"), typeof(Delegates.glScissorIndexedv));
				glDepthRangeArrayv = (Delegates.glDepthRangeArrayv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRangeArrayv"), typeof(Delegates.glDepthRangeArrayv));
				glDepthRangeIndexed = (Delegates.glDepthRangeIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRangeIndexed"), typeof(Delegates.glDepthRangeIndexed));
				glGetFloati_v = (Delegates.glGetFloati_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFloati_v"), typeof(Delegates.glGetFloati_v));
				glGetDoublei_v = (Delegates.glGetDoublei_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetDoublei_v"), typeof(Delegates.glGetDoublei_v));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 2))
			{
				glDrawArraysInstancedBaseInstance = (Delegates.glDrawArraysInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArraysInstancedBaseInstance"), typeof(Delegates.glDrawArraysInstancedBaseInstance));
				glDrawElementsInstancedBaseInstance = (Delegates.glDrawElementsInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstancedBaseInstance"), typeof(Delegates.glDrawElementsInstancedBaseInstance));
				glDrawElementsInstancedBaseVertexBaseInstance = (Delegates.glDrawElementsInstancedBaseVertexBaseInstance)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstancedBaseVertexBaseInstance"), typeof(Delegates.glDrawElementsInstancedBaseVertexBaseInstance));
				glGetInternalformativ = (Delegates.glGetInternalformativ)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInternalformativ"), typeof(Delegates.glGetInternalformativ));
				glGetActiveAtomicCounterBufferiv = (Delegates.glGetActiveAtomicCounterBufferiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveAtomicCounterBufferiv"), typeof(Delegates.glGetActiveAtomicCounterBufferiv));
				glBindImageTexture = (Delegates.glBindImageTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindImageTexture"), typeof(Delegates.glBindImageTexture));
				glMemoryBarrier = (Delegates.glMemoryBarrier)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMemoryBarrier"), typeof(Delegates.glMemoryBarrier));
				glTexStorage1D = (Delegates.glTexStorage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage1D"), typeof(Delegates.glTexStorage1D));
				glTexStorage2D = (Delegates.glTexStorage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage2D"), typeof(Delegates.glTexStorage2D));
				glTexStorage3D = (Delegates.glTexStorage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage3D"), typeof(Delegates.glTexStorage3D));
				glDrawTransformFeedbackInstanced = (Delegates.glDrawTransformFeedbackInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedbackInstanced"), typeof(Delegates.glDrawTransformFeedbackInstanced));
				glDrawTransformFeedbackStreamInstanced = (Delegates.glDrawTransformFeedbackStreamInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedbackStreamInstanced"), typeof(Delegates.glDrawTransformFeedbackStreamInstanced));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 3))
			{
				glClearBufferData = (Delegates.glClearBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferData"), typeof(Delegates.glClearBufferData));
				glClearBufferSubData = (Delegates.glClearBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferSubData"), typeof(Delegates.glClearBufferSubData));
				glDispatchCompute = (Delegates.glDispatchCompute)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDispatchCompute"), typeof(Delegates.glDispatchCompute));
				glDispatchComputeIndirect = (Delegates.glDispatchComputeIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDispatchComputeIndirect"), typeof(Delegates.glDispatchComputeIndirect));
				glCopyImageSubData = (Delegates.glCopyImageSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyImageSubData"), typeof(Delegates.glCopyImageSubData));
				glFramebufferParameteri = (Delegates.glFramebufferParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferParameteri"), typeof(Delegates.glFramebufferParameteri));
				glGetFramebufferParameteriv = (Delegates.glGetFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFramebufferParameteriv"), typeof(Delegates.glGetFramebufferParameteriv));
				glGetInternalformati64v = (Delegates.glGetInternalformati64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInternalformati64v"), typeof(Delegates.glGetInternalformati64v));
				glInvalidateTexSubImage = (Delegates.glInvalidateTexSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateTexSubImage"), typeof(Delegates.glInvalidateTexSubImage));
				glInvalidateTexImage = (Delegates.glInvalidateTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateTexImage"), typeof(Delegates.glInvalidateTexImage));
				glInvalidateBufferSubData = (Delegates.glInvalidateBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateBufferSubData"), typeof(Delegates.glInvalidateBufferSubData));
				glInvalidateBufferData = (Delegates.glInvalidateBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateBufferData"), typeof(Delegates.glInvalidateBufferData));
				glInvalidateFramebuffer = (Delegates.glInvalidateFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateFramebuffer"), typeof(Delegates.glInvalidateFramebuffer));
				glInvalidateSubFramebuffer = (Delegates.glInvalidateSubFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateSubFramebuffer"), typeof(Delegates.glInvalidateSubFramebuffer));
				glMultiDrawArraysIndirect = (Delegates.glMultiDrawArraysIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawArraysIndirect"), typeof(Delegates.glMultiDrawArraysIndirect));
				glMultiDrawElementsIndirect = (Delegates.glMultiDrawElementsIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawElementsIndirect"), typeof(Delegates.glMultiDrawElementsIndirect));
				glGetProgramInterfaceiv = (Delegates.glGetProgramInterfaceiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramInterfaceiv"), typeof(Delegates.glGetProgramInterfaceiv));
				glGetProgramResourceIndex = (Delegates.glGetProgramResourceIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceIndex"), typeof(Delegates.glGetProgramResourceIndex));
				glGetProgramResourceName = (Delegates.glGetProgramResourceName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceName"), typeof(Delegates.glGetProgramResourceName));
				glGetProgramResourceiv = (Delegates.glGetProgramResourceiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceiv"), typeof(Delegates.glGetProgramResourceiv));
				glGetProgramResourceLocation = (Delegates.glGetProgramResourceLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceLocation"), typeof(Delegates.glGetProgramResourceLocation));
				glGetProgramResourceLocationIndex = (Delegates.glGetProgramResourceLocationIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceLocationIndex"), typeof(Delegates.glGetProgramResourceLocationIndex));
				glShaderStorageBlockBinding = (Delegates.glShaderStorageBlockBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glShaderStorageBlockBinding"), typeof(Delegates.glShaderStorageBlockBinding));
				glTexBufferRange = (Delegates.glTexBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexBufferRange"), typeof(Delegates.glTexBufferRange));
				glTexStorage2DMultisample = (Delegates.glTexStorage2DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage2DMultisample"), typeof(Delegates.glTexStorage2DMultisample));
				glTexStorage3DMultisample = (Delegates.glTexStorage3DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage3DMultisample"), typeof(Delegates.glTexStorage3DMultisample));
				glTextureView = (Delegates.glTextureView)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureView"), typeof(Delegates.glTextureView));
				glBindVertexBuffer = (Delegates.glBindVertexBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindVertexBuffer"), typeof(Delegates.glBindVertexBuffer));
				glVertexAttribFormat = (Delegates.glVertexAttribFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribFormat"), typeof(Delegates.glVertexAttribFormat));
				glVertexAttribIFormat = (Delegates.glVertexAttribIFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribIFormat"), typeof(Delegates.glVertexAttribIFormat));
				glVertexAttribLFormat = (Delegates.glVertexAttribLFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribLFormat"), typeof(Delegates.glVertexAttribLFormat));
				glVertexAttribBinding = (Delegates.glVertexAttribBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribBinding"), typeof(Delegates.glVertexAttribBinding));
				glVertexBindingDivisor = (Delegates.glVertexBindingDivisor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexBindingDivisor"), typeof(Delegates.glVertexBindingDivisor));
				glDebugMessageControl = (Delegates.glDebugMessageControl)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDebugMessageControl"), typeof(Delegates.glDebugMessageControl));
				glDebugMessageInsert = (Delegates.glDebugMessageInsert)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDebugMessageInsert"), typeof(Delegates.glDebugMessageInsert));
				glDebugMessageCallback = (Delegates.glDebugMessageCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDebugMessageCallback"), typeof(Delegates.glDebugMessageCallback));
				glGetDebugMessageLog = (Delegates.glGetDebugMessageLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetDebugMessageLog"), typeof(Delegates.glGetDebugMessageLog));
				glPushDebugGroup = (Delegates.glPushDebugGroup)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPushDebugGroup"), typeof(Delegates.glPushDebugGroup));
				glPopDebugGroup = (Delegates.glPopDebugGroup)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPopDebugGroup"), typeof(Delegates.glPopDebugGroup));
				glObjectLabel = (Delegates.glObjectLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glObjectLabel"), typeof(Delegates.glObjectLabel));
				glGetObjectLabel = (Delegates.glGetObjectLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetObjectLabel"), typeof(Delegates.glGetObjectLabel));
				glObjectPtrLabel = (Delegates.glObjectPtrLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glObjectPtrLabel"), typeof(Delegates.glObjectPtrLabel));
				glGetObjectPtrLabel = (Delegates.glGetObjectPtrLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetObjectPtrLabel"), typeof(Delegates.glGetObjectPtrLabel));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 4))
			{
				glBufferStorage = (Delegates.glBufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBufferStorage"), typeof(Delegates.glBufferStorage));
				glClearTexImage = (Delegates.glClearTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearTexImage"), typeof(Delegates.glClearTexImage));
				glClearTexSubImage = (Delegates.glClearTexSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearTexSubImage"), typeof(Delegates.glClearTexSubImage));
				glBindBuffersBase = (Delegates.glBindBuffersBase)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBuffersBase"), typeof(Delegates.glBindBuffersBase));
				glBindBuffersRange = (Delegates.glBindBuffersRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBuffersRange"), typeof(Delegates.glBindBuffersRange));
				glBindTextures = (Delegates.glBindTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTextures"), typeof(Delegates.glBindTextures));
				glBindSamplers = (Delegates.glBindSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindSamplers"), typeof(Delegates.glBindSamplers));
				glBindImageTextures = (Delegates.glBindImageTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindImageTextures"), typeof(Delegates.glBindImageTextures));
				glBindVertexBuffers = (Delegates.glBindVertexBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindVertexBuffers"), typeof(Delegates.glBindVertexBuffers));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 5))
			{
				glClipControl = (Delegates.glClipControl)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClipControl"), typeof(Delegates.glClipControl));
				glCreateTransformFeedbacks = (Delegates.glCreateTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateTransformFeedbacks"), typeof(Delegates.glCreateTransformFeedbacks));
				glTransformFeedbackBufferBase = (Delegates.glTransformFeedbackBufferBase)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTransformFeedbackBufferBase"), typeof(Delegates.glTransformFeedbackBufferBase));
				glTransformFeedbackBufferRange = (Delegates.glTransformFeedbackBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTransformFeedbackBufferRange"), typeof(Delegates.glTransformFeedbackBufferRange));
				glGetTransformFeedbackiv = (Delegates.glGetTransformFeedbackiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbackiv"), typeof(Delegates.glGetTransformFeedbackiv));
				glGetTransformFeedbacki_v = (Delegates.glGetTransformFeedbacki_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbacki_v"), typeof(Delegates.glGetTransformFeedbacki_v));
				glGetTransformFeedbacki64_v = (Delegates.glGetTransformFeedbacki64_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbacki64_v"), typeof(Delegates.glGetTransformFeedbacki64_v));
				glCreateBuffers = (Delegates.glCreateBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateBuffers"), typeof(Delegates.glCreateBuffers));
				glNamedBufferStorage = (Delegates.glNamedBufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedBufferStorage"), typeof(Delegates.glNamedBufferStorage));
				glNamedBufferData = (Delegates.glNamedBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedBufferData"), typeof(Delegates.glNamedBufferData));
				glNamedBufferSubData = (Delegates.glNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedBufferSubData"), typeof(Delegates.glNamedBufferSubData));
				glCopyNamedBufferSubData = (Delegates.glCopyNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyNamedBufferSubData"), typeof(Delegates.glCopyNamedBufferSubData));
				glClearNamedBufferData = (Delegates.glClearNamedBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedBufferData"), typeof(Delegates.glClearNamedBufferData));
				glClearNamedBufferSubData = (Delegates.glClearNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedBufferSubData"), typeof(Delegates.glClearNamedBufferSubData));
				glMapNamedBuffer = (Delegates.glMapNamedBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapNamedBuffer"), typeof(Delegates.glMapNamedBuffer));
				glMapNamedBufferRange = (Delegates.glMapNamedBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapNamedBufferRange"), typeof(Delegates.glMapNamedBufferRange));
				glUnmapNamedBuffer = (Delegates.glUnmapNamedBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUnmapNamedBuffer"), typeof(Delegates.glUnmapNamedBuffer));
				glFlushMappedNamedBufferRange = (Delegates.glFlushMappedNamedBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFlushMappedNamedBufferRange"), typeof(Delegates.glFlushMappedNamedBufferRange));
				glGetNamedBufferParameteriv = (Delegates.glGetNamedBufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferParameteriv"), typeof(Delegates.glGetNamedBufferParameteriv));
				glGetNamedBufferParameteri64v = (Delegates.glGetNamedBufferParameteri64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferParameteri64v"), typeof(Delegates.glGetNamedBufferParameteri64v));
				glGetNamedBufferPointerv = (Delegates.glGetNamedBufferPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferPointerv"), typeof(Delegates.glGetNamedBufferPointerv));
				glGetNamedBufferSubData = (Delegates.glGetNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferSubData"), typeof(Delegates.glGetNamedBufferSubData));
				glCreateFramebuffers = (Delegates.glCreateFramebuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateFramebuffers"), typeof(Delegates.glCreateFramebuffers));
				glNamedFramebufferRenderbuffer = (Delegates.glNamedFramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferRenderbuffer"), typeof(Delegates.glNamedFramebufferRenderbuffer));
				glNamedFramebufferParameteri = (Delegates.glNamedFramebufferParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferParameteri"), typeof(Delegates.glNamedFramebufferParameteri));
				glNamedFramebufferTexture = (Delegates.glNamedFramebufferTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferTexture"), typeof(Delegates.glNamedFramebufferTexture));
				glNamedFramebufferTextureLayer = (Delegates.glNamedFramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferTextureLayer"), typeof(Delegates.glNamedFramebufferTextureLayer));
				glNamedFramebufferDrawBuffer = (Delegates.glNamedFramebufferDrawBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferDrawBuffer"), typeof(Delegates.glNamedFramebufferDrawBuffer));
				glNamedFramebufferDrawBuffers = (Delegates.glNamedFramebufferDrawBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferDrawBuffers"), typeof(Delegates.glNamedFramebufferDrawBuffers));
				glNamedFramebufferReadBuffer = (Delegates.glNamedFramebufferReadBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferReadBuffer"), typeof(Delegates.glNamedFramebufferReadBuffer));
				glInvalidateNamedFramebufferData = (Delegates.glInvalidateNamedFramebufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateNamedFramebufferData"), typeof(Delegates.glInvalidateNamedFramebufferData));
				glInvalidateNamedFramebufferSubData = (Delegates.glInvalidateNamedFramebufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateNamedFramebufferSubData"), typeof(Delegates.glInvalidateNamedFramebufferSubData));
				glClearNamedFramebufferiv = (Delegates.glClearNamedFramebufferiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferiv"), typeof(Delegates.glClearNamedFramebufferiv));
				glClearNamedFramebufferuiv = (Delegates.glClearNamedFramebufferuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferuiv"), typeof(Delegates.glClearNamedFramebufferuiv));
				glClearNamedFramebufferfv = (Delegates.glClearNamedFramebufferfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferfv"), typeof(Delegates.glClearNamedFramebufferfv));
				glClearNamedFramebufferfi = (Delegates.glClearNamedFramebufferfi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferfi"), typeof(Delegates.glClearNamedFramebufferfi));
				glBlitNamedFramebuffer = (Delegates.glBlitNamedFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlitNamedFramebuffer"), typeof(Delegates.glBlitNamedFramebuffer));
				glCheckNamedFramebufferStatus = (Delegates.glCheckNamedFramebufferStatus)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCheckNamedFramebufferStatus"), typeof(Delegates.glCheckNamedFramebufferStatus));
				glGetNamedFramebufferParameteriv = (Delegates.glGetNamedFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedFramebufferParameteriv"), typeof(Delegates.glGetNamedFramebufferParameteriv));
				glGetNamedFramebufferAttachmentParameteriv = (Delegates.glGetNamedFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedFramebufferAttachmentParameteriv"), typeof(Delegates.glGetNamedFramebufferAttachmentParameteriv));
				glCreateRenderbuffers = (Delegates.glCreateRenderbuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateRenderbuffers"), typeof(Delegates.glCreateRenderbuffers));
				glNamedRenderbufferStorage = (Delegates.glNamedRenderbufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedRenderbufferStorage"), typeof(Delegates.glNamedRenderbufferStorage));
				glNamedRenderbufferStorageMultisample = (Delegates.glNamedRenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedRenderbufferStorageMultisample"), typeof(Delegates.glNamedRenderbufferStorageMultisample));
				glGetNamedRenderbufferParameteriv = (Delegates.glGetNamedRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedRenderbufferParameteriv"), typeof(Delegates.glGetNamedRenderbufferParameteriv));
				glCreateTextures = (Delegates.glCreateTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateTextures"), typeof(Delegates.glCreateTextures));
				glTextureBuffer = (Delegates.glTextureBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureBuffer"), typeof(Delegates.glTextureBuffer));
				glTextureBufferRange = (Delegates.glTextureBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureBufferRange"), typeof(Delegates.glTextureBufferRange));
				glTextureStorage1D = (Delegates.glTextureStorage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage1D"), typeof(Delegates.glTextureStorage1D));
				glTextureStorage2D = (Delegates.glTextureStorage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage2D"), typeof(Delegates.glTextureStorage2D));
				glTextureStorage3D = (Delegates.glTextureStorage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage3D"), typeof(Delegates.glTextureStorage3D));
				glTextureStorage2DMultisample = (Delegates.glTextureStorage2DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage2DMultisample"), typeof(Delegates.glTextureStorage2DMultisample));
				glTextureStorage3DMultisample = (Delegates.glTextureStorage3DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage3DMultisample"), typeof(Delegates.glTextureStorage3DMultisample));
				glTextureSubImage1D = (Delegates.glTextureSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureSubImage1D"), typeof(Delegates.glTextureSubImage1D));
				glTextureSubImage2D = (Delegates.glTextureSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureSubImage2D"), typeof(Delegates.glTextureSubImage2D));
				glTextureSubImage3D = (Delegates.glTextureSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureSubImage3D"), typeof(Delegates.glTextureSubImage3D));
				glCompressedTextureSubImage1D = (Delegates.glCompressedTextureSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTextureSubImage1D"), typeof(Delegates.glCompressedTextureSubImage1D));
				glCompressedTextureSubImage2D = (Delegates.glCompressedTextureSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTextureSubImage2D"), typeof(Delegates.glCompressedTextureSubImage2D));
				glCompressedTextureSubImage3D = (Delegates.glCompressedTextureSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTextureSubImage3D"), typeof(Delegates.glCompressedTextureSubImage3D));
				glCopyTextureSubImage1D = (Delegates.glCopyTextureSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTextureSubImage1D"), typeof(Delegates.glCopyTextureSubImage1D));
				glCopyTextureSubImage2D = (Delegates.glCopyTextureSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTextureSubImage2D"), typeof(Delegates.glCopyTextureSubImage2D));
				glCopyTextureSubImage3D = (Delegates.glCopyTextureSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTextureSubImage3D"), typeof(Delegates.glCopyTextureSubImage3D));
				glTextureParameterf = (Delegates.glTextureParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterf"), typeof(Delegates.glTextureParameterf));
				glTextureParameterfv = (Delegates.glTextureParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterfv"), typeof(Delegates.glTextureParameterfv));
				glTextureParameteri = (Delegates.glTextureParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameteri"), typeof(Delegates.glTextureParameteri));
				glTextureParameterIiv = (Delegates.glTextureParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterIiv"), typeof(Delegates.glTextureParameterIiv));
				glTextureParameterIuiv = (Delegates.glTextureParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterIuiv"), typeof(Delegates.glTextureParameterIuiv));
				glTextureParameteriv = (Delegates.glTextureParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameteriv"), typeof(Delegates.glTextureParameteriv));
				glGenerateTextureMipmap = (Delegates.glGenerateTextureMipmap)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenerateTextureMipmap"), typeof(Delegates.glGenerateTextureMipmap));
				glBindTextureUnit = (Delegates.glBindTextureUnit)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTextureUnit"), typeof(Delegates.glBindTextureUnit));
				glGetTextureImage = (Delegates.glGetTextureImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureImage"), typeof(Delegates.glGetTextureImage));
				glGetCompressedTextureImage = (Delegates.glGetCompressedTextureImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetCompressedTextureImage"), typeof(Delegates.glGetCompressedTextureImage));
				glGetTextureLevelParameterfv = (Delegates.glGetTextureLevelParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureLevelParameterfv"), typeof(Delegates.glGetTextureLevelParameterfv));
				glGetTextureLevelParameteriv = (Delegates.glGetTextureLevelParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureLevelParameteriv"), typeof(Delegates.glGetTextureLevelParameteriv));
				glGetTextureParameterfv = (Delegates.glGetTextureParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameterfv"), typeof(Delegates.glGetTextureParameterfv));
				glGetTextureParameterIiv = (Delegates.glGetTextureParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameterIiv"), typeof(Delegates.glGetTextureParameterIiv));
				glGetTextureParameterIuiv = (Delegates.glGetTextureParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameterIuiv"), typeof(Delegates.glGetTextureParameterIuiv));
				glGetTextureParameteriv = (Delegates.glGetTextureParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameteriv"), typeof(Delegates.glGetTextureParameteriv));
				glCreateVertexArrays = (Delegates.glCreateVertexArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateVertexArrays"), typeof(Delegates.glCreateVertexArrays));
				glDisableVertexArrayAttrib = (Delegates.glDisableVertexArrayAttrib)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisableVertexArrayAttrib"), typeof(Delegates.glDisableVertexArrayAttrib));
				glEnableVertexArrayAttrib = (Delegates.glEnableVertexArrayAttrib)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnableVertexArrayAttrib"), typeof(Delegates.glEnableVertexArrayAttrib));
				glVertexArrayElementBuffer = (Delegates.glVertexArrayElementBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayElementBuffer"), typeof(Delegates.glVertexArrayElementBuffer));
				glVertexArrayVertexBuffer = (Delegates.glVertexArrayVertexBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayVertexBuffer"), typeof(Delegates.glVertexArrayVertexBuffer));
				glVertexArrayVertexBuffers = (Delegates.glVertexArrayVertexBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayVertexBuffers"), typeof(Delegates.glVertexArrayVertexBuffers));
				glVertexArrayAttribBinding = (Delegates.glVertexArrayAttribBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribBinding"), typeof(Delegates.glVertexArrayAttribBinding));
				glVertexArrayAttribFormat = (Delegates.glVertexArrayAttribFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribFormat"), typeof(Delegates.glVertexArrayAttribFormat));
				glVertexArrayAttribIFormat = (Delegates.glVertexArrayAttribIFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribIFormat"), typeof(Delegates.glVertexArrayAttribIFormat));
				glVertexArrayAttribLFormat = (Delegates.glVertexArrayAttribLFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribLFormat"), typeof(Delegates.glVertexArrayAttribLFormat));
				glVertexArrayBindingDivisor = (Delegates.glVertexArrayBindingDivisor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayBindingDivisor"), typeof(Delegates.glVertexArrayBindingDivisor));
				glGetVertexArrayiv = (Delegates.glGetVertexArrayiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexArrayiv"), typeof(Delegates.glGetVertexArrayiv));
				glGetVertexArrayIndexediv = (Delegates.glGetVertexArrayIndexediv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexArrayIndexediv"), typeof(Delegates.glGetVertexArrayIndexediv));
				glGetVertexArrayIndexed64iv = (Delegates.glGetVertexArrayIndexed64iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexArrayIndexed64iv"), typeof(Delegates.glGetVertexArrayIndexed64iv));
				glCreateSamplers = (Delegates.glCreateSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateSamplers"), typeof(Delegates.glCreateSamplers));
				glCreateProgramPipelines = (Delegates.glCreateProgramPipelines)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateProgramPipelines"), typeof(Delegates.glCreateProgramPipelines));
				glCreateQueries = (Delegates.glCreateQueries)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateQueries"), typeof(Delegates.glCreateQueries));
				glGetQueryBufferObjecti64v = (Delegates.glGetQueryBufferObjecti64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjecti64v"), typeof(Delegates.glGetQueryBufferObjecti64v));
				glGetQueryBufferObjectiv = (Delegates.glGetQueryBufferObjectiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjectiv"), typeof(Delegates.glGetQueryBufferObjectiv));
				glGetQueryBufferObjectui64v = (Delegates.glGetQueryBufferObjectui64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjectui64v"), typeof(Delegates.glGetQueryBufferObjectui64v));
				glGetQueryBufferObjectuiv = (Delegates.glGetQueryBufferObjectuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjectuiv"), typeof(Delegates.glGetQueryBufferObjectuiv));
				glMemoryBarrierByRegion = (Delegates.glMemoryBarrierByRegion)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMemoryBarrierByRegion"), typeof(Delegates.glMemoryBarrierByRegion));
				glGetTextureSubImage = (Delegates.glGetTextureSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureSubImage"), typeof(Delegates.glGetTextureSubImage));
				glGetCompressedTextureSubImage = (Delegates.glGetCompressedTextureSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetCompressedTextureSubImage"), typeof(Delegates.glGetCompressedTextureSubImage));
				glGetGraphicsResetStatus = (Delegates.glGetGraphicsResetStatus)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetGraphicsResetStatus"), typeof(Delegates.glGetGraphicsResetStatus));
				glGetnCompressedTexImage = (Delegates.glGetnCompressedTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnCompressedTexImage"), typeof(Delegates.glGetnCompressedTexImage));
				glGetnTexImage = (Delegates.glGetnTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnTexImage"), typeof(Delegates.glGetnTexImage));
				glGetnUniformdv = (Delegates.glGetnUniformdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformdv"), typeof(Delegates.glGetnUniformdv));
				glGetnUniformfv = (Delegates.glGetnUniformfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformfv"), typeof(Delegates.glGetnUniformfv));
				glGetnUniformiv = (Delegates.glGetnUniformiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformiv"), typeof(Delegates.glGetnUniformiv));
				glGetnUniformuiv = (Delegates.glGetnUniformuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformuiv"), typeof(Delegates.glGetnUniformuiv));
				glReadnPixels = (Delegates.glReadnPixels)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReadnPixels"), typeof(Delegates.glReadnPixels));
				glTextureBarrier = (Delegates.glTextureBarrier)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureBarrier"), typeof(Delegates.glTextureBarrier));
			}

			if (versionMajor > 0 || (versionMajor == 0 && versionMinor >= 0))
			{
				glUniformMatrix4fvByRef = (Delegates.glUniformMatrix4fvByRef)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4fv"), typeof(Delegates.glUniformMatrix4fvByRef));
			}
		}

	}
}
