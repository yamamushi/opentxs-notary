/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_otapi_WRAP_H_
#define SWIG_otapi_WRAP_H_

#include <map>
#include <string>


class SwigDirector_OTNameLookup : public OTNameLookup, public Swig::Director {

public:
    SwigDirector_OTNameLookup(SV *self);
    virtual ~SwigDirector_OTNameLookup();
    virtual std::string GetNymName(std::string const &str_id, std::string const *p_server_id = NULL) const;
    virtual std::string GetAcctName(std::string const &str_id, std::string const *p_nym_id = NULL, std::string const *p_server_id = NULL, std::string const *p_asset_id = NULL) const;

/* Internal director utilities */
public:
    bool swig_get_inner(const char *swig_protected_method_name) const {
      std::map<std::string, bool>::const_iterator iv = swig_inner.find(swig_protected_method_name);
      return (iv != swig_inner.end() ? iv->second : false);
    }
    void swig_set_inner(const char *swig_protected_method_name, bool val) const {
      swig_inner[swig_protected_method_name] = val;
    }
private:
    mutable std::map<std::string, bool> swig_inner;
};

#endif
