/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

// source: swig\otapi\OTAPI.i

#ifndef SWIG_otapi_WRAP_H_
#define SWIG_otapi_WRAP_H_

class SwigDirector_OTNameLookup : public OTNameLookup
{
 public:
  SwigDirector_OTNameLookup(void *swig_p);
  virtual ~SwigDirector_OTNameLookup();
  std::string _swig_upcall_GetNymName__SWIG_0(std::string const &str_id, std::string const *p_server_id) const {
    return OTNameLookup::GetNymName(str_id,p_server_id);
  }
  virtual std::string GetNymName(std::string const &str_id, std::string const *p_server_id) const;
  std::string _swig_upcall_GetNymName__SWIG_1(std::string const &str_id) const {
    return OTNameLookup::GetNymName(str_id);
  }
  virtual std::string GetNymName(std::string const &str_id) const;
  std::string _swig_upcall_GetAcctName__SWIG_0(std::string const &str_id, std::string const *p_nym_id, std::string const *p_server_id, std::string const *p_asset_id) const {
    return OTNameLookup::GetAcctName(str_id,p_nym_id,p_server_id,p_asset_id);
  }
  virtual std::string GetAcctName(std::string const &str_id, std::string const *p_nym_id, std::string const *p_server_id, std::string const *p_asset_id) const;
  std::string _swig_upcall_GetAcctName__SWIG_1(std::string const &str_id, std::string const *p_nym_id, std::string const *p_server_id) const {
    return OTNameLookup::GetAcctName(str_id,p_nym_id,p_server_id);
  }
  virtual std::string GetAcctName(std::string const &str_id, std::string const *p_nym_id, std::string const *p_server_id) const;
  std::string _swig_upcall_GetAcctName__SWIG_2(std::string const &str_id, std::string const *p_nym_id) const {
    return OTNameLookup::GetAcctName(str_id,p_nym_id);
  }
  virtual std::string GetAcctName(std::string const &str_id, std::string const *p_nym_id) const;
  std::string _swig_upcall_GetAcctName__SWIG_3(std::string const &str_id) const {
    return OTNameLookup::GetAcctName(str_id);
  }
  virtual std::string GetAcctName(std::string const &str_id) const;
 private:
  void *go_val;
};

#endif
