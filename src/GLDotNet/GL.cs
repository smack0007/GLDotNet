// Copyright (c) 2017-2019 Zachary Snow
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GLDotNet
{
	public static unsafe partial class GL
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
		public const uint GL_BLEND_COLOR = 0x8005;
		public const uint GL_BLEND_DST = 0x0BE0;
		public const uint GL_BLEND_DST_ALPHA = 0x80CA;
		public const uint GL_BLEND_DST_RGB = 0x80C8;
		public const uint GL_BLEND_EQUATION = 0x8009;
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
		public const uint GL_CLIPPING_INPUT_PRIMITIVES = 0x82F6;
		public const uint GL_CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;
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
		public const uint GL_COMPUTE_SHADER_INVOCATIONS = 0x82F5;
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
		public const uint GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008;
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
		public const uint GL_FRAGMENT_SHADER_INVOCATIONS = 0x82F4;
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
		public const uint GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3;
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
		public const uint GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;
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
		public const uint GL_NUM_SPIR_V_EXTENSIONS = 0x9554;
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
		public const uint GL_PARAMETER_BUFFER = 0x80EE;
		public const uint GL_PARAMETER_BUFFER_BINDING = 0x80EF;
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
		public const uint GL_POLYGON_OFFSET_CLAMP = 0x8E1B;
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
		public const uint GL_PRIMITIVES_SUBMITTED = 0x82EF;
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
		public const uint GL_SHADER_BINARY_FORMAT_SPIR_V = 0x9551;
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
		public const uint GL_SPIR_V_BINARY = 0x9552;
		public const uint GL_SPIR_V_EXTENSIONS = 0x9553;
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
		public const uint GL_TESS_CONTROL_SHADER_PATCHES = 0x82F1;
		public const uint GL_TESS_CONTROL_SUBROUTINE = 0x92E9;
		public const uint GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
		public const uint GL_TESS_CONTROL_TEXTURE = 0x829C;
		public const uint GL_TESS_EVALUATION_SHADER = 0x8E87;
		public const uint GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
		public const uint GL_TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2;
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
		public const uint GL_TEXTURE_MAX_ANISOTROPY = 0x84FE;
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
		public const uint GL_TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC;
		public const uint GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
		public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
		public const uint GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;
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
		public const uint GL_VERTEX_SHADER_INVOCATIONS = 0x82F0;
		public const uint GL_VERTEX_SUBROUTINE = 0x92E8;
		public const uint GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
		public const uint GL_VERTEX_TEXTURE = 0x829B;
		public const uint GL_VERTICES_SUBMITTED = 0x82EE;
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

		public delegate void glDebugProc(uint source, uint type, uint id, uint severity, int length, string message, IntPtr userParam);

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

			public delegate void glBindBuffersBase(uint target, uint first, int count, uint* buffers);

			public delegate void glBindBuffersRange(uint target, uint first, int count, uint* buffers, int* offsets, int* sizes);

			public delegate void glBindFragDataLocation(uint program, uint color, string name);

			public delegate void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name);

			public delegate void glBindFramebuffer(uint target, uint framebuffer);

			public delegate void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);

			public delegate void glBindImageTextures(uint first, int count, uint* textures);

			public delegate void glBindProgramPipeline(uint pipeline);

			public delegate void glBindRenderbuffer(uint target, uint renderbuffer);

			public delegate void glBindSampler(uint unit, uint sampler);

			public delegate void glBindSamplers(uint first, int count, uint* samplers);

			public delegate void glBindTexture(uint target, uint texture);

			public delegate void glBindTextures(uint first, int count, uint* textures);

			public delegate void glBindTextureUnit(uint unit, uint texture);

			public delegate void glBindTransformFeedback(uint target, uint id);

			public delegate void glBindVertexArray(uint array);

			public delegate void glBindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride);

			public delegate void glBindVertexBuffers(uint first, int count, uint* buffers, int* offsets, int* strides);

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

			public delegate void glBufferData(uint target, int size, void* data, uint usage);

			public delegate void glBufferStorage(uint target, int size, void* data, uint flags);

			public delegate void glBufferSubData(uint target, int offset, int size, void* data);

			public delegate uint glCheckFramebufferStatus(uint target);

			public delegate uint glCheckNamedFramebufferStatus(uint framebuffer, uint target);

			public delegate void glClampColor(uint target, uint clamp);

			public delegate void glClear(uint mask);

			public delegate void glClearBufferData(uint target, uint internalformat, uint format, uint type, void* data);

			public delegate void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil);

			public delegate void glClearBufferfv(uint buffer, int drawbuffer, float* value);

			public delegate void glClearBufferiv(uint buffer, int drawbuffer, int* value);

			public delegate void glClearBufferSubData(uint target, uint internalformat, int offset, int size, uint format, uint type, void* data);

			public delegate void glClearBufferuiv(uint buffer, int drawbuffer, uint* value);

			public delegate void glClearColor(float red, float green, float blue, float alpha);

			public delegate void glClearDepth(double depth);

			public delegate void glClearDepthf(float d);

			public delegate void glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, void* data);

			public delegate void glClearNamedBufferSubData(uint buffer, uint internalformat, int offset, int size, uint format, uint type, void* data);

			public delegate void glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);

			public delegate void glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value);

			public delegate void glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value);

			public delegate void glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value);

			public delegate void glClearStencil(int s);

			public delegate void glClearTexImage(uint texture, int level, uint format, uint type, void* data);

			public delegate void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data);

			public delegate uint glClientWaitSync(IntPtr sync, uint flags, ulong timeout);

			public delegate void glClipControl(uint origin, uint depth);

			public delegate void glColorMask(bool red, bool green, bool blue, bool alpha);

			public delegate void glColorMaski(uint index, bool r, bool g, bool b, bool a);

			public delegate void glCompileShader(uint shader);

			public delegate void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data);

			public delegate void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);

			public delegate void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);

			public delegate void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data);

			public delegate void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

			public delegate void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);

			public delegate void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data);

			public delegate void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

			public delegate void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);

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

			public delegate void glCreateBuffers(int n, uint* buffers);

			public delegate void glCreateFramebuffers(int n, uint* framebuffers);

			public delegate uint glCreateProgram();

			public delegate void glCreateProgramPipelines(int n, uint* pipelines);

			public delegate void glCreateQueries(uint target, int n, uint* ids);

			public delegate void glCreateRenderbuffers(int n, uint* renderbuffers);

			public delegate void glCreateSamplers(int n, uint* samplers);

			public delegate uint glCreateShader(uint type);

			public delegate uint glCreateShaderProgramv(uint type, int count, string[] strings);

			public delegate void glCreateTextures(uint target, int n, uint* textures);

			public delegate void glCreateTransformFeedbacks(int n, uint* ids);

			public delegate void glCreateVertexArrays(int n, uint* arrays);

			public delegate void glCullFace(uint mode);

			public delegate void glDebugMessageCallback(glDebugProc callback, void* userParam);

			public delegate void glDebugMessageControl(uint source, uint type, uint severity, int count, uint* ids, bool enabled);

			public delegate void glDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, string buf);

			public delegate void glDeleteBuffers(int n, uint* buffers);

			public delegate void glDeleteFramebuffers(int n, uint* framebuffers);

			public delegate void glDeleteProgram(uint program);

			public delegate void glDeleteProgramPipelines(int n, uint* pipelines);

			public delegate void glDeleteQueries(int n, uint* ids);

			public delegate void glDeleteRenderbuffers(int n, uint* renderbuffers);

			public delegate void glDeleteSamplers(int count, uint* samplers);

			public delegate void glDeleteShader(uint shader);

			public delegate void glDeleteSync(IntPtr sync);

			public delegate void glDeleteTextures(int n, uint* textures);

			public delegate void glDeleteTransformFeedbacks(int n, uint* ids);

			public delegate void glDeleteVertexArrays(int n, uint* arrays);

			public delegate void glDepthFunc(uint func);

			public delegate void glDepthMask(bool flag);

			public delegate void glDepthRange(double n, double f);

			public delegate void glDepthRangeArrayv(uint first, int count, double* v);

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

			public delegate void glDrawArraysIndirect(uint mode, void* indirect);

			public delegate void glDrawArraysInstanced(uint mode, int first, int count, int instancecount);

			public delegate void glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance);

			public delegate void glDrawBuffer(uint buf);

			public delegate void glDrawBuffers(int n, uint* bufs);

			public delegate void glDrawElements(uint mode, int count, uint type, void* indices);

			public delegate void glDrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex);

			public delegate void glDrawElementsIndirect(uint mode, uint type, void* indirect);

			public delegate void glDrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount);

			public delegate void glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance);

			public delegate void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex);

			public delegate void glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance);

			public delegate void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);

			public delegate void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);

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

			public delegate void glGenBuffers(int n, uint* buffers);

			public delegate void glGenerateMipmap(uint target);

			public delegate void glGenerateTextureMipmap(uint texture);

			public delegate void glGenFramebuffers(int n, uint* framebuffers);

			public delegate void glGenProgramPipelines(int n, uint* pipelines);

			public delegate void glGenQueries(int n, uint* ids);

			public delegate void glGenRenderbuffers(int n, uint* renderbuffers);

			public delegate void glGenSamplers(int count, uint* samplers);

			public delegate void glGenTextures(int n, uint* textures);

			public delegate void glGenTransformFeedbacks(int n, uint* ids);

			public delegate void glGenVertexArrays(int n, uint* arrays);

			public delegate void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* @params);

			public delegate void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name);

			public delegate void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int* length, StringBuilder name);

			public delegate void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values);

			public delegate void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int* length, StringBuilder name);

			public delegate void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name);

			public delegate void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* @params);

			public delegate void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, StringBuilder uniformBlockName);

			public delegate void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, StringBuilder uniformName);

			public delegate void glGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* @params);

			public delegate void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);

			public delegate int glGetAttribLocation(uint program, string name);

			public delegate void glGetBooleani_v(uint target, uint index, bool* data);

			public delegate void glGetBooleanv(uint pname, bool* data);

			public delegate void glGetBufferParameteri64v(uint target, uint pname, long* @params);

			public delegate void glGetBufferParameteriv(uint target, uint pname, int* @params);

			public delegate void glGetBufferPointerv(uint target, uint pname, void** @params);

			public delegate void glGetBufferSubData(uint target, int offset, int size, void* data);

			public delegate void glGetCompressedTexImage(uint target, int level, void* img);

			public delegate void glGetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels);

			public delegate void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels);

			public delegate uint glGetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, StringBuilder messageLog);

			public delegate void glGetDoublei_v(uint target, uint index, double* data);

			public delegate void glGetDoublev(uint pname, double* data);

			public delegate uint glGetError();

			public delegate void glGetFloati_v(uint target, uint index, float* data);

			public delegate void glGetFloatv(uint pname, float* data);

			public delegate int glGetFragDataIndex(uint program, string name);

			public delegate int glGetFragDataLocation(uint program, string name);

			public delegate void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params);

			public delegate void glGetFramebufferParameteriv(uint target, uint pname, int* @params);

			public delegate uint glGetGraphicsResetStatus();

			public delegate void glGetInteger64i_v(uint target, uint index, long* data);

			public delegate void glGetInteger64v(uint pname, long* data);

			public delegate void glGetIntegeri_v(uint target, uint index, int* data);

			public delegate void glGetIntegerv(uint pname, int* data);

			public delegate void glGetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, long* @params);

			public delegate void glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int* @params);

			public delegate void glGetMultisamplefv(uint pname, uint index, float* val);

			public delegate void glGetNamedBufferParameteri64v(uint buffer, uint pname, long* @params);

			public delegate void glGetNamedBufferParameteriv(uint buffer, uint pname, int* @params);

			public delegate void glGetNamedBufferPointerv(uint buffer, uint pname, void** @params);

			public delegate void glGetNamedBufferSubData(uint buffer, int offset, int size, void* data);

			public delegate void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* @params);

			public delegate void glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param);

			public delegate void glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* @params);

			public delegate void glGetnCompressedTexImage(uint target, int lod, int bufSize, void* pixels);

			public delegate void glGetnTexImage(uint target, int level, uint format, uint type, int bufSize, void* pixels);

			public delegate void glGetnUniformdv(uint program, int location, int bufSize, double* @params);

			public delegate void glGetnUniformfv(uint program, int location, int bufSize, float* @params);

			public delegate void glGetnUniformiv(uint program, int location, int bufSize, int* @params);

			public delegate void glGetnUniformuiv(uint program, int location, int bufSize, uint* @params);

			public delegate void glGetObjectLabel(uint identifier, uint name, int bufSize, int* length, StringBuilder label);

			public delegate void glGetObjectPtrLabel(void* ptr, int bufSize, int* length, StringBuilder label);

			public delegate void glGetPointerv(uint pname, void** @params);

			public delegate void glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary);

			public delegate void glGetProgramInfoLog(uint program, int bufSize, int* length, StringBuilder infoLog);

			public delegate void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* @params);

			public delegate void glGetProgramiv(uint program, uint pname, int* @params);

			public delegate void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, StringBuilder infoLog);

			public delegate void glGetProgramPipelineiv(uint pipeline, uint pname, int* @params);

			public delegate uint glGetProgramResourceIndex(uint program, uint programInterface, string name);

			public delegate void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int bufSize, int* length, int* @params);

			public delegate int glGetProgramResourceLocation(uint program, uint programInterface, string name);

			public delegate int glGetProgramResourceLocationIndex(uint program, uint programInterface, string name);

			public delegate void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, StringBuilder name);

			public delegate void glGetProgramStageiv(uint program, uint shadertype, uint pname, int* values);

			public delegate void glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int offset);

			public delegate void glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, int offset);

			public delegate void glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int offset);

			public delegate void glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int offset);

			public delegate void glGetQueryIndexediv(uint target, uint index, uint pname, int* @params);

			public delegate void glGetQueryiv(uint target, uint pname, int* @params);

			public delegate void glGetQueryObjecti64v(uint id, uint pname, long* @params);

			public delegate void glGetQueryObjectiv(uint id, uint pname, int* @params);

			public delegate void glGetQueryObjectui64v(uint id, uint pname, ulong* @params);

			public delegate void glGetQueryObjectuiv(uint id, uint pname, uint* @params);

			public delegate void glGetRenderbufferParameteriv(uint target, uint pname, int* @params);

			public delegate void glGetSamplerParameterfv(uint sampler, uint pname, float* @params);

			public delegate void glGetSamplerParameterIiv(uint sampler, uint pname, int* @params);

			public delegate void glGetSamplerParameterIuiv(uint sampler, uint pname, uint* @params);

			public delegate void glGetSamplerParameteriv(uint sampler, uint pname, int* @params);

			public delegate void glGetShaderInfoLog(uint shader, int bufSize, int* length, StringBuilder infoLog);

			public delegate void glGetShaderiv(uint shader, uint pname, int* @params);

			public delegate void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision);

			public delegate void glGetShaderSource(uint shader, int bufSize, int* length, StringBuilder source);

			public delegate IntPtr glGetString(uint name);

			public delegate IntPtr glGetStringi(uint name, uint index);

			public delegate uint glGetSubroutineIndex(uint program, uint shadertype, string name);

			public delegate int glGetSubroutineUniformLocation(uint program, uint shadertype, string name);

			public delegate void glGetSynciv(IntPtr sync, uint pname, int bufSize, int* length, int* values);

			public delegate void glGetTexImage(uint target, int level, uint format, uint type, void* pixels);

			public delegate void glGetTexLevelParameterfv(uint target, int level, uint pname, float* @params);

			public delegate void glGetTexLevelParameteriv(uint target, int level, uint pname, int* @params);

			public delegate void glGetTexParameterfv(uint target, uint pname, float* @params);

			public delegate void glGetTexParameterIiv(uint target, uint pname, int* @params);

			public delegate void glGetTexParameterIuiv(uint target, uint pname, uint* @params);

			public delegate void glGetTexParameteriv(uint target, uint pname, int* @params);

			public delegate void glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, void* pixels);

			public delegate void glGetTextureLevelParameterfv(uint texture, int level, uint pname, float* @params);

			public delegate void glGetTextureLevelParameteriv(uint texture, int level, uint pname, int* @params);

			public delegate void glGetTextureParameterfv(uint texture, uint pname, float* @params);

			public delegate void glGetTextureParameterIiv(uint texture, uint pname, int* @params);

			public delegate void glGetTextureParameterIuiv(uint texture, uint pname, uint* @params);

			public delegate void glGetTextureParameteriv(uint texture, uint pname, int* @params);

			public delegate void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels);

			public delegate void glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param);

			public delegate void glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long* param);

			public delegate void glGetTransformFeedbackiv(uint xfb, uint pname, int* param);

			public delegate void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name);

			public delegate uint glGetUniformBlockIndex(uint program, string uniformBlockName);

			public delegate void glGetUniformdv(uint program, int location, double* @params);

			public delegate void glGetUniformfv(uint program, int location, float* @params);

			public delegate void glGetUniformIndices(uint program, int uniformCount, string[] uniformNames, uint* uniformIndices);

			public delegate void glGetUniformiv(uint program, int location, int* @params);

			public delegate int glGetUniformLocation(uint program, string name);

			public delegate void glGetUniformSubroutineuiv(uint shadertype, int location, uint* @params);

			public delegate void glGetUniformuiv(uint program, int location, uint* @params);

			public delegate void glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long* param);

			public delegate void glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param);

			public delegate void glGetVertexArrayiv(uint vaobj, uint pname, int* param);

			public delegate void glGetVertexAttribdv(uint index, uint pname, double* @params);

			public delegate void glGetVertexAttribfv(uint index, uint pname, float* @params);

			public delegate void glGetVertexAttribIiv(uint index, uint pname, int* @params);

			public delegate void glGetVertexAttribIuiv(uint index, uint pname, uint* @params);

			public delegate void glGetVertexAttribiv(uint index, uint pname, int* @params);

			public delegate void glGetVertexAttribLdv(uint index, uint pname, double* @params);

			public delegate void glGetVertexAttribPointerv(uint index, uint pname, void** pointer);

			public delegate void glHint(uint target, uint mode);

			public delegate void glInvalidateBufferData(uint buffer);

			public delegate void glInvalidateBufferSubData(uint buffer, int offset, int length);

			public delegate void glInvalidateFramebuffer(uint target, int numAttachments, uint* attachments);

			public delegate void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments);

			public delegate void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height);

			public delegate void glInvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height);

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

			public delegate void glMultiDrawArrays(uint mode, int* first, int* count, int drawcount);

			public delegate void glMultiDrawArraysIndirect(uint mode, void* indirect, int drawcount, int stride);

			public delegate void glMultiDrawArraysIndirectCount(uint mode, void* indirect, int drawcount, int maxdrawcount, int stride);

			public delegate void glMultiDrawElements(uint mode, int* count, uint type, void** indices, int drawcount);

			public delegate void glMultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex);

			public delegate void glMultiDrawElementsIndirect(uint mode, uint type, void* indirect, int drawcount, int stride);

			public delegate void glMultiDrawElementsIndirectCount(uint mode, uint type, void* indirect, int drawcount, int maxdrawcount, int stride);

			public delegate void glNamedBufferData(uint buffer, int size, void* data, uint usage);

			public delegate void glNamedBufferStorage(uint buffer, int size, void* data, uint flags);

			public delegate void glNamedBufferSubData(uint buffer, int offset, int size, void* data);

			public delegate void glNamedFramebufferDrawBuffer(uint framebuffer, uint buf);

			public delegate void glNamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs);

			public delegate void glNamedFramebufferParameteri(uint framebuffer, uint pname, int param);

			public delegate void glNamedFramebufferReadBuffer(uint framebuffer, uint src);

			public delegate void glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);

			public delegate void glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level);

			public delegate void glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer);

			public delegate void glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height);

			public delegate void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height);

			public delegate void glObjectLabel(uint identifier, uint name, int length, string label);

			public delegate void glObjectPtrLabel(void* ptr, int length, string label);

			public delegate void glPatchParameterfv(uint pname, float* values);

			public delegate void glPatchParameteri(uint pname, int value);

			public delegate void glPauseTransformFeedback();

			public delegate void glPixelStoref(uint pname, float param);

			public delegate void glPixelStorei(uint pname, int param);

			public delegate void glPointParameterf(uint pname, float param);

			public delegate void glPointParameterfv(uint pname, float* @params);

			public delegate void glPointParameteri(uint pname, int param);

			public delegate void glPointParameteriv(uint pname, int* @params);

			public delegate void glPointSize(float size);

			public delegate void glPolygonMode(uint face, uint mode);

			public delegate void glPolygonOffset(float factor, float units);

			public delegate void glPolygonOffsetClamp(float factor, float units, float clamp);

			public delegate void glPopDebugGroup();

			public delegate void glPrimitiveRestartIndex(uint index);

			public delegate void glProgramBinary(uint program, uint binaryFormat, void* binary, int length);

			public delegate void glProgramParameteri(uint program, uint pname, int value);

			public delegate void glProgramUniform1d(uint program, int location, double v0);

			public delegate void glProgramUniform1dv(uint program, int location, int count, double* value);

			public delegate void glProgramUniform1f(uint program, int location, float v0);

			public delegate void glProgramUniform1fv(uint program, int location, int count, float* value);

			public delegate void glProgramUniform1i(uint program, int location, int v0);

			public delegate void glProgramUniform1iv(uint program, int location, int count, int* value);

			public delegate void glProgramUniform1ui(uint program, int location, uint v0);

			public delegate void glProgramUniform1uiv(uint program, int location, int count, uint* value);

			public delegate void glProgramUniform2d(uint program, int location, double v0, double v1);

			public delegate void glProgramUniform2dv(uint program, int location, int count, double* value);

			public delegate void glProgramUniform2f(uint program, int location, float v0, float v1);

			public delegate void glProgramUniform2fv(uint program, int location, int count, float* value);

			public delegate void glProgramUniform2i(uint program, int location, int v0, int v1);

			public delegate void glProgramUniform2iv(uint program, int location, int count, int* value);

			public delegate void glProgramUniform2ui(uint program, int location, uint v0, uint v1);

			public delegate void glProgramUniform2uiv(uint program, int location, int count, uint* value);

			public delegate void glProgramUniform3d(uint program, int location, double v0, double v1, double v2);

			public delegate void glProgramUniform3dv(uint program, int location, int count, double* value);

			public delegate void glProgramUniform3f(uint program, int location, float v0, float v1, float v2);

			public delegate void glProgramUniform3fv(uint program, int location, int count, float* value);

			public delegate void glProgramUniform3i(uint program, int location, int v0, int v1, int v2);

			public delegate void glProgramUniform3iv(uint program, int location, int count, int* value);

			public delegate void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);

			public delegate void glProgramUniform3uiv(uint program, int location, int count, uint* value);

			public delegate void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);

			public delegate void glProgramUniform4dv(uint program, int location, int count, double* value);

			public delegate void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);

			public delegate void glProgramUniform4fv(uint program, int location, int count, float* value);

			public delegate void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);

			public delegate void glProgramUniform4iv(uint program, int location, int count, int* value);

			public delegate void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);

			public delegate void glProgramUniform4uiv(uint program, int location, int count, uint* value);

			public delegate void glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double* value);

			public delegate void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value);

			public delegate void glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double* value);

			public delegate void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float* value);

			public delegate void glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double* value);

			public delegate void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float* value);

			public delegate void glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double* value);

			public delegate void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value);

			public delegate void glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double* value);

			public delegate void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float* value);

			public delegate void glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double* value);

			public delegate void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float* value);

			public delegate void glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double* value);

			public delegate void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value);

			public delegate void glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double* value);

			public delegate void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float* value);

			public delegate void glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double* value);

			public delegate void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float* value);

			public delegate void glProvokingVertex(uint mode);

			public delegate void glPushDebugGroup(uint source, uint id, int length, string message);

			public delegate void glQueryCounter(uint id, uint target);

			public delegate void glReadBuffer(uint src);

			public delegate void glReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);

			public delegate void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);

			public delegate void glReleaseShaderCompiler();

			public delegate void glRenderbufferStorage(uint target, uint internalformat, int width, int height);

			public delegate void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);

			public delegate void glResumeTransformFeedback();

			public delegate void glSampleCoverage(float value, bool invert);

			public delegate void glSampleMaski(uint maskNumber, uint mask);

			public delegate void glSamplerParameterf(uint sampler, uint pname, float param);

			public delegate void glSamplerParameterfv(uint sampler, uint pname, float* param);

			public delegate void glSamplerParameteri(uint sampler, uint pname, int param);

			public delegate void glSamplerParameterIiv(uint sampler, uint pname, int* param);

			public delegate void glSamplerParameterIuiv(uint sampler, uint pname, uint* param);

			public delegate void glSamplerParameteriv(uint sampler, uint pname, int* param);

			public delegate void glScissor(int x, int y, int width, int height);

			public delegate void glScissorArrayv(uint first, int count, int* v);

			public delegate void glScissorIndexed(uint index, int left, int bottom, int width, int height);

			public delegate void glScissorIndexedv(uint index, int* v);

			public delegate void glShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length);

			public delegate void glShaderSource(uint shader, int count, string[] @string, int* length);

			public delegate void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);

			public delegate void glSpecializeShader(uint shader, string pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue);

			public delegate void glStencilFunc(uint func, int @ref, uint mask);

			public delegate void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask);

			public delegate void glStencilMask(uint mask);

			public delegate void glStencilMaskSeparate(uint face, uint mask);

			public delegate void glStencilOp(uint fail, uint zfail, uint zpass);

			public delegate void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);

			public delegate void glTexBuffer(uint target, uint internalformat, uint buffer);

			public delegate void glTexBufferRange(uint target, uint internalformat, uint buffer, int offset, int size);

			public delegate void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);

			public delegate void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);

			public delegate void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void glTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);

			public delegate void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void glTexParameterf(uint target, uint pname, float param);

			public delegate void glTexParameterfv(uint target, uint pname, float* @params);

			public delegate void glTexParameteri(uint target, uint pname, int param);

			public delegate void glTexParameterIiv(uint target, uint pname, int* @params);

			public delegate void glTexParameterIuiv(uint target, uint pname, uint* @params);

			public delegate void glTexParameteriv(uint target, uint pname, int* @params);

			public delegate void glTexStorage1D(uint target, int levels, uint internalformat, int width);

			public delegate void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height);

			public delegate void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);

			public delegate void glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);

			public delegate void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

			public delegate void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

			public delegate void glTextureBarrier();

			public delegate void glTextureBuffer(uint texture, uint internalformat, uint buffer);

			public delegate void glTextureBufferRange(uint texture, uint internalformat, uint buffer, int offset, int size);

			public delegate void glTextureParameterf(uint texture, uint pname, float param);

			public delegate void glTextureParameterfv(uint texture, uint pname, float* param);

			public delegate void glTextureParameteri(uint texture, uint pname, int param);

			public delegate void glTextureParameterIiv(uint texture, uint pname, int* @params);

			public delegate void glTextureParameterIuiv(uint texture, uint pname, uint* @params);

			public delegate void glTextureParameteriv(uint texture, uint pname, int* param);

			public delegate void glTextureStorage1D(uint texture, int levels, uint internalformat, int width);

			public delegate void glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height);

			public delegate void glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth);

			public delegate void glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels);

			public delegate void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

			public delegate void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

			public delegate void glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

			public delegate void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer);

			public delegate void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size);

			public delegate void glTransformFeedbackVaryings(uint program, int count, string[] varyings, uint bufferMode);

			public delegate void glUniform1d(int location, double x);

			public delegate void glUniform1dv(int location, int count, double* value);

			public delegate void glUniform1f(int location, float v0);

			public delegate void glUniform1fv(int location, int count, float* value);

			public delegate void glUniform1i(int location, int v0);

			public delegate void glUniform1iv(int location, int count, int* value);

			public delegate void glUniform1ui(int location, uint v0);

			public delegate void glUniform1uiv(int location, int count, uint* value);

			public delegate void glUniform2d(int location, double x, double y);

			public delegate void glUniform2dv(int location, int count, double* value);

			public delegate void glUniform2f(int location, float v0, float v1);

			public delegate void glUniform2fv(int location, int count, float* value);

			public delegate void glUniform2i(int location, int v0, int v1);

			public delegate void glUniform2iv(int location, int count, int* value);

			public delegate void glUniform2ui(int location, uint v0, uint v1);

			public delegate void glUniform2uiv(int location, int count, uint* value);

			public delegate void glUniform3d(int location, double x, double y, double z);

			public delegate void glUniform3dv(int location, int count, double* value);

			public delegate void glUniform3f(int location, float v0, float v1, float v2);

			public delegate void glUniform3fv(int location, int count, float* value);

			public delegate void glUniform3i(int location, int v0, int v1, int v2);

			public delegate void glUniform3iv(int location, int count, int* value);

			public delegate void glUniform3ui(int location, uint v0, uint v1, uint v2);

			public delegate void glUniform3uiv(int location, int count, uint* value);

			public delegate void glUniform4d(int location, double x, double y, double z, double w);

			public delegate void glUniform4dv(int location, int count, double* value);

			public delegate void glUniform4f(int location, float v0, float v1, float v2, float v3);

			public delegate void glUniform4fv(int location, int count, float* value);

			public delegate void glUniform4i(int location, int v0, int v1, int v2, int v3);

			public delegate void glUniform4iv(int location, int count, int* value);

			public delegate void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);

			public delegate void glUniform4uiv(int location, int count, uint* value);

			public delegate void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

			public delegate void glUniformMatrix2dv(int location, int count, bool transpose, double* value);

			public delegate void glUniformMatrix2fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformMatrix2x3dv(int location, int count, bool transpose, double* value);

			public delegate void glUniformMatrix2x3fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformMatrix2x4dv(int location, int count, bool transpose, double* value);

			public delegate void glUniformMatrix2x4fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformMatrix3dv(int location, int count, bool transpose, double* value);

			public delegate void glUniformMatrix3fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformMatrix3x2dv(int location, int count, bool transpose, double* value);

			public delegate void glUniformMatrix3x2fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformMatrix3x4dv(int location, int count, bool transpose, double* value);

			public delegate void glUniformMatrix3x4fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformMatrix4dv(int location, int count, bool transpose, double* value);

			public delegate void glUniformMatrix4fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformMatrix4x2dv(int location, int count, bool transpose, double* value);

			public delegate void glUniformMatrix4x2fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformMatrix4x3dv(int location, int count, bool transpose, double* value);

			public delegate void glUniformMatrix4x3fv(int location, int count, bool transpose, float* value);

			public delegate void glUniformSubroutinesuiv(uint shadertype, int count, uint* indices);

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

			public delegate void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, int* offsets, int* strides);

			public delegate void glVertexAttrib1d(uint index, double x);

			public delegate void glVertexAttrib1dv(uint index, double* v);

			public delegate void glVertexAttrib1f(uint index, float x);

			public delegate void glVertexAttrib1fv(uint index, float* v);

			public delegate void glVertexAttrib1s(uint index, short x);

			public delegate void glVertexAttrib1sv(uint index, short* v);

			public delegate void glVertexAttrib2d(uint index, double x, double y);

			public delegate void glVertexAttrib2dv(uint index, double* v);

			public delegate void glVertexAttrib2f(uint index, float x, float y);

			public delegate void glVertexAttrib2fv(uint index, float* v);

			public delegate void glVertexAttrib2s(uint index, short x, short y);

			public delegate void glVertexAttrib2sv(uint index, short* v);

			public delegate void glVertexAttrib3d(uint index, double x, double y, double z);

			public delegate void glVertexAttrib3dv(uint index, double* v);

			public delegate void glVertexAttrib3f(uint index, float x, float y, float z);

			public delegate void glVertexAttrib3fv(uint index, float* v);

			public delegate void glVertexAttrib3s(uint index, short x, short y, short z);

			public delegate void glVertexAttrib3sv(uint index, short* v);

			public delegate void glVertexAttrib4bv(uint index, sbyte* v);

			public delegate void glVertexAttrib4d(uint index, double x, double y, double z, double w);

			public delegate void glVertexAttrib4dv(uint index, double* v);

			public delegate void glVertexAttrib4f(uint index, float x, float y, float z, float w);

			public delegate void glVertexAttrib4fv(uint index, float* v);

			public delegate void glVertexAttrib4iv(uint index, int* v);

			public delegate void glVertexAttrib4Nbv(uint index, sbyte* v);

			public delegate void glVertexAttrib4Niv(uint index, int* v);

			public delegate void glVertexAttrib4Nsv(uint index, short* v);

			public delegate void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);

			public delegate void glVertexAttrib4Nubv(uint index, byte* v);

			public delegate void glVertexAttrib4Nuiv(uint index, uint* v);

			public delegate void glVertexAttrib4Nusv(uint index, ushort* v);

			public delegate void glVertexAttrib4s(uint index, short x, short y, short z, short w);

			public delegate void glVertexAttrib4sv(uint index, short* v);

			public delegate void glVertexAttrib4ubv(uint index, byte* v);

			public delegate void glVertexAttrib4uiv(uint index, uint* v);

			public delegate void glVertexAttrib4usv(uint index, ushort* v);

			public delegate void glVertexAttribBinding(uint attribindex, uint bindingindex);

			public delegate void glVertexAttribDivisor(uint index, uint divisor);

			public delegate void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);

			public delegate void glVertexAttribI1i(uint index, int x);

			public delegate void glVertexAttribI1iv(uint index, int* v);

			public delegate void glVertexAttribI1ui(uint index, uint x);

			public delegate void glVertexAttribI1uiv(uint index, uint* v);

			public delegate void glVertexAttribI2i(uint index, int x, int y);

			public delegate void glVertexAttribI2iv(uint index, int* v);

			public delegate void glVertexAttribI2ui(uint index, uint x, uint y);

			public delegate void glVertexAttribI2uiv(uint index, uint* v);

			public delegate void glVertexAttribI3i(uint index, int x, int y, int z);

			public delegate void glVertexAttribI3iv(uint index, int* v);

			public delegate void glVertexAttribI3ui(uint index, uint x, uint y, uint z);

			public delegate void glVertexAttribI3uiv(uint index, uint* v);

			public delegate void glVertexAttribI4bv(uint index, sbyte* v);

			public delegate void glVertexAttribI4i(uint index, int x, int y, int z, int w);

			public delegate void glVertexAttribI4iv(uint index, int* v);

			public delegate void glVertexAttribI4sv(uint index, short* v);

			public delegate void glVertexAttribI4ubv(uint index, byte* v);

			public delegate void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);

			public delegate void glVertexAttribI4uiv(uint index, uint* v);

			public delegate void glVertexAttribI4usv(uint index, ushort* v);

			public delegate void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void glVertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer);

			public delegate void glVertexAttribL1d(uint index, double x);

			public delegate void glVertexAttribL1dv(uint index, double* v);

			public delegate void glVertexAttribL2d(uint index, double x, double y);

			public delegate void glVertexAttribL2dv(uint index, double* v);

			public delegate void glVertexAttribL3d(uint index, double x, double y, double z);

			public delegate void glVertexAttribL3dv(uint index, double* v);

			public delegate void glVertexAttribL4d(uint index, double x, double y, double z, double w);

			public delegate void glVertexAttribL4dv(uint index, double* v);

			public delegate void glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void glVertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer);

			public delegate void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value);

			public delegate void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint* value);

			public delegate void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value);

			public delegate void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint* value);

			public delegate void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value);

			public delegate void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint* value);

			public delegate void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value);

			public delegate void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint* value);

			public delegate void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer);

			public delegate void glVertexBindingDivisor(uint bindingindex, uint divisor);

			public delegate void glViewport(int x, int y, int width, int height);

			public delegate void glViewportArrayv(uint first, int count, float* v);

			public delegate void glViewportIndexedf(uint index, float x, float y, float w, float h);

			public delegate void glViewportIndexedfv(uint index, float* v);

			public delegate void glWaitSync(IntPtr sync, uint flags, ulong timeout);

		}

		public static class Functions
		{
			public static Delegates.glActiveShaderProgram glActiveShaderProgram { get; set; }

			public static Delegates.glActiveTexture glActiveTexture { get; set; }

			public static Delegates.glAttachShader glAttachShader { get; set; }

			public static Delegates.glBeginConditionalRender glBeginConditionalRender { get; set; }

			public static Delegates.glBeginQuery glBeginQuery { get; set; }

			public static Delegates.glBeginQueryIndexed glBeginQueryIndexed { get; set; }

			public static Delegates.glBeginTransformFeedback glBeginTransformFeedback { get; set; }

			public static Delegates.glBindAttribLocation glBindAttribLocation { get; set; }

			public static Delegates.glBindBuffer glBindBuffer { get; set; }

			public static Delegates.glBindBufferBase glBindBufferBase { get; set; }

			public static Delegates.glBindBufferRange glBindBufferRange { get; set; }

			public static Delegates.glBindBuffersBase glBindBuffersBase { get; set; }

			public static Delegates.glBindBuffersRange glBindBuffersRange { get; set; }

			public static Delegates.glBindFragDataLocation glBindFragDataLocation { get; set; }

			public static Delegates.glBindFragDataLocationIndexed glBindFragDataLocationIndexed { get; set; }

			public static Delegates.glBindFramebuffer glBindFramebuffer { get; set; }

			public static Delegates.glBindImageTexture glBindImageTexture { get; set; }

			public static Delegates.glBindImageTextures glBindImageTextures { get; set; }

			public static Delegates.glBindProgramPipeline glBindProgramPipeline { get; set; }

			public static Delegates.glBindRenderbuffer glBindRenderbuffer { get; set; }

			public static Delegates.glBindSampler glBindSampler { get; set; }

			public static Delegates.glBindSamplers glBindSamplers { get; set; }

			public static Delegates.glBindTexture glBindTexture { get; set; }

			public static Delegates.glBindTextures glBindTextures { get; set; }

			public static Delegates.glBindTextureUnit glBindTextureUnit { get; set; }

			public static Delegates.glBindTransformFeedback glBindTransformFeedback { get; set; }

			public static Delegates.glBindVertexArray glBindVertexArray { get; set; }

			public static Delegates.glBindVertexBuffer glBindVertexBuffer { get; set; }

			public static Delegates.glBindVertexBuffers glBindVertexBuffers { get; set; }

			public static Delegates.glBlendColor glBlendColor { get; set; }

			public static Delegates.glBlendEquation glBlendEquation { get; set; }

			public static Delegates.glBlendEquationi glBlendEquationi { get; set; }

			public static Delegates.glBlendEquationSeparate glBlendEquationSeparate { get; set; }

			public static Delegates.glBlendEquationSeparatei glBlendEquationSeparatei { get; set; }

			public static Delegates.glBlendFunc glBlendFunc { get; set; }

			public static Delegates.glBlendFunci glBlendFunci { get; set; }

			public static Delegates.glBlendFuncSeparate glBlendFuncSeparate { get; set; }

			public static Delegates.glBlendFuncSeparatei glBlendFuncSeparatei { get; set; }

			public static Delegates.glBlitFramebuffer glBlitFramebuffer { get; set; }

			public static Delegates.glBlitNamedFramebuffer glBlitNamedFramebuffer { get; set; }

			public static Delegates.glBufferData glBufferData { get; set; }

			public static Delegates.glBufferStorage glBufferStorage { get; set; }

			public static Delegates.glBufferSubData glBufferSubData { get; set; }

			public static Delegates.glCheckFramebufferStatus glCheckFramebufferStatus { get; set; }

			public static Delegates.glCheckNamedFramebufferStatus glCheckNamedFramebufferStatus { get; set; }

			public static Delegates.glClampColor glClampColor { get; set; }

			public static Delegates.glClear glClear { get; set; }

			public static Delegates.glClearBufferData glClearBufferData { get; set; }

			public static Delegates.glClearBufferfi glClearBufferfi { get; set; }

			public static Delegates.glClearBufferfv glClearBufferfv { get; set; }

			public static Delegates.glClearBufferiv glClearBufferiv { get; set; }

			public static Delegates.glClearBufferSubData glClearBufferSubData { get; set; }

			public static Delegates.glClearBufferuiv glClearBufferuiv { get; set; }

			public static Delegates.glClearColor glClearColor { get; set; }

			public static Delegates.glClearDepth glClearDepth { get; set; }

			public static Delegates.glClearDepthf glClearDepthf { get; set; }

			public static Delegates.glClearNamedBufferData glClearNamedBufferData { get; set; }

			public static Delegates.glClearNamedBufferSubData glClearNamedBufferSubData { get; set; }

			public static Delegates.glClearNamedFramebufferfi glClearNamedFramebufferfi { get; set; }

			public static Delegates.glClearNamedFramebufferfv glClearNamedFramebufferfv { get; set; }

			public static Delegates.glClearNamedFramebufferiv glClearNamedFramebufferiv { get; set; }

			public static Delegates.glClearNamedFramebufferuiv glClearNamedFramebufferuiv { get; set; }

			public static Delegates.glClearStencil glClearStencil { get; set; }

			public static Delegates.glClearTexImage glClearTexImage { get; set; }

			public static Delegates.glClearTexSubImage glClearTexSubImage { get; set; }

			public static Delegates.glClientWaitSync glClientWaitSync { get; set; }

			public static Delegates.glClipControl glClipControl { get; set; }

			public static Delegates.glColorMask glColorMask { get; set; }

			public static Delegates.glColorMaski glColorMaski { get; set; }

			public static Delegates.glCompileShader glCompileShader { get; set; }

			public static Delegates.glCompressedTexImage1D glCompressedTexImage1D { get; set; }

			public static Delegates.glCompressedTexImage2D glCompressedTexImage2D { get; set; }

			public static Delegates.glCompressedTexImage3D glCompressedTexImage3D { get; set; }

			public static Delegates.glCompressedTexSubImage1D glCompressedTexSubImage1D { get; set; }

			public static Delegates.glCompressedTexSubImage2D glCompressedTexSubImage2D { get; set; }

			public static Delegates.glCompressedTexSubImage3D glCompressedTexSubImage3D { get; set; }

			public static Delegates.glCompressedTextureSubImage1D glCompressedTextureSubImage1D { get; set; }

			public static Delegates.glCompressedTextureSubImage2D glCompressedTextureSubImage2D { get; set; }

			public static Delegates.glCompressedTextureSubImage3D glCompressedTextureSubImage3D { get; set; }

			public static Delegates.glCopyBufferSubData glCopyBufferSubData { get; set; }

			public static Delegates.glCopyImageSubData glCopyImageSubData { get; set; }

			public static Delegates.glCopyNamedBufferSubData glCopyNamedBufferSubData { get; set; }

			public static Delegates.glCopyTexImage1D glCopyTexImage1D { get; set; }

			public static Delegates.glCopyTexImage2D glCopyTexImage2D { get; set; }

			public static Delegates.glCopyTexSubImage1D glCopyTexSubImage1D { get; set; }

			public static Delegates.glCopyTexSubImage2D glCopyTexSubImage2D { get; set; }

			public static Delegates.glCopyTexSubImage3D glCopyTexSubImage3D { get; set; }

			public static Delegates.glCopyTextureSubImage1D glCopyTextureSubImage1D { get; set; }

			public static Delegates.glCopyTextureSubImage2D glCopyTextureSubImage2D { get; set; }

			public static Delegates.glCopyTextureSubImage3D glCopyTextureSubImage3D { get; set; }

			public static Delegates.glCreateBuffers glCreateBuffers { get; set; }

			public static Delegates.glCreateFramebuffers glCreateFramebuffers { get; set; }

			public static Delegates.glCreateProgram glCreateProgram { get; set; }

			public static Delegates.glCreateProgramPipelines glCreateProgramPipelines { get; set; }

			public static Delegates.glCreateQueries glCreateQueries { get; set; }

			public static Delegates.glCreateRenderbuffers glCreateRenderbuffers { get; set; }

			public static Delegates.glCreateSamplers glCreateSamplers { get; set; }

			public static Delegates.glCreateShader glCreateShader { get; set; }

			public static Delegates.glCreateShaderProgramv glCreateShaderProgramv { get; set; }

			public static Delegates.glCreateTextures glCreateTextures { get; set; }

			public static Delegates.glCreateTransformFeedbacks glCreateTransformFeedbacks { get; set; }

			public static Delegates.glCreateVertexArrays glCreateVertexArrays { get; set; }

			public static Delegates.glCullFace glCullFace { get; set; }

			public static Delegates.glDebugMessageCallback glDebugMessageCallback { get; set; }

			public static Delegates.glDebugMessageControl glDebugMessageControl { get; set; }

			public static Delegates.glDebugMessageInsert glDebugMessageInsert { get; set; }

			public static Delegates.glDeleteBuffers glDeleteBuffers { get; set; }

			public static Delegates.glDeleteFramebuffers glDeleteFramebuffers { get; set; }

			public static Delegates.glDeleteProgram glDeleteProgram { get; set; }

			public static Delegates.glDeleteProgramPipelines glDeleteProgramPipelines { get; set; }

			public static Delegates.glDeleteQueries glDeleteQueries { get; set; }

			public static Delegates.glDeleteRenderbuffers glDeleteRenderbuffers { get; set; }

			public static Delegates.glDeleteSamplers glDeleteSamplers { get; set; }

			public static Delegates.glDeleteShader glDeleteShader { get; set; }

			public static Delegates.glDeleteSync glDeleteSync { get; set; }

			public static Delegates.glDeleteTextures glDeleteTextures { get; set; }

			public static Delegates.glDeleteTransformFeedbacks glDeleteTransformFeedbacks { get; set; }

			public static Delegates.glDeleteVertexArrays glDeleteVertexArrays { get; set; }

			public static Delegates.glDepthFunc glDepthFunc { get; set; }

			public static Delegates.glDepthMask glDepthMask { get; set; }

			public static Delegates.glDepthRange glDepthRange { get; set; }

			public static Delegates.glDepthRangeArrayv glDepthRangeArrayv { get; set; }

			public static Delegates.glDepthRangef glDepthRangef { get; set; }

			public static Delegates.glDepthRangeIndexed glDepthRangeIndexed { get; set; }

			public static Delegates.glDetachShader glDetachShader { get; set; }

			public static Delegates.glDisable glDisable { get; set; }

			public static Delegates.glDisablei glDisablei { get; set; }

			public static Delegates.glDisableVertexArrayAttrib glDisableVertexArrayAttrib { get; set; }

			public static Delegates.glDisableVertexAttribArray glDisableVertexAttribArray { get; set; }

			public static Delegates.glDispatchCompute glDispatchCompute { get; set; }

			public static Delegates.glDispatchComputeIndirect glDispatchComputeIndirect { get; set; }

			public static Delegates.glDrawArrays glDrawArrays { get; set; }

			public static Delegates.glDrawArraysIndirect glDrawArraysIndirect { get; set; }

			public static Delegates.glDrawArraysInstanced glDrawArraysInstanced { get; set; }

			public static Delegates.glDrawArraysInstancedBaseInstance glDrawArraysInstancedBaseInstance { get; set; }

			public static Delegates.glDrawBuffer glDrawBuffer { get; set; }

			public static Delegates.glDrawBuffers glDrawBuffers { get; set; }

			public static Delegates.glDrawElements glDrawElements { get; set; }

			public static Delegates.glDrawElementsBaseVertex glDrawElementsBaseVertex { get; set; }

			public static Delegates.glDrawElementsIndirect glDrawElementsIndirect { get; set; }

			public static Delegates.glDrawElementsInstanced glDrawElementsInstanced { get; set; }

			public static Delegates.glDrawElementsInstancedBaseInstance glDrawElementsInstancedBaseInstance { get; set; }

			public static Delegates.glDrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex { get; set; }

			public static Delegates.glDrawElementsInstancedBaseVertexBaseInstance glDrawElementsInstancedBaseVertexBaseInstance { get; set; }

			public static Delegates.glDrawRangeElements glDrawRangeElements { get; set; }

			public static Delegates.glDrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex { get; set; }

			public static Delegates.glDrawTransformFeedback glDrawTransformFeedback { get; set; }

			public static Delegates.glDrawTransformFeedbackInstanced glDrawTransformFeedbackInstanced { get; set; }

			public static Delegates.glDrawTransformFeedbackStream glDrawTransformFeedbackStream { get; set; }

			public static Delegates.glDrawTransformFeedbackStreamInstanced glDrawTransformFeedbackStreamInstanced { get; set; }

			public static Delegates.glEnable glEnable { get; set; }

			public static Delegates.glEnablei glEnablei { get; set; }

			public static Delegates.glEnableVertexArrayAttrib glEnableVertexArrayAttrib { get; set; }

			public static Delegates.glEnableVertexAttribArray glEnableVertexAttribArray { get; set; }

			public static Delegates.glEndConditionalRender glEndConditionalRender { get; set; }

			public static Delegates.glEndQuery glEndQuery { get; set; }

			public static Delegates.glEndQueryIndexed glEndQueryIndexed { get; set; }

			public static Delegates.glEndTransformFeedback glEndTransformFeedback { get; set; }

			public static Delegates.glFenceSync glFenceSync { get; set; }

			public static Delegates.glFinish glFinish { get; set; }

			public static Delegates.glFlush glFlush { get; set; }

			public static Delegates.glFlushMappedBufferRange glFlushMappedBufferRange { get; set; }

			public static Delegates.glFlushMappedNamedBufferRange glFlushMappedNamedBufferRange { get; set; }

			public static Delegates.glFramebufferParameteri glFramebufferParameteri { get; set; }

			public static Delegates.glFramebufferRenderbuffer glFramebufferRenderbuffer { get; set; }

			public static Delegates.glFramebufferTexture glFramebufferTexture { get; set; }

			public static Delegates.glFramebufferTexture1D glFramebufferTexture1D { get; set; }

			public static Delegates.glFramebufferTexture2D glFramebufferTexture2D { get; set; }

			public static Delegates.glFramebufferTexture3D glFramebufferTexture3D { get; set; }

			public static Delegates.glFramebufferTextureLayer glFramebufferTextureLayer { get; set; }

			public static Delegates.glFrontFace glFrontFace { get; set; }

			public static Delegates.glGenBuffers glGenBuffers { get; set; }

			public static Delegates.glGenerateMipmap glGenerateMipmap { get; set; }

			public static Delegates.glGenerateTextureMipmap glGenerateTextureMipmap { get; set; }

			public static Delegates.glGenFramebuffers glGenFramebuffers { get; set; }

			public static Delegates.glGenProgramPipelines glGenProgramPipelines { get; set; }

			public static Delegates.glGenQueries glGenQueries { get; set; }

			public static Delegates.glGenRenderbuffers glGenRenderbuffers { get; set; }

			public static Delegates.glGenSamplers glGenSamplers { get; set; }

			public static Delegates.glGenTextures glGenTextures { get; set; }

			public static Delegates.glGenTransformFeedbacks glGenTransformFeedbacks { get; set; }

			public static Delegates.glGenVertexArrays glGenVertexArrays { get; set; }

			public static Delegates.glGetActiveAtomicCounterBufferiv glGetActiveAtomicCounterBufferiv { get; set; }

			public static Delegates.glGetActiveAttrib glGetActiveAttrib { get; set; }

			public static Delegates.glGetActiveSubroutineName glGetActiveSubroutineName { get; set; }

			public static Delegates.glGetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv { get; set; }

			public static Delegates.glGetActiveSubroutineUniformName glGetActiveSubroutineUniformName { get; set; }

			public static Delegates.glGetActiveUniform glGetActiveUniform { get; set; }

			public static Delegates.glGetActiveUniformBlockiv glGetActiveUniformBlockiv { get; set; }

			public static Delegates.glGetActiveUniformBlockName glGetActiveUniformBlockName { get; set; }

			public static Delegates.glGetActiveUniformName glGetActiveUniformName { get; set; }

			public static Delegates.glGetActiveUniformsiv glGetActiveUniformsiv { get; set; }

			public static Delegates.glGetAttachedShaders glGetAttachedShaders { get; set; }

			public static Delegates.glGetAttribLocation glGetAttribLocation { get; set; }

			public static Delegates.glGetBooleani_v glGetBooleani_v { get; set; }

			public static Delegates.glGetBooleanv glGetBooleanv { get; set; }

			public static Delegates.glGetBufferParameteri64v glGetBufferParameteri64v { get; set; }

			public static Delegates.glGetBufferParameteriv glGetBufferParameteriv { get; set; }

			public static Delegates.glGetBufferPointerv glGetBufferPointerv { get; set; }

			public static Delegates.glGetBufferSubData glGetBufferSubData { get; set; }

			public static Delegates.glGetCompressedTexImage glGetCompressedTexImage { get; set; }

			public static Delegates.glGetCompressedTextureImage glGetCompressedTextureImage { get; set; }

			public static Delegates.glGetCompressedTextureSubImage glGetCompressedTextureSubImage { get; set; }

			public static Delegates.glGetDebugMessageLog glGetDebugMessageLog { get; set; }

			public static Delegates.glGetDoublei_v glGetDoublei_v { get; set; }

			public static Delegates.glGetDoublev glGetDoublev { get; set; }

			public static Delegates.glGetError glGetError { get; set; }

			public static Delegates.glGetFloati_v glGetFloati_v { get; set; }

			public static Delegates.glGetFloatv glGetFloatv { get; set; }

			public static Delegates.glGetFragDataIndex glGetFragDataIndex { get; set; }

			public static Delegates.glGetFragDataLocation glGetFragDataLocation { get; set; }

			public static Delegates.glGetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv { get; set; }

			public static Delegates.glGetFramebufferParameteriv glGetFramebufferParameteriv { get; set; }

			public static Delegates.glGetGraphicsResetStatus glGetGraphicsResetStatus { get; set; }

			public static Delegates.glGetInteger64i_v glGetInteger64i_v { get; set; }

			public static Delegates.glGetInteger64v glGetInteger64v { get; set; }

			public static Delegates.glGetIntegeri_v glGetIntegeri_v { get; set; }

			public static Delegates.glGetIntegerv glGetIntegerv { get; set; }

			public static Delegates.glGetInternalformati64v glGetInternalformati64v { get; set; }

			public static Delegates.glGetInternalformativ glGetInternalformativ { get; set; }

			public static Delegates.glGetMultisamplefv glGetMultisamplefv { get; set; }

			public static Delegates.glGetNamedBufferParameteri64v glGetNamedBufferParameteri64v { get; set; }

			public static Delegates.glGetNamedBufferParameteriv glGetNamedBufferParameteriv { get; set; }

			public static Delegates.glGetNamedBufferPointerv glGetNamedBufferPointerv { get; set; }

			public static Delegates.glGetNamedBufferSubData glGetNamedBufferSubData { get; set; }

			public static Delegates.glGetNamedFramebufferAttachmentParameteriv glGetNamedFramebufferAttachmentParameteriv { get; set; }

			public static Delegates.glGetNamedFramebufferParameteriv glGetNamedFramebufferParameteriv { get; set; }

			public static Delegates.glGetNamedRenderbufferParameteriv glGetNamedRenderbufferParameteriv { get; set; }

			public static Delegates.glGetnCompressedTexImage glGetnCompressedTexImage { get; set; }

			public static Delegates.glGetnTexImage glGetnTexImage { get; set; }

			public static Delegates.glGetnUniformdv glGetnUniformdv { get; set; }

			public static Delegates.glGetnUniformfv glGetnUniformfv { get; set; }

			public static Delegates.glGetnUniformiv glGetnUniformiv { get; set; }

			public static Delegates.glGetnUniformuiv glGetnUniformuiv { get; set; }

			public static Delegates.glGetObjectLabel glGetObjectLabel { get; set; }

			public static Delegates.glGetObjectPtrLabel glGetObjectPtrLabel { get; set; }

			public static Delegates.glGetPointerv glGetPointerv { get; set; }

			public static Delegates.glGetProgramBinary glGetProgramBinary { get; set; }

			public static Delegates.glGetProgramInfoLog glGetProgramInfoLog { get; set; }

			public static Delegates.glGetProgramInterfaceiv glGetProgramInterfaceiv { get; set; }

			public static Delegates.glGetProgramiv glGetProgramiv { get; set; }

			public static Delegates.glGetProgramPipelineInfoLog glGetProgramPipelineInfoLog { get; set; }

			public static Delegates.glGetProgramPipelineiv glGetProgramPipelineiv { get; set; }

			public static Delegates.glGetProgramResourceIndex glGetProgramResourceIndex { get; set; }

			public static Delegates.glGetProgramResourceiv glGetProgramResourceiv { get; set; }

			public static Delegates.glGetProgramResourceLocation glGetProgramResourceLocation { get; set; }

			public static Delegates.glGetProgramResourceLocationIndex glGetProgramResourceLocationIndex { get; set; }

			public static Delegates.glGetProgramResourceName glGetProgramResourceName { get; set; }

			public static Delegates.glGetProgramStageiv glGetProgramStageiv { get; set; }

			public static Delegates.glGetQueryBufferObjecti64v glGetQueryBufferObjecti64v { get; set; }

			public static Delegates.glGetQueryBufferObjectiv glGetQueryBufferObjectiv { get; set; }

			public static Delegates.glGetQueryBufferObjectui64v glGetQueryBufferObjectui64v { get; set; }

			public static Delegates.glGetQueryBufferObjectuiv glGetQueryBufferObjectuiv { get; set; }

			public static Delegates.glGetQueryIndexediv glGetQueryIndexediv { get; set; }

			public static Delegates.glGetQueryiv glGetQueryiv { get; set; }

			public static Delegates.glGetQueryObjecti64v glGetQueryObjecti64v { get; set; }

			public static Delegates.glGetQueryObjectiv glGetQueryObjectiv { get; set; }

			public static Delegates.glGetQueryObjectui64v glGetQueryObjectui64v { get; set; }

			public static Delegates.glGetQueryObjectuiv glGetQueryObjectuiv { get; set; }

			public static Delegates.glGetRenderbufferParameteriv glGetRenderbufferParameteriv { get; set; }

			public static Delegates.glGetSamplerParameterfv glGetSamplerParameterfv { get; set; }

			public static Delegates.glGetSamplerParameterIiv glGetSamplerParameterIiv { get; set; }

			public static Delegates.glGetSamplerParameterIuiv glGetSamplerParameterIuiv { get; set; }

			public static Delegates.glGetSamplerParameteriv glGetSamplerParameteriv { get; set; }

			public static Delegates.glGetShaderInfoLog glGetShaderInfoLog { get; set; }

			public static Delegates.glGetShaderiv glGetShaderiv { get; set; }

			public static Delegates.glGetShaderPrecisionFormat glGetShaderPrecisionFormat { get; set; }

			public static Delegates.glGetShaderSource glGetShaderSource { get; set; }

			public static Delegates.glGetString glGetString { get; set; }

			public static Delegates.glGetStringi glGetStringi { get; set; }

			public static Delegates.glGetSubroutineIndex glGetSubroutineIndex { get; set; }

			public static Delegates.glGetSubroutineUniformLocation glGetSubroutineUniformLocation { get; set; }

			public static Delegates.glGetSynciv glGetSynciv { get; set; }

			public static Delegates.glGetTexImage glGetTexImage { get; set; }

			public static Delegates.glGetTexLevelParameterfv glGetTexLevelParameterfv { get; set; }

			public static Delegates.glGetTexLevelParameteriv glGetTexLevelParameteriv { get; set; }

			public static Delegates.glGetTexParameterfv glGetTexParameterfv { get; set; }

			public static Delegates.glGetTexParameterIiv glGetTexParameterIiv { get; set; }

			public static Delegates.glGetTexParameterIuiv glGetTexParameterIuiv { get; set; }

			public static Delegates.glGetTexParameteriv glGetTexParameteriv { get; set; }

			public static Delegates.glGetTextureImage glGetTextureImage { get; set; }

			public static Delegates.glGetTextureLevelParameterfv glGetTextureLevelParameterfv { get; set; }

			public static Delegates.glGetTextureLevelParameteriv glGetTextureLevelParameteriv { get; set; }

			public static Delegates.glGetTextureParameterfv glGetTextureParameterfv { get; set; }

			public static Delegates.glGetTextureParameterIiv glGetTextureParameterIiv { get; set; }

			public static Delegates.glGetTextureParameterIuiv glGetTextureParameterIuiv { get; set; }

			public static Delegates.glGetTextureParameteriv glGetTextureParameteriv { get; set; }

			public static Delegates.glGetTextureSubImage glGetTextureSubImage { get; set; }

			public static Delegates.glGetTransformFeedbacki_v glGetTransformFeedbacki_v { get; set; }

			public static Delegates.glGetTransformFeedbacki64_v glGetTransformFeedbacki64_v { get; set; }

			public static Delegates.glGetTransformFeedbackiv glGetTransformFeedbackiv { get; set; }

			public static Delegates.glGetTransformFeedbackVarying glGetTransformFeedbackVarying { get; set; }

			public static Delegates.glGetUniformBlockIndex glGetUniformBlockIndex { get; set; }

			public static Delegates.glGetUniformdv glGetUniformdv { get; set; }

			public static Delegates.glGetUniformfv glGetUniformfv { get; set; }

			public static Delegates.glGetUniformIndices glGetUniformIndices { get; set; }

			public static Delegates.glGetUniformiv glGetUniformiv { get; set; }

			public static Delegates.glGetUniformLocation glGetUniformLocation { get; set; }

			public static Delegates.glGetUniformSubroutineuiv glGetUniformSubroutineuiv { get; set; }

			public static Delegates.glGetUniformuiv glGetUniformuiv { get; set; }

			public static Delegates.glGetVertexArrayIndexed64iv glGetVertexArrayIndexed64iv { get; set; }

			public static Delegates.glGetVertexArrayIndexediv glGetVertexArrayIndexediv { get; set; }

			public static Delegates.glGetVertexArrayiv glGetVertexArrayiv { get; set; }

			public static Delegates.glGetVertexAttribdv glGetVertexAttribdv { get; set; }

			public static Delegates.glGetVertexAttribfv glGetVertexAttribfv { get; set; }

			public static Delegates.glGetVertexAttribIiv glGetVertexAttribIiv { get; set; }

			public static Delegates.glGetVertexAttribIuiv glGetVertexAttribIuiv { get; set; }

			public static Delegates.glGetVertexAttribiv glGetVertexAttribiv { get; set; }

			public static Delegates.glGetVertexAttribLdv glGetVertexAttribLdv { get; set; }

			public static Delegates.glGetVertexAttribPointerv glGetVertexAttribPointerv { get; set; }

			public static Delegates.glHint glHint { get; set; }

			public static Delegates.glInvalidateBufferData glInvalidateBufferData { get; set; }

			public static Delegates.glInvalidateBufferSubData glInvalidateBufferSubData { get; set; }

			public static Delegates.glInvalidateFramebuffer glInvalidateFramebuffer { get; set; }

			public static Delegates.glInvalidateNamedFramebufferData glInvalidateNamedFramebufferData { get; set; }

			public static Delegates.glInvalidateNamedFramebufferSubData glInvalidateNamedFramebufferSubData { get; set; }

			public static Delegates.glInvalidateSubFramebuffer glInvalidateSubFramebuffer { get; set; }

			public static Delegates.glInvalidateTexImage glInvalidateTexImage { get; set; }

			public static Delegates.glInvalidateTexSubImage glInvalidateTexSubImage { get; set; }

			public static Delegates.glIsBuffer glIsBuffer { get; set; }

			public static Delegates.glIsEnabled glIsEnabled { get; set; }

			public static Delegates.glIsEnabledi glIsEnabledi { get; set; }

			public static Delegates.glIsFramebuffer glIsFramebuffer { get; set; }

			public static Delegates.glIsProgram glIsProgram { get; set; }

			public static Delegates.glIsProgramPipeline glIsProgramPipeline { get; set; }

			public static Delegates.glIsQuery glIsQuery { get; set; }

			public static Delegates.glIsRenderbuffer glIsRenderbuffer { get; set; }

			public static Delegates.glIsSampler glIsSampler { get; set; }

			public static Delegates.glIsShader glIsShader { get; set; }

			public static Delegates.glIsSync glIsSync { get; set; }

			public static Delegates.glIsTexture glIsTexture { get; set; }

			public static Delegates.glIsTransformFeedback glIsTransformFeedback { get; set; }

			public static Delegates.glIsVertexArray glIsVertexArray { get; set; }

			public static Delegates.glLineWidth glLineWidth { get; set; }

			public static Delegates.glLinkProgram glLinkProgram { get; set; }

			public static Delegates.glLogicOp glLogicOp { get; set; }

			public static Delegates.glMapBuffer glMapBuffer { get; set; }

			public static Delegates.glMapBufferRange glMapBufferRange { get; set; }

			public static Delegates.glMapNamedBuffer glMapNamedBuffer { get; set; }

			public static Delegates.glMapNamedBufferRange glMapNamedBufferRange { get; set; }

			public static Delegates.glMemoryBarrier glMemoryBarrier { get; set; }

			public static Delegates.glMemoryBarrierByRegion glMemoryBarrierByRegion { get; set; }

			public static Delegates.glMinSampleShading glMinSampleShading { get; set; }

			public static Delegates.glMultiDrawArrays glMultiDrawArrays { get; set; }

			public static Delegates.glMultiDrawArraysIndirect glMultiDrawArraysIndirect { get; set; }

			public static Delegates.glMultiDrawArraysIndirectCount glMultiDrawArraysIndirectCount { get; set; }

			public static Delegates.glMultiDrawElements glMultiDrawElements { get; set; }

			public static Delegates.glMultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex { get; set; }

			public static Delegates.glMultiDrawElementsIndirect glMultiDrawElementsIndirect { get; set; }

			public static Delegates.glMultiDrawElementsIndirectCount glMultiDrawElementsIndirectCount { get; set; }

			public static Delegates.glNamedBufferData glNamedBufferData { get; set; }

			public static Delegates.glNamedBufferStorage glNamedBufferStorage { get; set; }

			public static Delegates.glNamedBufferSubData glNamedBufferSubData { get; set; }

			public static Delegates.glNamedFramebufferDrawBuffer glNamedFramebufferDrawBuffer { get; set; }

			public static Delegates.glNamedFramebufferDrawBuffers glNamedFramebufferDrawBuffers { get; set; }

			public static Delegates.glNamedFramebufferParameteri glNamedFramebufferParameteri { get; set; }

			public static Delegates.glNamedFramebufferReadBuffer glNamedFramebufferReadBuffer { get; set; }

			public static Delegates.glNamedFramebufferRenderbuffer glNamedFramebufferRenderbuffer { get; set; }

			public static Delegates.glNamedFramebufferTexture glNamedFramebufferTexture { get; set; }

			public static Delegates.glNamedFramebufferTextureLayer glNamedFramebufferTextureLayer { get; set; }

			public static Delegates.glNamedRenderbufferStorage glNamedRenderbufferStorage { get; set; }

			public static Delegates.glNamedRenderbufferStorageMultisample glNamedRenderbufferStorageMultisample { get; set; }

			public static Delegates.glObjectLabel glObjectLabel { get; set; }

			public static Delegates.glObjectPtrLabel glObjectPtrLabel { get; set; }

			public static Delegates.glPatchParameterfv glPatchParameterfv { get; set; }

			public static Delegates.glPatchParameteri glPatchParameteri { get; set; }

			public static Delegates.glPauseTransformFeedback glPauseTransformFeedback { get; set; }

			public static Delegates.glPixelStoref glPixelStoref { get; set; }

			public static Delegates.glPixelStorei glPixelStorei { get; set; }

			public static Delegates.glPointParameterf glPointParameterf { get; set; }

			public static Delegates.glPointParameterfv glPointParameterfv { get; set; }

			public static Delegates.glPointParameteri glPointParameteri { get; set; }

			public static Delegates.glPointParameteriv glPointParameteriv { get; set; }

			public static Delegates.glPointSize glPointSize { get; set; }

			public static Delegates.glPolygonMode glPolygonMode { get; set; }

			public static Delegates.glPolygonOffset glPolygonOffset { get; set; }

			public static Delegates.glPolygonOffsetClamp glPolygonOffsetClamp { get; set; }

			public static Delegates.glPopDebugGroup glPopDebugGroup { get; set; }

			public static Delegates.glPrimitiveRestartIndex glPrimitiveRestartIndex { get; set; }

			public static Delegates.glProgramBinary glProgramBinary { get; set; }

			public static Delegates.glProgramParameteri glProgramParameteri { get; set; }

			public static Delegates.glProgramUniform1d glProgramUniform1d { get; set; }

			public static Delegates.glProgramUniform1dv glProgramUniform1dv { get; set; }

			public static Delegates.glProgramUniform1f glProgramUniform1f { get; set; }

			public static Delegates.glProgramUniform1fv glProgramUniform1fv { get; set; }

			public static Delegates.glProgramUniform1i glProgramUniform1i { get; set; }

			public static Delegates.glProgramUniform1iv glProgramUniform1iv { get; set; }

			public static Delegates.glProgramUniform1ui glProgramUniform1ui { get; set; }

			public static Delegates.glProgramUniform1uiv glProgramUniform1uiv { get; set; }

			public static Delegates.glProgramUniform2d glProgramUniform2d { get; set; }

			public static Delegates.glProgramUniform2dv glProgramUniform2dv { get; set; }

			public static Delegates.glProgramUniform2f glProgramUniform2f { get; set; }

			public static Delegates.glProgramUniform2fv glProgramUniform2fv { get; set; }

			public static Delegates.glProgramUniform2i glProgramUniform2i { get; set; }

			public static Delegates.glProgramUniform2iv glProgramUniform2iv { get; set; }

			public static Delegates.glProgramUniform2ui glProgramUniform2ui { get; set; }

			public static Delegates.glProgramUniform2uiv glProgramUniform2uiv { get; set; }

			public static Delegates.glProgramUniform3d glProgramUniform3d { get; set; }

			public static Delegates.glProgramUniform3dv glProgramUniform3dv { get; set; }

			public static Delegates.glProgramUniform3f glProgramUniform3f { get; set; }

			public static Delegates.glProgramUniform3fv glProgramUniform3fv { get; set; }

			public static Delegates.glProgramUniform3i glProgramUniform3i { get; set; }

			public static Delegates.glProgramUniform3iv glProgramUniform3iv { get; set; }

			public static Delegates.glProgramUniform3ui glProgramUniform3ui { get; set; }

			public static Delegates.glProgramUniform3uiv glProgramUniform3uiv { get; set; }

			public static Delegates.glProgramUniform4d glProgramUniform4d { get; set; }

			public static Delegates.glProgramUniform4dv glProgramUniform4dv { get; set; }

			public static Delegates.glProgramUniform4f glProgramUniform4f { get; set; }

			public static Delegates.glProgramUniform4fv glProgramUniform4fv { get; set; }

			public static Delegates.glProgramUniform4i glProgramUniform4i { get; set; }

			public static Delegates.glProgramUniform4iv glProgramUniform4iv { get; set; }

			public static Delegates.glProgramUniform4ui glProgramUniform4ui { get; set; }

			public static Delegates.glProgramUniform4uiv glProgramUniform4uiv { get; set; }

			public static Delegates.glProgramUniformMatrix2dv glProgramUniformMatrix2dv { get; set; }

			public static Delegates.glProgramUniformMatrix2fv glProgramUniformMatrix2fv { get; set; }

			public static Delegates.glProgramUniformMatrix2x3dv glProgramUniformMatrix2x3dv { get; set; }

			public static Delegates.glProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv { get; set; }

			public static Delegates.glProgramUniformMatrix2x4dv glProgramUniformMatrix2x4dv { get; set; }

			public static Delegates.glProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv { get; set; }

			public static Delegates.glProgramUniformMatrix3dv glProgramUniformMatrix3dv { get; set; }

			public static Delegates.glProgramUniformMatrix3fv glProgramUniformMatrix3fv { get; set; }

			public static Delegates.glProgramUniformMatrix3x2dv glProgramUniformMatrix3x2dv { get; set; }

			public static Delegates.glProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv { get; set; }

			public static Delegates.glProgramUniformMatrix3x4dv glProgramUniformMatrix3x4dv { get; set; }

			public static Delegates.glProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv { get; set; }

			public static Delegates.glProgramUniformMatrix4dv glProgramUniformMatrix4dv { get; set; }

			public static Delegates.glProgramUniformMatrix4fv glProgramUniformMatrix4fv { get; set; }

			public static Delegates.glProgramUniformMatrix4x2dv glProgramUniformMatrix4x2dv { get; set; }

			public static Delegates.glProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv { get; set; }

			public static Delegates.glProgramUniformMatrix4x3dv glProgramUniformMatrix4x3dv { get; set; }

			public static Delegates.glProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv { get; set; }

			public static Delegates.glProvokingVertex glProvokingVertex { get; set; }

			public static Delegates.glPushDebugGroup glPushDebugGroup { get; set; }

			public static Delegates.glQueryCounter glQueryCounter { get; set; }

			public static Delegates.glReadBuffer glReadBuffer { get; set; }

			public static Delegates.glReadnPixels glReadnPixels { get; set; }

			public static Delegates.glReadPixels glReadPixels { get; set; }

			public static Delegates.glReleaseShaderCompiler glReleaseShaderCompiler { get; set; }

			public static Delegates.glRenderbufferStorage glRenderbufferStorage { get; set; }

			public static Delegates.glRenderbufferStorageMultisample glRenderbufferStorageMultisample { get; set; }

			public static Delegates.glResumeTransformFeedback glResumeTransformFeedback { get; set; }

			public static Delegates.glSampleCoverage glSampleCoverage { get; set; }

			public static Delegates.glSampleMaski glSampleMaski { get; set; }

			public static Delegates.glSamplerParameterf glSamplerParameterf { get; set; }

			public static Delegates.glSamplerParameterfv glSamplerParameterfv { get; set; }

			public static Delegates.glSamplerParameteri glSamplerParameteri { get; set; }

			public static Delegates.glSamplerParameterIiv glSamplerParameterIiv { get; set; }

			public static Delegates.glSamplerParameterIuiv glSamplerParameterIuiv { get; set; }

			public static Delegates.glSamplerParameteriv glSamplerParameteriv { get; set; }

			public static Delegates.glScissor glScissor { get; set; }

			public static Delegates.glScissorArrayv glScissorArrayv { get; set; }

			public static Delegates.glScissorIndexed glScissorIndexed { get; set; }

			public static Delegates.glScissorIndexedv glScissorIndexedv { get; set; }

			public static Delegates.glShaderBinary glShaderBinary { get; set; }

			public static Delegates.glShaderSource glShaderSource { get; set; }

			public static Delegates.glShaderStorageBlockBinding glShaderStorageBlockBinding { get; set; }

			public static Delegates.glSpecializeShader glSpecializeShader { get; set; }

			public static Delegates.glStencilFunc glStencilFunc { get; set; }

			public static Delegates.glStencilFuncSeparate glStencilFuncSeparate { get; set; }

			public static Delegates.glStencilMask glStencilMask { get; set; }

			public static Delegates.glStencilMaskSeparate glStencilMaskSeparate { get; set; }

			public static Delegates.glStencilOp glStencilOp { get; set; }

			public static Delegates.glStencilOpSeparate glStencilOpSeparate { get; set; }

			public static Delegates.glTexBuffer glTexBuffer { get; set; }

			public static Delegates.glTexBufferRange glTexBufferRange { get; set; }

			public static Delegates.glTexImage1D glTexImage1D { get; set; }

			public static Delegates.glTexImage2D glTexImage2D { get; set; }

			public static Delegates.glTexImage2DMultisample glTexImage2DMultisample { get; set; }

			public static Delegates.glTexImage3D glTexImage3D { get; set; }

			public static Delegates.glTexImage3DMultisample glTexImage3DMultisample { get; set; }

			public static Delegates.glTexParameterf glTexParameterf { get; set; }

			public static Delegates.glTexParameterfv glTexParameterfv { get; set; }

			public static Delegates.glTexParameteri glTexParameteri { get; set; }

			public static Delegates.glTexParameterIiv glTexParameterIiv { get; set; }

			public static Delegates.glTexParameterIuiv glTexParameterIuiv { get; set; }

			public static Delegates.glTexParameteriv glTexParameteriv { get; set; }

			public static Delegates.glTexStorage1D glTexStorage1D { get; set; }

			public static Delegates.glTexStorage2D glTexStorage2D { get; set; }

			public static Delegates.glTexStorage2DMultisample glTexStorage2DMultisample { get; set; }

			public static Delegates.glTexStorage3D glTexStorage3D { get; set; }

			public static Delegates.glTexStorage3DMultisample glTexStorage3DMultisample { get; set; }

			public static Delegates.glTexSubImage1D glTexSubImage1D { get; set; }

			public static Delegates.glTexSubImage2D glTexSubImage2D { get; set; }

			public static Delegates.glTexSubImage3D glTexSubImage3D { get; set; }

			public static Delegates.glTextureBarrier glTextureBarrier { get; set; }

			public static Delegates.glTextureBuffer glTextureBuffer { get; set; }

			public static Delegates.glTextureBufferRange glTextureBufferRange { get; set; }

			public static Delegates.glTextureParameterf glTextureParameterf { get; set; }

			public static Delegates.glTextureParameterfv glTextureParameterfv { get; set; }

			public static Delegates.glTextureParameteri glTextureParameteri { get; set; }

			public static Delegates.glTextureParameterIiv glTextureParameterIiv { get; set; }

			public static Delegates.glTextureParameterIuiv glTextureParameterIuiv { get; set; }

			public static Delegates.glTextureParameteriv glTextureParameteriv { get; set; }

			public static Delegates.glTextureStorage1D glTextureStorage1D { get; set; }

			public static Delegates.glTextureStorage2D glTextureStorage2D { get; set; }

			public static Delegates.glTextureStorage2DMultisample glTextureStorage2DMultisample { get; set; }

			public static Delegates.glTextureStorage3D glTextureStorage3D { get; set; }

			public static Delegates.glTextureStorage3DMultisample glTextureStorage3DMultisample { get; set; }

			public static Delegates.glTextureSubImage1D glTextureSubImage1D { get; set; }

			public static Delegates.glTextureSubImage2D glTextureSubImage2D { get; set; }

			public static Delegates.glTextureSubImage3D glTextureSubImage3D { get; set; }

			public static Delegates.glTextureView glTextureView { get; set; }

			public static Delegates.glTransformFeedbackBufferBase glTransformFeedbackBufferBase { get; set; }

			public static Delegates.glTransformFeedbackBufferRange glTransformFeedbackBufferRange { get; set; }

			public static Delegates.glTransformFeedbackVaryings glTransformFeedbackVaryings { get; set; }

			public static Delegates.glUniform1d glUniform1d { get; set; }

			public static Delegates.glUniform1dv glUniform1dv { get; set; }

			public static Delegates.glUniform1f glUniform1f { get; set; }

			public static Delegates.glUniform1fv glUniform1fv { get; set; }

			public static Delegates.glUniform1i glUniform1i { get; set; }

			public static Delegates.glUniform1iv glUniform1iv { get; set; }

			public static Delegates.glUniform1ui glUniform1ui { get; set; }

			public static Delegates.glUniform1uiv glUniform1uiv { get; set; }

			public static Delegates.glUniform2d glUniform2d { get; set; }

			public static Delegates.glUniform2dv glUniform2dv { get; set; }

			public static Delegates.glUniform2f glUniform2f { get; set; }

			public static Delegates.glUniform2fv glUniform2fv { get; set; }

			public static Delegates.glUniform2i glUniform2i { get; set; }

			public static Delegates.glUniform2iv glUniform2iv { get; set; }

			public static Delegates.glUniform2ui glUniform2ui { get; set; }

			public static Delegates.glUniform2uiv glUniform2uiv { get; set; }

			public static Delegates.glUniform3d glUniform3d { get; set; }

			public static Delegates.glUniform3dv glUniform3dv { get; set; }

			public static Delegates.glUniform3f glUniform3f { get; set; }

			public static Delegates.glUniform3fv glUniform3fv { get; set; }

			public static Delegates.glUniform3i glUniform3i { get; set; }

			public static Delegates.glUniform3iv glUniform3iv { get; set; }

			public static Delegates.glUniform3ui glUniform3ui { get; set; }

			public static Delegates.glUniform3uiv glUniform3uiv { get; set; }

			public static Delegates.glUniform4d glUniform4d { get; set; }

			public static Delegates.glUniform4dv glUniform4dv { get; set; }

			public static Delegates.glUniform4f glUniform4f { get; set; }

			public static Delegates.glUniform4fv glUniform4fv { get; set; }

			public static Delegates.glUniform4i glUniform4i { get; set; }

			public static Delegates.glUniform4iv glUniform4iv { get; set; }

			public static Delegates.glUniform4ui glUniform4ui { get; set; }

			public static Delegates.glUniform4uiv glUniform4uiv { get; set; }

			public static Delegates.glUniformBlockBinding glUniformBlockBinding { get; set; }

			public static Delegates.glUniformMatrix2dv glUniformMatrix2dv { get; set; }

			public static Delegates.glUniformMatrix2fv glUniformMatrix2fv { get; set; }

			public static Delegates.glUniformMatrix2x3dv glUniformMatrix2x3dv { get; set; }

			public static Delegates.glUniformMatrix2x3fv glUniformMatrix2x3fv { get; set; }

			public static Delegates.glUniformMatrix2x4dv glUniformMatrix2x4dv { get; set; }

			public static Delegates.glUniformMatrix2x4fv glUniformMatrix2x4fv { get; set; }

			public static Delegates.glUniformMatrix3dv glUniformMatrix3dv { get; set; }

			public static Delegates.glUniformMatrix3fv glUniformMatrix3fv { get; set; }

			public static Delegates.glUniformMatrix3x2dv glUniformMatrix3x2dv { get; set; }

			public static Delegates.glUniformMatrix3x2fv glUniformMatrix3x2fv { get; set; }

			public static Delegates.glUniformMatrix3x4dv glUniformMatrix3x4dv { get; set; }

			public static Delegates.glUniformMatrix3x4fv glUniformMatrix3x4fv { get; set; }

			public static Delegates.glUniformMatrix4dv glUniformMatrix4dv { get; set; }

			public static Delegates.glUniformMatrix4fv glUniformMatrix4fv { get; set; }

			public static Delegates.glUniformMatrix4x2dv glUniformMatrix4x2dv { get; set; }

			public static Delegates.glUniformMatrix4x2fv glUniformMatrix4x2fv { get; set; }

			public static Delegates.glUniformMatrix4x3dv glUniformMatrix4x3dv { get; set; }

			public static Delegates.glUniformMatrix4x3fv glUniformMatrix4x3fv { get; set; }

			public static Delegates.glUniformSubroutinesuiv glUniformSubroutinesuiv { get; set; }

			public static Delegates.glUnmapBuffer glUnmapBuffer { get; set; }

			public static Delegates.glUnmapNamedBuffer glUnmapNamedBuffer { get; set; }

			public static Delegates.glUseProgram glUseProgram { get; set; }

			public static Delegates.glUseProgramStages glUseProgramStages { get; set; }

			public static Delegates.glValidateProgram glValidateProgram { get; set; }

			public static Delegates.glValidateProgramPipeline glValidateProgramPipeline { get; set; }

			public static Delegates.glVertexArrayAttribBinding glVertexArrayAttribBinding { get; set; }

			public static Delegates.glVertexArrayAttribFormat glVertexArrayAttribFormat { get; set; }

			public static Delegates.glVertexArrayAttribIFormat glVertexArrayAttribIFormat { get; set; }

			public static Delegates.glVertexArrayAttribLFormat glVertexArrayAttribLFormat { get; set; }

			public static Delegates.glVertexArrayBindingDivisor glVertexArrayBindingDivisor { get; set; }

			public static Delegates.glVertexArrayElementBuffer glVertexArrayElementBuffer { get; set; }

			public static Delegates.glVertexArrayVertexBuffer glVertexArrayVertexBuffer { get; set; }

			public static Delegates.glVertexArrayVertexBuffers glVertexArrayVertexBuffers { get; set; }

			public static Delegates.glVertexAttrib1d glVertexAttrib1d { get; set; }

			public static Delegates.glVertexAttrib1dv glVertexAttrib1dv { get; set; }

			public static Delegates.glVertexAttrib1f glVertexAttrib1f { get; set; }

			public static Delegates.glVertexAttrib1fv glVertexAttrib1fv { get; set; }

			public static Delegates.glVertexAttrib1s glVertexAttrib1s { get; set; }

			public static Delegates.glVertexAttrib1sv glVertexAttrib1sv { get; set; }

			public static Delegates.glVertexAttrib2d glVertexAttrib2d { get; set; }

			public static Delegates.glVertexAttrib2dv glVertexAttrib2dv { get; set; }

			public static Delegates.glVertexAttrib2f glVertexAttrib2f { get; set; }

			public static Delegates.glVertexAttrib2fv glVertexAttrib2fv { get; set; }

			public static Delegates.glVertexAttrib2s glVertexAttrib2s { get; set; }

			public static Delegates.glVertexAttrib2sv glVertexAttrib2sv { get; set; }

			public static Delegates.glVertexAttrib3d glVertexAttrib3d { get; set; }

			public static Delegates.glVertexAttrib3dv glVertexAttrib3dv { get; set; }

			public static Delegates.glVertexAttrib3f glVertexAttrib3f { get; set; }

			public static Delegates.glVertexAttrib3fv glVertexAttrib3fv { get; set; }

			public static Delegates.glVertexAttrib3s glVertexAttrib3s { get; set; }

			public static Delegates.glVertexAttrib3sv glVertexAttrib3sv { get; set; }

			public static Delegates.glVertexAttrib4bv glVertexAttrib4bv { get; set; }

			public static Delegates.glVertexAttrib4d glVertexAttrib4d { get; set; }

			public static Delegates.glVertexAttrib4dv glVertexAttrib4dv { get; set; }

			public static Delegates.glVertexAttrib4f glVertexAttrib4f { get; set; }

			public static Delegates.glVertexAttrib4fv glVertexAttrib4fv { get; set; }

			public static Delegates.glVertexAttrib4iv glVertexAttrib4iv { get; set; }

			public static Delegates.glVertexAttrib4Nbv glVertexAttrib4Nbv { get; set; }

			public static Delegates.glVertexAttrib4Niv glVertexAttrib4Niv { get; set; }

			public static Delegates.glVertexAttrib4Nsv glVertexAttrib4Nsv { get; set; }

			public static Delegates.glVertexAttrib4Nub glVertexAttrib4Nub { get; set; }

			public static Delegates.glVertexAttrib4Nubv glVertexAttrib4Nubv { get; set; }

			public static Delegates.glVertexAttrib4Nuiv glVertexAttrib4Nuiv { get; set; }

			public static Delegates.glVertexAttrib4Nusv glVertexAttrib4Nusv { get; set; }

			public static Delegates.glVertexAttrib4s glVertexAttrib4s { get; set; }

			public static Delegates.glVertexAttrib4sv glVertexAttrib4sv { get; set; }

			public static Delegates.glVertexAttrib4ubv glVertexAttrib4ubv { get; set; }

			public static Delegates.glVertexAttrib4uiv glVertexAttrib4uiv { get; set; }

			public static Delegates.glVertexAttrib4usv glVertexAttrib4usv { get; set; }

			public static Delegates.glVertexAttribBinding glVertexAttribBinding { get; set; }

			public static Delegates.glVertexAttribDivisor glVertexAttribDivisor { get; set; }

			public static Delegates.glVertexAttribFormat glVertexAttribFormat { get; set; }

			public static Delegates.glVertexAttribI1i glVertexAttribI1i { get; set; }

			public static Delegates.glVertexAttribI1iv glVertexAttribI1iv { get; set; }

			public static Delegates.glVertexAttribI1ui glVertexAttribI1ui { get; set; }

			public static Delegates.glVertexAttribI1uiv glVertexAttribI1uiv { get; set; }

			public static Delegates.glVertexAttribI2i glVertexAttribI2i { get; set; }

			public static Delegates.glVertexAttribI2iv glVertexAttribI2iv { get; set; }

			public static Delegates.glVertexAttribI2ui glVertexAttribI2ui { get; set; }

			public static Delegates.glVertexAttribI2uiv glVertexAttribI2uiv { get; set; }

			public static Delegates.glVertexAttribI3i glVertexAttribI3i { get; set; }

			public static Delegates.glVertexAttribI3iv glVertexAttribI3iv { get; set; }

			public static Delegates.glVertexAttribI3ui glVertexAttribI3ui { get; set; }

			public static Delegates.glVertexAttribI3uiv glVertexAttribI3uiv { get; set; }

			public static Delegates.glVertexAttribI4bv glVertexAttribI4bv { get; set; }

			public static Delegates.glVertexAttribI4i glVertexAttribI4i { get; set; }

			public static Delegates.glVertexAttribI4iv glVertexAttribI4iv { get; set; }

			public static Delegates.glVertexAttribI4sv glVertexAttribI4sv { get; set; }

			public static Delegates.glVertexAttribI4ubv glVertexAttribI4ubv { get; set; }

			public static Delegates.glVertexAttribI4ui glVertexAttribI4ui { get; set; }

			public static Delegates.glVertexAttribI4uiv glVertexAttribI4uiv { get; set; }

			public static Delegates.glVertexAttribI4usv glVertexAttribI4usv { get; set; }

			public static Delegates.glVertexAttribIFormat glVertexAttribIFormat { get; set; }

			public static Delegates.glVertexAttribIPointer glVertexAttribIPointer { get; set; }

			public static Delegates.glVertexAttribL1d glVertexAttribL1d { get; set; }

			public static Delegates.glVertexAttribL1dv glVertexAttribL1dv { get; set; }

			public static Delegates.glVertexAttribL2d glVertexAttribL2d { get; set; }

			public static Delegates.glVertexAttribL2dv glVertexAttribL2dv { get; set; }

			public static Delegates.glVertexAttribL3d glVertexAttribL3d { get; set; }

			public static Delegates.glVertexAttribL3dv glVertexAttribL3dv { get; set; }

			public static Delegates.glVertexAttribL4d glVertexAttribL4d { get; set; }

			public static Delegates.glVertexAttribL4dv glVertexAttribL4dv { get; set; }

			public static Delegates.glVertexAttribLFormat glVertexAttribLFormat { get; set; }

			public static Delegates.glVertexAttribLPointer glVertexAttribLPointer { get; set; }

			public static Delegates.glVertexAttribP1ui glVertexAttribP1ui { get; set; }

			public static Delegates.glVertexAttribP1uiv glVertexAttribP1uiv { get; set; }

			public static Delegates.glVertexAttribP2ui glVertexAttribP2ui { get; set; }

			public static Delegates.glVertexAttribP2uiv glVertexAttribP2uiv { get; set; }

			public static Delegates.glVertexAttribP3ui glVertexAttribP3ui { get; set; }

			public static Delegates.glVertexAttribP3uiv glVertexAttribP3uiv { get; set; }

			public static Delegates.glVertexAttribP4ui glVertexAttribP4ui { get; set; }

			public static Delegates.glVertexAttribP4uiv glVertexAttribP4uiv { get; set; }

			public static Delegates.glVertexAttribPointer glVertexAttribPointer { get; set; }

			public static Delegates.glVertexBindingDivisor glVertexBindingDivisor { get; set; }

			public static Delegates.glViewport glViewport { get; set; }

			public static Delegates.glViewportArrayv glViewportArrayv { get; set; }

			public static Delegates.glViewportIndexedf glViewportIndexedf { get; set; }

			public static Delegates.glViewportIndexedfv glViewportIndexedfv { get; set; }

			public static Delegates.glWaitSync glWaitSync { get; set; }

		}

#if !GLDOTNET_EXCLUDE_GLINIT
		public static void glInit(Func<string, IntPtr> getProcAddress, int versionMajor, int versionMinor)
		{
			if (getProcAddress == null) throw new ArgumentNullException(nameof(getProcAddress));

			T getProc<T>(string name) => Marshal.GetDelegateForFunctionPointer<T>(getProcAddress(name));

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 0))
			{
				Functions.glBlendFunc = getProc<Delegates.glBlendFunc>("glBlendFunc");
				Functions.glClear = getProc<Delegates.glClear>("glClear");
				Functions.glClearColor = getProc<Delegates.glClearColor>("glClearColor");
				Functions.glClearDepth = getProc<Delegates.glClearDepth>("glClearDepth");
				Functions.glClearStencil = getProc<Delegates.glClearStencil>("glClearStencil");
				Functions.glColorMask = getProc<Delegates.glColorMask>("glColorMask");
				Functions.glCullFace = getProc<Delegates.glCullFace>("glCullFace");
				Functions.glDepthFunc = getProc<Delegates.glDepthFunc>("glDepthFunc");
				Functions.glDepthMask = getProc<Delegates.glDepthMask>("glDepthMask");
				Functions.glDepthRange = getProc<Delegates.glDepthRange>("glDepthRange");
				Functions.glDisable = getProc<Delegates.glDisable>("glDisable");
				Functions.glDrawBuffer = getProc<Delegates.glDrawBuffer>("glDrawBuffer");
				Functions.glEnable = getProc<Delegates.glEnable>("glEnable");
				Functions.glFinish = getProc<Delegates.glFinish>("glFinish");
				Functions.glFlush = getProc<Delegates.glFlush>("glFlush");
				Functions.glFrontFace = getProc<Delegates.glFrontFace>("glFrontFace");
				Functions.glGetBooleanv = getProc<Delegates.glGetBooleanv>("glGetBooleanv");
				Functions.glGetDoublev = getProc<Delegates.glGetDoublev>("glGetDoublev");
				Functions.glGetError = getProc<Delegates.glGetError>("glGetError");
				Functions.glGetFloatv = getProc<Delegates.glGetFloatv>("glGetFloatv");
				Functions.glGetIntegerv = getProc<Delegates.glGetIntegerv>("glGetIntegerv");
				Functions.glGetString = getProc<Delegates.glGetString>("glGetString");
				Functions.glGetTexImage = getProc<Delegates.glGetTexImage>("glGetTexImage");
				Functions.glGetTexLevelParameterfv = getProc<Delegates.glGetTexLevelParameterfv>("glGetTexLevelParameterfv");
				Functions.glGetTexLevelParameteriv = getProc<Delegates.glGetTexLevelParameteriv>("glGetTexLevelParameteriv");
				Functions.glGetTexParameterfv = getProc<Delegates.glGetTexParameterfv>("glGetTexParameterfv");
				Functions.glGetTexParameteriv = getProc<Delegates.glGetTexParameteriv>("glGetTexParameteriv");
				Functions.glHint = getProc<Delegates.glHint>("glHint");
				Functions.glIsEnabled = getProc<Delegates.glIsEnabled>("glIsEnabled");
				Functions.glLineWidth = getProc<Delegates.glLineWidth>("glLineWidth");
				Functions.glLogicOp = getProc<Delegates.glLogicOp>("glLogicOp");
				Functions.glPixelStoref = getProc<Delegates.glPixelStoref>("glPixelStoref");
				Functions.glPixelStorei = getProc<Delegates.glPixelStorei>("glPixelStorei");
				Functions.glPointSize = getProc<Delegates.glPointSize>("glPointSize");
				Functions.glPolygonMode = getProc<Delegates.glPolygonMode>("glPolygonMode");
				Functions.glReadBuffer = getProc<Delegates.glReadBuffer>("glReadBuffer");
				Functions.glReadPixels = getProc<Delegates.glReadPixels>("glReadPixels");
				Functions.glScissor = getProc<Delegates.glScissor>("glScissor");
				Functions.glStencilFunc = getProc<Delegates.glStencilFunc>("glStencilFunc");
				Functions.glStencilMask = getProc<Delegates.glStencilMask>("glStencilMask");
				Functions.glStencilOp = getProc<Delegates.glStencilOp>("glStencilOp");
				Functions.glTexImage1D = getProc<Delegates.glTexImage1D>("glTexImage1D");
				Functions.glTexImage2D = getProc<Delegates.glTexImage2D>("glTexImage2D");
				Functions.glTexParameterf = getProc<Delegates.glTexParameterf>("glTexParameterf");
				Functions.glTexParameterfv = getProc<Delegates.glTexParameterfv>("glTexParameterfv");
				Functions.glTexParameteri = getProc<Delegates.glTexParameteri>("glTexParameteri");
				Functions.glTexParameteriv = getProc<Delegates.glTexParameteriv>("glTexParameteriv");
				Functions.glViewport = getProc<Delegates.glViewport>("glViewport");
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 1))
			{
				Functions.glBindTexture = getProc<Delegates.glBindTexture>("glBindTexture");
				Functions.glCopyTexImage1D = getProc<Delegates.glCopyTexImage1D>("glCopyTexImage1D");
				Functions.glCopyTexImage2D = getProc<Delegates.glCopyTexImage2D>("glCopyTexImage2D");
				Functions.glCopyTexSubImage1D = getProc<Delegates.glCopyTexSubImage1D>("glCopyTexSubImage1D");
				Functions.glCopyTexSubImage2D = getProc<Delegates.glCopyTexSubImage2D>("glCopyTexSubImage2D");
				Functions.glDeleteTextures = getProc<Delegates.glDeleteTextures>("glDeleteTextures");
				Functions.glDrawArrays = getProc<Delegates.glDrawArrays>("glDrawArrays");
				Functions.glDrawElements = getProc<Delegates.glDrawElements>("glDrawElements");
				Functions.glGenTextures = getProc<Delegates.glGenTextures>("glGenTextures");
				Functions.glGetPointerv = getProc<Delegates.glGetPointerv>("glGetPointerv");
				Functions.glIsTexture = getProc<Delegates.glIsTexture>("glIsTexture");
				Functions.glPolygonOffset = getProc<Delegates.glPolygonOffset>("glPolygonOffset");
				Functions.glTexSubImage1D = getProc<Delegates.glTexSubImage1D>("glTexSubImage1D");
				Functions.glTexSubImage2D = getProc<Delegates.glTexSubImage2D>("glTexSubImage2D");
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 2))
			{
				Functions.glCopyTexSubImage3D = getProc<Delegates.glCopyTexSubImage3D>("glCopyTexSubImage3D");
				Functions.glDrawRangeElements = getProc<Delegates.glDrawRangeElements>("glDrawRangeElements");
				Functions.glTexImage3D = getProc<Delegates.glTexImage3D>("glTexImage3D");
				Functions.glTexSubImage3D = getProc<Delegates.glTexSubImage3D>("glTexSubImage3D");
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 3))
			{
				Functions.glActiveTexture = getProc<Delegates.glActiveTexture>("glActiveTexture");
				Functions.glCompressedTexImage1D = getProc<Delegates.glCompressedTexImage1D>("glCompressedTexImage1D");
				Functions.glCompressedTexImage2D = getProc<Delegates.glCompressedTexImage2D>("glCompressedTexImage2D");
				Functions.glCompressedTexImage3D = getProc<Delegates.glCompressedTexImage3D>("glCompressedTexImage3D");
				Functions.glCompressedTexSubImage1D = getProc<Delegates.glCompressedTexSubImage1D>("glCompressedTexSubImage1D");
				Functions.glCompressedTexSubImage2D = getProc<Delegates.glCompressedTexSubImage2D>("glCompressedTexSubImage2D");
				Functions.glCompressedTexSubImage3D = getProc<Delegates.glCompressedTexSubImage3D>("glCompressedTexSubImage3D");
				Functions.glGetCompressedTexImage = getProc<Delegates.glGetCompressedTexImage>("glGetCompressedTexImage");
				Functions.glSampleCoverage = getProc<Delegates.glSampleCoverage>("glSampleCoverage");
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 4))
			{
				Functions.glBlendColor = getProc<Delegates.glBlendColor>("glBlendColor");
				Functions.glBlendEquation = getProc<Delegates.glBlendEquation>("glBlendEquation");
				Functions.glBlendFuncSeparate = getProc<Delegates.glBlendFuncSeparate>("glBlendFuncSeparate");
				Functions.glMultiDrawArrays = getProc<Delegates.glMultiDrawArrays>("glMultiDrawArrays");
				Functions.glMultiDrawElements = getProc<Delegates.glMultiDrawElements>("glMultiDrawElements");
				Functions.glPointParameterf = getProc<Delegates.glPointParameterf>("glPointParameterf");
				Functions.glPointParameterfv = getProc<Delegates.glPointParameterfv>("glPointParameterfv");
				Functions.glPointParameteri = getProc<Delegates.glPointParameteri>("glPointParameteri");
				Functions.glPointParameteriv = getProc<Delegates.glPointParameteriv>("glPointParameteriv");
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 5))
			{
				Functions.glBeginQuery = getProc<Delegates.glBeginQuery>("glBeginQuery");
				Functions.glBindBuffer = getProc<Delegates.glBindBuffer>("glBindBuffer");
				Functions.glBufferData = getProc<Delegates.glBufferData>("glBufferData");
				Functions.glBufferSubData = getProc<Delegates.glBufferSubData>("glBufferSubData");
				Functions.glDeleteBuffers = getProc<Delegates.glDeleteBuffers>("glDeleteBuffers");
				Functions.glDeleteQueries = getProc<Delegates.glDeleteQueries>("glDeleteQueries");
				Functions.glEndQuery = getProc<Delegates.glEndQuery>("glEndQuery");
				Functions.glGenBuffers = getProc<Delegates.glGenBuffers>("glGenBuffers");
				Functions.glGenQueries = getProc<Delegates.glGenQueries>("glGenQueries");
				Functions.glGetBufferParameteriv = getProc<Delegates.glGetBufferParameteriv>("glGetBufferParameteriv");
				Functions.glGetBufferPointerv = getProc<Delegates.glGetBufferPointerv>("glGetBufferPointerv");
				Functions.glGetBufferSubData = getProc<Delegates.glGetBufferSubData>("glGetBufferSubData");
				Functions.glGetQueryiv = getProc<Delegates.glGetQueryiv>("glGetQueryiv");
				Functions.glGetQueryObjectiv = getProc<Delegates.glGetQueryObjectiv>("glGetQueryObjectiv");
				Functions.glGetQueryObjectuiv = getProc<Delegates.glGetQueryObjectuiv>("glGetQueryObjectuiv");
				Functions.glIsBuffer = getProc<Delegates.glIsBuffer>("glIsBuffer");
				Functions.glIsQuery = getProc<Delegates.glIsQuery>("glIsQuery");
				Functions.glMapBuffer = getProc<Delegates.glMapBuffer>("glMapBuffer");
				Functions.glUnmapBuffer = getProc<Delegates.glUnmapBuffer>("glUnmapBuffer");
			}

			if (versionMajor > 2 || (versionMajor == 2 && versionMinor >= 0))
			{
				Functions.glAttachShader = getProc<Delegates.glAttachShader>("glAttachShader");
				Functions.glBindAttribLocation = getProc<Delegates.glBindAttribLocation>("glBindAttribLocation");
				Functions.glBlendEquationSeparate = getProc<Delegates.glBlendEquationSeparate>("glBlendEquationSeparate");
				Functions.glCompileShader = getProc<Delegates.glCompileShader>("glCompileShader");
				Functions.glCreateProgram = getProc<Delegates.glCreateProgram>("glCreateProgram");
				Functions.glCreateShader = getProc<Delegates.glCreateShader>("glCreateShader");
				Functions.glDeleteProgram = getProc<Delegates.glDeleteProgram>("glDeleteProgram");
				Functions.glDeleteShader = getProc<Delegates.glDeleteShader>("glDeleteShader");
				Functions.glDetachShader = getProc<Delegates.glDetachShader>("glDetachShader");
				Functions.glDisableVertexAttribArray = getProc<Delegates.glDisableVertexAttribArray>("glDisableVertexAttribArray");
				Functions.glDrawBuffers = getProc<Delegates.glDrawBuffers>("glDrawBuffers");
				Functions.glEnableVertexAttribArray = getProc<Delegates.glEnableVertexAttribArray>("glEnableVertexAttribArray");
				Functions.glGetActiveAttrib = getProc<Delegates.glGetActiveAttrib>("glGetActiveAttrib");
				Functions.glGetActiveUniform = getProc<Delegates.glGetActiveUniform>("glGetActiveUniform");
				Functions.glGetAttachedShaders = getProc<Delegates.glGetAttachedShaders>("glGetAttachedShaders");
				Functions.glGetAttribLocation = getProc<Delegates.glGetAttribLocation>("glGetAttribLocation");
				Functions.glGetProgramInfoLog = getProc<Delegates.glGetProgramInfoLog>("glGetProgramInfoLog");
				Functions.glGetProgramiv = getProc<Delegates.glGetProgramiv>("glGetProgramiv");
				Functions.glGetShaderInfoLog = getProc<Delegates.glGetShaderInfoLog>("glGetShaderInfoLog");
				Functions.glGetShaderiv = getProc<Delegates.glGetShaderiv>("glGetShaderiv");
				Functions.glGetShaderSource = getProc<Delegates.glGetShaderSource>("glGetShaderSource");
				Functions.glGetUniformfv = getProc<Delegates.glGetUniformfv>("glGetUniformfv");
				Functions.glGetUniformiv = getProc<Delegates.glGetUniformiv>("glGetUniformiv");
				Functions.glGetUniformLocation = getProc<Delegates.glGetUniformLocation>("glGetUniformLocation");
				Functions.glGetVertexAttribdv = getProc<Delegates.glGetVertexAttribdv>("glGetVertexAttribdv");
				Functions.glGetVertexAttribfv = getProc<Delegates.glGetVertexAttribfv>("glGetVertexAttribfv");
				Functions.glGetVertexAttribiv = getProc<Delegates.glGetVertexAttribiv>("glGetVertexAttribiv");
				Functions.glGetVertexAttribPointerv = getProc<Delegates.glGetVertexAttribPointerv>("glGetVertexAttribPointerv");
				Functions.glIsProgram = getProc<Delegates.glIsProgram>("glIsProgram");
				Functions.glIsShader = getProc<Delegates.glIsShader>("glIsShader");
				Functions.glLinkProgram = getProc<Delegates.glLinkProgram>("glLinkProgram");
				Functions.glShaderSource = getProc<Delegates.glShaderSource>("glShaderSource");
				Functions.glStencilFuncSeparate = getProc<Delegates.glStencilFuncSeparate>("glStencilFuncSeparate");
				Functions.glStencilMaskSeparate = getProc<Delegates.glStencilMaskSeparate>("glStencilMaskSeparate");
				Functions.glStencilOpSeparate = getProc<Delegates.glStencilOpSeparate>("glStencilOpSeparate");
				Functions.glUniform1f = getProc<Delegates.glUniform1f>("glUniform1f");
				Functions.glUniform1fv = getProc<Delegates.glUniform1fv>("glUniform1fv");
				Functions.glUniform1i = getProc<Delegates.glUniform1i>("glUniform1i");
				Functions.glUniform1iv = getProc<Delegates.glUniform1iv>("glUniform1iv");
				Functions.glUniform2f = getProc<Delegates.glUniform2f>("glUniform2f");
				Functions.glUniform2fv = getProc<Delegates.glUniform2fv>("glUniform2fv");
				Functions.glUniform2i = getProc<Delegates.glUniform2i>("glUniform2i");
				Functions.glUniform2iv = getProc<Delegates.glUniform2iv>("glUniform2iv");
				Functions.glUniform3f = getProc<Delegates.glUniform3f>("glUniform3f");
				Functions.glUniform3fv = getProc<Delegates.glUniform3fv>("glUniform3fv");
				Functions.glUniform3i = getProc<Delegates.glUniform3i>("glUniform3i");
				Functions.glUniform3iv = getProc<Delegates.glUniform3iv>("glUniform3iv");
				Functions.glUniform4f = getProc<Delegates.glUniform4f>("glUniform4f");
				Functions.glUniform4fv = getProc<Delegates.glUniform4fv>("glUniform4fv");
				Functions.glUniform4i = getProc<Delegates.glUniform4i>("glUniform4i");
				Functions.glUniform4iv = getProc<Delegates.glUniform4iv>("glUniform4iv");
				Functions.glUniformMatrix2fv = getProc<Delegates.glUniformMatrix2fv>("glUniformMatrix2fv");
				Functions.glUniformMatrix3fv = getProc<Delegates.glUniformMatrix3fv>("glUniformMatrix3fv");
				Functions.glUniformMatrix4fv = getProc<Delegates.glUniformMatrix4fv>("glUniformMatrix4fv");
				Functions.glUseProgram = getProc<Delegates.glUseProgram>("glUseProgram");
				Functions.glValidateProgram = getProc<Delegates.glValidateProgram>("glValidateProgram");
				Functions.glVertexAttrib1d = getProc<Delegates.glVertexAttrib1d>("glVertexAttrib1d");
				Functions.glVertexAttrib1dv = getProc<Delegates.glVertexAttrib1dv>("glVertexAttrib1dv");
				Functions.glVertexAttrib1f = getProc<Delegates.glVertexAttrib1f>("glVertexAttrib1f");
				Functions.glVertexAttrib1fv = getProc<Delegates.glVertexAttrib1fv>("glVertexAttrib1fv");
				Functions.glVertexAttrib1s = getProc<Delegates.glVertexAttrib1s>("glVertexAttrib1s");
				Functions.glVertexAttrib1sv = getProc<Delegates.glVertexAttrib1sv>("glVertexAttrib1sv");
				Functions.glVertexAttrib2d = getProc<Delegates.glVertexAttrib2d>("glVertexAttrib2d");
				Functions.glVertexAttrib2dv = getProc<Delegates.glVertexAttrib2dv>("glVertexAttrib2dv");
				Functions.glVertexAttrib2f = getProc<Delegates.glVertexAttrib2f>("glVertexAttrib2f");
				Functions.glVertexAttrib2fv = getProc<Delegates.glVertexAttrib2fv>("glVertexAttrib2fv");
				Functions.glVertexAttrib2s = getProc<Delegates.glVertexAttrib2s>("glVertexAttrib2s");
				Functions.glVertexAttrib2sv = getProc<Delegates.glVertexAttrib2sv>("glVertexAttrib2sv");
				Functions.glVertexAttrib3d = getProc<Delegates.glVertexAttrib3d>("glVertexAttrib3d");
				Functions.glVertexAttrib3dv = getProc<Delegates.glVertexAttrib3dv>("glVertexAttrib3dv");
				Functions.glVertexAttrib3f = getProc<Delegates.glVertexAttrib3f>("glVertexAttrib3f");
				Functions.glVertexAttrib3fv = getProc<Delegates.glVertexAttrib3fv>("glVertexAttrib3fv");
				Functions.glVertexAttrib3s = getProc<Delegates.glVertexAttrib3s>("glVertexAttrib3s");
				Functions.glVertexAttrib3sv = getProc<Delegates.glVertexAttrib3sv>("glVertexAttrib3sv");
				Functions.glVertexAttrib4bv = getProc<Delegates.glVertexAttrib4bv>("glVertexAttrib4bv");
				Functions.glVertexAttrib4d = getProc<Delegates.glVertexAttrib4d>("glVertexAttrib4d");
				Functions.glVertexAttrib4dv = getProc<Delegates.glVertexAttrib4dv>("glVertexAttrib4dv");
				Functions.glVertexAttrib4f = getProc<Delegates.glVertexAttrib4f>("glVertexAttrib4f");
				Functions.glVertexAttrib4fv = getProc<Delegates.glVertexAttrib4fv>("glVertexAttrib4fv");
				Functions.glVertexAttrib4iv = getProc<Delegates.glVertexAttrib4iv>("glVertexAttrib4iv");
				Functions.glVertexAttrib4Nbv = getProc<Delegates.glVertexAttrib4Nbv>("glVertexAttrib4Nbv");
				Functions.glVertexAttrib4Niv = getProc<Delegates.glVertexAttrib4Niv>("glVertexAttrib4Niv");
				Functions.glVertexAttrib4Nsv = getProc<Delegates.glVertexAttrib4Nsv>("glVertexAttrib4Nsv");
				Functions.glVertexAttrib4Nub = getProc<Delegates.glVertexAttrib4Nub>("glVertexAttrib4Nub");
				Functions.glVertexAttrib4Nubv = getProc<Delegates.glVertexAttrib4Nubv>("glVertexAttrib4Nubv");
				Functions.glVertexAttrib4Nuiv = getProc<Delegates.glVertexAttrib4Nuiv>("glVertexAttrib4Nuiv");
				Functions.glVertexAttrib4Nusv = getProc<Delegates.glVertexAttrib4Nusv>("glVertexAttrib4Nusv");
				Functions.glVertexAttrib4s = getProc<Delegates.glVertexAttrib4s>("glVertexAttrib4s");
				Functions.glVertexAttrib4sv = getProc<Delegates.glVertexAttrib4sv>("glVertexAttrib4sv");
				Functions.glVertexAttrib4ubv = getProc<Delegates.glVertexAttrib4ubv>("glVertexAttrib4ubv");
				Functions.glVertexAttrib4uiv = getProc<Delegates.glVertexAttrib4uiv>("glVertexAttrib4uiv");
				Functions.glVertexAttrib4usv = getProc<Delegates.glVertexAttrib4usv>("glVertexAttrib4usv");
				Functions.glVertexAttribPointer = getProc<Delegates.glVertexAttribPointer>("glVertexAttribPointer");
			}

			if (versionMajor > 2 || (versionMajor == 2 && versionMinor >= 1))
			{
				Functions.glUniformMatrix2x3fv = getProc<Delegates.glUniformMatrix2x3fv>("glUniformMatrix2x3fv");
				Functions.glUniformMatrix2x4fv = getProc<Delegates.glUniformMatrix2x4fv>("glUniformMatrix2x4fv");
				Functions.glUniformMatrix3x2fv = getProc<Delegates.glUniformMatrix3x2fv>("glUniformMatrix3x2fv");
				Functions.glUniformMatrix3x4fv = getProc<Delegates.glUniformMatrix3x4fv>("glUniformMatrix3x4fv");
				Functions.glUniformMatrix4x2fv = getProc<Delegates.glUniformMatrix4x2fv>("glUniformMatrix4x2fv");
				Functions.glUniformMatrix4x3fv = getProc<Delegates.glUniformMatrix4x3fv>("glUniformMatrix4x3fv");
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 0))
			{
				Functions.glBeginConditionalRender = getProc<Delegates.glBeginConditionalRender>("glBeginConditionalRender");
				Functions.glBeginTransformFeedback = getProc<Delegates.glBeginTransformFeedback>("glBeginTransformFeedback");
				Functions.glBindBufferBase = getProc<Delegates.glBindBufferBase>("glBindBufferBase");
				Functions.glBindBufferRange = getProc<Delegates.glBindBufferRange>("glBindBufferRange");
				Functions.glBindFragDataLocation = getProc<Delegates.glBindFragDataLocation>("glBindFragDataLocation");
				Functions.glBindFramebuffer = getProc<Delegates.glBindFramebuffer>("glBindFramebuffer");
				Functions.glBindRenderbuffer = getProc<Delegates.glBindRenderbuffer>("glBindRenderbuffer");
				Functions.glBindVertexArray = getProc<Delegates.glBindVertexArray>("glBindVertexArray");
				Functions.glBlitFramebuffer = getProc<Delegates.glBlitFramebuffer>("glBlitFramebuffer");
				Functions.glCheckFramebufferStatus = getProc<Delegates.glCheckFramebufferStatus>("glCheckFramebufferStatus");
				Functions.glClampColor = getProc<Delegates.glClampColor>("glClampColor");
				Functions.glClearBufferfi = getProc<Delegates.glClearBufferfi>("glClearBufferfi");
				Functions.glClearBufferfv = getProc<Delegates.glClearBufferfv>("glClearBufferfv");
				Functions.glClearBufferiv = getProc<Delegates.glClearBufferiv>("glClearBufferiv");
				Functions.glClearBufferuiv = getProc<Delegates.glClearBufferuiv>("glClearBufferuiv");
				Functions.glColorMaski = getProc<Delegates.glColorMaski>("glColorMaski");
				Functions.glDeleteFramebuffers = getProc<Delegates.glDeleteFramebuffers>("glDeleteFramebuffers");
				Functions.glDeleteRenderbuffers = getProc<Delegates.glDeleteRenderbuffers>("glDeleteRenderbuffers");
				Functions.glDeleteVertexArrays = getProc<Delegates.glDeleteVertexArrays>("glDeleteVertexArrays");
				Functions.glDisablei = getProc<Delegates.glDisablei>("glDisablei");
				Functions.glEnablei = getProc<Delegates.glEnablei>("glEnablei");
				Functions.glEndConditionalRender = getProc<Delegates.glEndConditionalRender>("glEndConditionalRender");
				Functions.glEndTransformFeedback = getProc<Delegates.glEndTransformFeedback>("glEndTransformFeedback");
				Functions.glFlushMappedBufferRange = getProc<Delegates.glFlushMappedBufferRange>("glFlushMappedBufferRange");
				Functions.glFramebufferRenderbuffer = getProc<Delegates.glFramebufferRenderbuffer>("glFramebufferRenderbuffer");
				Functions.glFramebufferTexture1D = getProc<Delegates.glFramebufferTexture1D>("glFramebufferTexture1D");
				Functions.glFramebufferTexture2D = getProc<Delegates.glFramebufferTexture2D>("glFramebufferTexture2D");
				Functions.glFramebufferTexture3D = getProc<Delegates.glFramebufferTexture3D>("glFramebufferTexture3D");
				Functions.glFramebufferTextureLayer = getProc<Delegates.glFramebufferTextureLayer>("glFramebufferTextureLayer");
				Functions.glGenerateMipmap = getProc<Delegates.glGenerateMipmap>("glGenerateMipmap");
				Functions.glGenFramebuffers = getProc<Delegates.glGenFramebuffers>("glGenFramebuffers");
				Functions.glGenRenderbuffers = getProc<Delegates.glGenRenderbuffers>("glGenRenderbuffers");
				Functions.glGenVertexArrays = getProc<Delegates.glGenVertexArrays>("glGenVertexArrays");
				Functions.glGetBooleani_v = getProc<Delegates.glGetBooleani_v>("glGetBooleani_v");
				Functions.glGetFragDataLocation = getProc<Delegates.glGetFragDataLocation>("glGetFragDataLocation");
				Functions.glGetFramebufferAttachmentParameteriv = getProc<Delegates.glGetFramebufferAttachmentParameteriv>("glGetFramebufferAttachmentParameteriv");
				Functions.glGetIntegeri_v = getProc<Delegates.glGetIntegeri_v>("glGetIntegeri_v");
				Functions.glGetRenderbufferParameteriv = getProc<Delegates.glGetRenderbufferParameteriv>("glGetRenderbufferParameteriv");
				Functions.glGetStringi = getProc<Delegates.glGetStringi>("glGetStringi");
				Functions.glGetTexParameterIiv = getProc<Delegates.glGetTexParameterIiv>("glGetTexParameterIiv");
				Functions.glGetTexParameterIuiv = getProc<Delegates.glGetTexParameterIuiv>("glGetTexParameterIuiv");
				Functions.glGetTransformFeedbackVarying = getProc<Delegates.glGetTransformFeedbackVarying>("glGetTransformFeedbackVarying");
				Functions.glGetUniformuiv = getProc<Delegates.glGetUniformuiv>("glGetUniformuiv");
				Functions.glGetVertexAttribIiv = getProc<Delegates.glGetVertexAttribIiv>("glGetVertexAttribIiv");
				Functions.glGetVertexAttribIuiv = getProc<Delegates.glGetVertexAttribIuiv>("glGetVertexAttribIuiv");
				Functions.glIsEnabledi = getProc<Delegates.glIsEnabledi>("glIsEnabledi");
				Functions.glIsFramebuffer = getProc<Delegates.glIsFramebuffer>("glIsFramebuffer");
				Functions.glIsRenderbuffer = getProc<Delegates.glIsRenderbuffer>("glIsRenderbuffer");
				Functions.glIsVertexArray = getProc<Delegates.glIsVertexArray>("glIsVertexArray");
				Functions.glMapBufferRange = getProc<Delegates.glMapBufferRange>("glMapBufferRange");
				Functions.glRenderbufferStorage = getProc<Delegates.glRenderbufferStorage>("glRenderbufferStorage");
				Functions.glRenderbufferStorageMultisample = getProc<Delegates.glRenderbufferStorageMultisample>("glRenderbufferStorageMultisample");
				Functions.glTexParameterIiv = getProc<Delegates.glTexParameterIiv>("glTexParameterIiv");
				Functions.glTexParameterIuiv = getProc<Delegates.glTexParameterIuiv>("glTexParameterIuiv");
				Functions.glTransformFeedbackVaryings = getProc<Delegates.glTransformFeedbackVaryings>("glTransformFeedbackVaryings");
				Functions.glUniform1ui = getProc<Delegates.glUniform1ui>("glUniform1ui");
				Functions.glUniform1uiv = getProc<Delegates.glUniform1uiv>("glUniform1uiv");
				Functions.glUniform2ui = getProc<Delegates.glUniform2ui>("glUniform2ui");
				Functions.glUniform2uiv = getProc<Delegates.glUniform2uiv>("glUniform2uiv");
				Functions.glUniform3ui = getProc<Delegates.glUniform3ui>("glUniform3ui");
				Functions.glUniform3uiv = getProc<Delegates.glUniform3uiv>("glUniform3uiv");
				Functions.glUniform4ui = getProc<Delegates.glUniform4ui>("glUniform4ui");
				Functions.glUniform4uiv = getProc<Delegates.glUniform4uiv>("glUniform4uiv");
				Functions.glVertexAttribI1i = getProc<Delegates.glVertexAttribI1i>("glVertexAttribI1i");
				Functions.glVertexAttribI1iv = getProc<Delegates.glVertexAttribI1iv>("glVertexAttribI1iv");
				Functions.glVertexAttribI1ui = getProc<Delegates.glVertexAttribI1ui>("glVertexAttribI1ui");
				Functions.glVertexAttribI1uiv = getProc<Delegates.glVertexAttribI1uiv>("glVertexAttribI1uiv");
				Functions.glVertexAttribI2i = getProc<Delegates.glVertexAttribI2i>("glVertexAttribI2i");
				Functions.glVertexAttribI2iv = getProc<Delegates.glVertexAttribI2iv>("glVertexAttribI2iv");
				Functions.glVertexAttribI2ui = getProc<Delegates.glVertexAttribI2ui>("glVertexAttribI2ui");
				Functions.glVertexAttribI2uiv = getProc<Delegates.glVertexAttribI2uiv>("glVertexAttribI2uiv");
				Functions.glVertexAttribI3i = getProc<Delegates.glVertexAttribI3i>("glVertexAttribI3i");
				Functions.glVertexAttribI3iv = getProc<Delegates.glVertexAttribI3iv>("glVertexAttribI3iv");
				Functions.glVertexAttribI3ui = getProc<Delegates.glVertexAttribI3ui>("glVertexAttribI3ui");
				Functions.glVertexAttribI3uiv = getProc<Delegates.glVertexAttribI3uiv>("glVertexAttribI3uiv");
				Functions.glVertexAttribI4bv = getProc<Delegates.glVertexAttribI4bv>("glVertexAttribI4bv");
				Functions.glVertexAttribI4i = getProc<Delegates.glVertexAttribI4i>("glVertexAttribI4i");
				Functions.glVertexAttribI4iv = getProc<Delegates.glVertexAttribI4iv>("glVertexAttribI4iv");
				Functions.glVertexAttribI4sv = getProc<Delegates.glVertexAttribI4sv>("glVertexAttribI4sv");
				Functions.glVertexAttribI4ubv = getProc<Delegates.glVertexAttribI4ubv>("glVertexAttribI4ubv");
				Functions.glVertexAttribI4ui = getProc<Delegates.glVertexAttribI4ui>("glVertexAttribI4ui");
				Functions.glVertexAttribI4uiv = getProc<Delegates.glVertexAttribI4uiv>("glVertexAttribI4uiv");
				Functions.glVertexAttribI4usv = getProc<Delegates.glVertexAttribI4usv>("glVertexAttribI4usv");
				Functions.glVertexAttribIPointer = getProc<Delegates.glVertexAttribIPointer>("glVertexAttribIPointer");
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 1))
			{
				Functions.glCopyBufferSubData = getProc<Delegates.glCopyBufferSubData>("glCopyBufferSubData");
				Functions.glDrawArraysInstanced = getProc<Delegates.glDrawArraysInstanced>("glDrawArraysInstanced");
				Functions.glDrawElementsInstanced = getProc<Delegates.glDrawElementsInstanced>("glDrawElementsInstanced");
				Functions.glGetActiveUniformBlockiv = getProc<Delegates.glGetActiveUniformBlockiv>("glGetActiveUniformBlockiv");
				Functions.glGetActiveUniformBlockName = getProc<Delegates.glGetActiveUniformBlockName>("glGetActiveUniformBlockName");
				Functions.glGetActiveUniformName = getProc<Delegates.glGetActiveUniformName>("glGetActiveUniformName");
				Functions.glGetActiveUniformsiv = getProc<Delegates.glGetActiveUniformsiv>("glGetActiveUniformsiv");
				Functions.glGetUniformBlockIndex = getProc<Delegates.glGetUniformBlockIndex>("glGetUniformBlockIndex");
				Functions.glGetUniformIndices = getProc<Delegates.glGetUniformIndices>("glGetUniformIndices");
				Functions.glPrimitiveRestartIndex = getProc<Delegates.glPrimitiveRestartIndex>("glPrimitiveRestartIndex");
				Functions.glTexBuffer = getProc<Delegates.glTexBuffer>("glTexBuffer");
				Functions.glUniformBlockBinding = getProc<Delegates.glUniformBlockBinding>("glUniformBlockBinding");
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 2))
			{
				Functions.glClientWaitSync = getProc<Delegates.glClientWaitSync>("glClientWaitSync");
				Functions.glDeleteSync = getProc<Delegates.glDeleteSync>("glDeleteSync");
				Functions.glDrawElementsBaseVertex = getProc<Delegates.glDrawElementsBaseVertex>("glDrawElementsBaseVertex");
				Functions.glDrawElementsInstancedBaseVertex = getProc<Delegates.glDrawElementsInstancedBaseVertex>("glDrawElementsInstancedBaseVertex");
				Functions.glDrawRangeElementsBaseVertex = getProc<Delegates.glDrawRangeElementsBaseVertex>("glDrawRangeElementsBaseVertex");
				Functions.glFenceSync = getProc<Delegates.glFenceSync>("glFenceSync");
				Functions.glFramebufferTexture = getProc<Delegates.glFramebufferTexture>("glFramebufferTexture");
				Functions.glGetBufferParameteri64v = getProc<Delegates.glGetBufferParameteri64v>("glGetBufferParameteri64v");
				Functions.glGetInteger64i_v = getProc<Delegates.glGetInteger64i_v>("glGetInteger64i_v");
				Functions.glGetInteger64v = getProc<Delegates.glGetInteger64v>("glGetInteger64v");
				Functions.glGetMultisamplefv = getProc<Delegates.glGetMultisamplefv>("glGetMultisamplefv");
				Functions.glGetSynciv = getProc<Delegates.glGetSynciv>("glGetSynciv");
				Functions.glIsSync = getProc<Delegates.glIsSync>("glIsSync");
				Functions.glMultiDrawElementsBaseVertex = getProc<Delegates.glMultiDrawElementsBaseVertex>("glMultiDrawElementsBaseVertex");
				Functions.glProvokingVertex = getProc<Delegates.glProvokingVertex>("glProvokingVertex");
				Functions.glSampleMaski = getProc<Delegates.glSampleMaski>("glSampleMaski");
				Functions.glTexImage2DMultisample = getProc<Delegates.glTexImage2DMultisample>("glTexImage2DMultisample");
				Functions.glTexImage3DMultisample = getProc<Delegates.glTexImage3DMultisample>("glTexImage3DMultisample");
				Functions.glWaitSync = getProc<Delegates.glWaitSync>("glWaitSync");
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 3))
			{
				Functions.glBindFragDataLocationIndexed = getProc<Delegates.glBindFragDataLocationIndexed>("glBindFragDataLocationIndexed");
				Functions.glBindSampler = getProc<Delegates.glBindSampler>("glBindSampler");
				Functions.glDeleteSamplers = getProc<Delegates.glDeleteSamplers>("glDeleteSamplers");
				Functions.glGenSamplers = getProc<Delegates.glGenSamplers>("glGenSamplers");
				Functions.glGetFragDataIndex = getProc<Delegates.glGetFragDataIndex>("glGetFragDataIndex");
				Functions.glGetQueryObjecti64v = getProc<Delegates.glGetQueryObjecti64v>("glGetQueryObjecti64v");
				Functions.glGetQueryObjectui64v = getProc<Delegates.glGetQueryObjectui64v>("glGetQueryObjectui64v");
				Functions.glGetSamplerParameterfv = getProc<Delegates.glGetSamplerParameterfv>("glGetSamplerParameterfv");
				Functions.glGetSamplerParameterIiv = getProc<Delegates.glGetSamplerParameterIiv>("glGetSamplerParameterIiv");
				Functions.glGetSamplerParameterIuiv = getProc<Delegates.glGetSamplerParameterIuiv>("glGetSamplerParameterIuiv");
				Functions.glGetSamplerParameteriv = getProc<Delegates.glGetSamplerParameteriv>("glGetSamplerParameteriv");
				Functions.glIsSampler = getProc<Delegates.glIsSampler>("glIsSampler");
				Functions.glQueryCounter = getProc<Delegates.glQueryCounter>("glQueryCounter");
				Functions.glSamplerParameterf = getProc<Delegates.glSamplerParameterf>("glSamplerParameterf");
				Functions.glSamplerParameterfv = getProc<Delegates.glSamplerParameterfv>("glSamplerParameterfv");
				Functions.glSamplerParameteri = getProc<Delegates.glSamplerParameteri>("glSamplerParameteri");
				Functions.glSamplerParameterIiv = getProc<Delegates.glSamplerParameterIiv>("glSamplerParameterIiv");
				Functions.glSamplerParameterIuiv = getProc<Delegates.glSamplerParameterIuiv>("glSamplerParameterIuiv");
				Functions.glSamplerParameteriv = getProc<Delegates.glSamplerParameteriv>("glSamplerParameteriv");
				Functions.glVertexAttribDivisor = getProc<Delegates.glVertexAttribDivisor>("glVertexAttribDivisor");
				Functions.glVertexAttribP1ui = getProc<Delegates.glVertexAttribP1ui>("glVertexAttribP1ui");
				Functions.glVertexAttribP1uiv = getProc<Delegates.glVertexAttribP1uiv>("glVertexAttribP1uiv");
				Functions.glVertexAttribP2ui = getProc<Delegates.glVertexAttribP2ui>("glVertexAttribP2ui");
				Functions.glVertexAttribP2uiv = getProc<Delegates.glVertexAttribP2uiv>("glVertexAttribP2uiv");
				Functions.glVertexAttribP3ui = getProc<Delegates.glVertexAttribP3ui>("glVertexAttribP3ui");
				Functions.glVertexAttribP3uiv = getProc<Delegates.glVertexAttribP3uiv>("glVertexAttribP3uiv");
				Functions.glVertexAttribP4ui = getProc<Delegates.glVertexAttribP4ui>("glVertexAttribP4ui");
				Functions.glVertexAttribP4uiv = getProc<Delegates.glVertexAttribP4uiv>("glVertexAttribP4uiv");
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 0))
			{
				Functions.glBeginQueryIndexed = getProc<Delegates.glBeginQueryIndexed>("glBeginQueryIndexed");
				Functions.glBindTransformFeedback = getProc<Delegates.glBindTransformFeedback>("glBindTransformFeedback");
				Functions.glBlendEquationi = getProc<Delegates.glBlendEquationi>("glBlendEquationi");
				Functions.glBlendEquationSeparatei = getProc<Delegates.glBlendEquationSeparatei>("glBlendEquationSeparatei");
				Functions.glBlendFunci = getProc<Delegates.glBlendFunci>("glBlendFunci");
				Functions.glBlendFuncSeparatei = getProc<Delegates.glBlendFuncSeparatei>("glBlendFuncSeparatei");
				Functions.glDeleteTransformFeedbacks = getProc<Delegates.glDeleteTransformFeedbacks>("glDeleteTransformFeedbacks");
				Functions.glDrawArraysIndirect = getProc<Delegates.glDrawArraysIndirect>("glDrawArraysIndirect");
				Functions.glDrawElementsIndirect = getProc<Delegates.glDrawElementsIndirect>("glDrawElementsIndirect");
				Functions.glDrawTransformFeedback = getProc<Delegates.glDrawTransformFeedback>("glDrawTransformFeedback");
				Functions.glDrawTransformFeedbackStream = getProc<Delegates.glDrawTransformFeedbackStream>("glDrawTransformFeedbackStream");
				Functions.glEndQueryIndexed = getProc<Delegates.glEndQueryIndexed>("glEndQueryIndexed");
				Functions.glGenTransformFeedbacks = getProc<Delegates.glGenTransformFeedbacks>("glGenTransformFeedbacks");
				Functions.glGetActiveSubroutineName = getProc<Delegates.glGetActiveSubroutineName>("glGetActiveSubroutineName");
				Functions.glGetActiveSubroutineUniformiv = getProc<Delegates.glGetActiveSubroutineUniformiv>("glGetActiveSubroutineUniformiv");
				Functions.glGetActiveSubroutineUniformName = getProc<Delegates.glGetActiveSubroutineUniformName>("glGetActiveSubroutineUniformName");
				Functions.glGetProgramStageiv = getProc<Delegates.glGetProgramStageiv>("glGetProgramStageiv");
				Functions.glGetQueryIndexediv = getProc<Delegates.glGetQueryIndexediv>("glGetQueryIndexediv");
				Functions.glGetSubroutineIndex = getProc<Delegates.glGetSubroutineIndex>("glGetSubroutineIndex");
				Functions.glGetSubroutineUniformLocation = getProc<Delegates.glGetSubroutineUniformLocation>("glGetSubroutineUniformLocation");
				Functions.glGetUniformdv = getProc<Delegates.glGetUniformdv>("glGetUniformdv");
				Functions.glGetUniformSubroutineuiv = getProc<Delegates.glGetUniformSubroutineuiv>("glGetUniformSubroutineuiv");
				Functions.glIsTransformFeedback = getProc<Delegates.glIsTransformFeedback>("glIsTransformFeedback");
				Functions.glMinSampleShading = getProc<Delegates.glMinSampleShading>("glMinSampleShading");
				Functions.glPatchParameterfv = getProc<Delegates.glPatchParameterfv>("glPatchParameterfv");
				Functions.glPatchParameteri = getProc<Delegates.glPatchParameteri>("glPatchParameteri");
				Functions.glPauseTransformFeedback = getProc<Delegates.glPauseTransformFeedback>("glPauseTransformFeedback");
				Functions.glResumeTransformFeedback = getProc<Delegates.glResumeTransformFeedback>("glResumeTransformFeedback");
				Functions.glUniform1d = getProc<Delegates.glUniform1d>("glUniform1d");
				Functions.glUniform1dv = getProc<Delegates.glUniform1dv>("glUniform1dv");
				Functions.glUniform2d = getProc<Delegates.glUniform2d>("glUniform2d");
				Functions.glUniform2dv = getProc<Delegates.glUniform2dv>("glUniform2dv");
				Functions.glUniform3d = getProc<Delegates.glUniform3d>("glUniform3d");
				Functions.glUniform3dv = getProc<Delegates.glUniform3dv>("glUniform3dv");
				Functions.glUniform4d = getProc<Delegates.glUniform4d>("glUniform4d");
				Functions.glUniform4dv = getProc<Delegates.glUniform4dv>("glUniform4dv");
				Functions.glUniformMatrix2dv = getProc<Delegates.glUniformMatrix2dv>("glUniformMatrix2dv");
				Functions.glUniformMatrix2x3dv = getProc<Delegates.glUniformMatrix2x3dv>("glUniformMatrix2x3dv");
				Functions.glUniformMatrix2x4dv = getProc<Delegates.glUniformMatrix2x4dv>("glUniformMatrix2x4dv");
				Functions.glUniformMatrix3dv = getProc<Delegates.glUniformMatrix3dv>("glUniformMatrix3dv");
				Functions.glUniformMatrix3x2dv = getProc<Delegates.glUniformMatrix3x2dv>("glUniformMatrix3x2dv");
				Functions.glUniformMatrix3x4dv = getProc<Delegates.glUniformMatrix3x4dv>("glUniformMatrix3x4dv");
				Functions.glUniformMatrix4dv = getProc<Delegates.glUniformMatrix4dv>("glUniformMatrix4dv");
				Functions.glUniformMatrix4x2dv = getProc<Delegates.glUniformMatrix4x2dv>("glUniformMatrix4x2dv");
				Functions.glUniformMatrix4x3dv = getProc<Delegates.glUniformMatrix4x3dv>("glUniformMatrix4x3dv");
				Functions.glUniformSubroutinesuiv = getProc<Delegates.glUniformSubroutinesuiv>("glUniformSubroutinesuiv");
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 1))
			{
				Functions.glActiveShaderProgram = getProc<Delegates.glActiveShaderProgram>("glActiveShaderProgram");
				Functions.glBindProgramPipeline = getProc<Delegates.glBindProgramPipeline>("glBindProgramPipeline");
				Functions.glClearDepthf = getProc<Delegates.glClearDepthf>("glClearDepthf");
				Functions.glCreateShaderProgramv = getProc<Delegates.glCreateShaderProgramv>("glCreateShaderProgramv");
				Functions.glDeleteProgramPipelines = getProc<Delegates.glDeleteProgramPipelines>("glDeleteProgramPipelines");
				Functions.glDepthRangeArrayv = getProc<Delegates.glDepthRangeArrayv>("glDepthRangeArrayv");
				Functions.glDepthRangef = getProc<Delegates.glDepthRangef>("glDepthRangef");
				Functions.glDepthRangeIndexed = getProc<Delegates.glDepthRangeIndexed>("glDepthRangeIndexed");
				Functions.glGenProgramPipelines = getProc<Delegates.glGenProgramPipelines>("glGenProgramPipelines");
				Functions.glGetDoublei_v = getProc<Delegates.glGetDoublei_v>("glGetDoublei_v");
				Functions.glGetFloati_v = getProc<Delegates.glGetFloati_v>("glGetFloati_v");
				Functions.glGetProgramBinary = getProc<Delegates.glGetProgramBinary>("glGetProgramBinary");
				Functions.glGetProgramPipelineInfoLog = getProc<Delegates.glGetProgramPipelineInfoLog>("glGetProgramPipelineInfoLog");
				Functions.glGetProgramPipelineiv = getProc<Delegates.glGetProgramPipelineiv>("glGetProgramPipelineiv");
				Functions.glGetShaderPrecisionFormat = getProc<Delegates.glGetShaderPrecisionFormat>("glGetShaderPrecisionFormat");
				Functions.glGetVertexAttribLdv = getProc<Delegates.glGetVertexAttribLdv>("glGetVertexAttribLdv");
				Functions.glIsProgramPipeline = getProc<Delegates.glIsProgramPipeline>("glIsProgramPipeline");
				Functions.glProgramBinary = getProc<Delegates.glProgramBinary>("glProgramBinary");
				Functions.glProgramParameteri = getProc<Delegates.glProgramParameteri>("glProgramParameteri");
				Functions.glProgramUniform1d = getProc<Delegates.glProgramUniform1d>("glProgramUniform1d");
				Functions.glProgramUniform1dv = getProc<Delegates.glProgramUniform1dv>("glProgramUniform1dv");
				Functions.glProgramUniform1f = getProc<Delegates.glProgramUniform1f>("glProgramUniform1f");
				Functions.glProgramUniform1fv = getProc<Delegates.glProgramUniform1fv>("glProgramUniform1fv");
				Functions.glProgramUniform1i = getProc<Delegates.glProgramUniform1i>("glProgramUniform1i");
				Functions.glProgramUniform1iv = getProc<Delegates.glProgramUniform1iv>("glProgramUniform1iv");
				Functions.glProgramUniform1ui = getProc<Delegates.glProgramUniform1ui>("glProgramUniform1ui");
				Functions.glProgramUniform1uiv = getProc<Delegates.glProgramUniform1uiv>("glProgramUniform1uiv");
				Functions.glProgramUniform2d = getProc<Delegates.glProgramUniform2d>("glProgramUniform2d");
				Functions.glProgramUniform2dv = getProc<Delegates.glProgramUniform2dv>("glProgramUniform2dv");
				Functions.glProgramUniform2f = getProc<Delegates.glProgramUniform2f>("glProgramUniform2f");
				Functions.glProgramUniform2fv = getProc<Delegates.glProgramUniform2fv>("glProgramUniform2fv");
				Functions.glProgramUniform2i = getProc<Delegates.glProgramUniform2i>("glProgramUniform2i");
				Functions.glProgramUniform2iv = getProc<Delegates.glProgramUniform2iv>("glProgramUniform2iv");
				Functions.glProgramUniform2ui = getProc<Delegates.glProgramUniform2ui>("glProgramUniform2ui");
				Functions.glProgramUniform2uiv = getProc<Delegates.glProgramUniform2uiv>("glProgramUniform2uiv");
				Functions.glProgramUniform3d = getProc<Delegates.glProgramUniform3d>("glProgramUniform3d");
				Functions.glProgramUniform3dv = getProc<Delegates.glProgramUniform3dv>("glProgramUniform3dv");
				Functions.glProgramUniform3f = getProc<Delegates.glProgramUniform3f>("glProgramUniform3f");
				Functions.glProgramUniform3fv = getProc<Delegates.glProgramUniform3fv>("glProgramUniform3fv");
				Functions.glProgramUniform3i = getProc<Delegates.glProgramUniform3i>("glProgramUniform3i");
				Functions.glProgramUniform3iv = getProc<Delegates.glProgramUniform3iv>("glProgramUniform3iv");
				Functions.glProgramUniform3ui = getProc<Delegates.glProgramUniform3ui>("glProgramUniform3ui");
				Functions.glProgramUniform3uiv = getProc<Delegates.glProgramUniform3uiv>("glProgramUniform3uiv");
				Functions.glProgramUniform4d = getProc<Delegates.glProgramUniform4d>("glProgramUniform4d");
				Functions.glProgramUniform4dv = getProc<Delegates.glProgramUniform4dv>("glProgramUniform4dv");
				Functions.glProgramUniform4f = getProc<Delegates.glProgramUniform4f>("glProgramUniform4f");
				Functions.glProgramUniform4fv = getProc<Delegates.glProgramUniform4fv>("glProgramUniform4fv");
				Functions.glProgramUniform4i = getProc<Delegates.glProgramUniform4i>("glProgramUniform4i");
				Functions.glProgramUniform4iv = getProc<Delegates.glProgramUniform4iv>("glProgramUniform4iv");
				Functions.glProgramUniform4ui = getProc<Delegates.glProgramUniform4ui>("glProgramUniform4ui");
				Functions.glProgramUniform4uiv = getProc<Delegates.glProgramUniform4uiv>("glProgramUniform4uiv");
				Functions.glProgramUniformMatrix2dv = getProc<Delegates.glProgramUniformMatrix2dv>("glProgramUniformMatrix2dv");
				Functions.glProgramUniformMatrix2fv = getProc<Delegates.glProgramUniformMatrix2fv>("glProgramUniformMatrix2fv");
				Functions.glProgramUniformMatrix2x3dv = getProc<Delegates.glProgramUniformMatrix2x3dv>("glProgramUniformMatrix2x3dv");
				Functions.glProgramUniformMatrix2x3fv = getProc<Delegates.glProgramUniformMatrix2x3fv>("glProgramUniformMatrix2x3fv");
				Functions.glProgramUniformMatrix2x4dv = getProc<Delegates.glProgramUniformMatrix2x4dv>("glProgramUniformMatrix2x4dv");
				Functions.glProgramUniformMatrix2x4fv = getProc<Delegates.glProgramUniformMatrix2x4fv>("glProgramUniformMatrix2x4fv");
				Functions.glProgramUniformMatrix3dv = getProc<Delegates.glProgramUniformMatrix3dv>("glProgramUniformMatrix3dv");
				Functions.glProgramUniformMatrix3fv = getProc<Delegates.glProgramUniformMatrix3fv>("glProgramUniformMatrix3fv");
				Functions.glProgramUniformMatrix3x2dv = getProc<Delegates.glProgramUniformMatrix3x2dv>("glProgramUniformMatrix3x2dv");
				Functions.glProgramUniformMatrix3x2fv = getProc<Delegates.glProgramUniformMatrix3x2fv>("glProgramUniformMatrix3x2fv");
				Functions.glProgramUniformMatrix3x4dv = getProc<Delegates.glProgramUniformMatrix3x4dv>("glProgramUniformMatrix3x4dv");
				Functions.glProgramUniformMatrix3x4fv = getProc<Delegates.glProgramUniformMatrix3x4fv>("glProgramUniformMatrix3x4fv");
				Functions.glProgramUniformMatrix4dv = getProc<Delegates.glProgramUniformMatrix4dv>("glProgramUniformMatrix4dv");
				Functions.glProgramUniformMatrix4fv = getProc<Delegates.glProgramUniformMatrix4fv>("glProgramUniformMatrix4fv");
				Functions.glProgramUniformMatrix4x2dv = getProc<Delegates.glProgramUniformMatrix4x2dv>("glProgramUniformMatrix4x2dv");
				Functions.glProgramUniformMatrix4x2fv = getProc<Delegates.glProgramUniformMatrix4x2fv>("glProgramUniformMatrix4x2fv");
				Functions.glProgramUniformMatrix4x3dv = getProc<Delegates.glProgramUniformMatrix4x3dv>("glProgramUniformMatrix4x3dv");
				Functions.glProgramUniformMatrix4x3fv = getProc<Delegates.glProgramUniformMatrix4x3fv>("glProgramUniformMatrix4x3fv");
				Functions.glReleaseShaderCompiler = getProc<Delegates.glReleaseShaderCompiler>("glReleaseShaderCompiler");
				Functions.glScissorArrayv = getProc<Delegates.glScissorArrayv>("glScissorArrayv");
				Functions.glScissorIndexed = getProc<Delegates.glScissorIndexed>("glScissorIndexed");
				Functions.glScissorIndexedv = getProc<Delegates.glScissorIndexedv>("glScissorIndexedv");
				Functions.glShaderBinary = getProc<Delegates.glShaderBinary>("glShaderBinary");
				Functions.glUseProgramStages = getProc<Delegates.glUseProgramStages>("glUseProgramStages");
				Functions.glValidateProgramPipeline = getProc<Delegates.glValidateProgramPipeline>("glValidateProgramPipeline");
				Functions.glVertexAttribL1d = getProc<Delegates.glVertexAttribL1d>("glVertexAttribL1d");
				Functions.glVertexAttribL1dv = getProc<Delegates.glVertexAttribL1dv>("glVertexAttribL1dv");
				Functions.glVertexAttribL2d = getProc<Delegates.glVertexAttribL2d>("glVertexAttribL2d");
				Functions.glVertexAttribL2dv = getProc<Delegates.glVertexAttribL2dv>("glVertexAttribL2dv");
				Functions.glVertexAttribL3d = getProc<Delegates.glVertexAttribL3d>("glVertexAttribL3d");
				Functions.glVertexAttribL3dv = getProc<Delegates.glVertexAttribL3dv>("glVertexAttribL3dv");
				Functions.glVertexAttribL4d = getProc<Delegates.glVertexAttribL4d>("glVertexAttribL4d");
				Functions.glVertexAttribL4dv = getProc<Delegates.glVertexAttribL4dv>("glVertexAttribL4dv");
				Functions.glVertexAttribLPointer = getProc<Delegates.glVertexAttribLPointer>("glVertexAttribLPointer");
				Functions.glViewportArrayv = getProc<Delegates.glViewportArrayv>("glViewportArrayv");
				Functions.glViewportIndexedf = getProc<Delegates.glViewportIndexedf>("glViewportIndexedf");
				Functions.glViewportIndexedfv = getProc<Delegates.glViewportIndexedfv>("glViewportIndexedfv");
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 2))
			{
				Functions.glBindImageTexture = getProc<Delegates.glBindImageTexture>("glBindImageTexture");
				Functions.glDrawArraysInstancedBaseInstance = getProc<Delegates.glDrawArraysInstancedBaseInstance>("glDrawArraysInstancedBaseInstance");
				Functions.glDrawElementsInstancedBaseInstance = getProc<Delegates.glDrawElementsInstancedBaseInstance>("glDrawElementsInstancedBaseInstance");
				Functions.glDrawElementsInstancedBaseVertexBaseInstance = getProc<Delegates.glDrawElementsInstancedBaseVertexBaseInstance>("glDrawElementsInstancedBaseVertexBaseInstance");
				Functions.glDrawTransformFeedbackInstanced = getProc<Delegates.glDrawTransformFeedbackInstanced>("glDrawTransformFeedbackInstanced");
				Functions.glDrawTransformFeedbackStreamInstanced = getProc<Delegates.glDrawTransformFeedbackStreamInstanced>("glDrawTransformFeedbackStreamInstanced");
				Functions.glGetActiveAtomicCounterBufferiv = getProc<Delegates.glGetActiveAtomicCounterBufferiv>("glGetActiveAtomicCounterBufferiv");
				Functions.glGetInternalformativ = getProc<Delegates.glGetInternalformativ>("glGetInternalformativ");
				Functions.glMemoryBarrier = getProc<Delegates.glMemoryBarrier>("glMemoryBarrier");
				Functions.glTexStorage1D = getProc<Delegates.glTexStorage1D>("glTexStorage1D");
				Functions.glTexStorage2D = getProc<Delegates.glTexStorage2D>("glTexStorage2D");
				Functions.glTexStorage3D = getProc<Delegates.glTexStorage3D>("glTexStorage3D");
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 3))
			{
				Functions.glBindVertexBuffer = getProc<Delegates.glBindVertexBuffer>("glBindVertexBuffer");
				Functions.glClearBufferData = getProc<Delegates.glClearBufferData>("glClearBufferData");
				Functions.glClearBufferSubData = getProc<Delegates.glClearBufferSubData>("glClearBufferSubData");
				Functions.glCopyImageSubData = getProc<Delegates.glCopyImageSubData>("glCopyImageSubData");
				Functions.glDebugMessageCallback = getProc<Delegates.glDebugMessageCallback>("glDebugMessageCallback");
				Functions.glDebugMessageControl = getProc<Delegates.glDebugMessageControl>("glDebugMessageControl");
				Functions.glDebugMessageInsert = getProc<Delegates.glDebugMessageInsert>("glDebugMessageInsert");
				Functions.glDispatchCompute = getProc<Delegates.glDispatchCompute>("glDispatchCompute");
				Functions.glDispatchComputeIndirect = getProc<Delegates.glDispatchComputeIndirect>("glDispatchComputeIndirect");
				Functions.glFramebufferParameteri = getProc<Delegates.glFramebufferParameteri>("glFramebufferParameteri");
				Functions.glGetDebugMessageLog = getProc<Delegates.glGetDebugMessageLog>("glGetDebugMessageLog");
				Functions.glGetFramebufferParameteriv = getProc<Delegates.glGetFramebufferParameteriv>("glGetFramebufferParameteriv");
				Functions.glGetInternalformati64v = getProc<Delegates.glGetInternalformati64v>("glGetInternalformati64v");
				Functions.glGetObjectLabel = getProc<Delegates.glGetObjectLabel>("glGetObjectLabel");
				Functions.glGetObjectPtrLabel = getProc<Delegates.glGetObjectPtrLabel>("glGetObjectPtrLabel");
				Functions.glGetProgramInterfaceiv = getProc<Delegates.glGetProgramInterfaceiv>("glGetProgramInterfaceiv");
				Functions.glGetProgramResourceIndex = getProc<Delegates.glGetProgramResourceIndex>("glGetProgramResourceIndex");
				Functions.glGetProgramResourceiv = getProc<Delegates.glGetProgramResourceiv>("glGetProgramResourceiv");
				Functions.glGetProgramResourceLocation = getProc<Delegates.glGetProgramResourceLocation>("glGetProgramResourceLocation");
				Functions.glGetProgramResourceLocationIndex = getProc<Delegates.glGetProgramResourceLocationIndex>("glGetProgramResourceLocationIndex");
				Functions.glGetProgramResourceName = getProc<Delegates.glGetProgramResourceName>("glGetProgramResourceName");
				Functions.glInvalidateBufferData = getProc<Delegates.glInvalidateBufferData>("glInvalidateBufferData");
				Functions.glInvalidateBufferSubData = getProc<Delegates.glInvalidateBufferSubData>("glInvalidateBufferSubData");
				Functions.glInvalidateFramebuffer = getProc<Delegates.glInvalidateFramebuffer>("glInvalidateFramebuffer");
				Functions.glInvalidateSubFramebuffer = getProc<Delegates.glInvalidateSubFramebuffer>("glInvalidateSubFramebuffer");
				Functions.glInvalidateTexImage = getProc<Delegates.glInvalidateTexImage>("glInvalidateTexImage");
				Functions.glInvalidateTexSubImage = getProc<Delegates.glInvalidateTexSubImage>("glInvalidateTexSubImage");
				Functions.glMultiDrawArraysIndirect = getProc<Delegates.glMultiDrawArraysIndirect>("glMultiDrawArraysIndirect");
				Functions.glMultiDrawElementsIndirect = getProc<Delegates.glMultiDrawElementsIndirect>("glMultiDrawElementsIndirect");
				Functions.glObjectLabel = getProc<Delegates.glObjectLabel>("glObjectLabel");
				Functions.glObjectPtrLabel = getProc<Delegates.glObjectPtrLabel>("glObjectPtrLabel");
				Functions.glPopDebugGroup = getProc<Delegates.glPopDebugGroup>("glPopDebugGroup");
				Functions.glPushDebugGroup = getProc<Delegates.glPushDebugGroup>("glPushDebugGroup");
				Functions.glShaderStorageBlockBinding = getProc<Delegates.glShaderStorageBlockBinding>("glShaderStorageBlockBinding");
				Functions.glTexBufferRange = getProc<Delegates.glTexBufferRange>("glTexBufferRange");
				Functions.glTexStorage2DMultisample = getProc<Delegates.glTexStorage2DMultisample>("glTexStorage2DMultisample");
				Functions.glTexStorage3DMultisample = getProc<Delegates.glTexStorage3DMultisample>("glTexStorage3DMultisample");
				Functions.glTextureView = getProc<Delegates.glTextureView>("glTextureView");
				Functions.glVertexAttribBinding = getProc<Delegates.glVertexAttribBinding>("glVertexAttribBinding");
				Functions.glVertexAttribFormat = getProc<Delegates.glVertexAttribFormat>("glVertexAttribFormat");
				Functions.glVertexAttribIFormat = getProc<Delegates.glVertexAttribIFormat>("glVertexAttribIFormat");
				Functions.glVertexAttribLFormat = getProc<Delegates.glVertexAttribLFormat>("glVertexAttribLFormat");
				Functions.glVertexBindingDivisor = getProc<Delegates.glVertexBindingDivisor>("glVertexBindingDivisor");
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 4))
			{
				Functions.glBindBuffersBase = getProc<Delegates.glBindBuffersBase>("glBindBuffersBase");
				Functions.glBindBuffersRange = getProc<Delegates.glBindBuffersRange>("glBindBuffersRange");
				Functions.glBindImageTextures = getProc<Delegates.glBindImageTextures>("glBindImageTextures");
				Functions.glBindSamplers = getProc<Delegates.glBindSamplers>("glBindSamplers");
				Functions.glBindTextures = getProc<Delegates.glBindTextures>("glBindTextures");
				Functions.glBindVertexBuffers = getProc<Delegates.glBindVertexBuffers>("glBindVertexBuffers");
				Functions.glBufferStorage = getProc<Delegates.glBufferStorage>("glBufferStorage");
				Functions.glClearTexImage = getProc<Delegates.glClearTexImage>("glClearTexImage");
				Functions.glClearTexSubImage = getProc<Delegates.glClearTexSubImage>("glClearTexSubImage");
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 5))
			{
				Functions.glBindTextureUnit = getProc<Delegates.glBindTextureUnit>("glBindTextureUnit");
				Functions.glBlitNamedFramebuffer = getProc<Delegates.glBlitNamedFramebuffer>("glBlitNamedFramebuffer");
				Functions.glCheckNamedFramebufferStatus = getProc<Delegates.glCheckNamedFramebufferStatus>("glCheckNamedFramebufferStatus");
				Functions.glClearNamedBufferData = getProc<Delegates.glClearNamedBufferData>("glClearNamedBufferData");
				Functions.glClearNamedBufferSubData = getProc<Delegates.glClearNamedBufferSubData>("glClearNamedBufferSubData");
				Functions.glClearNamedFramebufferfi = getProc<Delegates.glClearNamedFramebufferfi>("glClearNamedFramebufferfi");
				Functions.glClearNamedFramebufferfv = getProc<Delegates.glClearNamedFramebufferfv>("glClearNamedFramebufferfv");
				Functions.glClearNamedFramebufferiv = getProc<Delegates.glClearNamedFramebufferiv>("glClearNamedFramebufferiv");
				Functions.glClearNamedFramebufferuiv = getProc<Delegates.glClearNamedFramebufferuiv>("glClearNamedFramebufferuiv");
				Functions.glClipControl = getProc<Delegates.glClipControl>("glClipControl");
				Functions.glCompressedTextureSubImage1D = getProc<Delegates.glCompressedTextureSubImage1D>("glCompressedTextureSubImage1D");
				Functions.glCompressedTextureSubImage2D = getProc<Delegates.glCompressedTextureSubImage2D>("glCompressedTextureSubImage2D");
				Functions.glCompressedTextureSubImage3D = getProc<Delegates.glCompressedTextureSubImage3D>("glCompressedTextureSubImage3D");
				Functions.glCopyNamedBufferSubData = getProc<Delegates.glCopyNamedBufferSubData>("glCopyNamedBufferSubData");
				Functions.glCopyTextureSubImage1D = getProc<Delegates.glCopyTextureSubImage1D>("glCopyTextureSubImage1D");
				Functions.glCopyTextureSubImage2D = getProc<Delegates.glCopyTextureSubImage2D>("glCopyTextureSubImage2D");
				Functions.glCopyTextureSubImage3D = getProc<Delegates.glCopyTextureSubImage3D>("glCopyTextureSubImage3D");
				Functions.glCreateBuffers = getProc<Delegates.glCreateBuffers>("glCreateBuffers");
				Functions.glCreateFramebuffers = getProc<Delegates.glCreateFramebuffers>("glCreateFramebuffers");
				Functions.glCreateProgramPipelines = getProc<Delegates.glCreateProgramPipelines>("glCreateProgramPipelines");
				Functions.glCreateQueries = getProc<Delegates.glCreateQueries>("glCreateQueries");
				Functions.glCreateRenderbuffers = getProc<Delegates.glCreateRenderbuffers>("glCreateRenderbuffers");
				Functions.glCreateSamplers = getProc<Delegates.glCreateSamplers>("glCreateSamplers");
				Functions.glCreateTextures = getProc<Delegates.glCreateTextures>("glCreateTextures");
				Functions.glCreateTransformFeedbacks = getProc<Delegates.glCreateTransformFeedbacks>("glCreateTransformFeedbacks");
				Functions.glCreateVertexArrays = getProc<Delegates.glCreateVertexArrays>("glCreateVertexArrays");
				Functions.glDisableVertexArrayAttrib = getProc<Delegates.glDisableVertexArrayAttrib>("glDisableVertexArrayAttrib");
				Functions.glEnableVertexArrayAttrib = getProc<Delegates.glEnableVertexArrayAttrib>("glEnableVertexArrayAttrib");
				Functions.glFlushMappedNamedBufferRange = getProc<Delegates.glFlushMappedNamedBufferRange>("glFlushMappedNamedBufferRange");
				Functions.glGenerateTextureMipmap = getProc<Delegates.glGenerateTextureMipmap>("glGenerateTextureMipmap");
				Functions.glGetCompressedTextureImage = getProc<Delegates.glGetCompressedTextureImage>("glGetCompressedTextureImage");
				Functions.glGetCompressedTextureSubImage = getProc<Delegates.glGetCompressedTextureSubImage>("glGetCompressedTextureSubImage");
				Functions.glGetGraphicsResetStatus = getProc<Delegates.glGetGraphicsResetStatus>("glGetGraphicsResetStatus");
				Functions.glGetNamedBufferParameteri64v = getProc<Delegates.glGetNamedBufferParameteri64v>("glGetNamedBufferParameteri64v");
				Functions.glGetNamedBufferParameteriv = getProc<Delegates.glGetNamedBufferParameteriv>("glGetNamedBufferParameteriv");
				Functions.glGetNamedBufferPointerv = getProc<Delegates.glGetNamedBufferPointerv>("glGetNamedBufferPointerv");
				Functions.glGetNamedBufferSubData = getProc<Delegates.glGetNamedBufferSubData>("glGetNamedBufferSubData");
				Functions.glGetNamedFramebufferAttachmentParameteriv = getProc<Delegates.glGetNamedFramebufferAttachmentParameteriv>("glGetNamedFramebufferAttachmentParameteriv");
				Functions.glGetNamedFramebufferParameteriv = getProc<Delegates.glGetNamedFramebufferParameteriv>("glGetNamedFramebufferParameteriv");
				Functions.glGetNamedRenderbufferParameteriv = getProc<Delegates.glGetNamedRenderbufferParameteriv>("glGetNamedRenderbufferParameteriv");
				Functions.glGetnCompressedTexImage = getProc<Delegates.glGetnCompressedTexImage>("glGetnCompressedTexImage");
				Functions.glGetnTexImage = getProc<Delegates.glGetnTexImage>("glGetnTexImage");
				Functions.glGetnUniformdv = getProc<Delegates.glGetnUniformdv>("glGetnUniformdv");
				Functions.glGetnUniformfv = getProc<Delegates.glGetnUniformfv>("glGetnUniformfv");
				Functions.glGetnUniformiv = getProc<Delegates.glGetnUniformiv>("glGetnUniformiv");
				Functions.glGetnUniformuiv = getProc<Delegates.glGetnUniformuiv>("glGetnUniformuiv");
				Functions.glGetQueryBufferObjecti64v = getProc<Delegates.glGetQueryBufferObjecti64v>("glGetQueryBufferObjecti64v");
				Functions.glGetQueryBufferObjectiv = getProc<Delegates.glGetQueryBufferObjectiv>("glGetQueryBufferObjectiv");
				Functions.glGetQueryBufferObjectui64v = getProc<Delegates.glGetQueryBufferObjectui64v>("glGetQueryBufferObjectui64v");
				Functions.glGetQueryBufferObjectuiv = getProc<Delegates.glGetQueryBufferObjectuiv>("glGetQueryBufferObjectuiv");
				Functions.glGetTextureImage = getProc<Delegates.glGetTextureImage>("glGetTextureImage");
				Functions.glGetTextureLevelParameterfv = getProc<Delegates.glGetTextureLevelParameterfv>("glGetTextureLevelParameterfv");
				Functions.glGetTextureLevelParameteriv = getProc<Delegates.glGetTextureLevelParameteriv>("glGetTextureLevelParameteriv");
				Functions.glGetTextureParameterfv = getProc<Delegates.glGetTextureParameterfv>("glGetTextureParameterfv");
				Functions.glGetTextureParameterIiv = getProc<Delegates.glGetTextureParameterIiv>("glGetTextureParameterIiv");
				Functions.glGetTextureParameterIuiv = getProc<Delegates.glGetTextureParameterIuiv>("glGetTextureParameterIuiv");
				Functions.glGetTextureParameteriv = getProc<Delegates.glGetTextureParameteriv>("glGetTextureParameteriv");
				Functions.glGetTextureSubImage = getProc<Delegates.glGetTextureSubImage>("glGetTextureSubImage");
				Functions.glGetTransformFeedbacki_v = getProc<Delegates.glGetTransformFeedbacki_v>("glGetTransformFeedbacki_v");
				Functions.glGetTransformFeedbacki64_v = getProc<Delegates.glGetTransformFeedbacki64_v>("glGetTransformFeedbacki64_v");
				Functions.glGetTransformFeedbackiv = getProc<Delegates.glGetTransformFeedbackiv>("glGetTransformFeedbackiv");
				Functions.glGetVertexArrayIndexed64iv = getProc<Delegates.glGetVertexArrayIndexed64iv>("glGetVertexArrayIndexed64iv");
				Functions.glGetVertexArrayIndexediv = getProc<Delegates.glGetVertexArrayIndexediv>("glGetVertexArrayIndexediv");
				Functions.glGetVertexArrayiv = getProc<Delegates.glGetVertexArrayiv>("glGetVertexArrayiv");
				Functions.glInvalidateNamedFramebufferData = getProc<Delegates.glInvalidateNamedFramebufferData>("glInvalidateNamedFramebufferData");
				Functions.glInvalidateNamedFramebufferSubData = getProc<Delegates.glInvalidateNamedFramebufferSubData>("glInvalidateNamedFramebufferSubData");
				Functions.glMapNamedBuffer = getProc<Delegates.glMapNamedBuffer>("glMapNamedBuffer");
				Functions.glMapNamedBufferRange = getProc<Delegates.glMapNamedBufferRange>("glMapNamedBufferRange");
				Functions.glMemoryBarrierByRegion = getProc<Delegates.glMemoryBarrierByRegion>("glMemoryBarrierByRegion");
				Functions.glNamedBufferData = getProc<Delegates.glNamedBufferData>("glNamedBufferData");
				Functions.glNamedBufferStorage = getProc<Delegates.glNamedBufferStorage>("glNamedBufferStorage");
				Functions.glNamedBufferSubData = getProc<Delegates.glNamedBufferSubData>("glNamedBufferSubData");
				Functions.glNamedFramebufferDrawBuffer = getProc<Delegates.glNamedFramebufferDrawBuffer>("glNamedFramebufferDrawBuffer");
				Functions.glNamedFramebufferDrawBuffers = getProc<Delegates.glNamedFramebufferDrawBuffers>("glNamedFramebufferDrawBuffers");
				Functions.glNamedFramebufferParameteri = getProc<Delegates.glNamedFramebufferParameteri>("glNamedFramebufferParameteri");
				Functions.glNamedFramebufferReadBuffer = getProc<Delegates.glNamedFramebufferReadBuffer>("glNamedFramebufferReadBuffer");
				Functions.glNamedFramebufferRenderbuffer = getProc<Delegates.glNamedFramebufferRenderbuffer>("glNamedFramebufferRenderbuffer");
				Functions.glNamedFramebufferTexture = getProc<Delegates.glNamedFramebufferTexture>("glNamedFramebufferTexture");
				Functions.glNamedFramebufferTextureLayer = getProc<Delegates.glNamedFramebufferTextureLayer>("glNamedFramebufferTextureLayer");
				Functions.glNamedRenderbufferStorage = getProc<Delegates.glNamedRenderbufferStorage>("glNamedRenderbufferStorage");
				Functions.glNamedRenderbufferStorageMultisample = getProc<Delegates.glNamedRenderbufferStorageMultisample>("glNamedRenderbufferStorageMultisample");
				Functions.glReadnPixels = getProc<Delegates.glReadnPixels>("glReadnPixels");
				Functions.glTextureBarrier = getProc<Delegates.glTextureBarrier>("glTextureBarrier");
				Functions.glTextureBuffer = getProc<Delegates.glTextureBuffer>("glTextureBuffer");
				Functions.glTextureBufferRange = getProc<Delegates.glTextureBufferRange>("glTextureBufferRange");
				Functions.glTextureParameterf = getProc<Delegates.glTextureParameterf>("glTextureParameterf");
				Functions.glTextureParameterfv = getProc<Delegates.glTextureParameterfv>("glTextureParameterfv");
				Functions.glTextureParameteri = getProc<Delegates.glTextureParameteri>("glTextureParameteri");
				Functions.glTextureParameterIiv = getProc<Delegates.glTextureParameterIiv>("glTextureParameterIiv");
				Functions.glTextureParameterIuiv = getProc<Delegates.glTextureParameterIuiv>("glTextureParameterIuiv");
				Functions.glTextureParameteriv = getProc<Delegates.glTextureParameteriv>("glTextureParameteriv");
				Functions.glTextureStorage1D = getProc<Delegates.glTextureStorage1D>("glTextureStorage1D");
				Functions.glTextureStorage2D = getProc<Delegates.glTextureStorage2D>("glTextureStorage2D");
				Functions.glTextureStorage2DMultisample = getProc<Delegates.glTextureStorage2DMultisample>("glTextureStorage2DMultisample");
				Functions.glTextureStorage3D = getProc<Delegates.glTextureStorage3D>("glTextureStorage3D");
				Functions.glTextureStorage3DMultisample = getProc<Delegates.glTextureStorage3DMultisample>("glTextureStorage3DMultisample");
				Functions.glTextureSubImage1D = getProc<Delegates.glTextureSubImage1D>("glTextureSubImage1D");
				Functions.glTextureSubImage2D = getProc<Delegates.glTextureSubImage2D>("glTextureSubImage2D");
				Functions.glTextureSubImage3D = getProc<Delegates.glTextureSubImage3D>("glTextureSubImage3D");
				Functions.glTransformFeedbackBufferBase = getProc<Delegates.glTransformFeedbackBufferBase>("glTransformFeedbackBufferBase");
				Functions.glTransformFeedbackBufferRange = getProc<Delegates.glTransformFeedbackBufferRange>("glTransformFeedbackBufferRange");
				Functions.glUnmapNamedBuffer = getProc<Delegates.glUnmapNamedBuffer>("glUnmapNamedBuffer");
				Functions.glVertexArrayAttribBinding = getProc<Delegates.glVertexArrayAttribBinding>("glVertexArrayAttribBinding");
				Functions.glVertexArrayAttribFormat = getProc<Delegates.glVertexArrayAttribFormat>("glVertexArrayAttribFormat");
				Functions.glVertexArrayAttribIFormat = getProc<Delegates.glVertexArrayAttribIFormat>("glVertexArrayAttribIFormat");
				Functions.glVertexArrayAttribLFormat = getProc<Delegates.glVertexArrayAttribLFormat>("glVertexArrayAttribLFormat");
				Functions.glVertexArrayBindingDivisor = getProc<Delegates.glVertexArrayBindingDivisor>("glVertexArrayBindingDivisor");
				Functions.glVertexArrayElementBuffer = getProc<Delegates.glVertexArrayElementBuffer>("glVertexArrayElementBuffer");
				Functions.glVertexArrayVertexBuffer = getProc<Delegates.glVertexArrayVertexBuffer>("glVertexArrayVertexBuffer");
				Functions.glVertexArrayVertexBuffers = getProc<Delegates.glVertexArrayVertexBuffers>("glVertexArrayVertexBuffers");
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 6))
			{
				Functions.glMultiDrawArraysIndirectCount = getProc<Delegates.glMultiDrawArraysIndirectCount>("glMultiDrawArraysIndirectCount");
				Functions.glMultiDrawElementsIndirectCount = getProc<Delegates.glMultiDrawElementsIndirectCount>("glMultiDrawElementsIndirectCount");
				Functions.glPolygonOffsetClamp = getProc<Delegates.glPolygonOffsetClamp>("glPolygonOffsetClamp");
				Functions.glSpecializeShader = getProc<Delegates.glSpecializeShader>("glSpecializeShader");
			}
		}
#endif

		public static void glActiveShaderProgram(uint pipeline, uint program)
		{
			Functions.glActiveShaderProgram(pipeline, program);
		}

		public static void glActiveTexture(uint texture)
		{
			Functions.glActiveTexture(texture);
		}

		public static void glAttachShader(uint program, uint shader)
		{
			Functions.glAttachShader(program, shader);
		}

		public static void glBeginConditionalRender(uint id, uint mode)
		{
			Functions.glBeginConditionalRender(id, mode);
		}

		public static void glBeginQuery(uint target, uint id)
		{
			Functions.glBeginQuery(target, id);
		}

		public static void glBeginQueryIndexed(uint target, uint index, uint id)
		{
			Functions.glBeginQueryIndexed(target, index, id);
		}

		public static void glBeginTransformFeedback(uint primitiveMode)
		{
			Functions.glBeginTransformFeedback(primitiveMode);
		}

		public static void glBindAttribLocation(uint program, uint index, string name)
		{
			Functions.glBindAttribLocation(program, index, name);
		}

		public static void glBindBuffer(uint target, uint buffer)
		{
			Functions.glBindBuffer(target, buffer);
		}

		public static void glBindBufferBase(uint target, uint index, uint buffer)
		{
			Functions.glBindBufferBase(target, index, buffer);
		}

		public static void glBindBufferRange(uint target, uint index, uint buffer, int offset, int size)
		{
			Functions.glBindBufferRange(target, index, buffer, offset, size);
		}

		public static void glBindBuffersBase(uint target, uint first, int count, uint* buffers)
		{
			Functions.glBindBuffersBase(target, first, count, buffers);
		}

		public static void glBindBuffersRange(uint target, uint first, int count, uint* buffers, int* offsets, int* sizes)
		{
			Functions.glBindBuffersRange(target, first, count, buffers, offsets, sizes);
		}

		public static void glBindFragDataLocation(uint program, uint color, string name)
		{
			Functions.glBindFragDataLocation(program, color, name);
		}

		public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name)
		{
			Functions.glBindFragDataLocationIndexed(program, colorNumber, index, name);
		}

		public static void glBindFramebuffer(uint target, uint framebuffer)
		{
			Functions.glBindFramebuffer(target, framebuffer);
		}

		public static void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format)
		{
			Functions.glBindImageTexture(unit, texture, level, layered, layer, access, format);
		}

		public static void glBindImageTextures(uint first, int count, uint* textures)
		{
			Functions.glBindImageTextures(first, count, textures);
		}

		public static void glBindProgramPipeline(uint pipeline)
		{
			Functions.glBindProgramPipeline(pipeline);
		}

		public static void glBindRenderbuffer(uint target, uint renderbuffer)
		{
			Functions.glBindRenderbuffer(target, renderbuffer);
		}

		public static void glBindSampler(uint unit, uint sampler)
		{
			Functions.glBindSampler(unit, sampler);
		}

		public static void glBindSamplers(uint first, int count, uint* samplers)
		{
			Functions.glBindSamplers(first, count, samplers);
		}

		public static void glBindTexture(uint target, uint texture)
		{
			Functions.glBindTexture(target, texture);
		}

		public static void glBindTextures(uint first, int count, uint* textures)
		{
			Functions.glBindTextures(first, count, textures);
		}

		public static void glBindTextureUnit(uint unit, uint texture)
		{
			Functions.glBindTextureUnit(unit, texture);
		}

		public static void glBindTransformFeedback(uint target, uint id)
		{
			Functions.glBindTransformFeedback(target, id);
		}

		public static void glBindVertexArray(uint array)
		{
			Functions.glBindVertexArray(array);
		}

		public static void glBindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride)
		{
			Functions.glBindVertexBuffer(bindingindex, buffer, offset, stride);
		}

		public static void glBindVertexBuffers(uint first, int count, uint* buffers, int* offsets, int* strides)
		{
			Functions.glBindVertexBuffers(first, count, buffers, offsets, strides);
		}

		public static void glBlendColor(float red, float green, float blue, float alpha)
		{
			Functions.glBlendColor(red, green, blue, alpha);
		}

		public static void glBlendEquation(uint mode)
		{
			Functions.glBlendEquation(mode);
		}

		public static void glBlendEquationi(uint buf, uint mode)
		{
			Functions.glBlendEquationi(buf, mode);
		}

		public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha)
		{
			Functions.glBlendEquationSeparate(modeRGB, modeAlpha);
		}

		public static void glBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha)
		{
			Functions.glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
		}

		public static void glBlendFunc(uint sfactor, uint dfactor)
		{
			Functions.glBlendFunc(sfactor, dfactor);
		}

		public static void glBlendFunci(uint buf, uint src, uint dst)
		{
			Functions.glBlendFunci(buf, src, dst);
		}

		public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
			Functions.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}

		public static void glBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
		{
			Functions.glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		}

		public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			Functions.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

		public static void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			Functions.glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

		public static void glBufferData(uint target, int size, void* data, uint usage)
		{
			Functions.glBufferData(target, size, data, usage);
		}

		public static void glBufferStorage(uint target, int size, void* data, uint flags)
		{
			Functions.glBufferStorage(target, size, data, flags);
		}

		public static void glBufferSubData(uint target, int offset, int size, void* data)
		{
			Functions.glBufferSubData(target, offset, size, data);
		}

		public static uint glCheckFramebufferStatus(uint target)
		{
			return Functions.glCheckFramebufferStatus(target);
		}

		public static uint glCheckNamedFramebufferStatus(uint framebuffer, uint target)
		{
			return Functions.glCheckNamedFramebufferStatus(framebuffer, target);
		}

		public static void glClampColor(uint target, uint clamp)
		{
			Functions.glClampColor(target, clamp);
		}

		public static void glClear(uint mask)
		{
			Functions.glClear(mask);
		}

		public static void glClearBufferData(uint target, uint internalformat, uint format, uint type, void* data)
		{
			Functions.glClearBufferData(target, internalformat, format, type, data);
		}

		public static void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil)
		{
			Functions.glClearBufferfi(buffer, drawbuffer, depth, stencil);
		}

		public static void glClearBufferfv(uint buffer, int drawbuffer, float* value)
		{
			Functions.glClearBufferfv(buffer, drawbuffer, value);
		}

		public static void glClearBufferiv(uint buffer, int drawbuffer, int* value)
		{
			Functions.glClearBufferiv(buffer, drawbuffer, value);
		}

		public static void glClearBufferSubData(uint target, uint internalformat, int offset, int size, uint format, uint type, void* data)
		{
			Functions.glClearBufferSubData(target, internalformat, offset, size, format, type, data);
		}

		public static void glClearBufferuiv(uint buffer, int drawbuffer, uint* value)
		{
			Functions.glClearBufferuiv(buffer, drawbuffer, value);
		}

		public static void glClearColor(float red, float green, float blue, float alpha)
		{
			Functions.glClearColor(red, green, blue, alpha);
		}

		public static void glClearDepth(double depth)
		{
			Functions.glClearDepth(depth);
		}

		public static void glClearDepthf(float d)
		{
			Functions.glClearDepthf(d);
		}

		public static void glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, void* data)
		{
			Functions.glClearNamedBufferData(buffer, internalformat, format, type, data);
		}

		public static void glClearNamedBufferSubData(uint buffer, uint internalformat, int offset, int size, uint format, uint type, void* data)
		{
			Functions.glClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
		}

		public static void glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil)
		{
			Functions.glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
		}

		public static void glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value)
		{
			Functions.glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);
		}

		public static void glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value)
		{
			Functions.glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);
		}

		public static void glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value)
		{
			Functions.glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);
		}

		public static void glClearStencil(int s)
		{
			Functions.glClearStencil(s);
		}

		public static void glClearTexImage(uint texture, int level, uint format, uint type, void* data)
		{
			Functions.glClearTexImage(texture, level, format, type, data);
		}

		public static void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data)
		{
			Functions.glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}

		public static uint glClientWaitSync(IntPtr sync, uint flags, ulong timeout)
		{
			return Functions.glClientWaitSync(sync, flags, timeout);
		}

		public static void glClipControl(uint origin, uint depth)
		{
			Functions.glClipControl(origin, depth);
		}

		public static void glColorMask(bool red, bool green, bool blue, bool alpha)
		{
			Functions.glColorMask(red, green, blue, alpha);
		}

		public static void glColorMaski(uint index, bool r, bool g, bool b, bool a)
		{
			Functions.glColorMaski(index, r, g, b, a);
		}

		public static void glCompileShader(uint shader)
		{
			Functions.glCompileShader(shader);
		}

		public static void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data)
		{
			Functions.glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
		}

		public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data)
		{
			Functions.glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		}

		public static void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data)
		{
			Functions.glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
		}

		public static void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data)
		{
			Functions.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
		}

		public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data)
		{
			Functions.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}

		public static void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data)
		{
			Functions.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}

		public static void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data)
		{
			Functions.glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
		}

		public static void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data)
		{
			Functions.glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
		}

		public static void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data)
		{
			Functions.glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}

		public static void glCopyBufferSubData(uint readTarget, uint writeTarget, int readOffset, int writeOffset, int size)
		{
			Functions.glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
		}

		public static void glCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
		{
			Functions.glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
		}

		public static void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size)
		{
			Functions.glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
		}

		public static void glCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border)
		{
			Functions.glCopyTexImage1D(target, level, internalformat, x, y, width, border);
		}

		public static void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
			Functions.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
		}

		public static void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width)
		{
			Functions.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
		}

		public static void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			Functions.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		}

		public static void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			Functions.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}

		public static void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width)
		{
			Functions.glCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
		}

		public static void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			Functions.glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
		}

		public static void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			Functions.glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
		}

		public static void glCreateBuffers(int n, uint* buffers)
		{
			Functions.glCreateBuffers(n, buffers);
		}

		public static void glCreateFramebuffers(int n, uint* framebuffers)
		{
			Functions.glCreateFramebuffers(n, framebuffers);
		}

		public static uint glCreateProgram()
		{
			return Functions.glCreateProgram();
		}

		public static void glCreateProgramPipelines(int n, uint* pipelines)
		{
			Functions.glCreateProgramPipelines(n, pipelines);
		}

		public static void glCreateQueries(uint target, int n, uint* ids)
		{
			Functions.glCreateQueries(target, n, ids);
		}

		public static void glCreateRenderbuffers(int n, uint* renderbuffers)
		{
			Functions.glCreateRenderbuffers(n, renderbuffers);
		}

		public static void glCreateSamplers(int n, uint* samplers)
		{
			Functions.glCreateSamplers(n, samplers);
		}

		public static uint glCreateShader(uint type)
		{
			return Functions.glCreateShader(type);
		}

		public static uint glCreateShaderProgramv(uint type, int count, string[] strings)
		{
			return Functions.glCreateShaderProgramv(type, count, strings);
		}

		public static void glCreateTextures(uint target, int n, uint* textures)
		{
			Functions.glCreateTextures(target, n, textures);
		}

		public static void glCreateTransformFeedbacks(int n, uint* ids)
		{
			Functions.glCreateTransformFeedbacks(n, ids);
		}

		public static void glCreateVertexArrays(int n, uint* arrays)
		{
			Functions.glCreateVertexArrays(n, arrays);
		}

		public static void glCullFace(uint mode)
		{
			Functions.glCullFace(mode);
		}

		public static void glDebugMessageCallback(glDebugProc callback, void* userParam)
		{
			Functions.glDebugMessageCallback(callback, userParam);
		}

		public static void glDebugMessageControl(uint source, uint type, uint severity, int count, uint* ids, bool enabled)
		{
			Functions.glDebugMessageControl(source, type, severity, count, ids, enabled);
		}

		public static void glDebugMessageInsert(uint source, uint type, uint id, uint severity, int length, string buf)
		{
			Functions.glDebugMessageInsert(source, type, id, severity, length, buf);
		}

		public static void glDeleteBuffers(int n, uint* buffers)
		{
			Functions.glDeleteBuffers(n, buffers);
		}

		public static void glDeleteFramebuffers(int n, uint* framebuffers)
		{
			Functions.glDeleteFramebuffers(n, framebuffers);
		}

		public static void glDeleteProgram(uint program)
		{
			Functions.glDeleteProgram(program);
		}

		public static void glDeleteProgramPipelines(int n, uint* pipelines)
		{
			Functions.glDeleteProgramPipelines(n, pipelines);
		}

		public static void glDeleteQueries(int n, uint* ids)
		{
			Functions.glDeleteQueries(n, ids);
		}

		public static void glDeleteRenderbuffers(int n, uint* renderbuffers)
		{
			Functions.glDeleteRenderbuffers(n, renderbuffers);
		}

		public static void glDeleteSamplers(int count, uint* samplers)
		{
			Functions.glDeleteSamplers(count, samplers);
		}

		public static void glDeleteShader(uint shader)
		{
			Functions.glDeleteShader(shader);
		}

		public static void glDeleteSync(IntPtr sync)
		{
			Functions.glDeleteSync(sync);
		}

		public static void glDeleteTextures(int n, uint* textures)
		{
			Functions.glDeleteTextures(n, textures);
		}

		public static void glDeleteTransformFeedbacks(int n, uint* ids)
		{
			Functions.glDeleteTransformFeedbacks(n, ids);
		}

		public static void glDeleteVertexArrays(int n, uint* arrays)
		{
			Functions.glDeleteVertexArrays(n, arrays);
		}

		public static void glDepthFunc(uint func)
		{
			Functions.glDepthFunc(func);
		}

		public static void glDepthMask(bool flag)
		{
			Functions.glDepthMask(flag);
		}

		public static void glDepthRange(double n, double f)
		{
			Functions.glDepthRange(n, f);
		}

		public static void glDepthRangeArrayv(uint first, int count, double* v)
		{
			Functions.glDepthRangeArrayv(first, count, v);
		}

		public static void glDepthRangef(float n, float f)
		{
			Functions.glDepthRangef(n, f);
		}

		public static void glDepthRangeIndexed(uint index, double n, double f)
		{
			Functions.glDepthRangeIndexed(index, n, f);
		}

		public static void glDetachShader(uint program, uint shader)
		{
			Functions.glDetachShader(program, shader);
		}

		public static void glDisable(uint cap)
		{
			Functions.glDisable(cap);
		}

		public static void glDisablei(uint target, uint index)
		{
			Functions.glDisablei(target, index);
		}

		public static void glDisableVertexArrayAttrib(uint vaobj, uint index)
		{
			Functions.glDisableVertexArrayAttrib(vaobj, index);
		}

		public static void glDisableVertexAttribArray(uint index)
		{
			Functions.glDisableVertexAttribArray(index);
		}

		public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z)
		{
			Functions.glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
		}

		public static void glDispatchComputeIndirect(int indirect)
		{
			Functions.glDispatchComputeIndirect(indirect);
		}

		public static void glDrawArrays(uint mode, int first, int count)
		{
			Functions.glDrawArrays(mode, first, count);
		}

		public static void glDrawArraysIndirect(uint mode, void* indirect)
		{
			Functions.glDrawArraysIndirect(mode, indirect);
		}

		public static void glDrawArraysInstanced(uint mode, int first, int count, int instancecount)
		{
			Functions.glDrawArraysInstanced(mode, first, count, instancecount);
		}

		public static void glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance)
		{
			Functions.glDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
		}

		public static void glDrawBuffer(uint buf)
		{
			Functions.glDrawBuffer(buf);
		}

		public static void glDrawBuffers(int n, uint* bufs)
		{
			Functions.glDrawBuffers(n, bufs);
		}

		public static void glDrawElements(uint mode, int count, uint type, void* indices)
		{
			Functions.glDrawElements(mode, count, type, indices);
		}

		public static void glDrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex)
		{
			Functions.glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
		}

		public static void glDrawElementsIndirect(uint mode, uint type, void* indirect)
		{
			Functions.glDrawElementsIndirect(mode, type, indirect);
		}

		public static void glDrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount)
		{
			Functions.glDrawElementsInstanced(mode, count, type, indices, instancecount);
		}

		public static void glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance)
		{
			Functions.glDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
		}

		public static void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex)
		{
			Functions.glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
		}

		public static void glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance)
		{
			Functions.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}

		public static void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices)
		{
			Functions.glDrawRangeElements(mode, start, end, count, type, indices);
		}

		public static void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex)
		{
			Functions.glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
		}

		public static void glDrawTransformFeedback(uint mode, uint id)
		{
			Functions.glDrawTransformFeedback(mode, id);
		}

		public static void glDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount)
		{
			Functions.glDrawTransformFeedbackInstanced(mode, id, instancecount);
		}

		public static void glDrawTransformFeedbackStream(uint mode, uint id, uint stream)
		{
			Functions.glDrawTransformFeedbackStream(mode, id, stream);
		}

		public static void glDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount)
		{
			Functions.glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
		}

		public static void glEnable(uint cap)
		{
			Functions.glEnable(cap);
		}

		public static void glEnablei(uint target, uint index)
		{
			Functions.glEnablei(target, index);
		}

		public static void glEnableVertexArrayAttrib(uint vaobj, uint index)
		{
			Functions.glEnableVertexArrayAttrib(vaobj, index);
		}

		public static void glEnableVertexAttribArray(uint index)
		{
			Functions.glEnableVertexAttribArray(index);
		}

		public static void glEndConditionalRender()
		{
			Functions.glEndConditionalRender();
		}

		public static void glEndQuery(uint target)
		{
			Functions.glEndQuery(target);
		}

		public static void glEndQueryIndexed(uint target, uint index)
		{
			Functions.glEndQueryIndexed(target, index);
		}

		public static void glEndTransformFeedback()
		{
			Functions.glEndTransformFeedback();
		}

		public static IntPtr glFenceSync(uint condition, uint flags)
		{
			return Functions.glFenceSync(condition, flags);
		}

		public static void glFinish()
		{
			Functions.glFinish();
		}

		public static void glFlush()
		{
			Functions.glFlush();
		}

		public static void glFlushMappedBufferRange(uint target, int offset, int length)
		{
			Functions.glFlushMappedBufferRange(target, offset, length);
		}

		public static void glFlushMappedNamedBufferRange(uint buffer, int offset, int length)
		{
			Functions.glFlushMappedNamedBufferRange(buffer, offset, length);
		}

		public static void glFramebufferParameteri(uint target, uint pname, int param)
		{
			Functions.glFramebufferParameteri(target, pname, param);
		}

		public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			Functions.glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		}

		public static void glFramebufferTexture(uint target, uint attachment, uint texture, int level)
		{
			Functions.glFramebufferTexture(target, attachment, texture, level);
		}

		public static void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			Functions.glFramebufferTexture1D(target, attachment, textarget, texture, level);
		}

		public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			Functions.glFramebufferTexture2D(target, attachment, textarget, texture, level);
		}

		public static void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
			Functions.glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
		}

		public static void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer)
		{
			Functions.glFramebufferTextureLayer(target, attachment, texture, level, layer);
		}

		public static void glFrontFace(uint mode)
		{
			Functions.glFrontFace(mode);
		}

		public static void glGenBuffers(int n, uint* buffers)
		{
			Functions.glGenBuffers(n, buffers);
		}

		public static void glGenerateMipmap(uint target)
		{
			Functions.glGenerateMipmap(target);
		}

		public static void glGenerateTextureMipmap(uint texture)
		{
			Functions.glGenerateTextureMipmap(texture);
		}

		public static void glGenFramebuffers(int n, uint* framebuffers)
		{
			Functions.glGenFramebuffers(n, framebuffers);
		}

		public static void glGenProgramPipelines(int n, uint* pipelines)
		{
			Functions.glGenProgramPipelines(n, pipelines);
		}

		public static void glGenQueries(int n, uint* ids)
		{
			Functions.glGenQueries(n, ids);
		}

		public static void glGenRenderbuffers(int n, uint* renderbuffers)
		{
			Functions.glGenRenderbuffers(n, renderbuffers);
		}

		public static void glGenSamplers(int count, uint* samplers)
		{
			Functions.glGenSamplers(count, samplers);
		}

		public static void glGenTextures(int n, uint* textures)
		{
			Functions.glGenTextures(n, textures);
		}

		public static void glGenTransformFeedbacks(int n, uint* ids)
		{
			Functions.glGenTransformFeedbacks(n, ids);
		}

		public static void glGenVertexArrays(int n, uint* arrays)
		{
			Functions.glGenVertexArrays(n, arrays);
		}

		public static void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* @params)
		{
			Functions.glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, @params);
		}

		public static void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name)
		{
			Functions.glGetActiveAttrib(program, index, bufSize, length, size, type, name);
		}

		public static void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int* length, StringBuilder name)
		{
			Functions.glGetActiveSubroutineName(program, shadertype, index, bufsize, length, name);
		}

		public static void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values)
		{
			Functions.glGetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
		}

		public static void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int* length, StringBuilder name)
		{
			Functions.glGetActiveSubroutineUniformName(program, shadertype, index, bufsize, length, name);
		}

		public static void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name)
		{
			Functions.glGetActiveUniform(program, index, bufSize, length, size, type, name);
		}

		public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* @params)
		{
			Functions.glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params);
		}

		public static void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, StringBuilder uniformBlockName)
		{
			Functions.glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
		}

		public static void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, StringBuilder uniformName)
		{
			Functions.glGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);
		}

		public static void glGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* @params)
		{
			Functions.glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params);
		}

		public static void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders)
		{
			Functions.glGetAttachedShaders(program, maxCount, count, shaders);
		}

		public static int glGetAttribLocation(uint program, string name)
		{
			return Functions.glGetAttribLocation(program, name);
		}

		public static void glGetBooleani_v(uint target, uint index, bool* data)
		{
			Functions.glGetBooleani_v(target, index, data);
		}

		public static void glGetBooleanv(uint pname, bool* data)
		{
			Functions.glGetBooleanv(pname, data);
		}

		public static void glGetBufferParameteri64v(uint target, uint pname, long* @params)
		{
			Functions.glGetBufferParameteri64v(target, pname, @params);
		}

		public static void glGetBufferParameteriv(uint target, uint pname, int* @params)
		{
			Functions.glGetBufferParameteriv(target, pname, @params);
		}

		public static void glGetBufferPointerv(uint target, uint pname, void** @params)
		{
			Functions.glGetBufferPointerv(target, pname, @params);
		}

		public static void glGetBufferSubData(uint target, int offset, int size, void* data)
		{
			Functions.glGetBufferSubData(target, offset, size, data);
		}

		public static void glGetCompressedTexImage(uint target, int level, void* img)
		{
			Functions.glGetCompressedTexImage(target, level, img);
		}

		public static void glGetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels)
		{
			Functions.glGetCompressedTextureImage(texture, level, bufSize, pixels);
		}

		public static void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels)
		{
			Functions.glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
		}

		public static uint glGetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, StringBuilder messageLog)
		{
			return Functions.glGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
		}

		public static void glGetDoublei_v(uint target, uint index, double* data)
		{
			Functions.glGetDoublei_v(target, index, data);
		}

		public static void glGetDoublev(uint pname, double* data)
		{
			Functions.glGetDoublev(pname, data);
		}

		public static uint glGetError()
		{
			return Functions.glGetError();
		}

		public static void glGetFloati_v(uint target, uint index, float* data)
		{
			Functions.glGetFloati_v(target, index, data);
		}

		public static void glGetFloatv(uint pname, float* data)
		{
			Functions.glGetFloatv(pname, data);
		}

		public static int glGetFragDataIndex(uint program, string name)
		{
			return Functions.glGetFragDataIndex(program, name);
		}

		public static int glGetFragDataLocation(uint program, string name)
		{
			return Functions.glGetFragDataLocation(program, name);
		}

		public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params)
		{
			Functions.glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
		}

		public static void glGetFramebufferParameteriv(uint target, uint pname, int* @params)
		{
			Functions.glGetFramebufferParameteriv(target, pname, @params);
		}

		public static uint glGetGraphicsResetStatus()
		{
			return Functions.glGetGraphicsResetStatus();
		}

		public static void glGetInteger64i_v(uint target, uint index, long* data)
		{
			Functions.glGetInteger64i_v(target, index, data);
		}

		public static void glGetInteger64v(uint pname, long* data)
		{
			Functions.glGetInteger64v(pname, data);
		}

		public static void glGetIntegeri_v(uint target, uint index, int* data)
		{
			Functions.glGetIntegeri_v(target, index, data);
		}

		public static void glGetIntegerv(uint pname, int* data)
		{
			Functions.glGetIntegerv(pname, data);
		}

		public static void glGetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, long* @params)
		{
			Functions.glGetInternalformati64v(target, internalformat, pname, bufSize, @params);
		}

		public static void glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int* @params)
		{
			Functions.glGetInternalformativ(target, internalformat, pname, bufSize, @params);
		}

		public static void glGetMultisamplefv(uint pname, uint index, float* val)
		{
			Functions.glGetMultisamplefv(pname, index, val);
		}

		public static void glGetNamedBufferParameteri64v(uint buffer, uint pname, long* @params)
		{
			Functions.glGetNamedBufferParameteri64v(buffer, pname, @params);
		}

		public static void glGetNamedBufferParameteriv(uint buffer, uint pname, int* @params)
		{
			Functions.glGetNamedBufferParameteriv(buffer, pname, @params);
		}

		public static void glGetNamedBufferPointerv(uint buffer, uint pname, void** @params)
		{
			Functions.glGetNamedBufferPointerv(buffer, pname, @params);
		}

		public static void glGetNamedBufferSubData(uint buffer, int offset, int size, void* data)
		{
			Functions.glGetNamedBufferSubData(buffer, offset, size, data);
		}

		public static void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* @params)
		{
			Functions.glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, @params);
		}

		public static void glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param)
		{
			Functions.glGetNamedFramebufferParameteriv(framebuffer, pname, param);
		}

		public static void glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* @params)
		{
			Functions.glGetNamedRenderbufferParameteriv(renderbuffer, pname, @params);
		}

		public static void glGetnCompressedTexImage(uint target, int lod, int bufSize, void* pixels)
		{
			Functions.glGetnCompressedTexImage(target, lod, bufSize, pixels);
		}

		public static void glGetnTexImage(uint target, int level, uint format, uint type, int bufSize, void* pixels)
		{
			Functions.glGetnTexImage(target, level, format, type, bufSize, pixels);
		}

		public static void glGetnUniformdv(uint program, int location, int bufSize, double* @params)
		{
			Functions.glGetnUniformdv(program, location, bufSize, @params);
		}

		public static void glGetnUniformfv(uint program, int location, int bufSize, float* @params)
		{
			Functions.glGetnUniformfv(program, location, bufSize, @params);
		}

		public static void glGetnUniformiv(uint program, int location, int bufSize, int* @params)
		{
			Functions.glGetnUniformiv(program, location, bufSize, @params);
		}

		public static void glGetnUniformuiv(uint program, int location, int bufSize, uint* @params)
		{
			Functions.glGetnUniformuiv(program, location, bufSize, @params);
		}

		public static void glGetObjectLabel(uint identifier, uint name, int bufSize, int* length, StringBuilder label)
		{
			Functions.glGetObjectLabel(identifier, name, bufSize, length, label);
		}

		public static void glGetObjectPtrLabel(void* ptr, int bufSize, int* length, StringBuilder label)
		{
			Functions.glGetObjectPtrLabel(ptr, bufSize, length, label);
		}

		public static void glGetPointerv(uint pname, void** @params)
		{
			Functions.glGetPointerv(pname, @params);
		}

		public static void glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary)
		{
			Functions.glGetProgramBinary(program, bufSize, length, binaryFormat, binary);
		}

		public static void glGetProgramInfoLog(uint program, int bufSize, int* length, StringBuilder infoLog)
		{
			Functions.glGetProgramInfoLog(program, bufSize, length, infoLog);
		}

		public static void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* @params)
		{
			Functions.glGetProgramInterfaceiv(program, programInterface, pname, @params);
		}

		public static void glGetProgramiv(uint program, uint pname, int* @params)
		{
			Functions.glGetProgramiv(program, pname, @params);
		}

		public static void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, StringBuilder infoLog)
		{
			Functions.glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
		}

		public static void glGetProgramPipelineiv(uint pipeline, uint pname, int* @params)
		{
			Functions.glGetProgramPipelineiv(pipeline, pname, @params);
		}

		public static uint glGetProgramResourceIndex(uint program, uint programInterface, string name)
		{
			return Functions.glGetProgramResourceIndex(program, programInterface, name);
		}

		public static void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int bufSize, int* length, int* @params)
		{
			Functions.glGetProgramResourceiv(program, programInterface, index, propCount, props, bufSize, length, @params);
		}

		public static int glGetProgramResourceLocation(uint program, uint programInterface, string name)
		{
			return Functions.glGetProgramResourceLocation(program, programInterface, name);
		}

		public static int glGetProgramResourceLocationIndex(uint program, uint programInterface, string name)
		{
			return Functions.glGetProgramResourceLocationIndex(program, programInterface, name);
		}

		public static void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, StringBuilder name)
		{
			Functions.glGetProgramResourceName(program, programInterface, index, bufSize, length, name);
		}

		public static void glGetProgramStageiv(uint program, uint shadertype, uint pname, int* values)
		{
			Functions.glGetProgramStageiv(program, shadertype, pname, values);
		}

		public static void glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int offset)
		{
			Functions.glGetQueryBufferObjecti64v(id, buffer, pname, offset);
		}

		public static void glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, int offset)
		{
			Functions.glGetQueryBufferObjectiv(id, buffer, pname, offset);
		}

		public static void glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int offset)
		{
			Functions.glGetQueryBufferObjectui64v(id, buffer, pname, offset);
		}

		public static void glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int offset)
		{
			Functions.glGetQueryBufferObjectuiv(id, buffer, pname, offset);
		}

		public static void glGetQueryIndexediv(uint target, uint index, uint pname, int* @params)
		{
			Functions.glGetQueryIndexediv(target, index, pname, @params);
		}

		public static void glGetQueryiv(uint target, uint pname, int* @params)
		{
			Functions.glGetQueryiv(target, pname, @params);
		}

		public static void glGetQueryObjecti64v(uint id, uint pname, long* @params)
		{
			Functions.glGetQueryObjecti64v(id, pname, @params);
		}

		public static void glGetQueryObjectiv(uint id, uint pname, int* @params)
		{
			Functions.glGetQueryObjectiv(id, pname, @params);
		}

		public static void glGetQueryObjectui64v(uint id, uint pname, ulong* @params)
		{
			Functions.glGetQueryObjectui64v(id, pname, @params);
		}

		public static void glGetQueryObjectuiv(uint id, uint pname, uint* @params)
		{
			Functions.glGetQueryObjectuiv(id, pname, @params);
		}

		public static void glGetRenderbufferParameteriv(uint target, uint pname, int* @params)
		{
			Functions.glGetRenderbufferParameteriv(target, pname, @params);
		}

		public static void glGetSamplerParameterfv(uint sampler, uint pname, float* @params)
		{
			Functions.glGetSamplerParameterfv(sampler, pname, @params);
		}

		public static void glGetSamplerParameterIiv(uint sampler, uint pname, int* @params)
		{
			Functions.glGetSamplerParameterIiv(sampler, pname, @params);
		}

		public static void glGetSamplerParameterIuiv(uint sampler, uint pname, uint* @params)
		{
			Functions.glGetSamplerParameterIuiv(sampler, pname, @params);
		}

		public static void glGetSamplerParameteriv(uint sampler, uint pname, int* @params)
		{
			Functions.glGetSamplerParameteriv(sampler, pname, @params);
		}

		public static void glGetShaderInfoLog(uint shader, int bufSize, int* length, StringBuilder infoLog)
		{
			Functions.glGetShaderInfoLog(shader, bufSize, length, infoLog);
		}

		public static void glGetShaderiv(uint shader, uint pname, int* @params)
		{
			Functions.glGetShaderiv(shader, pname, @params);
		}

		public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision)
		{
			Functions.glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
		}

		public static void glGetShaderSource(uint shader, int bufSize, int* length, StringBuilder source)
		{
			Functions.glGetShaderSource(shader, bufSize, length, source);
		}

		public static IntPtr glGetString(uint name)
		{
			return Functions.glGetString(name);
		}

		public static IntPtr glGetStringi(uint name, uint index)
		{
			return Functions.glGetStringi(name, index);
		}

		public static uint glGetSubroutineIndex(uint program, uint shadertype, string name)
		{
			return Functions.glGetSubroutineIndex(program, shadertype, name);
		}

		public static int glGetSubroutineUniformLocation(uint program, uint shadertype, string name)
		{
			return Functions.glGetSubroutineUniformLocation(program, shadertype, name);
		}

		public static void glGetSynciv(IntPtr sync, uint pname, int bufSize, int* length, int* values)
		{
			Functions.glGetSynciv(sync, pname, bufSize, length, values);
		}

		public static void glGetTexImage(uint target, int level, uint format, uint type, void* pixels)
		{
			Functions.glGetTexImage(target, level, format, type, pixels);
		}

		public static void glGetTexLevelParameterfv(uint target, int level, uint pname, float* @params)
		{
			Functions.glGetTexLevelParameterfv(target, level, pname, @params);
		}

		public static void glGetTexLevelParameteriv(uint target, int level, uint pname, int* @params)
		{
			Functions.glGetTexLevelParameteriv(target, level, pname, @params);
		}

		public static void glGetTexParameterfv(uint target, uint pname, float* @params)
		{
			Functions.glGetTexParameterfv(target, pname, @params);
		}

		public static void glGetTexParameterIiv(uint target, uint pname, int* @params)
		{
			Functions.glGetTexParameterIiv(target, pname, @params);
		}

		public static void glGetTexParameterIuiv(uint target, uint pname, uint* @params)
		{
			Functions.glGetTexParameterIuiv(target, pname, @params);
		}

		public static void glGetTexParameteriv(uint target, uint pname, int* @params)
		{
			Functions.glGetTexParameteriv(target, pname, @params);
		}

		public static void glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, void* pixels)
		{
			Functions.glGetTextureImage(texture, level, format, type, bufSize, pixels);
		}

		public static void glGetTextureLevelParameterfv(uint texture, int level, uint pname, float* @params)
		{
			Functions.glGetTextureLevelParameterfv(texture, level, pname, @params);
		}

		public static void glGetTextureLevelParameteriv(uint texture, int level, uint pname, int* @params)
		{
			Functions.glGetTextureLevelParameteriv(texture, level, pname, @params);
		}

		public static void glGetTextureParameterfv(uint texture, uint pname, float* @params)
		{
			Functions.glGetTextureParameterfv(texture, pname, @params);
		}

		public static void glGetTextureParameterIiv(uint texture, uint pname, int* @params)
		{
			Functions.glGetTextureParameterIiv(texture, pname, @params);
		}

		public static void glGetTextureParameterIuiv(uint texture, uint pname, uint* @params)
		{
			Functions.glGetTextureParameterIuiv(texture, pname, @params);
		}

		public static void glGetTextureParameteriv(uint texture, uint pname, int* @params)
		{
			Functions.glGetTextureParameteriv(texture, pname, @params);
		}

		public static void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels)
		{
			Functions.glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
		}

		public static void glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param)
		{
			Functions.glGetTransformFeedbacki_v(xfb, pname, index, param);
		}

		public static void glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long* param)
		{
			Functions.glGetTransformFeedbacki64_v(xfb, pname, index, param);
		}

		public static void glGetTransformFeedbackiv(uint xfb, uint pname, int* param)
		{
			Functions.glGetTransformFeedbackiv(xfb, pname, param);
		}

		public static void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, StringBuilder name)
		{
			Functions.glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
		}

		public static uint glGetUniformBlockIndex(uint program, string uniformBlockName)
		{
			return Functions.glGetUniformBlockIndex(program, uniformBlockName);
		}

		public static void glGetUniformdv(uint program, int location, double* @params)
		{
			Functions.glGetUniformdv(program, location, @params);
		}

		public static void glGetUniformfv(uint program, int location, float* @params)
		{
			Functions.glGetUniformfv(program, location, @params);
		}

		public static void glGetUniformIndices(uint program, int uniformCount, string[] uniformNames, uint* uniformIndices)
		{
			Functions.glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
		}

		public static void glGetUniformiv(uint program, int location, int* @params)
		{
			Functions.glGetUniformiv(program, location, @params);
		}

		public static int glGetUniformLocation(uint program, string name)
		{
			return Functions.glGetUniformLocation(program, name);
		}

		public static void glGetUniformSubroutineuiv(uint shadertype, int location, uint* @params)
		{
			Functions.glGetUniformSubroutineuiv(shadertype, location, @params);
		}

		public static void glGetUniformuiv(uint program, int location, uint* @params)
		{
			Functions.glGetUniformuiv(program, location, @params);
		}

		public static void glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long* param)
		{
			Functions.glGetVertexArrayIndexed64iv(vaobj, index, pname, param);
		}

		public static void glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param)
		{
			Functions.glGetVertexArrayIndexediv(vaobj, index, pname, param);
		}

		public static void glGetVertexArrayiv(uint vaobj, uint pname, int* param)
		{
			Functions.glGetVertexArrayiv(vaobj, pname, param);
		}

		public static void glGetVertexAttribdv(uint index, uint pname, double* @params)
		{
			Functions.glGetVertexAttribdv(index, pname, @params);
		}

		public static void glGetVertexAttribfv(uint index, uint pname, float* @params)
		{
			Functions.glGetVertexAttribfv(index, pname, @params);
		}

		public static void glGetVertexAttribIiv(uint index, uint pname, int* @params)
		{
			Functions.glGetVertexAttribIiv(index, pname, @params);
		}

		public static void glGetVertexAttribIuiv(uint index, uint pname, uint* @params)
		{
			Functions.glGetVertexAttribIuiv(index, pname, @params);
		}

		public static void glGetVertexAttribiv(uint index, uint pname, int* @params)
		{
			Functions.glGetVertexAttribiv(index, pname, @params);
		}

		public static void glGetVertexAttribLdv(uint index, uint pname, double* @params)
		{
			Functions.glGetVertexAttribLdv(index, pname, @params);
		}

		public static void glGetVertexAttribPointerv(uint index, uint pname, void** pointer)
		{
			Functions.glGetVertexAttribPointerv(index, pname, pointer);
		}

		public static void glHint(uint target, uint mode)
		{
			Functions.glHint(target, mode);
		}

		public static void glInvalidateBufferData(uint buffer)
		{
			Functions.glInvalidateBufferData(buffer);
		}

		public static void glInvalidateBufferSubData(uint buffer, int offset, int length)
		{
			Functions.glInvalidateBufferSubData(buffer, offset, length);
		}

		public static void glInvalidateFramebuffer(uint target, int numAttachments, uint* attachments)
		{
			Functions.glInvalidateFramebuffer(target, numAttachments, attachments);
		}

		public static void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments)
		{
			Functions.glInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
		}

		public static void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height)
		{
			Functions.glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
		}

		public static void glInvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height)
		{
			Functions.glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
		}

		public static void glInvalidateTexImage(uint texture, int level)
		{
			Functions.glInvalidateTexImage(texture, level);
		}

		public static void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
		{
			Functions.glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
		}

		public static bool glIsBuffer(uint buffer)
		{
			return Functions.glIsBuffer(buffer);
		}

		public static bool glIsEnabled(uint cap)
		{
			return Functions.glIsEnabled(cap);
		}

		public static bool glIsEnabledi(uint target, uint index)
		{
			return Functions.glIsEnabledi(target, index);
		}

		public static bool glIsFramebuffer(uint framebuffer)
		{
			return Functions.glIsFramebuffer(framebuffer);
		}

		public static bool glIsProgram(uint program)
		{
			return Functions.glIsProgram(program);
		}

		public static bool glIsProgramPipeline(uint pipeline)
		{
			return Functions.glIsProgramPipeline(pipeline);
		}

		public static bool glIsQuery(uint id)
		{
			return Functions.glIsQuery(id);
		}

		public static bool glIsRenderbuffer(uint renderbuffer)
		{
			return Functions.glIsRenderbuffer(renderbuffer);
		}

		public static bool glIsSampler(uint sampler)
		{
			return Functions.glIsSampler(sampler);
		}

		public static bool glIsShader(uint shader)
		{
			return Functions.glIsShader(shader);
		}

		public static bool glIsSync(IntPtr sync)
		{
			return Functions.glIsSync(sync);
		}

		public static bool glIsTexture(uint texture)
		{
			return Functions.glIsTexture(texture);
		}

		public static bool glIsTransformFeedback(uint id)
		{
			return Functions.glIsTransformFeedback(id);
		}

		public static bool glIsVertexArray(uint array)
		{
			return Functions.glIsVertexArray(array);
		}

		public static void glLineWidth(float width)
		{
			Functions.glLineWidth(width);
		}

		public static void glLinkProgram(uint program)
		{
			Functions.glLinkProgram(program);
		}

		public static void glLogicOp(uint opcode)
		{
			Functions.glLogicOp(opcode);
		}

		public static IntPtr glMapBuffer(uint target, uint access)
		{
			return Functions.glMapBuffer(target, access);
		}

		public static IntPtr glMapBufferRange(uint target, int offset, int length, uint access)
		{
			return Functions.glMapBufferRange(target, offset, length, access);
		}

		public static IntPtr glMapNamedBuffer(uint buffer, uint access)
		{
			return Functions.glMapNamedBuffer(buffer, access);
		}

		public static IntPtr glMapNamedBufferRange(uint buffer, int offset, int length, uint access)
		{
			return Functions.glMapNamedBufferRange(buffer, offset, length, access);
		}

		public static void glMemoryBarrier(uint barriers)
		{
			Functions.glMemoryBarrier(barriers);
		}

		public static void glMemoryBarrierByRegion(uint barriers)
		{
			Functions.glMemoryBarrierByRegion(barriers);
		}

		public static void glMinSampleShading(float value)
		{
			Functions.glMinSampleShading(value);
		}

		public static void glMultiDrawArrays(uint mode, int* first, int* count, int drawcount)
		{
			Functions.glMultiDrawArrays(mode, first, count, drawcount);
		}

		public static void glMultiDrawArraysIndirect(uint mode, void* indirect, int drawcount, int stride)
		{
			Functions.glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
		}

		public static void glMultiDrawArraysIndirectCount(uint mode, void* indirect, int drawcount, int maxdrawcount, int stride)
		{
			Functions.glMultiDrawArraysIndirectCount(mode, indirect, drawcount, maxdrawcount, stride);
		}

		public static void glMultiDrawElements(uint mode, int* count, uint type, void** indices, int drawcount)
		{
			Functions.glMultiDrawElements(mode, count, type, indices, drawcount);
		}

		public static void glMultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex)
		{
			Functions.glMultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
		}

		public static void glMultiDrawElementsIndirect(uint mode, uint type, void* indirect, int drawcount, int stride)
		{
			Functions.glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
		}

		public static void glMultiDrawElementsIndirectCount(uint mode, uint type, void* indirect, int drawcount, int maxdrawcount, int stride)
		{
			Functions.glMultiDrawElementsIndirectCount(mode, type, indirect, drawcount, maxdrawcount, stride);
		}

		public static void glNamedBufferData(uint buffer, int size, void* data, uint usage)
		{
			Functions.glNamedBufferData(buffer, size, data, usage);
		}

		public static void glNamedBufferStorage(uint buffer, int size, void* data, uint flags)
		{
			Functions.glNamedBufferStorage(buffer, size, data, flags);
		}

		public static void glNamedBufferSubData(uint buffer, int offset, int size, void* data)
		{
			Functions.glNamedBufferSubData(buffer, offset, size, data);
		}

		public static void glNamedFramebufferDrawBuffer(uint framebuffer, uint buf)
		{
			Functions.glNamedFramebufferDrawBuffer(framebuffer, buf);
		}

		public static void glNamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs)
		{
			Functions.glNamedFramebufferDrawBuffers(framebuffer, n, bufs);
		}

		public static void glNamedFramebufferParameteri(uint framebuffer, uint pname, int param)
		{
			Functions.glNamedFramebufferParameteri(framebuffer, pname, param);
		}

		public static void glNamedFramebufferReadBuffer(uint framebuffer, uint src)
		{
			Functions.glNamedFramebufferReadBuffer(framebuffer, src);
		}

		public static void glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			Functions.glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
		}

		public static void glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level)
		{
			Functions.glNamedFramebufferTexture(framebuffer, attachment, texture, level);
		}

		public static void glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer)
		{
			Functions.glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
		}

		public static void glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height)
		{
			Functions.glNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
		}

		public static void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height)
		{
			Functions.glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
		}

		public static void glObjectLabel(uint identifier, uint name, int length, string label)
		{
			Functions.glObjectLabel(identifier, name, length, label);
		}

		public static void glObjectPtrLabel(void* ptr, int length, string label)
		{
			Functions.glObjectPtrLabel(ptr, length, label);
		}

		public static void glPatchParameterfv(uint pname, float* values)
		{
			Functions.glPatchParameterfv(pname, values);
		}

		public static void glPatchParameteri(uint pname, int value)
		{
			Functions.glPatchParameteri(pname, value);
		}

		public static void glPauseTransformFeedback()
		{
			Functions.glPauseTransformFeedback();
		}

		public static void glPixelStoref(uint pname, float param)
		{
			Functions.glPixelStoref(pname, param);
		}

		public static void glPixelStorei(uint pname, int param)
		{
			Functions.glPixelStorei(pname, param);
		}

		public static void glPointParameterf(uint pname, float param)
		{
			Functions.glPointParameterf(pname, param);
		}

		public static void glPointParameterfv(uint pname, float* @params)
		{
			Functions.glPointParameterfv(pname, @params);
		}

		public static void glPointParameteri(uint pname, int param)
		{
			Functions.glPointParameteri(pname, param);
		}

		public static void glPointParameteriv(uint pname, int* @params)
		{
			Functions.glPointParameteriv(pname, @params);
		}

		public static void glPointSize(float size)
		{
			Functions.glPointSize(size);
		}

		public static void glPolygonMode(uint face, uint mode)
		{
			Functions.glPolygonMode(face, mode);
		}

		public static void glPolygonOffset(float factor, float units)
		{
			Functions.glPolygonOffset(factor, units);
		}

		public static void glPolygonOffsetClamp(float factor, float units, float clamp)
		{
			Functions.glPolygonOffsetClamp(factor, units, clamp);
		}

		public static void glPopDebugGroup()
		{
			Functions.glPopDebugGroup();
		}

		public static void glPrimitiveRestartIndex(uint index)
		{
			Functions.glPrimitiveRestartIndex(index);
		}

		public static void glProgramBinary(uint program, uint binaryFormat, void* binary, int length)
		{
			Functions.glProgramBinary(program, binaryFormat, binary, length);
		}

		public static void glProgramParameteri(uint program, uint pname, int value)
		{
			Functions.glProgramParameteri(program, pname, value);
		}

		public static void glProgramUniform1d(uint program, int location, double v0)
		{
			Functions.glProgramUniform1d(program, location, v0);
		}

		public static void glProgramUniform1dv(uint program, int location, int count, double* value)
		{
			Functions.glProgramUniform1dv(program, location, count, value);
		}

		public static void glProgramUniform1f(uint program, int location, float v0)
		{
			Functions.glProgramUniform1f(program, location, v0);
		}

		public static void glProgramUniform1fv(uint program, int location, int count, float* value)
		{
			Functions.glProgramUniform1fv(program, location, count, value);
		}

		public static void glProgramUniform1i(uint program, int location, int v0)
		{
			Functions.glProgramUniform1i(program, location, v0);
		}

		public static void glProgramUniform1iv(uint program, int location, int count, int* value)
		{
			Functions.glProgramUniform1iv(program, location, count, value);
		}

		public static void glProgramUniform1ui(uint program, int location, uint v0)
		{
			Functions.glProgramUniform1ui(program, location, v0);
		}

		public static void glProgramUniform1uiv(uint program, int location, int count, uint* value)
		{
			Functions.glProgramUniform1uiv(program, location, count, value);
		}

		public static void glProgramUniform2d(uint program, int location, double v0, double v1)
		{
			Functions.glProgramUniform2d(program, location, v0, v1);
		}

		public static void glProgramUniform2dv(uint program, int location, int count, double* value)
		{
			Functions.glProgramUniform2dv(program, location, count, value);
		}

		public static void glProgramUniform2f(uint program, int location, float v0, float v1)
		{
			Functions.glProgramUniform2f(program, location, v0, v1);
		}

		public static void glProgramUniform2fv(uint program, int location, int count, float* value)
		{
			Functions.glProgramUniform2fv(program, location, count, value);
		}

		public static void glProgramUniform2i(uint program, int location, int v0, int v1)
		{
			Functions.glProgramUniform2i(program, location, v0, v1);
		}

		public static void glProgramUniform2iv(uint program, int location, int count, int* value)
		{
			Functions.glProgramUniform2iv(program, location, count, value);
		}

		public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1)
		{
			Functions.glProgramUniform2ui(program, location, v0, v1);
		}

		public static void glProgramUniform2uiv(uint program, int location, int count, uint* value)
		{
			Functions.glProgramUniform2uiv(program, location, count, value);
		}

		public static void glProgramUniform3d(uint program, int location, double v0, double v1, double v2)
		{
			Functions.glProgramUniform3d(program, location, v0, v1, v2);
		}

		public static void glProgramUniform3dv(uint program, int location, int count, double* value)
		{
			Functions.glProgramUniform3dv(program, location, count, value);
		}

		public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2)
		{
			Functions.glProgramUniform3f(program, location, v0, v1, v2);
		}

		public static void glProgramUniform3fv(uint program, int location, int count, float* value)
		{
			Functions.glProgramUniform3fv(program, location, count, value);
		}

		public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2)
		{
			Functions.glProgramUniform3i(program, location, v0, v1, v2);
		}

		public static void glProgramUniform3iv(uint program, int location, int count, int* value)
		{
			Functions.glProgramUniform3iv(program, location, count, value);
		}

		public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2)
		{
			Functions.glProgramUniform3ui(program, location, v0, v1, v2);
		}

		public static void glProgramUniform3uiv(uint program, int location, int count, uint* value)
		{
			Functions.glProgramUniform3uiv(program, location, count, value);
		}

		public static void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3)
		{
			Functions.glProgramUniform4d(program, location, v0, v1, v2, v3);
		}

		public static void glProgramUniform4dv(uint program, int location, int count, double* value)
		{
			Functions.glProgramUniform4dv(program, location, count, value);
		}

		public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3)
		{
			Functions.glProgramUniform4f(program, location, v0, v1, v2, v3);
		}

		public static void glProgramUniform4fv(uint program, int location, int count, float* value)
		{
			Functions.glProgramUniform4fv(program, location, count, value);
		}

		public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3)
		{
			Functions.glProgramUniform4i(program, location, v0, v1, v2, v3);
		}

		public static void glProgramUniform4iv(uint program, int location, int count, int* value)
		{
			Functions.glProgramUniform4iv(program, location, count, value);
		}

		public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3)
		{
			Functions.glProgramUniform4ui(program, location, v0, v1, v2, v3);
		}

		public static void glProgramUniform4uiv(uint program, int location, int count, uint* value)
		{
			Functions.glProgramUniform4uiv(program, location, count, value);
		}

		public static void glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double* value)
		{
			Functions.glProgramUniformMatrix2dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value)
		{
			Functions.glProgramUniformMatrix2fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double* value)
		{
			Functions.glProgramUniformMatrix2x3dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float* value)
		{
			Functions.glProgramUniformMatrix2x3fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double* value)
		{
			Functions.glProgramUniformMatrix2x4dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float* value)
		{
			Functions.glProgramUniformMatrix2x4fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double* value)
		{
			Functions.glProgramUniformMatrix3dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value)
		{
			Functions.glProgramUniformMatrix3fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double* value)
		{
			Functions.glProgramUniformMatrix3x2dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float* value)
		{
			Functions.glProgramUniformMatrix3x2fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double* value)
		{
			Functions.glProgramUniformMatrix3x4dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float* value)
		{
			Functions.glProgramUniformMatrix3x4fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double* value)
		{
			Functions.glProgramUniformMatrix4dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value)
		{
			Functions.glProgramUniformMatrix4fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double* value)
		{
			Functions.glProgramUniformMatrix4x2dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float* value)
		{
			Functions.glProgramUniformMatrix4x2fv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double* value)
		{
			Functions.glProgramUniformMatrix4x3dv(program, location, count, transpose, value);
		}

		public static void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float* value)
		{
			Functions.glProgramUniformMatrix4x3fv(program, location, count, transpose, value);
		}

		public static void glProvokingVertex(uint mode)
		{
			Functions.glProvokingVertex(mode);
		}

		public static void glPushDebugGroup(uint source, uint id, int length, string message)
		{
			Functions.glPushDebugGroup(source, id, length, message);
		}

		public static void glQueryCounter(uint id, uint target)
		{
			Functions.glQueryCounter(id, target);
		}

		public static void glReadBuffer(uint src)
		{
			Functions.glReadBuffer(src);
		}

		public static void glReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data)
		{
			Functions.glReadnPixels(x, y, width, height, format, type, bufSize, data);
		}

		public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels)
		{
			Functions.glReadPixels(x, y, width, height, format, type, pixels);
		}

		public static void glReleaseShaderCompiler()
		{
			Functions.glReleaseShaderCompiler();
		}

		public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height)
		{
			Functions.glRenderbufferStorage(target, internalformat, width, height);
		}

		public static void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height)
		{
			Functions.glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
		}

		public static void glResumeTransformFeedback()
		{
			Functions.glResumeTransformFeedback();
		}

		public static void glSampleCoverage(float value, bool invert)
		{
			Functions.glSampleCoverage(value, invert);
		}

		public static void glSampleMaski(uint maskNumber, uint mask)
		{
			Functions.glSampleMaski(maskNumber, mask);
		}

		public static void glSamplerParameterf(uint sampler, uint pname, float param)
		{
			Functions.glSamplerParameterf(sampler, pname, param);
		}

		public static void glSamplerParameterfv(uint sampler, uint pname, float* param)
		{
			Functions.glSamplerParameterfv(sampler, pname, param);
		}

		public static void glSamplerParameteri(uint sampler, uint pname, int param)
		{
			Functions.glSamplerParameteri(sampler, pname, param);
		}

		public static void glSamplerParameterIiv(uint sampler, uint pname, int* param)
		{
			Functions.glSamplerParameterIiv(sampler, pname, param);
		}

		public static void glSamplerParameterIuiv(uint sampler, uint pname, uint* param)
		{
			Functions.glSamplerParameterIuiv(sampler, pname, param);
		}

		public static void glSamplerParameteriv(uint sampler, uint pname, int* param)
		{
			Functions.glSamplerParameteriv(sampler, pname, param);
		}

		public static void glScissor(int x, int y, int width, int height)
		{
			Functions.glScissor(x, y, width, height);
		}

		public static void glScissorArrayv(uint first, int count, int* v)
		{
			Functions.glScissorArrayv(first, count, v);
		}

		public static void glScissorIndexed(uint index, int left, int bottom, int width, int height)
		{
			Functions.glScissorIndexed(index, left, bottom, width, height);
		}

		public static void glScissorIndexedv(uint index, int* v)
		{
			Functions.glScissorIndexedv(index, v);
		}

		public static void glShaderBinary(int count, uint* shaders, uint binaryformat, void* binary, int length)
		{
			Functions.glShaderBinary(count, shaders, binaryformat, binary, length);
		}

		public static void glShaderSource(uint shader, int count, string[] @string, int* length)
		{
			Functions.glShaderSource(shader, count, @string, length);
		}

		public static void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding)
		{
			Functions.glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
		}

		public static void glSpecializeShader(uint shader, string pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue)
		{
			Functions.glSpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
		}

		public static void glStencilFunc(uint func, int @ref, uint mask)
		{
			Functions.glStencilFunc(func, @ref, mask);
		}

		public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask)
		{
			Functions.glStencilFuncSeparate(face, func, @ref, mask);
		}

		public static void glStencilMask(uint mask)
		{
			Functions.glStencilMask(mask);
		}

		public static void glStencilMaskSeparate(uint face, uint mask)
		{
			Functions.glStencilMaskSeparate(face, mask);
		}

		public static void glStencilOp(uint fail, uint zfail, uint zpass)
		{
			Functions.glStencilOp(fail, zfail, zpass);
		}

		public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass)
		{
			Functions.glStencilOpSeparate(face, sfail, dpfail, dppass);
		}

		public static void glTexBuffer(uint target, uint internalformat, uint buffer)
		{
			Functions.glTexBuffer(target, internalformat, buffer);
		}

		public static void glTexBufferRange(uint target, uint internalformat, uint buffer, int offset, int size)
		{
			Functions.glTexBufferRange(target, internalformat, buffer, offset, size);
		}

		public static void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels)
		{
			Functions.glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
		}

		public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels)
		{
			Functions.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}

		public static void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			Functions.glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}

		public static void glTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels)
		{
			Functions.glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}

		public static void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			Functions.glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

		public static void glTexParameterf(uint target, uint pname, float param)
		{
			Functions.glTexParameterf(target, pname, param);
		}

		public static void glTexParameterfv(uint target, uint pname, float* @params)
		{
			Functions.glTexParameterfv(target, pname, @params);
		}

		public static void glTexParameteri(uint target, uint pname, int param)
		{
			Functions.glTexParameteri(target, pname, param);
		}

		public static void glTexParameterIiv(uint target, uint pname, int* @params)
		{
			Functions.glTexParameterIiv(target, pname, @params);
		}

		public static void glTexParameterIuiv(uint target, uint pname, uint* @params)
		{
			Functions.glTexParameterIuiv(target, pname, @params);
		}

		public static void glTexParameteriv(uint target, uint pname, int* @params)
		{
			Functions.glTexParameteriv(target, pname, @params);
		}

		public static void glTexStorage1D(uint target, int levels, uint internalformat, int width)
		{
			Functions.glTexStorage1D(target, levels, internalformat, width);
		}

		public static void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height)
		{
			Functions.glTexStorage2D(target, levels, internalformat, width, height);
		}

		public static void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			Functions.glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		}

		public static void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth)
		{
			Functions.glTexStorage3D(target, levels, internalformat, width, height, depth);
		}

		public static void glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			Functions.glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

		public static void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels)
		{
			Functions.glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
		}

		public static void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels)
		{
			Functions.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}

		public static void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels)
		{
			Functions.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}

		public static void glTextureBarrier()
		{
			Functions.glTextureBarrier();
		}

		public static void glTextureBuffer(uint texture, uint internalformat, uint buffer)
		{
			Functions.glTextureBuffer(texture, internalformat, buffer);
		}

		public static void glTextureBufferRange(uint texture, uint internalformat, uint buffer, int offset, int size)
		{
			Functions.glTextureBufferRange(texture, internalformat, buffer, offset, size);
		}

		public static void glTextureParameterf(uint texture, uint pname, float param)
		{
			Functions.glTextureParameterf(texture, pname, param);
		}

		public static void glTextureParameterfv(uint texture, uint pname, float* param)
		{
			Functions.glTextureParameterfv(texture, pname, param);
		}

		public static void glTextureParameteri(uint texture, uint pname, int param)
		{
			Functions.glTextureParameteri(texture, pname, param);
		}

		public static void glTextureParameterIiv(uint texture, uint pname, int* @params)
		{
			Functions.glTextureParameterIiv(texture, pname, @params);
		}

		public static void glTextureParameterIuiv(uint texture, uint pname, uint* @params)
		{
			Functions.glTextureParameterIuiv(texture, pname, @params);
		}

		public static void glTextureParameteriv(uint texture, uint pname, int* param)
		{
			Functions.glTextureParameteriv(texture, pname, param);
		}

		public static void glTextureStorage1D(uint texture, int levels, uint internalformat, int width)
		{
			Functions.glTextureStorage1D(texture, levels, internalformat, width);
		}

		public static void glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height)
		{
			Functions.glTextureStorage2D(texture, levels, internalformat, width, height);
		}

		public static void glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			Functions.glTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
		}

		public static void glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth)
		{
			Functions.glTextureStorage3D(texture, levels, internalformat, width, height, depth);
		}

		public static void glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			Functions.glTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
		}

		public static void glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels)
		{
			Functions.glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
		}

		public static void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels)
		{
			Functions.glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
		}

		public static void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels)
		{
			Functions.glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}

		public static void glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
		{
			Functions.glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
		}

		public static void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer)
		{
			Functions.glTransformFeedbackBufferBase(xfb, index, buffer);
		}

		public static void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size)
		{
			Functions.glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
		}

		public static void glTransformFeedbackVaryings(uint program, int count, string[] varyings, uint bufferMode)
		{
			Functions.glTransformFeedbackVaryings(program, count, varyings, bufferMode);
		}

		public static void glUniform1d(int location, double x)
		{
			Functions.glUniform1d(location, x);
		}

		public static void glUniform1dv(int location, int count, double* value)
		{
			Functions.glUniform1dv(location, count, value);
		}

		public static void glUniform1f(int location, float v0)
		{
			Functions.glUniform1f(location, v0);
		}

		public static void glUniform1fv(int location, int count, float* value)
		{
			Functions.glUniform1fv(location, count, value);
		}

		public static void glUniform1i(int location, int v0)
		{
			Functions.glUniform1i(location, v0);
		}

		public static void glUniform1iv(int location, int count, int* value)
		{
			Functions.glUniform1iv(location, count, value);
		}

		public static void glUniform1ui(int location, uint v0)
		{
			Functions.glUniform1ui(location, v0);
		}

		public static void glUniform1uiv(int location, int count, uint* value)
		{
			Functions.glUniform1uiv(location, count, value);
		}

		public static void glUniform2d(int location, double x, double y)
		{
			Functions.glUniform2d(location, x, y);
		}

		public static void glUniform2dv(int location, int count, double* value)
		{
			Functions.glUniform2dv(location, count, value);
		}

		public static void glUniform2f(int location, float v0, float v1)
		{
			Functions.glUniform2f(location, v0, v1);
		}

		public static void glUniform2fv(int location, int count, float* value)
		{
			Functions.glUniform2fv(location, count, value);
		}

		public static void glUniform2i(int location, int v0, int v1)
		{
			Functions.glUniform2i(location, v0, v1);
		}

		public static void glUniform2iv(int location, int count, int* value)
		{
			Functions.glUniform2iv(location, count, value);
		}

		public static void glUniform2ui(int location, uint v0, uint v1)
		{
			Functions.glUniform2ui(location, v0, v1);
		}

		public static void glUniform2uiv(int location, int count, uint* value)
		{
			Functions.glUniform2uiv(location, count, value);
		}

		public static void glUniform3d(int location, double x, double y, double z)
		{
			Functions.glUniform3d(location, x, y, z);
		}

		public static void glUniform3dv(int location, int count, double* value)
		{
			Functions.glUniform3dv(location, count, value);
		}

		public static void glUniform3f(int location, float v0, float v1, float v2)
		{
			Functions.glUniform3f(location, v0, v1, v2);
		}

		public static void glUniform3fv(int location, int count, float* value)
		{
			Functions.glUniform3fv(location, count, value);
		}

		public static void glUniform3i(int location, int v0, int v1, int v2)
		{
			Functions.glUniform3i(location, v0, v1, v2);
		}

		public static void glUniform3iv(int location, int count, int* value)
		{
			Functions.glUniform3iv(location, count, value);
		}

		public static void glUniform3ui(int location, uint v0, uint v1, uint v2)
		{
			Functions.glUniform3ui(location, v0, v1, v2);
		}

		public static void glUniform3uiv(int location, int count, uint* value)
		{
			Functions.glUniform3uiv(location, count, value);
		}

		public static void glUniform4d(int location, double x, double y, double z, double w)
		{
			Functions.glUniform4d(location, x, y, z, w);
		}

		public static void glUniform4dv(int location, int count, double* value)
		{
			Functions.glUniform4dv(location, count, value);
		}

		public static void glUniform4f(int location, float v0, float v1, float v2, float v3)
		{
			Functions.glUniform4f(location, v0, v1, v2, v3);
		}

		public static void glUniform4fv(int location, int count, float* value)
		{
			Functions.glUniform4fv(location, count, value);
		}

		public static void glUniform4i(int location, int v0, int v1, int v2, int v3)
		{
			Functions.glUniform4i(location, v0, v1, v2, v3);
		}

		public static void glUniform4iv(int location, int count, int* value)
		{
			Functions.glUniform4iv(location, count, value);
		}

		public static void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3)
		{
			Functions.glUniform4ui(location, v0, v1, v2, v3);
		}

		public static void glUniform4uiv(int location, int count, uint* value)
		{
			Functions.glUniform4uiv(location, count, value);
		}

		public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
			Functions.glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
		}

		public static void glUniformMatrix2dv(int location, int count, bool transpose, double* value)
		{
			Functions.glUniformMatrix2dv(location, count, transpose, value);
		}

		public static void glUniformMatrix2fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix2fv(location, count, transpose, value);
		}

		public static void glUniformMatrix2x3dv(int location, int count, bool transpose, double* value)
		{
			Functions.glUniformMatrix2x3dv(location, count, transpose, value);
		}

		public static void glUniformMatrix2x3fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix2x3fv(location, count, transpose, value);
		}

		public static void glUniformMatrix2x4dv(int location, int count, bool transpose, double* value)
		{
			Functions.glUniformMatrix2x4dv(location, count, transpose, value);
		}

		public static void glUniformMatrix2x4fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix2x4fv(location, count, transpose, value);
		}

		public static void glUniformMatrix3dv(int location, int count, bool transpose, double* value)
		{
			Functions.glUniformMatrix3dv(location, count, transpose, value);
		}

		public static void glUniformMatrix3fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix3fv(location, count, transpose, value);
		}

		public static void glUniformMatrix3x2dv(int location, int count, bool transpose, double* value)
		{
			Functions.glUniformMatrix3x2dv(location, count, transpose, value);
		}

		public static void glUniformMatrix3x2fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix3x2fv(location, count, transpose, value);
		}

		public static void glUniformMatrix3x4dv(int location, int count, bool transpose, double* value)
		{
			Functions.glUniformMatrix3x4dv(location, count, transpose, value);
		}

		public static void glUniformMatrix3x4fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix3x4fv(location, count, transpose, value);
		}

		public static void glUniformMatrix4dv(int location, int count, bool transpose, double* value)
		{
			Functions.glUniformMatrix4dv(location, count, transpose, value);
		}

		public static void glUniformMatrix4fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix4fv(location, count, transpose, value);
		}

		public static void glUniformMatrix4x2dv(int location, int count, bool transpose, double* value)
		{
			Functions.glUniformMatrix4x2dv(location, count, transpose, value);
		}

		public static void glUniformMatrix4x2fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix4x2fv(location, count, transpose, value);
		}

		public static void glUniformMatrix4x3dv(int location, int count, bool transpose, double* value)
		{
			Functions.glUniformMatrix4x3dv(location, count, transpose, value);
		}

		public static void glUniformMatrix4x3fv(int location, int count, bool transpose, float* value)
		{
			Functions.glUniformMatrix4x3fv(location, count, transpose, value);
		}

		public static void glUniformSubroutinesuiv(uint shadertype, int count, uint* indices)
		{
			Functions.glUniformSubroutinesuiv(shadertype, count, indices);
		}

		public static bool glUnmapBuffer(uint target)
		{
			return Functions.glUnmapBuffer(target);
		}

		public static bool glUnmapNamedBuffer(uint buffer)
		{
			return Functions.glUnmapNamedBuffer(buffer);
		}

		public static void glUseProgram(uint program)
		{
			Functions.glUseProgram(program);
		}

		public static void glUseProgramStages(uint pipeline, uint stages, uint program)
		{
			Functions.glUseProgramStages(pipeline, stages, program);
		}

		public static void glValidateProgram(uint program)
		{
			Functions.glValidateProgram(program);
		}

		public static void glValidateProgramPipeline(uint pipeline)
		{
			Functions.glValidateProgramPipeline(pipeline);
		}

		public static void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex)
		{
			Functions.glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
		}

		public static void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			Functions.glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
		}

		public static void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			Functions.glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
		}

		public static void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset)
		{
			Functions.glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
		}

		public static void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor)
		{
			Functions.glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
		}

		public static void glVertexArrayElementBuffer(uint vaobj, uint buffer)
		{
			Functions.glVertexArrayElementBuffer(vaobj, buffer);
		}

		public static void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride)
		{
			Functions.glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
		}

		public static void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, int* offsets, int* strides)
		{
			Functions.glVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
		}

		public static void glVertexAttrib1d(uint index, double x)
		{
			Functions.glVertexAttrib1d(index, x);
		}

		public static void glVertexAttrib1dv(uint index, double* v)
		{
			Functions.glVertexAttrib1dv(index, v);
		}

		public static void glVertexAttrib1f(uint index, float x)
		{
			Functions.glVertexAttrib1f(index, x);
		}

		public static void glVertexAttrib1fv(uint index, float* v)
		{
			Functions.glVertexAttrib1fv(index, v);
		}

		public static void glVertexAttrib1s(uint index, short x)
		{
			Functions.glVertexAttrib1s(index, x);
		}

		public static void glVertexAttrib1sv(uint index, short* v)
		{
			Functions.glVertexAttrib1sv(index, v);
		}

		public static void glVertexAttrib2d(uint index, double x, double y)
		{
			Functions.glVertexAttrib2d(index, x, y);
		}

		public static void glVertexAttrib2dv(uint index, double* v)
		{
			Functions.glVertexAttrib2dv(index, v);
		}

		public static void glVertexAttrib2f(uint index, float x, float y)
		{
			Functions.glVertexAttrib2f(index, x, y);
		}

		public static void glVertexAttrib2fv(uint index, float* v)
		{
			Functions.glVertexAttrib2fv(index, v);
		}

		public static void glVertexAttrib2s(uint index, short x, short y)
		{
			Functions.glVertexAttrib2s(index, x, y);
		}

		public static void glVertexAttrib2sv(uint index, short* v)
		{
			Functions.glVertexAttrib2sv(index, v);
		}

		public static void glVertexAttrib3d(uint index, double x, double y, double z)
		{
			Functions.glVertexAttrib3d(index, x, y, z);
		}

		public static void glVertexAttrib3dv(uint index, double* v)
		{
			Functions.glVertexAttrib3dv(index, v);
		}

		public static void glVertexAttrib3f(uint index, float x, float y, float z)
		{
			Functions.glVertexAttrib3f(index, x, y, z);
		}

		public static void glVertexAttrib3fv(uint index, float* v)
		{
			Functions.glVertexAttrib3fv(index, v);
		}

		public static void glVertexAttrib3s(uint index, short x, short y, short z)
		{
			Functions.glVertexAttrib3s(index, x, y, z);
		}

		public static void glVertexAttrib3sv(uint index, short* v)
		{
			Functions.glVertexAttrib3sv(index, v);
		}

		public static void glVertexAttrib4bv(uint index, sbyte* v)
		{
			Functions.glVertexAttrib4bv(index, v);
		}

		public static void glVertexAttrib4d(uint index, double x, double y, double z, double w)
		{
			Functions.glVertexAttrib4d(index, x, y, z, w);
		}

		public static void glVertexAttrib4dv(uint index, double* v)
		{
			Functions.glVertexAttrib4dv(index, v);
		}

		public static void glVertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			Functions.glVertexAttrib4f(index, x, y, z, w);
		}

		public static void glVertexAttrib4fv(uint index, float* v)
		{
			Functions.glVertexAttrib4fv(index, v);
		}

		public static void glVertexAttrib4iv(uint index, int* v)
		{
			Functions.glVertexAttrib4iv(index, v);
		}

		public static void glVertexAttrib4Nbv(uint index, sbyte* v)
		{
			Functions.glVertexAttrib4Nbv(index, v);
		}

		public static void glVertexAttrib4Niv(uint index, int* v)
		{
			Functions.glVertexAttrib4Niv(index, v);
		}

		public static void glVertexAttrib4Nsv(uint index, short* v)
		{
			Functions.glVertexAttrib4Nsv(index, v);
		}

		public static void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w)
		{
			Functions.glVertexAttrib4Nub(index, x, y, z, w);
		}

		public static void glVertexAttrib4Nubv(uint index, byte* v)
		{
			Functions.glVertexAttrib4Nubv(index, v);
		}

		public static void glVertexAttrib4Nuiv(uint index, uint* v)
		{
			Functions.glVertexAttrib4Nuiv(index, v);
		}

		public static void glVertexAttrib4Nusv(uint index, ushort* v)
		{
			Functions.glVertexAttrib4Nusv(index, v);
		}

		public static void glVertexAttrib4s(uint index, short x, short y, short z, short w)
		{
			Functions.glVertexAttrib4s(index, x, y, z, w);
		}

		public static void glVertexAttrib4sv(uint index, short* v)
		{
			Functions.glVertexAttrib4sv(index, v);
		}

		public static void glVertexAttrib4ubv(uint index, byte* v)
		{
			Functions.glVertexAttrib4ubv(index, v);
		}

		public static void glVertexAttrib4uiv(uint index, uint* v)
		{
			Functions.glVertexAttrib4uiv(index, v);
		}

		public static void glVertexAttrib4usv(uint index, ushort* v)
		{
			Functions.glVertexAttrib4usv(index, v);
		}

		public static void glVertexAttribBinding(uint attribindex, uint bindingindex)
		{
			Functions.glVertexAttribBinding(attribindex, bindingindex);
		}

		public static void glVertexAttribDivisor(uint index, uint divisor)
		{
			Functions.glVertexAttribDivisor(index, divisor);
		}

		public static void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset)
		{
			Functions.glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
		}

		public static void glVertexAttribI1i(uint index, int x)
		{
			Functions.glVertexAttribI1i(index, x);
		}

		public static void glVertexAttribI1iv(uint index, int* v)
		{
			Functions.glVertexAttribI1iv(index, v);
		}

		public static void glVertexAttribI1ui(uint index, uint x)
		{
			Functions.glVertexAttribI1ui(index, x);
		}

		public static void glVertexAttribI1uiv(uint index, uint* v)
		{
			Functions.glVertexAttribI1uiv(index, v);
		}

		public static void glVertexAttribI2i(uint index, int x, int y)
		{
			Functions.glVertexAttribI2i(index, x, y);
		}

		public static void glVertexAttribI2iv(uint index, int* v)
		{
			Functions.glVertexAttribI2iv(index, v);
		}

		public static void glVertexAttribI2ui(uint index, uint x, uint y)
		{
			Functions.glVertexAttribI2ui(index, x, y);
		}

		public static void glVertexAttribI2uiv(uint index, uint* v)
		{
			Functions.glVertexAttribI2uiv(index, v);
		}

		public static void glVertexAttribI3i(uint index, int x, int y, int z)
		{
			Functions.glVertexAttribI3i(index, x, y, z);
		}

		public static void glVertexAttribI3iv(uint index, int* v)
		{
			Functions.glVertexAttribI3iv(index, v);
		}

		public static void glVertexAttribI3ui(uint index, uint x, uint y, uint z)
		{
			Functions.glVertexAttribI3ui(index, x, y, z);
		}

		public static void glVertexAttribI3uiv(uint index, uint* v)
		{
			Functions.glVertexAttribI3uiv(index, v);
		}

		public static void glVertexAttribI4bv(uint index, sbyte* v)
		{
			Functions.glVertexAttribI4bv(index, v);
		}

		public static void glVertexAttribI4i(uint index, int x, int y, int z, int w)
		{
			Functions.glVertexAttribI4i(index, x, y, z, w);
		}

		public static void glVertexAttribI4iv(uint index, int* v)
		{
			Functions.glVertexAttribI4iv(index, v);
		}

		public static void glVertexAttribI4sv(uint index, short* v)
		{
			Functions.glVertexAttribI4sv(index, v);
		}

		public static void glVertexAttribI4ubv(uint index, byte* v)
		{
			Functions.glVertexAttribI4ubv(index, v);
		}

		public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
			Functions.glVertexAttribI4ui(index, x, y, z, w);
		}

		public static void glVertexAttribI4uiv(uint index, uint* v)
		{
			Functions.glVertexAttribI4uiv(index, v);
		}

		public static void glVertexAttribI4usv(uint index, ushort* v)
		{
			Functions.glVertexAttribI4usv(index, v);
		}

		public static void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			Functions.glVertexAttribIFormat(attribindex, size, type, relativeoffset);
		}

		public static void glVertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer)
		{
			Functions.glVertexAttribIPointer(index, size, type, stride, pointer);
		}

		public static void glVertexAttribL1d(uint index, double x)
		{
			Functions.glVertexAttribL1d(index, x);
		}

		public static void glVertexAttribL1dv(uint index, double* v)
		{
			Functions.glVertexAttribL1dv(index, v);
		}

		public static void glVertexAttribL2d(uint index, double x, double y)
		{
			Functions.glVertexAttribL2d(index, x, y);
		}

		public static void glVertexAttribL2dv(uint index, double* v)
		{
			Functions.glVertexAttribL2dv(index, v);
		}

		public static void glVertexAttribL3d(uint index, double x, double y, double z)
		{
			Functions.glVertexAttribL3d(index, x, y, z);
		}

		public static void glVertexAttribL3dv(uint index, double* v)
		{
			Functions.glVertexAttribL3dv(index, v);
		}

		public static void glVertexAttribL4d(uint index, double x, double y, double z, double w)
		{
			Functions.glVertexAttribL4d(index, x, y, z, w);
		}

		public static void glVertexAttribL4dv(uint index, double* v)
		{
			Functions.glVertexAttribL4dv(index, v);
		}

		public static void glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset)
		{
			Functions.glVertexAttribLFormat(attribindex, size, type, relativeoffset);
		}

		public static void glVertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer)
		{
			Functions.glVertexAttribLPointer(index, size, type, stride, pointer);
		}

		public static void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value)
		{
			Functions.glVertexAttribP1ui(index, type, normalized, value);
		}

		public static void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint* value)
		{
			Functions.glVertexAttribP1uiv(index, type, normalized, value);
		}

		public static void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value)
		{
			Functions.glVertexAttribP2ui(index, type, normalized, value);
		}

		public static void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint* value)
		{
			Functions.glVertexAttribP2uiv(index, type, normalized, value);
		}

		public static void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value)
		{
			Functions.glVertexAttribP3ui(index, type, normalized, value);
		}

		public static void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint* value)
		{
			Functions.glVertexAttribP3uiv(index, type, normalized, value);
		}

		public static void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value)
		{
			Functions.glVertexAttribP4ui(index, type, normalized, value);
		}

		public static void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint* value)
		{
			Functions.glVertexAttribP4uiv(index, type, normalized, value);
		}

		public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer)
		{
			Functions.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		}

		public static void glVertexBindingDivisor(uint bindingindex, uint divisor)
		{
			Functions.glVertexBindingDivisor(bindingindex, divisor);
		}

		public static void glViewport(int x, int y, int width, int height)
		{
			Functions.glViewport(x, y, width, height);
		}

		public static void glViewportArrayv(uint first, int count, float* v)
		{
			Functions.glViewportArrayv(first, count, v);
		}

		public static void glViewportIndexedf(uint index, float x, float y, float w, float h)
		{
			Functions.glViewportIndexedf(index, x, y, w, h);
		}

		public static void glViewportIndexedfv(uint index, float* v)
		{
			Functions.glViewportIndexedfv(index, v);
		}

		public static void glWaitSync(IntPtr sync, uint flags, ulong timeout)
		{
			Functions.glWaitSync(sync, flags, timeout);
		}

	}
}
