#!/bin/bash

#ls -la /home/vscode
#
## Import public keys
#gpg --import /workspaces/${1}/tmp/pubkeys.gpg
#
## Set ultimate trust level on only the keys we just imported
#FINGERPRINTS=$(gpg --with-colons --with-fingerprint --show-keys /workspaces/${1}/tmp/pubkeys.gpg \
#  | grep '^fpr' \
#  | cut -d: -f10)
#
#echo "$FINGERPRINTS" \
#  | xargs -I{} echo "{}:6" \
#  | gpg --import-ownertrust
#  
#FINGERPRINT=$(echo "$FINGERPRINTS" | head -1)
#
## Set git to use the key
#git config --global user.signingkey $FINGERPRINT
#
## Remove tmp files
#rm -r /workspaces/${1}/tmp
#git config --global commit.gpgsign true
#
## Use gpg agent socket from host
#echo "no-autostart" > ~/.gnupg/common.conf
#gpgconf --kill gpg-agent

# Restore .NET dependencies
#dotnet restore