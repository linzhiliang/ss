/* This file is generated by tdr. */
/* No manual modification is permitted. */

/* metalib version: 101 */
/* metalib md5sum: f8305675cf6b3330d5923f3f17b6f7be */

/* creation time: Thu Aug 18 18:14:29 2016 */
/* tdr version: 2.7.12, build at 20151212 */


using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using tsf4g_tdr_csharp;

namespace GSProtocal
{


public class MACROS_GSPROTOCAL_ERROR
{

 /* macros in macrogroup GSErrCode */
 public const int K_ERR_PROTOCOL_ERROR = -9999; // 客户端协议过期，请更新版本
 public const int K_ERR_LACK_RESOURCE = -43; // 缺少资源
 public const int K_ERR_EQUIP_LV_LIMIT = -42; // 等级限制
 public const int K_ERR_ITEM_CANNOT_USE = -41; // 道具不能主动使用
 public const int K_ERR_HERO_LV_LIMIT = -40; // 英雄等级不足
 public const int K_ERR_LACK_LP = -39; // 缺少体力
 public const int K_ERR_LACK_ITEM = -38; // 缺少道具
 public const int K_ERR_LACK_COIN = -37; // 缺少钢币
 public const int K_ERR_LACK_GOLD = -36; // 缺少金币
 public const int K_ERR_LACK_DIAMOND = -35; // 缺少钻石
 public const int K_ERR_PAY_FAILED = -34; // 支付失败
 public const int K_ERR_TIME_ERR = -29; // 不在正确的时间内
 public const int K_ERR_USER_IN_WRONG_SVR = -28; // 用户不被允许登录此服务器(错误的服务器)
 public const int K_ERR_DAY_REGISTER_QUOTA = -27; // 服务器日注册名额已用完
 public const int K_ERR_BAN_REWARD = -26; // 账号禁闭,进入零收益状态
 public const int K_ERR_BAN_TALK = -25; // 禁言
 public const int K_ERR_TALK_TOO_FAST = -24; // 聊天太快
 public const int K_ERR_PAY_OP_FREQUENCY = -23; // 支付请求正在处理，请勿重复操作
 public const int K_ERR_USER_BAN = -22; // 封号
 public const int K_ERR_USER_IN_BLACK = -21; // 用户不被允许登录此服务器(在黑名单)
 public const int K_ERR_USER_NOT_IN_WHITE = -20; // 用户未激活(不在白名单)
 public const int K_ERR_HERO_NAME_EXIST = -19; // 角色名已经被使用
 public const int K_ERR_BAD_NAME = -17; // 不合法的名字
 public const int K_ERR_BAD_STR_LEN = -16; // 字符串长度不合法
 public const int K_ERR_WRONG_OS = -15; // 手机操作系统类型不匹配
 public const int K_ERR_BAN_CREATE_ROLE = -14; // 服务器禁止注册新用户
 public const int K_ERR_LOST_CON = -13; // 您已经从其他地方登陆，与服务器的连接断开
 public const int K_ERR_SYS_SHUTDOWN = -12; // 系统已经关闭
 public const int K_ERR_OVERLOAD_LIMIT = -11; // 系统负载过高，请稍后再试
 public const int K_ERR_OP_FREQUENCY = -10; // 系统已在处理您的请求，请勿频繁操作
 public const int K_ERR_ROLE_EXCEED = -9; // 超过服务器角色数量限制
 public const int K_ERR_FATAL_FAILURE = -8; // 服务器内部致命错误
 public const int K_ERR_LOGIN_INVALID_NO_HERO = -7; // 登陆已失效，未完成选角色
 public const int K_ERR_LOGIN_INVALID = -6; // 登陆已失效，未登陆游戏内账号
 public const int K_ERR_DB_ACCESS_ERROR = -5; // 数据库访问错误
 public const int K_ERR_INNER_ERROR = -4; // 内部错误
 public const int K_ERR_PARA_ERROR = -3; // 参数不合法
 public const int K_ERR_UNKNOWN_REQUEST = -2; // 未知的请求类型
 public const int K_ERR_BAD_PACKAGE = -1; // 不合法的数据包
}


public enum  GSErrCode
{
 K_ERR_PROTOCOL_ERROR = -9999, // 客户端协议过期，请更新版本
 K_ERR_LACK_RESOURCE = -43, // 缺少资源
 K_ERR_EQUIP_LV_LIMIT = -42, // 等级限制
 K_ERR_ITEM_CANNOT_USE = -41, // 道具不能主动使用
 K_ERR_HERO_LV_LIMIT = -40, // 英雄等级不足
 K_ERR_LACK_LP = -39, // 缺少体力
 K_ERR_LACK_ITEM = -38, // 缺少道具
 K_ERR_LACK_COIN = -37, // 缺少钢币
 K_ERR_LACK_GOLD = -36, // 缺少金币
 K_ERR_LACK_DIAMOND = -35, // 缺少钻石
 K_ERR_PAY_FAILED = -34, // 支付失败
 K_ERR_TIME_ERR = -29, // 不在正确的时间内
 K_ERR_USER_IN_WRONG_SVR = -28, // 用户不被允许登录此服务器(错误的服务器)
 K_ERR_DAY_REGISTER_QUOTA = -27, // 服务器日注册名额已用完
 K_ERR_BAN_REWARD = -26, // 账号禁闭,进入零收益状态
 K_ERR_BAN_TALK = -25, // 禁言
 K_ERR_TALK_TOO_FAST = -24, // 聊天太快
 K_ERR_PAY_OP_FREQUENCY = -23, // 支付请求正在处理，请勿重复操作
 K_ERR_USER_BAN = -22, // 封号
 K_ERR_USER_IN_BLACK = -21, // 用户不被允许登录此服务器(在黑名单)
 K_ERR_USER_NOT_IN_WHITE = -20, // 用户未激活(不在白名单)
 K_ERR_HERO_NAME_EXIST = -19, // 角色名已经被使用
 K_ERR_BAD_NAME = -17, // 不合法的名字
 K_ERR_BAD_STR_LEN = -16, // 字符串长度不合法
 K_ERR_WRONG_OS = -15, // 手机操作系统类型不匹配
 K_ERR_BAN_CREATE_ROLE = -14, // 服务器禁止注册新用户
 K_ERR_LOST_CON = -13, // 您已经从其他地方登陆，与服务器的连接断开
 K_ERR_SYS_SHUTDOWN = -12, // 系统已经关闭
 K_ERR_OVERLOAD_LIMIT = -11, // 系统负载过高，请稍后再试
 K_ERR_OP_FREQUENCY = -10, // 系统已在处理您的请求，请勿频繁操作
 K_ERR_ROLE_EXCEED = -9, // 超过服务器角色数量限制
 K_ERR_FATAL_FAILURE = -8, // 服务器内部致命错误
 K_ERR_LOGIN_INVALID_NO_HERO = -7, // 登陆已失效，未完成选角色
 K_ERR_LOGIN_INVALID = -6, // 登陆已失效，未登陆游戏内账号
 K_ERR_DB_ACCESS_ERROR = -5, // 数据库访问错误
 K_ERR_INNER_ERROR = -4, // 内部错误
 K_ERR_PARA_ERROR = -3, // 参数不合法
 K_ERR_UNKNOWN_REQUEST = -2, // 未知的请求类型
 K_ERR_BAD_PACKAGE = -1, // 不合法的数据包
}


}