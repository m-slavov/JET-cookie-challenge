module.exports = {
    devServer: {
      proxy: {
        '^/api': {
          target: 'http://jetcookies:5000',
          changeOrigin: true
        },
      }
    }
  }