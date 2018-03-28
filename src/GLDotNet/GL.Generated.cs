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

		private static Delegates.glActiveShaderProgram _glActiveShaderProgram;

		private static Delegates.glActiveTexture _glActiveTexture;

		private static Delegates.glAttachShader _glAttachShader;

		private static Delegates.glBeginConditionalRender _glBeginConditionalRender;

		private static Delegates.glBeginQuery _glBeginQuery;

		private static Delegates.glBeginQueryIndexed _glBeginQueryIndexed;

		private static Delegates.glBeginTransformFeedback _glBeginTransformFeedback;

		private static Delegates.glBindAttribLocation _glBindAttribLocation;

		private static Delegates.glBindBuffer _glBindBuffer;

		private static Delegates.glBindBufferBase _glBindBufferBase;

		private static Delegates.glBindBufferRange _glBindBufferRange;

		private static Delegates.glBindBuffersBase _glBindBuffersBase;

		private static Delegates.glBindBuffersRange _glBindBuffersRange;

		private static Delegates.glBindFragDataLocation _glBindFragDataLocation;

		private static Delegates.glBindFragDataLocationIndexed _glBindFragDataLocationIndexed;

		private static Delegates.glBindFramebuffer _glBindFramebuffer;

		private static Delegates.glBindImageTexture _glBindImageTexture;

		private static Delegates.glBindImageTextures _glBindImageTextures;

		private static Delegates.glBindProgramPipeline _glBindProgramPipeline;

		private static Delegates.glBindRenderbuffer _glBindRenderbuffer;

		private static Delegates.glBindSampler _glBindSampler;

		private static Delegates.glBindSamplers _glBindSamplers;

		private static Delegates.glBindTexture _glBindTexture;

		private static Delegates.glBindTextures _glBindTextures;

		private static Delegates.glBindTextureUnit _glBindTextureUnit;

		private static Delegates.glBindTransformFeedback _glBindTransformFeedback;

		private static Delegates.glBindVertexArray _glBindVertexArray;

		private static Delegates.glBindVertexBuffer _glBindVertexBuffer;

		private static Delegates.glBindVertexBuffers _glBindVertexBuffers;

		private static Delegates.glBlendColor _glBlendColor;

		private static Delegates.glBlendEquation _glBlendEquation;

		private static Delegates.glBlendEquationi _glBlendEquationi;

		private static Delegates.glBlendEquationSeparate _glBlendEquationSeparate;

		private static Delegates.glBlendEquationSeparatei _glBlendEquationSeparatei;

		private static Delegates.glBlendFunc _glBlendFunc;

		private static Delegates.glBlendFunci _glBlendFunci;

		private static Delegates.glBlendFuncSeparate _glBlendFuncSeparate;

		private static Delegates.glBlendFuncSeparatei _glBlendFuncSeparatei;

		private static Delegates.glBlitFramebuffer _glBlitFramebuffer;

		private static Delegates.glBlitNamedFramebuffer _glBlitNamedFramebuffer;

		private static Delegates.glBufferData _glBufferData;

		private static Delegates.glBufferStorage _glBufferStorage;

		private static Delegates.glBufferSubData _glBufferSubData;

		private static Delegates.glCheckFramebufferStatus _glCheckFramebufferStatus;

		private static Delegates.glCheckNamedFramebufferStatus _glCheckNamedFramebufferStatus;

		private static Delegates.glClampColor _glClampColor;

		private static Delegates.glClear _glClear;

		private static Delegates.glClearBufferData _glClearBufferData;

		private static Delegates.glClearBufferfi _glClearBufferfi;

		private static Delegates.glClearBufferfv _glClearBufferfv;

		private static Delegates.glClearBufferiv _glClearBufferiv;

		private static Delegates.glClearBufferSubData _glClearBufferSubData;

		private static Delegates.glClearBufferuiv _glClearBufferuiv;

		private static Delegates.glClearColor _glClearColor;

		private static Delegates.glClearDepth _glClearDepth;

		private static Delegates.glClearDepthf _glClearDepthf;

		private static Delegates.glClearNamedBufferData _glClearNamedBufferData;

		private static Delegates.glClearNamedBufferSubData _glClearNamedBufferSubData;

		private static Delegates.glClearNamedFramebufferfi _glClearNamedFramebufferfi;

		private static Delegates.glClearNamedFramebufferfv _glClearNamedFramebufferfv;

		private static Delegates.glClearNamedFramebufferiv _glClearNamedFramebufferiv;

		private static Delegates.glClearNamedFramebufferuiv _glClearNamedFramebufferuiv;

		private static Delegates.glClearStencil _glClearStencil;

		private static Delegates.glClearTexImage _glClearTexImage;

		private static Delegates.glClearTexSubImage _glClearTexSubImage;

		private static Delegates.glClientWaitSync _glClientWaitSync;

		private static Delegates.glClipControl _glClipControl;

		private static Delegates.glColorMask _glColorMask;

		private static Delegates.glColorMaski _glColorMaski;

		private static Delegates.glCompileShader _glCompileShader;

		private static Delegates.glCompressedTexImage1D _glCompressedTexImage1D;

		private static Delegates.glCompressedTexImage2D _glCompressedTexImage2D;

		private static Delegates.glCompressedTexImage3D _glCompressedTexImage3D;

		private static Delegates.glCompressedTexSubImage1D _glCompressedTexSubImage1D;

		private static Delegates.glCompressedTexSubImage2D _glCompressedTexSubImage2D;

		private static Delegates.glCompressedTexSubImage3D _glCompressedTexSubImage3D;

		private static Delegates.glCompressedTextureSubImage1D _glCompressedTextureSubImage1D;

		private static Delegates.glCompressedTextureSubImage2D _glCompressedTextureSubImage2D;

		private static Delegates.glCompressedTextureSubImage3D _glCompressedTextureSubImage3D;

		private static Delegates.glCopyBufferSubData _glCopyBufferSubData;

		private static Delegates.glCopyImageSubData _glCopyImageSubData;

		private static Delegates.glCopyNamedBufferSubData _glCopyNamedBufferSubData;

		private static Delegates.glCopyTexImage1D _glCopyTexImage1D;

		private static Delegates.glCopyTexImage2D _glCopyTexImage2D;

		private static Delegates.glCopyTexSubImage1D _glCopyTexSubImage1D;

		private static Delegates.glCopyTexSubImage2D _glCopyTexSubImage2D;

		private static Delegates.glCopyTexSubImage3D _glCopyTexSubImage3D;

		private static Delegates.glCopyTextureSubImage1D _glCopyTextureSubImage1D;

		private static Delegates.glCopyTextureSubImage2D _glCopyTextureSubImage2D;

		private static Delegates.glCopyTextureSubImage3D _glCopyTextureSubImage3D;

		private static Delegates.glCreateBuffers _glCreateBuffers;

		private static Delegates.glCreateFramebuffers _glCreateFramebuffers;

		private static Delegates.glCreateProgram _glCreateProgram;

		private static Delegates.glCreateProgramPipelines _glCreateProgramPipelines;

		private static Delegates.glCreateQueries _glCreateQueries;

		private static Delegates.glCreateRenderbuffers _glCreateRenderbuffers;

		private static Delegates.glCreateSamplers _glCreateSamplers;

		private static Delegates.glCreateShader _glCreateShader;

		private static Delegates.glCreateShaderProgramv _glCreateShaderProgramv;

		private static Delegates.glCreateTextures _glCreateTextures;

		private static Delegates.glCreateTransformFeedbacks _glCreateTransformFeedbacks;

		private static Delegates.glCreateVertexArrays _glCreateVertexArrays;

		private static Delegates.glCullFace _glCullFace;

		private static Delegates.glDebugMessageCallback _glDebugMessageCallback;

		private static Delegates.glDebugMessageControl _glDebugMessageControl;

		private static Delegates.glDebugMessageInsert _glDebugMessageInsert;

		private static Delegates.glDeleteBuffers _glDeleteBuffers;

		private static Delegates.glDeleteFramebuffers _glDeleteFramebuffers;

		private static Delegates.glDeleteProgram _glDeleteProgram;

		private static Delegates.glDeleteProgramPipelines _glDeleteProgramPipelines;

		private static Delegates.glDeleteQueries _glDeleteQueries;

		private static Delegates.glDeleteRenderbuffers _glDeleteRenderbuffers;

		private static Delegates.glDeleteSamplers _glDeleteSamplers;

		private static Delegates.glDeleteShader _glDeleteShader;

		private static Delegates.glDeleteSync _glDeleteSync;

		private static Delegates.glDeleteTextures _glDeleteTextures;

		private static Delegates.glDeleteTransformFeedbacks _glDeleteTransformFeedbacks;

		private static Delegates.glDeleteVertexArrays _glDeleteVertexArrays;

		private static Delegates.glDepthFunc _glDepthFunc;

		private static Delegates.glDepthMask _glDepthMask;

		private static Delegates.glDepthRange _glDepthRange;

		private static Delegates.glDepthRangeArrayv _glDepthRangeArrayv;

		private static Delegates.glDepthRangef _glDepthRangef;

		private static Delegates.glDepthRangeIndexed _glDepthRangeIndexed;

		private static Delegates.glDetachShader _glDetachShader;

		private static Delegates.glDisable _glDisable;

		private static Delegates.glDisablei _glDisablei;

		private static Delegates.glDisableVertexArrayAttrib _glDisableVertexArrayAttrib;

		private static Delegates.glDisableVertexAttribArray _glDisableVertexAttribArray;

		private static Delegates.glDispatchCompute _glDispatchCompute;

		private static Delegates.glDispatchComputeIndirect _glDispatchComputeIndirect;

		private static Delegates.glDrawArrays _glDrawArrays;

		private static Delegates.glDrawArraysIndirect _glDrawArraysIndirect;

		private static Delegates.glDrawArraysInstanced _glDrawArraysInstanced;

		private static Delegates.glDrawArraysInstancedBaseInstance _glDrawArraysInstancedBaseInstance;

		private static Delegates.glDrawBuffer _glDrawBuffer;

		private static Delegates.glDrawBuffers _glDrawBuffers;

		private static Delegates.glDrawElements _glDrawElements;

		private static Delegates.glDrawElementsBaseVertex _glDrawElementsBaseVertex;

		private static Delegates.glDrawElementsIndirect _glDrawElementsIndirect;

		private static Delegates.glDrawElementsInstanced _glDrawElementsInstanced;

		private static Delegates.glDrawElementsInstancedBaseInstance _glDrawElementsInstancedBaseInstance;

		private static Delegates.glDrawElementsInstancedBaseVertex _glDrawElementsInstancedBaseVertex;

		private static Delegates.glDrawElementsInstancedBaseVertexBaseInstance _glDrawElementsInstancedBaseVertexBaseInstance;

		private static Delegates.glDrawRangeElements _glDrawRangeElements;

		private static Delegates.glDrawRangeElementsBaseVertex _glDrawRangeElementsBaseVertex;

		private static Delegates.glDrawTransformFeedback _glDrawTransformFeedback;

		private static Delegates.glDrawTransformFeedbackInstanced _glDrawTransformFeedbackInstanced;

		private static Delegates.glDrawTransformFeedbackStream _glDrawTransformFeedbackStream;

		private static Delegates.glDrawTransformFeedbackStreamInstanced _glDrawTransformFeedbackStreamInstanced;

		private static Delegates.glEnable _glEnable;

		private static Delegates.glEnablei _glEnablei;

		private static Delegates.glEnableVertexArrayAttrib _glEnableVertexArrayAttrib;

		private static Delegates.glEnableVertexAttribArray _glEnableVertexAttribArray;

		private static Delegates.glEndConditionalRender _glEndConditionalRender;

		private static Delegates.glEndQuery _glEndQuery;

		private static Delegates.glEndQueryIndexed _glEndQueryIndexed;

		private static Delegates.glEndTransformFeedback _glEndTransformFeedback;

		private static Delegates.glFenceSync _glFenceSync;

		private static Delegates.glFinish _glFinish;

		private static Delegates.glFlush _glFlush;

		private static Delegates.glFlushMappedBufferRange _glFlushMappedBufferRange;

		private static Delegates.glFlushMappedNamedBufferRange _glFlushMappedNamedBufferRange;

		private static Delegates.glFramebufferParameteri _glFramebufferParameteri;

		private static Delegates.glFramebufferRenderbuffer _glFramebufferRenderbuffer;

		private static Delegates.glFramebufferTexture _glFramebufferTexture;

		private static Delegates.glFramebufferTexture1D _glFramebufferTexture1D;

		private static Delegates.glFramebufferTexture2D _glFramebufferTexture2D;

		private static Delegates.glFramebufferTexture3D _glFramebufferTexture3D;

		private static Delegates.glFramebufferTextureLayer _glFramebufferTextureLayer;

		private static Delegates.glFrontFace _glFrontFace;

		private static Delegates.glGenBuffers _glGenBuffers;

		private static Delegates.glGenerateMipmap _glGenerateMipmap;

		private static Delegates.glGenerateTextureMipmap _glGenerateTextureMipmap;

		private static Delegates.glGenFramebuffers _glGenFramebuffers;

		private static Delegates.glGenProgramPipelines _glGenProgramPipelines;

		private static Delegates.glGenQueries _glGenQueries;

		private static Delegates.glGenRenderbuffers _glGenRenderbuffers;

		private static Delegates.glGenSamplers _glGenSamplers;

		private static Delegates.glGenTextures _glGenTextures;

		private static Delegates.glGenTransformFeedbacks _glGenTransformFeedbacks;

		private static Delegates.glGenVertexArrays _glGenVertexArrays;

		private static Delegates.glGetActiveAtomicCounterBufferiv _glGetActiveAtomicCounterBufferiv;

		private static Delegates.glGetActiveAttrib _glGetActiveAttrib;

		private static Delegates.glGetActiveSubroutineName _glGetActiveSubroutineName;

		private static Delegates.glGetActiveSubroutineUniformiv _glGetActiveSubroutineUniformiv;

		private static Delegates.glGetActiveSubroutineUniformName _glGetActiveSubroutineUniformName;

		private static Delegates.glGetActiveUniform _glGetActiveUniform;

		private static Delegates.glGetActiveUniformBlockiv _glGetActiveUniformBlockiv;

		private static Delegates.glGetActiveUniformBlockName _glGetActiveUniformBlockName;

		private static Delegates.glGetActiveUniformName _glGetActiveUniformName;

		private static Delegates.glGetActiveUniformsiv _glGetActiveUniformsiv;

		private static Delegates.glGetAttachedShaders _glGetAttachedShaders;

		private static Delegates.glGetAttribLocation _glGetAttribLocation;

		private static Delegates.glGetBooleani_v _glGetBooleani_v;

		private static Delegates.glGetBooleanv _glGetBooleanv;

		private static Delegates.glGetBufferParameteri64v _glGetBufferParameteri64v;

		private static Delegates.glGetBufferParameteriv _glGetBufferParameteriv;

		private static Delegates.glGetBufferPointerv _glGetBufferPointerv;

		private static Delegates.glGetBufferSubData _glGetBufferSubData;

		private static Delegates.glGetCompressedTexImage _glGetCompressedTexImage;

		private static Delegates.glGetCompressedTextureImage _glGetCompressedTextureImage;

		private static Delegates.glGetCompressedTextureSubImage _glGetCompressedTextureSubImage;

		private static Delegates.glGetDebugMessageLog _glGetDebugMessageLog;

		private static Delegates.glGetDoublei_v _glGetDoublei_v;

		private static Delegates.glGetDoublev _glGetDoublev;

		private static Delegates.glGetError _glGetError;

		private static Delegates.glGetFloati_v _glGetFloati_v;

		private static Delegates.glGetFloatv _glGetFloatv;

		private static Delegates.glGetFragDataIndex _glGetFragDataIndex;

		private static Delegates.glGetFragDataLocation _glGetFragDataLocation;

		private static Delegates.glGetFramebufferAttachmentParameteriv _glGetFramebufferAttachmentParameteriv;

		private static Delegates.glGetFramebufferParameteriv _glGetFramebufferParameteriv;

		private static Delegates.glGetGraphicsResetStatus _glGetGraphicsResetStatus;

		private static Delegates.glGetInteger64i_v _glGetInteger64i_v;

		private static Delegates.glGetInteger64v _glGetInteger64v;

		private static Delegates.glGetIntegeri_v _glGetIntegeri_v;

		private static Delegates.glGetIntegerv _glGetIntegerv;

		private static Delegates.glGetInternalformati64v _glGetInternalformati64v;

		private static Delegates.glGetInternalformativ _glGetInternalformativ;

		private static Delegates.glGetMultisamplefv _glGetMultisamplefv;

		private static Delegates.glGetNamedBufferParameteri64v _glGetNamedBufferParameteri64v;

		private static Delegates.glGetNamedBufferParameteriv _glGetNamedBufferParameteriv;

		private static Delegates.glGetNamedBufferPointerv _glGetNamedBufferPointerv;

		private static Delegates.glGetNamedBufferSubData _glGetNamedBufferSubData;

		private static Delegates.glGetNamedFramebufferAttachmentParameteriv _glGetNamedFramebufferAttachmentParameteriv;

		private static Delegates.glGetNamedFramebufferParameteriv _glGetNamedFramebufferParameteriv;

		private static Delegates.glGetNamedRenderbufferParameteriv _glGetNamedRenderbufferParameteriv;

		private static Delegates.glGetnCompressedTexImage _glGetnCompressedTexImage;

		private static Delegates.glGetnTexImage _glGetnTexImage;

		private static Delegates.glGetnUniformdv _glGetnUniformdv;

		private static Delegates.glGetnUniformfv _glGetnUniformfv;

		private static Delegates.glGetnUniformiv _glGetnUniformiv;

		private static Delegates.glGetnUniformuiv _glGetnUniformuiv;

		private static Delegates.glGetObjectLabel _glGetObjectLabel;

		private static Delegates.glGetObjectPtrLabel _glGetObjectPtrLabel;

		private static Delegates.glGetPointerv _glGetPointerv;

		private static Delegates.glGetProgramBinary _glGetProgramBinary;

		private static Delegates.glGetProgramInfoLog _glGetProgramInfoLog;

		private static Delegates.glGetProgramInterfaceiv _glGetProgramInterfaceiv;

		private static Delegates.glGetProgramiv _glGetProgramiv;

		private static Delegates.glGetProgramPipelineInfoLog _glGetProgramPipelineInfoLog;

		private static Delegates.glGetProgramPipelineiv _glGetProgramPipelineiv;

		private static Delegates.glGetProgramResourceIndex _glGetProgramResourceIndex;

		private static Delegates.glGetProgramResourceiv _glGetProgramResourceiv;

		private static Delegates.glGetProgramResourceLocation _glGetProgramResourceLocation;

		private static Delegates.glGetProgramResourceLocationIndex _glGetProgramResourceLocationIndex;

		private static Delegates.glGetProgramResourceName _glGetProgramResourceName;

		private static Delegates.glGetProgramStageiv _glGetProgramStageiv;

		private static Delegates.glGetQueryBufferObjecti64v _glGetQueryBufferObjecti64v;

		private static Delegates.glGetQueryBufferObjectiv _glGetQueryBufferObjectiv;

		private static Delegates.glGetQueryBufferObjectui64v _glGetQueryBufferObjectui64v;

		private static Delegates.glGetQueryBufferObjectuiv _glGetQueryBufferObjectuiv;

		private static Delegates.glGetQueryIndexediv _glGetQueryIndexediv;

		private static Delegates.glGetQueryiv _glGetQueryiv;

		private static Delegates.glGetQueryObjecti64v _glGetQueryObjecti64v;

		private static Delegates.glGetQueryObjectiv _glGetQueryObjectiv;

		private static Delegates.glGetQueryObjectui64v _glGetQueryObjectui64v;

		private static Delegates.glGetQueryObjectuiv _glGetQueryObjectuiv;

		private static Delegates.glGetRenderbufferParameteriv _glGetRenderbufferParameteriv;

		private static Delegates.glGetSamplerParameterfv _glGetSamplerParameterfv;

		private static Delegates.glGetSamplerParameterIiv _glGetSamplerParameterIiv;

		private static Delegates.glGetSamplerParameterIuiv _glGetSamplerParameterIuiv;

		private static Delegates.glGetSamplerParameteriv _glGetSamplerParameteriv;

		private static Delegates.glGetShaderInfoLog _glGetShaderInfoLog;

		private static Delegates.glGetShaderiv _glGetShaderiv;

		private static Delegates.glGetShaderPrecisionFormat _glGetShaderPrecisionFormat;

		private static Delegates.glGetShaderSource _glGetShaderSource;

		private static Delegates.glGetString _glGetString;

		private static Delegates.glGetStringi _glGetStringi;

		private static Delegates.glGetSubroutineIndex _glGetSubroutineIndex;

		private static Delegates.glGetSubroutineUniformLocation _glGetSubroutineUniformLocation;

		private static Delegates.glGetSynciv _glGetSynciv;

		private static Delegates.glGetTexImage _glGetTexImage;

		private static Delegates.glGetTexLevelParameterfv _glGetTexLevelParameterfv;

		private static Delegates.glGetTexLevelParameteriv _glGetTexLevelParameteriv;

		private static Delegates.glGetTexParameterfv _glGetTexParameterfv;

		private static Delegates.glGetTexParameterIiv _glGetTexParameterIiv;

		private static Delegates.glGetTexParameterIuiv _glGetTexParameterIuiv;

		private static Delegates.glGetTexParameteriv _glGetTexParameteriv;

		private static Delegates.glGetTextureImage _glGetTextureImage;

		private static Delegates.glGetTextureLevelParameterfv _glGetTextureLevelParameterfv;

		private static Delegates.glGetTextureLevelParameteriv _glGetTextureLevelParameteriv;

		private static Delegates.glGetTextureParameterfv _glGetTextureParameterfv;

		private static Delegates.glGetTextureParameterIiv _glGetTextureParameterIiv;

		private static Delegates.glGetTextureParameterIuiv _glGetTextureParameterIuiv;

		private static Delegates.glGetTextureParameteriv _glGetTextureParameteriv;

		private static Delegates.glGetTextureSubImage _glGetTextureSubImage;

		private static Delegates.glGetTransformFeedbacki_v _glGetTransformFeedbacki_v;

		private static Delegates.glGetTransformFeedbacki64_v _glGetTransformFeedbacki64_v;

		private static Delegates.glGetTransformFeedbackiv _glGetTransformFeedbackiv;

		private static Delegates.glGetTransformFeedbackVarying _glGetTransformFeedbackVarying;

		private static Delegates.glGetUniformBlockIndex _glGetUniformBlockIndex;

		private static Delegates.glGetUniformdv _glGetUniformdv;

		private static Delegates.glGetUniformfv _glGetUniformfv;

		private static Delegates.glGetUniformIndices _glGetUniformIndices;

		private static Delegates.glGetUniformiv _glGetUniformiv;

		private static Delegates.glGetUniformLocation _glGetUniformLocation;

		private static Delegates.glGetUniformSubroutineuiv _glGetUniformSubroutineuiv;

		private static Delegates.glGetUniformuiv _glGetUniformuiv;

		private static Delegates.glGetVertexArrayIndexed64iv _glGetVertexArrayIndexed64iv;

		private static Delegates.glGetVertexArrayIndexediv _glGetVertexArrayIndexediv;

		private static Delegates.glGetVertexArrayiv _glGetVertexArrayiv;

		private static Delegates.glGetVertexAttribdv _glGetVertexAttribdv;

		private static Delegates.glGetVertexAttribfv _glGetVertexAttribfv;

		private static Delegates.glGetVertexAttribIiv _glGetVertexAttribIiv;

		private static Delegates.glGetVertexAttribIuiv _glGetVertexAttribIuiv;

		private static Delegates.glGetVertexAttribiv _glGetVertexAttribiv;

		private static Delegates.glGetVertexAttribLdv _glGetVertexAttribLdv;

		private static Delegates.glGetVertexAttribPointerv _glGetVertexAttribPointerv;

		private static Delegates.glHint _glHint;

		private static Delegates.glInvalidateBufferData _glInvalidateBufferData;

		private static Delegates.glInvalidateBufferSubData _glInvalidateBufferSubData;

		private static Delegates.glInvalidateFramebuffer _glInvalidateFramebuffer;

		private static Delegates.glInvalidateNamedFramebufferData _glInvalidateNamedFramebufferData;

		private static Delegates.glInvalidateNamedFramebufferSubData _glInvalidateNamedFramebufferSubData;

		private static Delegates.glInvalidateSubFramebuffer _glInvalidateSubFramebuffer;

		private static Delegates.glInvalidateTexImage _glInvalidateTexImage;

		private static Delegates.glInvalidateTexSubImage _glInvalidateTexSubImage;

		private static Delegates.glIsBuffer _glIsBuffer;

		private static Delegates.glIsEnabled _glIsEnabled;

		private static Delegates.glIsEnabledi _glIsEnabledi;

		private static Delegates.glIsFramebuffer _glIsFramebuffer;

		private static Delegates.glIsProgram _glIsProgram;

		private static Delegates.glIsProgramPipeline _glIsProgramPipeline;

		private static Delegates.glIsQuery _glIsQuery;

		private static Delegates.glIsRenderbuffer _glIsRenderbuffer;

		private static Delegates.glIsSampler _glIsSampler;

		private static Delegates.glIsShader _glIsShader;

		private static Delegates.glIsSync _glIsSync;

		private static Delegates.glIsTexture _glIsTexture;

		private static Delegates.glIsTransformFeedback _glIsTransformFeedback;

		private static Delegates.glIsVertexArray _glIsVertexArray;

		private static Delegates.glLineWidth _glLineWidth;

		private static Delegates.glLinkProgram _glLinkProgram;

		private static Delegates.glLogicOp _glLogicOp;

		private static Delegates.glMapBuffer _glMapBuffer;

		private static Delegates.glMapBufferRange _glMapBufferRange;

		private static Delegates.glMapNamedBuffer _glMapNamedBuffer;

		private static Delegates.glMapNamedBufferRange _glMapNamedBufferRange;

		private static Delegates.glMemoryBarrier _glMemoryBarrier;

		private static Delegates.glMemoryBarrierByRegion _glMemoryBarrierByRegion;

		private static Delegates.glMinSampleShading _glMinSampleShading;

		private static Delegates.glMultiDrawArrays _glMultiDrawArrays;

		private static Delegates.glMultiDrawArraysIndirect _glMultiDrawArraysIndirect;

		private static Delegates.glMultiDrawElements _glMultiDrawElements;

		private static Delegates.glMultiDrawElementsBaseVertex _glMultiDrawElementsBaseVertex;

		private static Delegates.glMultiDrawElementsIndirect _glMultiDrawElementsIndirect;

		private static Delegates.glNamedBufferData _glNamedBufferData;

		private static Delegates.glNamedBufferStorage _glNamedBufferStorage;

		private static Delegates.glNamedBufferSubData _glNamedBufferSubData;

		private static Delegates.glNamedFramebufferDrawBuffer _glNamedFramebufferDrawBuffer;

		private static Delegates.glNamedFramebufferDrawBuffers _glNamedFramebufferDrawBuffers;

		private static Delegates.glNamedFramebufferParameteri _glNamedFramebufferParameteri;

		private static Delegates.glNamedFramebufferReadBuffer _glNamedFramebufferReadBuffer;

		private static Delegates.glNamedFramebufferRenderbuffer _glNamedFramebufferRenderbuffer;

		private static Delegates.glNamedFramebufferTexture _glNamedFramebufferTexture;

		private static Delegates.glNamedFramebufferTextureLayer _glNamedFramebufferTextureLayer;

		private static Delegates.glNamedRenderbufferStorage _glNamedRenderbufferStorage;

		private static Delegates.glNamedRenderbufferStorageMultisample _glNamedRenderbufferStorageMultisample;

		private static Delegates.glObjectLabel _glObjectLabel;

		private static Delegates.glObjectPtrLabel _glObjectPtrLabel;

		private static Delegates.glPatchParameterfv _glPatchParameterfv;

		private static Delegates.glPatchParameteri _glPatchParameteri;

		private static Delegates.glPauseTransformFeedback _glPauseTransformFeedback;

		private static Delegates.glPixelStoref _glPixelStoref;

		private static Delegates.glPixelStorei _glPixelStorei;

		private static Delegates.glPointParameterf _glPointParameterf;

		private static Delegates.glPointParameterfv _glPointParameterfv;

		private static Delegates.glPointParameteri _glPointParameteri;

		private static Delegates.glPointParameteriv _glPointParameteriv;

		private static Delegates.glPointSize _glPointSize;

		private static Delegates.glPolygonMode _glPolygonMode;

		private static Delegates.glPolygonOffset _glPolygonOffset;

		private static Delegates.glPopDebugGroup _glPopDebugGroup;

		private static Delegates.glPrimitiveRestartIndex _glPrimitiveRestartIndex;

		private static Delegates.glProgramBinary _glProgramBinary;

		private static Delegates.glProgramParameteri _glProgramParameteri;

		private static Delegates.glProgramUniform1d _glProgramUniform1d;

		private static Delegates.glProgramUniform1dv _glProgramUniform1dv;

		private static Delegates.glProgramUniform1f _glProgramUniform1f;

		private static Delegates.glProgramUniform1fv _glProgramUniform1fv;

		private static Delegates.glProgramUniform1i _glProgramUniform1i;

		private static Delegates.glProgramUniform1iv _glProgramUniform1iv;

		private static Delegates.glProgramUniform1ui _glProgramUniform1ui;

		private static Delegates.glProgramUniform1uiv _glProgramUniform1uiv;

		private static Delegates.glProgramUniform2d _glProgramUniform2d;

		private static Delegates.glProgramUniform2dv _glProgramUniform2dv;

		private static Delegates.glProgramUniform2f _glProgramUniform2f;

		private static Delegates.glProgramUniform2fv _glProgramUniform2fv;

		private static Delegates.glProgramUniform2i _glProgramUniform2i;

		private static Delegates.glProgramUniform2iv _glProgramUniform2iv;

		private static Delegates.glProgramUniform2ui _glProgramUniform2ui;

		private static Delegates.glProgramUniform2uiv _glProgramUniform2uiv;

		private static Delegates.glProgramUniform3d _glProgramUniform3d;

		private static Delegates.glProgramUniform3dv _glProgramUniform3dv;

		private static Delegates.glProgramUniform3f _glProgramUniform3f;

		private static Delegates.glProgramUniform3fv _glProgramUniform3fv;

		private static Delegates.glProgramUniform3i _glProgramUniform3i;

		private static Delegates.glProgramUniform3iv _glProgramUniform3iv;

		private static Delegates.glProgramUniform3ui _glProgramUniform3ui;

		private static Delegates.glProgramUniform3uiv _glProgramUniform3uiv;

		private static Delegates.glProgramUniform4d _glProgramUniform4d;

		private static Delegates.glProgramUniform4dv _glProgramUniform4dv;

		private static Delegates.glProgramUniform4f _glProgramUniform4f;

		private static Delegates.glProgramUniform4fv _glProgramUniform4fv;

		private static Delegates.glProgramUniform4i _glProgramUniform4i;

		private static Delegates.glProgramUniform4iv _glProgramUniform4iv;

		private static Delegates.glProgramUniform4ui _glProgramUniform4ui;

		private static Delegates.glProgramUniform4uiv _glProgramUniform4uiv;

		private static Delegates.glProgramUniformMatrix2dv _glProgramUniformMatrix2dv;

		private static Delegates.glProgramUniformMatrix2fv _glProgramUniformMatrix2fv;

		private static Delegates.glProgramUniformMatrix2x3dv _glProgramUniformMatrix2x3dv;

		private static Delegates.glProgramUniformMatrix2x3fv _glProgramUniformMatrix2x3fv;

		private static Delegates.glProgramUniformMatrix2x4dv _glProgramUniformMatrix2x4dv;

		private static Delegates.glProgramUniformMatrix2x4fv _glProgramUniformMatrix2x4fv;

		private static Delegates.glProgramUniformMatrix3dv _glProgramUniformMatrix3dv;

		private static Delegates.glProgramUniformMatrix3fv _glProgramUniformMatrix3fv;

		private static Delegates.glProgramUniformMatrix3x2dv _glProgramUniformMatrix3x2dv;

		private static Delegates.glProgramUniformMatrix3x2fv _glProgramUniformMatrix3x2fv;

		private static Delegates.glProgramUniformMatrix3x4dv _glProgramUniformMatrix3x4dv;

		private static Delegates.glProgramUniformMatrix3x4fv _glProgramUniformMatrix3x4fv;

		private static Delegates.glProgramUniformMatrix4dv _glProgramUniformMatrix4dv;

		private static Delegates.glProgramUniformMatrix4fv _glProgramUniformMatrix4fv;

		private static Delegates.glProgramUniformMatrix4x2dv _glProgramUniformMatrix4x2dv;

		private static Delegates.glProgramUniformMatrix4x2fv _glProgramUniformMatrix4x2fv;

		private static Delegates.glProgramUniformMatrix4x3dv _glProgramUniformMatrix4x3dv;

		private static Delegates.glProgramUniformMatrix4x3fv _glProgramUniformMatrix4x3fv;

		private static Delegates.glProvokingVertex _glProvokingVertex;

		private static Delegates.glPushDebugGroup _glPushDebugGroup;

		private static Delegates.glQueryCounter _glQueryCounter;

		private static Delegates.glReadBuffer _glReadBuffer;

		private static Delegates.glReadnPixels _glReadnPixels;

		private static Delegates.glReadPixels _glReadPixels;

		private static Delegates.glReleaseShaderCompiler _glReleaseShaderCompiler;

		private static Delegates.glRenderbufferStorage _glRenderbufferStorage;

		private static Delegates.glRenderbufferStorageMultisample _glRenderbufferStorageMultisample;

		private static Delegates.glResumeTransformFeedback _glResumeTransformFeedback;

		private static Delegates.glSampleCoverage _glSampleCoverage;

		private static Delegates.glSampleMaski _glSampleMaski;

		private static Delegates.glSamplerParameterf _glSamplerParameterf;

		private static Delegates.glSamplerParameterfv _glSamplerParameterfv;

		private static Delegates.glSamplerParameteri _glSamplerParameteri;

		private static Delegates.glSamplerParameterIiv _glSamplerParameterIiv;

		private static Delegates.glSamplerParameterIuiv _glSamplerParameterIuiv;

		private static Delegates.glSamplerParameteriv _glSamplerParameteriv;

		private static Delegates.glScissor _glScissor;

		private static Delegates.glScissorArrayv _glScissorArrayv;

		private static Delegates.glScissorIndexed _glScissorIndexed;

		private static Delegates.glScissorIndexedv _glScissorIndexedv;

		private static Delegates.glShaderBinary _glShaderBinary;

		private static Delegates.glShaderSource _glShaderSource;

		private static Delegates.glShaderStorageBlockBinding _glShaderStorageBlockBinding;

		private static Delegates.glStencilFunc _glStencilFunc;

		private static Delegates.glStencilFuncSeparate _glStencilFuncSeparate;

		private static Delegates.glStencilMask _glStencilMask;

		private static Delegates.glStencilMaskSeparate _glStencilMaskSeparate;

		private static Delegates.glStencilOp _glStencilOp;

		private static Delegates.glStencilOpSeparate _glStencilOpSeparate;

		private static Delegates.glTexBuffer _glTexBuffer;

		private static Delegates.glTexBufferRange _glTexBufferRange;

		private static Delegates.glTexImage1D _glTexImage1D;

		private static Delegates.glTexImage2D _glTexImage2D;

		private static Delegates.glTexImage2DMultisample _glTexImage2DMultisample;

		private static Delegates.glTexImage3D _glTexImage3D;

		private static Delegates.glTexImage3DMultisample _glTexImage3DMultisample;

		private static Delegates.glTexParameterf _glTexParameterf;

		private static Delegates.glTexParameterfv _glTexParameterfv;

		private static Delegates.glTexParameteri _glTexParameteri;

		private static Delegates.glTexParameterIiv _glTexParameterIiv;

		private static Delegates.glTexParameterIuiv _glTexParameterIuiv;

		private static Delegates.glTexParameteriv _glTexParameteriv;

		private static Delegates.glTexStorage1D _glTexStorage1D;

		private static Delegates.glTexStorage2D _glTexStorage2D;

		private static Delegates.glTexStorage2DMultisample _glTexStorage2DMultisample;

		private static Delegates.glTexStorage3D _glTexStorage3D;

		private static Delegates.glTexStorage3DMultisample _glTexStorage3DMultisample;

		private static Delegates.glTexSubImage1D _glTexSubImage1D;

		private static Delegates.glTexSubImage2D _glTexSubImage2D;

		private static Delegates.glTexSubImage3D _glTexSubImage3D;

		private static Delegates.glTextureBarrier _glTextureBarrier;

		private static Delegates.glTextureBuffer _glTextureBuffer;

		private static Delegates.glTextureBufferRange _glTextureBufferRange;

		private static Delegates.glTextureParameterf _glTextureParameterf;

		private static Delegates.glTextureParameterfv _glTextureParameterfv;

		private static Delegates.glTextureParameteri _glTextureParameteri;

		private static Delegates.glTextureParameterIiv _glTextureParameterIiv;

		private static Delegates.glTextureParameterIuiv _glTextureParameterIuiv;

		private static Delegates.glTextureParameteriv _glTextureParameteriv;

		private static Delegates.glTextureStorage1D _glTextureStorage1D;

		private static Delegates.glTextureStorage2D _glTextureStorage2D;

		private static Delegates.glTextureStorage2DMultisample _glTextureStorage2DMultisample;

		private static Delegates.glTextureStorage3D _glTextureStorage3D;

		private static Delegates.glTextureStorage3DMultisample _glTextureStorage3DMultisample;

		private static Delegates.glTextureSubImage1D _glTextureSubImage1D;

		private static Delegates.glTextureSubImage2D _glTextureSubImage2D;

		private static Delegates.glTextureSubImage3D _glTextureSubImage3D;

		private static Delegates.glTextureView _glTextureView;

		private static Delegates.glTransformFeedbackBufferBase _glTransformFeedbackBufferBase;

		private static Delegates.glTransformFeedbackBufferRange _glTransformFeedbackBufferRange;

		private static Delegates.glTransformFeedbackVaryings _glTransformFeedbackVaryings;

		private static Delegates.glUniform1d _glUniform1d;

		private static Delegates.glUniform1dv _glUniform1dv;

		private static Delegates.glUniform1f _glUniform1f;

		private static Delegates.glUniform1fv _glUniform1fv;

		private static Delegates.glUniform1i _glUniform1i;

		private static Delegates.glUniform1iv _glUniform1iv;

		private static Delegates.glUniform1ui _glUniform1ui;

		private static Delegates.glUniform1uiv _glUniform1uiv;

		private static Delegates.glUniform2d _glUniform2d;

		private static Delegates.glUniform2dv _glUniform2dv;

		private static Delegates.glUniform2f _glUniform2f;

		private static Delegates.glUniform2fv _glUniform2fv;

		private static Delegates.glUniform2i _glUniform2i;

		private static Delegates.glUniform2iv _glUniform2iv;

		private static Delegates.glUniform2ui _glUniform2ui;

		private static Delegates.glUniform2uiv _glUniform2uiv;

		private static Delegates.glUniform3d _glUniform3d;

		private static Delegates.glUniform3dv _glUniform3dv;

		private static Delegates.glUniform3f _glUniform3f;

		private static Delegates.glUniform3fv _glUniform3fv;

		private static Delegates.glUniform3i _glUniform3i;

		private static Delegates.glUniform3iv _glUniform3iv;

		private static Delegates.glUniform3ui _glUniform3ui;

		private static Delegates.glUniform3uiv _glUniform3uiv;

		private static Delegates.glUniform4d _glUniform4d;

		private static Delegates.glUniform4dv _glUniform4dv;

		private static Delegates.glUniform4f _glUniform4f;

		private static Delegates.glUniform4fv _glUniform4fv;

		private static Delegates.glUniform4i _glUniform4i;

		private static Delegates.glUniform4iv _glUniform4iv;

		private static Delegates.glUniform4ui _glUniform4ui;

		private static Delegates.glUniform4uiv _glUniform4uiv;

		private static Delegates.glUniformBlockBinding _glUniformBlockBinding;

		private static Delegates.glUniformMatrix2dv _glUniformMatrix2dv;

		private static Delegates.glUniformMatrix2fv _glUniformMatrix2fv;

		private static Delegates.glUniformMatrix2x3dv _glUniformMatrix2x3dv;

		private static Delegates.glUniformMatrix2x3fv _glUniformMatrix2x3fv;

		private static Delegates.glUniformMatrix2x4dv _glUniformMatrix2x4dv;

		private static Delegates.glUniformMatrix2x4fv _glUniformMatrix2x4fv;

		private static Delegates.glUniformMatrix3dv _glUniformMatrix3dv;

		private static Delegates.glUniformMatrix3fv _glUniformMatrix3fv;

		private static Delegates.glUniformMatrix3x2dv _glUniformMatrix3x2dv;

		private static Delegates.glUniformMatrix3x2fv _glUniformMatrix3x2fv;

		private static Delegates.glUniformMatrix3x4dv _glUniformMatrix3x4dv;

		private static Delegates.glUniformMatrix3x4fv _glUniformMatrix3x4fv;

		private static Delegates.glUniformMatrix4dv _glUniformMatrix4dv;

		private static Delegates.glUniformMatrix4fv _glUniformMatrix4fv;

		private static Delegates.glUniformMatrix4fvByRef _glUniformMatrix4fvByRef;

		private static Delegates.glUniformMatrix4x2dv _glUniformMatrix4x2dv;

		private static Delegates.glUniformMatrix4x2fv _glUniformMatrix4x2fv;

		private static Delegates.glUniformMatrix4x3dv _glUniformMatrix4x3dv;

		private static Delegates.glUniformMatrix4x3fv _glUniformMatrix4x3fv;

		private static Delegates.glUniformSubroutinesuiv _glUniformSubroutinesuiv;

		private static Delegates.glUnmapBuffer _glUnmapBuffer;

		private static Delegates.glUnmapNamedBuffer _glUnmapNamedBuffer;

		private static Delegates.glUseProgram _glUseProgram;

		private static Delegates.glUseProgramStages _glUseProgramStages;

		private static Delegates.glValidateProgram _glValidateProgram;

		private static Delegates.glValidateProgramPipeline _glValidateProgramPipeline;

		private static Delegates.glVertexArrayAttribBinding _glVertexArrayAttribBinding;

		private static Delegates.glVertexArrayAttribFormat _glVertexArrayAttribFormat;

		private static Delegates.glVertexArrayAttribIFormat _glVertexArrayAttribIFormat;

		private static Delegates.glVertexArrayAttribLFormat _glVertexArrayAttribLFormat;

		private static Delegates.glVertexArrayBindingDivisor _glVertexArrayBindingDivisor;

		private static Delegates.glVertexArrayElementBuffer _glVertexArrayElementBuffer;

		private static Delegates.glVertexArrayVertexBuffer _glVertexArrayVertexBuffer;

		private static Delegates.glVertexArrayVertexBuffers _glVertexArrayVertexBuffers;

		private static Delegates.glVertexAttrib1d _glVertexAttrib1d;

		private static Delegates.glVertexAttrib1dv _glVertexAttrib1dv;

		private static Delegates.glVertexAttrib1f _glVertexAttrib1f;

		private static Delegates.glVertexAttrib1fv _glVertexAttrib1fv;

		private static Delegates.glVertexAttrib1s _glVertexAttrib1s;

		private static Delegates.glVertexAttrib1sv _glVertexAttrib1sv;

		private static Delegates.glVertexAttrib2d _glVertexAttrib2d;

		private static Delegates.glVertexAttrib2dv _glVertexAttrib2dv;

		private static Delegates.glVertexAttrib2f _glVertexAttrib2f;

		private static Delegates.glVertexAttrib2fv _glVertexAttrib2fv;

		private static Delegates.glVertexAttrib2s _glVertexAttrib2s;

		private static Delegates.glVertexAttrib2sv _glVertexAttrib2sv;

		private static Delegates.glVertexAttrib3d _glVertexAttrib3d;

		private static Delegates.glVertexAttrib3dv _glVertexAttrib3dv;

		private static Delegates.glVertexAttrib3f _glVertexAttrib3f;

		private static Delegates.glVertexAttrib3fv _glVertexAttrib3fv;

		private static Delegates.glVertexAttrib3s _glVertexAttrib3s;

		private static Delegates.glVertexAttrib3sv _glVertexAttrib3sv;

		private static Delegates.glVertexAttrib4bv _glVertexAttrib4bv;

		private static Delegates.glVertexAttrib4d _glVertexAttrib4d;

		private static Delegates.glVertexAttrib4dv _glVertexAttrib4dv;

		private static Delegates.glVertexAttrib4f _glVertexAttrib4f;

		private static Delegates.glVertexAttrib4fv _glVertexAttrib4fv;

		private static Delegates.glVertexAttrib4iv _glVertexAttrib4iv;

		private static Delegates.glVertexAttrib4Nbv _glVertexAttrib4Nbv;

		private static Delegates.glVertexAttrib4Niv _glVertexAttrib4Niv;

		private static Delegates.glVertexAttrib4Nsv _glVertexAttrib4Nsv;

		private static Delegates.glVertexAttrib4Nub _glVertexAttrib4Nub;

		private static Delegates.glVertexAttrib4Nubv _glVertexAttrib4Nubv;

		private static Delegates.glVertexAttrib4Nuiv _glVertexAttrib4Nuiv;

		private static Delegates.glVertexAttrib4Nusv _glVertexAttrib4Nusv;

		private static Delegates.glVertexAttrib4s _glVertexAttrib4s;

		private static Delegates.glVertexAttrib4sv _glVertexAttrib4sv;

		private static Delegates.glVertexAttrib4ubv _glVertexAttrib4ubv;

		private static Delegates.glVertexAttrib4uiv _glVertexAttrib4uiv;

		private static Delegates.glVertexAttrib4usv _glVertexAttrib4usv;

		private static Delegates.glVertexAttribBinding _glVertexAttribBinding;

		private static Delegates.glVertexAttribDivisor _glVertexAttribDivisor;

		private static Delegates.glVertexAttribFormat _glVertexAttribFormat;

		private static Delegates.glVertexAttribI1i _glVertexAttribI1i;

		private static Delegates.glVertexAttribI1iv _glVertexAttribI1iv;

		private static Delegates.glVertexAttribI1ui _glVertexAttribI1ui;

		private static Delegates.glVertexAttribI1uiv _glVertexAttribI1uiv;

		private static Delegates.glVertexAttribI2i _glVertexAttribI2i;

		private static Delegates.glVertexAttribI2iv _glVertexAttribI2iv;

		private static Delegates.glVertexAttribI2ui _glVertexAttribI2ui;

		private static Delegates.glVertexAttribI2uiv _glVertexAttribI2uiv;

		private static Delegates.glVertexAttribI3i _glVertexAttribI3i;

		private static Delegates.glVertexAttribI3iv _glVertexAttribI3iv;

		private static Delegates.glVertexAttribI3ui _glVertexAttribI3ui;

		private static Delegates.glVertexAttribI3uiv _glVertexAttribI3uiv;

		private static Delegates.glVertexAttribI4bv _glVertexAttribI4bv;

		private static Delegates.glVertexAttribI4i _glVertexAttribI4i;

		private static Delegates.glVertexAttribI4iv _glVertexAttribI4iv;

		private static Delegates.glVertexAttribI4sv _glVertexAttribI4sv;

		private static Delegates.glVertexAttribI4ubv _glVertexAttribI4ubv;

		private static Delegates.glVertexAttribI4ui _glVertexAttribI4ui;

		private static Delegates.glVertexAttribI4uiv _glVertexAttribI4uiv;

		private static Delegates.glVertexAttribI4usv _glVertexAttribI4usv;

		private static Delegates.glVertexAttribIFormat _glVertexAttribIFormat;

		private static Delegates.glVertexAttribIPointer _glVertexAttribIPointer;

		private static Delegates.glVertexAttribL1d _glVertexAttribL1d;

		private static Delegates.glVertexAttribL1dv _glVertexAttribL1dv;

		private static Delegates.glVertexAttribL2d _glVertexAttribL2d;

		private static Delegates.glVertexAttribL2dv _glVertexAttribL2dv;

		private static Delegates.glVertexAttribL3d _glVertexAttribL3d;

		private static Delegates.glVertexAttribL3dv _glVertexAttribL3dv;

		private static Delegates.glVertexAttribL4d _glVertexAttribL4d;

		private static Delegates.glVertexAttribL4dv _glVertexAttribL4dv;

		private static Delegates.glVertexAttribLFormat _glVertexAttribLFormat;

		private static Delegates.glVertexAttribLPointer _glVertexAttribLPointer;

		private static Delegates.glVertexAttribP1ui _glVertexAttribP1ui;

		private static Delegates.glVertexAttribP1uiv _glVertexAttribP1uiv;

		private static Delegates.glVertexAttribP2ui _glVertexAttribP2ui;

		private static Delegates.glVertexAttribP2uiv _glVertexAttribP2uiv;

		private static Delegates.glVertexAttribP3ui _glVertexAttribP3ui;

		private static Delegates.glVertexAttribP3uiv _glVertexAttribP3uiv;

		private static Delegates.glVertexAttribP4ui _glVertexAttribP4ui;

		private static Delegates.glVertexAttribP4uiv _glVertexAttribP4uiv;

		private static Delegates.glVertexAttribPointer _glVertexAttribPointer;

		private static Delegates.glVertexBindingDivisor _glVertexBindingDivisor;

		private static Delegates.glViewport _glViewport;

		private static Delegates.glViewportArrayv _glViewportArrayv;

		private static Delegates.glViewportIndexedf _glViewportIndexedf;

		private static Delegates.glViewportIndexedfv _glViewportIndexedfv;

		private static Delegates.glWaitSync _glWaitSync;

		public static void glInit(Func<string, IntPtr> getProcAddress, int versionMajor, int versionMinor)
		{
			if (getProcAddress == null) throw new ArgumentNullException(nameof(getProcAddress));

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 0))
			{
				_glCullFace = (Delegates.glCullFace)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCullFace"), typeof(Delegates.glCullFace));
				_glFrontFace = (Delegates.glFrontFace)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFrontFace"), typeof(Delegates.glFrontFace));
				_glHint = (Delegates.glHint)Marshal.GetDelegateForFunctionPointer(getProcAddress("glHint"), typeof(Delegates.glHint));
				_glLineWidth = (Delegates.glLineWidth)Marshal.GetDelegateForFunctionPointer(getProcAddress("glLineWidth"), typeof(Delegates.glLineWidth));
				_glPointSize = (Delegates.glPointSize)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointSize"), typeof(Delegates.glPointSize));
				_glPolygonMode = (Delegates.glPolygonMode)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPolygonMode"), typeof(Delegates.glPolygonMode));
				_glScissor = (Delegates.glScissor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissor"), typeof(Delegates.glScissor));
				_glTexParameterf = (Delegates.glTexParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterf"), typeof(Delegates.glTexParameterf));
				_glTexParameterfv = (Delegates.glTexParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterfv"), typeof(Delegates.glTexParameterfv));
				_glTexParameteri = (Delegates.glTexParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameteri"), typeof(Delegates.glTexParameteri));
				_glTexParameteriv = (Delegates.glTexParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameteriv"), typeof(Delegates.glTexParameteriv));
				_glTexImage1D = (Delegates.glTexImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage1D"), typeof(Delegates.glTexImage1D));
				_glTexImage2D = (Delegates.glTexImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage2D"), typeof(Delegates.glTexImage2D));
				_glDrawBuffer = (Delegates.glDrawBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawBuffer"), typeof(Delegates.glDrawBuffer));
				_glClear = (Delegates.glClear)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClear"), typeof(Delegates.glClear));
				_glClearColor = (Delegates.glClearColor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearColor"), typeof(Delegates.glClearColor));
				_glClearStencil = (Delegates.glClearStencil)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearStencil"), typeof(Delegates.glClearStencil));
				_glClearDepth = (Delegates.glClearDepth)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearDepth"), typeof(Delegates.glClearDepth));
				_glStencilMask = (Delegates.glStencilMask)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilMask"), typeof(Delegates.glStencilMask));
				_glColorMask = (Delegates.glColorMask)Marshal.GetDelegateForFunctionPointer(getProcAddress("glColorMask"), typeof(Delegates.glColorMask));
				_glDepthMask = (Delegates.glDepthMask)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthMask"), typeof(Delegates.glDepthMask));
				_glDisable = (Delegates.glDisable)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisable"), typeof(Delegates.glDisable));
				_glEnable = (Delegates.glEnable)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnable"), typeof(Delegates.glEnable));
				_glFinish = (Delegates.glFinish)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFinish"), typeof(Delegates.glFinish));
				_glFlush = (Delegates.glFlush)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFlush"), typeof(Delegates.glFlush));
				_glBlendFunc = (Delegates.glBlendFunc)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFunc"), typeof(Delegates.glBlendFunc));
				_glLogicOp = (Delegates.glLogicOp)Marshal.GetDelegateForFunctionPointer(getProcAddress("glLogicOp"), typeof(Delegates.glLogicOp));
				_glStencilFunc = (Delegates.glStencilFunc)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilFunc"), typeof(Delegates.glStencilFunc));
				_glStencilOp = (Delegates.glStencilOp)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilOp"), typeof(Delegates.glStencilOp));
				_glDepthFunc = (Delegates.glDepthFunc)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthFunc"), typeof(Delegates.glDepthFunc));
				_glPixelStoref = (Delegates.glPixelStoref)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPixelStoref"), typeof(Delegates.glPixelStoref));
				_glPixelStorei = (Delegates.glPixelStorei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPixelStorei"), typeof(Delegates.glPixelStorei));
				_glReadBuffer = (Delegates.glReadBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReadBuffer"), typeof(Delegates.glReadBuffer));
				_glReadPixels = (Delegates.glReadPixels)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReadPixels"), typeof(Delegates.glReadPixels));
				_glGetBooleanv = (Delegates.glGetBooleanv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBooleanv"), typeof(Delegates.glGetBooleanv));
				_glGetDoublev = (Delegates.glGetDoublev)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetDoublev"), typeof(Delegates.glGetDoublev));
				_glGetError = (Delegates.glGetError)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetError"), typeof(Delegates.glGetError));
				_glGetFloatv = (Delegates.glGetFloatv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFloatv"), typeof(Delegates.glGetFloatv));
				_glGetIntegerv = (Delegates.glGetIntegerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetIntegerv"), typeof(Delegates.glGetIntegerv));
				_glGetString = (Delegates.glGetString)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetString"), typeof(Delegates.glGetString));
				_glGetTexImage = (Delegates.glGetTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexImage"), typeof(Delegates.glGetTexImage));
				_glGetTexParameterfv = (Delegates.glGetTexParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameterfv"), typeof(Delegates.glGetTexParameterfv));
				_glGetTexParameteriv = (Delegates.glGetTexParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameteriv"), typeof(Delegates.glGetTexParameteriv));
				_glGetTexLevelParameterfv = (Delegates.glGetTexLevelParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexLevelParameterfv"), typeof(Delegates.glGetTexLevelParameterfv));
				_glGetTexLevelParameteriv = (Delegates.glGetTexLevelParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexLevelParameteriv"), typeof(Delegates.glGetTexLevelParameteriv));
				_glIsEnabled = (Delegates.glIsEnabled)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsEnabled"), typeof(Delegates.glIsEnabled));
				_glDepthRange = (Delegates.glDepthRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRange"), typeof(Delegates.glDepthRange));
				_glViewport = (Delegates.glViewport)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewport"), typeof(Delegates.glViewport));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 1))
			{
				_glDrawArrays = (Delegates.glDrawArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArrays"), typeof(Delegates.glDrawArrays));
				_glDrawElements = (Delegates.glDrawElements)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElements"), typeof(Delegates.glDrawElements));
				_glGetPointerv = (Delegates.glGetPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetPointerv"), typeof(Delegates.glGetPointerv));
				_glPolygonOffset = (Delegates.glPolygonOffset)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPolygonOffset"), typeof(Delegates.glPolygonOffset));
				_glCopyTexImage1D = (Delegates.glCopyTexImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexImage1D"), typeof(Delegates.glCopyTexImage1D));
				_glCopyTexImage2D = (Delegates.glCopyTexImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexImage2D"), typeof(Delegates.glCopyTexImage2D));
				_glCopyTexSubImage1D = (Delegates.glCopyTexSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexSubImage1D"), typeof(Delegates.glCopyTexSubImage1D));
				_glCopyTexSubImage2D = (Delegates.glCopyTexSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexSubImage2D"), typeof(Delegates.glCopyTexSubImage2D));
				_glTexSubImage1D = (Delegates.glTexSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexSubImage1D"), typeof(Delegates.glTexSubImage1D));
				_glTexSubImage2D = (Delegates.glTexSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexSubImage2D"), typeof(Delegates.glTexSubImage2D));
				_glBindTexture = (Delegates.glBindTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTexture"), typeof(Delegates.glBindTexture));
				_glDeleteTextures = (Delegates.glDeleteTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteTextures"), typeof(Delegates.glDeleteTextures));
				_glGenTextures = (Delegates.glGenTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenTextures"), typeof(Delegates.glGenTextures));
				_glIsTexture = (Delegates.glIsTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsTexture"), typeof(Delegates.glIsTexture));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 2))
			{
				_glDrawRangeElements = (Delegates.glDrawRangeElements)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawRangeElements"), typeof(Delegates.glDrawRangeElements));
				_glTexImage3D = (Delegates.glTexImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage3D"), typeof(Delegates.glTexImage3D));
				_glTexSubImage3D = (Delegates.glTexSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexSubImage3D"), typeof(Delegates.glTexSubImage3D));
				_glCopyTexSubImage3D = (Delegates.glCopyTexSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexSubImage3D"), typeof(Delegates.glCopyTexSubImage3D));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 3))
			{
				_glActiveTexture = (Delegates.glActiveTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glActiveTexture"), typeof(Delegates.glActiveTexture));
				_glSampleCoverage = (Delegates.glSampleCoverage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSampleCoverage"), typeof(Delegates.glSampleCoverage));
				_glCompressedTexImage3D = (Delegates.glCompressedTexImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexImage3D"), typeof(Delegates.glCompressedTexImage3D));
				_glCompressedTexImage2D = (Delegates.glCompressedTexImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexImage2D"), typeof(Delegates.glCompressedTexImage2D));
				_glCompressedTexImage1D = (Delegates.glCompressedTexImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexImage1D"), typeof(Delegates.glCompressedTexImage1D));
				_glCompressedTexSubImage3D = (Delegates.glCompressedTexSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexSubImage3D"), typeof(Delegates.glCompressedTexSubImage3D));
				_glCompressedTexSubImage2D = (Delegates.glCompressedTexSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexSubImage2D"), typeof(Delegates.glCompressedTexSubImage2D));
				_glCompressedTexSubImage1D = (Delegates.glCompressedTexSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexSubImage1D"), typeof(Delegates.glCompressedTexSubImage1D));
				_glGetCompressedTexImage = (Delegates.glGetCompressedTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetCompressedTexImage"), typeof(Delegates.glGetCompressedTexImage));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 4))
			{
				_glBlendFuncSeparate = (Delegates.glBlendFuncSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFuncSeparate"), typeof(Delegates.glBlendFuncSeparate));
				_glMultiDrawArrays = (Delegates.glMultiDrawArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawArrays"), typeof(Delegates.glMultiDrawArrays));
				_glMultiDrawElements = (Delegates.glMultiDrawElements)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawElements"), typeof(Delegates.glMultiDrawElements));
				_glPointParameterf = (Delegates.glPointParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameterf"), typeof(Delegates.glPointParameterf));
				_glPointParameterfv = (Delegates.glPointParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameterfv"), typeof(Delegates.glPointParameterfv));
				_glPointParameteri = (Delegates.glPointParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameteri"), typeof(Delegates.glPointParameteri));
				_glPointParameteriv = (Delegates.glPointParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameteriv"), typeof(Delegates.glPointParameteriv));
				_glBlendColor = (Delegates.glBlendColor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendColor"), typeof(Delegates.glBlendColor));
				_glBlendEquation = (Delegates.glBlendEquation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquation"), typeof(Delegates.glBlendEquation));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 5))
			{
				_glGenQueries = (Delegates.glGenQueries)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenQueries"), typeof(Delegates.glGenQueries));
				_glDeleteQueries = (Delegates.glDeleteQueries)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteQueries"), typeof(Delegates.glDeleteQueries));
				_glIsQuery = (Delegates.glIsQuery)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsQuery"), typeof(Delegates.glIsQuery));
				_glBeginQuery = (Delegates.glBeginQuery)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginQuery"), typeof(Delegates.glBeginQuery));
				_glEndQuery = (Delegates.glEndQuery)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndQuery"), typeof(Delegates.glEndQuery));
				_glGetQueryiv = (Delegates.glGetQueryiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryiv"), typeof(Delegates.glGetQueryiv));
				_glGetQueryObjectiv = (Delegates.glGetQueryObjectiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjectiv"), typeof(Delegates.glGetQueryObjectiv));
				_glGetQueryObjectuiv = (Delegates.glGetQueryObjectuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjectuiv"), typeof(Delegates.glGetQueryObjectuiv));
				_glBindBuffer = (Delegates.glBindBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBuffer"), typeof(Delegates.glBindBuffer));
				_glDeleteBuffers = (Delegates.glDeleteBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteBuffers"), typeof(Delegates.glDeleteBuffers));
				_glGenBuffers = (Delegates.glGenBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenBuffers"), typeof(Delegates.glGenBuffers));
				_glIsBuffer = (Delegates.glIsBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsBuffer"), typeof(Delegates.glIsBuffer));
				_glBufferData = (Delegates.glBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBufferData"), typeof(Delegates.glBufferData));
				_glBufferSubData = (Delegates.glBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBufferSubData"), typeof(Delegates.glBufferSubData));
				_glGetBufferSubData = (Delegates.glGetBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferSubData"), typeof(Delegates.glGetBufferSubData));
				_glMapBuffer = (Delegates.glMapBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapBuffer"), typeof(Delegates.glMapBuffer));
				_glUnmapBuffer = (Delegates.glUnmapBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUnmapBuffer"), typeof(Delegates.glUnmapBuffer));
				_glGetBufferParameteriv = (Delegates.glGetBufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferParameteriv"), typeof(Delegates.glGetBufferParameteriv));
				_glGetBufferPointerv = (Delegates.glGetBufferPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferPointerv"), typeof(Delegates.glGetBufferPointerv));
			}

			if (versionMajor > 2 || (versionMajor == 2 && versionMinor >= 0))
			{
				_glBlendEquationSeparate = (Delegates.glBlendEquationSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquationSeparate"), typeof(Delegates.glBlendEquationSeparate));
				_glDrawBuffers = (Delegates.glDrawBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawBuffers"), typeof(Delegates.glDrawBuffers));
				_glStencilOpSeparate = (Delegates.glStencilOpSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilOpSeparate"), typeof(Delegates.glStencilOpSeparate));
				_glStencilFuncSeparate = (Delegates.glStencilFuncSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilFuncSeparate"), typeof(Delegates.glStencilFuncSeparate));
				_glStencilMaskSeparate = (Delegates.glStencilMaskSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilMaskSeparate"), typeof(Delegates.glStencilMaskSeparate));
				_glAttachShader = (Delegates.glAttachShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glAttachShader"), typeof(Delegates.glAttachShader));
				_glBindAttribLocation = (Delegates.glBindAttribLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindAttribLocation"), typeof(Delegates.glBindAttribLocation));
				_glCompileShader = (Delegates.glCompileShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompileShader"), typeof(Delegates.glCompileShader));
				_glCreateProgram = (Delegates.glCreateProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateProgram"), typeof(Delegates.glCreateProgram));
				_glCreateShader = (Delegates.glCreateShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateShader"), typeof(Delegates.glCreateShader));
				_glDeleteProgram = (Delegates.glDeleteProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteProgram"), typeof(Delegates.glDeleteProgram));
				_glDeleteShader = (Delegates.glDeleteShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteShader"), typeof(Delegates.glDeleteShader));
				_glDetachShader = (Delegates.glDetachShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDetachShader"), typeof(Delegates.glDetachShader));
				_glDisableVertexAttribArray = (Delegates.glDisableVertexAttribArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisableVertexAttribArray"), typeof(Delegates.glDisableVertexAttribArray));
				_glEnableVertexAttribArray = (Delegates.glEnableVertexAttribArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnableVertexAttribArray"), typeof(Delegates.glEnableVertexAttribArray));
				_glGetActiveAttrib = (Delegates.glGetActiveAttrib)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveAttrib"), typeof(Delegates.glGetActiveAttrib));
				_glGetActiveUniform = (Delegates.glGetActiveUniform)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniform"), typeof(Delegates.glGetActiveUniform));
				_glGetAttachedShaders = (Delegates.glGetAttachedShaders)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetAttachedShaders"), typeof(Delegates.glGetAttachedShaders));
				_glGetAttribLocation = (Delegates.glGetAttribLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetAttribLocation"), typeof(Delegates.glGetAttribLocation));
				_glGetProgramiv = (Delegates.glGetProgramiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramiv"), typeof(Delegates.glGetProgramiv));
				_glGetProgramInfoLog = (Delegates.glGetProgramInfoLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramInfoLog"), typeof(Delegates.glGetProgramInfoLog));
				_glGetShaderiv = (Delegates.glGetShaderiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderiv"), typeof(Delegates.glGetShaderiv));
				_glGetShaderInfoLog = (Delegates.glGetShaderInfoLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderInfoLog"), typeof(Delegates.glGetShaderInfoLog));
				_glGetShaderSource = (Delegates.glGetShaderSource)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderSource"), typeof(Delegates.glGetShaderSource));
				_glGetUniformLocation = (Delegates.glGetUniformLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformLocation"), typeof(Delegates.glGetUniformLocation));
				_glGetUniformfv = (Delegates.glGetUniformfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformfv"), typeof(Delegates.glGetUniformfv));
				_glGetUniformiv = (Delegates.glGetUniformiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformiv"), typeof(Delegates.glGetUniformiv));
				_glGetVertexAttribdv = (Delegates.glGetVertexAttribdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribdv"), typeof(Delegates.glGetVertexAttribdv));
				_glGetVertexAttribfv = (Delegates.glGetVertexAttribfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribfv"), typeof(Delegates.glGetVertexAttribfv));
				_glGetVertexAttribiv = (Delegates.glGetVertexAttribiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribiv"), typeof(Delegates.glGetVertexAttribiv));
				_glGetVertexAttribPointerv = (Delegates.glGetVertexAttribPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribPointerv"), typeof(Delegates.glGetVertexAttribPointerv));
				_glIsProgram = (Delegates.glIsProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsProgram"), typeof(Delegates.glIsProgram));
				_glIsShader = (Delegates.glIsShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsShader"), typeof(Delegates.glIsShader));
				_glLinkProgram = (Delegates.glLinkProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glLinkProgram"), typeof(Delegates.glLinkProgram));
				_glShaderSource = (Delegates.glShaderSource)Marshal.GetDelegateForFunctionPointer(getProcAddress("glShaderSource"), typeof(Delegates.glShaderSource));
				_glUseProgram = (Delegates.glUseProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUseProgram"), typeof(Delegates.glUseProgram));
				_glUniform1f = (Delegates.glUniform1f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1f"), typeof(Delegates.glUniform1f));
				_glUniform2f = (Delegates.glUniform2f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2f"), typeof(Delegates.glUniform2f));
				_glUniform3f = (Delegates.glUniform3f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3f"), typeof(Delegates.glUniform3f));
				_glUniform4f = (Delegates.glUniform4f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4f"), typeof(Delegates.glUniform4f));
				_glUniform1i = (Delegates.glUniform1i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1i"), typeof(Delegates.glUniform1i));
				_glUniform2i = (Delegates.glUniform2i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2i"), typeof(Delegates.glUniform2i));
				_glUniform3i = (Delegates.glUniform3i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3i"), typeof(Delegates.glUniform3i));
				_glUniform4i = (Delegates.glUniform4i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4i"), typeof(Delegates.glUniform4i));
				_glUniform1fv = (Delegates.glUniform1fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1fv"), typeof(Delegates.glUniform1fv));
				_glUniform2fv = (Delegates.glUniform2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2fv"), typeof(Delegates.glUniform2fv));
				_glUniform3fv = (Delegates.glUniform3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3fv"), typeof(Delegates.glUniform3fv));
				_glUniform4fv = (Delegates.glUniform4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4fv"), typeof(Delegates.glUniform4fv));
				_glUniform1iv = (Delegates.glUniform1iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1iv"), typeof(Delegates.glUniform1iv));
				_glUniform2iv = (Delegates.glUniform2iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2iv"), typeof(Delegates.glUniform2iv));
				_glUniform3iv = (Delegates.glUniform3iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3iv"), typeof(Delegates.glUniform3iv));
				_glUniform4iv = (Delegates.glUniform4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4iv"), typeof(Delegates.glUniform4iv));
				_glUniformMatrix2fv = (Delegates.glUniformMatrix2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2fv"), typeof(Delegates.glUniformMatrix2fv));
				_glUniformMatrix3fv = (Delegates.glUniformMatrix3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3fv"), typeof(Delegates.glUniformMatrix3fv));
				_glUniformMatrix4fv = (Delegates.glUniformMatrix4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4fv"), typeof(Delegates.glUniformMatrix4fv));
				_glValidateProgram = (Delegates.glValidateProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glValidateProgram"), typeof(Delegates.glValidateProgram));
				_glVertexAttrib1d = (Delegates.glVertexAttrib1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1d"), typeof(Delegates.glVertexAttrib1d));
				_glVertexAttrib1dv = (Delegates.glVertexAttrib1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1dv"), typeof(Delegates.glVertexAttrib1dv));
				_glVertexAttrib1f = (Delegates.glVertexAttrib1f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1f"), typeof(Delegates.glVertexAttrib1f));
				_glVertexAttrib1fv = (Delegates.glVertexAttrib1fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1fv"), typeof(Delegates.glVertexAttrib1fv));
				_glVertexAttrib1s = (Delegates.glVertexAttrib1s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1s"), typeof(Delegates.glVertexAttrib1s));
				_glVertexAttrib1sv = (Delegates.glVertexAttrib1sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1sv"), typeof(Delegates.glVertexAttrib1sv));
				_glVertexAttrib2d = (Delegates.glVertexAttrib2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2d"), typeof(Delegates.glVertexAttrib2d));
				_glVertexAttrib2dv = (Delegates.glVertexAttrib2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2dv"), typeof(Delegates.glVertexAttrib2dv));
				_glVertexAttrib2f = (Delegates.glVertexAttrib2f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2f"), typeof(Delegates.glVertexAttrib2f));
				_glVertexAttrib2fv = (Delegates.glVertexAttrib2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2fv"), typeof(Delegates.glVertexAttrib2fv));
				_glVertexAttrib2s = (Delegates.glVertexAttrib2s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2s"), typeof(Delegates.glVertexAttrib2s));
				_glVertexAttrib2sv = (Delegates.glVertexAttrib2sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2sv"), typeof(Delegates.glVertexAttrib2sv));
				_glVertexAttrib3d = (Delegates.glVertexAttrib3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3d"), typeof(Delegates.glVertexAttrib3d));
				_glVertexAttrib3dv = (Delegates.glVertexAttrib3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3dv"), typeof(Delegates.glVertexAttrib3dv));
				_glVertexAttrib3f = (Delegates.glVertexAttrib3f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3f"), typeof(Delegates.glVertexAttrib3f));
				_glVertexAttrib3fv = (Delegates.glVertexAttrib3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3fv"), typeof(Delegates.glVertexAttrib3fv));
				_glVertexAttrib3s = (Delegates.glVertexAttrib3s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3s"), typeof(Delegates.glVertexAttrib3s));
				_glVertexAttrib3sv = (Delegates.glVertexAttrib3sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3sv"), typeof(Delegates.glVertexAttrib3sv));
				_glVertexAttrib4Nbv = (Delegates.glVertexAttrib4Nbv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nbv"), typeof(Delegates.glVertexAttrib4Nbv));
				_glVertexAttrib4Niv = (Delegates.glVertexAttrib4Niv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Niv"), typeof(Delegates.glVertexAttrib4Niv));
				_glVertexAttrib4Nsv = (Delegates.glVertexAttrib4Nsv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nsv"), typeof(Delegates.glVertexAttrib4Nsv));
				_glVertexAttrib4Nub = (Delegates.glVertexAttrib4Nub)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nub"), typeof(Delegates.glVertexAttrib4Nub));
				_glVertexAttrib4Nubv = (Delegates.glVertexAttrib4Nubv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nubv"), typeof(Delegates.glVertexAttrib4Nubv));
				_glVertexAttrib4Nuiv = (Delegates.glVertexAttrib4Nuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nuiv"), typeof(Delegates.glVertexAttrib4Nuiv));
				_glVertexAttrib4Nusv = (Delegates.glVertexAttrib4Nusv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nusv"), typeof(Delegates.glVertexAttrib4Nusv));
				_glVertexAttrib4bv = (Delegates.glVertexAttrib4bv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4bv"), typeof(Delegates.glVertexAttrib4bv));
				_glVertexAttrib4d = (Delegates.glVertexAttrib4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4d"), typeof(Delegates.glVertexAttrib4d));
				_glVertexAttrib4dv = (Delegates.glVertexAttrib4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4dv"), typeof(Delegates.glVertexAttrib4dv));
				_glVertexAttrib4f = (Delegates.glVertexAttrib4f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4f"), typeof(Delegates.glVertexAttrib4f));
				_glVertexAttrib4fv = (Delegates.glVertexAttrib4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4fv"), typeof(Delegates.glVertexAttrib4fv));
				_glVertexAttrib4iv = (Delegates.glVertexAttrib4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4iv"), typeof(Delegates.glVertexAttrib4iv));
				_glVertexAttrib4s = (Delegates.glVertexAttrib4s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4s"), typeof(Delegates.glVertexAttrib4s));
				_glVertexAttrib4sv = (Delegates.glVertexAttrib4sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4sv"), typeof(Delegates.glVertexAttrib4sv));
				_glVertexAttrib4ubv = (Delegates.glVertexAttrib4ubv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4ubv"), typeof(Delegates.glVertexAttrib4ubv));
				_glVertexAttrib4uiv = (Delegates.glVertexAttrib4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4uiv"), typeof(Delegates.glVertexAttrib4uiv));
				_glVertexAttrib4usv = (Delegates.glVertexAttrib4usv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4usv"), typeof(Delegates.glVertexAttrib4usv));
				_glVertexAttribPointer = (Delegates.glVertexAttribPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribPointer"), typeof(Delegates.glVertexAttribPointer));
			}

			if (versionMajor > 2 || (versionMajor == 2 && versionMinor >= 1))
			{
				_glUniformMatrix2x3fv = (Delegates.glUniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x3fv"), typeof(Delegates.glUniformMatrix2x3fv));
				_glUniformMatrix3x2fv = (Delegates.glUniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x2fv"), typeof(Delegates.glUniformMatrix3x2fv));
				_glUniformMatrix2x4fv = (Delegates.glUniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x4fv"), typeof(Delegates.glUniformMatrix2x4fv));
				_glUniformMatrix4x2fv = (Delegates.glUniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x2fv"), typeof(Delegates.glUniformMatrix4x2fv));
				_glUniformMatrix3x4fv = (Delegates.glUniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x4fv"), typeof(Delegates.glUniformMatrix3x4fv));
				_glUniformMatrix4x3fv = (Delegates.glUniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x3fv"), typeof(Delegates.glUniformMatrix4x3fv));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 0))
			{
				_glColorMaski = (Delegates.glColorMaski)Marshal.GetDelegateForFunctionPointer(getProcAddress("glColorMaski"), typeof(Delegates.glColorMaski));
				_glGetBooleani_v = (Delegates.glGetBooleani_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBooleani_v"), typeof(Delegates.glGetBooleani_v));
				_glGetIntegeri_v = (Delegates.glGetIntegeri_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetIntegeri_v"), typeof(Delegates.glGetIntegeri_v));
				_glEnablei = (Delegates.glEnablei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnablei"), typeof(Delegates.glEnablei));
				_glDisablei = (Delegates.glDisablei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisablei"), typeof(Delegates.glDisablei));
				_glIsEnabledi = (Delegates.glIsEnabledi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsEnabledi"), typeof(Delegates.glIsEnabledi));
				_glBeginTransformFeedback = (Delegates.glBeginTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginTransformFeedback"), typeof(Delegates.glBeginTransformFeedback));
				_glEndTransformFeedback = (Delegates.glEndTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndTransformFeedback"), typeof(Delegates.glEndTransformFeedback));
				_glBindBufferRange = (Delegates.glBindBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBufferRange"), typeof(Delegates.glBindBufferRange));
				_glBindBufferBase = (Delegates.glBindBufferBase)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBufferBase"), typeof(Delegates.glBindBufferBase));
				_glTransformFeedbackVaryings = (Delegates.glTransformFeedbackVaryings)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTransformFeedbackVaryings"), typeof(Delegates.glTransformFeedbackVaryings));
				_glGetTransformFeedbackVarying = (Delegates.glGetTransformFeedbackVarying)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbackVarying"), typeof(Delegates.glGetTransformFeedbackVarying));
				_glClampColor = (Delegates.glClampColor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClampColor"), typeof(Delegates.glClampColor));
				_glBeginConditionalRender = (Delegates.glBeginConditionalRender)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginConditionalRender"), typeof(Delegates.glBeginConditionalRender));
				_glEndConditionalRender = (Delegates.glEndConditionalRender)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndConditionalRender"), typeof(Delegates.glEndConditionalRender));
				_glVertexAttribIPointer = (Delegates.glVertexAttribIPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribIPointer"), typeof(Delegates.glVertexAttribIPointer));
				_glGetVertexAttribIiv = (Delegates.glGetVertexAttribIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribIiv"), typeof(Delegates.glGetVertexAttribIiv));
				_glGetVertexAttribIuiv = (Delegates.glGetVertexAttribIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribIuiv"), typeof(Delegates.glGetVertexAttribIuiv));
				_glVertexAttribI1i = (Delegates.glVertexAttribI1i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1i"), typeof(Delegates.glVertexAttribI1i));
				_glVertexAttribI2i = (Delegates.glVertexAttribI2i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2i"), typeof(Delegates.glVertexAttribI2i));
				_glVertexAttribI3i = (Delegates.glVertexAttribI3i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3i"), typeof(Delegates.glVertexAttribI3i));
				_glVertexAttribI4i = (Delegates.glVertexAttribI4i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4i"), typeof(Delegates.glVertexAttribI4i));
				_glVertexAttribI1ui = (Delegates.glVertexAttribI1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1ui"), typeof(Delegates.glVertexAttribI1ui));
				_glVertexAttribI2ui = (Delegates.glVertexAttribI2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2ui"), typeof(Delegates.glVertexAttribI2ui));
				_glVertexAttribI3ui = (Delegates.glVertexAttribI3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3ui"), typeof(Delegates.glVertexAttribI3ui));
				_glVertexAttribI4ui = (Delegates.glVertexAttribI4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4ui"), typeof(Delegates.glVertexAttribI4ui));
				_glVertexAttribI1iv = (Delegates.glVertexAttribI1iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1iv"), typeof(Delegates.glVertexAttribI1iv));
				_glVertexAttribI2iv = (Delegates.glVertexAttribI2iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2iv"), typeof(Delegates.glVertexAttribI2iv));
				_glVertexAttribI3iv = (Delegates.glVertexAttribI3iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3iv"), typeof(Delegates.glVertexAttribI3iv));
				_glVertexAttribI4iv = (Delegates.glVertexAttribI4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4iv"), typeof(Delegates.glVertexAttribI4iv));
				_glVertexAttribI1uiv = (Delegates.glVertexAttribI1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1uiv"), typeof(Delegates.glVertexAttribI1uiv));
				_glVertexAttribI2uiv = (Delegates.glVertexAttribI2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2uiv"), typeof(Delegates.glVertexAttribI2uiv));
				_glVertexAttribI3uiv = (Delegates.glVertexAttribI3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3uiv"), typeof(Delegates.glVertexAttribI3uiv));
				_glVertexAttribI4uiv = (Delegates.glVertexAttribI4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4uiv"), typeof(Delegates.glVertexAttribI4uiv));
				_glVertexAttribI4bv = (Delegates.glVertexAttribI4bv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4bv"), typeof(Delegates.glVertexAttribI4bv));
				_glVertexAttribI4sv = (Delegates.glVertexAttribI4sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4sv"), typeof(Delegates.glVertexAttribI4sv));
				_glVertexAttribI4ubv = (Delegates.glVertexAttribI4ubv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4ubv"), typeof(Delegates.glVertexAttribI4ubv));
				_glVertexAttribI4usv = (Delegates.glVertexAttribI4usv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4usv"), typeof(Delegates.glVertexAttribI4usv));
				_glGetUniformuiv = (Delegates.glGetUniformuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformuiv"), typeof(Delegates.glGetUniformuiv));
				_glBindFragDataLocation = (Delegates.glBindFragDataLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindFragDataLocation"), typeof(Delegates.glBindFragDataLocation));
				_glGetFragDataLocation = (Delegates.glGetFragDataLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFragDataLocation"), typeof(Delegates.glGetFragDataLocation));
				_glUniform1ui = (Delegates.glUniform1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1ui"), typeof(Delegates.glUniform1ui));
				_glUniform2ui = (Delegates.glUniform2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2ui"), typeof(Delegates.glUniform2ui));
				_glUniform3ui = (Delegates.glUniform3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3ui"), typeof(Delegates.glUniform3ui));
				_glUniform4ui = (Delegates.glUniform4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4ui"), typeof(Delegates.glUniform4ui));
				_glUniform1uiv = (Delegates.glUniform1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1uiv"), typeof(Delegates.glUniform1uiv));
				_glUniform2uiv = (Delegates.glUniform2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2uiv"), typeof(Delegates.glUniform2uiv));
				_glUniform3uiv = (Delegates.glUniform3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3uiv"), typeof(Delegates.glUniform3uiv));
				_glUniform4uiv = (Delegates.glUniform4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4uiv"), typeof(Delegates.glUniform4uiv));
				_glTexParameterIiv = (Delegates.glTexParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterIiv"), typeof(Delegates.glTexParameterIiv));
				_glTexParameterIuiv = (Delegates.glTexParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterIuiv"), typeof(Delegates.glTexParameterIuiv));
				_glGetTexParameterIiv = (Delegates.glGetTexParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameterIiv"), typeof(Delegates.glGetTexParameterIiv));
				_glGetTexParameterIuiv = (Delegates.glGetTexParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameterIuiv"), typeof(Delegates.glGetTexParameterIuiv));
				_glClearBufferiv = (Delegates.glClearBufferiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferiv"), typeof(Delegates.glClearBufferiv));
				_glClearBufferuiv = (Delegates.glClearBufferuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferuiv"), typeof(Delegates.glClearBufferuiv));
				_glClearBufferfv = (Delegates.glClearBufferfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferfv"), typeof(Delegates.glClearBufferfv));
				_glClearBufferfi = (Delegates.glClearBufferfi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferfi"), typeof(Delegates.glClearBufferfi));
				_glGetStringi = (Delegates.glGetStringi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetStringi"), typeof(Delegates.glGetStringi));
				_glIsRenderbuffer = (Delegates.glIsRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsRenderbuffer"), typeof(Delegates.glIsRenderbuffer));
				_glBindRenderbuffer = (Delegates.glBindRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindRenderbuffer"), typeof(Delegates.glBindRenderbuffer));
				_glDeleteRenderbuffers = (Delegates.glDeleteRenderbuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteRenderbuffers"), typeof(Delegates.glDeleteRenderbuffers));
				_glGenRenderbuffers = (Delegates.glGenRenderbuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenRenderbuffers"), typeof(Delegates.glGenRenderbuffers));
				_glRenderbufferStorage = (Delegates.glRenderbufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glRenderbufferStorage"), typeof(Delegates.glRenderbufferStorage));
				_glGetRenderbufferParameteriv = (Delegates.glGetRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetRenderbufferParameteriv"), typeof(Delegates.glGetRenderbufferParameteriv));
				_glIsFramebuffer = (Delegates.glIsFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsFramebuffer"), typeof(Delegates.glIsFramebuffer));
				_glBindFramebuffer = (Delegates.glBindFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindFramebuffer"), typeof(Delegates.glBindFramebuffer));
				_glDeleteFramebuffers = (Delegates.glDeleteFramebuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteFramebuffers"), typeof(Delegates.glDeleteFramebuffers));
				_glGenFramebuffers = (Delegates.glGenFramebuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenFramebuffers"), typeof(Delegates.glGenFramebuffers));
				_glCheckFramebufferStatus = (Delegates.glCheckFramebufferStatus)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCheckFramebufferStatus"), typeof(Delegates.glCheckFramebufferStatus));
				_glFramebufferTexture1D = (Delegates.glFramebufferTexture1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture1D"), typeof(Delegates.glFramebufferTexture1D));
				_glFramebufferTexture2D = (Delegates.glFramebufferTexture2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture2D"), typeof(Delegates.glFramebufferTexture2D));
				_glFramebufferTexture3D = (Delegates.glFramebufferTexture3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture3D"), typeof(Delegates.glFramebufferTexture3D));
				_glFramebufferRenderbuffer = (Delegates.glFramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferRenderbuffer"), typeof(Delegates.glFramebufferRenderbuffer));
				_glGetFramebufferAttachmentParameteriv = (Delegates.glGetFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFramebufferAttachmentParameteriv"), typeof(Delegates.glGetFramebufferAttachmentParameteriv));
				_glGenerateMipmap = (Delegates.glGenerateMipmap)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenerateMipmap"), typeof(Delegates.glGenerateMipmap));
				_glBlitFramebuffer = (Delegates.glBlitFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlitFramebuffer"), typeof(Delegates.glBlitFramebuffer));
				_glRenderbufferStorageMultisample = (Delegates.glRenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glRenderbufferStorageMultisample"), typeof(Delegates.glRenderbufferStorageMultisample));
				_glFramebufferTextureLayer = (Delegates.glFramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTextureLayer"), typeof(Delegates.glFramebufferTextureLayer));
				_glMapBufferRange = (Delegates.glMapBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapBufferRange"), typeof(Delegates.glMapBufferRange));
				_glFlushMappedBufferRange = (Delegates.glFlushMappedBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFlushMappedBufferRange"), typeof(Delegates.glFlushMappedBufferRange));
				_glBindVertexArray = (Delegates.glBindVertexArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindVertexArray"), typeof(Delegates.glBindVertexArray));
				_glDeleteVertexArrays = (Delegates.glDeleteVertexArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteVertexArrays"), typeof(Delegates.glDeleteVertexArrays));
				_glGenVertexArrays = (Delegates.glGenVertexArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenVertexArrays"), typeof(Delegates.glGenVertexArrays));
				_glIsVertexArray = (Delegates.glIsVertexArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsVertexArray"), typeof(Delegates.glIsVertexArray));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 1))
			{
				_glDrawArraysInstanced = (Delegates.glDrawArraysInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArraysInstanced"), typeof(Delegates.glDrawArraysInstanced));
				_glDrawElementsInstanced = (Delegates.glDrawElementsInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstanced"), typeof(Delegates.glDrawElementsInstanced));
				_glTexBuffer = (Delegates.glTexBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexBuffer"), typeof(Delegates.glTexBuffer));
				_glPrimitiveRestartIndex = (Delegates.glPrimitiveRestartIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPrimitiveRestartIndex"), typeof(Delegates.glPrimitiveRestartIndex));
				_glCopyBufferSubData = (Delegates.glCopyBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyBufferSubData"), typeof(Delegates.glCopyBufferSubData));
				_glGetUniformIndices = (Delegates.glGetUniformIndices)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformIndices"), typeof(Delegates.glGetUniformIndices));
				_glGetActiveUniformsiv = (Delegates.glGetActiveUniformsiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformsiv"), typeof(Delegates.glGetActiveUniformsiv));
				_glGetActiveUniformName = (Delegates.glGetActiveUniformName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformName"), typeof(Delegates.glGetActiveUniformName));
				_glGetUniformBlockIndex = (Delegates.glGetUniformBlockIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformBlockIndex"), typeof(Delegates.glGetUniformBlockIndex));
				_glGetActiveUniformBlockiv = (Delegates.glGetActiveUniformBlockiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformBlockiv"), typeof(Delegates.glGetActiveUniformBlockiv));
				_glGetActiveUniformBlockName = (Delegates.glGetActiveUniformBlockName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformBlockName"), typeof(Delegates.glGetActiveUniformBlockName));
				_glUniformBlockBinding = (Delegates.glUniformBlockBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformBlockBinding"), typeof(Delegates.glUniformBlockBinding));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 2))
			{
				_glDrawElementsBaseVertex = (Delegates.glDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsBaseVertex"), typeof(Delegates.glDrawElementsBaseVertex));
				_glDrawRangeElementsBaseVertex = (Delegates.glDrawRangeElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawRangeElementsBaseVertex"), typeof(Delegates.glDrawRangeElementsBaseVertex));
				_glDrawElementsInstancedBaseVertex = (Delegates.glDrawElementsInstancedBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstancedBaseVertex"), typeof(Delegates.glDrawElementsInstancedBaseVertex));
				_glMultiDrawElementsBaseVertex = (Delegates.glMultiDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawElementsBaseVertex"), typeof(Delegates.glMultiDrawElementsBaseVertex));
				_glProvokingVertex = (Delegates.glProvokingVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProvokingVertex"), typeof(Delegates.glProvokingVertex));
				_glFenceSync = (Delegates.glFenceSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFenceSync"), typeof(Delegates.glFenceSync));
				_glIsSync = (Delegates.glIsSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsSync"), typeof(Delegates.glIsSync));
				_glDeleteSync = (Delegates.glDeleteSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteSync"), typeof(Delegates.glDeleteSync));
				_glClientWaitSync = (Delegates.glClientWaitSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClientWaitSync"), typeof(Delegates.glClientWaitSync));
				_glWaitSync = (Delegates.glWaitSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glWaitSync"), typeof(Delegates.glWaitSync));
				_glGetInteger64v = (Delegates.glGetInteger64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInteger64v"), typeof(Delegates.glGetInteger64v));
				_glGetSynciv = (Delegates.glGetSynciv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSynciv"), typeof(Delegates.glGetSynciv));
				_glGetInteger64i_v = (Delegates.glGetInteger64i_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInteger64i_v"), typeof(Delegates.glGetInteger64i_v));
				_glGetBufferParameteri64v = (Delegates.glGetBufferParameteri64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferParameteri64v"), typeof(Delegates.glGetBufferParameteri64v));
				_glFramebufferTexture = (Delegates.glFramebufferTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture"), typeof(Delegates.glFramebufferTexture));
				_glTexImage2DMultisample = (Delegates.glTexImage2DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage2DMultisample"), typeof(Delegates.glTexImage2DMultisample));
				_glTexImage3DMultisample = (Delegates.glTexImage3DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage3DMultisample"), typeof(Delegates.glTexImage3DMultisample));
				_glGetMultisamplefv = (Delegates.glGetMultisamplefv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetMultisamplefv"), typeof(Delegates.glGetMultisamplefv));
				_glSampleMaski = (Delegates.glSampleMaski)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSampleMaski"), typeof(Delegates.glSampleMaski));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 3))
			{
				_glBindFragDataLocationIndexed = (Delegates.glBindFragDataLocationIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindFragDataLocationIndexed"), typeof(Delegates.glBindFragDataLocationIndexed));
				_glGetFragDataIndex = (Delegates.glGetFragDataIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFragDataIndex"), typeof(Delegates.glGetFragDataIndex));
				_glGenSamplers = (Delegates.glGenSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenSamplers"), typeof(Delegates.glGenSamplers));
				_glDeleteSamplers = (Delegates.glDeleteSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteSamplers"), typeof(Delegates.glDeleteSamplers));
				_glIsSampler = (Delegates.glIsSampler)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsSampler"), typeof(Delegates.glIsSampler));
				_glBindSampler = (Delegates.glBindSampler)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindSampler"), typeof(Delegates.glBindSampler));
				_glSamplerParameteri = (Delegates.glSamplerParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameteri"), typeof(Delegates.glSamplerParameteri));
				_glSamplerParameteriv = (Delegates.glSamplerParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameteriv"), typeof(Delegates.glSamplerParameteriv));
				_glSamplerParameterf = (Delegates.glSamplerParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterf"), typeof(Delegates.glSamplerParameterf));
				_glSamplerParameterfv = (Delegates.glSamplerParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterfv"), typeof(Delegates.glSamplerParameterfv));
				_glSamplerParameterIiv = (Delegates.glSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterIiv"), typeof(Delegates.glSamplerParameterIiv));
				_glSamplerParameterIuiv = (Delegates.glSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterIuiv"), typeof(Delegates.glSamplerParameterIuiv));
				_glGetSamplerParameteriv = (Delegates.glGetSamplerParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameteriv"), typeof(Delegates.glGetSamplerParameteriv));
				_glGetSamplerParameterIiv = (Delegates.glGetSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameterIiv"), typeof(Delegates.glGetSamplerParameterIiv));
				_glGetSamplerParameterfv = (Delegates.glGetSamplerParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameterfv"), typeof(Delegates.glGetSamplerParameterfv));
				_glGetSamplerParameterIuiv = (Delegates.glGetSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameterIuiv"), typeof(Delegates.glGetSamplerParameterIuiv));
				_glQueryCounter = (Delegates.glQueryCounter)Marshal.GetDelegateForFunctionPointer(getProcAddress("glQueryCounter"), typeof(Delegates.glQueryCounter));
				_glGetQueryObjecti64v = (Delegates.glGetQueryObjecti64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjecti64v"), typeof(Delegates.glGetQueryObjecti64v));
				_glGetQueryObjectui64v = (Delegates.glGetQueryObjectui64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjectui64v"), typeof(Delegates.glGetQueryObjectui64v));
				_glVertexAttribDivisor = (Delegates.glVertexAttribDivisor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribDivisor"), typeof(Delegates.glVertexAttribDivisor));
				_glVertexAttribP1ui = (Delegates.glVertexAttribP1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP1ui"), typeof(Delegates.glVertexAttribP1ui));
				_glVertexAttribP1uiv = (Delegates.glVertexAttribP1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP1uiv"), typeof(Delegates.glVertexAttribP1uiv));
				_glVertexAttribP2ui = (Delegates.glVertexAttribP2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP2ui"), typeof(Delegates.glVertexAttribP2ui));
				_glVertexAttribP2uiv = (Delegates.glVertexAttribP2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP2uiv"), typeof(Delegates.glVertexAttribP2uiv));
				_glVertexAttribP3ui = (Delegates.glVertexAttribP3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP3ui"), typeof(Delegates.glVertexAttribP3ui));
				_glVertexAttribP3uiv = (Delegates.glVertexAttribP3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP3uiv"), typeof(Delegates.glVertexAttribP3uiv));
				_glVertexAttribP4ui = (Delegates.glVertexAttribP4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP4ui"), typeof(Delegates.glVertexAttribP4ui));
				_glVertexAttribP4uiv = (Delegates.glVertexAttribP4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP4uiv"), typeof(Delegates.glVertexAttribP4uiv));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 0))
			{
				_glMinSampleShading = (Delegates.glMinSampleShading)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMinSampleShading"), typeof(Delegates.glMinSampleShading));
				_glBlendEquationi = (Delegates.glBlendEquationi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquationi"), typeof(Delegates.glBlendEquationi));
				_glBlendEquationSeparatei = (Delegates.glBlendEquationSeparatei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquationSeparatei"), typeof(Delegates.glBlendEquationSeparatei));
				_glBlendFunci = (Delegates.glBlendFunci)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFunci"), typeof(Delegates.glBlendFunci));
				_glBlendFuncSeparatei = (Delegates.glBlendFuncSeparatei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFuncSeparatei"), typeof(Delegates.glBlendFuncSeparatei));
				_glDrawArraysIndirect = (Delegates.glDrawArraysIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArraysIndirect"), typeof(Delegates.glDrawArraysIndirect));
				_glDrawElementsIndirect = (Delegates.glDrawElementsIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsIndirect"), typeof(Delegates.glDrawElementsIndirect));
				_glUniform1d = (Delegates.glUniform1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1d"), typeof(Delegates.glUniform1d));
				_glUniform2d = (Delegates.glUniform2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2d"), typeof(Delegates.glUniform2d));
				_glUniform3d = (Delegates.glUniform3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3d"), typeof(Delegates.glUniform3d));
				_glUniform4d = (Delegates.glUniform4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4d"), typeof(Delegates.glUniform4d));
				_glUniform1dv = (Delegates.glUniform1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1dv"), typeof(Delegates.glUniform1dv));
				_glUniform2dv = (Delegates.glUniform2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2dv"), typeof(Delegates.glUniform2dv));
				_glUniform3dv = (Delegates.glUniform3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3dv"), typeof(Delegates.glUniform3dv));
				_glUniform4dv = (Delegates.glUniform4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4dv"), typeof(Delegates.glUniform4dv));
				_glUniformMatrix2dv = (Delegates.glUniformMatrix2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2dv"), typeof(Delegates.glUniformMatrix2dv));
				_glUniformMatrix3dv = (Delegates.glUniformMatrix3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3dv"), typeof(Delegates.glUniformMatrix3dv));
				_glUniformMatrix4dv = (Delegates.glUniformMatrix4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4dv"), typeof(Delegates.glUniformMatrix4dv));
				_glUniformMatrix2x3dv = (Delegates.glUniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x3dv"), typeof(Delegates.glUniformMatrix2x3dv));
				_glUniformMatrix2x4dv = (Delegates.glUniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x4dv"), typeof(Delegates.glUniformMatrix2x4dv));
				_glUniformMatrix3x2dv = (Delegates.glUniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x2dv"), typeof(Delegates.glUniformMatrix3x2dv));
				_glUniformMatrix3x4dv = (Delegates.glUniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x4dv"), typeof(Delegates.glUniformMatrix3x4dv));
				_glUniformMatrix4x2dv = (Delegates.glUniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x2dv"), typeof(Delegates.glUniformMatrix4x2dv));
				_glUniformMatrix4x3dv = (Delegates.glUniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x3dv"), typeof(Delegates.glUniformMatrix4x3dv));
				_glGetUniformdv = (Delegates.glGetUniformdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformdv"), typeof(Delegates.glGetUniformdv));
				_glGetSubroutineUniformLocation = (Delegates.glGetSubroutineUniformLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSubroutineUniformLocation"), typeof(Delegates.glGetSubroutineUniformLocation));
				_glGetSubroutineIndex = (Delegates.glGetSubroutineIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSubroutineIndex"), typeof(Delegates.glGetSubroutineIndex));
				_glGetActiveSubroutineUniformiv = (Delegates.glGetActiveSubroutineUniformiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveSubroutineUniformiv"), typeof(Delegates.glGetActiveSubroutineUniformiv));
				_glGetActiveSubroutineUniformName = (Delegates.glGetActiveSubroutineUniformName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveSubroutineUniformName"), typeof(Delegates.glGetActiveSubroutineUniformName));
				_glGetActiveSubroutineName = (Delegates.glGetActiveSubroutineName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveSubroutineName"), typeof(Delegates.glGetActiveSubroutineName));
				_glUniformSubroutinesuiv = (Delegates.glUniformSubroutinesuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformSubroutinesuiv"), typeof(Delegates.glUniformSubroutinesuiv));
				_glGetUniformSubroutineuiv = (Delegates.glGetUniformSubroutineuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformSubroutineuiv"), typeof(Delegates.glGetUniformSubroutineuiv));
				_glGetProgramStageiv = (Delegates.glGetProgramStageiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramStageiv"), typeof(Delegates.glGetProgramStageiv));
				_glPatchParameteri = (Delegates.glPatchParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPatchParameteri"), typeof(Delegates.glPatchParameteri));
				_glPatchParameterfv = (Delegates.glPatchParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPatchParameterfv"), typeof(Delegates.glPatchParameterfv));
				_glBindTransformFeedback = (Delegates.glBindTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTransformFeedback"), typeof(Delegates.glBindTransformFeedback));
				_glDeleteTransformFeedbacks = (Delegates.glDeleteTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteTransformFeedbacks"), typeof(Delegates.glDeleteTransformFeedbacks));
				_glGenTransformFeedbacks = (Delegates.glGenTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenTransformFeedbacks"), typeof(Delegates.glGenTransformFeedbacks));
				_glIsTransformFeedback = (Delegates.glIsTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsTransformFeedback"), typeof(Delegates.glIsTransformFeedback));
				_glPauseTransformFeedback = (Delegates.glPauseTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPauseTransformFeedback"), typeof(Delegates.glPauseTransformFeedback));
				_glResumeTransformFeedback = (Delegates.glResumeTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glResumeTransformFeedback"), typeof(Delegates.glResumeTransformFeedback));
				_glDrawTransformFeedback = (Delegates.glDrawTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedback"), typeof(Delegates.glDrawTransformFeedback));
				_glDrawTransformFeedbackStream = (Delegates.glDrawTransformFeedbackStream)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedbackStream"), typeof(Delegates.glDrawTransformFeedbackStream));
				_glBeginQueryIndexed = (Delegates.glBeginQueryIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginQueryIndexed"), typeof(Delegates.glBeginQueryIndexed));
				_glEndQueryIndexed = (Delegates.glEndQueryIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndQueryIndexed"), typeof(Delegates.glEndQueryIndexed));
				_glGetQueryIndexediv = (Delegates.glGetQueryIndexediv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryIndexediv"), typeof(Delegates.glGetQueryIndexediv));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 1))
			{
				_glReleaseShaderCompiler = (Delegates.glReleaseShaderCompiler)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReleaseShaderCompiler"), typeof(Delegates.glReleaseShaderCompiler));
				_glShaderBinary = (Delegates.glShaderBinary)Marshal.GetDelegateForFunctionPointer(getProcAddress("glShaderBinary"), typeof(Delegates.glShaderBinary));
				_glGetShaderPrecisionFormat = (Delegates.glGetShaderPrecisionFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderPrecisionFormat"), typeof(Delegates.glGetShaderPrecisionFormat));
				_glDepthRangef = (Delegates.glDepthRangef)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRangef"), typeof(Delegates.glDepthRangef));
				_glClearDepthf = (Delegates.glClearDepthf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearDepthf"), typeof(Delegates.glClearDepthf));
				_glGetProgramBinary = (Delegates.glGetProgramBinary)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramBinary"), typeof(Delegates.glGetProgramBinary));
				_glProgramBinary = (Delegates.glProgramBinary)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramBinary"), typeof(Delegates.glProgramBinary));
				_glProgramParameteri = (Delegates.glProgramParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramParameteri"), typeof(Delegates.glProgramParameteri));
				_glUseProgramStages = (Delegates.glUseProgramStages)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUseProgramStages"), typeof(Delegates.glUseProgramStages));
				_glActiveShaderProgram = (Delegates.glActiveShaderProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glActiveShaderProgram"), typeof(Delegates.glActiveShaderProgram));
				_glCreateShaderProgramv = (Delegates.glCreateShaderProgramv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateShaderProgramv"), typeof(Delegates.glCreateShaderProgramv));
				_glBindProgramPipeline = (Delegates.glBindProgramPipeline)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindProgramPipeline"), typeof(Delegates.glBindProgramPipeline));
				_glDeleteProgramPipelines = (Delegates.glDeleteProgramPipelines)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteProgramPipelines"), typeof(Delegates.glDeleteProgramPipelines));
				_glGenProgramPipelines = (Delegates.glGenProgramPipelines)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenProgramPipelines"), typeof(Delegates.glGenProgramPipelines));
				_glIsProgramPipeline = (Delegates.glIsProgramPipeline)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsProgramPipeline"), typeof(Delegates.glIsProgramPipeline));
				_glGetProgramPipelineiv = (Delegates.glGetProgramPipelineiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramPipelineiv"), typeof(Delegates.glGetProgramPipelineiv));
				_glProgramUniform1i = (Delegates.glProgramUniform1i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1i"), typeof(Delegates.glProgramUniform1i));
				_glProgramUniform1iv = (Delegates.glProgramUniform1iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1iv"), typeof(Delegates.glProgramUniform1iv));
				_glProgramUniform1f = (Delegates.glProgramUniform1f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1f"), typeof(Delegates.glProgramUniform1f));
				_glProgramUniform1fv = (Delegates.glProgramUniform1fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1fv"), typeof(Delegates.glProgramUniform1fv));
				_glProgramUniform1d = (Delegates.glProgramUniform1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1d"), typeof(Delegates.glProgramUniform1d));
				_glProgramUniform1dv = (Delegates.glProgramUniform1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1dv"), typeof(Delegates.glProgramUniform1dv));
				_glProgramUniform1ui = (Delegates.glProgramUniform1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1ui"), typeof(Delegates.glProgramUniform1ui));
				_glProgramUniform1uiv = (Delegates.glProgramUniform1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1uiv"), typeof(Delegates.glProgramUniform1uiv));
				_glProgramUniform2i = (Delegates.glProgramUniform2i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2i"), typeof(Delegates.glProgramUniform2i));
				_glProgramUniform2iv = (Delegates.glProgramUniform2iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2iv"), typeof(Delegates.glProgramUniform2iv));
				_glProgramUniform2f = (Delegates.glProgramUniform2f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2f"), typeof(Delegates.glProgramUniform2f));
				_glProgramUniform2fv = (Delegates.glProgramUniform2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2fv"), typeof(Delegates.glProgramUniform2fv));
				_glProgramUniform2d = (Delegates.glProgramUniform2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2d"), typeof(Delegates.glProgramUniform2d));
				_glProgramUniform2dv = (Delegates.glProgramUniform2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2dv"), typeof(Delegates.glProgramUniform2dv));
				_glProgramUniform2ui = (Delegates.glProgramUniform2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2ui"), typeof(Delegates.glProgramUniform2ui));
				_glProgramUniform2uiv = (Delegates.glProgramUniform2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2uiv"), typeof(Delegates.glProgramUniform2uiv));
				_glProgramUniform3i = (Delegates.glProgramUniform3i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3i"), typeof(Delegates.glProgramUniform3i));
				_glProgramUniform3iv = (Delegates.glProgramUniform3iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3iv"), typeof(Delegates.glProgramUniform3iv));
				_glProgramUniform3f = (Delegates.glProgramUniform3f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3f"), typeof(Delegates.glProgramUniform3f));
				_glProgramUniform3fv = (Delegates.glProgramUniform3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3fv"), typeof(Delegates.glProgramUniform3fv));
				_glProgramUniform3d = (Delegates.glProgramUniform3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3d"), typeof(Delegates.glProgramUniform3d));
				_glProgramUniform3dv = (Delegates.glProgramUniform3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3dv"), typeof(Delegates.glProgramUniform3dv));
				_glProgramUniform3ui = (Delegates.glProgramUniform3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3ui"), typeof(Delegates.glProgramUniform3ui));
				_glProgramUniform3uiv = (Delegates.glProgramUniform3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3uiv"), typeof(Delegates.glProgramUniform3uiv));
				_glProgramUniform4i = (Delegates.glProgramUniform4i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4i"), typeof(Delegates.glProgramUniform4i));
				_glProgramUniform4iv = (Delegates.glProgramUniform4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4iv"), typeof(Delegates.glProgramUniform4iv));
				_glProgramUniform4f = (Delegates.glProgramUniform4f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4f"), typeof(Delegates.glProgramUniform4f));
				_glProgramUniform4fv = (Delegates.glProgramUniform4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4fv"), typeof(Delegates.glProgramUniform4fv));
				_glProgramUniform4d = (Delegates.glProgramUniform4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4d"), typeof(Delegates.glProgramUniform4d));
				_glProgramUniform4dv = (Delegates.glProgramUniform4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4dv"), typeof(Delegates.glProgramUniform4dv));
				_glProgramUniform4ui = (Delegates.glProgramUniform4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4ui"), typeof(Delegates.glProgramUniform4ui));
				_glProgramUniform4uiv = (Delegates.glProgramUniform4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4uiv"), typeof(Delegates.glProgramUniform4uiv));
				_glProgramUniformMatrix2fv = (Delegates.glProgramUniformMatrix2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2fv"), typeof(Delegates.glProgramUniformMatrix2fv));
				_glProgramUniformMatrix3fv = (Delegates.glProgramUniformMatrix3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3fv"), typeof(Delegates.glProgramUniformMatrix3fv));
				_glProgramUniformMatrix4fv = (Delegates.glProgramUniformMatrix4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4fv"), typeof(Delegates.glProgramUniformMatrix4fv));
				_glProgramUniformMatrix2dv = (Delegates.glProgramUniformMatrix2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2dv"), typeof(Delegates.glProgramUniformMatrix2dv));
				_glProgramUniformMatrix3dv = (Delegates.glProgramUniformMatrix3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3dv"), typeof(Delegates.glProgramUniformMatrix3dv));
				_glProgramUniformMatrix4dv = (Delegates.glProgramUniformMatrix4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4dv"), typeof(Delegates.glProgramUniformMatrix4dv));
				_glProgramUniformMatrix2x3fv = (Delegates.glProgramUniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x3fv"), typeof(Delegates.glProgramUniformMatrix2x3fv));
				_glProgramUniformMatrix3x2fv = (Delegates.glProgramUniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x2fv"), typeof(Delegates.glProgramUniformMatrix3x2fv));
				_glProgramUniformMatrix2x4fv = (Delegates.glProgramUniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x4fv"), typeof(Delegates.glProgramUniformMatrix2x4fv));
				_glProgramUniformMatrix4x2fv = (Delegates.glProgramUniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x2fv"), typeof(Delegates.glProgramUniformMatrix4x2fv));
				_glProgramUniformMatrix3x4fv = (Delegates.glProgramUniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x4fv"), typeof(Delegates.glProgramUniformMatrix3x4fv));
				_glProgramUniformMatrix4x3fv = (Delegates.glProgramUniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x3fv"), typeof(Delegates.glProgramUniformMatrix4x3fv));
				_glProgramUniformMatrix2x3dv = (Delegates.glProgramUniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x3dv"), typeof(Delegates.glProgramUniformMatrix2x3dv));
				_glProgramUniformMatrix3x2dv = (Delegates.glProgramUniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x2dv"), typeof(Delegates.glProgramUniformMatrix3x2dv));
				_glProgramUniformMatrix2x4dv = (Delegates.glProgramUniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x4dv"), typeof(Delegates.glProgramUniformMatrix2x4dv));
				_glProgramUniformMatrix4x2dv = (Delegates.glProgramUniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x2dv"), typeof(Delegates.glProgramUniformMatrix4x2dv));
				_glProgramUniformMatrix3x4dv = (Delegates.glProgramUniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x4dv"), typeof(Delegates.glProgramUniformMatrix3x4dv));
				_glProgramUniformMatrix4x3dv = (Delegates.glProgramUniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x3dv"), typeof(Delegates.glProgramUniformMatrix4x3dv));
				_glValidateProgramPipeline = (Delegates.glValidateProgramPipeline)Marshal.GetDelegateForFunctionPointer(getProcAddress("glValidateProgramPipeline"), typeof(Delegates.glValidateProgramPipeline));
				_glGetProgramPipelineInfoLog = (Delegates.glGetProgramPipelineInfoLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramPipelineInfoLog"), typeof(Delegates.glGetProgramPipelineInfoLog));
				_glVertexAttribL1d = (Delegates.glVertexAttribL1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL1d"), typeof(Delegates.glVertexAttribL1d));
				_glVertexAttribL2d = (Delegates.glVertexAttribL2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL2d"), typeof(Delegates.glVertexAttribL2d));
				_glVertexAttribL3d = (Delegates.glVertexAttribL3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL3d"), typeof(Delegates.glVertexAttribL3d));
				_glVertexAttribL4d = (Delegates.glVertexAttribL4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL4d"), typeof(Delegates.glVertexAttribL4d));
				_glVertexAttribL1dv = (Delegates.glVertexAttribL1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL1dv"), typeof(Delegates.glVertexAttribL1dv));
				_glVertexAttribL2dv = (Delegates.glVertexAttribL2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL2dv"), typeof(Delegates.glVertexAttribL2dv));
				_glVertexAttribL3dv = (Delegates.glVertexAttribL3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL3dv"), typeof(Delegates.glVertexAttribL3dv));
				_glVertexAttribL4dv = (Delegates.glVertexAttribL4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL4dv"), typeof(Delegates.glVertexAttribL4dv));
				_glVertexAttribLPointer = (Delegates.glVertexAttribLPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribLPointer"), typeof(Delegates.glVertexAttribLPointer));
				_glGetVertexAttribLdv = (Delegates.glGetVertexAttribLdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribLdv"), typeof(Delegates.glGetVertexAttribLdv));
				_glViewportArrayv = (Delegates.glViewportArrayv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewportArrayv"), typeof(Delegates.glViewportArrayv));
				_glViewportIndexedf = (Delegates.glViewportIndexedf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewportIndexedf"), typeof(Delegates.glViewportIndexedf));
				_glViewportIndexedfv = (Delegates.glViewportIndexedfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewportIndexedfv"), typeof(Delegates.glViewportIndexedfv));
				_glScissorArrayv = (Delegates.glScissorArrayv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissorArrayv"), typeof(Delegates.glScissorArrayv));
				_glScissorIndexed = (Delegates.glScissorIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissorIndexed"), typeof(Delegates.glScissorIndexed));
				_glScissorIndexedv = (Delegates.glScissorIndexedv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissorIndexedv"), typeof(Delegates.glScissorIndexedv));
				_glDepthRangeArrayv = (Delegates.glDepthRangeArrayv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRangeArrayv"), typeof(Delegates.glDepthRangeArrayv));
				_glDepthRangeIndexed = (Delegates.glDepthRangeIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRangeIndexed"), typeof(Delegates.glDepthRangeIndexed));
				_glGetFloati_v = (Delegates.glGetFloati_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFloati_v"), typeof(Delegates.glGetFloati_v));
				_glGetDoublei_v = (Delegates.glGetDoublei_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetDoublei_v"), typeof(Delegates.glGetDoublei_v));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 2))
			{
				_glDrawArraysInstancedBaseInstance = (Delegates.glDrawArraysInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArraysInstancedBaseInstance"), typeof(Delegates.glDrawArraysInstancedBaseInstance));
				_glDrawElementsInstancedBaseInstance = (Delegates.glDrawElementsInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstancedBaseInstance"), typeof(Delegates.glDrawElementsInstancedBaseInstance));
				_glDrawElementsInstancedBaseVertexBaseInstance = (Delegates.glDrawElementsInstancedBaseVertexBaseInstance)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstancedBaseVertexBaseInstance"), typeof(Delegates.glDrawElementsInstancedBaseVertexBaseInstance));
				_glGetInternalformativ = (Delegates.glGetInternalformativ)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInternalformativ"), typeof(Delegates.glGetInternalformativ));
				_glGetActiveAtomicCounterBufferiv = (Delegates.glGetActiveAtomicCounterBufferiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveAtomicCounterBufferiv"), typeof(Delegates.glGetActiveAtomicCounterBufferiv));
				_glBindImageTexture = (Delegates.glBindImageTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindImageTexture"), typeof(Delegates.glBindImageTexture));
				_glMemoryBarrier = (Delegates.glMemoryBarrier)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMemoryBarrier"), typeof(Delegates.glMemoryBarrier));
				_glTexStorage1D = (Delegates.glTexStorage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage1D"), typeof(Delegates.glTexStorage1D));
				_glTexStorage2D = (Delegates.glTexStorage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage2D"), typeof(Delegates.glTexStorage2D));
				_glTexStorage3D = (Delegates.glTexStorage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage3D"), typeof(Delegates.glTexStorage3D));
				_glDrawTransformFeedbackInstanced = (Delegates.glDrawTransformFeedbackInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedbackInstanced"), typeof(Delegates.glDrawTransformFeedbackInstanced));
				_glDrawTransformFeedbackStreamInstanced = (Delegates.glDrawTransformFeedbackStreamInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedbackStreamInstanced"), typeof(Delegates.glDrawTransformFeedbackStreamInstanced));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 3))
			{
				_glClearBufferData = (Delegates.glClearBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferData"), typeof(Delegates.glClearBufferData));
				_glClearBufferSubData = (Delegates.glClearBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferSubData"), typeof(Delegates.glClearBufferSubData));
				_glDispatchCompute = (Delegates.glDispatchCompute)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDispatchCompute"), typeof(Delegates.glDispatchCompute));
				_glDispatchComputeIndirect = (Delegates.glDispatchComputeIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDispatchComputeIndirect"), typeof(Delegates.glDispatchComputeIndirect));
				_glCopyImageSubData = (Delegates.glCopyImageSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyImageSubData"), typeof(Delegates.glCopyImageSubData));
				_glFramebufferParameteri = (Delegates.glFramebufferParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferParameteri"), typeof(Delegates.glFramebufferParameteri));
				_glGetFramebufferParameteriv = (Delegates.glGetFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFramebufferParameteriv"), typeof(Delegates.glGetFramebufferParameteriv));
				_glGetInternalformati64v = (Delegates.glGetInternalformati64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInternalformati64v"), typeof(Delegates.glGetInternalformati64v));
				_glInvalidateTexSubImage = (Delegates.glInvalidateTexSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateTexSubImage"), typeof(Delegates.glInvalidateTexSubImage));
				_glInvalidateTexImage = (Delegates.glInvalidateTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateTexImage"), typeof(Delegates.glInvalidateTexImage));
				_glInvalidateBufferSubData = (Delegates.glInvalidateBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateBufferSubData"), typeof(Delegates.glInvalidateBufferSubData));
				_glInvalidateBufferData = (Delegates.glInvalidateBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateBufferData"), typeof(Delegates.glInvalidateBufferData));
				_glInvalidateFramebuffer = (Delegates.glInvalidateFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateFramebuffer"), typeof(Delegates.glInvalidateFramebuffer));
				_glInvalidateSubFramebuffer = (Delegates.glInvalidateSubFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateSubFramebuffer"), typeof(Delegates.glInvalidateSubFramebuffer));
				_glMultiDrawArraysIndirect = (Delegates.glMultiDrawArraysIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawArraysIndirect"), typeof(Delegates.glMultiDrawArraysIndirect));
				_glMultiDrawElementsIndirect = (Delegates.glMultiDrawElementsIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawElementsIndirect"), typeof(Delegates.glMultiDrawElementsIndirect));
				_glGetProgramInterfaceiv = (Delegates.glGetProgramInterfaceiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramInterfaceiv"), typeof(Delegates.glGetProgramInterfaceiv));
				_glGetProgramResourceIndex = (Delegates.glGetProgramResourceIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceIndex"), typeof(Delegates.glGetProgramResourceIndex));
				_glGetProgramResourceName = (Delegates.glGetProgramResourceName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceName"), typeof(Delegates.glGetProgramResourceName));
				_glGetProgramResourceiv = (Delegates.glGetProgramResourceiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceiv"), typeof(Delegates.glGetProgramResourceiv));
				_glGetProgramResourceLocation = (Delegates.glGetProgramResourceLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceLocation"), typeof(Delegates.glGetProgramResourceLocation));
				_glGetProgramResourceLocationIndex = (Delegates.glGetProgramResourceLocationIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceLocationIndex"), typeof(Delegates.glGetProgramResourceLocationIndex));
				_glShaderStorageBlockBinding = (Delegates.glShaderStorageBlockBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glShaderStorageBlockBinding"), typeof(Delegates.glShaderStorageBlockBinding));
				_glTexBufferRange = (Delegates.glTexBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexBufferRange"), typeof(Delegates.glTexBufferRange));
				_glTexStorage2DMultisample = (Delegates.glTexStorage2DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage2DMultisample"), typeof(Delegates.glTexStorage2DMultisample));
				_glTexStorage3DMultisample = (Delegates.glTexStorage3DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage3DMultisample"), typeof(Delegates.glTexStorage3DMultisample));
				_glTextureView = (Delegates.glTextureView)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureView"), typeof(Delegates.glTextureView));
				_glBindVertexBuffer = (Delegates.glBindVertexBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindVertexBuffer"), typeof(Delegates.glBindVertexBuffer));
				_glVertexAttribFormat = (Delegates.glVertexAttribFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribFormat"), typeof(Delegates.glVertexAttribFormat));
				_glVertexAttribIFormat = (Delegates.glVertexAttribIFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribIFormat"), typeof(Delegates.glVertexAttribIFormat));
				_glVertexAttribLFormat = (Delegates.glVertexAttribLFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribLFormat"), typeof(Delegates.glVertexAttribLFormat));
				_glVertexAttribBinding = (Delegates.glVertexAttribBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribBinding"), typeof(Delegates.glVertexAttribBinding));
				_glVertexBindingDivisor = (Delegates.glVertexBindingDivisor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexBindingDivisor"), typeof(Delegates.glVertexBindingDivisor));
				_glDebugMessageControl = (Delegates.glDebugMessageControl)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDebugMessageControl"), typeof(Delegates.glDebugMessageControl));
				_glDebugMessageInsert = (Delegates.glDebugMessageInsert)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDebugMessageInsert"), typeof(Delegates.glDebugMessageInsert));
				_glDebugMessageCallback = (Delegates.glDebugMessageCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDebugMessageCallback"), typeof(Delegates.glDebugMessageCallback));
				_glGetDebugMessageLog = (Delegates.glGetDebugMessageLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetDebugMessageLog"), typeof(Delegates.glGetDebugMessageLog));
				_glPushDebugGroup = (Delegates.glPushDebugGroup)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPushDebugGroup"), typeof(Delegates.glPushDebugGroup));
				_glPopDebugGroup = (Delegates.glPopDebugGroup)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPopDebugGroup"), typeof(Delegates.glPopDebugGroup));
				_glObjectLabel = (Delegates.glObjectLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glObjectLabel"), typeof(Delegates.glObjectLabel));
				_glGetObjectLabel = (Delegates.glGetObjectLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetObjectLabel"), typeof(Delegates.glGetObjectLabel));
				_glObjectPtrLabel = (Delegates.glObjectPtrLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glObjectPtrLabel"), typeof(Delegates.glObjectPtrLabel));
				_glGetObjectPtrLabel = (Delegates.glGetObjectPtrLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetObjectPtrLabel"), typeof(Delegates.glGetObjectPtrLabel));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 4))
			{
				_glBufferStorage = (Delegates.glBufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBufferStorage"), typeof(Delegates.glBufferStorage));
				_glClearTexImage = (Delegates.glClearTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearTexImage"), typeof(Delegates.glClearTexImage));
				_glClearTexSubImage = (Delegates.glClearTexSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearTexSubImage"), typeof(Delegates.glClearTexSubImage));
				_glBindBuffersBase = (Delegates.glBindBuffersBase)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBuffersBase"), typeof(Delegates.glBindBuffersBase));
				_glBindBuffersRange = (Delegates.glBindBuffersRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBuffersRange"), typeof(Delegates.glBindBuffersRange));
				_glBindTextures = (Delegates.glBindTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTextures"), typeof(Delegates.glBindTextures));
				_glBindSamplers = (Delegates.glBindSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindSamplers"), typeof(Delegates.glBindSamplers));
				_glBindImageTextures = (Delegates.glBindImageTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindImageTextures"), typeof(Delegates.glBindImageTextures));
				_glBindVertexBuffers = (Delegates.glBindVertexBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindVertexBuffers"), typeof(Delegates.glBindVertexBuffers));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 5))
			{
				_glClipControl = (Delegates.glClipControl)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClipControl"), typeof(Delegates.glClipControl));
				_glCreateTransformFeedbacks = (Delegates.glCreateTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateTransformFeedbacks"), typeof(Delegates.glCreateTransformFeedbacks));
				_glTransformFeedbackBufferBase = (Delegates.glTransformFeedbackBufferBase)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTransformFeedbackBufferBase"), typeof(Delegates.glTransformFeedbackBufferBase));
				_glTransformFeedbackBufferRange = (Delegates.glTransformFeedbackBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTransformFeedbackBufferRange"), typeof(Delegates.glTransformFeedbackBufferRange));
				_glGetTransformFeedbackiv = (Delegates.glGetTransformFeedbackiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbackiv"), typeof(Delegates.glGetTransformFeedbackiv));
				_glGetTransformFeedbacki_v = (Delegates.glGetTransformFeedbacki_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbacki_v"), typeof(Delegates.glGetTransformFeedbacki_v));
				_glGetTransformFeedbacki64_v = (Delegates.glGetTransformFeedbacki64_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbacki64_v"), typeof(Delegates.glGetTransformFeedbacki64_v));
				_glCreateBuffers = (Delegates.glCreateBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateBuffers"), typeof(Delegates.glCreateBuffers));
				_glNamedBufferStorage = (Delegates.glNamedBufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedBufferStorage"), typeof(Delegates.glNamedBufferStorage));
				_glNamedBufferData = (Delegates.glNamedBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedBufferData"), typeof(Delegates.glNamedBufferData));
				_glNamedBufferSubData = (Delegates.glNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedBufferSubData"), typeof(Delegates.glNamedBufferSubData));
				_glCopyNamedBufferSubData = (Delegates.glCopyNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyNamedBufferSubData"), typeof(Delegates.glCopyNamedBufferSubData));
				_glClearNamedBufferData = (Delegates.glClearNamedBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedBufferData"), typeof(Delegates.glClearNamedBufferData));
				_glClearNamedBufferSubData = (Delegates.glClearNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedBufferSubData"), typeof(Delegates.glClearNamedBufferSubData));
				_glMapNamedBuffer = (Delegates.glMapNamedBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapNamedBuffer"), typeof(Delegates.glMapNamedBuffer));
				_glMapNamedBufferRange = (Delegates.glMapNamedBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapNamedBufferRange"), typeof(Delegates.glMapNamedBufferRange));
				_glUnmapNamedBuffer = (Delegates.glUnmapNamedBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUnmapNamedBuffer"), typeof(Delegates.glUnmapNamedBuffer));
				_glFlushMappedNamedBufferRange = (Delegates.glFlushMappedNamedBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFlushMappedNamedBufferRange"), typeof(Delegates.glFlushMappedNamedBufferRange));
				_glGetNamedBufferParameteriv = (Delegates.glGetNamedBufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferParameteriv"), typeof(Delegates.glGetNamedBufferParameteriv));
				_glGetNamedBufferParameteri64v = (Delegates.glGetNamedBufferParameteri64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferParameteri64v"), typeof(Delegates.glGetNamedBufferParameteri64v));
				_glGetNamedBufferPointerv = (Delegates.glGetNamedBufferPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferPointerv"), typeof(Delegates.glGetNamedBufferPointerv));
				_glGetNamedBufferSubData = (Delegates.glGetNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferSubData"), typeof(Delegates.glGetNamedBufferSubData));
				_glCreateFramebuffers = (Delegates.glCreateFramebuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateFramebuffers"), typeof(Delegates.glCreateFramebuffers));
				_glNamedFramebufferRenderbuffer = (Delegates.glNamedFramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferRenderbuffer"), typeof(Delegates.glNamedFramebufferRenderbuffer));
				_glNamedFramebufferParameteri = (Delegates.glNamedFramebufferParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferParameteri"), typeof(Delegates.glNamedFramebufferParameteri));
				_glNamedFramebufferTexture = (Delegates.glNamedFramebufferTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferTexture"), typeof(Delegates.glNamedFramebufferTexture));
				_glNamedFramebufferTextureLayer = (Delegates.glNamedFramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferTextureLayer"), typeof(Delegates.glNamedFramebufferTextureLayer));
				_glNamedFramebufferDrawBuffer = (Delegates.glNamedFramebufferDrawBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferDrawBuffer"), typeof(Delegates.glNamedFramebufferDrawBuffer));
				_glNamedFramebufferDrawBuffers = (Delegates.glNamedFramebufferDrawBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferDrawBuffers"), typeof(Delegates.glNamedFramebufferDrawBuffers));
				_glNamedFramebufferReadBuffer = (Delegates.glNamedFramebufferReadBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferReadBuffer"), typeof(Delegates.glNamedFramebufferReadBuffer));
				_glInvalidateNamedFramebufferData = (Delegates.glInvalidateNamedFramebufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateNamedFramebufferData"), typeof(Delegates.glInvalidateNamedFramebufferData));
				_glInvalidateNamedFramebufferSubData = (Delegates.glInvalidateNamedFramebufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateNamedFramebufferSubData"), typeof(Delegates.glInvalidateNamedFramebufferSubData));
				_glClearNamedFramebufferiv = (Delegates.glClearNamedFramebufferiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferiv"), typeof(Delegates.glClearNamedFramebufferiv));
				_glClearNamedFramebufferuiv = (Delegates.glClearNamedFramebufferuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferuiv"), typeof(Delegates.glClearNamedFramebufferuiv));
				_glClearNamedFramebufferfv = (Delegates.glClearNamedFramebufferfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferfv"), typeof(Delegates.glClearNamedFramebufferfv));
				_glClearNamedFramebufferfi = (Delegates.glClearNamedFramebufferfi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferfi"), typeof(Delegates.glClearNamedFramebufferfi));
				_glBlitNamedFramebuffer = (Delegates.glBlitNamedFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlitNamedFramebuffer"), typeof(Delegates.glBlitNamedFramebuffer));
				_glCheckNamedFramebufferStatus = (Delegates.glCheckNamedFramebufferStatus)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCheckNamedFramebufferStatus"), typeof(Delegates.glCheckNamedFramebufferStatus));
				_glGetNamedFramebufferParameteriv = (Delegates.glGetNamedFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedFramebufferParameteriv"), typeof(Delegates.glGetNamedFramebufferParameteriv));
				_glGetNamedFramebufferAttachmentParameteriv = (Delegates.glGetNamedFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedFramebufferAttachmentParameteriv"), typeof(Delegates.glGetNamedFramebufferAttachmentParameteriv));
				_glCreateRenderbuffers = (Delegates.glCreateRenderbuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateRenderbuffers"), typeof(Delegates.glCreateRenderbuffers));
				_glNamedRenderbufferStorage = (Delegates.glNamedRenderbufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedRenderbufferStorage"), typeof(Delegates.glNamedRenderbufferStorage));
				_glNamedRenderbufferStorageMultisample = (Delegates.glNamedRenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedRenderbufferStorageMultisample"), typeof(Delegates.glNamedRenderbufferStorageMultisample));
				_glGetNamedRenderbufferParameteriv = (Delegates.glGetNamedRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedRenderbufferParameteriv"), typeof(Delegates.glGetNamedRenderbufferParameteriv));
				_glCreateTextures = (Delegates.glCreateTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateTextures"), typeof(Delegates.glCreateTextures));
				_glTextureBuffer = (Delegates.glTextureBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureBuffer"), typeof(Delegates.glTextureBuffer));
				_glTextureBufferRange = (Delegates.glTextureBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureBufferRange"), typeof(Delegates.glTextureBufferRange));
				_glTextureStorage1D = (Delegates.glTextureStorage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage1D"), typeof(Delegates.glTextureStorage1D));
				_glTextureStorage2D = (Delegates.glTextureStorage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage2D"), typeof(Delegates.glTextureStorage2D));
				_glTextureStorage3D = (Delegates.glTextureStorage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage3D"), typeof(Delegates.glTextureStorage3D));
				_glTextureStorage2DMultisample = (Delegates.glTextureStorage2DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage2DMultisample"), typeof(Delegates.glTextureStorage2DMultisample));
				_glTextureStorage3DMultisample = (Delegates.glTextureStorage3DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage3DMultisample"), typeof(Delegates.glTextureStorage3DMultisample));
				_glTextureSubImage1D = (Delegates.glTextureSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureSubImage1D"), typeof(Delegates.glTextureSubImage1D));
				_glTextureSubImage2D = (Delegates.glTextureSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureSubImage2D"), typeof(Delegates.glTextureSubImage2D));
				_glTextureSubImage3D = (Delegates.glTextureSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureSubImage3D"), typeof(Delegates.glTextureSubImage3D));
				_glCompressedTextureSubImage1D = (Delegates.glCompressedTextureSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTextureSubImage1D"), typeof(Delegates.glCompressedTextureSubImage1D));
				_glCompressedTextureSubImage2D = (Delegates.glCompressedTextureSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTextureSubImage2D"), typeof(Delegates.glCompressedTextureSubImage2D));
				_glCompressedTextureSubImage3D = (Delegates.glCompressedTextureSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTextureSubImage3D"), typeof(Delegates.glCompressedTextureSubImage3D));
				_glCopyTextureSubImage1D = (Delegates.glCopyTextureSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTextureSubImage1D"), typeof(Delegates.glCopyTextureSubImage1D));
				_glCopyTextureSubImage2D = (Delegates.glCopyTextureSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTextureSubImage2D"), typeof(Delegates.glCopyTextureSubImage2D));
				_glCopyTextureSubImage3D = (Delegates.glCopyTextureSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTextureSubImage3D"), typeof(Delegates.glCopyTextureSubImage3D));
				_glTextureParameterf = (Delegates.glTextureParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterf"), typeof(Delegates.glTextureParameterf));
				_glTextureParameterfv = (Delegates.glTextureParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterfv"), typeof(Delegates.glTextureParameterfv));
				_glTextureParameteri = (Delegates.glTextureParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameteri"), typeof(Delegates.glTextureParameteri));
				_glTextureParameterIiv = (Delegates.glTextureParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterIiv"), typeof(Delegates.glTextureParameterIiv));
				_glTextureParameterIuiv = (Delegates.glTextureParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterIuiv"), typeof(Delegates.glTextureParameterIuiv));
				_glTextureParameteriv = (Delegates.glTextureParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameteriv"), typeof(Delegates.glTextureParameteriv));
				_glGenerateTextureMipmap = (Delegates.glGenerateTextureMipmap)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenerateTextureMipmap"), typeof(Delegates.glGenerateTextureMipmap));
				_glBindTextureUnit = (Delegates.glBindTextureUnit)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTextureUnit"), typeof(Delegates.glBindTextureUnit));
				_glGetTextureImage = (Delegates.glGetTextureImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureImage"), typeof(Delegates.glGetTextureImage));
				_glGetCompressedTextureImage = (Delegates.glGetCompressedTextureImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetCompressedTextureImage"), typeof(Delegates.glGetCompressedTextureImage));
				_glGetTextureLevelParameterfv = (Delegates.glGetTextureLevelParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureLevelParameterfv"), typeof(Delegates.glGetTextureLevelParameterfv));
				_glGetTextureLevelParameteriv = (Delegates.glGetTextureLevelParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureLevelParameteriv"), typeof(Delegates.glGetTextureLevelParameteriv));
				_glGetTextureParameterfv = (Delegates.glGetTextureParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameterfv"), typeof(Delegates.glGetTextureParameterfv));
				_glGetTextureParameterIiv = (Delegates.glGetTextureParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameterIiv"), typeof(Delegates.glGetTextureParameterIiv));
				_glGetTextureParameterIuiv = (Delegates.glGetTextureParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameterIuiv"), typeof(Delegates.glGetTextureParameterIuiv));
				_glGetTextureParameteriv = (Delegates.glGetTextureParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameteriv"), typeof(Delegates.glGetTextureParameteriv));
				_glCreateVertexArrays = (Delegates.glCreateVertexArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateVertexArrays"), typeof(Delegates.glCreateVertexArrays));
				_glDisableVertexArrayAttrib = (Delegates.glDisableVertexArrayAttrib)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisableVertexArrayAttrib"), typeof(Delegates.glDisableVertexArrayAttrib));
				_glEnableVertexArrayAttrib = (Delegates.glEnableVertexArrayAttrib)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnableVertexArrayAttrib"), typeof(Delegates.glEnableVertexArrayAttrib));
				_glVertexArrayElementBuffer = (Delegates.glVertexArrayElementBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayElementBuffer"), typeof(Delegates.glVertexArrayElementBuffer));
				_glVertexArrayVertexBuffer = (Delegates.glVertexArrayVertexBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayVertexBuffer"), typeof(Delegates.glVertexArrayVertexBuffer));
				_glVertexArrayVertexBuffers = (Delegates.glVertexArrayVertexBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayVertexBuffers"), typeof(Delegates.glVertexArrayVertexBuffers));
				_glVertexArrayAttribBinding = (Delegates.glVertexArrayAttribBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribBinding"), typeof(Delegates.glVertexArrayAttribBinding));
				_glVertexArrayAttribFormat = (Delegates.glVertexArrayAttribFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribFormat"), typeof(Delegates.glVertexArrayAttribFormat));
				_glVertexArrayAttribIFormat = (Delegates.glVertexArrayAttribIFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribIFormat"), typeof(Delegates.glVertexArrayAttribIFormat));
				_glVertexArrayAttribLFormat = (Delegates.glVertexArrayAttribLFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribLFormat"), typeof(Delegates.glVertexArrayAttribLFormat));
				_glVertexArrayBindingDivisor = (Delegates.glVertexArrayBindingDivisor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayBindingDivisor"), typeof(Delegates.glVertexArrayBindingDivisor));
				_glGetVertexArrayiv = (Delegates.glGetVertexArrayiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexArrayiv"), typeof(Delegates.glGetVertexArrayiv));
				_glGetVertexArrayIndexediv = (Delegates.glGetVertexArrayIndexediv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexArrayIndexediv"), typeof(Delegates.glGetVertexArrayIndexediv));
				_glGetVertexArrayIndexed64iv = (Delegates.glGetVertexArrayIndexed64iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexArrayIndexed64iv"), typeof(Delegates.glGetVertexArrayIndexed64iv));
				_glCreateSamplers = (Delegates.glCreateSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateSamplers"), typeof(Delegates.glCreateSamplers));
				_glCreateProgramPipelines = (Delegates.glCreateProgramPipelines)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateProgramPipelines"), typeof(Delegates.glCreateProgramPipelines));
				_glCreateQueries = (Delegates.glCreateQueries)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateQueries"), typeof(Delegates.glCreateQueries));
				_glGetQueryBufferObjecti64v = (Delegates.glGetQueryBufferObjecti64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjecti64v"), typeof(Delegates.glGetQueryBufferObjecti64v));
				_glGetQueryBufferObjectiv = (Delegates.glGetQueryBufferObjectiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjectiv"), typeof(Delegates.glGetQueryBufferObjectiv));
				_glGetQueryBufferObjectui64v = (Delegates.glGetQueryBufferObjectui64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjectui64v"), typeof(Delegates.glGetQueryBufferObjectui64v));
				_glGetQueryBufferObjectuiv = (Delegates.glGetQueryBufferObjectuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjectuiv"), typeof(Delegates.glGetQueryBufferObjectuiv));
				_glMemoryBarrierByRegion = (Delegates.glMemoryBarrierByRegion)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMemoryBarrierByRegion"), typeof(Delegates.glMemoryBarrierByRegion));
				_glGetTextureSubImage = (Delegates.glGetTextureSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureSubImage"), typeof(Delegates.glGetTextureSubImage));
				_glGetCompressedTextureSubImage = (Delegates.glGetCompressedTextureSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetCompressedTextureSubImage"), typeof(Delegates.glGetCompressedTextureSubImage));
				_glGetGraphicsResetStatus = (Delegates.glGetGraphicsResetStatus)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetGraphicsResetStatus"), typeof(Delegates.glGetGraphicsResetStatus));
				_glGetnCompressedTexImage = (Delegates.glGetnCompressedTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnCompressedTexImage"), typeof(Delegates.glGetnCompressedTexImage));
				_glGetnTexImage = (Delegates.glGetnTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnTexImage"), typeof(Delegates.glGetnTexImage));
				_glGetnUniformdv = (Delegates.glGetnUniformdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformdv"), typeof(Delegates.glGetnUniformdv));
				_glGetnUniformfv = (Delegates.glGetnUniformfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformfv"), typeof(Delegates.glGetnUniformfv));
				_glGetnUniformiv = (Delegates.glGetnUniformiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformiv"), typeof(Delegates.glGetnUniformiv));
				_glGetnUniformuiv = (Delegates.glGetnUniformuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformuiv"), typeof(Delegates.glGetnUniformuiv));
				_glReadnPixels = (Delegates.glReadnPixels)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReadnPixels"), typeof(Delegates.glReadnPixels));
				_glTextureBarrier = (Delegates.glTextureBarrier)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureBarrier"), typeof(Delegates.glTextureBarrier));
			}

			if (versionMajor > 2 || (versionMajor == 2 && versionMinor >= 0))
			{
				_glUniformMatrix4fvByRef = (Delegates.glUniformMatrix4fvByRef)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4fv"), typeof(Delegates.glUniformMatrix4fvByRef));
			}
		}

		public static void glActiveShaderProgram(uint pipeline, uint program)
		{
			_glActiveShaderProgram(pipeline, program);
		}

		public static void glActiveTexture(uint texture)
		{
			_glActiveTexture(texture);
		}

		public static void glAttachShader(uint program, uint shader)
		{
			_glAttachShader(program, shader);
		}

		public static void glBeginConditionalRender(uint id, uint mode)
		{
			_glBeginConditionalRender(id, mode);
		}

		public static void glBeginQuery(uint target, uint id)
		{
			_glBeginQuery(target, id);
		}

		public static void glBeginQueryIndexed(uint target, uint index, uint id)
		{
			_glBeginQueryIndexed(target, index, id);
		}

		public static void glBeginTransformFeedback(uint primitiveMode)
		{
			_glBeginTransformFeedback(primitiveMode);
		}

		public static void glBindAttribLocation(uint program, uint index, string name)
		{
			_glBindAttribLocation(program, index, name);
		}

		public static void glBindBuffer(uint target, uint buffer)
		{
			_glBindBuffer(target, buffer);
		}

		public static void glBindBufferBase(uint target, uint index, uint buffer)
		{
			_glBindBufferBase(target, index, buffer);
		}

		public static void glBindBufferRange(uint target, uint index, uint buffer, int offset, int size)
		{
			_glBindBufferRange(target, index, buffer, offset, size);
		}

		public static void glBindBuffersBase(uint target, uint first, int count, uint[] buffers)
		{
			_glBindBuffersBase(target, first, count, buffers);
		}

		public static void glBindBuffersRange(uint target, uint first, int count, uint[] buffers, int[] offsets, int[] sizes)
		{
			_glBindBuffersRange(target, first, count, buffers, offsets, sizes);
		}

		public static void glBindFragDataLocation(uint program, uint color, string name)
		{
			_glBindFragDataLocation(program, color, name);
		}

		public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name)
		{
			_glBindFragDataLocationIndexed(program, colorNumber, index, name);
		}

		public static void glBindFramebuffer(uint target, uint framebuffer)
		{
			_glBindFramebuffer(target, framebuffer);
		}

		public static void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format)
		{
			_glBindImageTexture(unit, texture, level, layered, layer, access, format);
		}

		public static void glBindImageTextures(uint first, int count, uint[] textures)
		{
			_glBindImageTextures(first, count, textures);
		}

		public static void glBindProgramPipeline(uint pipeline)
		{
			_glBindProgramPipeline(pipeline);
		}

		public static void glBindRenderbuffer(uint target, uint renderbuffer)
		{
			_glBindRenderbuffer(target, renderbuffer);
		}

		public static void glBindSampler(uint unit, uint sampler)
		{
			_glBindSampler(unit, sampler);
		}

		public static void glBindSamplers(uint first, int count, uint[] samplers)
		{
			_glBindSamplers(first, count, samplers);
		}

		public static void glBindTexture(uint target, uint texture)
		{
			_glBindTexture(target, texture);
		}

		public static void glBindTextures(uint first, int count, uint[] textures)
		{
			_glBindTextures(first, count, textures);
		}

		public static void glBindTextureUnit(uint unit, uint texture)
		{
			_glBindTextureUnit(unit, texture);
		}

		public static void glBindTransformFeedback(uint target, uint id)
		{
			_glBindTransformFeedback(target, id);
		}

		public static void glBindVertexArray(uint array)
		{
			_glBindVertexArray(array);
		}

		public static void glBindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride)
		{
			_glBindVertexBuffer(bindingindex, buffer, offset, stride);
		}

		public static void glBindVertexBuffers(uint first, int count, uint[] buffers, int[] offsets, int[] strides)
		{
			_glBindVertexBuffers(first, count, buffers, offsets, strides);
		}

		public static void glBlendColor(float red, float green, float blue, float alpha)
		{
			_glBlendColor(red, green, blue, alpha);
		}

		public static void glBlendEquation(uint mode)
		{
			_glBlendEquation(mode);
		}

		public static void glBlendEquationi(uint buf, uint mode)
		{
			_glBlendEquationi(buf, mode);
		}

		public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha)
		{
			_glBlendEquationSeparate(modeRGB, modeAlpha);
		}

		public static void glBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha)
		{
			_glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
		}

		public static void glBlendFunc(uint sfactor, uint dfactor)
		{
			_glBlendFunc(sfactor, dfactor);
		}

		public static void glBlendFunci(uint buf, uint src, uint dst)
		{
			_glBlendFunci(buf, src, dst);
		}

		public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
			_glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}

		public static void glBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
		{
			_glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}

		public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			_glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

		public static void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			_glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

		public static void glBufferData(uint target, int size, IntPtr data, uint usage)
		{
			_glBufferData(target, size, data, usage);
		}

		public static void glBufferStorage(uint target, int size, IntPtr data, uint flags)
		{
			_glBufferStorage(target, size, data, flags);
		}

		public static void glBufferSubData(uint target, int offset, int size, IntPtr data)
		{
			_glBufferSubData(target, offset, size, data);
		}

		public static uint glCheckFramebufferStatus(uint target)
		{
			return _glCheckFramebufferStatus(target);
		}

		public static uint glCheckNamedFramebufferStatus(uint framebuffer, uint target)
		{
			return _glCheckNamedFramebufferStatus(framebuffer, target);
		}

		public static void glClampColor(uint target, uint clamp)
		{
			_glClampColor(target, clamp);
		}

		public static void glClear(uint mask)
		{
			_glClear(mask);
		}

		public static void glClearBufferData(uint target, uint internalformat, uint format, uint type, IntPtr data)
		{
			_glClearBufferData(target, internalformat, format, type, data);
		}

		public static void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil)
		{
			_glClearBufferfi(buffer, drawbuffer, depth, stencil);
		}

		public static void glClearBufferfv(uint buffer, int drawbuffer, float[] value)
		{
			_glClearBufferfv(buffer, drawbuffer, value);
		}

		public static void glClearBufferiv(uint buffer, int drawbuffer, int[] value)
		{
			_glClearBufferiv(buffer, drawbuffer, value);
		}

		public static void glClearBufferSubData(uint target, uint internalformat, int offset, int size, uint format, uint type, IntPtr data)
		{
			_glClearBufferSubData(target, internalformat, offset, size, format, type, data);
		}

		public static void glClearBufferuiv(uint buffer, int drawbuffer, uint[] value)
		{
			_glClearBufferuiv(buffer, drawbuffer, value);
		}

		public static void glClearColor(float red, float green, float blue, float alpha)
		{
			_glClearColor(red, green, blue, alpha);
		}

		public static void glClearDepth(double depth)
		{
			_glClearDepth(depth);
		}

		public static void glClearDepthf(float d)
		{
			_glClearDepthf(d);
		}

		public static void glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, IntPtr data)
		{
			_glClearNamedBufferData(buffer, internalformat, format, type, data);
		}

		public static void glClearNamedBufferSubData(uint buffer, uint internalformat, int offset, int size, uint format, uint type, IntPtr data)
		{
			_glClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
		}

		public static void glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil)
		{
			_glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
		}

		public static void glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float[] value)
		{
			_glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);
		}

		public static void glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int[] value)
		{
			_glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);
		}

		public static void glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint[] value)
		{
			_glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);
		}

		public static void glClearStencil(int s)
		{
			_glClearStencil(s);
		}

		public static void glClearTexImage(uint texture, int level, uint format, uint type, IntPtr data)
		{
			_glClearTexImage(texture, level, format, type, data);
		}

		public static void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data)
		{
			_glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}

		public static uint glClientWaitSync(IntPtr sync, uint flags, ulong timeout)
		{
			return _glClientWaitSync(sync, flags, timeout);
		}

		public static void glClipControl(uint origin, uint depth)
		{
			_glClipControl(origin, depth);
		}

		public static void glColorMask(bool red, bool green, bool blue, bool alpha)
		{
			_glColorMask(red, green, blue, alpha);
		}

		public static void glColorMaski(uint index, bool r, bool g, bool b, bool a)
		{
			_glColorMaski(index, r, g, b, a);
		}

		public static void glCompileShader(uint shader)
		{
			_glCompileShader(shader);
		}

		public static void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data)
		{
			_glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
		}

		public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data)
		{
			_glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}

		public static void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
		{
			_glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
		}

		public static void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data)
		{
			_glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
		}

		public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data)
		{
			_glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}

		public static void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data)
		{
			_glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}

		public static void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data)
		{
			_glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
		}

		public static void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data)
		{
			_glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
		}

		public static void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data)
		{
			_glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}

		public static void glCopyBufferSubData(uint readTarget, uint writeTarget, int readOffset, int writeOffset, int size)
		{
			_glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
		}

		public static void glCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			_glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}

		public static void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size)
		{
			_glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
		}

		public static void glCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border)
		{
			_glCopyTexImage1D(target, level, internalformat, x, y, width, border);
		}

		public static void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
			_glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}

		public static void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width)
		{
			_glCopyTexSubImage1D(target, level, xoffset, x, y, width);
		}

		public static void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			_glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}

		public static void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			_glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}

		public static void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width)
		{
			_glCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
		}

		public static void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			_glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
		}

		public static void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			_glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
		}

		public static void glCreateBuffers(int n, uint[] buffers)
		{
			_glCreateBuffers(n, buffers);
		}

		public static void glCreateFramebuffers(int n, uint[] framebuffers)
		{
			_glCreateFramebuffers(n, framebuffers);
		}

		public static uint glCreateProgram()
		{
			return _glCreateProgram();
		}

		public static void glCreateProgramPipelines(int n, uint[] pipelines)
		{
			_glCreateProgramPipelines(n, pipelines);
		}

		public static void glCreateQueries(uint target, int n, uint[] ids)
		{
			_glCreateQueries(target, n, ids);
		}

		public static void glCreateRenderbuffers(int n, uint[] renderbuffers)
		{
			_glCreateRenderbuffers(n, renderbuffers);
		}

		public static void glCreateSamplers(int n, uint[] samplers)
		{
			_glCreateSamplers(n, samplers);
		}

		public static uint glCreateShader(uint type)
		{
			return _glCreateShader(type);
		}

		public static uint glCreateShaderProgramv(uint type, int count, string[] strings)
		{
			return _glCreateShaderProgramv(type, count, strings);
		}

		public static void glCreateTextures(uint target, int n, uint[] textures)
		{
			_glCreateTextures(target, n, textures);
		}

		public static void glCreateTransformFeedbacks(int n, uint[] ids)
		{
			_glCreateTransformFeedbacks(n, ids);
		}

		public static void glCreateVertexArrays(int n, uint[] arrays)
		{
			_glCreateVertexArrays(n, arrays);
		}

		public static void glCullFace(uint mode)
		{
			_glCullFace(mode);
		}

		public static void glDebugMessageCallback(DebugProc callback, IntPtr userParam)
		{
			_glDebugMessageCallback(callback, userParam);
		}

		public static void glDebugMessageControl(uint source, uint type, uint severity, int count, uint[] ids, bool enabled)
		{
			_glDebugMessageControl(source, type, severity, count, ids, enabled);
		}

		public static void glDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, string buf)
		{
			_glDebugMessageInsert(source, type, id, severity, length, buf);
		}

		public static void glDeleteBuffers(int n, uint[] buffers)
		{
			_glDeleteBuffers(n, buffers);
		}

		public static void glDeleteBuffer(uint handle)
		{
			var temp = new uint[] { handle };
			glDeleteBuffers(1, temp);
		}

		public static void glDeleteFramebuffers(int n, uint[] framebuffers)
		{
			_glDeleteFramebuffers(n, framebuffers);
		}

		public static void glDeleteFramebuffer(uint handle)
		{
			var temp = new uint[] { handle };
			glDeleteFramebuffers(1, temp);
		}

		public static void glDeleteProgram(uint program)
		{
			_glDeleteProgram(program);
		}

		public static void glDeleteProgramPipelines(int n, uint[] pipelines)
		{
			_glDeleteProgramPipelines(n, pipelines);
		}

		public static void glDeleteProgramPipeline(uint handle)
		{
			var temp = new uint[] { handle };
			glDeleteProgramPipelines(1, temp);
		}

		public static void glDeleteQueries(int n, uint[] ids)
		{
			_glDeleteQueries(n, ids);
		}

		public static void glDeleteQuerie(uint handle)
		{
			var temp = new uint[] { handle };
			glDeleteQueries(1, temp);
		}

		public static void glDeleteRenderbuffers(int n, uint[] renderbuffers)
		{
			_glDeleteRenderbuffers(n, renderbuffers);
		}

		public static void glDeleteRenderbuffer(uint handle)
		{
			var temp = new uint[] { handle };
			glDeleteRenderbuffers(1, temp);
		}

		public static void glDeleteSamplers(int count, uint[] samplers)
		{
			_glDeleteSamplers(count, samplers);
		}

		public static void glDeleteSampler(uint handle)
		{
			var temp = new uint[] { handle };
			glDeleteSamplers(1, temp);
		}

		public static void glDeleteShader(uint shader)
		{
			_glDeleteShader(shader);
		}

		public static void glDeleteSync(IntPtr sync)
		{
			_glDeleteSync(sync);
		}

		public static void glDeleteTextures(int n, uint[] textures)
		{
			_glDeleteTextures(n, textures);
		}

		public static void glDeleteTexture(uint handle)
		{
			var temp = new uint[] { handle };
			glDeleteTextures(1, temp);
		}

		public static void glDeleteTransformFeedbacks(int n, uint[] ids)
		{
			_glDeleteTransformFeedbacks(n, ids);
		}

		public static void glDeleteTransformFeedback(uint handle)
		{
			var temp = new uint[] { handle };
			glDeleteTransformFeedbacks(1, temp);
		}

		public static void glDeleteVertexArrays(int n, uint[] arrays)
		{
			_glDeleteVertexArrays(n, arrays);
		}

		public static void glDeleteVertexArray(uint handle)
		{
			var temp = new uint[] { handle };
			glDeleteVertexArrays(1, temp);
		}

		public static void glDepthFunc(uint func)
		{
			_glDepthFunc(func);
		}

		public static void glDepthMask(bool flag)
		{
			_glDepthMask(flag);
		}

		public static void glDepthRange(double near, double far)
		{
			_glDepthRange(near, far);
		}

		public static void glDepthRangeArrayv(uint first, int count, double[] v)
		{
			_glDepthRangeArrayv(first, count, v);
		}

		public static void glDepthRangef(float n, float f)
		{
			_glDepthRangef(n, f);
		}

		public static void glDepthRangeIndexed(uint index, double n, double f)
		{
			_glDepthRangeIndexed(index, n, f);
		}

		public static void glDetachShader(uint program, uint shader)
		{
			_glDetachShader(program, shader);
		}

		public static void glDisable(uint cap)
		{
			_glDisable(cap);
		}

		public static void glDisablei(uint target, uint index)
		{
			_glDisablei(target, index);
		}

		public static void glDisableVertexArrayAttrib(uint vaobj, uint index)
		{
			_glDisableVertexArrayAttrib(vaobj, index);
		}

		public static void glDisableVertexAttribArray(uint index)
		{
			_glDisableVertexAttribArray(index);
		}

		public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
		{
			_glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
		}

		public static void glDispatchComputeIndirect(int indirect)
		{
			_glDispatchComputeIndirect(indirect);
		}

		public static void glDrawArrays(uint mode, int first, int count)
		{
			_glDrawArrays(mode, first, count);
		}

		public static void glDrawArraysIndirect(uint mode, IntPtr indirect)
		{
			_glDrawArraysIndirect(mode, indirect);
		}

		public static void glDrawArraysInstanced(uint mode, int first, int count, int instancecount)
		{
			_glDrawArraysInstanced(mode, first, count, instancecount);
		}

		public static void glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance)
		{
			_glDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
		}

		public static void glDrawBuffer(uint buf)
		{
			_glDrawBuffer(buf);
		}

		public static void glDrawBuffers(int n, uint[] bufs)
		{
			_glDrawBuffers(n, bufs);
		}

		public static void glDrawElements(uint mode, int count, uint type, IntPtr indices)
		{
			_glDrawElements(mode, count, type, indices);
		}

		public static void glDrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int basevertex)
		{
			_glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
		}

		public static void glDrawElementsIndirect(uint mode, uint type, IntPtr indirect)
		{
			_glDrawElementsIndirect(mode, type, indirect);
		}

		public static void glDrawElementsInstanced(uint mode, int count, uint type, IntPtr indices, int instancecount)
		{
			_glDrawElementsInstanced(mode, count, type, indices, instancecount);
		}

		public static void glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance)
		{
			_glDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
		}

		public static void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex)
		{
			_glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
		}

		public static void glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance)
		{
			_glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}

		public static void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices)
		{
			_glDrawRangeElements(mode, start, end, count, type, indices);
		}

		public static void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex)
		{
			_glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
		}

		public static void glDrawTransformFeedback(uint mode, uint id)
		{
			_glDrawTransformFeedback(mode, id);
		}

		public static void glDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount)
		{
			_glDrawTransformFeedbackInstanced(mode, id, instancecount);
		}

		public static void glDrawTransformFeedbackStream(uint mode, uint id, uint stream)
		{
			_glDrawTransformFeedbackStream(mode, id, stream);
		}

		public static void glDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount)
		{
			_glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
		}

		public static void glEnable(uint cap)
		{
			_glEnable(cap);
		}

		public static void glEnablei(uint target, uint index)
		{
			_glEnablei(target, index);
		}

		public static void glEnableVertexArrayAttrib(uint vaobj, uint index)
		{
			_glEnableVertexArrayAttrib(vaobj, index);
		}

		public static void glEnableVertexAttribArray(uint index)
		{
			_glEnableVertexAttribArray(index);
		}

		public static void glEndConditionalRender()
		{
			_glEndConditionalRender();
		}

		public static void glEndQuery(uint target)
		{
			_glEndQuery(target);
		}

		public static void glEndQueryIndexed(uint target, uint index)
		{
			_glEndQueryIndexed(target, index);
		}

		public static void glEndTransformFeedback()
		{
			_glEndTransformFeedback();
		}

		public static IntPtr glFenceSync(uint condition, uint flags)
		{
			return _glFenceSync(condition, flags);
		}

		public static void glFinish()
		{
			_glFinish();
		}

		public static void glFlush()
		{
			_glFlush();
		}

		public static void glFlushMappedBufferRange(uint target, int offset, int length)
		{
			_glFlushMappedBufferRange(target, offset, length);
		}

		public static void glFlushMappedNamedBufferRange(uint buffer, int offset, int length)
		{
			_glFlushMappedNamedBufferRange(buffer, offset, length);
		}

		public static void glFramebufferParameteri(uint target, uint pname, int param)
		{
			_glFramebufferParameteri(target, pname, param);
		}

		public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			_glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		}

		public static void glFramebufferTexture(uint target, uint attachment, uint texture, int level)
		{
			_glFramebufferTexture(target, attachment, texture, level);
		}

		public static void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			_glFramebufferTexture1D(target, attachment, textarget, texture, level);
		}

		public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			_glFramebufferTexture2D(target, attachment, textarget, texture, level);
		}

		public static void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
			_glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
		}

		public static void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer)
		{
			_glFramebufferTextureLayer(target, attachment, texture, level, layer);
		}

		public static void glFrontFace(uint mode)
		{
			_glFrontFace(mode);
		}

		public static void glGenBuffers(int n, uint[] buffers)
		{
			_glGenBuffers(n, buffers);
		}

		public static uint glGenBuffer()
		{
			var temp = new uint[1];
			glGenBuffers(1, temp);
			return temp[0];
		}

		public static void glGenerateMipmap(uint target)
		{
			_glGenerateMipmap(target);
		}

		public static void glGenerateTextureMipmap(uint texture)
		{
			_glGenerateTextureMipmap(texture);
		}

		public static void glGenFramebuffers(int n, uint[] framebuffers)
		{
			_glGenFramebuffers(n, framebuffers);
		}

		public static uint glGenFramebuffer()
		{
			var temp = new uint[1];
			glGenFramebuffers(1, temp);
			return temp[0];
		}

		public static void glGenProgramPipelines(int n, uint[] pipelines)
		{
			_glGenProgramPipelines(n, pipelines);
		}

		public static uint glGenProgramPipeline()
		{
			var temp = new uint[1];
			glGenProgramPipelines(1, temp);
			return temp[0];
		}

		public static void glGenQueries(int n, uint[] ids)
		{
			_glGenQueries(n, ids);
		}

		public static uint glGenQuerie()
		{
			var temp = new uint[1];
			glGenQueries(1, temp);
			return temp[0];
		}

		public static void glGenRenderbuffers(int n, uint[] renderbuffers)
		{
			_glGenRenderbuffers(n, renderbuffers);
		}

		public static uint glGenRenderbuffer()
		{
			var temp = new uint[1];
			glGenRenderbuffers(1, temp);
			return temp[0];
		}

		public static void glGenSamplers(int count, uint[] samplers)
		{
			_glGenSamplers(count, samplers);
		}

		public static uint glGenSampler()
		{
			var temp = new uint[1];
			glGenSamplers(1, temp);
			return temp[0];
		}

		public static void glGenTextures(int n, uint[] textures)
		{
			_glGenTextures(n, textures);
		}

		public static uint glGenTexture()
		{
			var temp = new uint[1];
			glGenTextures(1, temp);
			return temp[0];
		}

		public static void glGenTransformFeedbacks(int n, uint[] ids)
		{
			_glGenTransformFeedbacks(n, ids);
		}

		public static uint glGenTransformFeedback()
		{
			var temp = new uint[1];
			glGenTransformFeedbacks(1, temp);
			return temp[0];
		}

		public static void glGenVertexArrays(int n, uint[] arrays)
		{
			_glGenVertexArrays(n, arrays);
		}

		public static uint glGenVertexArray()
		{
			var temp = new uint[1];
			glGenVertexArrays(1, temp);
			return temp[0];
		}

		public static void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int[] @params)
		{
			_glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, @params);
		}

		public static void glGetActiveAttrib(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name)
		{
			_glGetActiveAttrib(program, index, bufSize, length, size, type, name);
		}

		public static void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int[] length, StringBuilder name)
		{
			_glGetActiveSubroutineName(program, shadertype, index, bufsize, length, name);
		}

		public static void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int[] values)
		{
			_glGetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
		}

		public static void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int[] length, StringBuilder name)
		{
			_glGetActiveSubroutineUniformName(program, shadertype, index, bufsize, length, name);
		}

		public static void glGetActiveUniform(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name)
		{
			_glGetActiveUniform(program, index, bufSize, length, size, type, name);
		}

		public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int[] @params)
		{
			_glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params);
		}

		public static void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int[] length, StringBuilder uniformBlockName)
		{
			_glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
		}

		public static void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int[] length, StringBuilder uniformName)
		{
			_glGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);
		}

		public static void glGetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] @params)
		{
			_glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params);
		}

		public static void glGetAttachedShaders(uint program, int maxCount, int[] count, uint[] shaders)
		{
			_glGetAttachedShaders(program, maxCount, count, shaders);
		}

		public static int glGetAttribLocation(uint program, string name)
		{
			return _glGetAttribLocation(program, name);
		}

		public static void glGetBooleani_v(uint target, uint index, bool[] data)
		{
			_glGetBooleani_v(target, index, data);
		}

		public static void glGetBooleanv(uint pname, bool[] data)
		{
			_glGetBooleanv(pname, data);
		}

		public static void glGetBufferParameteri64v(uint target, uint pname, long[] @params)
		{
			_glGetBufferParameteri64v(target, pname, @params);
		}

		public static void glGetBufferParameteriv(uint target, uint pname, int[] @params)
		{
			_glGetBufferParameteriv(target, pname, @params);
		}

		public static void glGetBufferPointerv(uint target, uint pname, IntPtr[] @params)
		{
			_glGetBufferPointerv(target, pname, @params);
		}

		public static void glGetBufferSubData(uint target, int offset, int size, IntPtr data)
		{
			_glGetBufferSubData(target, offset, size, data);
		}

		public static void glGetCompressedTexImage(uint target, int level, IntPtr img)
		{
			_glGetCompressedTexImage(target, level, img);
		}

		public static void glGetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels)
		{
			_glGetCompressedTextureImage(texture, level, bufSize, pixels);
		}

		public static void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels)
		{
			_glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
		}

		public static uint glGetDebugMessageLog(uint count, int bufSize, uint[] sources, uint[] types, uint[] ids, uint[] severities, int[] lengths, StringBuilder messageLog)
		{
			return _glGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
		}

		public static void glGetDoublei_v(uint target, uint index, double[] data)
		{
			_glGetDoublei_v(target, index, data);
		}

		public static void glGetDoublev(uint pname, double[] data)
		{
			_glGetDoublev(pname, data);
		}

		public static uint glGetError()
		{
			return _glGetError();
		}

		public static void glGetFloati_v(uint target, uint index, float[] data)
		{
			_glGetFloati_v(target, index, data);
		}

		public static void glGetFloatv(uint pname, float[] data)
		{
			_glGetFloatv(pname, data);
		}

		public static int glGetFragDataIndex(uint program, string name)
		{
			return _glGetFragDataIndex(program, name);
		}

		public static int glGetFragDataLocation(uint program, string name)
		{
			return _glGetFragDataLocation(program, name);
		}

		public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int[] @params)
		{
			_glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
		}

		public static void glGetFramebufferParameteriv(uint target, uint pname, int[] @params)
		{
			_glGetFramebufferParameteriv(target, pname, @params);
		}

		public static uint glGetGraphicsResetStatus()
		{
			return _glGetGraphicsResetStatus();
		}

		public static void glGetInteger64i_v(uint target, uint index, long[] data)
		{
			_glGetInteger64i_v(target, index, data);
		}

		public static void glGetInteger64v(uint pname, long[] data)
		{
			_glGetInteger64v(pname, data);
		}

		public static void glGetIntegeri_v(uint target, uint index, int[] data)
		{
			_glGetIntegeri_v(target, index, data);
		}

		public static void glGetIntegerv(uint pname, int[] data)
		{
			_glGetIntegerv(pname, data);
		}

		public static void glGetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, long[] @params)
		{
			_glGetInternalformati64v(target, internalformat, pname, bufSize, @params);
		}

		public static void glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int[] @params)
		{
			_glGetInternalformativ(target, internalformat, pname, bufSize, @params);
		}

		public static void glGetMultisamplefv(uint pname, uint index, float[] val)
		{
			_glGetMultisamplefv(pname, index, val);
		}

		public static void glGetNamedBufferParameteri64v(uint buffer, uint pname, long[] @params)
		{
			_glGetNamedBufferParameteri64v(buffer, pname, @params);
		}

		public static void glGetNamedBufferParameteriv(uint buffer, uint pname, int[] @params)
		{
			_glGetNamedBufferParameteriv(buffer, pname, @params);
		}

		public static void glGetNamedBufferPointerv(uint buffer, uint pname, IntPtr[] @params)
		{
			_glGetNamedBufferPointerv(buffer, pname, @params);
		}

		public static void glGetNamedBufferSubData(uint buffer, int offset, int size, IntPtr data)
		{
			_glGetNamedBufferSubData(buffer, offset, size, data);
		}

		public static void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int[] @params)
		{
			_glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, @params);
		}

		public static void glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int[] param)
		{
			_glGetNamedFramebufferParameteriv(framebuffer, pname, param);
		}

		public static void glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int[] @params)
		{
			_glGetNamedRenderbufferParameteriv(renderbuffer, pname, @params);
		}

		public static void glGetnCompressedTexImage(uint target, int lod, int bufSize, IntPtr pixels)
		{
			_glGetnCompressedTexImage(target, lod, bufSize, pixels);
		}

		public static void glGetnTexImage(uint target, int level, uint format, uint type, int bufSize, IntPtr pixels)
		{
			_glGetnTexImage(target, level, format, type, bufSize, pixels);
		}

		public static void glGetnUniformdv(uint program, int location, int bufSize, double[] @params)
		{
			_glGetnUniformdv(program, location, bufSize, @params);
		}

		public static void glGetnUniformfv(uint program, int location, int bufSize, float[] @params)
		{
			_glGetnUniformfv(program, location, bufSize, @params);
		}

		public static void glGetnUniformiv(uint program, int location, int bufSize, int[] @params)
		{
			_glGetnUniformiv(program, location, bufSize, @params);
		}

		public static void glGetnUniformuiv(uint program, int location, int bufSize, uint[] @params)
		{
			_glGetnUniformuiv(program, location, bufSize, @params);
		}

		public static void glGetObjectLabel(uint identifier, uint name, int bufSize, int[] length, StringBuilder label)
		{
			_glGetObjectLabel(identifier, name, bufSize, length, label);
		}

		public static void glGetObjectPtrLabel(IntPtr ptr, int bufSize, int[] length, StringBuilder label)
		{
			_glGetObjectPtrLabel(ptr, bufSize, length, label);
		}

		public static void glGetPointerv(uint pname, IntPtr[] @params)
		{
			_glGetPointerv(pname, @params);
		}

		public static void glGetProgramBinary(uint program, int bufSize, int[] length, uint[] binaryFormat, IntPtr binary)
		{
			_glGetProgramBinary(program, bufSize, length, binaryFormat, binary);
		}

		public static void glGetProgramInfoLog(uint program, int bufSize, out int length, StringBuilder infoLog)
		{
			_glGetProgramInfoLog(program, bufSize, out length, infoLog);
		}

		public static void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int[] @params)
		{
			_glGetProgramInterfaceiv(program, programInterface, pname, @params);
		}

		public static void glGetProgramiv(uint program, uint pname, out int @params)
		{
			_glGetProgramiv(program, pname, out @params);
		}

		public static void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int[] length, StringBuilder infoLog)
		{
			_glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
		}

		public static void glGetProgramPipelineiv(uint pipeline, uint pname, int[] @params)
		{
			_glGetProgramPipelineiv(pipeline, pname, @params);
		}

		public static uint glGetProgramResourceIndex(uint program, uint programInterface, string name)
		{
			return _glGetProgramResourceIndex(program, programInterface, name);
		}

		public static void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint[] props, int bufSize, int[] length, int[] @params)
		{
			_glGetProgramResourceiv(program, programInterface, index, propCount, props, bufSize, length, @params);
		}

		public static int glGetProgramResourceLocation(uint program, uint programInterface, string name)
		{
			return _glGetProgramResourceLocation(program, programInterface, name);
		}

		public static int glGetProgramResourceLocationIndex(uint program, uint programInterface, string name)
		{
			return _glGetProgramResourceLocationIndex(program, programInterface, name);
		}

		public static void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int[] length, StringBuilder name)
		{
			_glGetProgramResourceName(program, programInterface, index, bufSize, length, name);
		}

		public static void glGetProgramStageiv(uint program, uint shadertype, uint pname, int[] values)
		{
			_glGetProgramStageiv(program, shadertype, pname, values);
		}

		public static void glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int offset)
		{
			_glGetQueryBufferObjecti64v(id, buffer, pname, offset);
		}

		public static void glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, int offset)
		{
			_glGetQueryBufferObjectiv(id, buffer, pname, offset);
		}

		public static void glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int offset)
		{
			_glGetQueryBufferObjectui64v(id, buffer, pname, offset);
		}

		public static void glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int offset)
		{
			_glGetQueryBufferObjectuiv(id, buffer, pname, offset);
		}

		public static void glGetQueryIndexediv(uint target, uint index, uint pname, int[] @params)
		{
			_glGetQueryIndexediv(target, index, pname, @params);
		}

		public static void glGetQueryiv(uint target, uint pname, int[] @params)
		{
			_glGetQueryiv(target, pname, @params);
		}

		public static void glGetQueryObjecti64v(uint id, uint pname, long[] @params)
		{
			_glGetQueryObjecti64v(id, pname, @params);
		}

		public static void glGetQueryObjectiv(uint id, uint pname, int[] @params)
		{
			_glGetQueryObjectiv(id, pname, @params);
		}

		public static void glGetQueryObjectui64v(uint id, uint pname, ulong[] @params)
		{
			_glGetQueryObjectui64v(id, pname, @params);
		}

		public static void glGetQueryObjectuiv(uint id, uint pname, uint[] @params)
		{
			_glGetQueryObjectuiv(id, pname, @params);
		}

		public static void glGetRenderbufferParameteriv(uint target, uint pname, int[] @params)
		{
			_glGetRenderbufferParameteriv(target, pname, @params);
		}

		public static void glGetSamplerParameterfv(uint sampler, uint pname, float[] @params)
		{
			_glGetSamplerParameterfv(sampler, pname, @params);
		}

		public static void glGetSamplerParameterIiv(uint sampler, uint pname, int[] @params)
		{
			_glGetSamplerParameterIiv(sampler, pname, @params);
		}

		public static void glGetSamplerParameterIuiv(uint sampler, uint pname, uint[] @params)
		{
			_glGetSamplerParameterIuiv(sampler, pname, @params);
		}

		public static void glGetSamplerParameteriv(uint sampler, uint pname, int[] @params)
		{
			_glGetSamplerParameteriv(sampler, pname, @params);
		}

		public static void glGetShaderInfoLog(uint shader, int bufSize, out int length, StringBuilder infoLog)
		{
			_glGetShaderInfoLog(shader, bufSize, out length, infoLog);
		}

		public static void glGetShaderiv(uint shader, uint pname, out int @params)
		{
			_glGetShaderiv(shader, pname, out @params);
		}

		public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int[] range, int[] precision)
		{
			_glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
		}

		public static void glGetShaderSource(uint shader, int bufSize, int[] length, StringBuilder source)
		{
			_glGetShaderSource(shader, bufSize, length, source);
		}

		public static IntPtr glGetString(uint name)
		{
			return _glGetString(name);
		}

		public static IntPtr glGetStringi(uint name, uint index)
		{
			return _glGetStringi(name, index);
		}

		public static uint glGetSubroutineIndex(uint program, uint shadertype, string name)
		{
			return _glGetSubroutineIndex(program, shadertype, name);
		}

		public static int glGetSubroutineUniformLocation(uint program, uint shadertype, string name)
		{
			return _glGetSubroutineUniformLocation(program, shadertype, name);
		}

		public static void glGetSynciv(IntPtr sync, uint pname, int bufSize, int[] length, int[] values)
		{
			_glGetSynciv(sync, pname, bufSize, length, values);
		}

		public static void glGetTexImage(uint target, int level, uint format, uint type, IntPtr pixels)
		{
			_glGetTexImage(target, level, format, type, pixels);
		}

		public static void glGetTexLevelParameterfv(uint target, int level, uint pname, float[] @params)
		{
			_glGetTexLevelParameterfv(target, level, pname, @params);
		}

		public static void glGetTexLevelParameteriv(uint target, int level, uint pname, int[] @params)
		{
			_glGetTexLevelParameteriv(target, level, pname, @params);
		}

		public static void glGetTexParameterfv(uint target, uint pname, float[] @params)
		{
			_glGetTexParameterfv(target, pname, @params);
		}

		public static void glGetTexParameterIiv(uint target, uint pname, int[] @params)
		{
			_glGetTexParameterIiv(target, pname, @params);
		}

		public static void glGetTexParameterIuiv(uint target, uint pname, uint[] @params)
		{
			_glGetTexParameterIuiv(target, pname, @params);
		}

		public static void glGetTexParameteriv(uint target, uint pname, int[] @params)
		{
			_glGetTexParameteriv(target, pname, @params);
		}

		public static void glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels)
		{
			_glGetTextureImage(texture, level, format, type, bufSize, pixels);
		}

		public static void glGetTextureLevelParameterfv(uint texture, int level, uint pname, float[] @params)
		{
			_glGetTextureLevelParameterfv(texture, level, pname, @params);
		}

		public static void glGetTextureLevelParameteriv(uint texture, int level, uint pname, int[] @params)
		{
			_glGetTextureLevelParameteriv(texture, level, pname, @params);
		}

		public static void glGetTextureParameterfv(uint texture, uint pname, float[] @params)
		{
			_glGetTextureParameterfv(texture, pname, @params);
		}

		public static void glGetTextureParameterIiv(uint texture, uint pname, int[] @params)
		{
			_glGetTextureParameterIiv(texture, pname, @params);
		}

		public static void glGetTextureParameterIuiv(uint texture, uint pname, uint[] @params)
		{
			_glGetTextureParameterIuiv(texture, pname, @params);
		}

		public static void glGetTextureParameteriv(uint texture, uint pname, int[] @params)
		{
			_glGetTextureParameteriv(texture, pname, @params);
		}

		public static void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels)
		{
			_glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
		}

		public static void glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int[] param)
		{
			_glGetTransformFeedbacki_v(xfb, pname, index, param);
		}

		public static void glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long[] param)
		{
			_glGetTransformFeedbacki64_v(xfb, pname, index, param);
		}

		public static void glGetTransformFeedbackiv(uint xfb, uint pname, int[] param)
		{
			_glGetTransformFeedbackiv(xfb, pname, param);
		}

		public static void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int[] length, int[] size, uint[] type, StringBuilder name)
		{
			_glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
		}

		public static uint glGetUniformBlockIndex(uint program, string uniformBlockName)
		{
			return _glGetUniformBlockIndex(program, uniformBlockName);
		}

		public static void glGetUniformdv(uint program, int location, double[] @params)
		{
			_glGetUniformdv(program, location, @params);
		}

		public static void glGetUniformfv(uint program, int location, float[] @params)
		{
			_glGetUniformfv(program, location, @params);
		}

		public static void glGetUniformIndices(uint program, int uniformCount, string[] uniformNames, uint[] uniformIndices)
		{
			_glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
		}

		public static void glGetUniformiv(uint program, int location, int[] @params)
		{
			_glGetUniformiv(program, location, @params);
		}

		public static int glGetUniformLocation(uint program, string name)
		{
			return _glGetUniformLocation(program, name);
		}

		public static void glGetUniformSubroutineuiv(uint shadertype, int location, uint[] @params)
		{
			_glGetUniformSubroutineuiv(shadertype, location, @params);
		}

		public static void glGetUniformuiv(uint program, int location, uint[] @params)
		{
			_glGetUniformuiv(program, location, @params);
		}

		public static void glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long[] param)
		{
			_glGetVertexArrayIndexed64iv(vaobj, index, pname, param);
		}

		public static void glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int[] param)
		{
			_glGetVertexArrayIndexediv(vaobj, index, pname, param);
		}

		public static void glGetVertexArrayiv(uint vaobj, uint pname, int[] param)
		{
			_glGetVertexArrayiv(vaobj, pname, param);
		}

		public static void glGetVertexAttribdv(uint index, uint pname, double[] @params)
		{
			_glGetVertexAttribdv(index, pname, @params);
		}

		public static void glGetVertexAttribfv(uint index, uint pname, float[] @params)
		{
			_glGetVertexAttribfv(index, pname, @params);
		}

		public static void glGetVertexAttribIiv(uint index, uint pname, int[] @params)
		{
			_glGetVertexAttribIiv(index, pname, @params);
		}

		public static void glGetVertexAttribIuiv(uint index, uint pname, uint[] @params)
		{
			_glGetVertexAttribIuiv(index, pname, @params);
		}

		public static void glGetVertexAttribiv(uint index, uint pname, int[] @params)
		{
			_glGetVertexAttribiv(index, pname, @params);
		}

		public static void glGetVertexAttribLdv(uint index, uint pname, double[] @params)
		{
			_glGetVertexAttribLdv(index, pname, @params);
		}

		public static void glGetVertexAttribPointerv(uint index, uint pname, IntPtr[] pointer)
		{
			_glGetVertexAttribPointerv(index, pname, pointer);
		}

		public static void glHint(uint target, uint mode)
		{
			_glHint(target, mode);
		}

		public static void glInvalidateBufferData(uint buffer)
		{
			_glInvalidateBufferData(buffer);
		}

		public static void glInvalidateBufferSubData(uint buffer, int offset, int length)
		{
			_glInvalidateBufferSubData(buffer, offset, length);
		}

		public static void glInvalidateFramebuffer(uint target, int numAttachments, uint[] attachments)
		{
			_glInvalidateFramebuffer(target, numAttachments, attachments);
		}

		public static void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint[] attachments)
		{
			_glInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
		}

		public static void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint[] attachments, int x, int y, int width, int height)
		{
			_glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
		}

		public static void glInvalidateSubFramebuffer(uint target, int numAttachments, uint[] attachments, int x, int y, int width, int height)
		{
			_glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
		}

		public static void glInvalidateTexImage(uint texture, int level)
		{
			_glInvalidateTexImage(texture, level);
		}

		public static void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
		{
			_glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
		}

		public static bool glIsBuffer(uint buffer)
		{
			return _glIsBuffer(buffer);
		}

		public static bool glIsEnabled(uint cap)
		{
			return _glIsEnabled(cap);
		}

		public static bool glIsEnabledi(uint target, uint index)
		{
			return _glIsEnabledi(target, index);
		}

		public static bool glIsFramebuffer(uint framebuffer)
		{
			return _glIsFramebuffer(framebuffer);
		}

		public static bool glIsProgram(uint program)
		{
			return _glIsProgram(program);
		}

		public static bool glIsProgramPipeline(uint pipeline)
		{
			return _glIsProgramPipeline(pipeline);
		}

		public static bool glIsQuery(uint id)
		{
			return _glIsQuery(id);
		}

		public static bool glIsRenderbuffer(uint renderbuffer)
		{
			return _glIsRenderbuffer(renderbuffer);
		}

		public static bool glIsSampler(uint sampler)
		{
			return _glIsSampler(sampler);
		}

		public static bool glIsShader(uint shader)
		{
			return _glIsShader(shader);
		}

		public static bool glIsSync(IntPtr sync)
		{
			return _glIsSync(sync);
		}

		public static bool glIsTexture(uint texture)
		{
			return _glIsTexture(texture);
		}

		public static bool glIsTransformFeedback(uint id)
		{
			return _glIsTransformFeedback(id);
		}

		public static bool glIsVertexArray(uint array)
		{
			return _glIsVertexArray(array);
		}

		public static void glLineWidth(float width)
		{
			_glLineWidth(width);
		}

		public static void glLinkProgram(uint program)
		{
			_glLinkProgram(program);
		}

		public static void glLogicOp(uint opcode)
		{
			_glLogicOp(opcode);
		}

		public static IntPtr glMapBuffer(uint target, uint access)
		{
			return _glMapBuffer(target, access);
		}

		public static IntPtr glMapBufferRange(uint target, int offset, int length, uint access)
		{
			return _glMapBufferRange(target, offset, length, access);
		}

		public static IntPtr glMapNamedBuffer(uint buffer, uint access)
		{
			return _glMapNamedBuffer(buffer, access);
		}

		public static IntPtr glMapNamedBufferRange(uint buffer, int offset, int length, uint access)
		{
			return _glMapNamedBufferRange(buffer, offset, length, access);
		}

		public static void glMemoryBarrier(uint barriers)
		{
			_glMemoryBarrier(barriers);
		}

		public static void glMemoryBarrierByRegion(uint barriers)
		{
			_glMemoryBarrierByRegion(barriers);
		}

		public static void glMinSampleShading(float value)
		{
			_glMinSampleShading(value);
		}

		public static void glMultiDrawArrays(uint mode, int[] first, int[] count, int drawcount)
		{
			_glMultiDrawArrays(mode, first, count, drawcount);
		}

		public static void glMultiDrawArraysIndirect(uint mode, IntPtr indirect, int drawcount, int stride)
		{
			_glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
		}

		public static void glMultiDrawElements(uint mode, int[] count, uint type, IntPtr[] indices, int drawcount)
		{
			_glMultiDrawElements(mode, count, type, indices, drawcount);
		}

		public static void glMultiDrawElementsBaseVertex(uint mode, int[] count, uint type, IntPtr[] indices, int drawcount, int[] basevertex)
		{
			_glMultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
		}

		public static void glMultiDrawElementsIndirect(uint mode, uint type, IntPtr indirect, int drawcount, int stride)
		{
			_glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
		}

		public static void glNamedBufferData(uint buffer, int size, IntPtr data, uint usage)
		{
			_glNamedBufferData(buffer, size, data, usage);
		}

		public static void glNamedBufferStorage(uint buffer, int size, IntPtr data, uint flags)
		{
			_glNamedBufferStorage(buffer, size, data, flags);
		}

		public static void glNamedBufferSubData(uint buffer, int offset, int size, IntPtr data)
		{
			_glNamedBufferSubData(buffer, offset, size, data);
		}

		public static void glNamedFramebufferDrawBuffer(uint framebuffer, uint buf)
		{
			_glNamedFramebufferDrawBuffer(framebuffer, buf);
		}

		public static void glNamedFramebufferDrawBuffers(uint framebuffer, int n, uint[] bufs)
		{
			_glNamedFramebufferDrawBuffers(framebuffer, n, bufs);
		}

		public static void glNamedFramebufferParameteri(uint framebuffer, uint pname, int param)
		{
			_glNamedFramebufferParameteri(framebuffer, pname, param);
		}

		public static void glNamedFramebufferReadBuffer(uint framebuffer, uint src)
		{
			_glNamedFramebufferReadBuffer(framebuffer, src);
		}

		public static void glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			_glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
		}

		public static void glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level)
		{
			_glNamedFramebufferTexture(framebuffer, attachment, texture, level);
		}

		public static void glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer)
		{
			_glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
		}

		public static void glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height)
		{
			_glNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
		}

		public static void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height)
		{
			_glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
		}

		public static void glObjectLabel(uint identifier, uint name, int length, string label)
		{
			_glObjectLabel(identifier, name, length, label);
		}

		public static void glObjectPtrLabel(IntPtr ptr, int length, string label)
		{
			_glObjectPtrLabel(ptr, length, label);
		}

		public static void glPatchParameterfv(uint pname, float[] values)
		{
			_glPatchParameterfv(pname, values);
		}

		public static void glPatchParameteri(uint pname, int value)
		{
			_glPatchParameteri(pname, value);
		}

		public static void glPauseTransformFeedback()
		{
			_glPauseTransformFeedback();
		}

		public static void glPixelStoref(uint pname, float param)
		{
			_glPixelStoref(pname, param);
		}

		public static void glPixelStorei(uint pname, int param)
		{
			_glPixelStorei(pname, param);
		}

		public static void glPointParameterf(uint pname, float param)
		{
			_glPointParameterf(pname, param);
		}

		public static void glPointParameterfv(uint pname, float[] @params)
		{
			_glPointParameterfv(pname, @params);
		}

		public static void glPointParameteri(uint pname, int param)
		{
			_glPointParameteri(pname, param);
		}

		public static void glPointParameteriv(uint pname, int[] @params)
		{
			_glPointParameteriv(pname, @params);
		}

		public static void glPointSize(float size)
		{
			_glPointSize(size);
		}

		public static void glPolygonMode(uint face, uint mode)
		{
			_glPolygonMode(face, mode);
		}

		public static void glPolygonOffset(float factor, float units)
		{
			_glPolygonOffset(factor, units);
		}

		public static void glPopDebugGroup()
		{
			_glPopDebugGroup();
		}

		public static void glPrimitiveRestartIndex(uint index)
		{
			_glPrimitiveRestartIndex(index);
		}

		public static void glProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length)
		{
			_glProgramBinary(program, binaryFormat, binary, length);
		}

		public static void glProgramParameteri(uint program, uint pname, int value)
		{
			_glProgramParameteri(program, pname, value);
		}

		public static void glProgramUniform1d(uint program, int location, double v0)
		{
			_glProgramUniform1d(program, location, v0);
		}

		public static void glProgramUniform1dv(uint program, int location, int count, double[] value)
		{
			_glProgramUniform1dv(program, location, count, value);
		}

		public static void glProgramUniform1f(uint program, int location, float v0)
		{
			_glProgramUniform1f(program, location, v0);
		}

		public static void glProgramUniform1fv(uint program, int location, int count, float[] value)
		{
			_glProgramUniform1fv(program, location, count, value);
		}

		public static void glProgramUniform1i(uint program, int location, int v0)
		{
			_glProgramUniform1i(program, location, v0);
		}

		public static void glProgramUniform1iv(uint program, int location, int count, int[] value)
		{
			_glProgramUniform1iv(program, location, count, value);
		}

		public static void glProgramUniform1ui(uint program, int location, uint v0)
		{
			_glProgramUniform1ui(program, location, v0);
		}

		public static void glProgramUniform1uiv(uint program, int location, int count, uint[] value)
		{
			_glProgramUniform1uiv(program, location, count, value);
		}

		public static void glProgramUniform2d(uint program, int location, double v0, double v1)
		{
			_glProgramUniform2d(program, location, v0, v1);
		}

		public static void glProgramUniform2dv(uint program, int location, int count, double[] value)
		{
			_glProgramUniform2dv(program, location, count, value);
		}

		public static void glProgramUniform2f(uint program, int location, float v0, float v1)
		{
			_glProgramUniform2f(program, location, v0, v1);
		}

		public static void glProgramUniform2fv(uint program, int location, int count, float[] value)
		{
			_glProgramUniform2fv(program, location, count, value);
		}

		public static void glProgramUniform2i(uint program, int location, int v0, int v1)
		{
			_glProgramUniform2i(program, location, v0, v1);
		}

		public static void glProgramUniform2iv(uint program, int location, int count, int[] value)
		{
			_glProgramUniform2iv(program, location, count, value);
		}

		public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1)
		{
			_glProgramUniform2ui(program, location, v0, v1);
		}

		public static void glProgramUniform2uiv(uint program, int location, int count, uint[] value)
		{
			_glProgramUniform2uiv(program, location, count, value);
		}

		public static void glProgramUniform3d(uint program, int location, double v0, double v1, double v2)
		{
			_glProgramUniform3d(program, location, v0, v1, v2);
		}

		public static void glProgramUniform3dv(uint program, int location, int count, double[] value)
		{
			_glProgramUniform3dv(program, location, count, value);
		}

		public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2)
		{
			_glProgramUniform3f(program, location, v0, v1, v2);
		}

		public static void glProgramUniform3fv(uint program, int location, int count, float[] value)
		{
			_glProgramUniform3fv(program, location, count, value);
		}

		public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2)
		{
			_glProgramUniform3i(program, location, v0, v1, v2);
		}

		public static void glProgramUniform3iv(uint program, int location, int count, int[] value)
		{
			_glProgramUniform3iv(program, location, count, value);
		}

		public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2)
		{
			_glProgramUniform3ui(program, location, v0, v1, v2);
		}

		public static void glProgramUniform3uiv(uint program, int location, int count, uint[] value)
		{
			_glProgramUniform3uiv(program, location, count, value);
		}

		public static void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3)
		{
			_glProgramUniform4d(program, location, v0, v1, v2, v3);
		}

		public static void glProgramUniform4dv(uint program, int location, int count, double[] value)
		{
			_glProgramUniform4dv(program, location, count, value);
		}

		public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3)
		{
			_glProgramUniform4f(program, location, v0, v1, v2, v3);
		}

		public static void glProgramUniform4fv(uint program, int location, int count, float[] value)
		{
			_glProgramUniform4fv(program, location, count, value);
		}

		public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3)
		{
			_glProgramUniform4i(program, location, v0, v1, v2, v3);
		}

		public static void glProgramUniform4iv(uint program, int location, int count, int[] value)
		{
			_glProgramUniform4iv(program, location, count, value);
		}

		public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			_glProgramUniform4ui(program, location, v0, v1, v2, v3);
		}

		public static void glProgramUniform4uiv(uint program, int location, int count, uint[] value)
		{
			_glProgramUniform4uiv(program, location, count, value);
		}

		public static void glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			_glProgramUniformMatrix2dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			_glProgramUniformMatrix2fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			_glProgramUniformMatrix2x3dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			_glProgramUniformMatrix2x3fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			_glProgramUniformMatrix2x4dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			_glProgramUniformMatrix2x4fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			_glProgramUniformMatrix3dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			_glProgramUniformMatrix3fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			_glProgramUniformMatrix3x2dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			_glProgramUniformMatrix3x2fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			_glProgramUniformMatrix3x4dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			_glProgramUniformMatrix3x4fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double[] value)
		{
			_glProgramUniformMatrix4dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float[] value)
		{
			_glProgramUniformMatrix4fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double[] value)
		{
			_glProgramUniformMatrix4x2dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float[] value)
		{
			_glProgramUniformMatrix4x2fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double[] value)
		{
			_glProgramUniformMatrix4x3dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float[] value)
		{
			_glProgramUniformMatrix4x3fv(program, location, count, transpose, value);
		}

		public static void glProvokingVertex(uint mode)
		{
			_glProvokingVertex(mode);
		}

		public static void glPushDebugGroup(uint source, uint id, int length, string message)
		{
			_glPushDebugGroup(source, id, length, message);
		}

		public static void glQueryCounter(uint id, uint target)
		{
			_glQueryCounter(id, target);
		}

		public static void glReadBuffer(uint src)
		{
			_glReadBuffer(src);
		}

		public static void glReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data)
		{
			_glReadnPixels(x, y, width, height, format, type, bufSize, data);
		}

		public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels)
		{
			_glReadPixels(x, y, width, height, format, type, pixels);
		}

		public static void glReleaseShaderCompiler()
		{
			_glReleaseShaderCompiler();
		}

		public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height)
		{
			_glRenderbufferStorage(target, internalformat, width, height);
		}

		public static void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height)
		{
			_glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
		}

		public static void glResumeTransformFeedback()
		{
			_glResumeTransformFeedback();
		}

		public static void glSampleCoverage(float value, bool invert)
		{
			_glSampleCoverage(value, invert);
		}

		public static void glSampleMaski(uint maskNumber, uint mask)
		{
			_glSampleMaski(maskNumber, mask);
		}

		public static void glSamplerParameterf(uint sampler, uint pname, float param)
		{
			_glSamplerParameterf(sampler, pname, param);
		}

		public static void glSamplerParameterfv(uint sampler, uint pname, float[] param)
		{
			_glSamplerParameterfv(sampler, pname, param);
		}

		public static void glSamplerParameteri(uint sampler, uint pname, int param)
		{
			_glSamplerParameteri(sampler, pname, param);
		}

		public static void glSamplerParameterIiv(uint sampler, uint pname, int[] param)
		{
			_glSamplerParameterIiv(sampler, pname, param);
		}

		public static void glSamplerParameterIuiv(uint sampler, uint pname, uint[] param)
		{
			_glSamplerParameterIuiv(sampler, pname, param);
		}

		public static void glSamplerParameteriv(uint sampler, uint pname, int[] param)
		{
			_glSamplerParameteriv(sampler, pname, param);
		}

		public static void glScissor(int x, int y, int width, int height)
		{
			_glScissor(x, y, width, height);
		}

		public static void glScissorArrayv(uint first, int count, int[] v)
		{
			_glScissorArrayv(first, count, v);
		}

		public static void glScissorIndexed(uint index, int left, int bottom, int width, int height)
		{
			_glScissorIndexed(index, left, bottom, width, height);
		}

		public static void glScissorIndexedv(uint index, int[] v)
		{
			_glScissorIndexedv(index, v);
		}

		public static void glShaderBinary(int count, uint[] shaders, uint binaryformat, IntPtr binary, int length)
		{
			_glShaderBinary(count, shaders, binaryformat, binary, length);
		}

		public static void glShaderSource(uint shader, int count, ref string @string, ref int length)
		{
			_glShaderSource(shader, count, ref @string, ref length);
		}

		public static void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
		{
			_glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
		}

		public static void glStencilFunc(uint func, int @ref, uint mask)
		{
			_glStencilFunc(func, @ref, mask);
		}

		public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask)
		{
			_glStencilFuncSeparate(face, func, @ref, mask);
		}

		public static void glStencilMask(uint mask)
		{
			_glStencilMask(mask);
		}

		public static void glStencilMaskSeparate(uint face, uint mask)
		{
			_glStencilMaskSeparate(face, mask);
		}

		public static void glStencilOp(uint fail, uint zfail, uint zpass)
		{
			_glStencilOp(fail, zfail, zpass);
		}

		public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass)
		{
			_glStencilOpSeparate(face, sfail, dpfail, dppass);
		}

		public static void glTexBuffer(uint target, uint internalformat, uint buffer)
		{
			_glTexBuffer(target, internalformat, buffer);
		}

		public static void glTexBufferRange(uint target, uint internalformat, uint buffer, int offset, int size)
		{
			_glTexBufferRange(target, internalformat, buffer, offset, size);
		}

		public static void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels)
		{
			_glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
		}

		public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels)
		{
			_glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}

		public static void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			_glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}

		public static void glTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels)
		{
			_glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}

		public static void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			_glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

		public static void glTexParameterf(uint target, uint pname, float param)
		{
			_glTexParameterf(target, pname, param);
		}

		public static void glTexParameterfv(uint target, uint pname, float[] @params)
		{
			_glTexParameterfv(target, pname, @params);
		}

		public static void glTexParameteri(uint target, uint pname, int param)
		{
			_glTexParameteri(target, pname, param);
		}

		public static void glTexParameterIiv(uint target, uint pname, int[] @params)
		{
			_glTexParameterIiv(target, pname, @params);
		}

		public static void glTexParameterIuiv(uint target, uint pname, uint[] @params)
		{
			_glTexParameterIuiv(target, pname, @params);
		}

		public static void glTexParameteriv(uint target, uint pname, int[] @params)
		{
			_glTexParameteriv(target, pname, @params);
		}

		public static void glTexStorage1D(uint target, int levels, uint internalformat, int width)
		{
			_glTexStorage1D(target, levels, internalformat, width);
		}

		public static void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height)
		{
			_glTexStorage2D(target, levels, internalformat, width, height);
		}

		public static void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			_glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}

		public static void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth)
		{
			_glTexStorage3D(target, levels, internalformat, width, height, depth);
		}

		public static void glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			_glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

		public static void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels)
		{
			_glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
		}

		public static void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels)
		{
			_glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}

		public static void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels)
		{
			_glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}

		public static void glTextureBarrier()
		{
			_glTextureBarrier();
		}

		public static void glTextureBuffer(uint texture, uint internalformat, uint buffer)
		{
			_glTextureBuffer(texture, internalformat, buffer);
		}

		public static void glTextureBufferRange(uint texture, uint internalformat, uint buffer, int offset, int size)
		{
			_glTextureBufferRange(texture, internalformat, buffer, offset, size);
		}

		public static void glTextureParameterf(uint texture, uint pname, float param)
		{
			_glTextureParameterf(texture, pname, param);
		}

		public static void glTextureParameterfv(uint texture, uint pname, float[] param)
		{
			_glTextureParameterfv(texture, pname, param);
		}

		public static void glTextureParameteri(uint texture, uint pname, int param)
		{
			_glTextureParameteri(texture, pname, param);
		}

		public static void glTextureParameterIiv(uint texture, uint pname, int[] @params)
		{
			_glTextureParameterIiv(texture, pname, @params);
		}

		public static void glTextureParameterIuiv(uint texture, uint pname, uint[] @params)
		{
			_glTextureParameterIuiv(texture, pname, @params);
		}

		public static void glTextureParameteriv(uint texture, uint pname, int[] param)
		{
			_glTextureParameteriv(texture, pname, param);
		}

		public static void glTextureStorage1D(uint texture, int levels, uint internalformat, int width)
		{
			_glTextureStorage1D(texture, levels, internalformat, width);
		}

		public static void glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height)
		{
			_glTextureStorage2D(texture, levels, internalformat, width, height);
		}

		public static void glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			_glTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
		}

		public static void glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth)
		{
			_glTextureStorage3D(texture, levels, internalformat, width, height, depth);
		}

		public static void glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			_glTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

		public static void glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels)
		{
			_glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
		}

		public static void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels)
		{
			_glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
		}

		public static void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels)
		{
			_glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}

		public static void glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			_glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}

		public static void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer)
		{
			_glTransformFeedbackBufferBase(xfb, index, buffer);
		}

		public static void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size)
		{
			_glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
		}

		public static void glTransformFeedbackVaryings(uint program, int count, string[] varyings, uint bufferMode)
		{
			_glTransformFeedbackVaryings(program, count, varyings, bufferMode);
		}

		public static void glUniform1d(int location, double x)
		{
			_glUniform1d(location, x);
		}

		public static void glUniform1dv(int location, int count, double[] value)
		{
			_glUniform1dv(location, count, value);
		}

		public static void glUniform1f(int location, float v0)
		{
			_glUniform1f(location, v0);
		}

		public static void glUniform1fv(int location, int count, float[] value)
		{
			_glUniform1fv(location, count, value);
		}

		public static void glUniform1i(int location, int v0)
		{
			_glUniform1i(location, v0);
		}

		public static void glUniform1iv(int location, int count, int[] value)
		{
			_glUniform1iv(location, count, value);
		}

		public static void glUniform1ui(int location, uint v0)
		{
			_glUniform1ui(location, v0);
		}

		public static void glUniform1uiv(int location, int count, uint[] value)
		{
			_glUniform1uiv(location, count, value);
		}

		public static void glUniform2d(int location, double x, double y)
		{
			_glUniform2d(location, x, y);
		}

		public static void glUniform2dv(int location, int count, double[] value)
		{
			_glUniform2dv(location, count, value);
		}

		public static void glUniform2f(int location, float v0, float v1)
		{
			_glUniform2f(location, v0, v1);
		}

		public static void glUniform2fv(int location, int count, float[] value)
		{
			_glUniform2fv(location, count, value);
		}

		public static void glUniform2i(int location, int v0, int v1)
		{
			_glUniform2i(location, v0, v1);
		}

		public static void glUniform2iv(int location, int count, int[] value)
		{
			_glUniform2iv(location, count, value);
		}

		public static void glUniform2ui(int location, uint v0, uint v1)
		{
			_glUniform2ui(location, v0, v1);
		}

		public static void glUniform2uiv(int location, int count, uint[] value)
		{
			_glUniform2uiv(location, count, value);
		}

		public static void glUniform3d(int location, double x, double y, double z)
		{
			_glUniform3d(location, x, y, z);
		}

		public static void glUniform3dv(int location, int count, double[] value)
		{
			_glUniform3dv(location, count, value);
		}

		public static void glUniform3f(int location, float v0, float v1, float v2)
		{
			_glUniform3f(location, v0, v1, v2);
		}

		public static void glUniform3fv(int location, int count, float[] value)
		{
			_glUniform3fv(location, count, value);
		}

		public static void glUniform3i(int location, int v0, int v1, int v2)
		{
			_glUniform3i(location, v0, v1, v2);
		}

		public static void glUniform3iv(int location, int count, int[] value)
		{
			_glUniform3iv(location, count, value);
		}

		public static void glUniform3ui(int location, uint v0, uint v1, uint v2)
		{
			_glUniform3ui(location, v0, v1, v2);
		}

		public static void glUniform3uiv(int location, int count, uint[] value)
		{
			_glUniform3uiv(location, count, value);
		}

		public static void glUniform4d(int location, double x, double y, double z, double w)
		{
			_glUniform4d(location, x, y, z, w);
		}

		public static void glUniform4dv(int location, int count, double[] value)
		{
			_glUniform4dv(location, count, value);
		}

		public static void glUniform4f(int location, float v0, float v1, float v2, float v3)
		{
			_glUniform4f(location, v0, v1, v2, v3);
		}

		public static void glUniform4fv(int location, int count, float[] value)
		{
			_glUniform4fv(location, count, value);
		}

		public static void glUniform4i(int location, int v0, int v1, int v2, int v3)
		{
			_glUniform4i(location, v0, v1, v2, v3);
		}

		public static void glUniform4iv(int location, int count, int[] value)
		{
			_glUniform4iv(location, count, value);
		}

		public static void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3)
		{
			_glUniform4ui(location, v0, v1, v2, v3);
		}

		public static void glUniform4uiv(int location, int count, uint[] value)
		{
			_glUniform4uiv(location, count, value);
		}

		public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
			_glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
		}

		public static void glUniformMatrix2dv(int location, int count, bool transpose, double[] value)
		{
			_glUniformMatrix2dv(location, count, transpose, value);
		}

		public static void glUniformMatrix2fv(int location, int count, bool transpose, float[] value)
		{
			_glUniformMatrix2fv(location, count, transpose, value);
		}

		public static void glUniformMatrix2x3dv(int location, int count, bool transpose, double[] value)
		{
			_glUniformMatrix2x3dv(location, count, transpose, value);
		}

		public static void glUniformMatrix2x3fv(int location, int count, bool transpose, float[] value)
		{
			_glUniformMatrix2x3fv(location, count, transpose, value);
		}

		public static void glUniformMatrix2x4dv(int location, int count, bool transpose, double[] value)
		{
			_glUniformMatrix2x4dv(location, count, transpose, value);
		}

		public static void glUniformMatrix2x4fv(int location, int count, bool transpose, float[] value)
		{
			_glUniformMatrix2x4fv(location, count, transpose, value);
		}

		public static void glUniformMatrix3dv(int location, int count, bool transpose, double[] value)
		{
			_glUniformMatrix3dv(location, count, transpose, value);
		}

		public static void glUniformMatrix3fv(int location, int count, bool transpose, float[] value)
		{
			_glUniformMatrix3fv(location, count, transpose, value);
		}

		public static void glUniformMatrix3x2dv(int location, int count, bool transpose, double[] value)
		{
			_glUniformMatrix3x2dv(location, count, transpose, value);
		}

		public static void glUniformMatrix3x2fv(int location, int count, bool transpose, float[] value)
		{
			_glUniformMatrix3x2fv(location, count, transpose, value);
		}

		public static void glUniformMatrix3x4dv(int location, int count, bool transpose, double[] value)
		{
			_glUniformMatrix3x4dv(location, count, transpose, value);
		}

		public static void glUniformMatrix3x4fv(int location, int count, bool transpose, float[] value)
		{
			_glUniformMatrix3x4fv(location, count, transpose, value);
		}

		public static void glUniformMatrix4dv(int location, int count, bool transpose, double[] value)
		{
			_glUniformMatrix4dv(location, count, transpose, value);
		}

		public static void glUniformMatrix4fv(int location, int count, bool transpose, float[] value)
		{
			_glUniformMatrix4fv(location, count, transpose, value);
		}

		public static void glUniformMatrix4fvByRef(int location, int count, bool transpose, ref float value)
		{
			_glUniformMatrix4fvByRef(location, count, transpose, ref value);
		}

		public static void glUniformMatrix4x2dv(int location, int count, bool transpose, double[] value)
		{
			_glUniformMatrix4x2dv(location, count, transpose, value);
		}

		public static void glUniformMatrix4x2fv(int location, int count, bool transpose, float[] value)
		{
			_glUniformMatrix4x2fv(location, count, transpose, value);
		}

		public static void glUniformMatrix4x3dv(int location, int count, bool transpose, double[] value)
		{
			_glUniformMatrix4x3dv(location, count, transpose, value);
		}

		public static void glUniformMatrix4x3fv(int location, int count, bool transpose, float[] value)
		{
			_glUniformMatrix4x3fv(location, count, transpose, value);
		}

		public static void glUniformSubroutinesuiv(uint shadertype, int count, uint[] indices)
		{
			_glUniformSubroutinesuiv(shadertype, count, indices);
		}

		public static bool glUnmapBuffer(uint target)
		{
			return _glUnmapBuffer(target);
		}

		public static bool glUnmapNamedBuffer(uint buffer)
		{
			return _glUnmapNamedBuffer(buffer);
		}

		public static void glUseProgram(uint program)
		{
			_glUseProgram(program);
		}

		public static void glUseProgramStages(uint pipeline, uint stages, uint program)
		{
			_glUseProgramStages(pipeline, stages, program);
		}

		public static void glValidateProgram(uint program)
		{
			_glValidateProgram(program);
		}

		public static void glValidateProgramPipeline(uint pipeline)
		{
			_glValidateProgramPipeline(pipeline);
		}

		public static void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex)
		{
			_glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
		}

		public static void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			_glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
		}

		public static void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			_glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
		}

		public static void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			_glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
		}

		public static void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor)
		{
			_glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
		}

		public static void glVertexArrayElementBuffer(uint vaobj, uint buffer)
		{
			_glVertexArrayElementBuffer(vaobj, buffer);
		}

		public static void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride)
		{
			_glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
		}

		public static void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint[] buffers, int[] offsets, int[] strides)
		{
			_glVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
		}

		public static void glVertexAttrib1d(uint index, double x)
		{
			_glVertexAttrib1d(index, x);
		}

		public static void glVertexAttrib1dv(uint index, double[] v)
		{
			_glVertexAttrib1dv(index, v);
		}

		public static void glVertexAttrib1f(uint index, float x)
		{
			_glVertexAttrib1f(index, x);
		}

		public static void glVertexAttrib1fv(uint index, float[] v)
		{
			_glVertexAttrib1fv(index, v);
		}

		public static void glVertexAttrib1s(uint index, short x)
		{
			_glVertexAttrib1s(index, x);
		}

		public static void glVertexAttrib1sv(uint index, short[] v)
		{
			_glVertexAttrib1sv(index, v);
		}

		public static void glVertexAttrib2d(uint index, double x, double y)
		{
			_glVertexAttrib2d(index, x, y);
		}

		public static void glVertexAttrib2dv(uint index, double[] v)
		{
			_glVertexAttrib2dv(index, v);
		}

		public static void glVertexAttrib2f(uint index, float x, float y)
		{
			_glVertexAttrib2f(index, x, y);
		}

		public static void glVertexAttrib2fv(uint index, float[] v)
		{
			_glVertexAttrib2fv(index, v);
		}

		public static void glVertexAttrib2s(uint index, short x, short y)
		{
			_glVertexAttrib2s(index, x, y);
		}

		public static void glVertexAttrib2sv(uint index, short[] v)
		{
			_glVertexAttrib2sv(index, v);
		}

		public static void glVertexAttrib3d(uint index, double x, double y, double z)
		{
			_glVertexAttrib3d(index, x, y, z);
		}

		public static void glVertexAttrib3dv(uint index, double[] v)
		{
			_glVertexAttrib3dv(index, v);
		}

		public static void glVertexAttrib3f(uint index, float x, float y, float z)
		{
			_glVertexAttrib3f(index, x, y, z);
		}

		public static void glVertexAttrib3fv(uint index, float[] v)
		{
			_glVertexAttrib3fv(index, v);
		}

		public static void glVertexAttrib3s(uint index, short x, short y, short z)
		{
			_glVertexAttrib3s(index, x, y, z);
		}

		public static void glVertexAttrib3sv(uint index, short[] v)
		{
			_glVertexAttrib3sv(index, v);
		}

		public static void glVertexAttrib4bv(uint index, sbyte[] v)
		{
			_glVertexAttrib4bv(index, v);
		}

		public static void glVertexAttrib4d(uint index, double x, double y, double z, double w)
		{
			_glVertexAttrib4d(index, x, y, z, w);
		}

		public static void glVertexAttrib4dv(uint index, double[] v)
		{
			_glVertexAttrib4dv(index, v);
		}

		public static void glVertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			_glVertexAttrib4f(index, x, y, z, w);
		}

		public static void glVertexAttrib4fv(uint index, float[] v)
		{
			_glVertexAttrib4fv(index, v);
		}

		public static void glVertexAttrib4iv(uint index, int[] v)
		{
			_glVertexAttrib4iv(index, v);
		}

		public static void glVertexAttrib4Nbv(uint index, sbyte[] v)
		{
			_glVertexAttrib4Nbv(index, v);
		}

		public static void glVertexAttrib4Niv(uint index, int[] v)
		{
			_glVertexAttrib4Niv(index, v);
		}

		public static void glVertexAttrib4Nsv(uint index, short[] v)
		{
			_glVertexAttrib4Nsv(index, v);
		}

		public static void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w)
		{
			_glVertexAttrib4Nub(index, x, y, z, w);
		}

		public static void glVertexAttrib4Nubv(uint index, byte[] v)
		{
			_glVertexAttrib4Nubv(index, v);
		}

		public static void glVertexAttrib4Nuiv(uint index, uint[] v)
		{
			_glVertexAttrib4Nuiv(index, v);
		}

		public static void glVertexAttrib4Nusv(uint index, ushort[] v)
		{
			_glVertexAttrib4Nusv(index, v);
		}

		public static void glVertexAttrib4s(uint index, short x, short y, short z, short w)
		{
			_glVertexAttrib4s(index, x, y, z, w);
		}

		public static void glVertexAttrib4sv(uint index, short[] v)
		{
			_glVertexAttrib4sv(index, v);
		}

		public static void glVertexAttrib4ubv(uint index, byte[] v)
		{
			_glVertexAttrib4ubv(index, v);
		}

		public static void glVertexAttrib4uiv(uint index, uint[] v)
		{
			_glVertexAttrib4uiv(index, v);
		}

		public static void glVertexAttrib4usv(uint index, ushort[] v)
		{
			_glVertexAttrib4usv(index, v);
		}

		public static void glVertexAttribBinding(uint attribindex, uint bindingindex)
		{
			_glVertexAttribBinding(attribindex, bindingindex);
		}

		public static void glVertexAttribDivisor(uint index, uint divisor)
		{
			_glVertexAttribDivisor(index, divisor);
		}

		public static void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			_glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
		}

		public static void glVertexAttribI1i(uint index, int x)
		{
			_glVertexAttribI1i(index, x);
		}

		public static void glVertexAttribI1iv(uint index, int[] v)
		{
			_glVertexAttribI1iv(index, v);
		}

		public static void glVertexAttribI1ui(uint index, uint x)
		{
			_glVertexAttribI1ui(index, x);
		}

		public static void glVertexAttribI1uiv(uint index, uint[] v)
		{
			_glVertexAttribI1uiv(index, v);
		}

		public static void glVertexAttribI2i(uint index, int x, int y)
		{
			_glVertexAttribI2i(index, x, y);
		}

		public static void glVertexAttribI2iv(uint index, int[] v)
		{
			_glVertexAttribI2iv(index, v);
		}

		public static void glVertexAttribI2ui(uint index, uint x, uint y)
		{
			_glVertexAttribI2ui(index, x, y);
		}

		public static void glVertexAttribI2uiv(uint index, uint[] v)
		{
			_glVertexAttribI2uiv(index, v);
		}

		public static void glVertexAttribI3i(uint index, int x, int y, int z)
		{
			_glVertexAttribI3i(index, x, y, z);
		}

		public static void glVertexAttribI3iv(uint index, int[] v)
		{
			_glVertexAttribI3iv(index, v);
		}

		public static void glVertexAttribI3ui(uint index, uint x, uint y, uint z)
		{
			_glVertexAttribI3ui(index, x, y, z);
		}

		public static void glVertexAttribI3uiv(uint index, uint[] v)
		{
			_glVertexAttribI3uiv(index, v);
		}

		public static void glVertexAttribI4bv(uint index, sbyte[] v)
		{
			_glVertexAttribI4bv(index, v);
		}

		public static void glVertexAttribI4i(uint index, int x, int y, int z, int w)
		{
			_glVertexAttribI4i(index, x, y, z, w);
		}

		public static void glVertexAttribI4iv(uint index, int[] v)
		{
			_glVertexAttribI4iv(index, v);
		}

		public static void glVertexAttribI4sv(uint index, short[] v)
		{
			_glVertexAttribI4sv(index, v);
		}

		public static void glVertexAttribI4ubv(uint index, byte[] v)
		{
			_glVertexAttribI4ubv(index, v);
		}

		public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
			_glVertexAttribI4ui(index, x, y, z, w);
		}

		public static void glVertexAttribI4uiv(uint index, uint[] v)
		{
			_glVertexAttribI4uiv(index, v);
		}

		public static void glVertexAttribI4usv(uint index, ushort[] v)
		{
			_glVertexAttribI4usv(index, v);
		}

		public static void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			_glVertexAttribIFormat(attribindex, size, type, relativeoffset);
		}

		public static void glVertexAttribIPointer(uint index, int size, uint type, int stride, IntPtr pointer)
		{
			_glVertexAttribIPointer(index, size, type, stride, pointer);
		}

		public static void glVertexAttribL1d(uint index, double x)
		{
			_glVertexAttribL1d(index, x);
		}

		public static void glVertexAttribL1dv(uint index, double[] v)
		{
			_glVertexAttribL1dv(index, v);
		}

		public static void glVertexAttribL2d(uint index, double x, double y)
		{
			_glVertexAttribL2d(index, x, y);
		}

		public static void glVertexAttribL2dv(uint index, double[] v)
		{
			_glVertexAttribL2dv(index, v);
		}

		public static void glVertexAttribL3d(uint index, double x, double y, double z)
		{
			_glVertexAttribL3d(index, x, y, z);
		}

		public static void glVertexAttribL3dv(uint index, double[] v)
		{
			_glVertexAttribL3dv(index, v);
		}

		public static void glVertexAttribL4d(uint index, double x, double y, double z, double w)
		{
			_glVertexAttribL4d(index, x, y, z, w);
		}

		public static void glVertexAttribL4dv(uint index, double[] v)
		{
			_glVertexAttribL4dv(index, v);
		}

		public static void glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			_glVertexAttribLFormat(attribindex, size, type, relativeoffset);
		}

		public static void glVertexAttribLPointer(uint index, int size, uint type, int stride, IntPtr pointer)
		{
			_glVertexAttribLPointer(index, size, type, stride, pointer);
		}

		public static void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value)
		{
			_glVertexAttribP1ui(index, type, normalized, value);
		}

		public static void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint[] value)
		{
			_glVertexAttribP1uiv(index, type, normalized, value);
		}

		public static void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value)
		{
			_glVertexAttribP2ui(index, type, normalized, value);
		}

		public static void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint[] value)
		{
			_glVertexAttribP2uiv(index, type, normalized, value);
		}

		public static void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value)
		{
			_glVertexAttribP3ui(index, type, normalized, value);
		}

		public static void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint[] value)
		{
			_glVertexAttribP3uiv(index, type, normalized, value);
		}

		public static void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value)
		{
			_glVertexAttribP4ui(index, type, normalized, value);
		}

		public static void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint[] value)
		{
			_glVertexAttribP4uiv(index, type, normalized, value);
		}

		public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer)
		{
			_glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}

		public static void glVertexBindingDivisor(uint bindingindex, uint divisor)
		{
			_glVertexBindingDivisor(bindingindex, divisor);
		}

		public static void glViewport(int x, int y, int width, int height)
		{
			_glViewport(x, y, width, height);
		}

		public static void glViewportArrayv(uint first, int count, float[] v)
		{
			_glViewportArrayv(first, count, v);
		}

		public static void glViewportIndexedf(uint index, float x, float y, float w, float h)
		{
			_glViewportIndexedf(index, x, y, w, h);
		}

		public static void glViewportIndexedfv(uint index, float[] v)
		{
			_glViewportIndexedfv(index, v);
		}

		public static void glWaitSync(IntPtr sync, uint flags, ulong timeout)
		{
			_glWaitSync(sync, flags, timeout);
		}

	}
}
