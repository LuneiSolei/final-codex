#!/bin/bash

mkdir -p ${1}/tmp
gpg --export > ${1}/tmp/pubkeys.gpg