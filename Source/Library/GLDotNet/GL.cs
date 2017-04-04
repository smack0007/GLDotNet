// Copyright (c) 2017 Zachary Snow
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

namespace GLDotNet
{
	public static class GL
	{
		public const uint DEPTH_BUFFER_BIT = 0x00000100;
		public const uint STENCIL_BUFFER_BIT = 0x00000400;
		public const uint COLOR_BUFFER_BIT = 0x00004000;
		public const uint FALSE = 0;
		public const uint TRUE = 1;
		public const uint POINTS = 0x0000;
		public const uint LINES = 0x0001;
		public const uint LINE_LOOP = 0x0002;
		public const uint LINE_STRIP = 0x0003;
		public const uint TRIANGLES = 0x0004;
		public const uint TRIANGLE_STRIP = 0x0005;
		public const uint TRIANGLE_FAN = 0x0006;
		public const uint QUADS = 0x0007;
		public const uint NEVER = 0x0200;
		public const uint LESS = 0x0201;
		public const uint EQUAL = 0x0202;
		public const uint LEQUAL = 0x0203;
		public const uint GREATER = 0x0204;
		public const uint NOTEQUAL = 0x0205;
		public const uint GEQUAL = 0x0206;
		public const uint ALWAYS = 0x0207;
		public const uint ZERO = 0;
		public const uint ONE = 1;
		public const uint SRC_COLOR = 0x0300;
		public const uint ONE_MINUS_SRC_COLOR = 0x0301;
		public const uint SRC_ALPHA = 0x0302;
		public const uint ONE_MINUS_SRC_ALPHA = 0x0303;
		public const uint DST_ALPHA = 0x0304;
		public const uint ONE_MINUS_DST_ALPHA = 0x0305;
		public const uint DST_COLOR = 0x0306;
		public const uint ONE_MINUS_DST_COLOR = 0x0307;
		public const uint SRC_ALPHA_SATURATE = 0x0308;
		public const uint NONE = 0;
		public const uint FRONT_LEFT = 0x0400;
		public const uint FRONT_RIGHT = 0x0401;
		public const uint BACK_LEFT = 0x0402;
		public const uint BACK_RIGHT = 0x0403;
		public const uint FRONT = 0x0404;
		public const uint BACK = 0x0405;
		public const uint LEFT = 0x0406;
		public const uint RIGHT = 0x0407;
		public const uint FRONT_AND_BACK = 0x0408;
		public const uint NO_ERROR = 0;
		public const uint INVALID_ENUM = 0x0500;
		public const uint INVALID_VALUE = 0x0501;
		public const uint INVALID_OPERATION = 0x0502;
		public const uint OUT_OF_MEMORY = 0x0505;
		public const uint CW = 0x0900;
		public const uint CCW = 0x0901;
		public const uint POINT_SIZE = 0x0B11;
		public const uint POINT_SIZE_RANGE = 0x0B12;
		public const uint POINT_SIZE_GRANULARITY = 0x0B13;
		public const uint LINE_SMOOTH = 0x0B20;
		public const uint LINE_WIDTH = 0x0B21;
		public const uint LINE_WIDTH_RANGE = 0x0B22;
		public const uint LINE_WIDTH_GRANULARITY = 0x0B23;
		public const uint POLYGON_MODE = 0x0B40;
		public const uint POLYGON_SMOOTH = 0x0B41;
		public const uint CULL_FACE = 0x0B44;
		public const uint CULL_FACE_MODE = 0x0B45;
		public const uint FRONT_FACE = 0x0B46;
		public const uint DEPTH_RANGE = 0x0B70;
		public const uint DEPTH_TEST = 0x0B71;
		public const uint DEPTH_WRITEMASK = 0x0B72;
		public const uint DEPTH_CLEAR_VALUE = 0x0B73;
		public const uint DEPTH_FUNC = 0x0B74;
		public const uint STENCIL_TEST = 0x0B90;
		public const uint STENCIL_CLEAR_VALUE = 0x0B91;
		public const uint STENCIL_FUNC = 0x0B92;
		public const uint STENCIL_VALUE_MASK = 0x0B93;
		public const uint STENCIL_FAIL = 0x0B94;
		public const uint STENCIL_PASS_DEPTH_FAIL = 0x0B95;
		public const uint STENCIL_PASS_DEPTH_PASS = 0x0B96;
		public const uint STENCIL_REF = 0x0B97;
		public const uint STENCIL_WRITEMASK = 0x0B98;
		public const uint VIEWPORT = 0x0BA2;
		public const uint DITHER = 0x0BD0;
		public const uint BLEND_DST = 0x0BE0;
		public const uint BLEND_SRC = 0x0BE1;
		public const uint BLEND = 0x0BE2;
		public const uint LOGIC_OP_MODE = 0x0BF0;
		public const uint DRAW_BUFFER = 0x0C01;
		public const uint READ_BUFFER = 0x0C02;
		public const uint SCISSOR_BOX = 0x0C10;
		public const uint SCISSOR_TEST = 0x0C11;
		public const uint COLOR_CLEAR_VALUE = 0x0C22;
		public const uint COLOR_WRITEMASK = 0x0C23;
		public const uint DOUBLEBUFFER = 0x0C32;
		public const uint STEREO = 0x0C33;
		public const uint LINE_SMOOTH_HINT = 0x0C52;
		public const uint POLYGON_SMOOTH_HINT = 0x0C53;
		public const uint UNPACK_SWAP_BYTES = 0x0CF0;
		public const uint UNPACK_LSB_FIRST = 0x0CF1;
		public const uint UNPACK_ROW_LENGTH = 0x0CF2;
		public const uint UNPACK_SKIP_ROWS = 0x0CF3;
		public const uint UNPACK_SKIP_PIXELS = 0x0CF4;
		public const uint UNPACK_ALIGNMENT = 0x0CF5;
		public const uint PACK_SWAP_BYTES = 0x0D00;
		public const uint PACK_LSB_FIRST = 0x0D01;
		public const uint PACK_ROW_LENGTH = 0x0D02;
		public const uint PACK_SKIP_ROWS = 0x0D03;
		public const uint PACK_SKIP_PIXELS = 0x0D04;
		public const uint PACK_ALIGNMENT = 0x0D05;
		public const uint MAX_TEXTURE_SIZE = 0x0D33;
		public const uint MAX_VIEWPORT_DIMS = 0x0D3A;
		public const uint SUBPIXEL_BITS = 0x0D50;
		public const uint TEXTURE_1D = 0x0DE0;
		public const uint TEXTURE_2D = 0x0DE1;
		public const uint TEXTURE_WIDTH = 0x1000;
		public const uint TEXTURE_HEIGHT = 0x1001;
		public const uint TEXTURE_BORDER_COLOR = 0x1004;
		public const uint DONT_CARE = 0x1100;
		public const uint FASTEST = 0x1101;
		public const uint NICEST = 0x1102;
		public const uint BYTE = 0x1400;
		public const uint UNSIGNED_BYTE = 0x1401;
		public const uint SHORT = 0x1402;
		public const uint UNSIGNED_SHORT = 0x1403;
		public const uint INT = 0x1404;
		public const uint UNSIGNED_INT = 0x1405;
		public const uint FLOAT = 0x1406;
		public const uint STACK_OVERFLOW = 0x0503;
		public const uint STACK_UNDERFLOW = 0x0504;
		public const uint CLEAR = 0x1500;
		public const uint AND = 0x1501;
		public const uint AND_REVERSE = 0x1502;
		public const uint COPY = 0x1503;
		public const uint AND_INVERTED = 0x1504;
		public const uint NOOP = 0x1505;
		public const uint XOR = 0x1506;
		public const uint OR = 0x1507;
		public const uint NOR = 0x1508;
		public const uint EQUIV = 0x1509;
		public const uint INVERT = 0x150A;
		public const uint OR_REVERSE = 0x150B;
		public const uint COPY_INVERTED = 0x150C;
		public const uint OR_INVERTED = 0x150D;
		public const uint NAND = 0x150E;
		public const uint SET = 0x150F;
		public const uint TEXTURE = 0x1702;
		public const uint COLOR = 0x1800;
		public const uint DEPTH = 0x1801;
		public const uint STENCIL = 0x1802;
		public const uint STENCIL_INDEX = 0x1901;
		public const uint DEPTH_COMPONENT = 0x1902;
		public const uint RED = 0x1903;
		public const uint GREEN = 0x1904;
		public const uint BLUE = 0x1905;
		public const uint ALPHA = 0x1906;
		public const uint RGB = 0x1907;
		public const uint RGBA = 0x1908;
		public const uint POINT = 0x1B00;
		public const uint LINE = 0x1B01;
		public const uint FILL = 0x1B02;
		public const uint KEEP = 0x1E00;
		public const uint REPLACE = 0x1E01;
		public const uint INCR = 0x1E02;
		public const uint DECR = 0x1E03;
		public const uint VENDOR = 0x1F00;
		public const uint RENDERER = 0x1F01;
		public const uint VERSION = 0x1F02;
		public const uint EXTENSIONS = 0x1F03;
		public const uint NEAREST = 0x2600;
		public const uint LINEAR = 0x2601;
		public const uint NEAREST_MIPMAP_NEAREST = 0x2700;
		public const uint LINEAR_MIPMAP_NEAREST = 0x2701;
		public const uint NEAREST_MIPMAP_LINEAR = 0x2702;
		public const uint LINEAR_MIPMAP_LINEAR = 0x2703;
		public const uint TEXTURE_MAG_FILTER = 0x2800;
		public const uint TEXTURE_MIN_FILTER = 0x2801;
		public const uint TEXTURE_WRAP_S = 0x2802;
		public const uint TEXTURE_WRAP_T = 0x2803;
		public const uint REPEAT = 0x2901;
		public const uint COLOR_LOGIC_OP = 0x0BF2;
		public const uint POLYGON_OFFSET_UNITS = 0x2A00;
		public const uint POLYGON_OFFSET_POINT = 0x2A01;
		public const uint POLYGON_OFFSET_LINE = 0x2A02;
		public const uint POLYGON_OFFSET_FILL = 0x8037;
		public const uint POLYGON_OFFSET_FACTOR = 0x8038;
		public const uint TEXTURE_BINDING_1D = 0x8068;
		public const uint TEXTURE_BINDING_2D = 0x8069;
		public const uint TEXTURE_INTERNAL_FORMAT = 0x1003;
		public const uint TEXTURE_RED_SIZE = 0x805C;
		public const uint TEXTURE_GREEN_SIZE = 0x805D;
		public const uint TEXTURE_BLUE_SIZE = 0x805E;
		public const uint TEXTURE_ALPHA_SIZE = 0x805F;
		public const uint DOUBLE = 0x140A;
		public const uint PROXY_TEXTURE_1D = 0x8063;
		public const uint PROXY_TEXTURE_2D = 0x8064;
		public const uint R3_G3_B2 = 0x2A10;
		public const uint RGB4 = 0x804F;
		public const uint RGB5 = 0x8050;
		public const uint RGB8 = 0x8051;
		public const uint RGB10 = 0x8052;
		public const uint RGB12 = 0x8053;
		public const uint RGB16 = 0x8054;
		public const uint RGBA2 = 0x8055;
		public const uint RGBA4 = 0x8056;
		public const uint RGB5_A1 = 0x8057;
		public const uint RGBA8 = 0x8058;
		public const uint RGB10_A2 = 0x8059;
		public const uint RGBA12 = 0x805A;
		public const uint RGBA16 = 0x805B;
		public const uint VERTEX_ARRAY = 0x8074;
		public const uint UNSIGNED_BYTE_3_3_2 = 0x8032;
		public const uint UNSIGNED_SHORT_4_4_4_4 = 0x8033;
		public const uint UNSIGNED_SHORT_5_5_5_1 = 0x8034;
		public const uint UNSIGNED_INT_8_8_8_8 = 0x8035;
		public const uint UNSIGNED_INT_10_10_10_2 = 0x8036;
		public const uint TEXTURE_BINDING_3D = 0x806A;
		public const uint PACK_SKIP_IMAGES = 0x806B;
		public const uint PACK_IMAGE_HEIGHT = 0x806C;
		public const uint UNPACK_SKIP_IMAGES = 0x806D;
		public const uint UNPACK_IMAGE_HEIGHT = 0x806E;
		public const uint TEXTURE_3D = 0x806F;
		public const uint PROXY_TEXTURE_3D = 0x8070;
		public const uint TEXTURE_DEPTH = 0x8071;
		public const uint TEXTURE_WRAP_R = 0x8072;
		public const uint MAX_3D_TEXTURE_SIZE = 0x8073;
		public const uint UNSIGNED_BYTE_2_3_3_REV = 0x8362;
		public const uint UNSIGNED_SHORT_5_6_5 = 0x8363;
		public const uint UNSIGNED_SHORT_5_6_5_REV = 0x8364;
		public const uint UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
		public const uint UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
		public const uint UNSIGNED_INT_8_8_8_8_REV = 0x8367;
		public const uint UNSIGNED_INT_2_10_10_10_REV = 0x8368;
		public const uint BGR = 0x80E0;
		public const uint BGRA = 0x80E1;
		public const uint MAX_ELEMENTS_VERTICES = 0x80E8;
		public const uint MAX_ELEMENTS_INDICES = 0x80E9;
		public const uint CLAMP_TO_EDGE = 0x812F;
		public const uint TEXTURE_MIN_LOD = 0x813A;
		public const uint TEXTURE_MAX_LOD = 0x813B;
		public const uint TEXTURE_BASE_LEVEL = 0x813C;
		public const uint TEXTURE_MAX_LEVEL = 0x813D;
		public const uint SMOOTH_POINT_SIZE_RANGE = 0x0B12;
		public const uint SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
		public const uint SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
		public const uint SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const uint ALIASED_LINE_WIDTH_RANGE = 0x846E;
		public const uint TEXTURE0 = 0x84C0;
		public const uint TEXTURE1 = 0x84C1;
		public const uint TEXTURE2 = 0x84C2;
		public const uint TEXTURE3 = 0x84C3;
		public const uint TEXTURE4 = 0x84C4;
		public const uint TEXTURE5 = 0x84C5;
		public const uint TEXTURE6 = 0x84C6;
		public const uint TEXTURE7 = 0x84C7;
		public const uint TEXTURE8 = 0x84C8;
		public const uint TEXTURE9 = 0x84C9;
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
		public const uint TEXTURE30 = 0x84DE;
		public const uint TEXTURE31 = 0x84DF;
		public const uint ACTIVE_TEXTURE = 0x84E0;
		public const uint MULTISAMPLE = 0x809D;
		public const uint SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		public const uint SAMPLE_ALPHA_TO_ONE = 0x809F;
		public const uint SAMPLE_COVERAGE = 0x80A0;
		public const uint SAMPLE_BUFFERS = 0x80A8;
		public const uint SAMPLES = 0x80A9;
		public const uint SAMPLE_COVERAGE_VALUE = 0x80AA;
		public const uint SAMPLE_COVERAGE_INVERT = 0x80AB;
		public const uint TEXTURE_CUBE_MAP = 0x8513;
		public const uint TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const uint TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		public const uint TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		public const uint TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		public const uint PROXY_TEXTURE_CUBE_MAP = 0x851B;
		public const uint MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		public const uint COMPRESSED_RGB = 0x84ED;
		public const uint COMPRESSED_RGBA = 0x84EE;
		public const uint TEXTURE_COMPRESSION_HINT = 0x84EF;
		public const uint TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
		public const uint TEXTURE_COMPRESSED = 0x86A1;
		public const uint NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
		public const uint COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		public const uint CLAMP_TO_BORDER = 0x812D;
		public const uint BLEND_DST_RGB = 0x80C8;
		public const uint BLEND_SRC_RGB = 0x80C9;
		public const uint BLEND_DST_ALPHA = 0x80CA;
		public const uint BLEND_SRC_ALPHA = 0x80CB;
		public const uint POINT_FADE_THRESHOLD_SIZE = 0x8128;
		public const uint DEPTH_COMPONENT16 = 0x81A5;
		public const uint DEPTH_COMPONENT24 = 0x81A6;
		public const uint DEPTH_COMPONENT32 = 0x81A7;
		public const uint MIRRORED_REPEAT = 0x8370;
		public const uint MAX_TEXTURE_LOD_BIAS = 0x84FD;
		public const uint TEXTURE_LOD_BIAS = 0x8501;
		public const uint INCR_WRAP = 0x8507;
		public const uint DECR_WRAP = 0x8508;
		public const uint TEXTURE_DEPTH_SIZE = 0x884A;
		public const uint TEXTURE_COMPARE_MODE = 0x884C;
		public const uint TEXTURE_COMPARE_FUNC = 0x884D;
		public const uint FUNC_ADD = 0x8006;
		public const uint FUNC_SUBTRACT = 0x800A;
		public const uint FUNC_REVERSE_SUBTRACT = 0x800B;
		public const uint MIN = 0x8007;
		public const uint MAX = 0x8008;
		public const uint CONSTANT_COLOR = 0x8001;
		public const uint ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const uint CONSTANT_ALPHA = 0x8003;
		public const uint ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		public const uint BUFFER_SIZE = 0x8764;
		public const uint BUFFER_USAGE = 0x8765;
		public const uint QUERY_COUNTER_BITS = 0x8864;
		public const uint CURRENT_QUERY = 0x8865;
		public const uint QUERY_RESULT = 0x8866;
		public const uint QUERY_RESULT_AVAILABLE = 0x8867;
		public const uint ARRAY_BUFFER = 0x8892;
		public const uint ELEMENT_ARRAY_BUFFER = 0x8893;
		public const uint ARRAY_BUFFER_BINDING = 0x8894;
		public const uint ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
		public const uint VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
		public const uint READ_ONLY = 0x88B8;
		public const uint WRITE_ONLY = 0x88B9;
		public const uint READ_WRITE = 0x88BA;
		public const uint BUFFER_ACCESS = 0x88BB;
		public const uint BUFFER_MAPPED = 0x88BC;
		public const uint BUFFER_MAP_POINTER = 0x88BD;
		public const uint STREAM_DRAW = 0x88E0;
		public const uint STREAM_READ = 0x88E1;
		public const uint STREAM_COPY = 0x88E2;
		public const uint STATIC_DRAW = 0x88E4;
		public const uint STATIC_READ = 0x88E5;
		public const uint STATIC_COPY = 0x88E6;
		public const uint DYNAMIC_DRAW = 0x88E8;
		public const uint DYNAMIC_READ = 0x88E9;
		public const uint DYNAMIC_COPY = 0x88EA;
		public const uint SAMPLES_PASSED = 0x8914;
		public const uint SRC1_ALPHA = 0x8589;
		public const uint BLEND_EQUATION_RGB = 0x8009;
		public const uint VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
		public const uint VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
		public const uint VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
		public const uint VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
		public const uint CURRENT_VERTEX_ATTRIB = 0x8626;
		public const uint VERTEX_PROGRAM_POINT_SIZE = 0x8642;
		public const uint VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
		public const uint STENCIL_BACK_FUNC = 0x8800;
		public const uint STENCIL_BACK_FAIL = 0x8801;
		public const uint STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
		public const uint STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
		public const uint MAX_DRAW_BUFFERS = 0x8824;
		public const uint DRAW_BUFFER0 = 0x8825;
		public const uint DRAW_BUFFER1 = 0x8826;
		public const uint DRAW_BUFFER2 = 0x8827;
		public const uint DRAW_BUFFER3 = 0x8828;
		public const uint DRAW_BUFFER4 = 0x8829;
		public const uint DRAW_BUFFER5 = 0x882A;
		public const uint DRAW_BUFFER6 = 0x882B;
		public const uint DRAW_BUFFER7 = 0x882C;
		public const uint DRAW_BUFFER8 = 0x882D;
		public const uint DRAW_BUFFER9 = 0x882E;
		public const uint DRAW_BUFFER10 = 0x882F;
		public const uint DRAW_BUFFER11 = 0x8830;
		public const uint DRAW_BUFFER12 = 0x8831;
		public const uint DRAW_BUFFER13 = 0x8832;
		public const uint DRAW_BUFFER14 = 0x8833;
		public const uint DRAW_BUFFER15 = 0x8834;
		public const uint BLEND_EQUATION_ALPHA = 0x883D;
		public const uint MAX_VERTEX_ATTRIBS = 0x8869;
		public const uint VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
		public const uint MAX_TEXTURE_IMAGE_UNITS = 0x8872;
		public const uint FRAGMENT_SHADER = 0x8B30;
		public const uint VERTEX_SHADER = 0x8B31;
		public const uint MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
		public const uint MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
		public const uint MAX_VARYING_FLOATS = 0x8B4B;
		public const uint MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
		public const uint MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
		public const uint SHADER_TYPE = 0x8B4F;
		public const uint FLOAT_VEC2 = 0x8B50;
		public const uint FLOAT_VEC3 = 0x8B51;
		public const uint FLOAT_VEC4 = 0x8B52;
		public const uint INT_VEC2 = 0x8B53;
		public const uint INT_VEC3 = 0x8B54;
		public const uint INT_VEC4 = 0x8B55;
		public const uint BOOL = 0x8B56;
		public const uint BOOL_VEC2 = 0x8B57;
		public const uint BOOL_VEC3 = 0x8B58;
		public const uint BOOL_VEC4 = 0x8B59;
		public const uint FLOAT_MAT2 = 0x8B5A;
		public const uint FLOAT_MAT3 = 0x8B5B;
		public const uint FLOAT_MAT4 = 0x8B5C;
		public const uint SAMPLER_1D = 0x8B5D;
		public const uint SAMPLER_2D = 0x8B5E;
		public const uint SAMPLER_3D = 0x8B5F;
		public const uint SAMPLER_CUBE = 0x8B60;
		public const uint SAMPLER_1D_SHADOW = 0x8B61;
		public const uint SAMPLER_2D_SHADOW = 0x8B62;
		public const uint DELETE_STATUS = 0x8B80;
		public const uint COMPILE_STATUS = 0x8B81;
		public const uint LINK_STATUS = 0x8B82;
		public const uint VALIDATE_STATUS = 0x8B83;
		public const uint INFO_LOG_LENGTH = 0x8B84;
		public const uint ATTACHED_SHADERS = 0x8B85;
		public const uint ACTIVE_UNIFORMS = 0x8B86;
		public const uint ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
		public const uint SHADER_SOURCE_LENGTH = 0x8B88;
		public const uint ACTIVE_ATTRIBUTES = 0x8B89;
		public const uint ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
		public const uint FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
		public const uint SHADING_LANGUAGE_VERSION = 0x8B8C;
		public const uint CURRENT_PROGRAM = 0x8B8D;
		public const uint POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
		public const uint LOWER_LEFT = 0x8CA1;
		public const uint UPPER_LEFT = 0x8CA2;
		public const uint STENCIL_BACK_REF = 0x8CA3;
		public const uint STENCIL_BACK_VALUE_MASK = 0x8CA4;
		public const uint STENCIL_BACK_WRITEMASK = 0x8CA5;
		public const uint PIXEL_PACK_BUFFER = 0x88EB;
		public const uint PIXEL_UNPACK_BUFFER = 0x88EC;
		public const uint PIXEL_PACK_BUFFER_BINDING = 0x88ED;
		public const uint PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
		public const uint FLOAT_MAT2x3 = 0x8B65;
		public const uint FLOAT_MAT2x4 = 0x8B66;
		public const uint FLOAT_MAT3x2 = 0x8B67;
		public const uint FLOAT_MAT3x4 = 0x8B68;
		public const uint FLOAT_MAT4x2 = 0x8B69;
		public const uint FLOAT_MAT4x3 = 0x8B6A;
		public const uint SRGB = 0x8C40;
		public const uint SRGB8 = 0x8C41;
		public const uint SRGB_ALPHA = 0x8C42;
		public const uint SRGB8_ALPHA8 = 0x8C43;
		public const uint COMPRESSED_SRGB = 0x8C48;
		public const uint COMPRESSED_SRGB_ALPHA = 0x8C49;
		public const uint COMPARE_REF_TO_TEXTURE = 0x884E;
		public const uint CLIP_DISTANCE0 = 0x3000;
		public const uint CLIP_DISTANCE1 = 0x3001;
		public const uint CLIP_DISTANCE2 = 0x3002;
		public const uint CLIP_DISTANCE3 = 0x3003;
		public const uint CLIP_DISTANCE4 = 0x3004;
		public const uint CLIP_DISTANCE5 = 0x3005;
		public const uint CLIP_DISTANCE6 = 0x3006;
		public const uint CLIP_DISTANCE7 = 0x3007;
		public const uint MAX_CLIP_DISTANCES = 0x0D32;
		public const uint MAJOR_VERSION = 0x821B;
		public const uint MINOR_VERSION = 0x821C;
		public const uint NUM_EXTENSIONS = 0x821D;
		public const uint CONTEXT_FLAGS = 0x821E;
		public const uint COMPRESSED_RED = 0x8225;
		public const uint COMPRESSED_RG = 0x8226;
		public const uint CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
		public const uint RGBA32F = 0x8814;
		public const uint RGB32F = 0x8815;
		public const uint RGBA16F = 0x881A;
		public const uint RGB16F = 0x881B;
		public const uint VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
		public const uint MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
		public const uint MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
		public const uint MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
		public const uint CLAMP_READ_COLOR = 0x891C;
		public const uint FIXED_ONLY = 0x891D;
		public const uint MAX_VARYING_COMPONENTS = 0x8B4B;
		public const uint TEXTURE_1D_ARRAY = 0x8C18;
		public const uint PROXY_TEXTURE_1D_ARRAY = 0x8C19;
		public const uint TEXTURE_2D_ARRAY = 0x8C1A;
		public const uint PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
		public const uint TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
		public const uint TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
		public const uint R11F_G11F_B10F = 0x8C3A;
		public const uint UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
		public const uint RGB9_E5 = 0x8C3D;
		public const uint UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
		public const uint TEXTURE_SHARED_SIZE = 0x8C3F;
		public const uint TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
		public const uint TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
		public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
		public const uint TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
		public const uint TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
		public const uint TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
		public const uint PRIMITIVES_GENERATED = 0x8C87;
		public const uint TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
		public const uint RASTERIZER_DISCARD = 0x8C89;
		public const uint MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
		public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
		public const uint INTERLEAVED_ATTRIBS = 0x8C8C;
		public const uint SEPARATE_ATTRIBS = 0x8C8D;
		public const uint TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
		public const uint TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
		public const uint RGBA32UI = 0x8D70;
		public const uint RGB32UI = 0x8D71;
		public const uint RGBA16UI = 0x8D76;
		public const uint RGB16UI = 0x8D77;
		public const uint RGBA8UI = 0x8D7C;
		public const uint RGB8UI = 0x8D7D;
		public const uint RGBA32I = 0x8D82;
		public const uint RGB32I = 0x8D83;
		public const uint RGBA16I = 0x8D88;
		public const uint RGB16I = 0x8D89;
		public const uint RGBA8I = 0x8D8E;
		public const uint RGB8I = 0x8D8F;
		public const uint RED_INTEGER = 0x8D94;
		public const uint GREEN_INTEGER = 0x8D95;
		public const uint BLUE_INTEGER = 0x8D96;
		public const uint RGB_INTEGER = 0x8D98;
		public const uint RGBA_INTEGER = 0x8D99;
		public const uint BGR_INTEGER = 0x8D9A;
		public const uint BGRA_INTEGER = 0x8D9B;
		public const uint SAMPLER_1D_ARRAY = 0x8DC0;
		public const uint SAMPLER_2D_ARRAY = 0x8DC1;
		public const uint SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
		public const uint SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
		public const uint SAMPLER_CUBE_SHADOW = 0x8DC5;
		public const uint UNSIGNED_INT_VEC2 = 0x8DC6;
		public const uint UNSIGNED_INT_VEC3 = 0x8DC7;
		public const uint UNSIGNED_INT_VEC4 = 0x8DC8;
		public const uint INT_SAMPLER_1D = 0x8DC9;
		public const uint INT_SAMPLER_2D = 0x8DCA;
		public const uint INT_SAMPLER_3D = 0x8DCB;
		public const uint INT_SAMPLER_CUBE = 0x8DCC;
		public const uint INT_SAMPLER_1D_ARRAY = 0x8DCE;
		public const uint INT_SAMPLER_2D_ARRAY = 0x8DCF;
		public const uint UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
		public const uint UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
		public const uint UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
		public const uint UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
		public const uint UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
		public const uint UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
		public const uint QUERY_WAIT = 0x8E13;
		public const uint QUERY_NO_WAIT = 0x8E14;
		public const uint QUERY_BY_REGION_WAIT = 0x8E15;
		public const uint QUERY_BY_REGION_NO_WAIT = 0x8E16;
		public const uint BUFFER_ACCESS_FLAGS = 0x911F;
		public const uint BUFFER_MAP_LENGTH = 0x9120;
		public const uint BUFFER_MAP_OFFSET = 0x9121;
		public const uint DEPTH_COMPONENT32F = 0x8CAC;
		public const uint DEPTH32F_STENCIL8 = 0x8CAD;
		public const uint FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
		public const uint INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		public const uint FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
		public const uint FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
		public const uint FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
		public const uint FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
		public const uint FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
		public const uint FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
		public const uint FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
		public const uint FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
		public const uint FRAMEBUFFER_DEFAULT = 0x8218;
		public const uint FRAMEBUFFER_UNDEFINED = 0x8219;
		public const uint DEPTH_STENCIL_ATTACHMENT = 0x821A;
		public const uint MAX_RENDERBUFFER_SIZE = 0x84E8;
		public const uint DEPTH_STENCIL = 0x84F9;
		public const uint UNSIGNED_INT_24_8 = 0x84FA;
		public const uint DEPTH24_STENCIL8 = 0x88F0;
		public const uint TEXTURE_STENCIL_SIZE = 0x88F1;
		public const uint TEXTURE_RED_TYPE = 0x8C10;
		public const uint TEXTURE_GREEN_TYPE = 0x8C11;
		public const uint TEXTURE_BLUE_TYPE = 0x8C12;
		public const uint TEXTURE_ALPHA_TYPE = 0x8C13;
		public const uint TEXTURE_DEPTH_TYPE = 0x8C16;
		public const uint UNSIGNED_NORMALIZED = 0x8C17;
		public const uint FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
		public const uint RENDERBUFFER_BINDING = 0x8CA7;
		public const uint READ_FRAMEBUFFER = 0x8CA8;
		public const uint DRAW_FRAMEBUFFER = 0x8CA9;
		public const uint READ_FRAMEBUFFER_BINDING = 0x8CAA;
		public const uint RENDERBUFFER_SAMPLES = 0x8CAB;
		public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
		public const uint FRAMEBUFFER_COMPLETE = 0x8CD5;
		public const uint FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		public const uint FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		public const uint FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
		public const uint FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
		public const uint FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		public const uint MAX_COLOR_ATTACHMENTS = 0x8CDF;
		public const uint COLOR_ATTACHMENT0 = 0x8CE0;
		public const uint COLOR_ATTACHMENT1 = 0x8CE1;
		public const uint COLOR_ATTACHMENT2 = 0x8CE2;
		public const uint COLOR_ATTACHMENT3 = 0x8CE3;
		public const uint COLOR_ATTACHMENT4 = 0x8CE4;
		public const uint COLOR_ATTACHMENT5 = 0x8CE5;
		public const uint COLOR_ATTACHMENT6 = 0x8CE6;
		public const uint COLOR_ATTACHMENT7 = 0x8CE7;
		public const uint COLOR_ATTACHMENT8 = 0x8CE8;
		public const uint COLOR_ATTACHMENT9 = 0x8CE9;
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
		public const uint COLOR_ATTACHMENT30 = 0x8CFE;
		public const uint COLOR_ATTACHMENT31 = 0x8CFF;
		public const uint DEPTH_ATTACHMENT = 0x8D00;
		public const uint STENCIL_ATTACHMENT = 0x8D20;
		public const uint FRAMEBUFFER = 0x8D40;
		public const uint RENDERBUFFER = 0x8D41;
		public const uint RENDERBUFFER_WIDTH = 0x8D42;
		public const uint RENDERBUFFER_HEIGHT = 0x8D43;
		public const uint RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		public const uint STENCIL_INDEX1 = 0x8D46;
		public const uint STENCIL_INDEX4 = 0x8D47;
		public const uint STENCIL_INDEX8 = 0x8D48;
		public const uint STENCIL_INDEX16 = 0x8D49;
		public const uint RENDERBUFFER_RED_SIZE = 0x8D50;
		public const uint RENDERBUFFER_GREEN_SIZE = 0x8D51;
		public const uint RENDERBUFFER_BLUE_SIZE = 0x8D52;
		public const uint RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		public const uint RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		public const uint RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		public const uint FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
		public const uint MAX_SAMPLES = 0x8D57;
		public const uint FRAMEBUFFER_SRGB = 0x8DB9;
		public const uint HALF_FLOAT = 0x140B;
		public const uint MAP_READ_BIT = 0x0001;
		public const uint MAP_WRITE_BIT = 0x0002;
		public const uint MAP_INVALIDATE_RANGE_BIT = 0x0004;
		public const uint MAP_INVALIDATE_BUFFER_BIT = 0x0008;
		public const uint MAP_FLUSH_EXPLICIT_BIT = 0x0010;
		public const uint MAP_UNSYNCHRONIZED_BIT = 0x0020;
		public const uint COMPRESSED_RED_RGTC1 = 0x8DBB;
		public const uint COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
		public const uint COMPRESSED_RG_RGTC2 = 0x8DBD;
		public const uint COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
		public const uint RG = 0x8227;
		public const uint RG_INTEGER = 0x8228;
		public const uint R8 = 0x8229;
		public const uint R16 = 0x822A;
		public const uint RG8 = 0x822B;
		public const uint RG16 = 0x822C;
		public const uint R16F = 0x822D;
		public const uint R32F = 0x822E;
		public const uint RG16F = 0x822F;
		public const uint RG32F = 0x8230;
		public const uint R8I = 0x8231;
		public const uint R8UI = 0x8232;
		public const uint R16I = 0x8233;
		public const uint R16UI = 0x8234;
		public const uint R32I = 0x8235;
		public const uint R32UI = 0x8236;
		public const uint RG8I = 0x8237;
		public const uint RG8UI = 0x8238;
		public const uint RG16I = 0x8239;
		public const uint RG16UI = 0x823A;
		public const uint RG32I = 0x823B;
		public const uint RG32UI = 0x823C;
		public const uint VERTEX_ARRAY_BINDING = 0x85B5;
		public const uint SAMPLER_2D_RECT = 0x8B63;
		public const uint SAMPLER_2D_RECT_SHADOW = 0x8B64;
		public const uint SAMPLER_BUFFER = 0x8DC2;
		public const uint INT_SAMPLER_2D_RECT = 0x8DCD;
		public const uint INT_SAMPLER_BUFFER = 0x8DD0;
		public const uint UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
		public const uint UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
		public const uint TEXTURE_BUFFER = 0x8C2A;
		public const uint MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
		public const uint TEXTURE_BINDING_BUFFER = 0x8C2C;
		public const uint TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
		public const uint TEXTURE_RECTANGLE = 0x84F5;
		public const uint TEXTURE_BINDING_RECTANGLE = 0x84F6;
		public const uint PROXY_TEXTURE_RECTANGLE = 0x84F7;
		public const uint MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
		public const uint R8_SNORM = 0x8F94;
		public const uint RG8_SNORM = 0x8F95;
		public const uint RGB8_SNORM = 0x8F96;
		public const uint RGBA8_SNORM = 0x8F97;
		public const uint R16_SNORM = 0x8F98;
		public const uint RG16_SNORM = 0x8F99;
		public const uint RGB16_SNORM = 0x8F9A;
		public const uint RGBA16_SNORM = 0x8F9B;
		public const uint SIGNED_NORMALIZED = 0x8F9C;
		public const uint PRIMITIVE_RESTART = 0x8F9D;
		public const uint PRIMITIVE_RESTART_INDEX = 0x8F9E;
		public const uint COPY_READ_BUFFER = 0x8F36;
		public const uint COPY_WRITE_BUFFER = 0x8F37;
		public const uint UNIFORM_BUFFER = 0x8A11;
		public const uint UNIFORM_BUFFER_BINDING = 0x8A28;
		public const uint UNIFORM_BUFFER_START = 0x8A29;
		public const uint UNIFORM_BUFFER_SIZE = 0x8A2A;
		public const uint MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
		public const uint MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
		public const uint MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
		public const uint MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
		public const uint MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
		public const uint MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
		public const uint MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
		public const uint MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
		public const uint MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
		public const uint UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
		public const uint ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
		public const uint ACTIVE_UNIFORM_BLOCKS = 0x8A36;
		public const uint UNIFORM_TYPE = 0x8A37;
		public const uint UNIFORM_SIZE = 0x8A38;
		public const uint UNIFORM_NAME_LENGTH = 0x8A39;
		public const uint UNIFORM_BLOCK_INDEX = 0x8A3A;
		public const uint UNIFORM_OFFSET = 0x8A3B;
		public const uint UNIFORM_ARRAY_STRIDE = 0x8A3C;
		public const uint UNIFORM_MATRIX_STRIDE = 0x8A3D;
		public const uint UNIFORM_IS_ROW_MAJOR = 0x8A3E;
		public const uint UNIFORM_BLOCK_BINDING = 0x8A3F;
		public const uint UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
		public const uint UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
		public const uint UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
		public const uint UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
		public const uint INVALID_INDEX = 0xFFFFFFFFu;
		public const uint CONTEXT_CORE_PROFILE_BIT = 0x00000001;
		public const uint CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
		public const uint LINES_ADJACENCY = 0x000A;
		public const uint LINE_STRIP_ADJACENCY = 0x000B;
		public const uint TRIANGLES_ADJACENCY = 0x000C;
		public const uint TRIANGLE_STRIP_ADJACENCY = 0x000D;
		public const uint PROGRAM_POINT_SIZE = 0x8642;
		public const uint MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
		public const uint FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
		public const uint FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
		public const uint GEOMETRY_SHADER = 0x8DD9;
		public const uint GEOMETRY_VERTICES_OUT = 0x8916;
		public const uint GEOMETRY_INPUT_TYPE = 0x8917;
		public const uint GEOMETRY_OUTPUT_TYPE = 0x8918;
		public const uint MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
		public const uint MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
		public const uint MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
		public const uint MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
		public const uint MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
		public const uint MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
		public const uint MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
		public const uint CONTEXT_PROFILE_MASK = 0x9126;
		public const uint DEPTH_CLAMP = 0x864F;
		public const uint QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
		public const uint FIRST_VERTEX_CONVENTION = 0x8E4D;
		public const uint LAST_VERTEX_CONVENTION = 0x8E4E;
		public const uint PROVOKING_VERTEX = 0x8E4F;
		public const uint TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
		public const uint MAX_SERVER_WAIT_TIMEOUT = 0x9111;
		public const uint OBJECT_TYPE = 0x9112;
		public const uint SYNC_CONDITION = 0x9113;
		public const uint SYNC_STATUS = 0x9114;
		public const uint SYNC_FLAGS = 0x9115;
		public const uint SYNC_FENCE = 0x9116;
		public const uint SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
		public const uint UNSIGNALED = 0x9118;
		public const uint SIGNALED = 0x9119;
		public const uint ALREADY_SIGNALED = 0x911A;
		public const uint TIMEOUT_EXPIRED = 0x911B;
		public const uint CONDITION_SATISFIED = 0x911C;
		public const uint WAIT_FAILED = 0x911D;
		public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
		public const uint SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
		public const uint SAMPLE_POSITION = 0x8E50;
		public const uint SAMPLE_MASK = 0x8E51;
		public const uint SAMPLE_MASK_VALUE = 0x8E52;
		public const uint MAX_SAMPLE_MASK_WORDS = 0x8E59;
		public const uint TEXTURE_2D_MULTISAMPLE = 0x9100;
		public const uint PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
		public const uint TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
		public const uint PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
		public const uint TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
		public const uint TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
		public const uint TEXTURE_SAMPLES = 0x9106;
		public const uint TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
		public const uint SAMPLER_2D_MULTISAMPLE = 0x9108;
		public const uint INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
		public const uint UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
		public const uint SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
		public const uint INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
		public const uint UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
		public const uint MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
		public const uint MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
		public const uint MAX_INTEGER_SAMPLES = 0x9110;
		public const uint VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
		public const uint SRC1_COLOR = 0x88F9;
		public const uint ONE_MINUS_SRC1_COLOR = 0x88FA;
		public const uint ONE_MINUS_SRC1_ALPHA = 0x88FB;
		public const uint MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
		public const uint ANY_SAMPLES_PASSED = 0x8C2F;
		public const uint SAMPLER_BINDING = 0x8919;
		public const uint RGB10_A2UI = 0x906F;
		public const uint TEXTURE_SWIZZLE_R = 0x8E42;
		public const uint TEXTURE_SWIZZLE_G = 0x8E43;
		public const uint TEXTURE_SWIZZLE_B = 0x8E44;
		public const uint TEXTURE_SWIZZLE_A = 0x8E45;
		public const uint TEXTURE_SWIZZLE_RGBA = 0x8E46;
		public const uint TIME_ELAPSED = 0x88BF;
		public const uint TIMESTAMP = 0x8E28;
		public const uint INT_2_10_10_10_REV = 0x8D9F;
		public const uint SAMPLE_SHADING = 0x8C36;
		public const uint MIN_SAMPLE_SHADING_VALUE = 0x8C37;
		public const uint MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
		public const uint MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
		public const uint TEXTURE_CUBE_MAP_ARRAY = 0x9009;
		public const uint TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
		public const uint PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
		public const uint SAMPLER_CUBE_MAP_ARRAY = 0x900C;
		public const uint SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
		public const uint INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
		public const uint UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
		public const uint DRAW_INDIRECT_BUFFER = 0x8F3F;
		public const uint DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
		public const uint GEOMETRY_SHADER_INVOCATIONS = 0x887F;
		public const uint MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
		public const uint MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
		public const uint MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
		public const uint FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
		public const uint MAX_VERTEX_STREAMS = 0x8E71;
		public const uint DOUBLE_VEC2 = 0x8FFC;
		public const uint DOUBLE_VEC3 = 0x8FFD;
		public const uint DOUBLE_VEC4 = 0x8FFE;
		public const uint DOUBLE_MAT2 = 0x8F46;
		public const uint DOUBLE_MAT3 = 0x8F47;
		public const uint DOUBLE_MAT4 = 0x8F48;
		public const uint DOUBLE_MAT2x3 = 0x8F49;
		public const uint DOUBLE_MAT2x4 = 0x8F4A;
		public const uint DOUBLE_MAT3x2 = 0x8F4B;
		public const uint DOUBLE_MAT3x4 = 0x8F4C;
		public const uint DOUBLE_MAT4x2 = 0x8F4D;
		public const uint DOUBLE_MAT4x3 = 0x8F4E;
		public const uint ACTIVE_SUBROUTINES = 0x8DE5;
		public const uint ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
		public const uint ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
		public const uint ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
		public const uint ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
		public const uint MAX_SUBROUTINES = 0x8DE7;
		public const uint MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
		public const uint NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
		public const uint COMPATIBLE_SUBROUTINES = 0x8E4B;
		public const uint PATCHES = 0x000E;
		public const uint PATCH_VERTICES = 0x8E72;
		public const uint PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
		public const uint PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
		public const uint TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
		public const uint TESS_GEN_MODE = 0x8E76;
		public const uint TESS_GEN_SPACING = 0x8E77;
		public const uint TESS_GEN_VERTEX_ORDER = 0x8E78;
		public const uint TESS_GEN_POINT_MODE = 0x8E79;
		public const uint ISOLINES = 0x8E7A;
		public const uint FRACTIONAL_ODD = 0x8E7B;
		public const uint FRACTIONAL_EVEN = 0x8E7C;
		public const uint MAX_PATCH_VERTICES = 0x8E7D;
		public const uint MAX_TESS_GEN_LEVEL = 0x8E7E;
		public const uint MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
		public const uint MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
		public const uint MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
		public const uint MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
		public const uint MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
		public const uint MAX_TESS_PATCH_COMPONENTS = 0x8E84;
		public const uint MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
		public const uint MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
		public const uint MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
		public const uint MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
		public const uint MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
		public const uint MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
		public const uint MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
		public const uint MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
		public const uint TESS_EVALUATION_SHADER = 0x8E87;
		public const uint TESS_CONTROL_SHADER = 0x8E88;
		public const uint TRANSFORM_FEEDBACK = 0x8E22;
		public const uint TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
		public const uint TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
		public const uint TRANSFORM_FEEDBACK_BINDING = 0x8E25;
		public const uint MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
		public const uint FIXED = 0x140C;
		public const uint IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
		public const uint IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
		public const uint LOW_FLOAT = 0x8DF0;
		public const uint MEDIUM_FLOAT = 0x8DF1;
		public const uint HIGH_FLOAT = 0x8DF2;
		public const uint LOW_INT = 0x8DF3;
		public const uint MEDIUM_INT = 0x8DF4;
		public const uint HIGH_INT = 0x8DF5;
		public const uint SHADER_COMPILER = 0x8DFA;
		public const uint SHADER_BINARY_FORMATS = 0x8DF8;
		public const uint NUM_SHADER_BINARY_FORMATS = 0x8DF9;
		public const uint MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		public const uint MAX_VARYING_VECTORS = 0x8DFC;
		public const uint MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
		public const uint RGB565 = 0x8D62;
		public const uint PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
		public const uint PROGRAM_BINARY_LENGTH = 0x8741;
		public const uint NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
		public const uint PROGRAM_BINARY_FORMATS = 0x87FF;
		public const uint VERTEX_SHADER_BIT = 0x00000001;
		public const uint FRAGMENT_SHADER_BIT = 0x00000002;
		public const uint GEOMETRY_SHADER_BIT = 0x00000004;
		public const uint TESS_CONTROL_SHADER_BIT = 0x00000008;
		public const uint TESS_EVALUATION_SHADER_BIT = 0x00000010;
		public const uint ALL_SHADER_BITS = 0xFFFFFFFF;
		public const uint PROGRAM_SEPARABLE = 0x8258;
		public const uint ACTIVE_PROGRAM = 0x8259;
		public const uint PROGRAM_PIPELINE_BINDING = 0x825A;
		public const uint MAX_VIEWPORTS = 0x825B;
		public const uint VIEWPORT_SUBPIXEL_BITS = 0x825C;
		public const uint VIEWPORT_BOUNDS_RANGE = 0x825D;
		public const uint LAYER_PROVOKING_VERTEX = 0x825E;
		public const uint VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
		public const uint UNDEFINED_VERTEX = 0x8260;
		public const uint COPY_READ_BUFFER_BINDING = 0x8F36;
		public const uint COPY_WRITE_BUFFER_BINDING = 0x8F37;
		public const uint TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
		public const uint TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
		public const uint UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
		public const uint UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
		public const uint UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
		public const uint UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
		public const uint PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
		public const uint PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
		public const uint PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
		public const uint PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
		public const uint NUM_SAMPLE_COUNTS = 0x9380;
		public const uint MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
		public const uint ATOMIC_COUNTER_BUFFER = 0x92C0;
		public const uint ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
		public const uint ATOMIC_COUNTER_BUFFER_START = 0x92C2;
		public const uint ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
		public const uint ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
		public const uint ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
		public const uint ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
		public const uint MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
		public const uint MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
		public const uint MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
		public const uint MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
		public const uint MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
		public const uint MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
		public const uint MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
		public const uint MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
		public const uint MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
		public const uint MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
		public const uint MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
		public const uint MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
		public const uint MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
		public const uint MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
		public const uint ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
		public const uint UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
		public const uint UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
		public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
		public const uint ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
		public const uint UNIFORM_BARRIER_BIT = 0x00000004;
		public const uint TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
		public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
		public const uint COMMAND_BARRIER_BIT = 0x00000040;
		public const uint PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
		public const uint TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
		public const uint BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
		public const uint FRAMEBUFFER_BARRIER_BIT = 0x00000400;
		public const uint TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
		public const uint ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
		public const uint ALL_BARRIER_BITS = 0xFFFFFFFF;
		public const uint MAX_IMAGE_UNITS = 0x8F38;
		public const uint MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
		public const uint IMAGE_BINDING_NAME = 0x8F3A;
		public const uint IMAGE_BINDING_LEVEL = 0x8F3B;
		public const uint IMAGE_BINDING_LAYERED = 0x8F3C;
		public const uint IMAGE_BINDING_LAYER = 0x8F3D;
		public const uint IMAGE_BINDING_ACCESS = 0x8F3E;
		public const uint IMAGE_1D = 0x904C;
		public const uint IMAGE_2D = 0x904D;
		public const uint IMAGE_3D = 0x904E;
		public const uint IMAGE_2D_RECT = 0x904F;
		public const uint IMAGE_CUBE = 0x9050;
		public const uint IMAGE_BUFFER = 0x9051;
		public const uint IMAGE_1D_ARRAY = 0x9052;
		public const uint IMAGE_2D_ARRAY = 0x9053;
		public const uint IMAGE_CUBE_MAP_ARRAY = 0x9054;
		public const uint IMAGE_2D_MULTISAMPLE = 0x9055;
		public const uint IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
		public const uint INT_IMAGE_1D = 0x9057;
		public const uint INT_IMAGE_2D = 0x9058;
		public const uint INT_IMAGE_3D = 0x9059;
		public const uint INT_IMAGE_2D_RECT = 0x905A;
		public const uint INT_IMAGE_CUBE = 0x905B;
		public const uint INT_IMAGE_BUFFER = 0x905C;
		public const uint INT_IMAGE_1D_ARRAY = 0x905D;
		public const uint INT_IMAGE_2D_ARRAY = 0x905E;
		public const uint INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
		public const uint INT_IMAGE_2D_MULTISAMPLE = 0x9060;
		public const uint INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
		public const uint UNSIGNED_INT_IMAGE_1D = 0x9062;
		public const uint UNSIGNED_INT_IMAGE_2D = 0x9063;
		public const uint UNSIGNED_INT_IMAGE_3D = 0x9064;
		public const uint UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
		public const uint UNSIGNED_INT_IMAGE_CUBE = 0x9066;
		public const uint UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
		public const uint UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
		public const uint UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
		public const uint UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
		public const uint UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
		public const uint UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
		public const uint MAX_IMAGE_SAMPLES = 0x906D;
		public const uint IMAGE_BINDING_FORMAT = 0x906E;
		public const uint IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
		public const uint IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
		public const uint IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
		public const uint MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
		public const uint MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
		public const uint MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
		public const uint MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
		public const uint MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
		public const uint MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
		public const uint COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;
		public const uint COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;
		public const uint COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;
		public const uint COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;
		public const uint TEXTURE_IMMUTABLE_FORMAT = 0x912F;
		public const uint NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
		public const uint VERTEX_ATTRIB_ARRAY_LONG = 0x874E;
		public const uint COMPRESSED_RGB8_ETC2 = 0x9274;
		public const uint COMPRESSED_SRGB8_ETC2 = 0x9275;
		public const uint COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
		public const uint COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
		public const uint COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
		public const uint COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
		public const uint COMPRESSED_R11_EAC = 0x9270;
		public const uint COMPRESSED_SIGNED_R11_EAC = 0x9271;
		public const uint COMPRESSED_RG11_EAC = 0x9272;
		public const uint COMPRESSED_SIGNED_RG11_EAC = 0x9273;
		public const uint PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
		public const uint ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
		public const uint MAX_ELEMENT_INDEX = 0x8D6B;
		public const uint COMPUTE_SHADER = 0x91B9;
		public const uint MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
		public const uint MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
		public const uint MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
		public const uint MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
		public const uint MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
		public const uint MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
		public const uint MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
		public const uint MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
		public const uint MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
		public const uint MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
		public const uint MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
		public const uint COMPUTE_WORK_GROUP_SIZE = 0x8267;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
		public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
		public const uint DISPATCH_INDIRECT_BUFFER = 0x90EE;
		public const uint DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
		public const uint COMPUTE_SHADER_BIT = 0x00000020;
		public const uint DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
		public const uint DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
		public const uint DEBUG_CALLBACK_FUNCTION = 0x8244;
		public const uint DEBUG_CALLBACK_USER_PARAM = 0x8245;
		public const uint DEBUG_SOURCE_API = 0x8246;
		public const uint DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
		public const uint DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
		public const uint DEBUG_SOURCE_THIRD_PARTY = 0x8249;
		public const uint DEBUG_SOURCE_APPLICATION = 0x824A;
		public const uint DEBUG_SOURCE_OTHER = 0x824B;
		public const uint DEBUG_TYPE_ERROR = 0x824C;
		public const uint DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
		public const uint DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
		public const uint DEBUG_TYPE_PORTABILITY = 0x824F;
		public const uint DEBUG_TYPE_PERFORMANCE = 0x8250;
		public const uint DEBUG_TYPE_OTHER = 0x8251;
		public const uint MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
		public const uint MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
		public const uint DEBUG_LOGGED_MESSAGES = 0x9145;
		public const uint DEBUG_SEVERITY_HIGH = 0x9146;
		public const uint DEBUG_SEVERITY_MEDIUM = 0x9147;
		public const uint DEBUG_SEVERITY_LOW = 0x9148;
		public const uint DEBUG_TYPE_MARKER = 0x8268;
		public const uint DEBUG_TYPE_PUSH_GROUP = 0x8269;
		public const uint DEBUG_TYPE_POP_GROUP = 0x826A;
		public const uint DEBUG_SEVERITY_NOTIFICATION = 0x826B;
		public const uint MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
		public const uint DEBUG_GROUP_STACK_DEPTH = 0x826D;
		public const uint BUFFER = 0x82E0;
		public const uint SHADER = 0x82E1;
		public const uint PROGRAM = 0x82E2;
		public const uint QUERY = 0x82E3;
		public const uint PROGRAM_PIPELINE = 0x82E4;
		public const uint SAMPLER = 0x82E6;
		public const uint MAX_LABEL_LENGTH = 0x82E8;
		public const uint DEBUG_OUTPUT = 0x92E0;
		public const uint CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
		public const uint MAX_UNIFORM_LOCATIONS = 0x826E;
		public const uint FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
		public const uint FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
		public const uint FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
		public const uint FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
		public const uint FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
		public const uint MAX_FRAMEBUFFER_WIDTH = 0x9315;
		public const uint MAX_FRAMEBUFFER_HEIGHT = 0x9316;
		public const uint MAX_FRAMEBUFFER_LAYERS = 0x9317;
		public const uint MAX_FRAMEBUFFER_SAMPLES = 0x9318;
		public const uint INTERNALFORMAT_SUPPORTED = 0x826F;
		public const uint INTERNALFORMAT_PREFERRED = 0x8270;
		public const uint INTERNALFORMAT_RED_SIZE = 0x8271;
		public const uint INTERNALFORMAT_GREEN_SIZE = 0x8272;
		public const uint INTERNALFORMAT_BLUE_SIZE = 0x8273;
		public const uint INTERNALFORMAT_ALPHA_SIZE = 0x8274;
		public const uint INTERNALFORMAT_DEPTH_SIZE = 0x8275;
		public const uint INTERNALFORMAT_STENCIL_SIZE = 0x8276;
		public const uint INTERNALFORMAT_SHARED_SIZE = 0x8277;
		public const uint INTERNALFORMAT_RED_TYPE = 0x8278;
		public const uint INTERNALFORMAT_GREEN_TYPE = 0x8279;
		public const uint INTERNALFORMAT_BLUE_TYPE = 0x827A;
		public const uint INTERNALFORMAT_ALPHA_TYPE = 0x827B;
		public const uint INTERNALFORMAT_DEPTH_TYPE = 0x827C;
		public const uint INTERNALFORMAT_STENCIL_TYPE = 0x827D;
		public const uint MAX_WIDTH = 0x827E;
		public const uint MAX_HEIGHT = 0x827F;
		public const uint MAX_DEPTH = 0x8280;
		public const uint MAX_LAYERS = 0x8281;
		public const uint MAX_COMBINED_DIMENSIONS = 0x8282;
		public const uint COLOR_COMPONENTS = 0x8283;
		public const uint DEPTH_COMPONENTS = 0x8284;
		public const uint STENCIL_COMPONENTS = 0x8285;
		public const uint COLOR_RENDERABLE = 0x8286;
		public const uint DEPTH_RENDERABLE = 0x8287;
		public const uint STENCIL_RENDERABLE = 0x8288;
		public const uint FRAMEBUFFER_RENDERABLE = 0x8289;
		public const uint FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
		public const uint FRAMEBUFFER_BLEND = 0x828B;
		public const uint READ_PIXELS = 0x828C;
		public const uint READ_PIXELS_FORMAT = 0x828D;
		public const uint READ_PIXELS_TYPE = 0x828E;
		public const uint TEXTURE_IMAGE_FORMAT = 0x828F;
		public const uint TEXTURE_IMAGE_TYPE = 0x8290;
		public const uint GET_TEXTURE_IMAGE_FORMAT = 0x8291;
		public const uint GET_TEXTURE_IMAGE_TYPE = 0x8292;
		public const uint MIPMAP = 0x8293;
		public const uint MANUAL_GENERATE_MIPMAP = 0x8294;
		public const uint AUTO_GENERATE_MIPMAP = 0x8295;
		public const uint COLOR_ENCODING = 0x8296;
		public const uint SRGB_READ = 0x8297;
		public const uint SRGB_WRITE = 0x8298;
		public const uint FILTER = 0x829A;
		public const uint VERTEX_TEXTURE = 0x829B;
		public const uint TESS_CONTROL_TEXTURE = 0x829C;
		public const uint TESS_EVALUATION_TEXTURE = 0x829D;
		public const uint GEOMETRY_TEXTURE = 0x829E;
		public const uint FRAGMENT_TEXTURE = 0x829F;
		public const uint COMPUTE_TEXTURE = 0x82A0;
		public const uint TEXTURE_SHADOW = 0x82A1;
		public const uint TEXTURE_GATHER = 0x82A2;
		public const uint TEXTURE_GATHER_SHADOW = 0x82A3;
		public const uint SHADER_IMAGE_LOAD = 0x82A4;
		public const uint SHADER_IMAGE_STORE = 0x82A5;
		public const uint SHADER_IMAGE_ATOMIC = 0x82A6;
		public const uint IMAGE_TEXEL_SIZE = 0x82A7;
		public const uint IMAGE_COMPATIBILITY_CLASS = 0x82A8;
		public const uint IMAGE_PIXEL_FORMAT = 0x82A9;
		public const uint IMAGE_PIXEL_TYPE = 0x82AA;
		public const uint SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
		public const uint SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
		public const uint SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
		public const uint SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
		public const uint TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
		public const uint TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
		public const uint TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
		public const uint CLEAR_BUFFER = 0x82B4;
		public const uint TEXTURE_VIEW = 0x82B5;
		public const uint VIEW_COMPATIBILITY_CLASS = 0x82B6;
		public const uint FULL_SUPPORT = 0x82B7;
		public const uint CAVEAT_SUPPORT = 0x82B8;
		public const uint IMAGE_CLASS_4_X_32 = 0x82B9;
		public const uint IMAGE_CLASS_2_X_32 = 0x82BA;
		public const uint IMAGE_CLASS_1_X_32 = 0x82BB;
		public const uint IMAGE_CLASS_4_X_16 = 0x82BC;
		public const uint IMAGE_CLASS_2_X_16 = 0x82BD;
		public const uint IMAGE_CLASS_1_X_16 = 0x82BE;
		public const uint IMAGE_CLASS_4_X_8 = 0x82BF;
		public const uint IMAGE_CLASS_2_X_8 = 0x82C0;
		public const uint IMAGE_CLASS_1_X_8 = 0x82C1;
		public const uint IMAGE_CLASS_11_11_10 = 0x82C2;
		public const uint IMAGE_CLASS_10_10_10_2 = 0x82C3;
		public const uint VIEW_CLASS_128_BITS = 0x82C4;
		public const uint VIEW_CLASS_96_BITS = 0x82C5;
		public const uint VIEW_CLASS_64_BITS = 0x82C6;
		public const uint VIEW_CLASS_48_BITS = 0x82C7;
		public const uint VIEW_CLASS_32_BITS = 0x82C8;
		public const uint VIEW_CLASS_24_BITS = 0x82C9;
		public const uint VIEW_CLASS_16_BITS = 0x82CA;
		public const uint VIEW_CLASS_8_BITS = 0x82CB;
		public const uint VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
		public const uint VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
		public const uint VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
		public const uint VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
		public const uint VIEW_CLASS_RGTC1_RED = 0x82D0;
		public const uint VIEW_CLASS_RGTC2_RG = 0x82D1;
		public const uint VIEW_CLASS_BPTC_UNORM = 0x82D2;
		public const uint VIEW_CLASS_BPTC_FLOAT = 0x82D3;
		public const uint UNIFORM = 0x92E1;
		public const uint UNIFORM_BLOCK = 0x92E2;
		public const uint PROGRAM_INPUT = 0x92E3;
		public const uint PROGRAM_OUTPUT = 0x92E4;
		public const uint BUFFER_VARIABLE = 0x92E5;
		public const uint SHADER_STORAGE_BLOCK = 0x92E6;
		public const uint VERTEX_SUBROUTINE = 0x92E8;
		public const uint TESS_CONTROL_SUBROUTINE = 0x92E9;
		public const uint TESS_EVALUATION_SUBROUTINE = 0x92EA;
		public const uint GEOMETRY_SUBROUTINE = 0x92EB;
		public const uint FRAGMENT_SUBROUTINE = 0x92EC;
		public const uint COMPUTE_SUBROUTINE = 0x92ED;
		public const uint VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
		public const uint TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
		public const uint TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
		public const uint GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
		public const uint FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
		public const uint COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
		public const uint TRANSFORM_FEEDBACK_VARYING = 0x92F4;
		public const uint ACTIVE_RESOURCES = 0x92F5;
		public const uint MAX_NAME_LENGTH = 0x92F6;
		public const uint MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
		public const uint MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
		public const uint NAME_LENGTH = 0x92F9;
		public const uint TYPE = 0x92FA;
		public const uint ARRAY_SIZE = 0x92FB;
		public const uint OFFSET = 0x92FC;
		public const uint BLOCK_INDEX = 0x92FD;
		public const uint ARRAY_STRIDE = 0x92FE;
		public const uint MATRIX_STRIDE = 0x92FF;
		public const uint IS_ROW_MAJOR = 0x9300;
		public const uint ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
		public const uint BUFFER_BINDING = 0x9302;
		public const uint BUFFER_DATA_SIZE = 0x9303;
		public const uint NUM_ACTIVE_VARIABLES = 0x9304;
		public const uint ACTIVE_VARIABLES = 0x9305;
		public const uint REFERENCED_BY_VERTEX_SHADER = 0x9306;
		public const uint REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
		public const uint REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
		public const uint REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
		public const uint REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
		public const uint REFERENCED_BY_COMPUTE_SHADER = 0x930B;
		public const uint TOP_LEVEL_ARRAY_SIZE = 0x930C;
		public const uint TOP_LEVEL_ARRAY_STRIDE = 0x930D;
		public const uint LOCATION = 0x930E;
		public const uint LOCATION_INDEX = 0x930F;
		public const uint IS_PER_PATCH = 0x92E7;
		public const uint SHADER_STORAGE_BUFFER = 0x90D2;
		public const uint SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
		public const uint SHADER_STORAGE_BUFFER_START = 0x90D4;
		public const uint SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
		public const uint MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
		public const uint MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
		public const uint MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
		public const uint MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
		public const uint MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
		public const uint MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
		public const uint MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
		public const uint MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
		public const uint MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
		public const uint SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
		public const uint SHADER_STORAGE_BARRIER_BIT = 0x00002000;
		public const uint MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
		public const uint DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
		public const uint TEXTURE_BUFFER_OFFSET = 0x919D;
		public const uint TEXTURE_BUFFER_SIZE = 0x919E;
		public const uint TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
		public const uint TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
		public const uint TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
		public const uint TEXTURE_VIEW_MIN_LAYER = 0x82DD;
		public const uint TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
		public const uint TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
		public const uint VERTEX_ATTRIB_BINDING = 0x82D4;
		public const uint VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
		public const uint VERTEX_BINDING_DIVISOR = 0x82D6;
		public const uint VERTEX_BINDING_OFFSET = 0x82D7;
		public const uint VERTEX_BINDING_STRIDE = 0x82D8;
		public const uint MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
		public const uint MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
		public const uint VERTEX_BINDING_BUFFER = 0x8F4F;
		public const uint MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
		public const uint PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
		public const uint TEXTURE_BUFFER_BINDING = 0x8C2A;
		public const uint MAP_PERSISTENT_BIT = 0x0040;
		public const uint MAP_COHERENT_BIT = 0x0080;
		public const uint DYNAMIC_STORAGE_BIT = 0x0100;
		public const uint CLIENT_STORAGE_BIT = 0x0200;
		public const uint CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
		public const uint BUFFER_IMMUTABLE_STORAGE = 0x821F;
		public const uint BUFFER_STORAGE_FLAGS = 0x8220;
		public const uint CLEAR_TEXTURE = 0x9365;
		public const uint LOCATION_COMPONENT = 0x934A;
		public const uint TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
		public const uint TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
		public const uint QUERY_BUFFER = 0x9192;
		public const uint QUERY_BUFFER_BARRIER_BIT = 0x00008000;
		public const uint QUERY_BUFFER_BINDING = 0x9193;
		public const uint QUERY_RESULT_NO_WAIT = 0x9194;
		public const uint MIRROR_CLAMP_TO_EDGE = 0x8743;
		public const uint CONTEXT_LOST = 0x0507;
		public const uint NEGATIVE_ONE_TO_ONE = 0x935E;
		public const uint ZERO_TO_ONE = 0x935F;
		public const uint CLIP_ORIGIN = 0x935C;
		public const uint CLIP_DEPTH_MODE = 0x935D;
		public const uint QUERY_WAIT_INVERTED = 0x8E17;
		public const uint QUERY_NO_WAIT_INVERTED = 0x8E18;
		public const uint QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
		public const uint QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
		public const uint MAX_CULL_DISTANCES = 0x82F9;
		public const uint MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
		public const uint TEXTURE_TARGET = 0x1006;
		public const uint QUERY_TARGET = 0x82EA;
		public const uint GUILTY_CONTEXT_RESET = 0x8253;
		public const uint INNOCENT_CONTEXT_RESET = 0x8254;
		public const uint UNKNOWN_CONTEXT_RESET = 0x8255;
		public const uint RESET_NOTIFICATION_STRATEGY = 0x8256;
		public const uint LOSE_CONTEXT_ON_RESET = 0x8252;
		public const uint NO_RESET_NOTIFICATION = 0x8261;
		public const uint CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
		public const uint CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
		public const uint CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;

		public static class Delegates
		{
			public delegate void CullFace(uint mode);

			public delegate void FrontFace(uint mode);

			public delegate void Hint(uint target, uint mode);

			public delegate void LineWidth(float width);

			public delegate void PointSize(float size);

			public delegate void PolygonMode(uint face, uint mode);

			public delegate void Scissor(int x, int y, int width, int height);

			public delegate void TexParameterf(uint target, uint pname, float param);

			public delegate void TexParameterfv(uint target, uint pname, float @params);

			public delegate void TexParameteri(uint target, uint pname, int param);

			public delegate void TexParameteriv(uint target, uint pname, int @params);

			public delegate void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels);

			public delegate void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);

			public delegate void DrawBuffer(uint buf);

			public delegate void Clear(uint mask);

			public delegate void ClearColor(float red, float green, float blue, float alpha);

			public delegate void ClearStencil(int s);

			public delegate void ClearDepth(double depth);

			public delegate void StencilMask(uint mask);

			public delegate void ColorMask(bool red, bool green, bool blue, bool alpha);

			public delegate void DepthMask(bool flag);

			public delegate void Disable(uint cap);

			public delegate void Enable(uint cap);

			public delegate void Finish();

			public delegate void Flush();

			public delegate void BlendFunc(uint sfactor, uint dfactor);

			public delegate void LogicOp(uint opcode);

			public delegate void StencilFunc(uint func, int @ref, uint mask);

			public delegate void StencilOp(uint fail, uint zfail, uint zpass);

			public delegate void DepthFunc(uint func);

			public delegate void PixelStoref(uint pname, float param);

			public delegate void PixelStorei(uint pname, int param);

			public delegate void ReadBuffer(uint src);

			public delegate void ReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels);

			public delegate void GetBooleanv(uint pname, bool data);

			public delegate void GetDoublev(uint pname, double data);

			public delegate uint GetError();

			public delegate void GetFloatv(uint pname, float data);

			public delegate void GetIntegerv(uint pname, int data);

			public delegate IntPtr GetString(uint name);

			public delegate void GetTexImage(uint target, int level, uint format, uint type, IntPtr pixels);

			public delegate void GetTexParameterfv(uint target, uint pname, float @params);

			public delegate void GetTexParameteriv(uint target, uint pname, int @params);

			public delegate void GetTexLevelParameterfv(uint target, int level, uint pname, float @params);

			public delegate void GetTexLevelParameteriv(uint target, int level, uint pname, int @params);

			public delegate bool IsEnabled(uint cap);

			public delegate void DepthRange(double near, double far);

			public delegate void Viewport(int x, int y, int width, int height);

			public delegate void DrawArrays(uint mode, int first, int count);

			public delegate void DrawElements(uint mode, int count, uint type, IntPtr indices);

			public delegate void GetPointerv(uint pname, IntPtr[] @params);

			public delegate void PolygonOffset(float factor, float units);

			public delegate void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border);

			public delegate void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

			public delegate void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);

			public delegate void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

			public delegate void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);

			public delegate void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);

			public delegate void BindTexture(uint target, uint texture);

			public delegate void DeleteTextures(int n, uint textures);

			public delegate void GenTextures(int n, uint textures);

			public delegate bool IsTexture(uint texture);

			public delegate void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices);

			public delegate void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);

			public delegate void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

			public delegate void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

			public delegate void ActiveTexture(uint texture);

			public delegate void SampleCoverage(float value, bool invert);

			public delegate void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);

			public delegate void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);

			public delegate void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);

			public delegate void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

			public delegate void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);

			public delegate void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);

			public delegate void GetCompressedTexImage(uint target, int level, IntPtr img);

			public delegate void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

			public delegate void MultiDrawArrays(uint mode, int first, int count, int drawcount);

			public delegate void MultiDrawElements(uint mode, int count, uint type, IntPtr[] indices, int drawcount);

			public delegate void PointParameterf(uint pname, float param);

			public delegate void PointParameterfv(uint pname, float @params);

			public delegate void PointParameteri(uint pname, int param);

			public delegate void PointParameteriv(uint pname, int @params);

			public delegate void BlendColor(float red, float green, float blue, float alpha);

			public delegate void BlendEquation(uint mode);

			public delegate void GenQueries(int n, uint ids);

			public delegate void DeleteQueries(int n, uint ids);

			public delegate bool IsQuery(uint id);

			public delegate void BeginQuery(uint target, uint id);

			public delegate void EndQuery(uint target);

			public delegate void GetQueryiv(uint target, uint pname, int @params);

			public delegate void GetQueryObjectiv(uint id, uint pname, int @params);

			public delegate void GetQueryObjectuiv(uint id, uint pname, uint @params);

			public delegate void BindBuffer(uint target, uint buffer);

			public delegate void DeleteBuffers(int n, uint buffers);

			public delegate void GenBuffers(int n, uint buffers);

			public delegate bool IsBuffer(uint buffer);

			public delegate void BufferData(uint target, int size, IntPtr data, uint usage);

			public delegate void BufferSubData(uint target, int offset, int size, IntPtr data);

			public delegate void GetBufferSubData(uint target, int offset, int size, IntPtr data);

			public delegate IntPtr MapBuffer(uint target, uint access);

			public delegate bool UnmapBuffer(uint target);

			public delegate void GetBufferParameteriv(uint target, uint pname, int @params);

			public delegate void GetBufferPointerv(uint target, uint pname, IntPtr[] @params);

			public delegate void BlendEquationSeparate(uint modeRGB, uint modeAlpha);

			public delegate void DrawBuffers(int n, uint bufs);

			public delegate void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);

			public delegate void StencilFuncSeparate(uint face, uint func, int @ref, uint mask);

			public delegate void StencilMaskSeparate(uint face, uint mask);

			public delegate void AttachShader(uint program, uint shader);

			public delegate void BindAttribLocation(uint program, uint index, string name);

			public delegate void CompileShader(uint shader);

			public delegate uint CreateProgram();

			public delegate uint CreateShader(uint type);

			public delegate void DeleteProgram(uint program);

			public delegate void DeleteShader(uint shader);

			public delegate void DetachShader(uint program, uint shader);

			public delegate void DisableVertexAttribArray(uint index);

			public delegate void EnableVertexAttribArray(uint index);

			public delegate void GetActiveAttrib(uint program, uint index, int bufSize, int length, int size, uint type, string name);

			public delegate void GetActiveUniform(uint program, uint index, int bufSize, int length, int size, uint type, string name);

			public delegate void GetAttachedShaders(uint program, int maxCount, int count, uint shaders);

			public delegate int GetAttribLocation(uint program, string name);

			public delegate void GetProgramiv(uint program, uint pname, int @params);

			public delegate void GetProgramInfoLog(uint program, int bufSize, int length, string infoLog);

			public delegate void GetShaderiv(uint shader, uint pname, int @params);

			public delegate void GetShaderInfoLog(uint shader, int bufSize, int length, string infoLog);

			public delegate void GetShaderSource(uint shader, int bufSize, int length, string source);

			public delegate int GetUniformLocation(uint program, string name);

			public delegate void GetUniformfv(uint program, int location, float @params);

			public delegate void GetUniformiv(uint program, int location, int @params);

			public delegate void GetVertexAttribdv(uint index, uint pname, double @params);

			public delegate void GetVertexAttribfv(uint index, uint pname, float @params);

			public delegate void GetVertexAttribiv(uint index, uint pname, int @params);

			public delegate void GetVertexAttribPointerv(uint index, uint pname, IntPtr[] pointer);

			public delegate bool IsProgram(uint program);

			public delegate bool IsShader(uint shader);

			public delegate void LinkProgram(uint program);

			public delegate void ShaderSource(uint shader, int count, string[] @string, int length);

			public delegate void UseProgram(uint program);

			public delegate void Uniform1f(int location, float v0);

			public delegate void Uniform2f(int location, float v0, float v1);

			public delegate void Uniform3f(int location, float v0, float v1, float v2);

			public delegate void Uniform4f(int location, float v0, float v1, float v2, float v3);

			public delegate void Uniform1i(int location, int v0);

			public delegate void Uniform2i(int location, int v0, int v1);

			public delegate void Uniform3i(int location, int v0, int v1, int v2);

			public delegate void Uniform4i(int location, int v0, int v1, int v2, int v3);

			public delegate void Uniform1fv(int location, int count, float value);

			public delegate void Uniform2fv(int location, int count, float value);

			public delegate void Uniform3fv(int location, int count, float value);

			public delegate void Uniform4fv(int location, int count, float value);

			public delegate void Uniform1iv(int location, int count, int value);

			public delegate void Uniform2iv(int location, int count, int value);

			public delegate void Uniform3iv(int location, int count, int value);

			public delegate void Uniform4iv(int location, int count, int value);

			public delegate void UniformMatrix2fv(int location, int count, bool transpose, float value);

			public delegate void UniformMatrix3fv(int location, int count, bool transpose, float value);

			public delegate void UniformMatrix4fv(int location, int count, bool transpose, float value);

			public delegate void ValidateProgram(uint program);

			public delegate void VertexAttrib1d(uint index, double x);

			public delegate void VertexAttrib1dv(uint index, double v);

			public delegate void VertexAttrib1f(uint index, float x);

			public delegate void VertexAttrib1fv(uint index, float v);

			public delegate void VertexAttrib1s(uint index, short x);

			public delegate void VertexAttrib1sv(uint index, short v);

			public delegate void VertexAttrib2d(uint index, double x, double y);

			public delegate void VertexAttrib2dv(uint index, double v);

			public delegate void VertexAttrib2f(uint index, float x, float y);

			public delegate void VertexAttrib2fv(uint index, float v);

			public delegate void VertexAttrib2s(uint index, short x, short y);

			public delegate void VertexAttrib2sv(uint index, short v);

			public delegate void VertexAttrib3d(uint index, double x, double y, double z);

			public delegate void VertexAttrib3dv(uint index, double v);

			public delegate void VertexAttrib3f(uint index, float x, float y, float z);

			public delegate void VertexAttrib3fv(uint index, float v);

			public delegate void VertexAttrib3s(uint index, short x, short y, short z);

			public delegate void VertexAttrib3sv(uint index, short v);

			public delegate void VertexAttrib4Nbv(uint index, sbyte v);

			public delegate void VertexAttrib4Niv(uint index, int v);

			public delegate void VertexAttrib4Nsv(uint index, short v);

			public delegate void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);

			public delegate void VertexAttrib4Nubv(uint index, byte v);

			public delegate void VertexAttrib4Nuiv(uint index, uint v);

			public delegate void VertexAttrib4Nusv(uint index, ushort v);

			public delegate void VertexAttrib4bv(uint index, sbyte v);

			public delegate void VertexAttrib4d(uint index, double x, double y, double z, double w);

			public delegate void VertexAttrib4dv(uint index, double v);

			public delegate void VertexAttrib4f(uint index, float x, float y, float z, float w);

			public delegate void VertexAttrib4fv(uint index, float v);

			public delegate void VertexAttrib4iv(uint index, int v);

			public delegate void VertexAttrib4s(uint index, short x, short y, short z, short w);

			public delegate void VertexAttrib4sv(uint index, short v);

			public delegate void VertexAttrib4ubv(uint index, byte v);

			public delegate void VertexAttrib4uiv(uint index, uint v);

			public delegate void VertexAttrib4usv(uint index, ushort v);

			public delegate void VertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer);

			public delegate void UniformMatrix2x3fv(int location, int count, bool transpose, float value);

			public delegate void UniformMatrix3x2fv(int location, int count, bool transpose, float value);

			public delegate void UniformMatrix2x4fv(int location, int count, bool transpose, float value);

			public delegate void UniformMatrix4x2fv(int location, int count, bool transpose, float value);

			public delegate void UniformMatrix3x4fv(int location, int count, bool transpose, float value);

			public delegate void UniformMatrix4x3fv(int location, int count, bool transpose, float value);

			public delegate void ColorMaski(uint index, bool r, bool g, bool b, bool a);

			public delegate void GetBooleani_v(uint target, uint index, bool data);

			public delegate void GetIntegeri_v(uint target, uint index, int data);

			public delegate void Enablei(uint target, uint index);

			public delegate void Disablei(uint target, uint index);

			public delegate bool IsEnabledi(uint target, uint index);

			public delegate void BeginTransformFeedback(uint primitiveMode);

			public delegate void EndTransformFeedback();

			public delegate void BindBufferRange(uint target, uint index, uint buffer, int offset, int size);

			public delegate void BindBufferBase(uint target, uint index, uint buffer);

			public delegate void TransformFeedbackVaryings(uint program, int count, string[] varyings, uint bufferMode);

			public delegate void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int length, int size, uint type, string name);

			public delegate void ClampColor(uint target, uint clamp);

			public delegate void BeginConditionalRender(uint id, uint mode);

			public delegate void EndConditionalRender();

			public delegate void VertexAttribIPointer(uint index, int size, uint type, int stride, IntPtr pointer);

			public delegate void GetVertexAttribIiv(uint index, uint pname, int @params);

			public delegate void GetVertexAttribIuiv(uint index, uint pname, uint @params);

			public delegate void VertexAttribI1i(uint index, int x);

			public delegate void VertexAttribI2i(uint index, int x, int y);

			public delegate void VertexAttribI3i(uint index, int x, int y, int z);

			public delegate void VertexAttribI4i(uint index, int x, int y, int z, int w);

			public delegate void VertexAttribI1ui(uint index, uint x);

			public delegate void VertexAttribI2ui(uint index, uint x, uint y);

			public delegate void VertexAttribI3ui(uint index, uint x, uint y, uint z);

			public delegate void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);

			public delegate void VertexAttribI1iv(uint index, int v);

			public delegate void VertexAttribI2iv(uint index, int v);

			public delegate void VertexAttribI3iv(uint index, int v);

			public delegate void VertexAttribI4iv(uint index, int v);

			public delegate void VertexAttribI1uiv(uint index, uint v);

			public delegate void VertexAttribI2uiv(uint index, uint v);

			public delegate void VertexAttribI3uiv(uint index, uint v);

			public delegate void VertexAttribI4uiv(uint index, uint v);

			public delegate void VertexAttribI4bv(uint index, sbyte v);

			public delegate void VertexAttribI4sv(uint index, short v);

			public delegate void VertexAttribI4ubv(uint index, byte v);

			public delegate void VertexAttribI4usv(uint index, ushort v);

			public delegate void GetUniformuiv(uint program, int location, uint @params);

			public delegate void BindFragDataLocation(uint program, uint color, string name);

			public delegate int GetFragDataLocation(uint program, string name);

			public delegate void Uniform1ui(int location, uint v0);

			public delegate void Uniform2ui(int location, uint v0, uint v1);

			public delegate void Uniform3ui(int location, uint v0, uint v1, uint v2);

			public delegate void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3);

			public delegate void Uniform1uiv(int location, int count, uint value);

			public delegate void Uniform2uiv(int location, int count, uint value);

			public delegate void Uniform3uiv(int location, int count, uint value);

			public delegate void Uniform4uiv(int location, int count, uint value);

			public delegate void TexParameterIiv(uint target, uint pname, int @params);

			public delegate void TexParameterIuiv(uint target, uint pname, uint @params);

			public delegate void GetTexParameterIiv(uint target, uint pname, int @params);

			public delegate void GetTexParameterIuiv(uint target, uint pname, uint @params);

			public delegate void ClearBufferiv(uint buffer, int drawbuffer, int value);

			public delegate void ClearBufferuiv(uint buffer, int drawbuffer, uint value);

			public delegate void ClearBufferfv(uint buffer, int drawbuffer, float value);

			public delegate void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil);

			public delegate IntPtr GetStringi(uint name, uint index);

			public delegate bool IsRenderbuffer(uint renderbuffer);

			public delegate void BindRenderbuffer(uint target, uint renderbuffer);

			public delegate void DeleteRenderbuffers(int n, uint renderbuffers);

			public delegate void GenRenderbuffers(int n, uint renderbuffers);

			public delegate void RenderbufferStorage(uint target, uint internalformat, int width, int height);

			public delegate void GetRenderbufferParameteriv(uint target, uint pname, int @params);

			public delegate bool IsFramebuffer(uint framebuffer);

			public delegate void BindFramebuffer(uint target, uint framebuffer);

			public delegate void DeleteFramebuffers(int n, uint framebuffers);

			public delegate void GenFramebuffers(int n, uint framebuffers);

			public delegate uint CheckFramebufferStatus(uint target);

			public delegate void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level);

			public delegate void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);

			public delegate void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);

			public delegate void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

			public delegate void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int @params);

			public delegate void GenerateMipmap(uint target);

			public delegate void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

			public delegate void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);

			public delegate void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);

			public delegate IntPtr MapBufferRange(uint target, int offset, int length, uint access);

			public delegate void FlushMappedBufferRange(uint target, int offset, int length);

			public delegate void BindVertexArray(uint array);

			public delegate void DeleteVertexArrays(int n, uint arrays);

			public delegate void GenVertexArrays(int n, uint arrays);

			public delegate bool IsVertexArray(uint array);

			public delegate void DrawArraysInstanced(uint mode, int first, int count, int instancecount);

			public delegate void DrawElementsInstanced(uint mode, int count, uint type, IntPtr indices, int instancecount);

			public delegate void TexBuffer(uint target, uint internalformat, uint buffer);

			public delegate void PrimitiveRestartIndex(uint index);

			public delegate void CopyBufferSubData(uint readTarget, uint writeTarget, int readOffset, int writeOffset, int size);

			public delegate void GetUniformIndices(uint program, int uniformCount, string[] uniformNames, uint uniformIndices);

			public delegate void GetActiveUniformsiv(uint program, int uniformCount, uint uniformIndices, uint pname, int @params);

			public delegate void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int length, string uniformName);

			public delegate uint GetUniformBlockIndex(uint program, string uniformBlockName);

			public delegate void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int @params);

			public delegate void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int length, string uniformBlockName);

			public delegate void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

			public delegate void DrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int basevertex);

			public delegate void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex);

			public delegate void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex);

			public delegate void MultiDrawElementsBaseVertex(uint mode, int count, uint type, IntPtr[] indices, int drawcount, int basevertex);

			public delegate void ProvokingVertex(uint mode);

			public delegate IntPtr FenceSync(uint condition, uint flags);

			public delegate bool IsSync(IntPtr sync);

			public delegate void DeleteSync(IntPtr sync);

			public delegate uint ClientWaitSync(IntPtr sync, uint flags, ulong timeout);

			public delegate void WaitSync(IntPtr sync, uint flags, ulong timeout);

			public delegate void GetInteger64v(uint pname, long data);

			public delegate void GetSynciv(IntPtr sync, uint pname, int bufSize, int length, int values);

			public delegate void GetInteger64i_v(uint target, uint index, long data);

			public delegate void GetBufferParameteri64v(uint target, uint pname, long @params);

			public delegate void FramebufferTexture(uint target, uint attachment, uint texture, int level);

			public delegate void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void GetMultisamplefv(uint pname, uint index, float val);

			public delegate void SampleMaski(uint maskNumber, uint mask);

			public delegate void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name);

			public delegate int GetFragDataIndex(uint program, string name);

			public delegate void GenSamplers(int count, uint samplers);

			public delegate void DeleteSamplers(int count, uint samplers);

			public delegate bool IsSampler(uint sampler);

			public delegate void BindSampler(uint unit, uint sampler);

			public delegate void SamplerParameteri(uint sampler, uint pname, int param);

			public delegate void SamplerParameteriv(uint sampler, uint pname, int param);

			public delegate void SamplerParameterf(uint sampler, uint pname, float param);

			public delegate void SamplerParameterfv(uint sampler, uint pname, float param);

			public delegate void SamplerParameterIiv(uint sampler, uint pname, int param);

			public delegate void SamplerParameterIuiv(uint sampler, uint pname, uint param);

			public delegate void GetSamplerParameteriv(uint sampler, uint pname, int @params);

			public delegate void GetSamplerParameterIiv(uint sampler, uint pname, int @params);

			public delegate void GetSamplerParameterfv(uint sampler, uint pname, float @params);

			public delegate void GetSamplerParameterIuiv(uint sampler, uint pname, uint @params);

			public delegate void QueryCounter(uint id, uint target);

			public delegate void GetQueryObjecti64v(uint id, uint pname, long @params);

			public delegate void GetQueryObjectui64v(uint id, uint pname, ulong @params);

			public delegate void VertexAttribDivisor(uint index, uint divisor);

			public delegate void VertexAttribP1ui(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP1uiv(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP2ui(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP2uiv(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP3ui(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP3uiv(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP4ui(uint index, uint type, bool normalized, uint value);

			public delegate void VertexAttribP4uiv(uint index, uint type, bool normalized, uint value);

			public delegate void MinSampleShading(float value);

			public delegate void BlendEquationi(uint buf, uint mode);

			public delegate void BlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);

			public delegate void BlendFunci(uint buf, uint src, uint dst);

			public delegate void BlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);

			public delegate void DrawArraysIndirect(uint mode, IntPtr indirect);

			public delegate void DrawElementsIndirect(uint mode, uint type, IntPtr indirect);

			public delegate void Uniform1d(int location, double x);

			public delegate void Uniform2d(int location, double x, double y);

			public delegate void Uniform3d(int location, double x, double y, double z);

			public delegate void Uniform4d(int location, double x, double y, double z, double w);

			public delegate void Uniform1dv(int location, int count, double value);

			public delegate void Uniform2dv(int location, int count, double value);

			public delegate void Uniform3dv(int location, int count, double value);

			public delegate void Uniform4dv(int location, int count, double value);

			public delegate void UniformMatrix2dv(int location, int count, bool transpose, double value);

			public delegate void UniformMatrix3dv(int location, int count, bool transpose, double value);

			public delegate void UniformMatrix4dv(int location, int count, bool transpose, double value);

			public delegate void UniformMatrix2x3dv(int location, int count, bool transpose, double value);

			public delegate void UniformMatrix2x4dv(int location, int count, bool transpose, double value);

			public delegate void UniformMatrix3x2dv(int location, int count, bool transpose, double value);

			public delegate void UniformMatrix3x4dv(int location, int count, bool transpose, double value);

			public delegate void UniformMatrix4x2dv(int location, int count, bool transpose, double value);

			public delegate void UniformMatrix4x3dv(int location, int count, bool transpose, double value);

			public delegate void GetUniformdv(uint program, int location, double @params);

			public delegate int GetSubroutineUniformLocation(uint program, uint shadertype, string name);

			public delegate uint GetSubroutineIndex(uint program, uint shadertype, string name);

			public delegate void GetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int values);

			public delegate void GetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int length, string name);

			public delegate void GetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int length, string name);

			public delegate void UniformSubroutinesuiv(uint shadertype, int count, uint indices);

			public delegate void GetUniformSubroutineuiv(uint shadertype, int location, uint @params);

			public delegate void GetProgramStageiv(uint program, uint shadertype, uint pname, int values);

			public delegate void PatchParameteri(uint pname, int value);

			public delegate void PatchParameterfv(uint pname, float values);

			public delegate void BindTransformFeedback(uint target, uint id);

			public delegate void DeleteTransformFeedbacks(int n, uint ids);

			public delegate void GenTransformFeedbacks(int n, uint ids);

			public delegate bool IsTransformFeedback(uint id);

			public delegate void PauseTransformFeedback();

			public delegate void ResumeTransformFeedback();

			public delegate void DrawTransformFeedback(uint mode, uint id);

			public delegate void DrawTransformFeedbackStream(uint mode, uint id, uint stream);

			public delegate void BeginQueryIndexed(uint target, uint index, uint id);

			public delegate void EndQueryIndexed(uint target, uint index);

			public delegate void GetQueryIndexediv(uint target, uint index, uint pname, int @params);

			public delegate void ReleaseShaderCompiler();

			public delegate void ShaderBinary(int count, uint shaders, uint binaryformat, IntPtr binary, int length);

			public delegate void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int range, int precision);

			public delegate void DepthRangef(float n, float f);

			public delegate void ClearDepthf(float d);

			public delegate void GetProgramBinary(uint program, int bufSize, int length, uint binaryFormat, IntPtr binary);

			public delegate void ProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length);

			public delegate void ProgramParameteri(uint program, uint pname, int value);

			public delegate void UseProgramStages(uint pipeline, uint stages, uint program);

			public delegate void ActiveShaderProgram(uint pipeline, uint program);

			public delegate uint CreateShaderProgramv(uint type, int count, string[] strings);

			public delegate void BindProgramPipeline(uint pipeline);

			public delegate void DeleteProgramPipelines(int n, uint pipelines);

			public delegate void GenProgramPipelines(int n, uint pipelines);

			public delegate bool IsProgramPipeline(uint pipeline);

			public delegate void GetProgramPipelineiv(uint pipeline, uint pname, int @params);

			public delegate void ProgramUniform1i(uint program, int location, int v0);

			public delegate void ProgramUniform1iv(uint program, int location, int count, int value);

			public delegate void ProgramUniform1f(uint program, int location, float v0);

			public delegate void ProgramUniform1fv(uint program, int location, int count, float value);

			public delegate void ProgramUniform1d(uint program, int location, double v0);

			public delegate void ProgramUniform1dv(uint program, int location, int count, double value);

			public delegate void ProgramUniform1ui(uint program, int location, uint v0);

			public delegate void ProgramUniform1uiv(uint program, int location, int count, uint value);

			public delegate void ProgramUniform2i(uint program, int location, int v0, int v1);

			public delegate void ProgramUniform2iv(uint program, int location, int count, int value);

			public delegate void ProgramUniform2f(uint program, int location, float v0, float v1);

			public delegate void ProgramUniform2fv(uint program, int location, int count, float value);

			public delegate void ProgramUniform2d(uint program, int location, double v0, double v1);

			public delegate void ProgramUniform2dv(uint program, int location, int count, double value);

			public delegate void ProgramUniform2ui(uint program, int location, uint v0, uint v1);

			public delegate void ProgramUniform2uiv(uint program, int location, int count, uint value);

			public delegate void ProgramUniform3i(uint program, int location, int v0, int v1, int v2);

			public delegate void ProgramUniform3iv(uint program, int location, int count, int value);

			public delegate void ProgramUniform3f(uint program, int location, float v0, float v1, float v2);

			public delegate void ProgramUniform3fv(uint program, int location, int count, float value);

			public delegate void ProgramUniform3d(uint program, int location, double v0, double v1, double v2);

			public delegate void ProgramUniform3dv(uint program, int location, int count, double value);

			public delegate void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);

			public delegate void ProgramUniform3uiv(uint program, int location, int count, uint value);

			public delegate void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);

			public delegate void ProgramUniform4iv(uint program, int location, int count, int value);

			public delegate void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);

			public delegate void ProgramUniform4fv(uint program, int location, int count, float value);

			public delegate void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);

			public delegate void ProgramUniform4dv(uint program, int location, int count, double value);

			public delegate void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);

			public delegate void ProgramUniform4uiv(uint program, int location, int count, uint value);

			public delegate void ProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float value);

			public delegate void ProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float value);

			public delegate void ProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float value);

			public delegate void ProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double value);

			public delegate void ProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double value);

			public delegate void ProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double value);

			public delegate void ProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float value);

			public delegate void ProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float value);

			public delegate void ProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float value);

			public delegate void ProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float value);

			public delegate void ProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float value);

			public delegate void ProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float value);

			public delegate void ProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double value);

			public delegate void ProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double value);

			public delegate void ProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double value);

			public delegate void ProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double value);

			public delegate void ProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double value);

			public delegate void ProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double value);

			public delegate void ValidateProgramPipeline(uint pipeline);

			public delegate void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int length, string infoLog);

			public delegate void VertexAttribL1d(uint index, double x);

			public delegate void VertexAttribL2d(uint index, double x, double y);

			public delegate void VertexAttribL3d(uint index, double x, double y, double z);

			public delegate void VertexAttribL4d(uint index, double x, double y, double z, double w);

			public delegate void VertexAttribL1dv(uint index, double v);

			public delegate void VertexAttribL2dv(uint index, double v);

			public delegate void VertexAttribL3dv(uint index, double v);

			public delegate void VertexAttribL4dv(uint index, double v);

			public delegate void VertexAttribLPointer(uint index, int size, uint type, int stride, IntPtr pointer);

			public delegate void GetVertexAttribLdv(uint index, uint pname, double @params);

			public delegate void ViewportArrayv(uint first, int count, float v);

			public delegate void ViewportIndexedf(uint index, float x, float y, float w, float h);

			public delegate void ViewportIndexedfv(uint index, float v);

			public delegate void ScissorArrayv(uint first, int count, int v);

			public delegate void ScissorIndexed(uint index, int left, int bottom, int width, int height);

			public delegate void ScissorIndexedv(uint index, int v);

			public delegate void DepthRangeArrayv(uint first, int count, double v);

			public delegate void DepthRangeIndexed(uint index, double n, double f);

			public delegate void GetFloati_v(uint target, uint index, float data);

			public delegate void GetDoublei_v(uint target, uint index, double data);

			public delegate void DrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance);

			public delegate void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance);

			public delegate void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance);

			public delegate void GetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int @params);

			public delegate void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int @params);

			public delegate void BindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);

			public delegate void MemoryBarrier(uint barriers);

			public delegate void TexStorage1D(uint target, int levels, uint internalformat, int width);

			public delegate void TexStorage2D(uint target, int levels, uint internalformat, int width, int height);

			public delegate void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);

			public delegate void DrawTransformFeedbackInstanced(uint mode, uint id, int instancecount);

			public delegate void DrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount);

			public delegate void ClearBufferData(uint target, uint internalformat, uint format, uint type, IntPtr data);

			public delegate void ClearBufferSubData(uint target, uint internalformat, int offset, int size, uint format, uint type, IntPtr data);

			public delegate void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);

			public delegate void DispatchComputeIndirect(int indirect);

			public delegate void CopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);

			public delegate void FramebufferParameteri(uint target, uint pname, int param);

			public delegate void GetFramebufferParameteriv(uint target, uint pname, int @params);

			public delegate void GetInternalformati64v(uint target, uint internalformat, uint pname, int bufSize, long @params);

			public delegate void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);

			public delegate void InvalidateTexImage(uint texture, int level);

			public delegate void InvalidateBufferSubData(uint buffer, int offset, int length);

			public delegate void InvalidateBufferData(uint buffer);

			public delegate void InvalidateFramebuffer(uint target, int numAttachments, uint attachments);

			public delegate void InvalidateSubFramebuffer(uint target, int numAttachments, uint attachments, int x, int y, int width, int height);

			public delegate void MultiDrawArraysIndirect(uint mode, IntPtr indirect, int drawcount, int stride);

			public delegate void MultiDrawElementsIndirect(uint mode, uint type, IntPtr indirect, int drawcount, int stride);

			public delegate void GetProgramInterfaceiv(uint program, uint programInterface, uint pname, int @params);

			public delegate uint GetProgramResourceIndex(uint program, uint programInterface, string name);

			public delegate void GetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int length, string name);

			public delegate void GetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint props, int bufSize, int length, int @params);

			public delegate int GetProgramResourceLocation(uint program, uint programInterface, string name);

			public delegate int GetProgramResourceLocationIndex(uint program, uint programInterface, string name);

			public delegate void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);

			public delegate void TexBufferRange(uint target, uint internalformat, uint buffer, int offset, int size);

			public delegate void TexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void TexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void TextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

			public delegate void BindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride);

			public delegate void VertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);

			public delegate void VertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void VertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void VertexAttribBinding(uint attribindex, uint bindingindex);

			public delegate void VertexBindingDivisor(uint bindingindex, uint divisor);

			public delegate void DebugMessageControl(uint source, uint type, uint severity, int count, uint ids, bool enabled);

			public delegate void DebugMessageInsert(uint source, uint type, uint id, uint severity, int length, string buf);

			public delegate void DebugMessageCallback(IntPtr callback, IntPtr userParam);

			public delegate uint GetDebugMessageLog(uint count, int bufSize, uint sources, uint types, uint ids, uint severities, int lengths, string messageLog);

			public delegate void PushDebugGroup(uint source, uint id, int length, string message);

			public delegate void PopDebugGroup();

			public delegate void ObjectLabel(uint identifier, uint name, int length, string label);

			public delegate void GetObjectLabel(uint identifier, uint name, int bufSize, int length, string label);

			public delegate void ObjectPtrLabel(IntPtr ptr, int length, string label);

			public delegate void GetObjectPtrLabel(IntPtr ptr, int bufSize, int length, string label);

			public delegate void BufferStorage(uint target, int size, IntPtr data, uint flags);

			public delegate void ClearTexImage(uint texture, int level, uint format, uint type, IntPtr data);

			public delegate void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data);

			public delegate void BindBuffersBase(uint target, uint first, int count, uint buffers);

			public delegate void BindBuffersRange(uint target, uint first, int count, uint buffers, int offsets, int sizes);

			public delegate void BindTextures(uint first, int count, uint textures);

			public delegate void BindSamplers(uint first, int count, uint samplers);

			public delegate void BindImageTextures(uint first, int count, uint textures);

			public delegate void BindVertexBuffers(uint first, int count, uint buffers, int offsets, int strides);

			public delegate void ClipControl(uint origin, uint depth);

			public delegate void CreateTransformFeedbacks(int n, uint ids);

			public delegate void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer);

			public delegate void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size);

			public delegate void GetTransformFeedbackiv(uint xfb, uint pname, int param);

			public delegate void GetTransformFeedbacki_v(uint xfb, uint pname, uint index, int param);

			public delegate void GetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long param);

			public delegate void CreateBuffers(int n, uint buffers);

			public delegate void NamedBufferStorage(uint buffer, int size, IntPtr data, uint flags);

			public delegate void NamedBufferData(uint buffer, int size, IntPtr data, uint usage);

			public delegate void NamedBufferSubData(uint buffer, int offset, int size, IntPtr data);

			public delegate void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size);

			public delegate void ClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, IntPtr data);

			public delegate void ClearNamedBufferSubData(uint buffer, uint internalformat, int offset, int size, uint format, uint type, IntPtr data);

			public delegate IntPtr MapNamedBuffer(uint buffer, uint access);

			public delegate IntPtr MapNamedBufferRange(uint buffer, int offset, int length, uint access);

			public delegate bool UnmapNamedBuffer(uint buffer);

			public delegate void FlushMappedNamedBufferRange(uint buffer, int offset, int length);

			public delegate void GetNamedBufferParameteriv(uint buffer, uint pname, int @params);

			public delegate void GetNamedBufferParameteri64v(uint buffer, uint pname, long @params);

			public delegate void GetNamedBufferPointerv(uint buffer, uint pname, IntPtr[] @params);

			public delegate void GetNamedBufferSubData(uint buffer, int offset, int size, IntPtr data);

			public delegate void CreateFramebuffers(int n, uint framebuffers);

			public delegate void NamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);

			public delegate void NamedFramebufferParameteri(uint framebuffer, uint pname, int param);

			public delegate void NamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level);

			public delegate void NamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer);

			public delegate void NamedFramebufferDrawBuffer(uint framebuffer, uint buf);

			public delegate void NamedFramebufferDrawBuffers(uint framebuffer, int n, uint bufs);

			public delegate void NamedFramebufferReadBuffer(uint framebuffer, uint src);

			public delegate void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint attachments);

			public delegate void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint attachments, int x, int y, int width, int height);

			public delegate void ClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int value);

			public delegate void ClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint value);

			public delegate void ClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float value);

			public delegate void ClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);

			public delegate void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

			public delegate uint CheckNamedFramebufferStatus(uint framebuffer, uint target);

			public delegate void GetNamedFramebufferParameteriv(uint framebuffer, uint pname, int param);

			public delegate void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int @params);

			public delegate void CreateRenderbuffers(int n, uint renderbuffers);

			public delegate void NamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height);

			public delegate void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height);

			public delegate void GetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int @params);

			public delegate void CreateTextures(uint target, int n, uint textures);

			public delegate void TextureBuffer(uint texture, uint internalformat, uint buffer);

			public delegate void TextureBufferRange(uint texture, uint internalformat, uint buffer, int offset, int size);

			public delegate void TextureStorage1D(uint texture, int levels, uint internalformat, int width);

			public delegate void TextureStorage2D(uint texture, int levels, uint internalformat, int width, int height);

			public delegate void TextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth);

			public delegate void TextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

			public delegate void TextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

			public delegate void TextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);

			public delegate void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);

			public delegate void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

			public delegate void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);

			public delegate void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);

			public delegate void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

			public delegate void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width);

			public delegate void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);

			public delegate void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

			public delegate void TextureParameterf(uint texture, uint pname, float param);

			public delegate void TextureParameterfv(uint texture, uint pname, float param);

			public delegate void TextureParameteri(uint texture, uint pname, int param);

			public delegate void TextureParameterIiv(uint texture, uint pname, int @params);

			public delegate void TextureParameterIuiv(uint texture, uint pname, uint @params);

			public delegate void TextureParameteriv(uint texture, uint pname, int param);

			public delegate void GenerateTextureMipmap(uint texture);

			public delegate void BindTextureUnit(uint unit, uint texture);

			public delegate void GetTextureImage(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels);

			public delegate void GetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels);

			public delegate void GetTextureLevelParameterfv(uint texture, int level, uint pname, float @params);

			public delegate void GetTextureLevelParameteriv(uint texture, int level, uint pname, int @params);

			public delegate void GetTextureParameterfv(uint texture, uint pname, float @params);

			public delegate void GetTextureParameterIiv(uint texture, uint pname, int @params);

			public delegate void GetTextureParameterIuiv(uint texture, uint pname, uint @params);

			public delegate void GetTextureParameteriv(uint texture, uint pname, int @params);

			public delegate void CreateVertexArrays(int n, uint arrays);

			public delegate void DisableVertexArrayAttrib(uint vaobj, uint index);

			public delegate void EnableVertexArrayAttrib(uint vaobj, uint index);

			public delegate void VertexArrayElementBuffer(uint vaobj, uint buffer);

			public delegate void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride);

			public delegate void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint buffers, int offsets, int strides);

			public delegate void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex);

			public delegate void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);

			public delegate void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

			public delegate void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor);

			public delegate void GetVertexArrayiv(uint vaobj, uint pname, int param);

			public delegate void GetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int param);

			public delegate void GetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long param);

			public delegate void CreateSamplers(int n, uint samplers);

			public delegate void CreateProgramPipelines(int n, uint pipelines);

			public delegate void CreateQueries(uint target, int n, uint ids);

			public delegate void GetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int offset);

			public delegate void GetQueryBufferObjectiv(uint id, uint buffer, uint pname, int offset);

			public delegate void GetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int offset);

			public delegate void GetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int offset);

			public delegate void MemoryBarrierByRegion(uint barriers);

			public delegate void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels);

			public delegate void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels);

			public delegate uint GetGraphicsResetStatus();

			public delegate void GetnCompressedTexImage(uint target, int lod, int bufSize, IntPtr pixels);

			public delegate void GetnTexImage(uint target, int level, uint format, uint type, int bufSize, IntPtr pixels);

			public delegate void GetnUniformdv(uint program, int location, int bufSize, double @params);

			public delegate void GetnUniformfv(uint program, int location, int bufSize, float @params);

			public delegate void GetnUniformiv(uint program, int location, int bufSize, int @params);

			public delegate void GetnUniformuiv(uint program, int location, int bufSize, uint @params);

			public delegate void ReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data);

			public delegate void TextureBarrier();

		}

		public static Delegates.CullFace CullFace;

		public static Delegates.FrontFace FrontFace;

		public static Delegates.Hint Hint;

		public static Delegates.LineWidth LineWidth;

		public static Delegates.PointSize PointSize;

		public static Delegates.PolygonMode PolygonMode;

		public static Delegates.Scissor Scissor;

		public static Delegates.TexParameterf TexParameterf;

		public static Delegates.TexParameterfv TexParameterfv;

		public static Delegates.TexParameteri TexParameteri;

		public static Delegates.TexParameteriv TexParameteriv;

		public static Delegates.TexImage1D TexImage1D;

		public static Delegates.TexImage2D TexImage2D;

		public static Delegates.DrawBuffer DrawBuffer;

		public static Delegates.Clear Clear;

		public static Delegates.ClearColor ClearColor;

		public static Delegates.ClearStencil ClearStencil;

		public static Delegates.ClearDepth ClearDepth;

		public static Delegates.StencilMask StencilMask;

		public static Delegates.ColorMask ColorMask;

		public static Delegates.DepthMask DepthMask;

		public static Delegates.Disable Disable;

		public static Delegates.Enable Enable;

		public static Delegates.Finish Finish;

		public static Delegates.Flush Flush;

		public static Delegates.BlendFunc BlendFunc;

		public static Delegates.LogicOp LogicOp;

		public static Delegates.StencilFunc StencilFunc;

		public static Delegates.StencilOp StencilOp;

		public static Delegates.DepthFunc DepthFunc;

		public static Delegates.PixelStoref PixelStoref;

		public static Delegates.PixelStorei PixelStorei;

		public static Delegates.ReadBuffer ReadBuffer;

		public static Delegates.ReadPixels ReadPixels;

		public static Delegates.GetBooleanv GetBooleanv;

		public static Delegates.GetDoublev GetDoublev;

		public static Delegates.GetError GetError;

		public static Delegates.GetFloatv GetFloatv;

		public static Delegates.GetIntegerv GetIntegerv;

		public static Delegates.GetString GetString;

		public static Delegates.GetTexImage GetTexImage;

		public static Delegates.GetTexParameterfv GetTexParameterfv;

		public static Delegates.GetTexParameteriv GetTexParameteriv;

		public static Delegates.GetTexLevelParameterfv GetTexLevelParameterfv;

		public static Delegates.GetTexLevelParameteriv GetTexLevelParameteriv;

		public static Delegates.IsEnabled IsEnabled;

		public static Delegates.DepthRange DepthRange;

		public static Delegates.Viewport Viewport;

		public static Delegates.DrawArrays DrawArrays;

		public static Delegates.DrawElements DrawElements;

		public static Delegates.GetPointerv GetPointerv;

		public static Delegates.PolygonOffset PolygonOffset;

		public static Delegates.CopyTexImage1D CopyTexImage1D;

		public static Delegates.CopyTexImage2D CopyTexImage2D;

		public static Delegates.CopyTexSubImage1D CopyTexSubImage1D;

		public static Delegates.CopyTexSubImage2D CopyTexSubImage2D;

		public static Delegates.TexSubImage1D TexSubImage1D;

		public static Delegates.TexSubImage2D TexSubImage2D;

		public static Delegates.BindTexture BindTexture;

		public static Delegates.DeleteTextures DeleteTextures;

		public static Delegates.GenTextures GenTextures;

		public static Delegates.IsTexture IsTexture;

		public static Delegates.DrawRangeElements DrawRangeElements;

		public static Delegates.TexImage3D TexImage3D;

		public static Delegates.TexSubImage3D TexSubImage3D;

		public static Delegates.CopyTexSubImage3D CopyTexSubImage3D;

		public static Delegates.ActiveTexture ActiveTexture;

		public static Delegates.SampleCoverage SampleCoverage;

		public static Delegates.CompressedTexImage3D CompressedTexImage3D;

		public static Delegates.CompressedTexImage2D CompressedTexImage2D;

		public static Delegates.CompressedTexImage1D CompressedTexImage1D;

		public static Delegates.CompressedTexSubImage3D CompressedTexSubImage3D;

		public static Delegates.CompressedTexSubImage2D CompressedTexSubImage2D;

		public static Delegates.CompressedTexSubImage1D CompressedTexSubImage1D;

		public static Delegates.GetCompressedTexImage GetCompressedTexImage;

		public static Delegates.BlendFuncSeparate BlendFuncSeparate;

		public static Delegates.MultiDrawArrays MultiDrawArrays;

		public static Delegates.MultiDrawElements MultiDrawElements;

		public static Delegates.PointParameterf PointParameterf;

		public static Delegates.PointParameterfv PointParameterfv;

		public static Delegates.PointParameteri PointParameteri;

		public static Delegates.PointParameteriv PointParameteriv;

		public static Delegates.BlendColor BlendColor;

		public static Delegates.BlendEquation BlendEquation;

		public static Delegates.GenQueries GenQueries;

		public static Delegates.DeleteQueries DeleteQueries;

		public static Delegates.IsQuery IsQuery;

		public static Delegates.BeginQuery BeginQuery;

		public static Delegates.EndQuery EndQuery;

		public static Delegates.GetQueryiv GetQueryiv;

		public static Delegates.GetQueryObjectiv GetQueryObjectiv;

		public static Delegates.GetQueryObjectuiv GetQueryObjectuiv;

		public static Delegates.BindBuffer BindBuffer;

		public static Delegates.DeleteBuffers DeleteBuffers;

		public static Delegates.GenBuffers GenBuffers;

		public static Delegates.IsBuffer IsBuffer;

		public static Delegates.BufferData BufferData;

		public static Delegates.BufferSubData BufferSubData;

		public static Delegates.GetBufferSubData GetBufferSubData;

		public static Delegates.MapBuffer MapBuffer;

		public static Delegates.UnmapBuffer UnmapBuffer;

		public static Delegates.GetBufferParameteriv GetBufferParameteriv;

		public static Delegates.GetBufferPointerv GetBufferPointerv;

		public static Delegates.BlendEquationSeparate BlendEquationSeparate;

		public static Delegates.DrawBuffers DrawBuffers;

		public static Delegates.StencilOpSeparate StencilOpSeparate;

		public static Delegates.StencilFuncSeparate StencilFuncSeparate;

		public static Delegates.StencilMaskSeparate StencilMaskSeparate;

		public static Delegates.AttachShader AttachShader;

		public static Delegates.BindAttribLocation BindAttribLocation;

		public static Delegates.CompileShader CompileShader;

		public static Delegates.CreateProgram CreateProgram;

		public static Delegates.CreateShader CreateShader;

		public static Delegates.DeleteProgram DeleteProgram;

		public static Delegates.DeleteShader DeleteShader;

		public static Delegates.DetachShader DetachShader;

		public static Delegates.DisableVertexAttribArray DisableVertexAttribArray;

		public static Delegates.EnableVertexAttribArray EnableVertexAttribArray;

		public static Delegates.GetActiveAttrib GetActiveAttrib;

		public static Delegates.GetActiveUniform GetActiveUniform;

		public static Delegates.GetAttachedShaders GetAttachedShaders;

		public static Delegates.GetAttribLocation GetAttribLocation;

		public static Delegates.GetProgramiv GetProgramiv;

		public static Delegates.GetProgramInfoLog GetProgramInfoLog;

		public static Delegates.GetShaderiv GetShaderiv;

		public static Delegates.GetShaderInfoLog GetShaderInfoLog;

		public static Delegates.GetShaderSource GetShaderSource;

		public static Delegates.GetUniformLocation GetUniformLocation;

		public static Delegates.GetUniformfv GetUniformfv;

		public static Delegates.GetUniformiv GetUniformiv;

		public static Delegates.GetVertexAttribdv GetVertexAttribdv;

		public static Delegates.GetVertexAttribfv GetVertexAttribfv;

		public static Delegates.GetVertexAttribiv GetVertexAttribiv;

		public static Delegates.GetVertexAttribPointerv GetVertexAttribPointerv;

		public static Delegates.IsProgram IsProgram;

		public static Delegates.IsShader IsShader;

		public static Delegates.LinkProgram LinkProgram;

		public static Delegates.ShaderSource ShaderSource;

		public static Delegates.UseProgram UseProgram;

		public static Delegates.Uniform1f Uniform1f;

		public static Delegates.Uniform2f Uniform2f;

		public static Delegates.Uniform3f Uniform3f;

		public static Delegates.Uniform4f Uniform4f;

		public static Delegates.Uniform1i Uniform1i;

		public static Delegates.Uniform2i Uniform2i;

		public static Delegates.Uniform3i Uniform3i;

		public static Delegates.Uniform4i Uniform4i;

		public static Delegates.Uniform1fv Uniform1fv;

		public static Delegates.Uniform2fv Uniform2fv;

		public static Delegates.Uniform3fv Uniform3fv;

		public static Delegates.Uniform4fv Uniform4fv;

		public static Delegates.Uniform1iv Uniform1iv;

		public static Delegates.Uniform2iv Uniform2iv;

		public static Delegates.Uniform3iv Uniform3iv;

		public static Delegates.Uniform4iv Uniform4iv;

		public static Delegates.UniformMatrix2fv UniformMatrix2fv;

		public static Delegates.UniformMatrix3fv UniformMatrix3fv;

		public static Delegates.UniformMatrix4fv UniformMatrix4fv;

		public static Delegates.ValidateProgram ValidateProgram;

		public static Delegates.VertexAttrib1d VertexAttrib1d;

		public static Delegates.VertexAttrib1dv VertexAttrib1dv;

		public static Delegates.VertexAttrib1f VertexAttrib1f;

		public static Delegates.VertexAttrib1fv VertexAttrib1fv;

		public static Delegates.VertexAttrib1s VertexAttrib1s;

		public static Delegates.VertexAttrib1sv VertexAttrib1sv;

		public static Delegates.VertexAttrib2d VertexAttrib2d;

		public static Delegates.VertexAttrib2dv VertexAttrib2dv;

		public static Delegates.VertexAttrib2f VertexAttrib2f;

		public static Delegates.VertexAttrib2fv VertexAttrib2fv;

		public static Delegates.VertexAttrib2s VertexAttrib2s;

		public static Delegates.VertexAttrib2sv VertexAttrib2sv;

		public static Delegates.VertexAttrib3d VertexAttrib3d;

		public static Delegates.VertexAttrib3dv VertexAttrib3dv;

		public static Delegates.VertexAttrib3f VertexAttrib3f;

		public static Delegates.VertexAttrib3fv VertexAttrib3fv;

		public static Delegates.VertexAttrib3s VertexAttrib3s;

		public static Delegates.VertexAttrib3sv VertexAttrib3sv;

		public static Delegates.VertexAttrib4Nbv VertexAttrib4Nbv;

		public static Delegates.VertexAttrib4Niv VertexAttrib4Niv;

		public static Delegates.VertexAttrib4Nsv VertexAttrib4Nsv;

		public static Delegates.VertexAttrib4Nub VertexAttrib4Nub;

		public static Delegates.VertexAttrib4Nubv VertexAttrib4Nubv;

		public static Delegates.VertexAttrib4Nuiv VertexAttrib4Nuiv;

		public static Delegates.VertexAttrib4Nusv VertexAttrib4Nusv;

		public static Delegates.VertexAttrib4bv VertexAttrib4bv;

		public static Delegates.VertexAttrib4d VertexAttrib4d;

		public static Delegates.VertexAttrib4dv VertexAttrib4dv;

		public static Delegates.VertexAttrib4f VertexAttrib4f;

		public static Delegates.VertexAttrib4fv VertexAttrib4fv;

		public static Delegates.VertexAttrib4iv VertexAttrib4iv;

		public static Delegates.VertexAttrib4s VertexAttrib4s;

		public static Delegates.VertexAttrib4sv VertexAttrib4sv;

		public static Delegates.VertexAttrib4ubv VertexAttrib4ubv;

		public static Delegates.VertexAttrib4uiv VertexAttrib4uiv;

		public static Delegates.VertexAttrib4usv VertexAttrib4usv;

		public static Delegates.VertexAttribPointer VertexAttribPointer;

		public static Delegates.UniformMatrix2x3fv UniformMatrix2x3fv;

		public static Delegates.UniformMatrix3x2fv UniformMatrix3x2fv;

		public static Delegates.UniformMatrix2x4fv UniformMatrix2x4fv;

		public static Delegates.UniformMatrix4x2fv UniformMatrix4x2fv;

		public static Delegates.UniformMatrix3x4fv UniformMatrix3x4fv;

		public static Delegates.UniformMatrix4x3fv UniformMatrix4x3fv;

		public static Delegates.ColorMaski ColorMaski;

		public static Delegates.GetBooleani_v GetBooleani_v;

		public static Delegates.GetIntegeri_v GetIntegeri_v;

		public static Delegates.Enablei Enablei;

		public static Delegates.Disablei Disablei;

		public static Delegates.IsEnabledi IsEnabledi;

		public static Delegates.BeginTransformFeedback BeginTransformFeedback;

		public static Delegates.EndTransformFeedback EndTransformFeedback;

		public static Delegates.BindBufferRange BindBufferRange;

		public static Delegates.BindBufferBase BindBufferBase;

		public static Delegates.TransformFeedbackVaryings TransformFeedbackVaryings;

		public static Delegates.GetTransformFeedbackVarying GetTransformFeedbackVarying;

		public static Delegates.ClampColor ClampColor;

		public static Delegates.BeginConditionalRender BeginConditionalRender;

		public static Delegates.EndConditionalRender EndConditionalRender;

		public static Delegates.VertexAttribIPointer VertexAttribIPointer;

		public static Delegates.GetVertexAttribIiv GetVertexAttribIiv;

		public static Delegates.GetVertexAttribIuiv GetVertexAttribIuiv;

		public static Delegates.VertexAttribI1i VertexAttribI1i;

		public static Delegates.VertexAttribI2i VertexAttribI2i;

		public static Delegates.VertexAttribI3i VertexAttribI3i;

		public static Delegates.VertexAttribI4i VertexAttribI4i;

		public static Delegates.VertexAttribI1ui VertexAttribI1ui;

		public static Delegates.VertexAttribI2ui VertexAttribI2ui;

		public static Delegates.VertexAttribI3ui VertexAttribI3ui;

		public static Delegates.VertexAttribI4ui VertexAttribI4ui;

		public static Delegates.VertexAttribI1iv VertexAttribI1iv;

		public static Delegates.VertexAttribI2iv VertexAttribI2iv;

		public static Delegates.VertexAttribI3iv VertexAttribI3iv;

		public static Delegates.VertexAttribI4iv VertexAttribI4iv;

		public static Delegates.VertexAttribI1uiv VertexAttribI1uiv;

		public static Delegates.VertexAttribI2uiv VertexAttribI2uiv;

		public static Delegates.VertexAttribI3uiv VertexAttribI3uiv;

		public static Delegates.VertexAttribI4uiv VertexAttribI4uiv;

		public static Delegates.VertexAttribI4bv VertexAttribI4bv;

		public static Delegates.VertexAttribI4sv VertexAttribI4sv;

		public static Delegates.VertexAttribI4ubv VertexAttribI4ubv;

		public static Delegates.VertexAttribI4usv VertexAttribI4usv;

		public static Delegates.GetUniformuiv GetUniformuiv;

		public static Delegates.BindFragDataLocation BindFragDataLocation;

		public static Delegates.GetFragDataLocation GetFragDataLocation;

		public static Delegates.Uniform1ui Uniform1ui;

		public static Delegates.Uniform2ui Uniform2ui;

		public static Delegates.Uniform3ui Uniform3ui;

		public static Delegates.Uniform4ui Uniform4ui;

		public static Delegates.Uniform1uiv Uniform1uiv;

		public static Delegates.Uniform2uiv Uniform2uiv;

		public static Delegates.Uniform3uiv Uniform3uiv;

		public static Delegates.Uniform4uiv Uniform4uiv;

		public static Delegates.TexParameterIiv TexParameterIiv;

		public static Delegates.TexParameterIuiv TexParameterIuiv;

		public static Delegates.GetTexParameterIiv GetTexParameterIiv;

		public static Delegates.GetTexParameterIuiv GetTexParameterIuiv;

		public static Delegates.ClearBufferiv ClearBufferiv;

		public static Delegates.ClearBufferuiv ClearBufferuiv;

		public static Delegates.ClearBufferfv ClearBufferfv;

		public static Delegates.ClearBufferfi ClearBufferfi;

		public static Delegates.GetStringi GetStringi;

		public static Delegates.IsRenderbuffer IsRenderbuffer;

		public static Delegates.BindRenderbuffer BindRenderbuffer;

		public static Delegates.DeleteRenderbuffers DeleteRenderbuffers;

		public static Delegates.GenRenderbuffers GenRenderbuffers;

		public static Delegates.RenderbufferStorage RenderbufferStorage;

		public static Delegates.GetRenderbufferParameteriv GetRenderbufferParameteriv;

		public static Delegates.IsFramebuffer IsFramebuffer;

		public static Delegates.BindFramebuffer BindFramebuffer;

		public static Delegates.DeleteFramebuffers DeleteFramebuffers;

		public static Delegates.GenFramebuffers GenFramebuffers;

		public static Delegates.CheckFramebufferStatus CheckFramebufferStatus;

		public static Delegates.FramebufferTexture1D FramebufferTexture1D;

		public static Delegates.FramebufferTexture2D FramebufferTexture2D;

		public static Delegates.FramebufferTexture3D FramebufferTexture3D;

		public static Delegates.FramebufferRenderbuffer FramebufferRenderbuffer;

		public static Delegates.GetFramebufferAttachmentParameteriv GetFramebufferAttachmentParameteriv;

		public static Delegates.GenerateMipmap GenerateMipmap;

		public static Delegates.BlitFramebuffer BlitFramebuffer;

		public static Delegates.RenderbufferStorageMultisample RenderbufferStorageMultisample;

		public static Delegates.FramebufferTextureLayer FramebufferTextureLayer;

		public static Delegates.MapBufferRange MapBufferRange;

		public static Delegates.FlushMappedBufferRange FlushMappedBufferRange;

		public static Delegates.BindVertexArray BindVertexArray;

		public static Delegates.DeleteVertexArrays DeleteVertexArrays;

		public static Delegates.GenVertexArrays GenVertexArrays;

		public static Delegates.IsVertexArray IsVertexArray;

		public static Delegates.DrawArraysInstanced DrawArraysInstanced;

		public static Delegates.DrawElementsInstanced DrawElementsInstanced;

		public static Delegates.TexBuffer TexBuffer;

		public static Delegates.PrimitiveRestartIndex PrimitiveRestartIndex;

		public static Delegates.CopyBufferSubData CopyBufferSubData;

		public static Delegates.GetUniformIndices GetUniformIndices;

		public static Delegates.GetActiveUniformsiv GetActiveUniformsiv;

		public static Delegates.GetActiveUniformName GetActiveUniformName;

		public static Delegates.GetUniformBlockIndex GetUniformBlockIndex;

		public static Delegates.GetActiveUniformBlockiv GetActiveUniformBlockiv;

		public static Delegates.GetActiveUniformBlockName GetActiveUniformBlockName;

		public static Delegates.UniformBlockBinding UniformBlockBinding;

		public static Delegates.DrawElementsBaseVertex DrawElementsBaseVertex;

		public static Delegates.DrawRangeElementsBaseVertex DrawRangeElementsBaseVertex;

		public static Delegates.DrawElementsInstancedBaseVertex DrawElementsInstancedBaseVertex;

		public static Delegates.MultiDrawElementsBaseVertex MultiDrawElementsBaseVertex;

		public static Delegates.ProvokingVertex ProvokingVertex;

		public static Delegates.FenceSync FenceSync;

		public static Delegates.IsSync IsSync;

		public static Delegates.DeleteSync DeleteSync;

		public static Delegates.ClientWaitSync ClientWaitSync;

		public static Delegates.WaitSync WaitSync;

		public static Delegates.GetInteger64v GetInteger64v;

		public static Delegates.GetSynciv GetSynciv;

		public static Delegates.GetInteger64i_v GetInteger64i_v;

		public static Delegates.GetBufferParameteri64v GetBufferParameteri64v;

		public static Delegates.FramebufferTexture FramebufferTexture;

		public static Delegates.TexImage2DMultisample TexImage2DMultisample;

		public static Delegates.TexImage3DMultisample TexImage3DMultisample;

		public static Delegates.GetMultisamplefv GetMultisamplefv;

		public static Delegates.SampleMaski SampleMaski;

		public static Delegates.BindFragDataLocationIndexed BindFragDataLocationIndexed;

		public static Delegates.GetFragDataIndex GetFragDataIndex;

		public static Delegates.GenSamplers GenSamplers;

		public static Delegates.DeleteSamplers DeleteSamplers;

		public static Delegates.IsSampler IsSampler;

		public static Delegates.BindSampler BindSampler;

		public static Delegates.SamplerParameteri SamplerParameteri;

		public static Delegates.SamplerParameteriv SamplerParameteriv;

		public static Delegates.SamplerParameterf SamplerParameterf;

		public static Delegates.SamplerParameterfv SamplerParameterfv;

		public static Delegates.SamplerParameterIiv SamplerParameterIiv;

		public static Delegates.SamplerParameterIuiv SamplerParameterIuiv;

		public static Delegates.GetSamplerParameteriv GetSamplerParameteriv;

		public static Delegates.GetSamplerParameterIiv GetSamplerParameterIiv;

		public static Delegates.GetSamplerParameterfv GetSamplerParameterfv;

		public static Delegates.GetSamplerParameterIuiv GetSamplerParameterIuiv;

		public static Delegates.QueryCounter QueryCounter;

		public static Delegates.GetQueryObjecti64v GetQueryObjecti64v;

		public static Delegates.GetQueryObjectui64v GetQueryObjectui64v;

		public static Delegates.VertexAttribDivisor VertexAttribDivisor;

		public static Delegates.VertexAttribP1ui VertexAttribP1ui;

		public static Delegates.VertexAttribP1uiv VertexAttribP1uiv;

		public static Delegates.VertexAttribP2ui VertexAttribP2ui;

		public static Delegates.VertexAttribP2uiv VertexAttribP2uiv;

		public static Delegates.VertexAttribP3ui VertexAttribP3ui;

		public static Delegates.VertexAttribP3uiv VertexAttribP3uiv;

		public static Delegates.VertexAttribP4ui VertexAttribP4ui;

		public static Delegates.VertexAttribP4uiv VertexAttribP4uiv;

		public static Delegates.MinSampleShading MinSampleShading;

		public static Delegates.BlendEquationi BlendEquationi;

		public static Delegates.BlendEquationSeparatei BlendEquationSeparatei;

		public static Delegates.BlendFunci BlendFunci;

		public static Delegates.BlendFuncSeparatei BlendFuncSeparatei;

		public static Delegates.DrawArraysIndirect DrawArraysIndirect;

		public static Delegates.DrawElementsIndirect DrawElementsIndirect;

		public static Delegates.Uniform1d Uniform1d;

		public static Delegates.Uniform2d Uniform2d;

		public static Delegates.Uniform3d Uniform3d;

		public static Delegates.Uniform4d Uniform4d;

		public static Delegates.Uniform1dv Uniform1dv;

		public static Delegates.Uniform2dv Uniform2dv;

		public static Delegates.Uniform3dv Uniform3dv;

		public static Delegates.Uniform4dv Uniform4dv;

		public static Delegates.UniformMatrix2dv UniformMatrix2dv;

		public static Delegates.UniformMatrix3dv UniformMatrix3dv;

		public static Delegates.UniformMatrix4dv UniformMatrix4dv;

		public static Delegates.UniformMatrix2x3dv UniformMatrix2x3dv;

		public static Delegates.UniformMatrix2x4dv UniformMatrix2x4dv;

		public static Delegates.UniformMatrix3x2dv UniformMatrix3x2dv;

		public static Delegates.UniformMatrix3x4dv UniformMatrix3x4dv;

		public static Delegates.UniformMatrix4x2dv UniformMatrix4x2dv;

		public static Delegates.UniformMatrix4x3dv UniformMatrix4x3dv;

		public static Delegates.GetUniformdv GetUniformdv;

		public static Delegates.GetSubroutineUniformLocation GetSubroutineUniformLocation;

		public static Delegates.GetSubroutineIndex GetSubroutineIndex;

		public static Delegates.GetActiveSubroutineUniformiv GetActiveSubroutineUniformiv;

		public static Delegates.GetActiveSubroutineUniformName GetActiveSubroutineUniformName;

		public static Delegates.GetActiveSubroutineName GetActiveSubroutineName;

		public static Delegates.UniformSubroutinesuiv UniformSubroutinesuiv;

		public static Delegates.GetUniformSubroutineuiv GetUniformSubroutineuiv;

		public static Delegates.GetProgramStageiv GetProgramStageiv;

		public static Delegates.PatchParameteri PatchParameteri;

		public static Delegates.PatchParameterfv PatchParameterfv;

		public static Delegates.BindTransformFeedback BindTransformFeedback;

		public static Delegates.DeleteTransformFeedbacks DeleteTransformFeedbacks;

		public static Delegates.GenTransformFeedbacks GenTransformFeedbacks;

		public static Delegates.IsTransformFeedback IsTransformFeedback;

		public static Delegates.PauseTransformFeedback PauseTransformFeedback;

		public static Delegates.ResumeTransformFeedback ResumeTransformFeedback;

		public static Delegates.DrawTransformFeedback DrawTransformFeedback;

		public static Delegates.DrawTransformFeedbackStream DrawTransformFeedbackStream;

		public static Delegates.BeginQueryIndexed BeginQueryIndexed;

		public static Delegates.EndQueryIndexed EndQueryIndexed;

		public static Delegates.GetQueryIndexediv GetQueryIndexediv;

		public static Delegates.ReleaseShaderCompiler ReleaseShaderCompiler;

		public static Delegates.ShaderBinary ShaderBinary;

		public static Delegates.GetShaderPrecisionFormat GetShaderPrecisionFormat;

		public static Delegates.DepthRangef DepthRangef;

		public static Delegates.ClearDepthf ClearDepthf;

		public static Delegates.GetProgramBinary GetProgramBinary;

		public static Delegates.ProgramBinary ProgramBinary;

		public static Delegates.ProgramParameteri ProgramParameteri;

		public static Delegates.UseProgramStages UseProgramStages;

		public static Delegates.ActiveShaderProgram ActiveShaderProgram;

		public static Delegates.CreateShaderProgramv CreateShaderProgramv;

		public static Delegates.BindProgramPipeline BindProgramPipeline;

		public static Delegates.DeleteProgramPipelines DeleteProgramPipelines;

		public static Delegates.GenProgramPipelines GenProgramPipelines;

		public static Delegates.IsProgramPipeline IsProgramPipeline;

		public static Delegates.GetProgramPipelineiv GetProgramPipelineiv;

		public static Delegates.ProgramUniform1i ProgramUniform1i;

		public static Delegates.ProgramUniform1iv ProgramUniform1iv;

		public static Delegates.ProgramUniform1f ProgramUniform1f;

		public static Delegates.ProgramUniform1fv ProgramUniform1fv;

		public static Delegates.ProgramUniform1d ProgramUniform1d;

		public static Delegates.ProgramUniform1dv ProgramUniform1dv;

		public static Delegates.ProgramUniform1ui ProgramUniform1ui;

		public static Delegates.ProgramUniform1uiv ProgramUniform1uiv;

		public static Delegates.ProgramUniform2i ProgramUniform2i;

		public static Delegates.ProgramUniform2iv ProgramUniform2iv;

		public static Delegates.ProgramUniform2f ProgramUniform2f;

		public static Delegates.ProgramUniform2fv ProgramUniform2fv;

		public static Delegates.ProgramUniform2d ProgramUniform2d;

		public static Delegates.ProgramUniform2dv ProgramUniform2dv;

		public static Delegates.ProgramUniform2ui ProgramUniform2ui;

		public static Delegates.ProgramUniform2uiv ProgramUniform2uiv;

		public static Delegates.ProgramUniform3i ProgramUniform3i;

		public static Delegates.ProgramUniform3iv ProgramUniform3iv;

		public static Delegates.ProgramUniform3f ProgramUniform3f;

		public static Delegates.ProgramUniform3fv ProgramUniform3fv;

		public static Delegates.ProgramUniform3d ProgramUniform3d;

		public static Delegates.ProgramUniform3dv ProgramUniform3dv;

		public static Delegates.ProgramUniform3ui ProgramUniform3ui;

		public static Delegates.ProgramUniform3uiv ProgramUniform3uiv;

		public static Delegates.ProgramUniform4i ProgramUniform4i;

		public static Delegates.ProgramUniform4iv ProgramUniform4iv;

		public static Delegates.ProgramUniform4f ProgramUniform4f;

		public static Delegates.ProgramUniform4fv ProgramUniform4fv;

		public static Delegates.ProgramUniform4d ProgramUniform4d;

		public static Delegates.ProgramUniform4dv ProgramUniform4dv;

		public static Delegates.ProgramUniform4ui ProgramUniform4ui;

		public static Delegates.ProgramUniform4uiv ProgramUniform4uiv;

		public static Delegates.ProgramUniformMatrix2fv ProgramUniformMatrix2fv;

		public static Delegates.ProgramUniformMatrix3fv ProgramUniformMatrix3fv;

		public static Delegates.ProgramUniformMatrix4fv ProgramUniformMatrix4fv;

		public static Delegates.ProgramUniformMatrix2dv ProgramUniformMatrix2dv;

		public static Delegates.ProgramUniformMatrix3dv ProgramUniformMatrix3dv;

		public static Delegates.ProgramUniformMatrix4dv ProgramUniformMatrix4dv;

		public static Delegates.ProgramUniformMatrix2x3fv ProgramUniformMatrix2x3fv;

		public static Delegates.ProgramUniformMatrix3x2fv ProgramUniformMatrix3x2fv;

		public static Delegates.ProgramUniformMatrix2x4fv ProgramUniformMatrix2x4fv;

		public static Delegates.ProgramUniformMatrix4x2fv ProgramUniformMatrix4x2fv;

		public static Delegates.ProgramUniformMatrix3x4fv ProgramUniformMatrix3x4fv;

		public static Delegates.ProgramUniformMatrix4x3fv ProgramUniformMatrix4x3fv;

		public static Delegates.ProgramUniformMatrix2x3dv ProgramUniformMatrix2x3dv;

		public static Delegates.ProgramUniformMatrix3x2dv ProgramUniformMatrix3x2dv;

		public static Delegates.ProgramUniformMatrix2x4dv ProgramUniformMatrix2x4dv;

		public static Delegates.ProgramUniformMatrix4x2dv ProgramUniformMatrix4x2dv;

		public static Delegates.ProgramUniformMatrix3x4dv ProgramUniformMatrix3x4dv;

		public static Delegates.ProgramUniformMatrix4x3dv ProgramUniformMatrix4x3dv;

		public static Delegates.ValidateProgramPipeline ValidateProgramPipeline;

		public static Delegates.GetProgramPipelineInfoLog GetProgramPipelineInfoLog;

		public static Delegates.VertexAttribL1d VertexAttribL1d;

		public static Delegates.VertexAttribL2d VertexAttribL2d;

		public static Delegates.VertexAttribL3d VertexAttribL3d;

		public static Delegates.VertexAttribL4d VertexAttribL4d;

		public static Delegates.VertexAttribL1dv VertexAttribL1dv;

		public static Delegates.VertexAttribL2dv VertexAttribL2dv;

		public static Delegates.VertexAttribL3dv VertexAttribL3dv;

		public static Delegates.VertexAttribL4dv VertexAttribL4dv;

		public static Delegates.VertexAttribLPointer VertexAttribLPointer;

		public static Delegates.GetVertexAttribLdv GetVertexAttribLdv;

		public static Delegates.ViewportArrayv ViewportArrayv;

		public static Delegates.ViewportIndexedf ViewportIndexedf;

		public static Delegates.ViewportIndexedfv ViewportIndexedfv;

		public static Delegates.ScissorArrayv ScissorArrayv;

		public static Delegates.ScissorIndexed ScissorIndexed;

		public static Delegates.ScissorIndexedv ScissorIndexedv;

		public static Delegates.DepthRangeArrayv DepthRangeArrayv;

		public static Delegates.DepthRangeIndexed DepthRangeIndexed;

		public static Delegates.GetFloati_v GetFloati_v;

		public static Delegates.GetDoublei_v GetDoublei_v;

		public static Delegates.DrawArraysInstancedBaseInstance DrawArraysInstancedBaseInstance;

		public static Delegates.DrawElementsInstancedBaseInstance DrawElementsInstancedBaseInstance;

		public static Delegates.DrawElementsInstancedBaseVertexBaseInstance DrawElementsInstancedBaseVertexBaseInstance;

		public static Delegates.GetInternalformativ GetInternalformativ;

		public static Delegates.GetActiveAtomicCounterBufferiv GetActiveAtomicCounterBufferiv;

		public static Delegates.BindImageTexture BindImageTexture;

		public static Delegates.MemoryBarrier MemoryBarrier;

		public static Delegates.TexStorage1D TexStorage1D;

		public static Delegates.TexStorage2D TexStorage2D;

		public static Delegates.TexStorage3D TexStorage3D;

		public static Delegates.DrawTransformFeedbackInstanced DrawTransformFeedbackInstanced;

		public static Delegates.DrawTransformFeedbackStreamInstanced DrawTransformFeedbackStreamInstanced;

		public static Delegates.ClearBufferData ClearBufferData;

		public static Delegates.ClearBufferSubData ClearBufferSubData;

		public static Delegates.DispatchCompute DispatchCompute;

		public static Delegates.DispatchComputeIndirect DispatchComputeIndirect;

		public static Delegates.CopyImageSubData CopyImageSubData;

		public static Delegates.FramebufferParameteri FramebufferParameteri;

		public static Delegates.GetFramebufferParameteriv GetFramebufferParameteriv;

		public static Delegates.GetInternalformati64v GetInternalformati64v;

		public static Delegates.InvalidateTexSubImage InvalidateTexSubImage;

		public static Delegates.InvalidateTexImage InvalidateTexImage;

		public static Delegates.InvalidateBufferSubData InvalidateBufferSubData;

		public static Delegates.InvalidateBufferData InvalidateBufferData;

		public static Delegates.InvalidateFramebuffer InvalidateFramebuffer;

		public static Delegates.InvalidateSubFramebuffer InvalidateSubFramebuffer;

		public static Delegates.MultiDrawArraysIndirect MultiDrawArraysIndirect;

		public static Delegates.MultiDrawElementsIndirect MultiDrawElementsIndirect;

		public static Delegates.GetProgramInterfaceiv GetProgramInterfaceiv;

		public static Delegates.GetProgramResourceIndex GetProgramResourceIndex;

		public static Delegates.GetProgramResourceName GetProgramResourceName;

		public static Delegates.GetProgramResourceiv GetProgramResourceiv;

		public static Delegates.GetProgramResourceLocation GetProgramResourceLocation;

		public static Delegates.GetProgramResourceLocationIndex GetProgramResourceLocationIndex;

		public static Delegates.ShaderStorageBlockBinding ShaderStorageBlockBinding;

		public static Delegates.TexBufferRange TexBufferRange;

		public static Delegates.TexStorage2DMultisample TexStorage2DMultisample;

		public static Delegates.TexStorage3DMultisample TexStorage3DMultisample;

		public static Delegates.TextureView TextureView;

		public static Delegates.BindVertexBuffer BindVertexBuffer;

		public static Delegates.VertexAttribFormat VertexAttribFormat;

		public static Delegates.VertexAttribIFormat VertexAttribIFormat;

		public static Delegates.VertexAttribLFormat VertexAttribLFormat;

		public static Delegates.VertexAttribBinding VertexAttribBinding;

		public static Delegates.VertexBindingDivisor VertexBindingDivisor;

		public static Delegates.DebugMessageControl DebugMessageControl;

		public static Delegates.DebugMessageInsert DebugMessageInsert;

		public static Delegates.DebugMessageCallback DebugMessageCallback;

		public static Delegates.GetDebugMessageLog GetDebugMessageLog;

		public static Delegates.PushDebugGroup PushDebugGroup;

		public static Delegates.PopDebugGroup PopDebugGroup;

		public static Delegates.ObjectLabel ObjectLabel;

		public static Delegates.GetObjectLabel GetObjectLabel;

		public static Delegates.ObjectPtrLabel ObjectPtrLabel;

		public static Delegates.GetObjectPtrLabel GetObjectPtrLabel;

		public static Delegates.BufferStorage BufferStorage;

		public static Delegates.ClearTexImage ClearTexImage;

		public static Delegates.ClearTexSubImage ClearTexSubImage;

		public static Delegates.BindBuffersBase BindBuffersBase;

		public static Delegates.BindBuffersRange BindBuffersRange;

		public static Delegates.BindTextures BindTextures;

		public static Delegates.BindSamplers BindSamplers;

		public static Delegates.BindImageTextures BindImageTextures;

		public static Delegates.BindVertexBuffers BindVertexBuffers;

		public static Delegates.ClipControl ClipControl;

		public static Delegates.CreateTransformFeedbacks CreateTransformFeedbacks;

		public static Delegates.TransformFeedbackBufferBase TransformFeedbackBufferBase;

		public static Delegates.TransformFeedbackBufferRange TransformFeedbackBufferRange;

		public static Delegates.GetTransformFeedbackiv GetTransformFeedbackiv;

		public static Delegates.GetTransformFeedbacki_v GetTransformFeedbacki_v;

		public static Delegates.GetTransformFeedbacki64_v GetTransformFeedbacki64_v;

		public static Delegates.CreateBuffers CreateBuffers;

		public static Delegates.NamedBufferStorage NamedBufferStorage;

		public static Delegates.NamedBufferData NamedBufferData;

		public static Delegates.NamedBufferSubData NamedBufferSubData;

		public static Delegates.CopyNamedBufferSubData CopyNamedBufferSubData;

		public static Delegates.ClearNamedBufferData ClearNamedBufferData;

		public static Delegates.ClearNamedBufferSubData ClearNamedBufferSubData;

		public static Delegates.MapNamedBuffer MapNamedBuffer;

		public static Delegates.MapNamedBufferRange MapNamedBufferRange;

		public static Delegates.UnmapNamedBuffer UnmapNamedBuffer;

		public static Delegates.FlushMappedNamedBufferRange FlushMappedNamedBufferRange;

		public static Delegates.GetNamedBufferParameteriv GetNamedBufferParameteriv;

		public static Delegates.GetNamedBufferParameteri64v GetNamedBufferParameteri64v;

		public static Delegates.GetNamedBufferPointerv GetNamedBufferPointerv;

		public static Delegates.GetNamedBufferSubData GetNamedBufferSubData;

		public static Delegates.CreateFramebuffers CreateFramebuffers;

		public static Delegates.NamedFramebufferRenderbuffer NamedFramebufferRenderbuffer;

		public static Delegates.NamedFramebufferParameteri NamedFramebufferParameteri;

		public static Delegates.NamedFramebufferTexture NamedFramebufferTexture;

		public static Delegates.NamedFramebufferTextureLayer NamedFramebufferTextureLayer;

		public static Delegates.NamedFramebufferDrawBuffer NamedFramebufferDrawBuffer;

		public static Delegates.NamedFramebufferDrawBuffers NamedFramebufferDrawBuffers;

		public static Delegates.NamedFramebufferReadBuffer NamedFramebufferReadBuffer;

		public static Delegates.InvalidateNamedFramebufferData InvalidateNamedFramebufferData;

		public static Delegates.InvalidateNamedFramebufferSubData InvalidateNamedFramebufferSubData;

		public static Delegates.ClearNamedFramebufferiv ClearNamedFramebufferiv;

		public static Delegates.ClearNamedFramebufferuiv ClearNamedFramebufferuiv;

		public static Delegates.ClearNamedFramebufferfv ClearNamedFramebufferfv;

		public static Delegates.ClearNamedFramebufferfi ClearNamedFramebufferfi;

		public static Delegates.BlitNamedFramebuffer BlitNamedFramebuffer;

		public static Delegates.CheckNamedFramebufferStatus CheckNamedFramebufferStatus;

		public static Delegates.GetNamedFramebufferParameteriv GetNamedFramebufferParameteriv;

		public static Delegates.GetNamedFramebufferAttachmentParameteriv GetNamedFramebufferAttachmentParameteriv;

		public static Delegates.CreateRenderbuffers CreateRenderbuffers;

		public static Delegates.NamedRenderbufferStorage NamedRenderbufferStorage;

		public static Delegates.NamedRenderbufferStorageMultisample NamedRenderbufferStorageMultisample;

		public static Delegates.GetNamedRenderbufferParameteriv GetNamedRenderbufferParameteriv;

		public static Delegates.CreateTextures CreateTextures;

		public static Delegates.TextureBuffer TextureBuffer;

		public static Delegates.TextureBufferRange TextureBufferRange;

		public static Delegates.TextureStorage1D TextureStorage1D;

		public static Delegates.TextureStorage2D TextureStorage2D;

		public static Delegates.TextureStorage3D TextureStorage3D;

		public static Delegates.TextureStorage2DMultisample TextureStorage2DMultisample;

		public static Delegates.TextureStorage3DMultisample TextureStorage3DMultisample;

		public static Delegates.TextureSubImage1D TextureSubImage1D;

		public static Delegates.TextureSubImage2D TextureSubImage2D;

		public static Delegates.TextureSubImage3D TextureSubImage3D;

		public static Delegates.CompressedTextureSubImage1D CompressedTextureSubImage1D;

		public static Delegates.CompressedTextureSubImage2D CompressedTextureSubImage2D;

		public static Delegates.CompressedTextureSubImage3D CompressedTextureSubImage3D;

		public static Delegates.CopyTextureSubImage1D CopyTextureSubImage1D;

		public static Delegates.CopyTextureSubImage2D CopyTextureSubImage2D;

		public static Delegates.CopyTextureSubImage3D CopyTextureSubImage3D;

		public static Delegates.TextureParameterf TextureParameterf;

		public static Delegates.TextureParameterfv TextureParameterfv;

		public static Delegates.TextureParameteri TextureParameteri;

		public static Delegates.TextureParameterIiv TextureParameterIiv;

		public static Delegates.TextureParameterIuiv TextureParameterIuiv;

		public static Delegates.TextureParameteriv TextureParameteriv;

		public static Delegates.GenerateTextureMipmap GenerateTextureMipmap;

		public static Delegates.BindTextureUnit BindTextureUnit;

		public static Delegates.GetTextureImage GetTextureImage;

		public static Delegates.GetCompressedTextureImage GetCompressedTextureImage;

		public static Delegates.GetTextureLevelParameterfv GetTextureLevelParameterfv;

		public static Delegates.GetTextureLevelParameteriv GetTextureLevelParameteriv;

		public static Delegates.GetTextureParameterfv GetTextureParameterfv;

		public static Delegates.GetTextureParameterIiv GetTextureParameterIiv;

		public static Delegates.GetTextureParameterIuiv GetTextureParameterIuiv;

		public static Delegates.GetTextureParameteriv GetTextureParameteriv;

		public static Delegates.CreateVertexArrays CreateVertexArrays;

		public static Delegates.DisableVertexArrayAttrib DisableVertexArrayAttrib;

		public static Delegates.EnableVertexArrayAttrib EnableVertexArrayAttrib;

		public static Delegates.VertexArrayElementBuffer VertexArrayElementBuffer;

		public static Delegates.VertexArrayVertexBuffer VertexArrayVertexBuffer;

		public static Delegates.VertexArrayVertexBuffers VertexArrayVertexBuffers;

		public static Delegates.VertexArrayAttribBinding VertexArrayAttribBinding;

		public static Delegates.VertexArrayAttribFormat VertexArrayAttribFormat;

		public static Delegates.VertexArrayAttribIFormat VertexArrayAttribIFormat;

		public static Delegates.VertexArrayAttribLFormat VertexArrayAttribLFormat;

		public static Delegates.VertexArrayBindingDivisor VertexArrayBindingDivisor;

		public static Delegates.GetVertexArrayiv GetVertexArrayiv;

		public static Delegates.GetVertexArrayIndexediv GetVertexArrayIndexediv;

		public static Delegates.GetVertexArrayIndexed64iv GetVertexArrayIndexed64iv;

		public static Delegates.CreateSamplers CreateSamplers;

		public static Delegates.CreateProgramPipelines CreateProgramPipelines;

		public static Delegates.CreateQueries CreateQueries;

		public static Delegates.GetQueryBufferObjecti64v GetQueryBufferObjecti64v;

		public static Delegates.GetQueryBufferObjectiv GetQueryBufferObjectiv;

		public static Delegates.GetQueryBufferObjectui64v GetQueryBufferObjectui64v;

		public static Delegates.GetQueryBufferObjectuiv GetQueryBufferObjectuiv;

		public static Delegates.MemoryBarrierByRegion MemoryBarrierByRegion;

		public static Delegates.GetTextureSubImage GetTextureSubImage;

		public static Delegates.GetCompressedTextureSubImage GetCompressedTextureSubImage;

		public static Delegates.GetGraphicsResetStatus GetGraphicsResetStatus;

		public static Delegates.GetnCompressedTexImage GetnCompressedTexImage;

		public static Delegates.GetnTexImage GetnTexImage;

		public static Delegates.GetnUniformdv GetnUniformdv;

		public static Delegates.GetnUniformfv GetnUniformfv;

		public static Delegates.GetnUniformiv GetnUniformiv;

		public static Delegates.GetnUniformuiv GetnUniformuiv;

		public static Delegates.ReadnPixels ReadnPixels;

		public static Delegates.TextureBarrier TextureBarrier;

		public static void Initialize(Func<string, IntPtr> getProcAddress, int versionMajor, int versionMinor)
		{
			if (getProcAddress == null) throw new ArgumentNullException(nameof(getProcAddress));

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 0))
			{
				CullFace = (Delegates.CullFace)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCullFace"), typeof(Delegates.CullFace));
				FrontFace = (Delegates.FrontFace)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFrontFace"), typeof(Delegates.FrontFace));
				Hint = (Delegates.Hint)Marshal.GetDelegateForFunctionPointer(getProcAddress("glHint"), typeof(Delegates.Hint));
				LineWidth = (Delegates.LineWidth)Marshal.GetDelegateForFunctionPointer(getProcAddress("glLineWidth"), typeof(Delegates.LineWidth));
				PointSize = (Delegates.PointSize)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointSize"), typeof(Delegates.PointSize));
				PolygonMode = (Delegates.PolygonMode)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPolygonMode"), typeof(Delegates.PolygonMode));
				Scissor = (Delegates.Scissor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissor"), typeof(Delegates.Scissor));
				TexParameterf = (Delegates.TexParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterf"), typeof(Delegates.TexParameterf));
				TexParameterfv = (Delegates.TexParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterfv"), typeof(Delegates.TexParameterfv));
				TexParameteri = (Delegates.TexParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameteri"), typeof(Delegates.TexParameteri));
				TexParameteriv = (Delegates.TexParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameteriv"), typeof(Delegates.TexParameteriv));
				TexImage1D = (Delegates.TexImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage1D"), typeof(Delegates.TexImage1D));
				TexImage2D = (Delegates.TexImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage2D"), typeof(Delegates.TexImage2D));
				DrawBuffer = (Delegates.DrawBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawBuffer"), typeof(Delegates.DrawBuffer));
				Clear = (Delegates.Clear)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClear"), typeof(Delegates.Clear));
				ClearColor = (Delegates.ClearColor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearColor"), typeof(Delegates.ClearColor));
				ClearStencil = (Delegates.ClearStencil)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearStencil"), typeof(Delegates.ClearStencil));
				ClearDepth = (Delegates.ClearDepth)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearDepth"), typeof(Delegates.ClearDepth));
				StencilMask = (Delegates.StencilMask)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilMask"), typeof(Delegates.StencilMask));
				ColorMask = (Delegates.ColorMask)Marshal.GetDelegateForFunctionPointer(getProcAddress("glColorMask"), typeof(Delegates.ColorMask));
				DepthMask = (Delegates.DepthMask)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthMask"), typeof(Delegates.DepthMask));
				Disable = (Delegates.Disable)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisable"), typeof(Delegates.Disable));
				Enable = (Delegates.Enable)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnable"), typeof(Delegates.Enable));
				Finish = (Delegates.Finish)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFinish"), typeof(Delegates.Finish));
				Flush = (Delegates.Flush)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFlush"), typeof(Delegates.Flush));
				BlendFunc = (Delegates.BlendFunc)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFunc"), typeof(Delegates.BlendFunc));
				LogicOp = (Delegates.LogicOp)Marshal.GetDelegateForFunctionPointer(getProcAddress("glLogicOp"), typeof(Delegates.LogicOp));
				StencilFunc = (Delegates.StencilFunc)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilFunc"), typeof(Delegates.StencilFunc));
				StencilOp = (Delegates.StencilOp)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilOp"), typeof(Delegates.StencilOp));
				DepthFunc = (Delegates.DepthFunc)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthFunc"), typeof(Delegates.DepthFunc));
				PixelStoref = (Delegates.PixelStoref)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPixelStoref"), typeof(Delegates.PixelStoref));
				PixelStorei = (Delegates.PixelStorei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPixelStorei"), typeof(Delegates.PixelStorei));
				ReadBuffer = (Delegates.ReadBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReadBuffer"), typeof(Delegates.ReadBuffer));
				ReadPixels = (Delegates.ReadPixels)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReadPixels"), typeof(Delegates.ReadPixels));
				GetBooleanv = (Delegates.GetBooleanv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBooleanv"), typeof(Delegates.GetBooleanv));
				GetDoublev = (Delegates.GetDoublev)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetDoublev"), typeof(Delegates.GetDoublev));
				GetError = (Delegates.GetError)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetError"), typeof(Delegates.GetError));
				GetFloatv = (Delegates.GetFloatv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFloatv"), typeof(Delegates.GetFloatv));
				GetIntegerv = (Delegates.GetIntegerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetIntegerv"), typeof(Delegates.GetIntegerv));
				GetString = (Delegates.GetString)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetString"), typeof(Delegates.GetString));
				GetTexImage = (Delegates.GetTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexImage"), typeof(Delegates.GetTexImage));
				GetTexParameterfv = (Delegates.GetTexParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameterfv"), typeof(Delegates.GetTexParameterfv));
				GetTexParameteriv = (Delegates.GetTexParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameteriv"), typeof(Delegates.GetTexParameteriv));
				GetTexLevelParameterfv = (Delegates.GetTexLevelParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexLevelParameterfv"), typeof(Delegates.GetTexLevelParameterfv));
				GetTexLevelParameteriv = (Delegates.GetTexLevelParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexLevelParameteriv"), typeof(Delegates.GetTexLevelParameteriv));
				IsEnabled = (Delegates.IsEnabled)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsEnabled"), typeof(Delegates.IsEnabled));
				DepthRange = (Delegates.DepthRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRange"), typeof(Delegates.DepthRange));
				Viewport = (Delegates.Viewport)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewport"), typeof(Delegates.Viewport));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 1))
			{
				DrawArrays = (Delegates.DrawArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArrays"), typeof(Delegates.DrawArrays));
				DrawElements = (Delegates.DrawElements)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElements"), typeof(Delegates.DrawElements));
				GetPointerv = (Delegates.GetPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetPointerv"), typeof(Delegates.GetPointerv));
				PolygonOffset = (Delegates.PolygonOffset)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPolygonOffset"), typeof(Delegates.PolygonOffset));
				CopyTexImage1D = (Delegates.CopyTexImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexImage1D"), typeof(Delegates.CopyTexImage1D));
				CopyTexImage2D = (Delegates.CopyTexImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexImage2D"), typeof(Delegates.CopyTexImage2D));
				CopyTexSubImage1D = (Delegates.CopyTexSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexSubImage1D"), typeof(Delegates.CopyTexSubImage1D));
				CopyTexSubImage2D = (Delegates.CopyTexSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexSubImage2D"), typeof(Delegates.CopyTexSubImage2D));
				TexSubImage1D = (Delegates.TexSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexSubImage1D"), typeof(Delegates.TexSubImage1D));
				TexSubImage2D = (Delegates.TexSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexSubImage2D"), typeof(Delegates.TexSubImage2D));
				BindTexture = (Delegates.BindTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTexture"), typeof(Delegates.BindTexture));
				DeleteTextures = (Delegates.DeleteTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteTextures"), typeof(Delegates.DeleteTextures));
				GenTextures = (Delegates.GenTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenTextures"), typeof(Delegates.GenTextures));
				IsTexture = (Delegates.IsTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsTexture"), typeof(Delegates.IsTexture));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 2))
			{
				DrawRangeElements = (Delegates.DrawRangeElements)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawRangeElements"), typeof(Delegates.DrawRangeElements));
				TexImage3D = (Delegates.TexImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage3D"), typeof(Delegates.TexImage3D));
				TexSubImage3D = (Delegates.TexSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexSubImage3D"), typeof(Delegates.TexSubImage3D));
				CopyTexSubImage3D = (Delegates.CopyTexSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTexSubImage3D"), typeof(Delegates.CopyTexSubImage3D));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 3))
			{
				ActiveTexture = (Delegates.ActiveTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glActiveTexture"), typeof(Delegates.ActiveTexture));
				SampleCoverage = (Delegates.SampleCoverage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSampleCoverage"), typeof(Delegates.SampleCoverage));
				CompressedTexImage3D = (Delegates.CompressedTexImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexImage3D"), typeof(Delegates.CompressedTexImage3D));
				CompressedTexImage2D = (Delegates.CompressedTexImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexImage2D"), typeof(Delegates.CompressedTexImage2D));
				CompressedTexImage1D = (Delegates.CompressedTexImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexImage1D"), typeof(Delegates.CompressedTexImage1D));
				CompressedTexSubImage3D = (Delegates.CompressedTexSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexSubImage3D"), typeof(Delegates.CompressedTexSubImage3D));
				CompressedTexSubImage2D = (Delegates.CompressedTexSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexSubImage2D"), typeof(Delegates.CompressedTexSubImage2D));
				CompressedTexSubImage1D = (Delegates.CompressedTexSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTexSubImage1D"), typeof(Delegates.CompressedTexSubImage1D));
				GetCompressedTexImage = (Delegates.GetCompressedTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetCompressedTexImage"), typeof(Delegates.GetCompressedTexImage));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 4))
			{
				BlendFuncSeparate = (Delegates.BlendFuncSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFuncSeparate"), typeof(Delegates.BlendFuncSeparate));
				MultiDrawArrays = (Delegates.MultiDrawArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawArrays"), typeof(Delegates.MultiDrawArrays));
				MultiDrawElements = (Delegates.MultiDrawElements)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawElements"), typeof(Delegates.MultiDrawElements));
				PointParameterf = (Delegates.PointParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameterf"), typeof(Delegates.PointParameterf));
				PointParameterfv = (Delegates.PointParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameterfv"), typeof(Delegates.PointParameterfv));
				PointParameteri = (Delegates.PointParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameteri"), typeof(Delegates.PointParameteri));
				PointParameteriv = (Delegates.PointParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPointParameteriv"), typeof(Delegates.PointParameteriv));
				BlendColor = (Delegates.BlendColor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendColor"), typeof(Delegates.BlendColor));
				BlendEquation = (Delegates.BlendEquation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquation"), typeof(Delegates.BlendEquation));
			}

			if (versionMajor > 1 || (versionMajor == 1 && versionMinor >= 5))
			{
				GenQueries = (Delegates.GenQueries)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenQueries"), typeof(Delegates.GenQueries));
				DeleteQueries = (Delegates.DeleteQueries)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteQueries"), typeof(Delegates.DeleteQueries));
				IsQuery = (Delegates.IsQuery)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsQuery"), typeof(Delegates.IsQuery));
				BeginQuery = (Delegates.BeginQuery)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginQuery"), typeof(Delegates.BeginQuery));
				EndQuery = (Delegates.EndQuery)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndQuery"), typeof(Delegates.EndQuery));
				GetQueryiv = (Delegates.GetQueryiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryiv"), typeof(Delegates.GetQueryiv));
				GetQueryObjectiv = (Delegates.GetQueryObjectiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjectiv"), typeof(Delegates.GetQueryObjectiv));
				GetQueryObjectuiv = (Delegates.GetQueryObjectuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjectuiv"), typeof(Delegates.GetQueryObjectuiv));
				BindBuffer = (Delegates.BindBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBuffer"), typeof(Delegates.BindBuffer));
				DeleteBuffers = (Delegates.DeleteBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteBuffers"), typeof(Delegates.DeleteBuffers));
				GenBuffers = (Delegates.GenBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenBuffers"), typeof(Delegates.GenBuffers));
				IsBuffer = (Delegates.IsBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsBuffer"), typeof(Delegates.IsBuffer));
				BufferData = (Delegates.BufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBufferData"), typeof(Delegates.BufferData));
				BufferSubData = (Delegates.BufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBufferSubData"), typeof(Delegates.BufferSubData));
				GetBufferSubData = (Delegates.GetBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferSubData"), typeof(Delegates.GetBufferSubData));
				MapBuffer = (Delegates.MapBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapBuffer"), typeof(Delegates.MapBuffer));
				UnmapBuffer = (Delegates.UnmapBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUnmapBuffer"), typeof(Delegates.UnmapBuffer));
				GetBufferParameteriv = (Delegates.GetBufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferParameteriv"), typeof(Delegates.GetBufferParameteriv));
				GetBufferPointerv = (Delegates.GetBufferPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferPointerv"), typeof(Delegates.GetBufferPointerv));
			}

			if (versionMajor > 2 || (versionMajor == 2 && versionMinor >= 0))
			{
				BlendEquationSeparate = (Delegates.BlendEquationSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquationSeparate"), typeof(Delegates.BlendEquationSeparate));
				DrawBuffers = (Delegates.DrawBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawBuffers"), typeof(Delegates.DrawBuffers));
				StencilOpSeparate = (Delegates.StencilOpSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilOpSeparate"), typeof(Delegates.StencilOpSeparate));
				StencilFuncSeparate = (Delegates.StencilFuncSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilFuncSeparate"), typeof(Delegates.StencilFuncSeparate));
				StencilMaskSeparate = (Delegates.StencilMaskSeparate)Marshal.GetDelegateForFunctionPointer(getProcAddress("glStencilMaskSeparate"), typeof(Delegates.StencilMaskSeparate));
				AttachShader = (Delegates.AttachShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glAttachShader"), typeof(Delegates.AttachShader));
				BindAttribLocation = (Delegates.BindAttribLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindAttribLocation"), typeof(Delegates.BindAttribLocation));
				CompileShader = (Delegates.CompileShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompileShader"), typeof(Delegates.CompileShader));
				CreateProgram = (Delegates.CreateProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateProgram"), typeof(Delegates.CreateProgram));
				CreateShader = (Delegates.CreateShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateShader"), typeof(Delegates.CreateShader));
				DeleteProgram = (Delegates.DeleteProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteProgram"), typeof(Delegates.DeleteProgram));
				DeleteShader = (Delegates.DeleteShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteShader"), typeof(Delegates.DeleteShader));
				DetachShader = (Delegates.DetachShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDetachShader"), typeof(Delegates.DetachShader));
				DisableVertexAttribArray = (Delegates.DisableVertexAttribArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisableVertexAttribArray"), typeof(Delegates.DisableVertexAttribArray));
				EnableVertexAttribArray = (Delegates.EnableVertexAttribArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnableVertexAttribArray"), typeof(Delegates.EnableVertexAttribArray));
				GetActiveAttrib = (Delegates.GetActiveAttrib)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveAttrib"), typeof(Delegates.GetActiveAttrib));
				GetActiveUniform = (Delegates.GetActiveUniform)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniform"), typeof(Delegates.GetActiveUniform));
				GetAttachedShaders = (Delegates.GetAttachedShaders)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetAttachedShaders"), typeof(Delegates.GetAttachedShaders));
				GetAttribLocation = (Delegates.GetAttribLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetAttribLocation"), typeof(Delegates.GetAttribLocation));
				GetProgramiv = (Delegates.GetProgramiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramiv"), typeof(Delegates.GetProgramiv));
				GetProgramInfoLog = (Delegates.GetProgramInfoLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramInfoLog"), typeof(Delegates.GetProgramInfoLog));
				GetShaderiv = (Delegates.GetShaderiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderiv"), typeof(Delegates.GetShaderiv));
				GetShaderInfoLog = (Delegates.GetShaderInfoLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderInfoLog"), typeof(Delegates.GetShaderInfoLog));
				GetShaderSource = (Delegates.GetShaderSource)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderSource"), typeof(Delegates.GetShaderSource));
				GetUniformLocation = (Delegates.GetUniformLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformLocation"), typeof(Delegates.GetUniformLocation));
				GetUniformfv = (Delegates.GetUniformfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformfv"), typeof(Delegates.GetUniformfv));
				GetUniformiv = (Delegates.GetUniformiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformiv"), typeof(Delegates.GetUniformiv));
				GetVertexAttribdv = (Delegates.GetVertexAttribdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribdv"), typeof(Delegates.GetVertexAttribdv));
				GetVertexAttribfv = (Delegates.GetVertexAttribfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribfv"), typeof(Delegates.GetVertexAttribfv));
				GetVertexAttribiv = (Delegates.GetVertexAttribiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribiv"), typeof(Delegates.GetVertexAttribiv));
				GetVertexAttribPointerv = (Delegates.GetVertexAttribPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribPointerv"), typeof(Delegates.GetVertexAttribPointerv));
				IsProgram = (Delegates.IsProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsProgram"), typeof(Delegates.IsProgram));
				IsShader = (Delegates.IsShader)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsShader"), typeof(Delegates.IsShader));
				LinkProgram = (Delegates.LinkProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glLinkProgram"), typeof(Delegates.LinkProgram));
				ShaderSource = (Delegates.ShaderSource)Marshal.GetDelegateForFunctionPointer(getProcAddress("glShaderSource"), typeof(Delegates.ShaderSource));
				UseProgram = (Delegates.UseProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUseProgram"), typeof(Delegates.UseProgram));
				Uniform1f = (Delegates.Uniform1f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1f"), typeof(Delegates.Uniform1f));
				Uniform2f = (Delegates.Uniform2f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2f"), typeof(Delegates.Uniform2f));
				Uniform3f = (Delegates.Uniform3f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3f"), typeof(Delegates.Uniform3f));
				Uniform4f = (Delegates.Uniform4f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4f"), typeof(Delegates.Uniform4f));
				Uniform1i = (Delegates.Uniform1i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1i"), typeof(Delegates.Uniform1i));
				Uniform2i = (Delegates.Uniform2i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2i"), typeof(Delegates.Uniform2i));
				Uniform3i = (Delegates.Uniform3i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3i"), typeof(Delegates.Uniform3i));
				Uniform4i = (Delegates.Uniform4i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4i"), typeof(Delegates.Uniform4i));
				Uniform1fv = (Delegates.Uniform1fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1fv"), typeof(Delegates.Uniform1fv));
				Uniform2fv = (Delegates.Uniform2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2fv"), typeof(Delegates.Uniform2fv));
				Uniform3fv = (Delegates.Uniform3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3fv"), typeof(Delegates.Uniform3fv));
				Uniform4fv = (Delegates.Uniform4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4fv"), typeof(Delegates.Uniform4fv));
				Uniform1iv = (Delegates.Uniform1iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1iv"), typeof(Delegates.Uniform1iv));
				Uniform2iv = (Delegates.Uniform2iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2iv"), typeof(Delegates.Uniform2iv));
				Uniform3iv = (Delegates.Uniform3iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3iv"), typeof(Delegates.Uniform3iv));
				Uniform4iv = (Delegates.Uniform4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4iv"), typeof(Delegates.Uniform4iv));
				UniformMatrix2fv = (Delegates.UniformMatrix2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2fv"), typeof(Delegates.UniformMatrix2fv));
				UniformMatrix3fv = (Delegates.UniformMatrix3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3fv"), typeof(Delegates.UniformMatrix3fv));
				UniformMatrix4fv = (Delegates.UniformMatrix4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4fv"), typeof(Delegates.UniformMatrix4fv));
				ValidateProgram = (Delegates.ValidateProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glValidateProgram"), typeof(Delegates.ValidateProgram));
				VertexAttrib1d = (Delegates.VertexAttrib1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1d"), typeof(Delegates.VertexAttrib1d));
				VertexAttrib1dv = (Delegates.VertexAttrib1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1dv"), typeof(Delegates.VertexAttrib1dv));
				VertexAttrib1f = (Delegates.VertexAttrib1f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1f"), typeof(Delegates.VertexAttrib1f));
				VertexAttrib1fv = (Delegates.VertexAttrib1fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1fv"), typeof(Delegates.VertexAttrib1fv));
				VertexAttrib1s = (Delegates.VertexAttrib1s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1s"), typeof(Delegates.VertexAttrib1s));
				VertexAttrib1sv = (Delegates.VertexAttrib1sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib1sv"), typeof(Delegates.VertexAttrib1sv));
				VertexAttrib2d = (Delegates.VertexAttrib2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2d"), typeof(Delegates.VertexAttrib2d));
				VertexAttrib2dv = (Delegates.VertexAttrib2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2dv"), typeof(Delegates.VertexAttrib2dv));
				VertexAttrib2f = (Delegates.VertexAttrib2f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2f"), typeof(Delegates.VertexAttrib2f));
				VertexAttrib2fv = (Delegates.VertexAttrib2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2fv"), typeof(Delegates.VertexAttrib2fv));
				VertexAttrib2s = (Delegates.VertexAttrib2s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2s"), typeof(Delegates.VertexAttrib2s));
				VertexAttrib2sv = (Delegates.VertexAttrib2sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib2sv"), typeof(Delegates.VertexAttrib2sv));
				VertexAttrib3d = (Delegates.VertexAttrib3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3d"), typeof(Delegates.VertexAttrib3d));
				VertexAttrib3dv = (Delegates.VertexAttrib3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3dv"), typeof(Delegates.VertexAttrib3dv));
				VertexAttrib3f = (Delegates.VertexAttrib3f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3f"), typeof(Delegates.VertexAttrib3f));
				VertexAttrib3fv = (Delegates.VertexAttrib3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3fv"), typeof(Delegates.VertexAttrib3fv));
				VertexAttrib3s = (Delegates.VertexAttrib3s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3s"), typeof(Delegates.VertexAttrib3s));
				VertexAttrib3sv = (Delegates.VertexAttrib3sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib3sv"), typeof(Delegates.VertexAttrib3sv));
				VertexAttrib4Nbv = (Delegates.VertexAttrib4Nbv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nbv"), typeof(Delegates.VertexAttrib4Nbv));
				VertexAttrib4Niv = (Delegates.VertexAttrib4Niv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Niv"), typeof(Delegates.VertexAttrib4Niv));
				VertexAttrib4Nsv = (Delegates.VertexAttrib4Nsv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nsv"), typeof(Delegates.VertexAttrib4Nsv));
				VertexAttrib4Nub = (Delegates.VertexAttrib4Nub)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nub"), typeof(Delegates.VertexAttrib4Nub));
				VertexAttrib4Nubv = (Delegates.VertexAttrib4Nubv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nubv"), typeof(Delegates.VertexAttrib4Nubv));
				VertexAttrib4Nuiv = (Delegates.VertexAttrib4Nuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nuiv"), typeof(Delegates.VertexAttrib4Nuiv));
				VertexAttrib4Nusv = (Delegates.VertexAttrib4Nusv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4Nusv"), typeof(Delegates.VertexAttrib4Nusv));
				VertexAttrib4bv = (Delegates.VertexAttrib4bv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4bv"), typeof(Delegates.VertexAttrib4bv));
				VertexAttrib4d = (Delegates.VertexAttrib4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4d"), typeof(Delegates.VertexAttrib4d));
				VertexAttrib4dv = (Delegates.VertexAttrib4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4dv"), typeof(Delegates.VertexAttrib4dv));
				VertexAttrib4f = (Delegates.VertexAttrib4f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4f"), typeof(Delegates.VertexAttrib4f));
				VertexAttrib4fv = (Delegates.VertexAttrib4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4fv"), typeof(Delegates.VertexAttrib4fv));
				VertexAttrib4iv = (Delegates.VertexAttrib4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4iv"), typeof(Delegates.VertexAttrib4iv));
				VertexAttrib4s = (Delegates.VertexAttrib4s)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4s"), typeof(Delegates.VertexAttrib4s));
				VertexAttrib4sv = (Delegates.VertexAttrib4sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4sv"), typeof(Delegates.VertexAttrib4sv));
				VertexAttrib4ubv = (Delegates.VertexAttrib4ubv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4ubv"), typeof(Delegates.VertexAttrib4ubv));
				VertexAttrib4uiv = (Delegates.VertexAttrib4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4uiv"), typeof(Delegates.VertexAttrib4uiv));
				VertexAttrib4usv = (Delegates.VertexAttrib4usv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttrib4usv"), typeof(Delegates.VertexAttrib4usv));
				VertexAttribPointer = (Delegates.VertexAttribPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribPointer"), typeof(Delegates.VertexAttribPointer));
			}

			if (versionMajor > 2 || (versionMajor == 2 && versionMinor >= 1))
			{
				UniformMatrix2x3fv = (Delegates.UniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x3fv"), typeof(Delegates.UniformMatrix2x3fv));
				UniformMatrix3x2fv = (Delegates.UniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x2fv"), typeof(Delegates.UniformMatrix3x2fv));
				UniformMatrix2x4fv = (Delegates.UniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x4fv"), typeof(Delegates.UniformMatrix2x4fv));
				UniformMatrix4x2fv = (Delegates.UniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x2fv"), typeof(Delegates.UniformMatrix4x2fv));
				UniformMatrix3x4fv = (Delegates.UniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x4fv"), typeof(Delegates.UniformMatrix3x4fv));
				UniformMatrix4x3fv = (Delegates.UniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x3fv"), typeof(Delegates.UniformMatrix4x3fv));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 0))
			{
				ColorMaski = (Delegates.ColorMaski)Marshal.GetDelegateForFunctionPointer(getProcAddress("glColorMaski"), typeof(Delegates.ColorMaski));
				GetBooleani_v = (Delegates.GetBooleani_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBooleani_v"), typeof(Delegates.GetBooleani_v));
				GetIntegeri_v = (Delegates.GetIntegeri_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetIntegeri_v"), typeof(Delegates.GetIntegeri_v));
				Enablei = (Delegates.Enablei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnablei"), typeof(Delegates.Enablei));
				Disablei = (Delegates.Disablei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisablei"), typeof(Delegates.Disablei));
				IsEnabledi = (Delegates.IsEnabledi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsEnabledi"), typeof(Delegates.IsEnabledi));
				BeginTransformFeedback = (Delegates.BeginTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginTransformFeedback"), typeof(Delegates.BeginTransformFeedback));
				EndTransformFeedback = (Delegates.EndTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndTransformFeedback"), typeof(Delegates.EndTransformFeedback));
				BindBufferRange = (Delegates.BindBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBufferRange"), typeof(Delegates.BindBufferRange));
				BindBufferBase = (Delegates.BindBufferBase)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBufferBase"), typeof(Delegates.BindBufferBase));
				TransformFeedbackVaryings = (Delegates.TransformFeedbackVaryings)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTransformFeedbackVaryings"), typeof(Delegates.TransformFeedbackVaryings));
				GetTransformFeedbackVarying = (Delegates.GetTransformFeedbackVarying)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbackVarying"), typeof(Delegates.GetTransformFeedbackVarying));
				ClampColor = (Delegates.ClampColor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClampColor"), typeof(Delegates.ClampColor));
				BeginConditionalRender = (Delegates.BeginConditionalRender)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginConditionalRender"), typeof(Delegates.BeginConditionalRender));
				EndConditionalRender = (Delegates.EndConditionalRender)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndConditionalRender"), typeof(Delegates.EndConditionalRender));
				VertexAttribIPointer = (Delegates.VertexAttribIPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribIPointer"), typeof(Delegates.VertexAttribIPointer));
				GetVertexAttribIiv = (Delegates.GetVertexAttribIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribIiv"), typeof(Delegates.GetVertexAttribIiv));
				GetVertexAttribIuiv = (Delegates.GetVertexAttribIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribIuiv"), typeof(Delegates.GetVertexAttribIuiv));
				VertexAttribI1i = (Delegates.VertexAttribI1i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1i"), typeof(Delegates.VertexAttribI1i));
				VertexAttribI2i = (Delegates.VertexAttribI2i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2i"), typeof(Delegates.VertexAttribI2i));
				VertexAttribI3i = (Delegates.VertexAttribI3i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3i"), typeof(Delegates.VertexAttribI3i));
				VertexAttribI4i = (Delegates.VertexAttribI4i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4i"), typeof(Delegates.VertexAttribI4i));
				VertexAttribI1ui = (Delegates.VertexAttribI1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1ui"), typeof(Delegates.VertexAttribI1ui));
				VertexAttribI2ui = (Delegates.VertexAttribI2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2ui"), typeof(Delegates.VertexAttribI2ui));
				VertexAttribI3ui = (Delegates.VertexAttribI3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3ui"), typeof(Delegates.VertexAttribI3ui));
				VertexAttribI4ui = (Delegates.VertexAttribI4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4ui"), typeof(Delegates.VertexAttribI4ui));
				VertexAttribI1iv = (Delegates.VertexAttribI1iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1iv"), typeof(Delegates.VertexAttribI1iv));
				VertexAttribI2iv = (Delegates.VertexAttribI2iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2iv"), typeof(Delegates.VertexAttribI2iv));
				VertexAttribI3iv = (Delegates.VertexAttribI3iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3iv"), typeof(Delegates.VertexAttribI3iv));
				VertexAttribI4iv = (Delegates.VertexAttribI4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4iv"), typeof(Delegates.VertexAttribI4iv));
				VertexAttribI1uiv = (Delegates.VertexAttribI1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI1uiv"), typeof(Delegates.VertexAttribI1uiv));
				VertexAttribI2uiv = (Delegates.VertexAttribI2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI2uiv"), typeof(Delegates.VertexAttribI2uiv));
				VertexAttribI3uiv = (Delegates.VertexAttribI3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI3uiv"), typeof(Delegates.VertexAttribI3uiv));
				VertexAttribI4uiv = (Delegates.VertexAttribI4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4uiv"), typeof(Delegates.VertexAttribI4uiv));
				VertexAttribI4bv = (Delegates.VertexAttribI4bv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4bv"), typeof(Delegates.VertexAttribI4bv));
				VertexAttribI4sv = (Delegates.VertexAttribI4sv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4sv"), typeof(Delegates.VertexAttribI4sv));
				VertexAttribI4ubv = (Delegates.VertexAttribI4ubv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4ubv"), typeof(Delegates.VertexAttribI4ubv));
				VertexAttribI4usv = (Delegates.VertexAttribI4usv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribI4usv"), typeof(Delegates.VertexAttribI4usv));
				GetUniformuiv = (Delegates.GetUniformuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformuiv"), typeof(Delegates.GetUniformuiv));
				BindFragDataLocation = (Delegates.BindFragDataLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindFragDataLocation"), typeof(Delegates.BindFragDataLocation));
				GetFragDataLocation = (Delegates.GetFragDataLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFragDataLocation"), typeof(Delegates.GetFragDataLocation));
				Uniform1ui = (Delegates.Uniform1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1ui"), typeof(Delegates.Uniform1ui));
				Uniform2ui = (Delegates.Uniform2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2ui"), typeof(Delegates.Uniform2ui));
				Uniform3ui = (Delegates.Uniform3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3ui"), typeof(Delegates.Uniform3ui));
				Uniform4ui = (Delegates.Uniform4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4ui"), typeof(Delegates.Uniform4ui));
				Uniform1uiv = (Delegates.Uniform1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1uiv"), typeof(Delegates.Uniform1uiv));
				Uniform2uiv = (Delegates.Uniform2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2uiv"), typeof(Delegates.Uniform2uiv));
				Uniform3uiv = (Delegates.Uniform3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3uiv"), typeof(Delegates.Uniform3uiv));
				Uniform4uiv = (Delegates.Uniform4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4uiv"), typeof(Delegates.Uniform4uiv));
				TexParameterIiv = (Delegates.TexParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterIiv"), typeof(Delegates.TexParameterIiv));
				TexParameterIuiv = (Delegates.TexParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexParameterIuiv"), typeof(Delegates.TexParameterIuiv));
				GetTexParameterIiv = (Delegates.GetTexParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameterIiv"), typeof(Delegates.GetTexParameterIiv));
				GetTexParameterIuiv = (Delegates.GetTexParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTexParameterIuiv"), typeof(Delegates.GetTexParameterIuiv));
				ClearBufferiv = (Delegates.ClearBufferiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferiv"), typeof(Delegates.ClearBufferiv));
				ClearBufferuiv = (Delegates.ClearBufferuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferuiv"), typeof(Delegates.ClearBufferuiv));
				ClearBufferfv = (Delegates.ClearBufferfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferfv"), typeof(Delegates.ClearBufferfv));
				ClearBufferfi = (Delegates.ClearBufferfi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferfi"), typeof(Delegates.ClearBufferfi));
				GetStringi = (Delegates.GetStringi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetStringi"), typeof(Delegates.GetStringi));
				IsRenderbuffer = (Delegates.IsRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsRenderbuffer"), typeof(Delegates.IsRenderbuffer));
				BindRenderbuffer = (Delegates.BindRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindRenderbuffer"), typeof(Delegates.BindRenderbuffer));
				DeleteRenderbuffers = (Delegates.DeleteRenderbuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteRenderbuffers"), typeof(Delegates.DeleteRenderbuffers));
				GenRenderbuffers = (Delegates.GenRenderbuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenRenderbuffers"), typeof(Delegates.GenRenderbuffers));
				RenderbufferStorage = (Delegates.RenderbufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glRenderbufferStorage"), typeof(Delegates.RenderbufferStorage));
				GetRenderbufferParameteriv = (Delegates.GetRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetRenderbufferParameteriv"), typeof(Delegates.GetRenderbufferParameteriv));
				IsFramebuffer = (Delegates.IsFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsFramebuffer"), typeof(Delegates.IsFramebuffer));
				BindFramebuffer = (Delegates.BindFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindFramebuffer"), typeof(Delegates.BindFramebuffer));
				DeleteFramebuffers = (Delegates.DeleteFramebuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteFramebuffers"), typeof(Delegates.DeleteFramebuffers));
				GenFramebuffers = (Delegates.GenFramebuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenFramebuffers"), typeof(Delegates.GenFramebuffers));
				CheckFramebufferStatus = (Delegates.CheckFramebufferStatus)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCheckFramebufferStatus"), typeof(Delegates.CheckFramebufferStatus));
				FramebufferTexture1D = (Delegates.FramebufferTexture1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture1D"), typeof(Delegates.FramebufferTexture1D));
				FramebufferTexture2D = (Delegates.FramebufferTexture2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture2D"), typeof(Delegates.FramebufferTexture2D));
				FramebufferTexture3D = (Delegates.FramebufferTexture3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture3D"), typeof(Delegates.FramebufferTexture3D));
				FramebufferRenderbuffer = (Delegates.FramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferRenderbuffer"), typeof(Delegates.FramebufferRenderbuffer));
				GetFramebufferAttachmentParameteriv = (Delegates.GetFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFramebufferAttachmentParameteriv"), typeof(Delegates.GetFramebufferAttachmentParameteriv));
				GenerateMipmap = (Delegates.GenerateMipmap)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenerateMipmap"), typeof(Delegates.GenerateMipmap));
				BlitFramebuffer = (Delegates.BlitFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlitFramebuffer"), typeof(Delegates.BlitFramebuffer));
				RenderbufferStorageMultisample = (Delegates.RenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glRenderbufferStorageMultisample"), typeof(Delegates.RenderbufferStorageMultisample));
				FramebufferTextureLayer = (Delegates.FramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTextureLayer"), typeof(Delegates.FramebufferTextureLayer));
				MapBufferRange = (Delegates.MapBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapBufferRange"), typeof(Delegates.MapBufferRange));
				FlushMappedBufferRange = (Delegates.FlushMappedBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFlushMappedBufferRange"), typeof(Delegates.FlushMappedBufferRange));
				BindVertexArray = (Delegates.BindVertexArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindVertexArray"), typeof(Delegates.BindVertexArray));
				DeleteVertexArrays = (Delegates.DeleteVertexArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteVertexArrays"), typeof(Delegates.DeleteVertexArrays));
				GenVertexArrays = (Delegates.GenVertexArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenVertexArrays"), typeof(Delegates.GenVertexArrays));
				IsVertexArray = (Delegates.IsVertexArray)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsVertexArray"), typeof(Delegates.IsVertexArray));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 1))
			{
				DrawArraysInstanced = (Delegates.DrawArraysInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArraysInstanced"), typeof(Delegates.DrawArraysInstanced));
				DrawElementsInstanced = (Delegates.DrawElementsInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstanced"), typeof(Delegates.DrawElementsInstanced));
				TexBuffer = (Delegates.TexBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexBuffer"), typeof(Delegates.TexBuffer));
				PrimitiveRestartIndex = (Delegates.PrimitiveRestartIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPrimitiveRestartIndex"), typeof(Delegates.PrimitiveRestartIndex));
				CopyBufferSubData = (Delegates.CopyBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyBufferSubData"), typeof(Delegates.CopyBufferSubData));
				GetUniformIndices = (Delegates.GetUniformIndices)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformIndices"), typeof(Delegates.GetUniformIndices));
				GetActiveUniformsiv = (Delegates.GetActiveUniformsiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformsiv"), typeof(Delegates.GetActiveUniformsiv));
				GetActiveUniformName = (Delegates.GetActiveUniformName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformName"), typeof(Delegates.GetActiveUniformName));
				GetUniformBlockIndex = (Delegates.GetUniformBlockIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformBlockIndex"), typeof(Delegates.GetUniformBlockIndex));
				GetActiveUniformBlockiv = (Delegates.GetActiveUniformBlockiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformBlockiv"), typeof(Delegates.GetActiveUniformBlockiv));
				GetActiveUniformBlockName = (Delegates.GetActiveUniformBlockName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveUniformBlockName"), typeof(Delegates.GetActiveUniformBlockName));
				UniformBlockBinding = (Delegates.UniformBlockBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformBlockBinding"), typeof(Delegates.UniformBlockBinding));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 2))
			{
				DrawElementsBaseVertex = (Delegates.DrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsBaseVertex"), typeof(Delegates.DrawElementsBaseVertex));
				DrawRangeElementsBaseVertex = (Delegates.DrawRangeElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawRangeElementsBaseVertex"), typeof(Delegates.DrawRangeElementsBaseVertex));
				DrawElementsInstancedBaseVertex = (Delegates.DrawElementsInstancedBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstancedBaseVertex"), typeof(Delegates.DrawElementsInstancedBaseVertex));
				MultiDrawElementsBaseVertex = (Delegates.MultiDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawElementsBaseVertex"), typeof(Delegates.MultiDrawElementsBaseVertex));
				ProvokingVertex = (Delegates.ProvokingVertex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProvokingVertex"), typeof(Delegates.ProvokingVertex));
				FenceSync = (Delegates.FenceSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFenceSync"), typeof(Delegates.FenceSync));
				IsSync = (Delegates.IsSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsSync"), typeof(Delegates.IsSync));
				DeleteSync = (Delegates.DeleteSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteSync"), typeof(Delegates.DeleteSync));
				ClientWaitSync = (Delegates.ClientWaitSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClientWaitSync"), typeof(Delegates.ClientWaitSync));
				WaitSync = (Delegates.WaitSync)Marshal.GetDelegateForFunctionPointer(getProcAddress("glWaitSync"), typeof(Delegates.WaitSync));
				GetInteger64v = (Delegates.GetInteger64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInteger64v"), typeof(Delegates.GetInteger64v));
				GetSynciv = (Delegates.GetSynciv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSynciv"), typeof(Delegates.GetSynciv));
				GetInteger64i_v = (Delegates.GetInteger64i_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInteger64i_v"), typeof(Delegates.GetInteger64i_v));
				GetBufferParameteri64v = (Delegates.GetBufferParameteri64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetBufferParameteri64v"), typeof(Delegates.GetBufferParameteri64v));
				FramebufferTexture = (Delegates.FramebufferTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferTexture"), typeof(Delegates.FramebufferTexture));
				TexImage2DMultisample = (Delegates.TexImage2DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage2DMultisample"), typeof(Delegates.TexImage2DMultisample));
				TexImage3DMultisample = (Delegates.TexImage3DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexImage3DMultisample"), typeof(Delegates.TexImage3DMultisample));
				GetMultisamplefv = (Delegates.GetMultisamplefv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetMultisamplefv"), typeof(Delegates.GetMultisamplefv));
				SampleMaski = (Delegates.SampleMaski)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSampleMaski"), typeof(Delegates.SampleMaski));
			}

			if (versionMajor > 3 || (versionMajor == 3 && versionMinor >= 3))
			{
				BindFragDataLocationIndexed = (Delegates.BindFragDataLocationIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindFragDataLocationIndexed"), typeof(Delegates.BindFragDataLocationIndexed));
				GetFragDataIndex = (Delegates.GetFragDataIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFragDataIndex"), typeof(Delegates.GetFragDataIndex));
				GenSamplers = (Delegates.GenSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenSamplers"), typeof(Delegates.GenSamplers));
				DeleteSamplers = (Delegates.DeleteSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteSamplers"), typeof(Delegates.DeleteSamplers));
				IsSampler = (Delegates.IsSampler)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsSampler"), typeof(Delegates.IsSampler));
				BindSampler = (Delegates.BindSampler)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindSampler"), typeof(Delegates.BindSampler));
				SamplerParameteri = (Delegates.SamplerParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameteri"), typeof(Delegates.SamplerParameteri));
				SamplerParameteriv = (Delegates.SamplerParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameteriv"), typeof(Delegates.SamplerParameteriv));
				SamplerParameterf = (Delegates.SamplerParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterf"), typeof(Delegates.SamplerParameterf));
				SamplerParameterfv = (Delegates.SamplerParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterfv"), typeof(Delegates.SamplerParameterfv));
				SamplerParameterIiv = (Delegates.SamplerParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterIiv"), typeof(Delegates.SamplerParameterIiv));
				SamplerParameterIuiv = (Delegates.SamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glSamplerParameterIuiv"), typeof(Delegates.SamplerParameterIuiv));
				GetSamplerParameteriv = (Delegates.GetSamplerParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameteriv"), typeof(Delegates.GetSamplerParameteriv));
				GetSamplerParameterIiv = (Delegates.GetSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameterIiv"), typeof(Delegates.GetSamplerParameterIiv));
				GetSamplerParameterfv = (Delegates.GetSamplerParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameterfv"), typeof(Delegates.GetSamplerParameterfv));
				GetSamplerParameterIuiv = (Delegates.GetSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSamplerParameterIuiv"), typeof(Delegates.GetSamplerParameterIuiv));
				QueryCounter = (Delegates.QueryCounter)Marshal.GetDelegateForFunctionPointer(getProcAddress("glQueryCounter"), typeof(Delegates.QueryCounter));
				GetQueryObjecti64v = (Delegates.GetQueryObjecti64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjecti64v"), typeof(Delegates.GetQueryObjecti64v));
				GetQueryObjectui64v = (Delegates.GetQueryObjectui64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryObjectui64v"), typeof(Delegates.GetQueryObjectui64v));
				VertexAttribDivisor = (Delegates.VertexAttribDivisor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribDivisor"), typeof(Delegates.VertexAttribDivisor));
				VertexAttribP1ui = (Delegates.VertexAttribP1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP1ui"), typeof(Delegates.VertexAttribP1ui));
				VertexAttribP1uiv = (Delegates.VertexAttribP1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP1uiv"), typeof(Delegates.VertexAttribP1uiv));
				VertexAttribP2ui = (Delegates.VertexAttribP2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP2ui"), typeof(Delegates.VertexAttribP2ui));
				VertexAttribP2uiv = (Delegates.VertexAttribP2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP2uiv"), typeof(Delegates.VertexAttribP2uiv));
				VertexAttribP3ui = (Delegates.VertexAttribP3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP3ui"), typeof(Delegates.VertexAttribP3ui));
				VertexAttribP3uiv = (Delegates.VertexAttribP3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP3uiv"), typeof(Delegates.VertexAttribP3uiv));
				VertexAttribP4ui = (Delegates.VertexAttribP4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP4ui"), typeof(Delegates.VertexAttribP4ui));
				VertexAttribP4uiv = (Delegates.VertexAttribP4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribP4uiv"), typeof(Delegates.VertexAttribP4uiv));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 0))
			{
				MinSampleShading = (Delegates.MinSampleShading)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMinSampleShading"), typeof(Delegates.MinSampleShading));
				BlendEquationi = (Delegates.BlendEquationi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquationi"), typeof(Delegates.BlendEquationi));
				BlendEquationSeparatei = (Delegates.BlendEquationSeparatei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendEquationSeparatei"), typeof(Delegates.BlendEquationSeparatei));
				BlendFunci = (Delegates.BlendFunci)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFunci"), typeof(Delegates.BlendFunci));
				BlendFuncSeparatei = (Delegates.BlendFuncSeparatei)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlendFuncSeparatei"), typeof(Delegates.BlendFuncSeparatei));
				DrawArraysIndirect = (Delegates.DrawArraysIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArraysIndirect"), typeof(Delegates.DrawArraysIndirect));
				DrawElementsIndirect = (Delegates.DrawElementsIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsIndirect"), typeof(Delegates.DrawElementsIndirect));
				Uniform1d = (Delegates.Uniform1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1d"), typeof(Delegates.Uniform1d));
				Uniform2d = (Delegates.Uniform2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2d"), typeof(Delegates.Uniform2d));
				Uniform3d = (Delegates.Uniform3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3d"), typeof(Delegates.Uniform3d));
				Uniform4d = (Delegates.Uniform4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4d"), typeof(Delegates.Uniform4d));
				Uniform1dv = (Delegates.Uniform1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform1dv"), typeof(Delegates.Uniform1dv));
				Uniform2dv = (Delegates.Uniform2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform2dv"), typeof(Delegates.Uniform2dv));
				Uniform3dv = (Delegates.Uniform3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform3dv"), typeof(Delegates.Uniform3dv));
				Uniform4dv = (Delegates.Uniform4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniform4dv"), typeof(Delegates.Uniform4dv));
				UniformMatrix2dv = (Delegates.UniformMatrix2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2dv"), typeof(Delegates.UniformMatrix2dv));
				UniformMatrix3dv = (Delegates.UniformMatrix3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3dv"), typeof(Delegates.UniformMatrix3dv));
				UniformMatrix4dv = (Delegates.UniformMatrix4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4dv"), typeof(Delegates.UniformMatrix4dv));
				UniformMatrix2x3dv = (Delegates.UniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x3dv"), typeof(Delegates.UniformMatrix2x3dv));
				UniformMatrix2x4dv = (Delegates.UniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix2x4dv"), typeof(Delegates.UniformMatrix2x4dv));
				UniformMatrix3x2dv = (Delegates.UniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x2dv"), typeof(Delegates.UniformMatrix3x2dv));
				UniformMatrix3x4dv = (Delegates.UniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix3x4dv"), typeof(Delegates.UniformMatrix3x4dv));
				UniformMatrix4x2dv = (Delegates.UniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x2dv"), typeof(Delegates.UniformMatrix4x2dv));
				UniformMatrix4x3dv = (Delegates.UniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformMatrix4x3dv"), typeof(Delegates.UniformMatrix4x3dv));
				GetUniformdv = (Delegates.GetUniformdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformdv"), typeof(Delegates.GetUniformdv));
				GetSubroutineUniformLocation = (Delegates.GetSubroutineUniformLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSubroutineUniformLocation"), typeof(Delegates.GetSubroutineUniformLocation));
				GetSubroutineIndex = (Delegates.GetSubroutineIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetSubroutineIndex"), typeof(Delegates.GetSubroutineIndex));
				GetActiveSubroutineUniformiv = (Delegates.GetActiveSubroutineUniformiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveSubroutineUniformiv"), typeof(Delegates.GetActiveSubroutineUniformiv));
				GetActiveSubroutineUniformName = (Delegates.GetActiveSubroutineUniformName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveSubroutineUniformName"), typeof(Delegates.GetActiveSubroutineUniformName));
				GetActiveSubroutineName = (Delegates.GetActiveSubroutineName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveSubroutineName"), typeof(Delegates.GetActiveSubroutineName));
				UniformSubroutinesuiv = (Delegates.UniformSubroutinesuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUniformSubroutinesuiv"), typeof(Delegates.UniformSubroutinesuiv));
				GetUniformSubroutineuiv = (Delegates.GetUniformSubroutineuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetUniformSubroutineuiv"), typeof(Delegates.GetUniformSubroutineuiv));
				GetProgramStageiv = (Delegates.GetProgramStageiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramStageiv"), typeof(Delegates.GetProgramStageiv));
				PatchParameteri = (Delegates.PatchParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPatchParameteri"), typeof(Delegates.PatchParameteri));
				PatchParameterfv = (Delegates.PatchParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPatchParameterfv"), typeof(Delegates.PatchParameterfv));
				BindTransformFeedback = (Delegates.BindTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTransformFeedback"), typeof(Delegates.BindTransformFeedback));
				DeleteTransformFeedbacks = (Delegates.DeleteTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteTransformFeedbacks"), typeof(Delegates.DeleteTransformFeedbacks));
				GenTransformFeedbacks = (Delegates.GenTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenTransformFeedbacks"), typeof(Delegates.GenTransformFeedbacks));
				IsTransformFeedback = (Delegates.IsTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsTransformFeedback"), typeof(Delegates.IsTransformFeedback));
				PauseTransformFeedback = (Delegates.PauseTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPauseTransformFeedback"), typeof(Delegates.PauseTransformFeedback));
				ResumeTransformFeedback = (Delegates.ResumeTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glResumeTransformFeedback"), typeof(Delegates.ResumeTransformFeedback));
				DrawTransformFeedback = (Delegates.DrawTransformFeedback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedback"), typeof(Delegates.DrawTransformFeedback));
				DrawTransformFeedbackStream = (Delegates.DrawTransformFeedbackStream)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedbackStream"), typeof(Delegates.DrawTransformFeedbackStream));
				BeginQueryIndexed = (Delegates.BeginQueryIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBeginQueryIndexed"), typeof(Delegates.BeginQueryIndexed));
				EndQueryIndexed = (Delegates.EndQueryIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEndQueryIndexed"), typeof(Delegates.EndQueryIndexed));
				GetQueryIndexediv = (Delegates.GetQueryIndexediv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryIndexediv"), typeof(Delegates.GetQueryIndexediv));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 1))
			{
				ReleaseShaderCompiler = (Delegates.ReleaseShaderCompiler)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReleaseShaderCompiler"), typeof(Delegates.ReleaseShaderCompiler));
				ShaderBinary = (Delegates.ShaderBinary)Marshal.GetDelegateForFunctionPointer(getProcAddress("glShaderBinary"), typeof(Delegates.ShaderBinary));
				GetShaderPrecisionFormat = (Delegates.GetShaderPrecisionFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetShaderPrecisionFormat"), typeof(Delegates.GetShaderPrecisionFormat));
				DepthRangef = (Delegates.DepthRangef)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRangef"), typeof(Delegates.DepthRangef));
				ClearDepthf = (Delegates.ClearDepthf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearDepthf"), typeof(Delegates.ClearDepthf));
				GetProgramBinary = (Delegates.GetProgramBinary)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramBinary"), typeof(Delegates.GetProgramBinary));
				ProgramBinary = (Delegates.ProgramBinary)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramBinary"), typeof(Delegates.ProgramBinary));
				ProgramParameteri = (Delegates.ProgramParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramParameteri"), typeof(Delegates.ProgramParameteri));
				UseProgramStages = (Delegates.UseProgramStages)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUseProgramStages"), typeof(Delegates.UseProgramStages));
				ActiveShaderProgram = (Delegates.ActiveShaderProgram)Marshal.GetDelegateForFunctionPointer(getProcAddress("glActiveShaderProgram"), typeof(Delegates.ActiveShaderProgram));
				CreateShaderProgramv = (Delegates.CreateShaderProgramv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateShaderProgramv"), typeof(Delegates.CreateShaderProgramv));
				BindProgramPipeline = (Delegates.BindProgramPipeline)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindProgramPipeline"), typeof(Delegates.BindProgramPipeline));
				DeleteProgramPipelines = (Delegates.DeleteProgramPipelines)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDeleteProgramPipelines"), typeof(Delegates.DeleteProgramPipelines));
				GenProgramPipelines = (Delegates.GenProgramPipelines)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenProgramPipelines"), typeof(Delegates.GenProgramPipelines));
				IsProgramPipeline = (Delegates.IsProgramPipeline)Marshal.GetDelegateForFunctionPointer(getProcAddress("glIsProgramPipeline"), typeof(Delegates.IsProgramPipeline));
				GetProgramPipelineiv = (Delegates.GetProgramPipelineiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramPipelineiv"), typeof(Delegates.GetProgramPipelineiv));
				ProgramUniform1i = (Delegates.ProgramUniform1i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1i"), typeof(Delegates.ProgramUniform1i));
				ProgramUniform1iv = (Delegates.ProgramUniform1iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1iv"), typeof(Delegates.ProgramUniform1iv));
				ProgramUniform1f = (Delegates.ProgramUniform1f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1f"), typeof(Delegates.ProgramUniform1f));
				ProgramUniform1fv = (Delegates.ProgramUniform1fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1fv"), typeof(Delegates.ProgramUniform1fv));
				ProgramUniform1d = (Delegates.ProgramUniform1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1d"), typeof(Delegates.ProgramUniform1d));
				ProgramUniform1dv = (Delegates.ProgramUniform1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1dv"), typeof(Delegates.ProgramUniform1dv));
				ProgramUniform1ui = (Delegates.ProgramUniform1ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1ui"), typeof(Delegates.ProgramUniform1ui));
				ProgramUniform1uiv = (Delegates.ProgramUniform1uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform1uiv"), typeof(Delegates.ProgramUniform1uiv));
				ProgramUniform2i = (Delegates.ProgramUniform2i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2i"), typeof(Delegates.ProgramUniform2i));
				ProgramUniform2iv = (Delegates.ProgramUniform2iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2iv"), typeof(Delegates.ProgramUniform2iv));
				ProgramUniform2f = (Delegates.ProgramUniform2f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2f"), typeof(Delegates.ProgramUniform2f));
				ProgramUniform2fv = (Delegates.ProgramUniform2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2fv"), typeof(Delegates.ProgramUniform2fv));
				ProgramUniform2d = (Delegates.ProgramUniform2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2d"), typeof(Delegates.ProgramUniform2d));
				ProgramUniform2dv = (Delegates.ProgramUniform2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2dv"), typeof(Delegates.ProgramUniform2dv));
				ProgramUniform2ui = (Delegates.ProgramUniform2ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2ui"), typeof(Delegates.ProgramUniform2ui));
				ProgramUniform2uiv = (Delegates.ProgramUniform2uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform2uiv"), typeof(Delegates.ProgramUniform2uiv));
				ProgramUniform3i = (Delegates.ProgramUniform3i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3i"), typeof(Delegates.ProgramUniform3i));
				ProgramUniform3iv = (Delegates.ProgramUniform3iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3iv"), typeof(Delegates.ProgramUniform3iv));
				ProgramUniform3f = (Delegates.ProgramUniform3f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3f"), typeof(Delegates.ProgramUniform3f));
				ProgramUniform3fv = (Delegates.ProgramUniform3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3fv"), typeof(Delegates.ProgramUniform3fv));
				ProgramUniform3d = (Delegates.ProgramUniform3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3d"), typeof(Delegates.ProgramUniform3d));
				ProgramUniform3dv = (Delegates.ProgramUniform3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3dv"), typeof(Delegates.ProgramUniform3dv));
				ProgramUniform3ui = (Delegates.ProgramUniform3ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3ui"), typeof(Delegates.ProgramUniform3ui));
				ProgramUniform3uiv = (Delegates.ProgramUniform3uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform3uiv"), typeof(Delegates.ProgramUniform3uiv));
				ProgramUniform4i = (Delegates.ProgramUniform4i)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4i"), typeof(Delegates.ProgramUniform4i));
				ProgramUniform4iv = (Delegates.ProgramUniform4iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4iv"), typeof(Delegates.ProgramUniform4iv));
				ProgramUniform4f = (Delegates.ProgramUniform4f)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4f"), typeof(Delegates.ProgramUniform4f));
				ProgramUniform4fv = (Delegates.ProgramUniform4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4fv"), typeof(Delegates.ProgramUniform4fv));
				ProgramUniform4d = (Delegates.ProgramUniform4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4d"), typeof(Delegates.ProgramUniform4d));
				ProgramUniform4dv = (Delegates.ProgramUniform4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4dv"), typeof(Delegates.ProgramUniform4dv));
				ProgramUniform4ui = (Delegates.ProgramUniform4ui)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4ui"), typeof(Delegates.ProgramUniform4ui));
				ProgramUniform4uiv = (Delegates.ProgramUniform4uiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniform4uiv"), typeof(Delegates.ProgramUniform4uiv));
				ProgramUniformMatrix2fv = (Delegates.ProgramUniformMatrix2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2fv"), typeof(Delegates.ProgramUniformMatrix2fv));
				ProgramUniformMatrix3fv = (Delegates.ProgramUniformMatrix3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3fv"), typeof(Delegates.ProgramUniformMatrix3fv));
				ProgramUniformMatrix4fv = (Delegates.ProgramUniformMatrix4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4fv"), typeof(Delegates.ProgramUniformMatrix4fv));
				ProgramUniformMatrix2dv = (Delegates.ProgramUniformMatrix2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2dv"), typeof(Delegates.ProgramUniformMatrix2dv));
				ProgramUniformMatrix3dv = (Delegates.ProgramUniformMatrix3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3dv"), typeof(Delegates.ProgramUniformMatrix3dv));
				ProgramUniformMatrix4dv = (Delegates.ProgramUniformMatrix4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4dv"), typeof(Delegates.ProgramUniformMatrix4dv));
				ProgramUniformMatrix2x3fv = (Delegates.ProgramUniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x3fv"), typeof(Delegates.ProgramUniformMatrix2x3fv));
				ProgramUniformMatrix3x2fv = (Delegates.ProgramUniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x2fv"), typeof(Delegates.ProgramUniformMatrix3x2fv));
				ProgramUniformMatrix2x4fv = (Delegates.ProgramUniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x4fv"), typeof(Delegates.ProgramUniformMatrix2x4fv));
				ProgramUniformMatrix4x2fv = (Delegates.ProgramUniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x2fv"), typeof(Delegates.ProgramUniformMatrix4x2fv));
				ProgramUniformMatrix3x4fv = (Delegates.ProgramUniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x4fv"), typeof(Delegates.ProgramUniformMatrix3x4fv));
				ProgramUniformMatrix4x3fv = (Delegates.ProgramUniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x3fv"), typeof(Delegates.ProgramUniformMatrix4x3fv));
				ProgramUniformMatrix2x3dv = (Delegates.ProgramUniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x3dv"), typeof(Delegates.ProgramUniformMatrix2x3dv));
				ProgramUniformMatrix3x2dv = (Delegates.ProgramUniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x2dv"), typeof(Delegates.ProgramUniformMatrix3x2dv));
				ProgramUniformMatrix2x4dv = (Delegates.ProgramUniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix2x4dv"), typeof(Delegates.ProgramUniformMatrix2x4dv));
				ProgramUniformMatrix4x2dv = (Delegates.ProgramUniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x2dv"), typeof(Delegates.ProgramUniformMatrix4x2dv));
				ProgramUniformMatrix3x4dv = (Delegates.ProgramUniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix3x4dv"), typeof(Delegates.ProgramUniformMatrix3x4dv));
				ProgramUniformMatrix4x3dv = (Delegates.ProgramUniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glProgramUniformMatrix4x3dv"), typeof(Delegates.ProgramUniformMatrix4x3dv));
				ValidateProgramPipeline = (Delegates.ValidateProgramPipeline)Marshal.GetDelegateForFunctionPointer(getProcAddress("glValidateProgramPipeline"), typeof(Delegates.ValidateProgramPipeline));
				GetProgramPipelineInfoLog = (Delegates.GetProgramPipelineInfoLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramPipelineInfoLog"), typeof(Delegates.GetProgramPipelineInfoLog));
				VertexAttribL1d = (Delegates.VertexAttribL1d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL1d"), typeof(Delegates.VertexAttribL1d));
				VertexAttribL2d = (Delegates.VertexAttribL2d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL2d"), typeof(Delegates.VertexAttribL2d));
				VertexAttribL3d = (Delegates.VertexAttribL3d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL3d"), typeof(Delegates.VertexAttribL3d));
				VertexAttribL4d = (Delegates.VertexAttribL4d)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL4d"), typeof(Delegates.VertexAttribL4d));
				VertexAttribL1dv = (Delegates.VertexAttribL1dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL1dv"), typeof(Delegates.VertexAttribL1dv));
				VertexAttribL2dv = (Delegates.VertexAttribL2dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL2dv"), typeof(Delegates.VertexAttribL2dv));
				VertexAttribL3dv = (Delegates.VertexAttribL3dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL3dv"), typeof(Delegates.VertexAttribL3dv));
				VertexAttribL4dv = (Delegates.VertexAttribL4dv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribL4dv"), typeof(Delegates.VertexAttribL4dv));
				VertexAttribLPointer = (Delegates.VertexAttribLPointer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribLPointer"), typeof(Delegates.VertexAttribLPointer));
				GetVertexAttribLdv = (Delegates.GetVertexAttribLdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexAttribLdv"), typeof(Delegates.GetVertexAttribLdv));
				ViewportArrayv = (Delegates.ViewportArrayv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewportArrayv"), typeof(Delegates.ViewportArrayv));
				ViewportIndexedf = (Delegates.ViewportIndexedf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewportIndexedf"), typeof(Delegates.ViewportIndexedf));
				ViewportIndexedfv = (Delegates.ViewportIndexedfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glViewportIndexedfv"), typeof(Delegates.ViewportIndexedfv));
				ScissorArrayv = (Delegates.ScissorArrayv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissorArrayv"), typeof(Delegates.ScissorArrayv));
				ScissorIndexed = (Delegates.ScissorIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissorIndexed"), typeof(Delegates.ScissorIndexed));
				ScissorIndexedv = (Delegates.ScissorIndexedv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glScissorIndexedv"), typeof(Delegates.ScissorIndexedv));
				DepthRangeArrayv = (Delegates.DepthRangeArrayv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRangeArrayv"), typeof(Delegates.DepthRangeArrayv));
				DepthRangeIndexed = (Delegates.DepthRangeIndexed)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDepthRangeIndexed"), typeof(Delegates.DepthRangeIndexed));
				GetFloati_v = (Delegates.GetFloati_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFloati_v"), typeof(Delegates.GetFloati_v));
				GetDoublei_v = (Delegates.GetDoublei_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetDoublei_v"), typeof(Delegates.GetDoublei_v));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 2))
			{
				DrawArraysInstancedBaseInstance = (Delegates.DrawArraysInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawArraysInstancedBaseInstance"), typeof(Delegates.DrawArraysInstancedBaseInstance));
				DrawElementsInstancedBaseInstance = (Delegates.DrawElementsInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstancedBaseInstance"), typeof(Delegates.DrawElementsInstancedBaseInstance));
				DrawElementsInstancedBaseVertexBaseInstance = (Delegates.DrawElementsInstancedBaseVertexBaseInstance)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawElementsInstancedBaseVertexBaseInstance"), typeof(Delegates.DrawElementsInstancedBaseVertexBaseInstance));
				GetInternalformativ = (Delegates.GetInternalformativ)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInternalformativ"), typeof(Delegates.GetInternalformativ));
				GetActiveAtomicCounterBufferiv = (Delegates.GetActiveAtomicCounterBufferiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetActiveAtomicCounterBufferiv"), typeof(Delegates.GetActiveAtomicCounterBufferiv));
				BindImageTexture = (Delegates.BindImageTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindImageTexture"), typeof(Delegates.BindImageTexture));
				MemoryBarrier = (Delegates.MemoryBarrier)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMemoryBarrier"), typeof(Delegates.MemoryBarrier));
				TexStorage1D = (Delegates.TexStorage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage1D"), typeof(Delegates.TexStorage1D));
				TexStorage2D = (Delegates.TexStorage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage2D"), typeof(Delegates.TexStorage2D));
				TexStorage3D = (Delegates.TexStorage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage3D"), typeof(Delegates.TexStorage3D));
				DrawTransformFeedbackInstanced = (Delegates.DrawTransformFeedbackInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedbackInstanced"), typeof(Delegates.DrawTransformFeedbackInstanced));
				DrawTransformFeedbackStreamInstanced = (Delegates.DrawTransformFeedbackStreamInstanced)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDrawTransformFeedbackStreamInstanced"), typeof(Delegates.DrawTransformFeedbackStreamInstanced));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 3))
			{
				ClearBufferData = (Delegates.ClearBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferData"), typeof(Delegates.ClearBufferData));
				ClearBufferSubData = (Delegates.ClearBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearBufferSubData"), typeof(Delegates.ClearBufferSubData));
				DispatchCompute = (Delegates.DispatchCompute)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDispatchCompute"), typeof(Delegates.DispatchCompute));
				DispatchComputeIndirect = (Delegates.DispatchComputeIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDispatchComputeIndirect"), typeof(Delegates.DispatchComputeIndirect));
				CopyImageSubData = (Delegates.CopyImageSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyImageSubData"), typeof(Delegates.CopyImageSubData));
				FramebufferParameteri = (Delegates.FramebufferParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFramebufferParameteri"), typeof(Delegates.FramebufferParameteri));
				GetFramebufferParameteriv = (Delegates.GetFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetFramebufferParameteriv"), typeof(Delegates.GetFramebufferParameteriv));
				GetInternalformati64v = (Delegates.GetInternalformati64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetInternalformati64v"), typeof(Delegates.GetInternalformati64v));
				InvalidateTexSubImage = (Delegates.InvalidateTexSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateTexSubImage"), typeof(Delegates.InvalidateTexSubImage));
				InvalidateTexImage = (Delegates.InvalidateTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateTexImage"), typeof(Delegates.InvalidateTexImage));
				InvalidateBufferSubData = (Delegates.InvalidateBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateBufferSubData"), typeof(Delegates.InvalidateBufferSubData));
				InvalidateBufferData = (Delegates.InvalidateBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateBufferData"), typeof(Delegates.InvalidateBufferData));
				InvalidateFramebuffer = (Delegates.InvalidateFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateFramebuffer"), typeof(Delegates.InvalidateFramebuffer));
				InvalidateSubFramebuffer = (Delegates.InvalidateSubFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateSubFramebuffer"), typeof(Delegates.InvalidateSubFramebuffer));
				MultiDrawArraysIndirect = (Delegates.MultiDrawArraysIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawArraysIndirect"), typeof(Delegates.MultiDrawArraysIndirect));
				MultiDrawElementsIndirect = (Delegates.MultiDrawElementsIndirect)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMultiDrawElementsIndirect"), typeof(Delegates.MultiDrawElementsIndirect));
				GetProgramInterfaceiv = (Delegates.GetProgramInterfaceiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramInterfaceiv"), typeof(Delegates.GetProgramInterfaceiv));
				GetProgramResourceIndex = (Delegates.GetProgramResourceIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceIndex"), typeof(Delegates.GetProgramResourceIndex));
				GetProgramResourceName = (Delegates.GetProgramResourceName)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceName"), typeof(Delegates.GetProgramResourceName));
				GetProgramResourceiv = (Delegates.GetProgramResourceiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceiv"), typeof(Delegates.GetProgramResourceiv));
				GetProgramResourceLocation = (Delegates.GetProgramResourceLocation)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceLocation"), typeof(Delegates.GetProgramResourceLocation));
				GetProgramResourceLocationIndex = (Delegates.GetProgramResourceLocationIndex)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetProgramResourceLocationIndex"), typeof(Delegates.GetProgramResourceLocationIndex));
				ShaderStorageBlockBinding = (Delegates.ShaderStorageBlockBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glShaderStorageBlockBinding"), typeof(Delegates.ShaderStorageBlockBinding));
				TexBufferRange = (Delegates.TexBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexBufferRange"), typeof(Delegates.TexBufferRange));
				TexStorage2DMultisample = (Delegates.TexStorage2DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage2DMultisample"), typeof(Delegates.TexStorage2DMultisample));
				TexStorage3DMultisample = (Delegates.TexStorage3DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTexStorage3DMultisample"), typeof(Delegates.TexStorage3DMultisample));
				TextureView = (Delegates.TextureView)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureView"), typeof(Delegates.TextureView));
				BindVertexBuffer = (Delegates.BindVertexBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindVertexBuffer"), typeof(Delegates.BindVertexBuffer));
				VertexAttribFormat = (Delegates.VertexAttribFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribFormat"), typeof(Delegates.VertexAttribFormat));
				VertexAttribIFormat = (Delegates.VertexAttribIFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribIFormat"), typeof(Delegates.VertexAttribIFormat));
				VertexAttribLFormat = (Delegates.VertexAttribLFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribLFormat"), typeof(Delegates.VertexAttribLFormat));
				VertexAttribBinding = (Delegates.VertexAttribBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexAttribBinding"), typeof(Delegates.VertexAttribBinding));
				VertexBindingDivisor = (Delegates.VertexBindingDivisor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexBindingDivisor"), typeof(Delegates.VertexBindingDivisor));
				DebugMessageControl = (Delegates.DebugMessageControl)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDebugMessageControl"), typeof(Delegates.DebugMessageControl));
				DebugMessageInsert = (Delegates.DebugMessageInsert)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDebugMessageInsert"), typeof(Delegates.DebugMessageInsert));
				DebugMessageCallback = (Delegates.DebugMessageCallback)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDebugMessageCallback"), typeof(Delegates.DebugMessageCallback));
				GetDebugMessageLog = (Delegates.GetDebugMessageLog)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetDebugMessageLog"), typeof(Delegates.GetDebugMessageLog));
				PushDebugGroup = (Delegates.PushDebugGroup)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPushDebugGroup"), typeof(Delegates.PushDebugGroup));
				PopDebugGroup = (Delegates.PopDebugGroup)Marshal.GetDelegateForFunctionPointer(getProcAddress("glPopDebugGroup"), typeof(Delegates.PopDebugGroup));
				ObjectLabel = (Delegates.ObjectLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glObjectLabel"), typeof(Delegates.ObjectLabel));
				GetObjectLabel = (Delegates.GetObjectLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetObjectLabel"), typeof(Delegates.GetObjectLabel));
				ObjectPtrLabel = (Delegates.ObjectPtrLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glObjectPtrLabel"), typeof(Delegates.ObjectPtrLabel));
				GetObjectPtrLabel = (Delegates.GetObjectPtrLabel)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetObjectPtrLabel"), typeof(Delegates.GetObjectPtrLabel));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 4))
			{
				BufferStorage = (Delegates.BufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBufferStorage"), typeof(Delegates.BufferStorage));
				ClearTexImage = (Delegates.ClearTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearTexImage"), typeof(Delegates.ClearTexImage));
				ClearTexSubImage = (Delegates.ClearTexSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearTexSubImage"), typeof(Delegates.ClearTexSubImage));
				BindBuffersBase = (Delegates.BindBuffersBase)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBuffersBase"), typeof(Delegates.BindBuffersBase));
				BindBuffersRange = (Delegates.BindBuffersRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindBuffersRange"), typeof(Delegates.BindBuffersRange));
				BindTextures = (Delegates.BindTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTextures"), typeof(Delegates.BindTextures));
				BindSamplers = (Delegates.BindSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindSamplers"), typeof(Delegates.BindSamplers));
				BindImageTextures = (Delegates.BindImageTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindImageTextures"), typeof(Delegates.BindImageTextures));
				BindVertexBuffers = (Delegates.BindVertexBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindVertexBuffers"), typeof(Delegates.BindVertexBuffers));
			}

			if (versionMajor > 4 || (versionMajor == 4 && versionMinor >= 5))
			{
				ClipControl = (Delegates.ClipControl)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClipControl"), typeof(Delegates.ClipControl));
				CreateTransformFeedbacks = (Delegates.CreateTransformFeedbacks)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateTransformFeedbacks"), typeof(Delegates.CreateTransformFeedbacks));
				TransformFeedbackBufferBase = (Delegates.TransformFeedbackBufferBase)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTransformFeedbackBufferBase"), typeof(Delegates.TransformFeedbackBufferBase));
				TransformFeedbackBufferRange = (Delegates.TransformFeedbackBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTransformFeedbackBufferRange"), typeof(Delegates.TransformFeedbackBufferRange));
				GetTransformFeedbackiv = (Delegates.GetTransformFeedbackiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbackiv"), typeof(Delegates.GetTransformFeedbackiv));
				GetTransformFeedbacki_v = (Delegates.GetTransformFeedbacki_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbacki_v"), typeof(Delegates.GetTransformFeedbacki_v));
				GetTransformFeedbacki64_v = (Delegates.GetTransformFeedbacki64_v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTransformFeedbacki64_v"), typeof(Delegates.GetTransformFeedbacki64_v));
				CreateBuffers = (Delegates.CreateBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateBuffers"), typeof(Delegates.CreateBuffers));
				NamedBufferStorage = (Delegates.NamedBufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedBufferStorage"), typeof(Delegates.NamedBufferStorage));
				NamedBufferData = (Delegates.NamedBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedBufferData"), typeof(Delegates.NamedBufferData));
				NamedBufferSubData = (Delegates.NamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedBufferSubData"), typeof(Delegates.NamedBufferSubData));
				CopyNamedBufferSubData = (Delegates.CopyNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyNamedBufferSubData"), typeof(Delegates.CopyNamedBufferSubData));
				ClearNamedBufferData = (Delegates.ClearNamedBufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedBufferData"), typeof(Delegates.ClearNamedBufferData));
				ClearNamedBufferSubData = (Delegates.ClearNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedBufferSubData"), typeof(Delegates.ClearNamedBufferSubData));
				MapNamedBuffer = (Delegates.MapNamedBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapNamedBuffer"), typeof(Delegates.MapNamedBuffer));
				MapNamedBufferRange = (Delegates.MapNamedBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMapNamedBufferRange"), typeof(Delegates.MapNamedBufferRange));
				UnmapNamedBuffer = (Delegates.UnmapNamedBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glUnmapNamedBuffer"), typeof(Delegates.UnmapNamedBuffer));
				FlushMappedNamedBufferRange = (Delegates.FlushMappedNamedBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glFlushMappedNamedBufferRange"), typeof(Delegates.FlushMappedNamedBufferRange));
				GetNamedBufferParameteriv = (Delegates.GetNamedBufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferParameteriv"), typeof(Delegates.GetNamedBufferParameteriv));
				GetNamedBufferParameteri64v = (Delegates.GetNamedBufferParameteri64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferParameteri64v"), typeof(Delegates.GetNamedBufferParameteri64v));
				GetNamedBufferPointerv = (Delegates.GetNamedBufferPointerv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferPointerv"), typeof(Delegates.GetNamedBufferPointerv));
				GetNamedBufferSubData = (Delegates.GetNamedBufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedBufferSubData"), typeof(Delegates.GetNamedBufferSubData));
				CreateFramebuffers = (Delegates.CreateFramebuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateFramebuffers"), typeof(Delegates.CreateFramebuffers));
				NamedFramebufferRenderbuffer = (Delegates.NamedFramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferRenderbuffer"), typeof(Delegates.NamedFramebufferRenderbuffer));
				NamedFramebufferParameteri = (Delegates.NamedFramebufferParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferParameteri"), typeof(Delegates.NamedFramebufferParameteri));
				NamedFramebufferTexture = (Delegates.NamedFramebufferTexture)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferTexture"), typeof(Delegates.NamedFramebufferTexture));
				NamedFramebufferTextureLayer = (Delegates.NamedFramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferTextureLayer"), typeof(Delegates.NamedFramebufferTextureLayer));
				NamedFramebufferDrawBuffer = (Delegates.NamedFramebufferDrawBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferDrawBuffer"), typeof(Delegates.NamedFramebufferDrawBuffer));
				NamedFramebufferDrawBuffers = (Delegates.NamedFramebufferDrawBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferDrawBuffers"), typeof(Delegates.NamedFramebufferDrawBuffers));
				NamedFramebufferReadBuffer = (Delegates.NamedFramebufferReadBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedFramebufferReadBuffer"), typeof(Delegates.NamedFramebufferReadBuffer));
				InvalidateNamedFramebufferData = (Delegates.InvalidateNamedFramebufferData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateNamedFramebufferData"), typeof(Delegates.InvalidateNamedFramebufferData));
				InvalidateNamedFramebufferSubData = (Delegates.InvalidateNamedFramebufferSubData)Marshal.GetDelegateForFunctionPointer(getProcAddress("glInvalidateNamedFramebufferSubData"), typeof(Delegates.InvalidateNamedFramebufferSubData));
				ClearNamedFramebufferiv = (Delegates.ClearNamedFramebufferiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferiv"), typeof(Delegates.ClearNamedFramebufferiv));
				ClearNamedFramebufferuiv = (Delegates.ClearNamedFramebufferuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferuiv"), typeof(Delegates.ClearNamedFramebufferuiv));
				ClearNamedFramebufferfv = (Delegates.ClearNamedFramebufferfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferfv"), typeof(Delegates.ClearNamedFramebufferfv));
				ClearNamedFramebufferfi = (Delegates.ClearNamedFramebufferfi)Marshal.GetDelegateForFunctionPointer(getProcAddress("glClearNamedFramebufferfi"), typeof(Delegates.ClearNamedFramebufferfi));
				BlitNamedFramebuffer = (Delegates.BlitNamedFramebuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBlitNamedFramebuffer"), typeof(Delegates.BlitNamedFramebuffer));
				CheckNamedFramebufferStatus = (Delegates.CheckNamedFramebufferStatus)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCheckNamedFramebufferStatus"), typeof(Delegates.CheckNamedFramebufferStatus));
				GetNamedFramebufferParameteriv = (Delegates.GetNamedFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedFramebufferParameteriv"), typeof(Delegates.GetNamedFramebufferParameteriv));
				GetNamedFramebufferAttachmentParameteriv = (Delegates.GetNamedFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedFramebufferAttachmentParameteriv"), typeof(Delegates.GetNamedFramebufferAttachmentParameteriv));
				CreateRenderbuffers = (Delegates.CreateRenderbuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateRenderbuffers"), typeof(Delegates.CreateRenderbuffers));
				NamedRenderbufferStorage = (Delegates.NamedRenderbufferStorage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedRenderbufferStorage"), typeof(Delegates.NamedRenderbufferStorage));
				NamedRenderbufferStorageMultisample = (Delegates.NamedRenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glNamedRenderbufferStorageMultisample"), typeof(Delegates.NamedRenderbufferStorageMultisample));
				GetNamedRenderbufferParameteriv = (Delegates.GetNamedRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetNamedRenderbufferParameteriv"), typeof(Delegates.GetNamedRenderbufferParameteriv));
				CreateTextures = (Delegates.CreateTextures)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateTextures"), typeof(Delegates.CreateTextures));
				TextureBuffer = (Delegates.TextureBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureBuffer"), typeof(Delegates.TextureBuffer));
				TextureBufferRange = (Delegates.TextureBufferRange)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureBufferRange"), typeof(Delegates.TextureBufferRange));
				TextureStorage1D = (Delegates.TextureStorage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage1D"), typeof(Delegates.TextureStorage1D));
				TextureStorage2D = (Delegates.TextureStorage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage2D"), typeof(Delegates.TextureStorage2D));
				TextureStorage3D = (Delegates.TextureStorage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage3D"), typeof(Delegates.TextureStorage3D));
				TextureStorage2DMultisample = (Delegates.TextureStorage2DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage2DMultisample"), typeof(Delegates.TextureStorage2DMultisample));
				TextureStorage3DMultisample = (Delegates.TextureStorage3DMultisample)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureStorage3DMultisample"), typeof(Delegates.TextureStorage3DMultisample));
				TextureSubImage1D = (Delegates.TextureSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureSubImage1D"), typeof(Delegates.TextureSubImage1D));
				TextureSubImage2D = (Delegates.TextureSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureSubImage2D"), typeof(Delegates.TextureSubImage2D));
				TextureSubImage3D = (Delegates.TextureSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureSubImage3D"), typeof(Delegates.TextureSubImage3D));
				CompressedTextureSubImage1D = (Delegates.CompressedTextureSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTextureSubImage1D"), typeof(Delegates.CompressedTextureSubImage1D));
				CompressedTextureSubImage2D = (Delegates.CompressedTextureSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTextureSubImage2D"), typeof(Delegates.CompressedTextureSubImage2D));
				CompressedTextureSubImage3D = (Delegates.CompressedTextureSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCompressedTextureSubImage3D"), typeof(Delegates.CompressedTextureSubImage3D));
				CopyTextureSubImage1D = (Delegates.CopyTextureSubImage1D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTextureSubImage1D"), typeof(Delegates.CopyTextureSubImage1D));
				CopyTextureSubImage2D = (Delegates.CopyTextureSubImage2D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTextureSubImage2D"), typeof(Delegates.CopyTextureSubImage2D));
				CopyTextureSubImage3D = (Delegates.CopyTextureSubImage3D)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCopyTextureSubImage3D"), typeof(Delegates.CopyTextureSubImage3D));
				TextureParameterf = (Delegates.TextureParameterf)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterf"), typeof(Delegates.TextureParameterf));
				TextureParameterfv = (Delegates.TextureParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterfv"), typeof(Delegates.TextureParameterfv));
				TextureParameteri = (Delegates.TextureParameteri)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameteri"), typeof(Delegates.TextureParameteri));
				TextureParameterIiv = (Delegates.TextureParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterIiv"), typeof(Delegates.TextureParameterIiv));
				TextureParameterIuiv = (Delegates.TextureParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameterIuiv"), typeof(Delegates.TextureParameterIuiv));
				TextureParameteriv = (Delegates.TextureParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureParameteriv"), typeof(Delegates.TextureParameteriv));
				GenerateTextureMipmap = (Delegates.GenerateTextureMipmap)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGenerateTextureMipmap"), typeof(Delegates.GenerateTextureMipmap));
				BindTextureUnit = (Delegates.BindTextureUnit)Marshal.GetDelegateForFunctionPointer(getProcAddress("glBindTextureUnit"), typeof(Delegates.BindTextureUnit));
				GetTextureImage = (Delegates.GetTextureImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureImage"), typeof(Delegates.GetTextureImage));
				GetCompressedTextureImage = (Delegates.GetCompressedTextureImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetCompressedTextureImage"), typeof(Delegates.GetCompressedTextureImage));
				GetTextureLevelParameterfv = (Delegates.GetTextureLevelParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureLevelParameterfv"), typeof(Delegates.GetTextureLevelParameterfv));
				GetTextureLevelParameteriv = (Delegates.GetTextureLevelParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureLevelParameteriv"), typeof(Delegates.GetTextureLevelParameteriv));
				GetTextureParameterfv = (Delegates.GetTextureParameterfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameterfv"), typeof(Delegates.GetTextureParameterfv));
				GetTextureParameterIiv = (Delegates.GetTextureParameterIiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameterIiv"), typeof(Delegates.GetTextureParameterIiv));
				GetTextureParameterIuiv = (Delegates.GetTextureParameterIuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameterIuiv"), typeof(Delegates.GetTextureParameterIuiv));
				GetTextureParameteriv = (Delegates.GetTextureParameteriv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureParameteriv"), typeof(Delegates.GetTextureParameteriv));
				CreateVertexArrays = (Delegates.CreateVertexArrays)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateVertexArrays"), typeof(Delegates.CreateVertexArrays));
				DisableVertexArrayAttrib = (Delegates.DisableVertexArrayAttrib)Marshal.GetDelegateForFunctionPointer(getProcAddress("glDisableVertexArrayAttrib"), typeof(Delegates.DisableVertexArrayAttrib));
				EnableVertexArrayAttrib = (Delegates.EnableVertexArrayAttrib)Marshal.GetDelegateForFunctionPointer(getProcAddress("glEnableVertexArrayAttrib"), typeof(Delegates.EnableVertexArrayAttrib));
				VertexArrayElementBuffer = (Delegates.VertexArrayElementBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayElementBuffer"), typeof(Delegates.VertexArrayElementBuffer));
				VertexArrayVertexBuffer = (Delegates.VertexArrayVertexBuffer)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayVertexBuffer"), typeof(Delegates.VertexArrayVertexBuffer));
				VertexArrayVertexBuffers = (Delegates.VertexArrayVertexBuffers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayVertexBuffers"), typeof(Delegates.VertexArrayVertexBuffers));
				VertexArrayAttribBinding = (Delegates.VertexArrayAttribBinding)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribBinding"), typeof(Delegates.VertexArrayAttribBinding));
				VertexArrayAttribFormat = (Delegates.VertexArrayAttribFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribFormat"), typeof(Delegates.VertexArrayAttribFormat));
				VertexArrayAttribIFormat = (Delegates.VertexArrayAttribIFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribIFormat"), typeof(Delegates.VertexArrayAttribIFormat));
				VertexArrayAttribLFormat = (Delegates.VertexArrayAttribLFormat)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayAttribLFormat"), typeof(Delegates.VertexArrayAttribLFormat));
				VertexArrayBindingDivisor = (Delegates.VertexArrayBindingDivisor)Marshal.GetDelegateForFunctionPointer(getProcAddress("glVertexArrayBindingDivisor"), typeof(Delegates.VertexArrayBindingDivisor));
				GetVertexArrayiv = (Delegates.GetVertexArrayiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexArrayiv"), typeof(Delegates.GetVertexArrayiv));
				GetVertexArrayIndexediv = (Delegates.GetVertexArrayIndexediv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexArrayIndexediv"), typeof(Delegates.GetVertexArrayIndexediv));
				GetVertexArrayIndexed64iv = (Delegates.GetVertexArrayIndexed64iv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetVertexArrayIndexed64iv"), typeof(Delegates.GetVertexArrayIndexed64iv));
				CreateSamplers = (Delegates.CreateSamplers)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateSamplers"), typeof(Delegates.CreateSamplers));
				CreateProgramPipelines = (Delegates.CreateProgramPipelines)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateProgramPipelines"), typeof(Delegates.CreateProgramPipelines));
				CreateQueries = (Delegates.CreateQueries)Marshal.GetDelegateForFunctionPointer(getProcAddress("glCreateQueries"), typeof(Delegates.CreateQueries));
				GetQueryBufferObjecti64v = (Delegates.GetQueryBufferObjecti64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjecti64v"), typeof(Delegates.GetQueryBufferObjecti64v));
				GetQueryBufferObjectiv = (Delegates.GetQueryBufferObjectiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjectiv"), typeof(Delegates.GetQueryBufferObjectiv));
				GetQueryBufferObjectui64v = (Delegates.GetQueryBufferObjectui64v)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjectui64v"), typeof(Delegates.GetQueryBufferObjectui64v));
				GetQueryBufferObjectuiv = (Delegates.GetQueryBufferObjectuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetQueryBufferObjectuiv"), typeof(Delegates.GetQueryBufferObjectuiv));
				MemoryBarrierByRegion = (Delegates.MemoryBarrierByRegion)Marshal.GetDelegateForFunctionPointer(getProcAddress("glMemoryBarrierByRegion"), typeof(Delegates.MemoryBarrierByRegion));
				GetTextureSubImage = (Delegates.GetTextureSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetTextureSubImage"), typeof(Delegates.GetTextureSubImage));
				GetCompressedTextureSubImage = (Delegates.GetCompressedTextureSubImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetCompressedTextureSubImage"), typeof(Delegates.GetCompressedTextureSubImage));
				GetGraphicsResetStatus = (Delegates.GetGraphicsResetStatus)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetGraphicsResetStatus"), typeof(Delegates.GetGraphicsResetStatus));
				GetnCompressedTexImage = (Delegates.GetnCompressedTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnCompressedTexImage"), typeof(Delegates.GetnCompressedTexImage));
				GetnTexImage = (Delegates.GetnTexImage)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnTexImage"), typeof(Delegates.GetnTexImage));
				GetnUniformdv = (Delegates.GetnUniformdv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformdv"), typeof(Delegates.GetnUniformdv));
				GetnUniformfv = (Delegates.GetnUniformfv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformfv"), typeof(Delegates.GetnUniformfv));
				GetnUniformiv = (Delegates.GetnUniformiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformiv"), typeof(Delegates.GetnUniformiv));
				GetnUniformuiv = (Delegates.GetnUniformuiv)Marshal.GetDelegateForFunctionPointer(getProcAddress("glGetnUniformuiv"), typeof(Delegates.GetnUniformuiv));
				ReadnPixels = (Delegates.ReadnPixels)Marshal.GetDelegateForFunctionPointer(getProcAddress("glReadnPixels"), typeof(Delegates.ReadnPixels));
				TextureBarrier = (Delegates.TextureBarrier)Marshal.GetDelegateForFunctionPointer(getProcAddress("glTextureBarrier"), typeof(Delegates.TextureBarrier));
			}
		}
	}
}
